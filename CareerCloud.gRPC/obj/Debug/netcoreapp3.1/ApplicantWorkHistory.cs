// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantWorkHistory.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantWorkHistory.proto</summary>
  public static partial class ApplicantWorkHistoryReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantWorkHistory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantWorkHistoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQcm90b3MvQXBwbGljYW50V29ya0hpc3RvcnkucHJvdG8SEENhcmVlckNs",
            "b3VkLmdSUEMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxofZ29vZ2xl",
            "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byIiChRJZFJlcXVlc3RXb3JrSGlz",
            "dG9yeRIKCgJJZBgBIAEoCSLsAQobQXBwbGljYW50V29ya0hpc3RvcnlQYXlM",
            "b2FkEgoKAklkGAEgASgJEhEKCUFwcGxpY2FudBgCIAEoCRITCgtDb21wYW55",
            "TmFtZRgDIAEoCRITCgtDb3VudHJ5Q29kZRgEIAEoCRIQCghMb2NhdGlvbhgF",
            "IAEoCRIQCghKb2JUaXRsZRgGIAEoCRIWCg5Kb2JEZXNjcmlwdGlvbhgHIAEo",
            "CRISCgpTdGFydE1vbnRoGAggASgFEhEKCVN0YXJ0WWVhchgJIAEoBRIQCghF",
            "bmRNb250aBgKIAEoBRIPCgdFbmRZZWFyGAsgASgFMrgDChRBcHBsaWNhbnRX",
            "b3JrSGlzdG9yeRJxChhSZWFkQXBwbGljYW50V29ya0hpc3RvcnkSJi5DYXJl",
            "ZXJDbG91ZC5nUlBDLklkUmVxdWVzdFdvcmtIaXN0b3J5Gi0uQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5BcHBsaWNhbnRXb3JrSGlzdG9yeVBheUxvYWQSYwoaQ3JlYXRl",
            "QXBwbGljYW50V29ya0hpc3RvcnkSLS5DYXJlZXJDbG91ZC5nUlBDLkFwcGxp",
            "Y2FudFdvcmtIaXN0b3J5UGF5TG9hZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0",
            "eRJjChpVcGRhdGVBcHBsaWNhbnRXb3JrSGlzdG9yeRItLkNhcmVlckNsb3Vk",
            "LmdSUEMuQXBwbGljYW50V29ya0hpc3RvcnlQYXlMb2FkGhYuZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5EmMKGkRlbGV0ZUFwcGxpY2FudFdvcmtIaXN0b3J5Ei0u",
            "Q2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNhbnRXb3JrSGlzdG9yeVBheUxvYWQa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHlCGqoCF0NhcmVlckNsb3VkLmdSUEMu",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.IdRequestWorkHistory), global::CareerCloud.gRPC.Protos.IdRequestWorkHistory.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantWorkHistoryPayLoad), global::CareerCloud.gRPC.Protos.ApplicantWorkHistoryPayLoad.Parser, new[]{ "Id", "Applicant", "CompanyName", "CountryCode", "Location", "JobTitle", "JobDescription", "StartMonth", "StartYear", "EndMonth", "EndYear" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IdRequestWorkHistory : pb::IMessage<IdRequestWorkHistory> {
    private static readonly pb::MessageParser<IdRequestWorkHistory> _parser = new pb::MessageParser<IdRequestWorkHistory>(() => new IdRequestWorkHistory());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequestWorkHistory> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantWorkHistoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestWorkHistory() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestWorkHistory(IdRequestWorkHistory other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestWorkHistory Clone() {
      return new IdRequestWorkHistory(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdRequestWorkHistory);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequestWorkHistory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdRequestWorkHistory other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApplicantWorkHistoryPayLoad : pb::IMessage<ApplicantWorkHistoryPayLoad> {
    private static readonly pb::MessageParser<ApplicantWorkHistoryPayLoad> _parser = new pb::MessageParser<ApplicantWorkHistoryPayLoad>(() => new ApplicantWorkHistoryPayLoad());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantWorkHistoryPayLoad> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantWorkHistoryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantWorkHistoryPayLoad() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantWorkHistoryPayLoad(ApplicantWorkHistoryPayLoad other) : this() {
      id_ = other.id_;
      applicant_ = other.applicant_;
      companyName_ = other.companyName_;
      countryCode_ = other.countryCode_;
      location_ = other.location_;
      jobTitle_ = other.jobTitle_;
      jobDescription_ = other.jobDescription_;
      startMonth_ = other.startMonth_;
      startYear_ = other.startYear_;
      endMonth_ = other.endMonth_;
      endYear_ = other.endYear_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantWorkHistoryPayLoad Clone() {
      return new ApplicantWorkHistoryPayLoad(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Applicant" field.</summary>
    public const int ApplicantFieldNumber = 2;
    private string applicant_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Applicant {
      get { return applicant_; }
      set {
        applicant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CompanyName" field.</summary>
    public const int CompanyNameFieldNumber = 3;
    private string companyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompanyName {
      get { return companyName_; }
      set {
        companyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CountryCode" field.</summary>
    public const int CountryCodeFieldNumber = 4;
    private string countryCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Location" field.</summary>
    public const int LocationFieldNumber = 5;
    private string location_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JobTitle" field.</summary>
    public const int JobTitleFieldNumber = 6;
    private string jobTitle_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobTitle {
      get { return jobTitle_; }
      set {
        jobTitle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JobDescription" field.</summary>
    public const int JobDescriptionFieldNumber = 7;
    private string jobDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobDescription {
      get { return jobDescription_; }
      set {
        jobDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StartMonth" field.</summary>
    public const int StartMonthFieldNumber = 8;
    private int startMonth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StartMonth {
      get { return startMonth_; }
      set {
        startMonth_ = value;
      }
    }

    /// <summary>Field number for the "StartYear" field.</summary>
    public const int StartYearFieldNumber = 9;
    private int startYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StartYear {
      get { return startYear_; }
      set {
        startYear_ = value;
      }
    }

    /// <summary>Field number for the "EndMonth" field.</summary>
    public const int EndMonthFieldNumber = 10;
    private int endMonth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EndMonth {
      get { return endMonth_; }
      set {
        endMonth_ = value;
      }
    }

    /// <summary>Field number for the "EndYear" field.</summary>
    public const int EndYearFieldNumber = 11;
    private int endYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EndYear {
      get { return endYear_; }
      set {
        endYear_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantWorkHistoryPayLoad);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantWorkHistoryPayLoad other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Applicant != other.Applicant) return false;
      if (CompanyName != other.CompanyName) return false;
      if (CountryCode != other.CountryCode) return false;
      if (Location != other.Location) return false;
      if (JobTitle != other.JobTitle) return false;
      if (JobDescription != other.JobDescription) return false;
      if (StartMonth != other.StartMonth) return false;
      if (StartYear != other.StartYear) return false;
      if (EndMonth != other.EndMonth) return false;
      if (EndYear != other.EndYear) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Applicant.Length != 0) hash ^= Applicant.GetHashCode();
      if (CompanyName.Length != 0) hash ^= CompanyName.GetHashCode();
      if (CountryCode.Length != 0) hash ^= CountryCode.GetHashCode();
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      if (JobTitle.Length != 0) hash ^= JobTitle.GetHashCode();
      if (JobDescription.Length != 0) hash ^= JobDescription.GetHashCode();
      if (StartMonth != 0) hash ^= StartMonth.GetHashCode();
      if (StartYear != 0) hash ^= StartYear.GetHashCode();
      if (EndMonth != 0) hash ^= EndMonth.GetHashCode();
      if (EndYear != 0) hash ^= EndYear.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Applicant.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Applicant);
      }
      if (CompanyName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CompanyName);
      }
      if (CountryCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CountryCode);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Location);
      }
      if (JobTitle.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(JobTitle);
      }
      if (JobDescription.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(JobDescription);
      }
      if (StartMonth != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(StartMonth);
      }
      if (StartYear != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(StartYear);
      }
      if (EndMonth != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(EndMonth);
      }
      if (EndYear != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(EndYear);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Applicant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Applicant);
      }
      if (CompanyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyName);
      }
      if (CountryCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (JobTitle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobTitle);
      }
      if (JobDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobDescription);
      }
      if (StartMonth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartMonth);
      }
      if (StartYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartYear);
      }
      if (EndMonth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndMonth);
      }
      if (EndYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndYear);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantWorkHistoryPayLoad other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Applicant.Length != 0) {
        Applicant = other.Applicant;
      }
      if (other.CompanyName.Length != 0) {
        CompanyName = other.CompanyName;
      }
      if (other.CountryCode.Length != 0) {
        CountryCode = other.CountryCode;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      if (other.JobTitle.Length != 0) {
        JobTitle = other.JobTitle;
      }
      if (other.JobDescription.Length != 0) {
        JobDescription = other.JobDescription;
      }
      if (other.StartMonth != 0) {
        StartMonth = other.StartMonth;
      }
      if (other.StartYear != 0) {
        StartYear = other.StartYear;
      }
      if (other.EndMonth != 0) {
        EndMonth = other.EndMonth;
      }
      if (other.EndYear != 0) {
        EndYear = other.EndYear;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Applicant = input.ReadString();
            break;
          }
          case 26: {
            CompanyName = input.ReadString();
            break;
          }
          case 34: {
            CountryCode = input.ReadString();
            break;
          }
          case 42: {
            Location = input.ReadString();
            break;
          }
          case 50: {
            JobTitle = input.ReadString();
            break;
          }
          case 58: {
            JobDescription = input.ReadString();
            break;
          }
          case 64: {
            StartMonth = input.ReadInt32();
            break;
          }
          case 72: {
            StartYear = input.ReadInt32();
            break;
          }
          case 80: {
            EndMonth = input.ReadInt32();
            break;
          }
          case 88: {
            EndYear = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code