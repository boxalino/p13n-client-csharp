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
  /// parameters of request context. Usually browser, platform, etc.
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RequestContext : TBase
  {
    private Dictionary<string, List<string>> _parameters;

    public Dictionary<string, List<string>> Parameters
    {
      get
      {
        return _parameters;
      }
      set
      {
        __isset.parameters = true;
        this._parameters = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool parameters;
    }

    public RequestContext() {
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
            if (field.Type == TType.Map) {
              {
                Parameters = new Dictionary<string, List<string>>();
                TMap _map40 = iprot.ReadMapBegin();
                for( int _i41 = 0; _i41 < _map40.Count; ++_i41)
                {
                  string _key42;
                  List<string> _val43;
                  _key42 = iprot.ReadString();
                  {
                    _val43 = new List<string>();
                    TList _list44 = iprot.ReadListBegin();
                    for( int _i45 = 0; _i45 < _list44.Count; ++_i45)
                    {
                      string _elem46;
                      _elem46 = iprot.ReadString();
                      _val43.Add(_elem46);
                    }
                    iprot.ReadListEnd();
                  }
                  Parameters[_key42] = _val43;
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("RequestContext");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Parameters != null && __isset.parameters) {
        field.Name = "parameters";
        field.Type = TType.Map;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.List, Parameters.Count));
          foreach (string _iter47 in Parameters.Keys)
          {
            oprot.WriteString(_iter47);
            {
              oprot.WriteListBegin(new TList(TType.String, Parameters[_iter47].Count));
              foreach (string _iter48 in Parameters[_iter47])
              {
                oprot.WriteString(_iter48);
              }
              oprot.WriteListEnd();
            }
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("RequestContext(");
      bool __first = true;
      if (Parameters != null && __isset.parameters) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Parameters: ");
        __sb.Append(Parameters);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
