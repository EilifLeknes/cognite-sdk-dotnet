﻿namespace Fusion

open System
open System.IO
open System.Net.Http
open System.Runtime.CompilerServices
open System.Threading.Tasks

open FSharp.Control.Tasks.V2
open Thoth.Json.Net

open Fusion
open Fusion.Api
open Fusion.Common
open Fusion.Timeseries

[<RequireQualifiedAccess>]
module GetLatestDataPoint =
    [<Literal>]
    let Url = "/timeseries/data/latest"

    type LatestDataPointRequest = {
        Before: string option
        Identity: Identity
    } with
        member this.Encoder =
            Encode.object [
                if this.Before.IsSome then
                    yield "before", Encode.string this.Before.Value
                match this.Identity with
                | CaseId id -> yield "id", Encode.int53 id
                | CaseExternalId id -> yield "externalId", Encode.string id
            ]

    type LatestDataPointsRequest = {
        Items: seq<LatestDataPointRequest>
    } with
        member this.Encoder =
            Encode.object [
                yield ("items", Seq.map (fun (it: LatestDataPointRequest) -> it.Encoder) this.Items |> Encode.seq)
            ]

    type DataPointsPoco = {
        Id: int64
        ExternalId: string
        IsString: bool
        NumericDataPoints: seq<NumericDataPointDto>
        StringDataPoints: seq<StringDataPointDto>
    }

    type DataPoints = {
        Id: int64
        ExternalId: string option
        IsString: bool
        DataPoints: DataPointSeq
    } with
        static member Decoder : Decoder<DataPoints> =
            Decode.object (fun get ->
                let isString = get.Required.Field "isString" Decode.bool
                let dataPoints =
                    if isString then
                        get.Required.Field "datapoints" (Decode.list StringDataPointDto.Decoder) |> List.toSeq |> String
                    else
                        get.Required.Field "datapoints" (Decode.list NumericDataPointDto.Decoder) |> List.toSeq |> Numeric
                {
                    Id = get.Required.Field "id" Decode.int64
                    ExternalId = get.Optional.Field "externalId" Decode.string
                    IsString = isString
                    DataPoints = dataPoints
                })
        static member ToPoco (item : DataPoints) : DataPointsPoco =
            let stringDataPoints, numericDataPoints =
                match item.DataPoints with
                | String data -> data, Seq.empty
                | Numeric data -> Seq.empty, data
            {
                Id = item.Id
                ExternalId = if item.ExternalId.IsSome then item.ExternalId.Value else Unchecked.defaultof<string>
                IsString = item.IsString
                NumericDataPoints = numericDataPoints
                StringDataPoints = stringDataPoints
            }

    type DataResponse = {
        Items: DataPoints seq
    } with
        static member Decoder : Decoder<DataResponse> =
            Decode.object (fun get ->
                {
                    Items = get.Required.Field "items" (Decode.list DataPoints.Decoder)
                })

    let getLatestDataPoint (options: LatestDataPointRequest seq) (fetch: HttpHandler<HttpResponseMessage, Stream, 'a>) =
        let decoder = decodeResponse DataResponse.Decoder (fun res -> res.Items)
        let request : LatestDataPointsRequest = { Items = options }

        POST
        >=> setVersion V10
        >=> setResource Url
        >=> setContent (Content.JsonValue request.Encoder)
        >=> fetch
        >=> decoder

[<AutoOpen>]
module GetLatestDataPointApi =
    /// **Description**
    ///
    /// Retrieves the single latest data point in a time series.
    ///
    /// **Parameters**
    ///   * `queryParams` - parameter of type `seq<QueryLatestParam>`
    ///   * `ctx` - parameter of type `HttpContext`
    ///
    /// **Output Type**
    ///   * `Async<Context<seq<PointResponseDataPoints>>>`
    ///
    let getLatestDataPoint (queryParams: GetLatestDataPoint.LatestDataPointRequest seq) (next: NextHandler<GetLatestDataPoint.DataPoints seq,'a>) =
        GetLatestDataPoint.getLatestDataPoint queryParams fetch next


    let getLatestDataPointAsync (queryParams: GetLatestDataPoint.LatestDataPointRequest seq) =
        GetLatestDataPoint.getLatestDataPoint queryParams fetch Async.single


[<Extension>]
type GetLatestDataPointExtensions =
    /// <summary>
    /// Retrieves the single latest data point in a time series.
    /// </summary>
    /// <param name="queryParams">Instance of QueryDataLatest object with query parameters.</param>
    /// <param name="client">The list of data points to insert.</param>
    /// <returns>Http status code.</returns>
    [<Extension>]
    static member GetLatestDataPointAsync (this: Client) (options: ValueTuple<Identity, string> seq) : Task<seq<GetLatestDataPoint.DataPointsPoco>> =
        task {
            let query = options |> Seq.map (fun struct (id, before) ->
                { Identity = id;
                  Before = if (isNull before) then None else Some before
                  } : GetLatestDataPoint.LatestDataPointRequest)
            let! ctx = getLatestDataPointAsync query this.Ctx
            match ctx.Result with
            | Ok response ->
                return response |> Seq.map (GetLatestDataPoint.DataPoints.ToPoco)
            | Error error ->
                let err = error2Exception error
                return raise err
        }

