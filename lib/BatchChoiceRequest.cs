/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


/// <summary>
/// <dl>
/// <dt>choiceInquiry</dt>
/// <dd><b>deprecated</b> - use choiceInquiries instead.</dd>
/// <dd>If choiceInquiries is given this field will be ignored</dd>
/// 
/// <dt>choiceInquiries</dt>
/// <dd>list of ChoiceInquiries to be executed sequentially.</dd>
/// <dd>Note that list items can depend of items before in list</dd>
/// 
/// <dt>requestContext</dt>
/// <dd><b>deprecated</b> - use profileContexts instead.</dd>
/// 
/// <dt>profileIds</dt>
/// <dd><b>deprecated</b> - use profileContexts instead.</dd>
/// </dl>
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class BatchChoiceRequest : TBase
{
  private UserRecord _userRecord;
  private ChoiceInquiry _choiceInquiry;
  private RequestContext _requestContext;
  private List<string> _profileIds;
  private List<ChoiceInquiry> _choiceInquiries;
  private List<ProfileContext> _profileContexts;

  public UserRecord UserRecord
  {
    get
    {
      return _userRecord;
    }
    set
    {
      __isset.userRecord = true;
      this._userRecord = value;
    }
  }

  public ChoiceInquiry ChoiceInquiry
  {
    get
    {
      return _choiceInquiry;
    }
    set
    {
      __isset.choiceInquiry = true;
      this._choiceInquiry = value;
    }
  }

  public RequestContext RequestContext
  {
    get
    {
      return _requestContext;
    }
    set
    {
      __isset.requestContext = true;
      this._requestContext = value;
    }
  }

  public List<string> ProfileIds
  {
    get
    {
      return _profileIds;
    }
    set
    {
      __isset.profileIds = true;
      this._profileIds = value;
    }
  }

  public List<ChoiceInquiry> ChoiceInquiries
  {
    get
    {
      return _choiceInquiries;
    }
    set
    {
      __isset.choiceInquiries = true;
      this._choiceInquiries = value;
    }
  }

  public List<ProfileContext> ProfileContexts
  {
    get
    {
      return _profileContexts;
    }
    set
    {
      __isset.profileContexts = true;
      this._profileContexts = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool userRecord;
    public bool choiceInquiry;
    public bool requestContext;
    public bool profileIds;
    public bool choiceInquiries;
    public bool profileContexts;
  }

  public BatchChoiceRequest() {
  }

  public void Read (TProtocol iprot)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              UserRecord = new UserRecord();
              UserRecord.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              ChoiceInquiry = new ChoiceInquiry();
              ChoiceInquiry.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              RequestContext = new RequestContext();
              RequestContext.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                ProfileIds = new List<string>();
                TList _list117 = iprot.ReadListBegin();
                for( int _i118 = 0; _i118 < _list117.Count; ++_i118)
                {
                  string _elem119;
                  _elem119 = iprot.ReadString();
                  ProfileIds.Add(_elem119);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                ChoiceInquiries = new List<ChoiceInquiry>();
                TList _list120 = iprot.ReadListBegin();
                for( int _i121 = 0; _i121 < _list120.Count; ++_i121)
                {
                  ChoiceInquiry _elem122;
                  _elem122 = new ChoiceInquiry();
                  _elem122.Read(iprot);
                  ChoiceInquiries.Add(_elem122);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                ProfileContexts = new List<ProfileContext>();
                TList _list123 = iprot.ReadListBegin();
                for( int _i124 = 0; _i124 < _list123.Count; ++_i124)
                {
                  ProfileContext _elem125;
                  _elem125 = new ProfileContext();
                  _elem125.Read(iprot);
                  ProfileContexts.Add(_elem125);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public void Write(TProtocol oprot) {
    oprot.IncrementRecursionDepth();
    try
    {
      TStruct struc = new TStruct("BatchChoiceRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (UserRecord != null && __isset.userRecord) {
        field.Name = "userRecord";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        UserRecord.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (ChoiceInquiry != null && __isset.choiceInquiry) {
        field.Name = "choiceInquiry";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        ChoiceInquiry.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (RequestContext != null && __isset.requestContext) {
        field.Name = "requestContext";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        RequestContext.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (ProfileIds != null && __isset.profileIds) {
        field.Name = "profileIds";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ProfileIds.Count));
          foreach (string _iter126 in ProfileIds)
          {
            oprot.WriteString(_iter126);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (ChoiceInquiries != null && __isset.choiceInquiries) {
        field.Name = "choiceInquiries";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ChoiceInquiries.Count));
          foreach (ChoiceInquiry _iter127 in ChoiceInquiries)
          {
            _iter127.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (ProfileContexts != null && __isset.profileContexts) {
        field.Name = "profileContexts";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ProfileContexts.Count));
          foreach (ProfileContext _iter128 in ProfileContexts)
          {
            _iter128.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("BatchChoiceRequest(");
    bool __first = true;
    if (UserRecord != null && __isset.userRecord) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("UserRecord: ");
      __sb.Append(UserRecord== null ? "<null>" : UserRecord.ToString());
    }
    if (ChoiceInquiry != null && __isset.choiceInquiry) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ChoiceInquiry: ");
      __sb.Append(ChoiceInquiry== null ? "<null>" : ChoiceInquiry.ToString());
    }
    if (RequestContext != null && __isset.requestContext) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("RequestContext: ");
      __sb.Append(RequestContext== null ? "<null>" : RequestContext.ToString());
    }
    if (ProfileIds != null && __isset.profileIds) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ProfileIds: ");
      __sb.Append(ProfileIds);
    }
    if (ChoiceInquiries != null && __isset.choiceInquiries) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ChoiceInquiries: ");
      __sb.Append(ChoiceInquiries);
    }
    if (ProfileContexts != null && __isset.profileContexts) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ProfileContexts: ");
      __sb.Append(ProfileContexts);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

