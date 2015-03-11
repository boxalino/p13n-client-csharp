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

namespace com.boxalino.p13n.api.thrift
{

  /// <summary>
  /// <dl>
  /// <dt>variantId</dt>
  /// <dd>id of the personalized variant</dd>
  /// 
  /// <dt>scenarioId</dt>
  /// <dd>scenario identificator used to produce recommendation result or search
  /// result personalization</dd>
  /// 
  /// <dt>searchResult</dt>
  /// <dd>result of the search request for recommendations and search requests</dd>
  /// 
  /// <dt>searchResultTitle</dt>
  /// <dd>recommendation's result title localized in language requested in
  /// corresponding SimpleSearchQuery</dd>
  /// 
  /// <dt>searchRelaxation</dt>
  /// <dd>When the service considers queryText invalid, it will evaluate and return
  /// relaxations if it is requested in corresponding ChoiceInquiry and if
  /// relaxations could be found.</dd>
  /// <dd>Note that original query still could yield some results; it is up to the
  /// client to decide whether searchRelaxations should be used (with displaying
  /// appropriate message) or not.</dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Variant : TBase
  {
    private string _variantId;
    private string _scenarioId;
    private SearchResult _searchResult;
    private string _searchResultTitle;
    private SearchRelaxation _searchRelaxation;
    private List<SearchResult> _semanticFilteringResults;

    public string VariantId
    {
      get
      {
        return _variantId;
      }
      set
      {
        __isset.variantId = true;
        this._variantId = value;
      }
    }

    public string ScenarioId
    {
      get
      {
        return _scenarioId;
      }
      set
      {
        __isset.scenarioId = true;
        this._scenarioId = value;
      }
    }

    public SearchResult SearchResult
    {
      get
      {
        return _searchResult;
      }
      set
      {
        __isset.searchResult = true;
        this._searchResult = value;
      }
    }

    public string SearchResultTitle
    {
      get
      {
        return _searchResultTitle;
      }
      set
      {
        __isset.searchResultTitle = true;
        this._searchResultTitle = value;
      }
    }

    public SearchRelaxation SearchRelaxation
    {
      get
      {
        return _searchRelaxation;
      }
      set
      {
        __isset.searchRelaxation = true;
        this._searchRelaxation = value;
      }
    }

    public List<SearchResult> SemanticFilteringResults
    {
      get
      {
        return _semanticFilteringResults;
      }
      set
      {
        __isset.semanticFilteringResults = true;
        this._semanticFilteringResults = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool variantId;
      public bool scenarioId;
      public bool searchResult;
      public bool searchResultTitle;
      public bool searchRelaxation;
      public bool semanticFilteringResults;
    }

    public Variant() {
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
            if (field.Type == TType.String) {
              VariantId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              ScenarioId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              SearchResult = new SearchResult();
              SearchResult.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              SearchResultTitle = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.Struct) {
              SearchRelaxation = new SearchRelaxation();
              SearchRelaxation.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 60:
            if (field.Type == TType.List) {
              {
                SemanticFilteringResults = new List<SearchResult>();
                TList _list90 = iprot.ReadListBegin();
                for( int _i91 = 0; _i91 < _list90.Count; ++_i91)
                {
                  SearchResult _elem92;
                  _elem92 = new SearchResult();
                  _elem92.Read(iprot);
                  SemanticFilteringResults.Add(_elem92);
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
      TStruct struc = new TStruct("Variant");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (VariantId != null && __isset.variantId) {
        field.Name = "variantId";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(VariantId);
        oprot.WriteFieldEnd();
      }
      if (ScenarioId != null && __isset.scenarioId) {
        field.Name = "scenarioId";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ScenarioId);
        oprot.WriteFieldEnd();
      }
      if (SearchResult != null && __isset.searchResult) {
        field.Name = "searchResult";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        SearchResult.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (SearchResultTitle != null && __isset.searchResultTitle) {
        field.Name = "searchResultTitle";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SearchResultTitle);
        oprot.WriteFieldEnd();
      }
      if (SearchRelaxation != null && __isset.searchRelaxation) {
        field.Name = "searchRelaxation";
        field.Type = TType.Struct;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        SearchRelaxation.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (SemanticFilteringResults != null && __isset.semanticFilteringResults) {
        field.Name = "semanticFilteringResults";
        field.Type = TType.List;
        field.ID = 60;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, SemanticFilteringResults.Count));
          foreach (SearchResult _iter93 in SemanticFilteringResults)
          {
            _iter93.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Variant(");
      bool __first = true;
      if (VariantId != null && __isset.variantId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("VariantId: ");
        __sb.Append(VariantId);
      }
      if (ScenarioId != null && __isset.scenarioId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ScenarioId: ");
        __sb.Append(ScenarioId);
      }
      if (SearchResult != null && __isset.searchResult) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SearchResult: ");
        __sb.Append(SearchResult== null ? "<null>" : SearchResult.ToString());
      }
      if (SearchResultTitle != null && __isset.searchResultTitle) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SearchResultTitle: ");
        __sb.Append(SearchResultTitle);
      }
      if (SearchRelaxation != null && __isset.searchRelaxation) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SearchRelaxation: ");
        __sb.Append(SearchRelaxation== null ? "<null>" : SearchRelaxation.ToString());
      }
      if (SemanticFilteringResults != null && __isset.semanticFilteringResults) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SemanticFilteringResults: ");
        __sb.Append(SemanticFilteringResults);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
