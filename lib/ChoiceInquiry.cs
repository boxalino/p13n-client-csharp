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
/// <dt>choiceId</dt>
/// <dd>personalization choice identificator</dd>
/// 
/// <dt>simpleSearchQuery</dt>
/// <dd>search query in a case of recommendation and search inquiries</dd>
/// 
/// <dt>contextItems</dt>
/// <dd>context items for recommendations</dd>
/// 
/// <dt>minHitCount</dt>
/// <dd>minimal hit count to return for recommendations.</dd>
/// <dd>if higher priority recommendation strategy yields less results, next
/// strategy is tried</dd>
/// 
/// <dt>excludeVariantIds</dt>
/// <dd>set of variantIds to be excluded from result, has no effect if null or empty</dd>
/// 
/// <dt>includeVariantIds</dt>
/// <dd>set of variantIds to be included in the result, has no effect if null or empty</dd>
/// 
/// <dt>scope</dt>
/// <dd>choice source to be used</dd>
/// 
/// <dt>withRelaxation</dt>
/// <dd>if search relaxation should be used</dd>
/// </dl>
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class ChoiceInquiry : TBase
{
  private string _choiceId;
  private SimpleSearchQuery _simpleSearchQuery;
  private List<ContextItem> _contextItems;
  private int _minHitCount;
  private THashSet<string> _excludeVariantIds;
  private string _scope;
  private bool _withRelaxation;
  private bool _withSemanticFiltering;
  private THashSet<string> _includeVariantIds;

  public string ChoiceId
  {
    get
    {
      return _choiceId;
    }
    set
    {
      __isset.choiceId = true;
      this._choiceId = value;
    }
  }

  public SimpleSearchQuery SimpleSearchQuery
  {
    get
    {
      return _simpleSearchQuery;
    }
    set
    {
      __isset.simpleSearchQuery = true;
      this._simpleSearchQuery = value;
    }
  }

  public List<ContextItem> ContextItems
  {
    get
    {
      return _contextItems;
    }
    set
    {
      __isset.contextItems = true;
      this._contextItems = value;
    }
  }

  public int MinHitCount
  {
    get
    {
      return _minHitCount;
    }
    set
    {
      __isset.minHitCount = true;
      this._minHitCount = value;
    }
  }

  public THashSet<string> ExcludeVariantIds
  {
    get
    {
      return _excludeVariantIds;
    }
    set
    {
      __isset.excludeVariantIds = true;
      this._excludeVariantIds = value;
    }
  }

  public string Scope
  {
    get
    {
      return _scope;
    }
    set
    {
      __isset.scope = true;
      this._scope = value;
    }
  }

  public bool WithRelaxation
  {
    get
    {
      return _withRelaxation;
    }
    set
    {
      __isset.withRelaxation = true;
      this._withRelaxation = value;
    }
  }

  public bool WithSemanticFiltering
  {
    get
    {
      return _withSemanticFiltering;
    }
    set
    {
      __isset.withSemanticFiltering = true;
      this._withSemanticFiltering = value;
    }
  }

  public THashSet<string> IncludeVariantIds
  {
    get
    {
      return _includeVariantIds;
    }
    set
    {
      __isset.includeVariantIds = true;
      this._includeVariantIds = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool choiceId;
    public bool simpleSearchQuery;
    public bool contextItems;
    public bool minHitCount;
    public bool excludeVariantIds;
    public bool scope;
    public bool withRelaxation;
    public bool withSemanticFiltering;
    public bool includeVariantIds;
  }

  public ChoiceInquiry() {
    this._scope = "system_rec";
    this.__isset.scope = true;
    this._withRelaxation = false;
    this.__isset.withRelaxation = true;
    this._withSemanticFiltering = false;
    this.__isset.withSemanticFiltering = true;
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
              ChoiceId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              SimpleSearchQuery = new SimpleSearchQuery();
              SimpleSearchQuery.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                ContextItems = new List<ContextItem>();
                TList _list37 = iprot.ReadListBegin();
                for( int _i38 = 0; _i38 < _list37.Count; ++_i38)
                {
                  ContextItem _elem39;
                  _elem39 = new ContextItem();
                  _elem39.Read(iprot);
                  ContextItems.Add(_elem39);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              MinHitCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Set) {
              {
                ExcludeVariantIds = new THashSet<string>();
                TSet _set40 = iprot.ReadSetBegin();
                for( int _i41 = 0; _i41 < _set40.Count; ++_i41)
                {
                  string _elem42;
                  _elem42 = iprot.ReadString();
                  ExcludeVariantIds.Add(_elem42);
                }
                iprot.ReadSetEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Scope = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 70:
            if (field.Type == TType.Bool) {
              WithRelaxation = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 80:
            if (field.Type == TType.Bool) {
              WithSemanticFiltering = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 90:
            if (field.Type == TType.Set) {
              {
                IncludeVariantIds = new THashSet<string>();
                TSet _set43 = iprot.ReadSetBegin();
                for( int _i44 = 0; _i44 < _set43.Count; ++_i44)
                {
                  string _elem45;
                  _elem45 = iprot.ReadString();
                  IncludeVariantIds.Add(_elem45);
                }
                iprot.ReadSetEnd();
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
      TStruct struc = new TStruct("ChoiceInquiry");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ChoiceId != null && __isset.choiceId) {
        field.Name = "choiceId";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ChoiceId);
        oprot.WriteFieldEnd();
      }
      if (SimpleSearchQuery != null && __isset.simpleSearchQuery) {
        field.Name = "simpleSearchQuery";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        SimpleSearchQuery.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (ContextItems != null && __isset.contextItems) {
        field.Name = "contextItems";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ContextItems.Count));
          foreach (ContextItem _iter46 in ContextItems)
          {
            _iter46.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.minHitCount) {
        field.Name = "minHitCount";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MinHitCount);
        oprot.WriteFieldEnd();
      }
      if (ExcludeVariantIds != null && __isset.excludeVariantIds) {
        field.Name = "excludeVariantIds";
        field.Type = TType.Set;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteSetBegin(new TSet(TType.String, ExcludeVariantIds.Count));
          foreach (string _iter47 in ExcludeVariantIds)
          {
            oprot.WriteString(_iter47);
          }
          oprot.WriteSetEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Scope != null && __isset.scope) {
        field.Name = "scope";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Scope);
        oprot.WriteFieldEnd();
      }
      if (__isset.withRelaxation) {
        field.Name = "withRelaxation";
        field.Type = TType.Bool;
        field.ID = 70;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(WithRelaxation);
        oprot.WriteFieldEnd();
      }
      if (__isset.withSemanticFiltering) {
        field.Name = "withSemanticFiltering";
        field.Type = TType.Bool;
        field.ID = 80;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(WithSemanticFiltering);
        oprot.WriteFieldEnd();
      }
      if (IncludeVariantIds != null && __isset.includeVariantIds) {
        field.Name = "includeVariantIds";
        field.Type = TType.Set;
        field.ID = 90;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteSetBegin(new TSet(TType.String, IncludeVariantIds.Count));
          foreach (string _iter48 in IncludeVariantIds)
          {
            oprot.WriteString(_iter48);
          }
          oprot.WriteSetEnd();
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
    StringBuilder __sb = new StringBuilder("ChoiceInquiry(");
    bool __first = true;
    if (ChoiceId != null && __isset.choiceId) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ChoiceId: ");
      __sb.Append(ChoiceId);
    }
    if (SimpleSearchQuery != null && __isset.simpleSearchQuery) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("SimpleSearchQuery: ");
      __sb.Append(SimpleSearchQuery== null ? "<null>" : SimpleSearchQuery.ToString());
    }
    if (ContextItems != null && __isset.contextItems) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ContextItems: ");
      __sb.Append(ContextItems);
    }
    if (__isset.minHitCount) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("MinHitCount: ");
      __sb.Append(MinHitCount);
    }
    if (ExcludeVariantIds != null && __isset.excludeVariantIds) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ExcludeVariantIds: ");
      __sb.Append(ExcludeVariantIds);
    }
    if (Scope != null && __isset.scope) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Scope: ");
      __sb.Append(Scope);
    }
    if (__isset.withRelaxation) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("WithRelaxation: ");
      __sb.Append(WithRelaxation);
    }
    if (__isset.withSemanticFiltering) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("WithSemanticFiltering: ");
      __sb.Append(WithSemanticFiltering);
    }
    if (IncludeVariantIds != null && __isset.includeVariantIds) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("IncludeVariantIds: ");
      __sb.Append(IncludeVariantIds);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

