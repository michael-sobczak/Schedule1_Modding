public class ZipArchiveEntry // TypeDefIndex: 17661
{
	// Fields
	private ZipArchive _archive; // 0x10
	private readonly bool _originallyInArchive; // 0x18
	private readonly int _diskNumberStart; // 0x1C
	private readonly ZipVersionMadeByPlatform _versionMadeByPlatform; // 0x20
	private ZipVersionNeededValues _versionMadeBySpecification; // 0x22
	private ZipVersionNeededValues _versionToExtract; // 0x24
	private ZipArchiveEntry.BitFlagValues _generalPurposeBitFlag; // 0x26
	private ZipArchiveEntry.CompressionMethodValues _storedCompressionMethod; // 0x28
	private DateTimeOffset _lastModified; // 0x30
	private long _compressedSize; // 0x40
	private long _uncompressedSize; // 0x48
	private long _offsetOfLocalHeader; // 0x50
	private Nullable<long> _storedOffsetOfCompressedData; // 0x58
	private uint _crc32; // 0x68
	private byte[][] _compressedBytes; // 0x70
	private MemoryStream _storedUncompressedData; // 0x78
	private bool _currentlyOpenForWrite; // 0x80
	private bool _everOpenedForWrite; // 0x81
	private Stream _outstandingWriteStream; // 0x88
	private uint _externalFileAttr; // 0x90
	private string _storedEntryName; // 0x98
	private byte[] _storedEntryNameBytes; // 0xA0
	private List<ZipGenericExtraField> _cdUnknownExtraFields; // 0xA8
	private List<ZipGenericExtraField> _lhUnknownExtraFields; // 0xB0
	private byte[] _fileComment; // 0xB8
	private Nullable<CompressionLevel> _compressionLevel; // 0xC0
	private static readonly bool s_allowLargeZipArchiveEntriesInUpdateMode; // 0x0
	internal static readonly ZipVersionMadeByPlatform CurrentZipPlatform; // 0x1

	// Properties
	public string FullName { get; set; }
	public DateTimeOffset LastWriteTime { get; set; }
	public long Length { get; }
	internal bool EverOpenedForWrite { get; }
	private long OffsetOfCompressedData { get; }
	private MemoryStream UncompressedData { get; }
	private ZipArchiveEntry.CompressionMethodValues CompressionMethod { get; set; }

	// Methods

	// RVA: 0x2177440 Offset: 0x2175E40 VA: 0x182177440
	internal void .ctor(ZipArchive archive, ZipCentralDirectoryFileHeader cd) { }

	// RVA: 0x21773B0 Offset: 0x2175DB0 VA: 0x1821773B0
	internal void .ctor(ZipArchive archive, string entryName, CompressionLevel compressionLevel) { }

	// RVA: 0x2177700 Offset: 0x2176100 VA: 0x182177700
	internal void .ctor(ZipArchive archive, string entryName) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_FullName() { }

	// RVA: 0x2177D40 Offset: 0x2176740 VA: 0x182177D40
	private void set_FullName(string value) { }

	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	public DateTimeOffset get_LastWriteTime() { }

	// RVA: 0x2177F60 Offset: 0x2176960 VA: 0x182177F60
	public void set_LastWriteTime(DateTimeOffset value) { }

	// RVA: 0x2177980 Offset: 0x2176380 VA: 0x182177980
	public long get_Length() { }

	// RVA: 0x21747E0 Offset: 0x21731E0 VA: 0x1821747E0
	public void Delete() { }

	// RVA: 0x2175CE0 Offset: 0x21746E0 VA: 0x182175CE0
	public Stream Open() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D85F50 Offset: 0x1D84950 VA: 0x181D85F50
	internal bool get_EverOpenedForWrite() { }

	// RVA: 0x21779F0 Offset: 0x21763F0 VA: 0x1821779F0
	private long get_OffsetOfCompressedData() { }

	// RVA: 0x2177B40 Offset: 0x2176540 VA: 0x182177B40
	private MemoryStream get_UncompressedData() { }

	// RVA: 0xCC6B00 Offset: 0xCC5500 VA: 0x180CC6B00
	private ZipArchiveEntry.CompressionMethodValues get_CompressionMethod() { }

	// RVA: 0x2177CF0 Offset: 0x21766F0 VA: 0x182177CF0
	private void set_CompressionMethod(ZipArchiveEntry.CompressionMethodValues value) { }

	// RVA: 0x2174780 Offset: 0x2173180 VA: 0x182174780
	private string DecodeEntryName(byte[] entryNameBytes) { }

	// RVA: 0x2174950 Offset: 0x2173350 VA: 0x182174950
	private byte[] EncodeEntryName(string entryName, out bool isUTF8) { }

	// RVA: 0x2176040 Offset: 0x2174A40 VA: 0x182176040
	internal void WriteAndFinishLocalEntry() { }

	// RVA: 0x21760B0 Offset: 0x2174AB0 VA: 0x1821760B0
	internal void WriteCentralDirectoryFileHeader() { }

	// RVA: 0x21752B0 Offset: 0x2173CB0 VA: 0x1821752B0
	internal bool LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded() { }

	// RVA: 0x2175F50 Offset: 0x2174950 VA: 0x182175F50
	internal void ThrowIfNotOpenable(bool needToUncompress, bool needToLoadIntoMemory) { }

	// RVA: 0x2174A60 Offset: 0x2173460 VA: 0x182174A60
	private CheckSumAndSizeWriteStream GetDataCompressor(Stream backingStream, bool leaveBackingStreamOpen, EventHandler onClose) { }

	// RVA: 0x2174CD0 Offset: 0x21736D0 VA: 0x182174CD0
	private Stream GetDataDecompressor(Stream compressedStreamToRead) { }

	// RVA: 0x2175750 Offset: 0x2174150 VA: 0x182175750
	private Stream OpenInReadMode(bool checkOpenable) { }

	// RVA: 0x2175AC0 Offset: 0x21744C0 VA: 0x182175AC0
	private Stream OpenInWriteMode() { }

	// RVA: 0x2175870 Offset: 0x2174270 VA: 0x182175870
	private Stream OpenInUpdateMode() { }

	// RVA: 0x2174FB0 Offset: 0x21739B0 VA: 0x182174FB0
	private bool IsOpenable(bool needToUncompress, bool needToLoadIntoMemory, out string message) { }

	// RVA: 0x2175EC0 Offset: 0x21748C0 VA: 0x182175EC0
	private bool SizesTooLarge() { }

	// RVA: 0x2176E00 Offset: 0x2175800 VA: 0x182176E00
	private bool WriteLocalFileHeader(bool isEmptyFile) { }

	// RVA: 0x2176B80 Offset: 0x2175580 VA: 0x182176B80
	private void WriteLocalFileHeaderAndDataIfNeeded() { }

	// RVA: 0x21766F0 Offset: 0x21750F0 VA: 0x1821766F0
	private void WriteCrcAndSizesInLocalHeader(bool zip64HeaderUsed) { }

	// RVA: 0x2176A40 Offset: 0x2175440 VA: 0x182176A40
	private void WriteDataDescriptor() { }

	// RVA: 0x2175FD0 Offset: 0x21749D0 VA: 0x182175FD0
	private void UnloadStreams() { }

	// RVA: 0x2174760 Offset: 0x2173160 VA: 0x182174760
	private void CloseStreams() { }

	// RVA: 0x2176020 Offset: 0x2174A20 VA: 0x182176020
	private void VersionToExtractAtLeast(ZipVersionNeededValues value) { }

	// RVA: 0x2175EE0 Offset: 0x21748E0 VA: 0x182175EE0
	private void ThrowIfInvalidArchive() { }

	// RVA: 0x2174F30 Offset: 0x2173930 VA: 0x182174F30
	private static string GetFileName_Windows(string path) { }

	// RVA: 0x2174EC0 Offset: 0x21738C0 VA: 0x182174EC0
	private static string GetFileName_Unix(string path) { }

	// RVA: 0x2175D90 Offset: 0x2174790 VA: 0x182175D90
	internal static string ParseFileName(string path, ZipVersionMadeByPlatform madeByPlatform) { }

	// RVA: 0x2177310 Offset: 0x2175D10 VA: 0x182177310
	private static void .cctor() { }
}
