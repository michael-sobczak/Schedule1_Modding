internal sealed class __BinaryParser // TypeDefIndex: 4504
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x1B7C740 Offset: 0x1B7B140 VA: 0x181B7C740
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x1B7CA10 Offset: 0x1B7B410 VA: 0x181B7CA10
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x1B7C940 Offset: 0x1B7B340 VA: 0x181B7C940
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x1B7C870 Offset: 0x1B7B270 VA: 0x181B7C870
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x1B7CAE0 Offset: 0x1B7B4E0 VA: 0x181B7CAE0
	internal ParseRecord get_prs() { }

	// RVA: 0x1B7C0D0 Offset: 0x1B7AAD0 VA: 0x181B7C0D0
	internal void Run() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void ReadBegin() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void ReadEnd() { }

	// RVA: 0x1B78230 Offset: 0x1B76C30 VA: 0x181B78230
	internal bool ReadBoolean() { }

	// RVA: 0x1B78260 Offset: 0x1B76C60 VA: 0x181B78260
	internal byte ReadByte() { }

	// RVA: 0x1B78290 Offset: 0x1B76C90 VA: 0x181B78290
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x1B782C0 Offset: 0x1B76CC0 VA: 0x181B782C0
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x1B78360 Offset: 0x1B76D60 VA: 0x181B78360
	internal char ReadChar() { }

	// RVA: 0x1B78390 Offset: 0x1B76D90 VA: 0x181B78390
	internal char[] ReadChars(int length) { }

	// RVA: 0x1B78610 Offset: 0x1B77010 VA: 0x181B78610
	internal Decimal ReadDecimal() { }

	// RVA: 0x1B7B9D0 Offset: 0x1B7A3D0 VA: 0x181B7B9D0
	internal float ReadSingle() { }

	// RVA: 0x1B786E0 Offset: 0x1B770E0 VA: 0x181B786E0
	internal double ReadDouble() { }

	// RVA: 0x1A454F0 Offset: 0x1A43EF0 VA: 0x181A454F0
	internal short ReadInt16() { }

	// RVA: 0x1B78710 Offset: 0x1B77110 VA: 0x181B78710
	internal int ReadInt32() { }

	// RVA: 0x1B78740 Offset: 0x1B77140 VA: 0x181B78740
	internal long ReadInt64() { }

	// RVA: 0x1B78260 Offset: 0x1B76C60 VA: 0x181B78260
	internal sbyte ReadSByte() { }

	// RVA: 0x1B7BA00 Offset: 0x1B7A400 VA: 0x181B7BA00
	internal string ReadString() { }

	// RVA: 0x1B78740 Offset: 0x1B77140 VA: 0x181B78740
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x1B785A0 Offset: 0x1B76FA0 VA: 0x181B785A0
	internal DateTime ReadDateTime() { }

	// RVA: 0x1B7BA30 Offset: 0x1B7A430 VA: 0x181B7BA30
	internal ushort ReadUInt16() { }

	// RVA: 0x1B7BA60 Offset: 0x1B7A460 VA: 0x181B7BA60
	internal uint ReadUInt32() { }

	// RVA: 0x1B7BA90 Offset: 0x1B7A490 VA: 0x181B7BA90
	internal ulong ReadUInt64() { }

	// RVA: 0x1B7B910 Offset: 0x1B7A310 VA: 0x181B7B910
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x1B77F90 Offset: 0x1B76990 VA: 0x181B77F90
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B7B3C0 Offset: 0x1B79DC0 VA: 0x181B7B3C0
	private void ReadObject() { }

	// RVA: 0x1B783C0 Offset: 0x1B76DC0 VA: 0x181B783C0
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x1B7AD30 Offset: 0x1B79730 VA: 0x181B7AD30
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B7AE00 Offset: 0x1B79800 VA: 0x181B7AE00
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x1B7A620 Offset: 0x1B79020 VA: 0x181B7A620
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B7A6E0 Offset: 0x1B790E0 VA: 0x181B7A6E0
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x1B79C00 Offset: 0x1B78600 VA: 0x181B79C00
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B78770 Offset: 0x1B77170 VA: 0x181B78770
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x1B77860 Offset: 0x1B76260 VA: 0x181B77860
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B77540 Offset: 0x1B75F40 VA: 0x181B77540
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x1B78DA0 Offset: 0x1B777A0 VA: 0x181B78DA0
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x1B79310 Offset: 0x1B77D10 VA: 0x181B79310
	private void ReadMemberReference() { }

	// RVA: 0x1B79880 Offset: 0x1B78280 VA: 0x181B79880
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B796D0 Offset: 0x1B780D0 VA: 0x181B796D0
	private void ReadMessageEnd() { }

	// RVA: 0x1B7BAC0 Offset: 0x1B7A4C0 VA: 0x181B7BAC0
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B773F0 Offset: 0x1B75DF0 VA: 0x181B773F0
	private ObjectProgress GetOp() { }

	// RVA: 0x1B774A0 Offset: 0x1B75EA0 VA: 0x181B774A0
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x1B7C6C0 Offset: 0x1B7B0C0 VA: 0x181B7C6C0
	private static void .cctor() { }
}
