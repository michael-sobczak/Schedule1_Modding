internal struct Zip64EndOfCentralDirectoryRecord // TypeDefIndex: 17666
{
	// Fields
	public ulong SizeOfThisRecord; // 0x0
	public ushort VersionMadeBy; // 0x8
	public ushort VersionNeededToExtract; // 0xA
	public uint NumberOfThisDisk; // 0xC
	public uint NumberOfDiskWithStartOfCD; // 0x10
	public ulong NumberOfEntriesOnThisDisk; // 0x18
	public ulong NumberOfEntriesTotal; // 0x20
	public ulong SizeOfCentralDirectory; // 0x28
	public ulong OffsetOfCentralDirectory; // 0x30

	// Methods

	// RVA: 0x21733F0 Offset: 0x2171DF0 VA: 0x1821733F0
	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord) { }

	// RVA: 0x2173550 Offset: 0x2171F50 VA: 0x182173550
	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory) { }
}
