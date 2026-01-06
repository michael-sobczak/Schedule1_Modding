internal sealed class BinaryAssembly // TypeDefIndex: 4473
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B433C0 Offset: 0x1B41DC0 VA: 0x181B433C0
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x1B433E0 Offset: 0x1B41DE0 VA: 0x181B433E0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1B43370 Offset: 0x1B41D70 VA: 0x181B43370 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Dump() { }
}
