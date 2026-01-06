internal struct Zip64EndOfCentralDirectoryLocator // TypeDefIndex: 17665
{
	// Fields
	public uint NumberOfDiskWithZip64EOCD; // 0x0
	public ulong OffsetOfZip64EOCD; // 0x8
	public uint TotalNumberOfDisks; // 0x10

	// Methods

	// RVA: 0x2173260 Offset: 0x2171C60 VA: 0x182173260
	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator) { }

	// RVA: 0x2173310 Offset: 0x2171D10 VA: 0x182173310
	public static void WriteBlock(Stream stream, long zip64EOCDRecordStart) { }
}
