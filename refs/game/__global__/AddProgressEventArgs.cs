public class AddProgressEventArgs : ZipProgressEventArgs // TypeDefIndex: 16583
{
	// Methods

	// RVA: 0x1E2FD60 Offset: 0x1E2E760 VA: 0x181E2FD60
	internal void .ctor() { }

	// RVA: 0x1E2FDB0 Offset: 0x1E2E7B0 VA: 0x181E2FDB0
	private void .ctor(string archiveName, ZipProgressEventType flavor) { }

	// RVA: 0x1E2FB50 Offset: 0x1E2E550 VA: 0x181E2FB50
	internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal) { }

	// RVA: 0x1E2FCC0 Offset: 0x1E2E6C0 VA: 0x181E2FCC0
	internal static AddProgressEventArgs Started(string archiveName) { }

	// RVA: 0x1E2FC20 Offset: 0x1E2E620 VA: 0x181E2FC20
	internal static AddProgressEventArgs Completed(string archiveName) { }
}
