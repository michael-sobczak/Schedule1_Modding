internal class FileSystemCalls : IFileSystemCalls // TypeDefIndex: 17945
{
	// Fields
	private readonly bool m_CanAccessFileSystem; // 0x10

	// Methods

	// RVA: 0x2B91610 Offset: 0x2B90010 VA: 0x182B91610
	internal void .ctor() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 4
	public bool CanAccessFileSystem() { }

	// RVA: 0x2B91540 Offset: 0x2B8FF40 VA: 0x182B91540 Slot: 5
	public bool FileExists(string path) { }

	// RVA: 0x2B91530 Offset: 0x2B8FF30 VA: 0x182B91530 Slot: 6
	public void DeleteFile(string path) { }

	// RVA: 0x2B915B0 Offset: 0x2B8FFB0 VA: 0x182B915B0 Slot: 7
	public Stream OpenFileForWriting(string path) { }

	// RVA: 0x2B91550 Offset: 0x2B8FF50 VA: 0x182B91550 Slot: 8
	public Stream OpenFileForReading(string path) { }
}
