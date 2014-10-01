/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
package com.boxalino.p13n.admin.thrift;

import org.apache.thrift.scheme.IScheme;
import org.apache.thrift.scheme.SchemeFactory;
import org.apache.thrift.scheme.StandardScheme;

import org.apache.thrift.scheme.TupleScheme;
import org.apache.thrift.protocol.TTupleProtocol;
import org.apache.thrift.protocol.TProtocolException;
import org.apache.thrift.EncodingUtils;
import org.apache.thrift.TException;
import org.apache.thrift.async.AsyncMethodCallback;
import org.apache.thrift.server.AbstractNonblockingServer.*;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;
import java.util.EnumMap;
import java.util.Set;
import java.util.HashSet;
import java.util.EnumSet;
import java.util.Collections;
import java.util.BitSet;
import java.nio.ByteBuffer;
import java.util.Arrays;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

public class ProfilePropertyValue implements org.apache.thrift.TBase<ProfilePropertyValue, ProfilePropertyValue._Fields>, java.io.Serializable, Cloneable, Comparable<ProfilePropertyValue> {
  private static final org.apache.thrift.protocol.TStruct STRUCT_DESC = new org.apache.thrift.protocol.TStruct("ProfilePropertyValue");

  private static final org.apache.thrift.protocol.TField PROFILE_ID_FIELD_DESC = new org.apache.thrift.protocol.TField("profileId", org.apache.thrift.protocol.TType.STRING, (short)1);
  private static final org.apache.thrift.protocol.TField PROPERTY_NAME_FIELD_DESC = new org.apache.thrift.protocol.TField("propertyName", org.apache.thrift.protocol.TType.STRING, (short)2);
  private static final org.apache.thrift.protocol.TField PROPERTY_VALUE_FIELD_DESC = new org.apache.thrift.protocol.TField("propertyValue", org.apache.thrift.protocol.TType.STRING, (short)3);
  private static final org.apache.thrift.protocol.TField CONFIDENCE_FIELD_DESC = new org.apache.thrift.protocol.TField("confidence", org.apache.thrift.protocol.TType.I32, (short)4);

  private static final Map<Class<? extends IScheme>, SchemeFactory> schemes = new HashMap<Class<? extends IScheme>, SchemeFactory>();
  static {
    schemes.put(StandardScheme.class, new ProfilePropertyValueStandardSchemeFactory());
    schemes.put(TupleScheme.class, new ProfilePropertyValueTupleSchemeFactory());
  }

  public String profileId; // required
  public String propertyName; // required
  public String propertyValue; // required
  public int confidence; // required

  /** The set of fields this struct contains, along with convenience methods for finding and manipulating them. */
  public enum _Fields implements org.apache.thrift.TFieldIdEnum {
    PROFILE_ID((short)1, "profileId"),
    PROPERTY_NAME((short)2, "propertyName"),
    PROPERTY_VALUE((short)3, "propertyValue"),
    CONFIDENCE((short)4, "confidence");

    private static final Map<String, _Fields> byName = new HashMap<String, _Fields>();

