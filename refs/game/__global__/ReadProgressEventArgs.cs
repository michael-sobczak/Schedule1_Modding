public class ReadProgressEventArgs : ZipProgressEventArgs // TypeDefIndex: 16582
{
	// Methods

	// RVA: 0x1E2FD60 Offset: 0x1E2E760 VA: 0x181E2FD60
	internal void .ctor() { }

	// RVA: 0x1E2FDB0 Offset: 0x1E2E7B0 VA: 0x181E2FDB0
	private void .ctor(string archiveName, ZipProgressEventType flavor) { }

	// RVA: 0x1E349C0 Offset: 0x1E333C0 VA: 0x181E349C0
	internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal) { }

	// RVA: 0x1E348F0 Offset: 0x1E332F0 VA: 0x181E348F0
	internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal) { }

	// RVA: 0x1E34BF0 Offset: 0x1E335F0 VA: 0x181E34BF0
	internal static ReadProgressEventArgs Started(string archiveName) { }

	// RVA: 0x1E34A70 Offset: 0x1E33470 VA: 0x181E34A70
	internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes) { }

	// RVA: 0x1E34B50 Offset: 0x1E33550 VA: 0x181E34B50
	internal static ReadProgressEventArgs Completed(string archiveName) { }
}
