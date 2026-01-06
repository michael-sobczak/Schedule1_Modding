internal sealed class ValueFixup // TypeDefIndex: 4510
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x1B76F70 Offset: 0x1B75970 VA: 0x181B76F70
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x1B76FD0 Offset: 0x1B759D0 VA: 0x181B76FD0
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x1B76C20 Offset: 0x1B75620 VA: 0x181B76C20
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}
