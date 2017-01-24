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
                TList _list129 = iprot.ReadListBegin();
                for( int _i130 = 0; _i130 < _list129.Count; ++_i130)
                {
                  Variant _elem131;
                  _elem131 = new Variant();
                  _elem131.Read(iprot);
                  Variants.Add(_elem131);
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
                TList _list132 = iprot.ReadListBegin();
                for( int _i133 = 0; _i133 < _list132.Count; ++_i133)
                {
                  List<Variant> _elem134;
                  {
                    _elem134 = new List<Variant>();
                    TList _list135 = iprot.ReadListBegin();
                    for( int _i136 = 0; _i136 < _list135.Count; ++_i136)
                    {
                      Variant _elem137;
                      _elem137 = new Variant();
                      _elem137.Read(iprot);
                      _elem134.Add(_elem137);
                    }
                    iprot.ReadListEnd();
                  }
                  SelectedVariants.Add(_elem134);
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
          foreach (Variant _iter138 in Variants)
          {
            _iter138.Write(oprot);
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
          foreach (List<Variant> _iter139 in SelectedVariants)
          {
            {
              oprot.WriteListBegin(new TList(TType.Struct, _iter139.Count));
              foreach (Variant _iter140 in _iter139)
              {
                _iter140.Write(oprot);
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
    finally
    {
      oprot.DecrementRecursionDepth();
    }
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

