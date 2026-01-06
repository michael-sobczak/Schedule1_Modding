public class ExtractProgressEventArgs : ZipProgressEventArgs // TypeDefIndex: 16585
{
	// Fields
	private int _entriesExtracted; // 0x40
	private string _target; // 0x48

	// Properties
	public int EntriesExtracted { get; }
	public string ExtractLocation { get; }

	// Methods

	// RVA: 0x1E313B0 Offset: 0x1E2FDB0 VA: 0x181E313B0
	internal void .ctor(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation) { }

	// RVA: 0x1E2FDB0 Offset: 0x1E2E7B0 VA: 0x181E2FDB0
	internal void .ctor(string archiveName, ZipProgressEventType flavor) { }

	// RVA: 0x1E2FD60 Offset: 0x1E2E760 VA: 0x181E2FD60
	internal void .ctor() { }

	// RVA: 0x1E30F80 Offset: 0x1E2F980 VA: 0x181E30F80
	internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation) { }

	// RVA: 0x1E312D0 Offset: 0x1E2FCD0 VA: 0x181E312D0
	internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation) { }

	// RVA: 0x1E30EA0 Offset: 0x1E2F8A0 VA: 0x181E30EA0
	internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation) { }

	// RVA: 0x1E31210 Offset: 0x1E2FC10 VA: 0x181E31210
	internal static ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation) { }

	// RVA: 0x1E31150 Offset: 0x1E2FB50 VA: 0x181E31150
	internal static ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation) { }

	// RVA: 0x1E31060 Offset: 0x1E2FA60 VA: 0x181E31060
	internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_EntriesExtracted() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_ExtractLocation() { }
}
