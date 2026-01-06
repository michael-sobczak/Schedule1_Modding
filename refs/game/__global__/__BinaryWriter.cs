internal sealed class __BinaryWriter // TypeDefIndex: 4493
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x1B5E190 Offset: 0x1B5CB90 VA: 0x181B5E190
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void WriteBegin() { }

	// RVA: 0x1B5BB80 Offset: 0x1B5A580 VA: 0x181B5BB80
	internal void WriteEnd() { }

	// RVA: 0x1B5B910 Offset: 0x1B5A310 VA: 0x181B5B910
	internal void WriteBoolean(bool value) { }

	// RVA: 0x1AEAC70 Offset: 0x1AE9670 VA: 0x181AEAC70
	internal void WriteByte(byte value) { }

	// RVA: 0x1B5B940 Offset: 0x1B5A340 VA: 0x181B5B940
	private void WriteBytes(byte[] value) { }

	// RVA: 0x1B5B970 Offset: 0x1B5A370 VA: 0x181B5B970
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x1B5B9A0 Offset: 0x1B5A3A0 VA: 0x181B5B9A0
	internal void WriteChar(char value) { }

	// RVA: 0x1B5B9D0 Offset: 0x1B5A3D0 VA: 0x181B5B9D0
	internal void WriteChars(char[] value) { }

	// RVA: 0x1B5BA80 Offset: 0x1B5A480 VA: 0x181B5BA80
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x1B5D770 Offset: 0x1B5C170 VA: 0x181B5D770
	internal void WriteSingle(float value) { }

	// RVA: 0x1B5BB50 Offset: 0x1B5A550 VA: 0x181B5BB50
	internal void WriteDouble(double value) { }

	// RVA: 0x1B5BBB0 Offset: 0x1B5A5B0 VA: 0x181B5BBB0
	internal void WriteInt16(short value) { }

	// RVA: 0x1B5BBE0 Offset: 0x1B5A5E0 VA: 0x181B5BBE0
	internal void WriteInt32(int value) { }

	// RVA: 0x1B5BC10 Offset: 0x1B5A610 VA: 0x181B5BC10
	internal void WriteInt64(long value) { }

	// RVA: 0x1AEAC70 Offset: 0x1AE9670 VA: 0x181AEAC70
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x1B5D7A0 Offset: 0x1B5C1A0 VA: 0x181B5D7A0
	internal void WriteString(string value) { }

	// RVA: 0x1B5D7D0 Offset: 0x1B5C1D0 VA: 0x181B5D7D0
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x1B5BA00 Offset: 0x1B5A400 VA: 0x181B5BA00
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x1B5D850 Offset: 0x1B5C250 VA: 0x181B5D850
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x1B5D880 Offset: 0x1B5C280 VA: 0x181B5D880
	internal void WriteUInt32(uint value) { }

	// RVA: 0x1B5D8B0 Offset: 0x1B5C2B0 VA: 0x181B5D8B0
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1B5D080 Offset: 0x1B5BA80 VA: 0x181B5D080
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x1B5D100 Offset: 0x1B5BB00 VA: 0x181B5D100
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x1B5C250 Offset: 0x1B5AC50 VA: 0x181B5C250
	internal void WriteMethodCall() { }

	// RVA: 0x1B5C2E0 Offset: 0x1B5ACE0 VA: 0x181B5C2E0
	internal void WriteMethodReturn() { }

	// RVA: 0x1B5C5D0 Offset: 0x1B5AFD0 VA: 0x181B5C5D0
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x1B5C4B0 Offset: 0x1B5AEB0 VA: 0x181B5C4B0
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x1B5D240 Offset: 0x1B5BC40 VA: 0x181B5D240
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x1B5B650 Offset: 0x1B5A050 VA: 0x181B5B650
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x1B5BCF0 Offset: 0x1B5A6F0 VA: 0x181B5BCF0
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x1B5CED0 Offset: 0x1B5B8D0 VA: 0x181B5CED0
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x1B5C450 Offset: 0x1B5AE50 VA: 0x181B5C450
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x1B5C080 Offset: 0x1B5AA80 VA: 0x181B5C080
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x1B5C380 Offset: 0x1B5AD80 VA: 0x181B5C380
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1B5BF20 Offset: 0x1B5A920 VA: 0x181B5BF20
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x1B5BEF0 Offset: 0x1B5A8F0 VA: 0x181B5BEF0
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x1B5C020 Offset: 0x1B5AA20 VA: 0x181B5C020
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x1B5BC90 Offset: 0x1B5A690 VA: 0x181B5BC90
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x1B5C370 Offset: 0x1B5AD70 VA: 0x181B5C370
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1B5BB40 Offset: 0x1B5A540 VA: 0x181B5BB40
	internal void WriteDelayedNullItem() { }

	// RVA: 0x1B5BC40 Offset: 0x1B5A640 VA: 0x181B5BC40
	internal void WriteItemEnd() { }

	// RVA: 0x1B5B5A0 Offset: 0x1B59FA0 VA: 0x181B5B5A0
	private void InternalWriteItemNull() { }

	// RVA: 0x1B5BC50 Offset: 0x1B5A650 VA: 0x181B5BC50
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x1B5B7B0 Offset: 0x1B5A1B0 VA: 0x181B5B7B0
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x1B5D8E0 Offset: 0x1B5C2E0 VA: 0x181B5D8E0
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}
