/**
 * Autogenerated by Thrift Compiler (0.9.3)
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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class Choice : TBase
{
  private string _id;
  private Dictionary<string, string> _selections;
  private Dictionary<string, int> _variantIds;
  private bool _sticky;
  private bool _traced;

  public string Id
  {
    get
    {
      return _id;
    }
    set
    {
      __isset.id = true;
      this._id = value;
    }
  }

  public Dictionary<string, string> Selections
  {
    get
    {
      return _selections;
    }
    set
    {
      __isset.selections = true;
      this._selections = value;
    }
  }

  public Dictionary<string, int> VariantIds
  {
    get
    {
      return _variantIds;
    }
    set
    {
      __isset.variantIds = true;
      this._variantIds = value;
    }
  }

  public bool Sticky
  {
    get
    {
      return _sticky;
    }
    set
    {
      __isset.sticky = true;
      this._sticky = value;
    }
  }

  public bool Traced
  {
    get
    {
      return _traced;
    }
    set
    {
      __isset.traced = true;
      this._traced = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool id;
    public bool selections;
    public bool variantIds;
    public bool sticky;
    public bool traced;
  }

  public Choice() {
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
          case 11:
            if (field.Type == TType.String) {
              Id = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 21:
            if (field.Type == TType.Map) {
              {
                Selections = new Dictionary<string, string>();
                TMap _map0 = iprot.ReadMapBegin();
                for( int _i1 = 0; _i1 < _map0.Count; ++_i1)
                {
                  string _key2;
                  string _val3;
                  _key2 = iprot.ReadString();
                  _val3 = iprot.ReadString();
                  Selections[_key2] = _val3;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 31:
            if (field.Type == TType.Map) {
              {
                VariantIds = new Dictionary<string, int>();
                TMap _map4 = iprot.ReadMapBegin();
                for( int _i5 = 0; _i5 < _map4.Count; ++_i5)
                {
                  string _key6;
                  int _val7;
                  _key6 = iprot.ReadString();
                  _val7 = iprot.ReadI32();
                  VariantIds[_key6] = _val7;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 41:
            if (field.Type == TType.Bool) {
              Sticky = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 51:
            if (field.Type == TType.Bool) {
              Traced = iprot.ReadBool();
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
      TStruct struc = new TStruct("Choice");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Id != null && __isset.id) {
        field.Name = "id";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Id);
        oprot.WriteFieldEnd();
      }
      if (Selections != null && __isset.selections) {
        field.Name = "selections";
        field.Type = TType.Map;
        field.ID = 21;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, Selections.Count));
          foreach (string _iter8 in Selections.Keys)
          {
            oprot.WriteString(_iter8);
            oprot.WriteString(Selections[_iter8]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (VariantIds != null && __isset.variantIds) {
        field.Name = "variantIds";
        field.Type = TType.Map;
        field.ID = 31;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.I32, VariantIds.Count));
          foreach (string _iter9 in VariantIds.Keys)
          {
            oprot.WriteString(_iter9);
            oprot.WriteI32(VariantIds[_iter9]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.sticky) {
        field.Name = "sticky";
        field.Type = TType.Bool;
        field.ID = 41;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Sticky);
        oprot.WriteFieldEnd();
      }
      if (__isset.traced) {
        field.Name = "traced";
        field.Type = TType.Bool;
        field.ID = 51;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Traced);
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
    StringBuilder __sb = new StringBuilder("Choice(");
    bool __first = true;
    if (Id != null && __isset.id) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Id: ");
      __sb.Append(Id);
    }
    if (Selections != null && __isset.selections) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Selections: ");
      __sb.Append(Selections);
    }
    if (VariantIds != null && __isset.variantIds) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("VariantIds: ");
      __sb.Append(VariantIds);
    }
    if (__isset.sticky) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Sticky: ");
      __sb.Append(Sticky);
    }
    if (__isset.traced) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Traced: ");
      __sb.Append(Traced);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

