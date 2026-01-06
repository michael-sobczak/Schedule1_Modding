public class ZipArchive : IDisposable // TypeDefIndex: 17656
{
	// Fields
	private Stream _archiveStream; // 0x10
	private ZipArchiveEntry _archiveStreamOwner; // 0x18
	private BinaryReader _archiveReader; // 0x20
	private ZipArchiveMode _mode; // 0x28
	private List<ZipArchiveEntry> _entries; // 0x30
	private ReadOnlyCollection<ZipArchiveEntry> _entriesCollection; // 0x38
	private Dictionary<string, ZipArchiveEntry> _entriesDictionary; // 0x40
	private bool _readEntries; // 0x48
	private bool _leaveOpen; // 0x49
	private long _centralDirectoryStart; // 0x50
	private bool _isDisposed; // 0x58
	private uint _numberOfThisDisk; // 0x5C
	private long _expectedNumberOfEntries; // 0x60
	private Stream _backingStream; // 0x68
	private byte[] _archiveComment; // 0x70
	private Encoding _entryNameEncoding; // 0x78

	// Properties
	public ReadOnlyCollection<ZipArchiveEntry> Entries { get; }
	public ZipArchiveMode Mode { get; }
	internal BinaryReader ArchiveReader { get; }
	internal Stream ArchiveStream { get; }
	internal uint NumberOfThisDisk { get; }
	internal Encoding EntryNameEncoding { get; set; }

	// Methods

	// RVA: 0x217A480 Offset: 0x2178E80 VA: 0x18217A480
	public void .ctor(Stream stream, ZipArchiveMode mode, bool leaveOpen, Encoding entryNameEncoding) { }

	// RVA: 0x217A600 Offset: 0x2179000 VA: 0x18217A600
	public ReadOnlyCollection<ZipArchiveEntry> get_Entries() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public ZipArchiveMode get_Mode() { }

	// RVA: 0x2178470 Offset: 0x2176E70 VA: 0x182178470
	public ZipArchiveEntry CreateEntry(string entryName) { }

	// RVA: 0x21783F0 Offset: 0x2176DF0 VA: 0x1821783F0
	public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel) { }

	// RVA: 0x2178480 Offset: 0x2176E80 VA: 0x182178480 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x21784F0 Offset: 0x2176EF0 VA: 0x1821784F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal BinaryReader get_ArchiveReader() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Stream get_ArchiveStream() { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	internal uint get_NumberOfThisDisk() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal Encoding get_EntryNameEncoding() { }

	// RVA: 0x217A680 Offset: 0x2179080 VA: 0x18217A680
	private void set_EntryNameEncoding(Encoding value) { }

	// RVA: 0x2178560 Offset: 0x2176F60 VA: 0x182178560
	private ZipArchiveEntry DoCreateEntry(string entryName, Nullable<CompressionLevel> compressionLevel) { }

	// RVA: 0x21781D0 Offset: 0x2176BD0 VA: 0x1821781D0
	internal void AcquireArchiveStream(ZipArchiveEntry entry) { }

	// RVA: 0x2178270 Offset: 0x2176C70 VA: 0x182178270
	private void AddEntry(ZipArchiveEntry entry) { }

	// RVA: 0x50B620 Offset: 0x50A020 VA: 0x18050B620
	internal void ReleaseArchiveStream(ZipArchiveEntry entry) { }

	// RVA: 0x2179A20 Offset: 0x2178420 VA: 0x182179A20
	internal void RemoveEntry(ZipArchiveEntry entry) { }

	// RVA: 0x2179AB0 Offset: 0x21784B0 VA: 0x182179AB0
	internal void ThrowIfDisposed() { }

	// RVA: 0x2178380 Offset: 0x2176D80 VA: 0x182178380
	private void CloseStreams() { }

	// RVA: 0x21787A0 Offset: 0x21771A0 VA: 0x1821787A0
	private void EnsureCentralDirectoryRead() { }

	// RVA: 0x21787C0 Offset: 0x21771C0 VA: 0x1821787C0
	private void Init(Stream stream, ZipArchiveMode mode, bool leaveOpen) { }

	// RVA: 0x2178F00 Offset: 0x2177900 VA: 0x182178F00
	private void ReadCentralDirectory() { }

	// RVA: 0x2179190 Offset: 0x2177B90 VA: 0x182179190
	private void ReadEndOfCentralDirectory() { }

	// RVA: 0x2179E30 Offset: 0x2178830 VA: 0x182179E30
	private void WriteFile() { }

	// RVA: 0x2179B40 Offset: 0x2178540 VA: 0x182179B40
	private void WriteArchiveEpilogue(long startOfCentralDirectory, long sizeOfCentralDirectory) { }
}
