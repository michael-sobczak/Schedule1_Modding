internal interface IFileSystemCalls // TypeDefIndex: 17944
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanAccessFileSystem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FileExists(string path);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DeleteFile(string path);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Stream OpenFileForWriting(string path);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Stream OpenFileForReading(string path);
}
