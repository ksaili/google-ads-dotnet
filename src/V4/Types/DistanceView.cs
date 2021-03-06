// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/distance_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/distance_view.proto</summary>
  public static partial class DistanceViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/distance_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DistanceViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMvZGlzdGFuY2Vf",
            "dmlldy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQucmVzb3VyY2Vz",
            "GjNnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9kaXN0YW5jZV9idWNr",
            "ZXQucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdv",
            "b2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFw",
            "cGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLMAgoM",
            "RGlzdGFuY2VWaWV3EkQKDXJlc291cmNlX25hbWUYASABKAlCLeBBA/pBJwol",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Rpc3RhbmNlVmlldxJeCg9kaXN0",
            "YW5jZV9idWNrZXQYAiABKA4yQC5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5l",
            "bnVtcy5EaXN0YW5jZUJ1Y2tldEVudW0uRGlzdGFuY2VCdWNrZXRCA+BBAxI2",
            "Cg1tZXRyaWNfc3lzdGVtGAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLkJvb2xW",
            "YWx1ZUID4EEDOl7qQVsKJWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9EaXN0",
            "YW5jZVZpZXcSMmN1c3RvbWVycy97Y3VzdG9tZXJ9L2Rpc3RhbmNlVmlld3Mv",
            "e2Rpc3RhbmNlX3ZpZXd9Qv4BCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djQucmVzb3VyY2VzQhFEaXN0YW5jZVZpZXdQcm90b1ABWkpnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQv",
            "cmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlY0LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XFJl",
            "c291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY0OjpSZXNvdXJj",
            "ZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.DistanceView), global::Google.Ads.GoogleAds.V4.Resources.DistanceView.Parser, new[]{ "ResourceName", "DistanceBucket", "MetricSystem" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A distance view with metrics aggregated by the user's distance from an
  /// advertiser's location extensions. Each DistanceBucket includes all
  /// impressions that fall within its distance and a single impression will
  /// contribute to the metrics for all DistanceBuckets that include the user's
  /// distance.
  /// </summary>
  public sealed partial class DistanceView : pb::IMessage<DistanceView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DistanceView> _parser = new pb::MessageParser<DistanceView>(() => new DistanceView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DistanceView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Resources.DistanceViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DistanceView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DistanceView(DistanceView other) : this() {
      resourceName_ = other.resourceName_;
      distanceBucket_ = other.distanceBucket_;
      MetricSystem = other.MetricSystem;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DistanceView Clone() {
      return new DistanceView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the distance view.
    /// Distance view resource names have the form:
    ///
    /// `customers/{customer_id}/distanceViews/1~{distance_bucket}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "distance_bucket" field.</summary>
    public const int DistanceBucketFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket distanceBucket_ = global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket.Unspecified;
    /// <summary>
    /// Output only. Grouping of user distance from location extensions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket DistanceBucket {
      get { return distanceBucket_; }
      set {
        distanceBucket_ = value;
      }
    }

    /// <summary>Field number for the "metric_system" field.</summary>
    public const int MetricSystemFieldNumber = 3;
    private static readonly pb::FieldCodec<bool?> _single_metricSystem_codec = pb::FieldCodec.ForStructWrapper<bool>(26);
    private bool? metricSystem_;
    /// <summary>
    /// Output only. True if the DistanceBucket is using the metric system, false otherwise.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? MetricSystem {
      get { return metricSystem_; }
      set {
        metricSystem_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DistanceView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DistanceView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (DistanceBucket != other.DistanceBucket) return false;
      if (MetricSystem != other.MetricSystem) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (DistanceBucket != global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket.Unspecified) hash ^= DistanceBucket.GetHashCode();
      if (metricSystem_ != null) hash ^= MetricSystem.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (DistanceBucket != global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) DistanceBucket);
      }
      if (metricSystem_ != null) {
        _single_metricSystem_codec.WriteTagAndValue(output, MetricSystem);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (DistanceBucket != global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) DistanceBucket);
      }
      if (metricSystem_ != null) {
        _single_metricSystem_codec.WriteTagAndValue(ref output, MetricSystem);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (DistanceBucket != global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DistanceBucket);
      }
      if (metricSystem_ != null) {
        size += _single_metricSystem_codec.CalculateSizeWithTag(MetricSystem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DistanceView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.DistanceBucket != global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket.Unspecified) {
        DistanceBucket = other.DistanceBucket;
      }
      if (other.metricSystem_ != null) {
        if (metricSystem_ == null || other.MetricSystem != false) {
          MetricSystem = other.MetricSystem;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            DistanceBucket = (global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket) input.ReadEnum();
            break;
          }
          case 26: {
            bool? value = _single_metricSystem_codec.Read(input);
            if (metricSystem_ == null || value != false) {
              MetricSystem = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            DistanceBucket = (global::Google.Ads.GoogleAds.V4.Enums.DistanceBucketEnum.Types.DistanceBucket) input.ReadEnum();
            break;
          }
          case 26: {
            bool? value = _single_metricSystem_codec.Read(ref input);
            if (metricSystem_ == null || value != false) {
              MetricSystem = value;
            }
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
