/**
 * Autogenerated by Thrift Compiler (0.9.2)
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
/// grouped item found
/// 
/// <dl>
/// <dt>groupValue</dt>
/// <dd>value of the groupBy field</dd>
/// 
/// <dt>totalHitCount</dt>
/// <dd>total hits count within the group</dd>
/// 
/// <dt>hits</dt>
/// <dd>group hits</dd>
/// </dl>
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class HitsGroup : TBase
{
  private string _groupValue;
  private long _totalHitCount;
  private List<Hit> _hits;

  public string GroupValue
  {
    get
    {
      return _groupValue;
    }
    set
    {
      __isset.groupValue = true;
      this._groupValue = value;
    }
  }

  public long TotalHitCount
  {
    get
    {
      return _totalHitCount;
    }
    set
    {
      __isset.totalHitCount = true;
      this._totalHitCount = value;
    }
  }

  public List<Hit> Hits
  {
    get
    {
      return _hits;
    }
    set
    {
      __isset.hits = true;
      this._hits = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool groupValue;
    public bool totalHitCount;
    public bool hits;
  }

  public HitsGroup() {
  }

  public void Read (TProtocol iprot)
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
        case 10:
          if (field.Type == TType.String) {
            GroupValue = iprot.ReadString();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 20:
          if (field.Type == TType.I64) {
            TotalHitCount = iprot.ReadI64();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 30:
          if (field.Type == TType.List) {
            {
              Hits = new List<Hit>();
              TList _list66 = iprot.ReadListBegin();
              for( int _i67 = 0; _i67 < _list66.Count; ++_i67)
              {
                Hit _elem68;
                _elem68 = new Hit();
                _elem68.Read(iprot);
                Hits.Add(_elem68);
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

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("HitsGroup");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (GroupValue != null && __isset.groupValue) {
      field.Name = "groupValue";
      field.Type = TType.String;
      field.ID = 10;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(GroupValue);
      oprot.WriteFieldEnd();
    }
    if (__isset.totalHitCount) {
      field.Name = "totalHitCount";
      field.Type = TType.I64;
      field.ID = 20;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(TotalHitCount);
      oprot.WriteFieldEnd();
    }
    if (Hits != null && __isset.hits) {
      field.Name = "hits";
      field.Type = TType.List;
      field.ID = 30;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Hits.Count));
        foreach (Hit _iter69 in Hits)
        {
          _iter69.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("HitsGroup(");
    bool __first = true;
    if (GroupValue != null && __isset.groupValue) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("GroupValue: ");
      __sb.Append(GroupValue);
    }
    if (__isset.totalHitCount) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("TotalHitCount: ");
      __sb.Append(TotalHitCount);
    }
    if (Hits != null && __isset.hits) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Hits: ");
      __sb.Append(Hits);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
