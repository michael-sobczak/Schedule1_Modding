internal sealed class ObjectMapInfo // TypeDefIndex: 4494
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x1B49EA0 Offset: 0x1B488A0 VA: 0x181B49EA0
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1B49F10 Offset: 0x1B48910 VA: 0x181B49F10
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}