    static {
      for (_Fields field : EnumSet.allOf(_Fields.class)) {
        byName.put(field.getFieldName(), field);
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, or null if its not found.
     */
    public static _Fields findByThriftId(int fieldId) {
      switch(fieldId) {
        case 1: // PROFILE_ID
          return PROFILE_ID;
        case 2: // PROPERTY_NAME
          return PROPERTY_NAME;
        case 3: // PROPERTY_VALUE
          return PROPERTY_VALUE;
        case 4: // CONFIDENCE
          return CONFIDENCE;
        default:
          return null;
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, throwing an exception
     * if it is not found.
     */
    public static _Fields findByThriftIdOrThrow(int fieldId) {
      _Fields fields = findByThriftId(fieldId);
      if (fields == null) throw new IllegalArgumentException("Field " + fieldId + " doesn't exist!");
      return fields;
    }

    /**
     * Find the _Fields constant that matches name, or null if its not found.
     */
    public static _Fields findByName(String name) {
      return byName.get(name);
    }

    private final short _thriftId;
    private final String _fieldName;

    _Fields(short thriftId, String fieldName) {
      _thriftId = thriftId;
      _fieldName = fieldName;
    }

    public short getThriftFieldId() {
      return _thriftId;
    }

    public String getFieldName() {
      return _fieldName;
    }
  }

  // isset id assignments
  private static final int __CONFIDENCE_ISSET_ID = 0;
  private byte __isset_bitfield = 0;
  public static final Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> metaDataMap;
  static {
    Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> tmpMap = new EnumMap<_Fields, org.apache.thrift.meta_data.FieldMetaData>(_Fields.class);
    tmpMap.put(_Fields.PROFILE_ID, new org.apache.thrift.meta_data.FieldMetaData("profileId", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.PROPERTY_NAME, new org.apache.thrift.meta_data.FieldMetaData("propertyName", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.PROPERTY_VALUE, new org.apache.thrift.meta_data.FieldMetaData("propertyValue", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.CONFIDENCE, new org.apache.thrift.meta_data.FieldMetaData("confidence", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.I32)));
    metaDataMap = Collections.unmodifiableMap(tmpMap);
    org.apache.thrift.meta_data.FieldMetaData.addStructMetaDataMap(ProfilePropertyValue.class, metaDataMap);
  }

  public ProfilePropertyValue() {
  }

  public ProfilePropertyValue(
    String profileId,
    String propertyName,
    String propertyValue,
    int confidence)
  {
    this();
    this.profileId = profileId;
    this.propertyName = propertyName;
    this.propertyValue = propertyValue;
    this.confidence = confidence;
    setConfidenceIsSet(true);
  }

  /**
   * Performs a deep copy on <i>other</i>.
   */
  public ProfilePropertyValue(ProfilePropertyValue other) {
    __isset_bitfield = other.__isset_bitfield;
    if (other.isSetProfileId()) {
      this.profileId = other.profileId;
    }
    if (other.isSetPropertyName()) {
      this.propertyName = other.propertyName;
    }
    if (other.isSetPropertyValue()) {
      this.propertyValue = other.propertyValue;
    }
    this.confidence = other.confidence;
  }

  public ProfilePropertyValue deepCopy() {
    return new ProfilePropertyValue(this);
  }

  @Override
  public void clear() {
    this.profileId = null;
    this.propertyName = null;
    this.propertyValue = null;
    setConfidenceIsSet(false);
    this.confidence = 0;
  }

  public String getProfileId() {
    return this.profileId;
  }

  public ProfilePropertyValue setProfileId(String profileId) {
    this.profileId = profileId;
    return this;
  }

  public void unsetProfileId() {
    this.profileId = null;
  }

  /** Returns true if field profileId is set (has been assigned a value) and false otherwise */
  public boolean isSetProfileId() {
    return this.profileId != null;
  }

  public void setProfileIdIsSet(boolean value) {
    if (!value) {
      this.profileId = null;
    }
  }

  public String getPropertyName() {
    return this.propertyName;
  }

  public ProfilePropertyValue setPropertyName(String propertyName) {
    this.propertyName = propertyName;
    return this;
  }

  public void unsetPropertyName() {
    this.propertyName = null;
  }

  /** Returns true if field propertyName is set (has been assigned a value) and false otherwise */
  public boolean isSetPropertyName() {
    return this.propertyName != null;
  }

  public void setPropertyNameIsSet(boolean value) {
    if (!value) {
      this.propertyName = null;
    }
  }

  public String getPropertyValue() {
    return this.propertyValue;
  }

  public ProfilePropertyValue setPropertyValue(String propertyValue) {
    this.propertyValue = propertyValue;
    return this;
  }

  public void unsetPropertyValue() {
    this.propertyValue = null;
  }

  /** Returns true if field propertyValue is set (has been assigned a value) and false otherwise */
  public boolean isSetPropertyValue() {
    return this.propertyValue != null;
  }

  public void setPropertyValueIsSet(boolean value) {
    if (!value) {
      this.propertyValue = null;
    }
  }

  public int getConfidence() {
    return this.confidence;
  }

  public ProfilePropertyValue setConfidence(int confidence) {
    this.confidence = confidence;
    setConfidenceIsSet(true);
    return this;
  }

  public void unsetConfidence() {
    __isset_bitfield = EncodingUtils.clearBit(__isset_bitfield, __CONFIDENCE_ISSET_ID);
  }

  /** Returns true if field confidence is set (has been assigned a value) and false otherwise */
  public boolean isSetConfidence() {
    return EncodingUtils.testBit(__isset_bitfield, __CONFIDENCE_ISSET_ID);
  }

  public void setConfidenceIsSet(boolean value) {
    __isset_bitfield = EncodingUtils.setBit(__isset_bitfield, __CONFIDENCE_ISSET_ID, value);
  }

  public void setFieldValue(_Fields field, Object value) {
    switch (field) {
    case PROFILE_ID:
      if (value == null) {
        unsetProfileId();
      } else {
        setProfileId((String)value);
      }
      break;

    case PROPERTY_NAME:
      if (value == null) {
        unsetPropertyName();
      } else {
        setPropertyName((String)value);
      }
      break;

    case PROPERTY_VALUE:
      if (value == null) {
        unsetPropertyValue();
      } else {
        setPropertyValue((String)value);
      }
      break;

    case CONFIDENCE:
      if (value == null) {
        unsetConfidence();
      } else {
        setConfidence((Integer)value);
      }
      break;

    }
  }

  public Object getFieldValue(_Fields field) {
    switch (field) {
    case PROFILE_ID:
      return getProfileId();

    case PROPERTY_NAME:
      return getPropertyName();

    case PROPERTY_VALUE:
      return getPropertyValue();

    case CONFIDENCE:
      return Integer.valueOf(getConfidence());

    }
    throw new IllegalStateException();
  }

  /** Returns true if field corresponding to fieldID is set (has been assigned a value) and false otherwise */
  public boolean isSet(_Fields field) {
    if (field == null) {
      throw new IllegalArgumentException();
    }

    switch (field) {
    case PROFILE_ID:
      return isSetProfileId();
    case PROPERTY_NAME:
      return isSetPropertyName();
    case PROPERTY_VALUE:
      return isSetPropertyValue();
    case CONFIDENCE:
      return isSetConfidence();
    }
    throw new IllegalStateException();
  }

  @Override
  public boolean equals(Object that) {
    if (that == null)
      return false;
    if (that instanceof ProfilePropertyValue)
      return this.equals((ProfilePropertyValue)that);
    return false;
  }

  public boolean equals(ProfilePropertyValue that) {
    if (that == null)
      return false;

    boolean this_present_profileId = true && this.isSetProfileId();
    boolean that_present_profileId = true && that.isSetProfileId();
    if (this_present_profileId || that_present_profileId) {
      if (!(this_present_profileId && that_present_profileId))
        return false;
      if (!this.profileId.equals(that.profileId))
        return false;
    }

    boolean this_present_propertyName = true && this.isSetPropertyName();
    boolean that_present_propertyName = true && that.isSetPropertyName();
    if (this_present_propertyName || that_present_propertyName) {
      if (!(this_present_propertyName && that_present_propertyName))
        return false;
      if (!this.propertyName.equals(that.propertyName))
        return false;
    }

    boolean this_present_propertyValue = true && this.isSetPropertyValue();
    boolean that_present_propertyValue = true && that.isSetPropertyValue();
    if (this_present_propertyValue || that_present_propertyValue) {
      if (!(this_present_propertyValue && that_present_propertyValue))
        return false;
      if (!this.propertyValue.equals(that.propertyValue))
        return false;
    }

    boolean this_present_confidence = true;
    boolean that_present_confidence = true;
    if (this_present_confidence || that_present_confidence) {
      if (!(this_present_confidence && that_present_confidence))
        return false;
      if (this.confidence != that.confidence)
        return false;
    }

    return true;
  }

  @Override
  public int hashCode() {
    return 0;
  }

  @Override
  public int compareTo(ProfilePropertyValue other) {
    if (!getClass().equals(other.getClass())) {
      return getClass().getName().compareTo(other.getClass().getName());
    }

    int lastComparison = 0;

    lastComparison = Boolean.valueOf(isSetProfileId()).compareTo(other.isSetProfileId());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetProfileId()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.profileId, other.profileId);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetPropertyName()).compareTo(other.isSetPropertyName());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetPropertyName()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.propertyName, other.propertyName);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetPropertyValue()).compareTo(other.isSetPropertyValue());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetPropertyValue()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.propertyValue, other.propertyValue);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetConfidence()).compareTo(other.isSetConfidence());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetConfidence()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.confidence, other.confidence);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    return 0;
  }

  public _Fields fieldForId(int fieldId) {
    return _Fields.findByThriftId(fieldId);
  }

  public void read(org.apache.thrift.protocol.TProtocol iprot) throws org.apache.thrift.TException {
    schemes.get(iprot.getScheme()).getScheme().read(iprot, this);
  }

  public void write(org.apache.thrift.protocol.TProtocol oprot) throws org.apache.thrift.TException {
    schemes.get(oprot.getScheme()).getScheme().write(oprot, this);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder("ProfilePropertyValue(");
    boolean first = true;

    sb.append("profileId:");
    if (this.profileId == null) {
      sb.append("null");
    } else {
      sb.append(this.profileId);
    }
    first = false;
    if (!first) sb.append(", ");
    sb.append("propertyName:");
    if (this.propertyName == null) {
      sb.append("null");
    } else {
      sb.append(this.propertyName);
    }
    first = false;
    if (!first) sb.append(", ");
    sb.append("propertyValue:");
    if (this.propertyValue == null) {
      sb.append("null");
    } else {
      sb.append(this.propertyValue);
    }
    first = false;
    if (!first) sb.append(", ");
    sb.append("confidence:");
    sb.append(this.confidence);
    first = false;
    sb.append(")");
    return sb.toString();
  }

  public void validate() throws org.apache.thrift.TException {
    // check for required fields
    // check for sub-struct validity
  }

  private void writeObject(java.io.ObjectOutputStream out) throws java.io.IOException {
    try {
      write(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(out)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private void readObject(java.io.ObjectInputStream in) throws java.io.IOException, ClassNotFoundException {
    try {
      // it doesn't seem like you should have to do this, but java serialization is wacky, and doesn't call the default constructor.
      __isset_bitfield = 0;
      read(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(in)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private static class ProfilePropertyValueStandardSchemeFactory implements SchemeFactory {
    public ProfilePropertyValueStandardScheme getScheme() {
      return new ProfilePropertyValueStandardScheme();
    }
  }

  private static class ProfilePropertyValueStandardScheme extends StandardScheme<ProfilePropertyValue> {

    public void read(org.apache.thrift.protocol.TProtocol iprot, ProfilePropertyValue struct) throws org.apache.thrift.TException {
      org.apache.thrift.protocol.TField schemeField;
      iprot.readStructBegin();
      while (true)
      {
        schemeField = iprot.readFieldBegin();
        if (schemeField.type == org.apache.thrift.protocol.TType.STOP) { 
          break;
        }
        switch (schemeField.id) {
          case 1: // PROFILE_ID
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.profileId = iprot.readString();
              struct.setProfileIdIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 2: // PROPERTY_NAME
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.propertyName = iprot.readString();
              struct.setPropertyNameIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 3: // PROPERTY_VALUE
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.propertyValue = iprot.readString();
              struct.setPropertyValueIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 4: // CONFIDENCE
            if (schemeField.type == org.apache.thrift.protocol.TType.I32) {
              struct.confidence = iprot.readI32();
              struct.setConfidenceIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          default:
            org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
        }
        iprot.readFieldEnd();
      }
      iprot.readStructEnd();

      // check for required fields of primitive type, which can't be checked in the validate method
      struct.validate();
    }

    public void write(org.apache.thrift.protocol.TProtocol oprot, ProfilePropertyValue struct) throws org.apache.thrift.TException {
      struct.validate();

      oprot.writeStructBegin(STRUCT_DESC);
      if (struct.profileId != null) {
        oprot.writeFieldBegin(PROFILE_ID_FIELD_DESC);
        oprot.writeString(struct.profileId);
        oprot.writeFieldEnd();
      }
      if (struct.propertyName != null) {
        oprot.writeFieldBegin(PROPERTY_NAME_FIELD_DESC);
        oprot.writeString(struct.propertyName);
        oprot.writeFieldEnd();
      }
      if (struct.propertyValue != null) {
        oprot.writeFieldBegin(PROPERTY_VALUE_FIELD_DESC);
        oprot.writeString(struct.propertyValue);
        oprot.writeFieldEnd();
      }
      oprot.writeFieldBegin(CONFIDENCE_FIELD_DESC);
      oprot.writeI32(struct.confidence);
      oprot.writeFieldEnd();
      oprot.writeFieldStop();
      oprot.writeStructEnd();
    }

  }

  private static class ProfilePropertyValueTupleSchemeFactory implements SchemeFactory {
    public ProfilePropertyValueTupleScheme getScheme() {
      return new ProfilePropertyValueTupleScheme();
    }
  }

  private static class ProfilePropertyValueTupleScheme extends TupleScheme<ProfilePropertyValue> {

    @Override
    public void write(org.apache.thrift.protocol.TProtocol prot, ProfilePropertyValue struct) throws org.apache.thrift.TException {
      TTupleProtocol oprot = (TTupleProtocol) prot;
      BitSet optionals = new BitSet();
      if (struct.isSetProfileId()) {
        optionals.set(0);
      }
      if (struct.isSetPropertyName()) {
        optionals.set(1);
      }
      if (struct.isSetPropertyValue()) {
        optionals.set(2);
      }
      if (struct.isSetConfidence()) {
        optionals.set(3);
      }
      oprot.writeBitSet(optionals, 4);
      if (struct.isSetProfileId()) {
        oprot.writeString(struct.profileId);
      }
      if (struct.isSetPropertyName()) {
        oprot.writeString(struct.propertyName);
      }
      if (struct.isSetPropertyValue()) {
        oprot.writeString(struct.propertyValue);
      }
      if (struct.isSetConfidence()) {
        oprot.writeI32(struct.confidence);
      }
    }

    @Override
    public void read(org.apache.thrift.protocol.TProtocol prot, ProfilePropertyValue struct) throws org.apache.thrift.TException {
      TTupleProtocol iprot = (TTupleProtocol) prot;
      BitSet incoming = iprot.readBitSet(4);
      if (incoming.get(0)) {
        struct.profileId = iprot.readString();
        struct.setProfileIdIsSet(true);
      }
      if (incoming.get(1)) {
        struct.propertyName = iprot.readString();
        struct.setPropertyNameIsSet(true);
      }
      if (incoming.get(2)) {
        struct.propertyValue = iprot.readString();
        struct.setPropertyValueIsSet(true);
      }
      if (incoming.get(3)) {
        struct.confidence = iprot.readI32();
        struct.setConfidenceIsSet(true);
      }
    }
  }

}

