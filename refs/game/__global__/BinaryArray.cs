internal sealed class BinaryArray // TypeDefIndex: 4484
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B43210 Offset: 0x1B41C10 VA: 0x181B43210
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1B42DE0 Offset: 0x1B417E0 VA: 0x181B42DE0
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x1B42EA0 Offset: 0x1B418A0 VA: 0x181B42EA0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1B42890 Offset: 0x1B41290 VA: 0x181B42890 Slot: 5
	public void Read(__BinaryParser input) { }
}
