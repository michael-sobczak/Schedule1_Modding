internal sealed class SerializationHeaderRecord // TypeDefIndex: 4472
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x1B56A30 Offset: 0x1B55430 VA: 0x181B56A30
	internal void .ctor() { }

	// RVA: 0x1B56A40 Offset: 0x1B55440 VA: 0x181B56A40
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x1B56950 Offset: 0x1B55350 VA: 0x181B56950 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1B566A0 Offset: 0x1B550A0 VA: 0x181B566A0
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x1B56710 Offset: 0x1B55110 VA: 0x181B56710 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Dump() { }
}
