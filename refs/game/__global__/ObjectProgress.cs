internal sealed class ObjectProgress // TypeDefIndex: 4490
{
	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x1B4ADF0 Offset: 0x1B497F0 VA: 0x181B4ADF0
	internal void .ctor() { }

	// RVA: 0x1B4ACE0 Offset: 0x1B496E0 VA: 0x181B4ACE0
	internal void Init() { }

	// RVA: 0x1B4AB70 Offset: 0x1B49570 VA: 0x181B4AB70
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x1B4AB80 Offset: 0x1B49580 VA: 0x181B4AB80
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x1B4ADB0 Offset: 0x1B497B0 VA: 0x181B4ADB0
	private static void .cctor() { }
}
