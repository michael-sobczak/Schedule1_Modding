internal struct ZipCentralDirectoryFileHeader // TypeDefIndex: 17668
{
	// Fields
	public byte VersionMadeByCompatibility; // 0x0
	public byte VersionMadeBySpecification; // 0x1
	public ushort VersionNeededToExtract; // 0x2
	public ushort GeneralPurposeBitFlag; // 0x4
	public ushort CompressionMethod; // 0x6
	public uint LastModified; // 0x8
	public uint Crc32; // 0xC
	public long CompressedSize; // 0x10
	public long UncompressedSize; // 0x18
	public ushort FilenameLength; // 0x20
	public ushort ExtraFieldLength; // 0x22
	public ushort FileCommentLength; // 0x24
	public int DiskNumberStart; // 0x28
	public ushort InternalFileAttributes; // 0x2C
	public uint ExternalFileAttributes; // 0x30
	public long RelativeOffsetOfLocalHeader; // 0x38
	public byte[] Filename; // 0x40
	public byte[] FileComment; // 0x48
	public List<ZipGenericExtraField> ExtraFields; // 0x50

	// Methods

	// RVA: 0x217A760 Offset: 0x2179160 VA: 0x18217A760
	public static bool TryReadBlock(BinaryReader reader, bool saveExtraFieldsAndComments, out ZipCentralDirectoryFileHeader header) { }
}
