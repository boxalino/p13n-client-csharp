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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class AutocompleteResponse : TBase
{
  private List<AutocompleteHit> _hits;
  private SearchResult _prefixSearchResult;

  public List<AutocompleteHit> Hits
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

  public SearchResult PrefixSearchResult
  {
    get
    {
      return _prefixSearchResult;
    }
    set
    {
      __isset.prefixSearchResult = true;
      this._prefixSearchResult = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool hits;
    public bool prefixSearchResult;
  }

  public AutocompleteResponse() {
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
        case 11:
          if (field.Type == TType.List) {
            {
              Hits = new List<AutocompleteHit>();
              TList _list122 = iprot.ReadListBegin();
              for( int _i123 = 0; _i123 < _list122.Count; ++_i123)
              {
                AutocompleteHit _elem124;
                _elem124 = new AutocompleteHit();
                _elem124.Read(iprot);
                Hits.Add(_elem124);
              }
              iprot.ReadListEnd();
            }
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 21:
          if (field.Type == TType.Struct) {
            PrefixSearchResult = new SearchResult();
            PrefixSearchResult.Read(iprot);
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
    TStruct struc = new TStruct("AutocompleteResponse");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (Hits != null && __isset.hits) {
      field.Name = "hits";
      field.Type = TType.List;
      field.ID = 11;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Hits.Count));
        foreach (AutocompleteHit _iter125 in Hits)
        {
          _iter125.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
    }
    if (PrefixSearchResult != null && __isset.prefixSearchResult) {
      field.Name = "prefixSearchResult";
      field.Type = TType.Struct;
      field.ID = 21;
      oprot.WriteFieldBegin(field);
      PrefixSearchResult.Write(oprot);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("AutocompleteResponse(");
    bool __first = true;
    if (Hits != null && __isset.hits) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Hits: ");
      __sb.Append(Hits);
    }
    if (PrefixSearchResult != null && __isset.prefixSearchResult) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("PrefixSearchResult: ");
      __sb.Append(PrefixSearchResult== null ? "<null>" : PrefixSearchResult.ToString());
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

