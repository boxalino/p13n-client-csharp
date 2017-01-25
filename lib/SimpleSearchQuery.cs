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
/// <dt>indexId</dt>
/// <dd>indexId to be used for search</dd>
/// 
/// <dt>language</dt>
/// <dd>language for localization</dd>
/// 
/// <dt>queryText</dt>
/// <dd>main search query</dd>
/// 
/// <dt>filters</dt>
/// <dd>list of filters to apply</dd>
/// 
/// <dt>orFilters</dt>
/// <dd>whether boolean OR should be aplied to the given list of filters if false
/// boolean AND will be applied</dd>
/// 
/// <dt>facetRequests</dt>
/// <dd>list of facets to be returned</dd>
/// 
/// <dt>sortFields</dt>
/// <dd>optional list of sort fields for hardcoded sorting. If not given,
/// relevance sort order will be used</dd>
/// 
/// <dt>offset</dt>
/// <dd>from which hit to return result</dd>
/// 
/// <dt>hitCount</dt>
/// <dd>how many hits to return</dd>
/// 
/// <dt>returnFields</dt>
/// <dd>which index fields to be returned</dd>
/// 
/// <dt>groupBy</dt>
/// <dd>field name of the field to do grouping by</dd>
/// 
/// <dt>groupFacets</dt>
/// <dd>whether facets counts should contain number of groups</dd>
/// 
/// <dt>groupItemsCount</dt>
/// <dd>how many hits in each group to return</dd>
/// 
/// <dt>groupItemsSort</dt>
/// <dd>how to sort items within the group, default is score</dd>
/// 
/// <dt>groupItemsSortAscending</dt>
/// <dd>whether to sort items within the group ascending</dd>
/// 
/// <dt>hitsGroupsAsHits</dt>
/// <dd>if true, will return hitsGroups as hits in the response</dd>
/// </dl>
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class SimpleSearchQuery : TBase
{
  private string _indexId;
  private string _language;
  private string _queryText;
  private List<Filter> _filters;
  private bool _orFilters;
  private List<FacetRequest> _facetRequests;
  private List<SortField> _sortFields;
  private long _offset;
  private int _hitCount;
  private List<string> _returnFields;
  private string _groupBy;
  private bool _groupFacets;
  private int _groupItemsCount;
  private string _groupItemsSort;
  private bool _groupItemsSortAscending;
  private bool _hitsGroupsAsHits;

  public string IndexId
  {
    get
    {
      return _indexId;
    }
    set
    {
      __isset.indexId = true;
      this._indexId = value;
    }
  }

  public string Language
  {
    get
    {
      return _language;
    }
    set
    {
      __isset.language = true;
      this._language = value;
    }
  }

  public string QueryText
  {
    get
    {
      return _queryText;
    }
    set
    {
      __isset.queryText = true;
      this._queryText = value;
    }
  }

  public List<Filter> Filters
  {
    get
    {
      return _filters;
    }
    set
    {
      __isset.filters = true;
      this._filters = value;
    }
  }

  public bool OrFilters
  {
    get
    {
      return _orFilters;
    }
    set
    {
      __isset.orFilters = true;
      this._orFilters = value;
    }
  }

  public List<FacetRequest> FacetRequests
  {
    get
    {
      return _facetRequests;
    }
    set
    {
      __isset.facetRequests = true;
      this._facetRequests = value;
    }
  }

  public List<SortField> SortFields
  {
    get
    {
      return _sortFields;
    }
    set
    {
      __isset.sortFields = true;
      this._sortFields = value;
    }
  }

  public long Offset
  {
    get
    {
      return _offset;
    }
    set
    {
      __isset.offset = true;
      this._offset = value;
    }
  }

  public int HitCount
  {
    get
    {
      return _hitCount;
    }
    set
    {
      __isset.hitCount = true;
      this._hitCount = value;
    }
  }

  public List<string> ReturnFields
  {
    get
    {
      return _returnFields;
    }
    set
    {
      __isset.returnFields = true;
      this._returnFields = value;
    }
  }

  public string GroupBy
  {
    get
    {
      return _groupBy;
    }
    set
    {
      __isset.groupBy = true;
      this._groupBy = value;
    }
  }

  public bool GroupFacets
  {
    get
    {
      return _groupFacets;
    }
    set
    {
      __isset.groupFacets = true;
      this._groupFacets = value;
    }
  }

  public int GroupItemsCount
  {
    get
    {
      return _groupItemsCount;
    }
    set
    {
      __isset.groupItemsCount = true;
      this._groupItemsCount = value;
    }
  }

  public string GroupItemsSort
  {
    get
    {
      return _groupItemsSort;
    }
    set
    {
      __isset.groupItemsSort = true;
      this._groupItemsSort = value;
    }
  }

  public bool GroupItemsSortAscending
  {
    get
    {
      return _groupItemsSortAscending;
    }
    set
    {
      __isset.groupItemsSortAscending = true;
      this._groupItemsSortAscending = value;
    }
  }

  public bool HitsGroupsAsHits
  {
    get
    {
      return _hitsGroupsAsHits;
    }
    set
    {
      __isset.hitsGroupsAsHits = true;
      this._hitsGroupsAsHits = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool indexId;
    public bool language;
    public bool queryText;
    public bool filters;
    public bool orFilters;
    public bool facetRequests;
    public bool sortFields;
    public bool offset;
    public bool hitCount;
    public bool returnFields;
    public bool groupBy;
    public bool groupFacets;
    public bool groupItemsCount;
    public bool groupItemsSort;
    public bool groupItemsSortAscending;
    public bool hitsGroupsAsHits;
  }

  public SimpleSearchQuery() {
    this._groupFacets = true;
    this.__isset.groupFacets = true;
    this._groupItemsCount = 1;
    this.__isset.groupItemsCount = true;
    this._groupItemsSort = "score";
    this.__isset.groupItemsSort = true;
    this._groupItemsSortAscending = false;
    this.__isset.groupItemsSortAscending = true;
    this._hitsGroupsAsHits = false;
    this.__isset.hitsGroupsAsHits = true;
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
              IndexId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Language = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              QueryText = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                Filters = new List<Filter>();
                TList _list21 = iprot.ReadListBegin();
                for( int _i22 = 0; _i22 < _list21.Count; ++_i22)
                {
                  Filter _elem23;
                  _elem23 = new Filter();
                  _elem23.Read(iprot);
                  Filters.Add(_elem23);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              OrFilters = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                FacetRequests = new List<FacetRequest>();
                TList _list24 = iprot.ReadListBegin();
                for( int _i25 = 0; _i25 < _list24.Count; ++_i25)
                {
                  FacetRequest _elem26;
                  _elem26 = new FacetRequest();
                  _elem26.Read(iprot);
                  FacetRequests.Add(_elem26);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                SortFields = new List<SortField>();
                TList _list27 = iprot.ReadListBegin();
                for( int _i28 = 0; _i28 < _list27.Count; ++_i28)
                {
                  SortField _elem29;
                  _elem29 = new SortField();
                  _elem29.Read(iprot);
                  SortFields.Add(_elem29);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I64) {
              Offset = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              HitCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.List) {
              {
                ReturnFields = new List<string>();
                TList _list30 = iprot.ReadListBegin();
                for( int _i31 = 0; _i31 < _list30.Count; ++_i31)
                {
                  string _elem32;
                  _elem32 = iprot.ReadString();
                  ReturnFields.Add(_elem32);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.String) {
              GroupBy = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Bool) {
              GroupFacets = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.I32) {
              GroupItemsCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.String) {
              GroupItemsSort = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 60:
            if (field.Type == TType.Bool) {
              GroupItemsSortAscending = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 70:
            if (field.Type == TType.Bool) {
              HitsGroupsAsHits = iprot.ReadBool();
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
      TStruct struc = new TStruct("SimpleSearchQuery");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (IndexId != null && __isset.indexId) {
        field.Name = "indexId";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(IndexId);
        oprot.WriteFieldEnd();
      }
      if (Language != null && __isset.language) {
        field.Name = "language";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Language);
        oprot.WriteFieldEnd();
      }
      if (QueryText != null && __isset.queryText) {
        field.Name = "queryText";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(QueryText);
        oprot.WriteFieldEnd();
      }
      if (Filters != null && __isset.filters) {
        field.Name = "filters";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Filters.Count));
          foreach (Filter _iter33 in Filters)
          {
            _iter33.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.orFilters) {
        field.Name = "orFilters";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(OrFilters);
        oprot.WriteFieldEnd();
      }
      if (FacetRequests != null && __isset.facetRequests) {
        field.Name = "facetRequests";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, FacetRequests.Count));
          foreach (FacetRequest _iter34 in FacetRequests)
          {
            _iter34.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (SortFields != null && __isset.sortFields) {
        field.Name = "sortFields";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, SortFields.Count));
          foreach (SortField _iter35 in SortFields)
          {
            _iter35.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.offset) {
        field.Name = "offset";
        field.Type = TType.I64;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Offset);
        oprot.WriteFieldEnd();
      }
      if (__isset.hitCount) {
        field.Name = "hitCount";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(HitCount);
        oprot.WriteFieldEnd();
      }
      if (ReturnFields != null && __isset.returnFields) {
        field.Name = "returnFields";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ReturnFields.Count));
          foreach (string _iter36 in ReturnFields)
          {
            oprot.WriteString(_iter36);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (GroupBy != null && __isset.groupBy) {
        field.Name = "groupBy";
        field.Type = TType.String;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(GroupBy);
        oprot.WriteFieldEnd();
      }
      if (__isset.groupFacets) {
        field.Name = "groupFacets";
        field.Type = TType.Bool;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(GroupFacets);
        oprot.WriteFieldEnd();
      }
      if (__isset.groupItemsCount) {
        field.Name = "groupItemsCount";
        field.Type = TType.I32;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(GroupItemsCount);
        oprot.WriteFieldEnd();
      }
      if (GroupItemsSort != null && __isset.groupItemsSort) {
        field.Name = "groupItemsSort";
        field.Type = TType.String;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(GroupItemsSort);
        oprot.WriteFieldEnd();
      }
      if (__isset.groupItemsSortAscending) {
        field.Name = "groupItemsSortAscending";
        field.Type = TType.Bool;
        field.ID = 60;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(GroupItemsSortAscending);
        oprot.WriteFieldEnd();
      }
      if (__isset.hitsGroupsAsHits) {
        field.Name = "hitsGroupsAsHits";
        field.Type = TType.Bool;
        field.ID = 70;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(HitsGroupsAsHits);
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
    StringBuilder __sb = new StringBuilder("SimpleSearchQuery(");
    bool __first = true;
    if (IndexId != null && __isset.indexId) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("IndexId: ");
      __sb.Append(IndexId);
    }
    if (Language != null && __isset.language) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Language: ");
      __sb.Append(Language);
    }
    if (QueryText != null && __isset.queryText) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("QueryText: ");
      __sb.Append(QueryText);
    }
    if (Filters != null && __isset.filters) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Filters: ");
      __sb.Append(Filters);
    }
    if (__isset.orFilters) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("OrFilters: ");
      __sb.Append(OrFilters);
    }
    if (FacetRequests != null && __isset.facetRequests) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("FacetRequests: ");
      __sb.Append(FacetRequests);
    }
    if (SortFields != null && __isset.sortFields) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("SortFields: ");
      __sb.Append(SortFields);
    }
    if (__isset.offset) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Offset: ");
      __sb.Append(Offset);
    }
    if (__isset.hitCount) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("HitCount: ");
      __sb.Append(HitCount);
    }
    if (ReturnFields != null && __isset.returnFields) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ReturnFields: ");
      __sb.Append(ReturnFields);
    }
    if (GroupBy != null && __isset.groupBy) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("GroupBy: ");
      __sb.Append(GroupBy);
    }
    if (__isset.groupFacets) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("GroupFacets: ");
      __sb.Append(GroupFacets);
    }
    if (__isset.groupItemsCount) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("GroupItemsCount: ");
      __sb.Append(GroupItemsCount);
    }
    if (GroupItemsSort != null && __isset.groupItemsSort) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("GroupItemsSort: ");
      __sb.Append(GroupItemsSort);
    }
    if (__isset.groupItemsSortAscending) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("GroupItemsSortAscending: ");
      __sb.Append(GroupItemsSortAscending);
    }
    if (__isset.hitsGroupsAsHits) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("HitsGroupsAsHits: ");
      __sb.Append(HitsGroupsAsHits);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

