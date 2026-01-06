internal sealed class BinaryObjectWithMap // TypeDefIndex: 4482
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B45F60 Offset: 0x1B44960 VA: 0x181B45F60
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x1B45FC0 Offset: 0x1B449C0 VA: 0x181B45FC0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1B45E30 Offset: 0x1B44830 VA: 0x181B45E30 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Dump() { }
}
