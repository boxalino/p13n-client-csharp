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
/// <dl>
/// <dt>variants</dt>
/// <dd><b>deprecated</b> - contains non-null value only if
/// corresponding BatchChoiceRequest had only one ChoiceInquiry</dd>
/// 
/// <dt>selectedVariants</dt>
/// <dd>outer list corresponds to profileIds given in BatchChoiceRequest, while
/// inner list corresponds to list of ChoiceInquiries from BatchChoiceRequest</dd>
/// </dl>
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class BatchChoiceResponse : TBase
{
  private List<Variant> _variants;
  private List<List<Variant>> _selectedVariants;

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

  public List<List<Variant>> SelectedVariants
  {
    get
    {
      return _selectedVariants;
    }
    set
    {
      __isset.selectedVariants = true;
      this._selectedVariants = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool variants;
    public bool selectedVariants;
  }

  public BatchChoiceResponse() {
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
        case 1:
          if (field.Type == TType.List) {
            {
              Variants = new List<Variant>();
              TList _list106 = iprot.ReadListBegin();
              for( int _i107 = 0; _i107 < _list106.Count; ++_i107)
              {
                Variant _elem108;
                _elem108 = new Variant();
                _elem108.Read(iprot);
                Variants.Add(_elem108);
              }
              iprot.ReadListEnd();
            }
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.List) {
            {
              SelectedVariants = new List<List<Variant>>();
              TList _list109 = iprot.ReadListBegin();
              for( int _i110 = 0; _i110 < _list109.Count; ++_i110)
              {
                List<Variant> _elem111;
                {
                  _elem111 = new List<Variant>();
                  TList _list112 = iprot.ReadListBegin();
                  for( int _i113 = 0; _i113 < _list112.Count; ++_i113)
                  {
                    Variant _elem114;
                    _elem114 = new Variant();
                    _elem114.Read(iprot);
                    _elem111.Add(_elem114);
                  }
                  iprot.ReadListEnd();
                }
                SelectedVariants.Add(_elem111);
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
    TStruct struc = new TStruct("BatchChoiceResponse");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (Variants != null && __isset.variants) {
      field.Name = "variants";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Variants.Count));
        foreach (Variant _iter115 in Variants)
        {
          _iter115.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
    }
    if (SelectedVariants != null && __isset.selectedVariants) {
      field.Name = "selectedVariants";
      field.Type = TType.List;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.List, SelectedVariants.Count));
        foreach (List<Variant> _iter116 in SelectedVariants)
        {
          {
            oprot.WriteListBegin(new TList(TType.Struct, _iter116.Count));
            foreach (Variant _iter117 in _iter116)
            {
              _iter117.Write(oprot);
            }
            oprot.WriteListEnd();
          }
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("BatchChoiceResponse(");
    bool __first = true;
    if (Variants != null && __isset.variants) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Variants: ");
      __sb.Append(Variants);
    }
    if (SelectedVariants != null && __isset.selectedVariants) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("SelectedVariants: ");
      __sb.Append(SelectedVariants);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
