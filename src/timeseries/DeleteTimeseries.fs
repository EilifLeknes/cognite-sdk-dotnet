namespace Fusion

open System.IO
open System.Net.Http
open System.Runtime.CompilerServices
open System.Threading.Tasks

open FSharp.Control.Tasks.V2
open Thoth.Json.Net

open Fusion
open Fusion.Api
open Fusion.Common

[<RequireQualifiedAccess>]
module DeleteTimeseries =
    [<Literal>]
    let Url = "/timeseries/delete"

    /// Used for retrieving multiple time series
    type DeleteRequest = {
        /// Sequence of items to retrieve
        Items: seq<Identity>
    } with
        member this.Encoder =
            Encode.object [
                yield ("items", Seq.map (fun (it: Identity) -> it.Encoder) this.Items |> Encode.seq)
            ]

    let deleteTimeseries (items: Identity seq) (fetch: HttpHandler<HttpResponseMessage, Stream, unit>) =
        let request : DeleteRequest = { Items = items }

        POST
        >=> setVersion V10
        >=> setBody request.Encoder
        >=> setResource Url
        >=> fetch
        >=> dispose

[<AutoOpen>]
module DeleteTimeseriesApi =
    /// **Description**
    ///
    /// Deletes a time series object given the name of the time series.
    ///
    /// **Parameters**
    ///   * `name` - The name of the timeseries to delete.
    ///   * `ctx` - The request HTTP context to use.
    ///
    /// **Output Type**
    ///   * `Async<Result<HttpResponse,ResponseError>>`
    ///
    let deleteTimeseries (items: Identity seq) (next: NextHandler<unit, unit>) =
        DeleteTimeseries.deleteTimeseries items fetch next

    let deleteTimeseriesAsync (items: Identity seq) =
        DeleteTimeseries.deleteTimeseries items fetch Async.single

[<Extension>]
type DeleteTimeseriesExtensions =
    /// <summary>
    /// Delete timeseries.
    /// </summary>
    /// <param name="name">The name of the timeseries to delete.</param>
    /// <returns>List of created timeseries.</returns>
    [<Extension>]
    static member DeleteTimeseriesAsync (this: Client) (items: Identity seq) : Task =
        task {
            let! ctx = deleteTimeseriesAsync items this.Ctx
            match ctx.Result with
            | Ok _ -> return ()
            | Error error ->
                let err = error2Exception error
                return raise err
        } :> Task
