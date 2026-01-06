internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 4483
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B45B70 Offset: 0x1B44570 VA: 0x181B45B70
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x1B45C10 Offset: 0x1B44610 VA: 0x181B45C10 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1B45860 Offset: 0x1B44260 VA: 0x181B45860 Slot: 5
	public void Read(__BinaryParser input) { }
}
