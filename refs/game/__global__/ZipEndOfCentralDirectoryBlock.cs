internal struct ZipEndOfCentralDirectoryBlock // TypeDefIndex: 17669
{
	// Fields
	public uint Signature; // 0x0
	public ushort NumberOfThisDisk; // 0x4
	public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory; // 0x6
	public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk; // 0x8
	public ushort NumberOfEntriesInTheCentralDirectory; // 0xA
	public uint SizeOfCentralDirectory; // 0xC
	public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber; // 0x10
	public byte[] ArchiveComment; // 0x18

	// Methods

	// RVA: 0x217B090 Offset: 0x2179A90 VA: 0x18217B090
	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory, byte[] archiveComment) { }

	// RVA: 0x217AF50 Offset: 0x2179950 VA: 0x18217AF50
	public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock) { }
}
