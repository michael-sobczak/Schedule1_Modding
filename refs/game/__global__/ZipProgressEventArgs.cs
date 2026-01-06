public class ZipProgressEventArgs : EventArgs // TypeDefIndex: 16581
{
	// Fields
	private int _entriesTotal; // 0x10
	private bool _cancel; // 0x14
	private ZipEntry _latestEntry; // 0x18
	private ZipProgressEventType _flavor; // 0x20
	private string _archiveName; // 0x28
	private long _bytesTransferred; // 0x30
	private long _totalBytesToTransfer; // 0x38

	// Properties
	public int EntriesTotal { get; set; }
	public ZipEntry CurrentEntry { get; set; }
	public bool Cancel { get; set; }
	public ZipProgressEventType EventType { get; set; }
	public string ArchiveName { get; set; }
	public long BytesTransferred { get; set; }
	public long TotalBytesToTransfer { get; set; }

	// Methods

	// RVA: 0x1E2FD60 Offset: 0x1E2E760 VA: 0x181E2FD60
	internal void .ctor() { }

	// RVA: 0x1E2FDB0 Offset: 0x1E2E7B0 VA: 0x181E2FDB0
	internal void .ctor(string archiveName, ZipProgressEventType flavor) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_EntriesTotal() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_EntriesTotal(int value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ZipEntry get_CurrentEntry() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_CurrentEntry(ZipEntry value) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_Cancel() { }

	// RVA: 0x1E44B50 Offset: 0x1E43550 VA: 0x181E44B50
	public void set_Cancel(bool value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public ZipProgressEventType get_EventType() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_EventType(ZipProgressEventType value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_ArchiveName() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_ArchiveName(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public long get_BytesTransferred() { }

	// RVA: 0x5E0890 Offset: 0x5DF290 VA: 0x1805E0890
	public void set_BytesTransferred(long value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public long get_TotalBytesToTransfer() { }

	// RVA: 0x57CCF0 Offset: 0x57B6F0 VA: 0x18057CCF0
	public void set_TotalBytesToTransfer(long value) { }
}
