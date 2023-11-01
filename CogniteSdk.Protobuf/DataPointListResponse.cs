// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: data_point_list_response.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Cognite.V1.Timeseries.Proto {

  /// <summary>Holder for reflection information generated from data_point_list_response.proto</summary>
  public static partial class DataPointListResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for data_point_list_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataPointListResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5kYXRhX3BvaW50X2xpc3RfcmVzcG9uc2UucHJvdG8SH2NvbS5jb2duaXRl",
            "LnYxLnRpbWVzZXJpZXMucHJvdG8aEWRhdGFfcG9pbnRzLnByb3RvIpUDChFE",
            "YXRhUG9pbnRMaXN0SXRlbRIKCgJpZBgBIAEoAxISCgpleHRlcm5hbElkGAIg",
            "ASgJEhAKCGlzU3RyaW5nGAYgASgIEg4KBmlzU3RlcBgHIAEoCBIMCgR1bml0",
            "GAggASgJEhIKCm5leHRDdXJzb3IYCSABKAkSFgoOdW5pdEV4dGVybmFsSWQY",
            "CiABKAkSTwoRbnVtZXJpY0RhdGFwb2ludHMYAyABKAsyMi5jb20uY29nbml0",
            "ZS52MS50aW1lc2VyaWVzLnByb3RvLk51bWVyaWNEYXRhcG9pbnRzSAASTQoQ",
            "c3RyaW5nRGF0YXBvaW50cxgEIAEoCzIxLmNvbS5jb2duaXRlLnYxLnRpbWVz",
            "ZXJpZXMucHJvdG8uU3RyaW5nRGF0YXBvaW50c0gAElMKE2FnZ3JlZ2F0ZURh",
            "dGFwb2ludHMYBSABKAsyNC5jb20uY29nbml0ZS52MS50aW1lc2VyaWVzLnBy",
            "b3RvLkFnZ3JlZ2F0ZURhdGFwb2ludHNIAEIPCg1kYXRhcG9pbnRUeXBlIloK",
            "FURhdGFQb2ludExpc3RSZXNwb25zZRJBCgVpdGVtcxgBIAMoCzIyLmNvbS5j",
            "b2duaXRlLnYxLnRpbWVzZXJpZXMucHJvdG8uRGF0YVBvaW50TGlzdEl0ZW1C",
            "AlABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Com.Cognite.V1.Timeseries.Proto.DataPointsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem), global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem.Parser, new[]{ "Id", "ExternalId", "IsString", "IsStep", "Unit", "NextCursor", "UnitExternalId", "NumericDatapoints", "StringDatapoints", "AggregateDatapoints" }, new[]{ "DatapointType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Cognite.V1.Timeseries.Proto.DataPointListResponse), global::Com.Cognite.V1.Timeseries.Proto.DataPointListResponse.Parser, new[]{ "Items" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DataPointListItem : pb::IMessage<DataPointListItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataPointListItem> _parser = new pb::MessageParser<DataPointListItem>(() => new DataPointListItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataPointListItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Cognite.V1.Timeseries.Proto.DataPointListResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataPointListItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataPointListItem(DataPointListItem other) : this() {
      id_ = other.id_;
      externalId_ = other.externalId_;
      isString_ = other.isString_;
      isStep_ = other.isStep_;
      unit_ = other.unit_;
      nextCursor_ = other.nextCursor_;
      unitExternalId_ = other.unitExternalId_;
      switch (other.DatapointTypeCase) {
        case DatapointTypeOneofCase.NumericDatapoints:
          NumericDatapoints = other.NumericDatapoints.Clone();
          break;
        case DatapointTypeOneofCase.StringDatapoints:
          StringDatapoints = other.StringDatapoints.Clone();
          break;
        case DatapointTypeOneofCase.AggregateDatapoints:
          AggregateDatapoints = other.AggregateDatapoints.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataPointListItem Clone() {
      return new DataPointListItem(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "externalId" field.</summary>
    public const int ExternalIdFieldNumber = 2;
    private string externalId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExternalId {
      get { return externalId_; }
      set {
        externalId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "isString" field.</summary>
    public const int IsStringFieldNumber = 6;
    private bool isString_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsString {
      get { return isString_; }
      set {
        isString_ = value;
      }
    }

    /// <summary>Field number for the "isStep" field.</summary>
    public const int IsStepFieldNumber = 7;
    private bool isStep_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStep {
      get { return isStep_; }
      set {
        isStep_ = value;
      }
    }

    /// <summary>Field number for the "unit" field.</summary>
    public const int UnitFieldNumber = 8;
    private string unit_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unit {
      get { return unit_; }
      set {
        unit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nextCursor" field.</summary>
    public const int NextCursorFieldNumber = 9;
    private string nextCursor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NextCursor {
      get { return nextCursor_; }
      set {
        nextCursor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unitExternalId" field.</summary>
    public const int UnitExternalIdFieldNumber = 10;
    private string unitExternalId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UnitExternalId {
      get { return unitExternalId_; }
      set {
        unitExternalId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "numericDatapoints" field.</summary>
    public const int NumericDatapointsFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints NumericDatapoints {
      get { return datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints ? (global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints) datapointType_ : null; }
      set {
        datapointType_ = value;
        datapointTypeCase_ = value == null ? DatapointTypeOneofCase.None : DatapointTypeOneofCase.NumericDatapoints;
      }
    }

    /// <summary>Field number for the "stringDatapoints" field.</summary>
    public const int StringDatapointsFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints StringDatapoints {
      get { return datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints ? (global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints) datapointType_ : null; }
      set {
        datapointType_ = value;
        datapointTypeCase_ = value == null ? DatapointTypeOneofCase.None : DatapointTypeOneofCase.StringDatapoints;
      }
    }

    /// <summary>Field number for the "aggregateDatapoints" field.</summary>
    public const int AggregateDatapointsFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints AggregateDatapoints {
      get { return datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints ? (global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints) datapointType_ : null; }
      set {
        datapointType_ = value;
        datapointTypeCase_ = value == null ? DatapointTypeOneofCase.None : DatapointTypeOneofCase.AggregateDatapoints;
      }
    }

    private object datapointType_;
    /// <summary>Enum of possible cases for the "datapointType" oneof.</summary>
    public enum DatapointTypeOneofCase {
      None = 0,
      NumericDatapoints = 3,
      StringDatapoints = 4,
      AggregateDatapoints = 5,
    }
    private DatapointTypeOneofCase datapointTypeCase_ = DatapointTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DatapointTypeOneofCase DatapointTypeCase {
      get { return datapointTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDatapointType() {
      datapointTypeCase_ = DatapointTypeOneofCase.None;
      datapointType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataPointListItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataPointListItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ExternalId != other.ExternalId) return false;
      if (IsString != other.IsString) return false;
      if (IsStep != other.IsStep) return false;
      if (Unit != other.Unit) return false;
      if (NextCursor != other.NextCursor) return false;
      if (UnitExternalId != other.UnitExternalId) return false;
      if (!object.Equals(NumericDatapoints, other.NumericDatapoints)) return false;
      if (!object.Equals(StringDatapoints, other.StringDatapoints)) return false;
      if (!object.Equals(AggregateDatapoints, other.AggregateDatapoints)) return false;
      if (DatapointTypeCase != other.DatapointTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (ExternalId.Length != 0) hash ^= ExternalId.GetHashCode();
      if (IsString != false) hash ^= IsString.GetHashCode();
      if (IsStep != false) hash ^= IsStep.GetHashCode();
      if (Unit.Length != 0) hash ^= Unit.GetHashCode();
      if (NextCursor.Length != 0) hash ^= NextCursor.GetHashCode();
      if (UnitExternalId.Length != 0) hash ^= UnitExternalId.GetHashCode();
      if (datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints) hash ^= NumericDatapoints.GetHashCode();
      if (datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints) hash ^= StringDatapoints.GetHashCode();
      if (datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints) hash ^= AggregateDatapoints.GetHashCode();
      hash ^= (int) datapointTypeCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (ExternalId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ExternalId);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints) {
        output.WriteRawTag(26);
        output.WriteMessage(NumericDatapoints);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints) {
        output.WriteRawTag(34);
        output.WriteMessage(StringDatapoints);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints) {
        output.WriteRawTag(42);
        output.WriteMessage(AggregateDatapoints);
      }
      if (IsString != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsString);
      }
      if (IsStep != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsStep);
      }
      if (Unit.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Unit);
      }
      if (NextCursor.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(NextCursor);
      }
      if (UnitExternalId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(UnitExternalId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (ExternalId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ExternalId);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints) {
        output.WriteRawTag(26);
        output.WriteMessage(NumericDatapoints);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints) {
        output.WriteRawTag(34);
        output.WriteMessage(StringDatapoints);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints) {
        output.WriteRawTag(42);
        output.WriteMessage(AggregateDatapoints);
      }
      if (IsString != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsString);
      }
      if (IsStep != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsStep);
      }
      if (Unit.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Unit);
      }
      if (NextCursor.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(NextCursor);
      }
      if (UnitExternalId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(UnitExternalId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (ExternalId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExternalId);
      }
      if (IsString != false) {
        size += 1 + 1;
      }
      if (IsStep != false) {
        size += 1 + 1;
      }
      if (Unit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unit);
      }
      if (NextCursor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextCursor);
      }
      if (UnitExternalId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UnitExternalId);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NumericDatapoints);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StringDatapoints);
      }
      if (datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AggregateDatapoints);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataPointListItem other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.ExternalId.Length != 0) {
        ExternalId = other.ExternalId;
      }
      if (other.IsString != false) {
        IsString = other.IsString;
      }
      if (other.IsStep != false) {
        IsStep = other.IsStep;
      }
      if (other.Unit.Length != 0) {
        Unit = other.Unit;
      }
      if (other.NextCursor.Length != 0) {
        NextCursor = other.NextCursor;
      }
      if (other.UnitExternalId.Length != 0) {
        UnitExternalId = other.UnitExternalId;
      }
      switch (other.DatapointTypeCase) {
        case DatapointTypeOneofCase.NumericDatapoints:
          if (NumericDatapoints == null) {
            NumericDatapoints = new global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints();
          }
          NumericDatapoints.MergeFrom(other.NumericDatapoints);
          break;
        case DatapointTypeOneofCase.StringDatapoints:
          if (StringDatapoints == null) {
            StringDatapoints = new global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints();
          }
          StringDatapoints.MergeFrom(other.StringDatapoints);
          break;
        case DatapointTypeOneofCase.AggregateDatapoints:
          if (AggregateDatapoints == null) {
            AggregateDatapoints = new global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints();
          }
          AggregateDatapoints.MergeFrom(other.AggregateDatapoints);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            ExternalId = input.ReadString();
            break;
          }
          case 26: {
            global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints subBuilder = new global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints();
            if (datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints) {
              subBuilder.MergeFrom(NumericDatapoints);
            }
            input.ReadMessage(subBuilder);
            NumericDatapoints = subBuilder;
            break;
          }
          case 34: {
            global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints subBuilder = new global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints();
            if (datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints) {
              subBuilder.MergeFrom(StringDatapoints);
            }
            input.ReadMessage(subBuilder);
            StringDatapoints = subBuilder;
            break;
          }
          case 42: {
            global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints subBuilder = new global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints();
            if (datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints) {
              subBuilder.MergeFrom(AggregateDatapoints);
            }
            input.ReadMessage(subBuilder);
            AggregateDatapoints = subBuilder;
            break;
          }
          case 48: {
            IsString = input.ReadBool();
            break;
          }
          case 56: {
            IsStep = input.ReadBool();
            break;
          }
          case 66: {
            Unit = input.ReadString();
            break;
          }
          case 74: {
            NextCursor = input.ReadString();
            break;
          }
          case 82: {
            UnitExternalId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            ExternalId = input.ReadString();
            break;
          }
          case 26: {
            global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints subBuilder = new global::Com.Cognite.V1.Timeseries.Proto.NumericDatapoints();
            if (datapointTypeCase_ == DatapointTypeOneofCase.NumericDatapoints) {
              subBuilder.MergeFrom(NumericDatapoints);
            }
            input.ReadMessage(subBuilder);
            NumericDatapoints = subBuilder;
            break;
          }
          case 34: {
            global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints subBuilder = new global::Com.Cognite.V1.Timeseries.Proto.StringDatapoints();
            if (datapointTypeCase_ == DatapointTypeOneofCase.StringDatapoints) {
              subBuilder.MergeFrom(StringDatapoints);
            }
            input.ReadMessage(subBuilder);
            StringDatapoints = subBuilder;
            break;
          }
          case 42: {
            global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints subBuilder = new global::Com.Cognite.V1.Timeseries.Proto.AggregateDatapoints();
            if (datapointTypeCase_ == DatapointTypeOneofCase.AggregateDatapoints) {
              subBuilder.MergeFrom(AggregateDatapoints);
            }
            input.ReadMessage(subBuilder);
            AggregateDatapoints = subBuilder;
            break;
          }
          case 48: {
            IsString = input.ReadBool();
            break;
          }
          case 56: {
            IsStep = input.ReadBool();
            break;
          }
          case 66: {
            Unit = input.ReadString();
            break;
          }
          case 74: {
            NextCursor = input.ReadString();
            break;
          }
          case 82: {
            UnitExternalId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DataPointListResponse : pb::IMessage<DataPointListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataPointListResponse> _parser = new pb::MessageParser<DataPointListResponse>(() => new DataPointListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataPointListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Cognite.V1.Timeseries.Proto.DataPointListResponseReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataPointListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataPointListResponse(DataPointListResponse other) : this() {
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataPointListResponse Clone() {
      return new DataPointListResponse(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem.Parser);
    private readonly pbc::RepeatedField<global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem> items_ = new pbc::RepeatedField<global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Com.Cognite.V1.Timeseries.Proto.DataPointListItem> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataPointListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataPointListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= items_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      items_.WriteTo(ref output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataPointListResponse other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            items_.AddEntriesFrom(ref input, _repeated_items_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
