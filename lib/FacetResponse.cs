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
/// <dt>fieldName</dt>
/// <dd>name of the facet field</dd>
/// 
/// <dt>values</dt>
/// <dd>list of facet values</dd>
/// </dl>
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class FacetResponse : TBase
{
  private string _fieldName;
  private List<FacetValue> _values;
  private bool _evaluate;
  private string _display;
  private bool _numerical;
  private bool _range;
  private FacetSortOrder _sortOrder;
  private bool _sortAscending;
  private bool _andSelectedValues;
  private bool _boundsOnly;
  private Dictionary<string, string> _extraInfo;

  public string FieldName
  {
    get
    {
      return _fieldName;
    }
    set
    {
      __isset.fieldName = true;
      this._fieldName = value;
    }
  }

  public List<FacetValue> Values
  {
    get
    {
      return _values;
    }
    set
    {
      __isset.values = true;
      this._values = value;
    }
  }

  public bool Evaluate
  {
    get
    {
      return _evaluate;
    }
    set
    {
      __isset.evaluate = true;
      this._evaluate = value;
    }
  }

  public string Display
  {
    get
    {
      return _display;
    }
    set
    {
      __isset.display = true;
      this._display = value;
    }
  }

  public bool Numerical
  {
    get
    {
      return _numerical;
    }
    set
    {
      __isset.numerical = true;
      this._numerical = value;
    }
  }

  public bool Range
  {
    get
    {
      return _range;
    }
    set
    {
      __isset.range = true;
      this._range = value;
    }
  }

  /// <summary>
  /// 
  /// <seealso cref="FacetSortOrder"/>
  /// </summary>
  public FacetSortOrder SortOrder
  {
    get
    {
      return _sortOrder;
    }
    set
    {
      __isset.sortOrder = true;
      this._sortOrder = value;
    }
  }

  public bool SortAscending
  {
    get
    {
      return _sortAscending;
    }
    set
    {
      __isset.sortAscending = true;
      this._sortAscending = value;
    }
  }

  public bool AndSelectedValues
  {
    get
    {
      return _andSelectedValues;
    }
    set
    {
      __isset.andSelectedValues = true;
      this._andSelectedValues = value;
    }
  }

  public bool BoundsOnly
  {
    get
    {
      return _boundsOnly;
    }
    set
    {
      __isset.boundsOnly = true;
      this._boundsOnly = value;
    }
  }

  public Dictionary<string, string> ExtraInfo
  {
    get
    {
      return _extraInfo;
    }
    set
    {
      __isset.extraInfo = true;
      this._extraInfo = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool fieldName;
    public bool values;
    public bool evaluate;
    public bool display;
    public bool numerical;
    public bool range;
    public bool sortOrder;
    public bool sortAscending;
    public bool andSelectedValues;
    public bool boundsOnly;
    public bool extraInfo;
  }

  public FacetResponse() {
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
            if (field.Type == TType.String) {
              FieldName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Values = new List<FacetValue>();
                TList _list62 = iprot.ReadListBegin();
                for( int _i63 = 0; _i63 < _list62.Count; ++_i63)
                {
                  FacetValue _elem64;
                  _elem64 = new FacetValue();
                  _elem64.Read(iprot);
                  Values.Add(_elem64);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              Evaluate = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Display = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              Numerical = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              Range = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              SortOrder = (FacetSortOrder)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Bool) {
              SortAscending = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Bool) {
              AndSelectedValues = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Bool) {
              BoundsOnly = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Map) {
              {
                ExtraInfo = new Dictionary<string, string>();
                TMap _map65 = iprot.ReadMapBegin();
                for( int _i66 = 0; _i66 < _map65.Count; ++_i66)
                {
                  string _key67;
                  string _val68;
                  _key67 = iprot.ReadString();
                  _val68 = iprot.ReadString();
                  ExtraInfo[_key67] = _val68;
                }
                iprot.ReadMapEnd();
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
      TStruct struc = new TStruct("FacetResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (FieldName != null && __isset.fieldName) {
        field.Name = "fieldName";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(FieldName);
        oprot.WriteFieldEnd();
      }
      if (Values != null && __isset.values) {
        field.Name = "values";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Values.Count));
          foreach (FacetValue _iter69 in Values)
          {
            _iter69.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.evaluate) {
        field.Name = "evaluate";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Evaluate);
        oprot.WriteFieldEnd();
      }
      if (Display != null && __isset.display) {
        field.Name = "display";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Display);
        oprot.WriteFieldEnd();
      }
      if (__isset.numerical) {
        field.Name = "numerical";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Numerical);
        oprot.WriteFieldEnd();
      }
      if (__isset.range) {
        field.Name = "range";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Range);
        oprot.WriteFieldEnd();
      }
      if (__isset.sortOrder) {
        field.Name = "sortOrder";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)SortOrder);
        oprot.WriteFieldEnd();
      }
      if (__isset.sortAscending) {
        field.Name = "sortAscending";
        field.Type = TType.Bool;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(SortAscending);
        oprot.WriteFieldEnd();
      }
      if (__isset.andSelectedValues) {
        field.Name = "andSelectedValues";
        field.Type = TType.Bool;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(AndSelectedValues);
        oprot.WriteFieldEnd();
      }
      if (__isset.boundsOnly) {
        field.Name = "boundsOnly";
        field.Type = TType.Bool;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(BoundsOnly);
        oprot.WriteFieldEnd();
      }
      if (ExtraInfo != null && __isset.extraInfo) {
        field.Name = "extraInfo";
        field.Type = TType.Map;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, ExtraInfo.Count));
          foreach (string _iter70 in ExtraInfo.Keys)
          {
            oprot.WriteString(_iter70);
            oprot.WriteString(ExtraInfo[_iter70]);
          }
          oprot.WriteMapEnd();
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
    StringBuilder __sb = new StringBuilder("FacetResponse(");
    bool __first = true;
    if (FieldName != null && __isset.fieldName) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("FieldName: ");
      __sb.Append(FieldName);
    }
    if (Values != null && __isset.values) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Values: ");
      __sb.Append(Values);
    }
    if (__isset.evaluate) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Evaluate: ");
      __sb.Append(Evaluate);
    }
    if (Display != null && __isset.display) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Display: ");
      __sb.Append(Display);
    }
    if (__isset.numerical) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Numerical: ");
      __sb.Append(Numerical);
    }
    if (__isset.range) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Range: ");
      __sb.Append(Range);
    }
    if (__isset.sortOrder) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("SortOrder: ");
      __sb.Append(SortOrder);
    }
    if (__isset.sortAscending) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("SortAscending: ");
      __sb.Append(SortAscending);
    }
    if (__isset.andSelectedValues) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("AndSelectedValues: ");
      __sb.Append(AndSelectedValues);
    }
    if (__isset.boundsOnly) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("BoundsOnly: ");
      __sb.Append(BoundsOnly);
    }
    if (ExtraInfo != null && __isset.extraInfo) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ExtraInfo: ");
      __sb.Append(ExtraInfo);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

