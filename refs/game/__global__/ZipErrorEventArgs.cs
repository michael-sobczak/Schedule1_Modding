public class ZipErrorEventArgs : ZipProgressEventArgs // TypeDefIndex: 16586
{
	// Fields
	private Exception _exc; // 0x40

	// Properties
	public Exception Exception { get; }
	public string FileName { get; }

	// Methods

	// RVA: 0x1E2FD60 Offset: 0x1E2E760 VA: 0x181E2FD60
	private void .ctor() { }

	// RVA: 0x1E44A50 Offset: 0x1E43450 VA: 0x181E44A50
	internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Exception get_Exception() { }

	// RVA: 0x1E44B30 Offset: 0x1E43530 VA: 0x181E44B30
	public string get_FileName() { }
}
