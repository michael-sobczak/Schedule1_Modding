public class SaveProgressEventArgs : ZipProgressEventArgs // TypeDefIndex: 16584
{
	// Fields
	private int _entriesSaved; // 0x40

	// Properties
	public int EntriesSaved { get; }

	// Methods

	// RVA: 0x1E34FF0 Offset: 0x1E339F0 VA: 0x181E34FF0
	internal void .ctor(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry) { }

	// RVA: 0x1E2FD60 Offset: 0x1E2E760 VA: 0x181E2FD60
	internal void .ctor() { }

	// RVA: 0x1E2FDB0 Offset: 0x1E2E7B0 VA: 0x181E2FDB0
	internal void .ctor(string archiveName, ZipProgressEventType flavor) { }

	// RVA: 0x1E34DC0 Offset: 0x1E337C0 VA: 0x181E34DC0
	internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes) { }

	// RVA: 0x1E34F50 Offset: 0x1E33950 VA: 0x181E34F50
	internal static SaveProgressEventArgs Started(string archiveName) { }

	// RVA: 0x1E34EB0 Offset: 0x1E338B0 VA: 0x181E34EB0
	internal static SaveProgressEventArgs Completed(string archiveName) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_EntriesSaved() { }
}
