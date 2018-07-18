// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/slot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/slot.proto</summary>
  public static partial class SlotReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/slot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SlotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9zbG90LnByb3RvEh1n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtcyKjAQoIU2xvdEVudW0ilgEK",
            "BFNsb3QSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDwoLU0VBUkNI",
            "X1NJREUQAhIOCgpTRUFSQ0hfVE9QEAMSEAoMU0VBUkNIX09USEVSEAQSCwoH",
            "Q09OVEVOVBAFEhYKElNFQVJDSF9QQVJUTkVSX1RPUBAGEhgKFFNFQVJDSF9Q",
            "QVJUTkVSX09USEVSEAdCugEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MC5lbnVtc0IJU2xvdFByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lbnVtcztlbnVtc6IC",
            "A0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVudW1zygIdR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.SlotEnum), global::Google.Ads.GoogleAds.V0.Enums.SlotEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.SlotEnum.Types.Slot) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of possible positions of the Ad.
  /// </summary>
  public sealed partial class SlotEnum : pb::IMessage<SlotEnum> {
    private static readonly pb::MessageParser<SlotEnum> _parser = new pb::MessageParser<SlotEnum>(() => new SlotEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SlotEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.SlotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SlotEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SlotEnum(SlotEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SlotEnum Clone() {
      return new SlotEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SlotEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SlotEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SlotEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SlotEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates possible positions of the Ad.
      /// </summary>
      public enum Slot {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google search: Side.
        /// </summary>
        [pbr::OriginalName("SEARCH_SIDE")] SearchSide = 2,
        /// <summary>
        /// Google search: Top.
        /// </summary>
        [pbr::OriginalName("SEARCH_TOP")] SearchTop = 3,
        /// <summary>
        /// Google search: Other.
        /// </summary>
        [pbr::OriginalName("SEARCH_OTHER")] SearchOther = 4,
        /// <summary>
        /// Google Display Network.
        /// </summary>
        [pbr::OriginalName("CONTENT")] Content = 5,
        /// <summary>
        /// Search partners: Top.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNER_TOP")] SearchPartnerTop = 6,
        /// <summary>
        /// Search partners: Other.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNER_OTHER")] SearchPartnerOther = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code