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
/// list of personalized variants. Item's index corresponds to the index of the
/// ChoiceInquiry
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class ChoiceResponse : TBase
{
  private List<Variant> _variants;

  public List<Variant> Variants
  {
    get
    {
      return _variants;
    }
    set
    {
      __isset.variants = true;
      this._variants = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool variants;
  }

  public ChoiceResponse() {
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
            if (field.Type == TType.List) {
              {
                Variants = new List<Variant>();
                TList _list113 = iprot.ReadListBegin();
                for( int _i114 = 0; _i114 < _list113.Count; ++_i114)
                {
                  Variant _elem115;
                  _elem115 = new Variant();
                  _elem115.Read(iprot);
                  Variants.Add(_elem115);
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
      TStruct struc = new TStruct("ChoiceResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Variants != null && __isset.variants) {
        field.Name = "variants";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Variants.Count));
          foreach (Variant _iter116 in Variants)
          {
            _iter116.Write(oprot);
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
    StringBuilder __sb = new StringBuilder("ChoiceResponse(");
    bool __first = true;
    if (Variants != null && __isset.variants) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Variants: ");
      __sb.Append(Variants);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

