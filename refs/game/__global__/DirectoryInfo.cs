public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 5079
{
	// Properties
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x1C27A80 Offset: 0x1C26480 VA: 0x181C27A80
	public void .ctor(string path) { }

	// RVA: 0x1C27B50 Offset: 0x1C26550 VA: 0x181C27B50
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x1C27490 Offset: 0x1C25E90 VA: 0x181C27490
	private void Init(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x1C27F70 Offset: 0x1C26970 VA: 0x181C27F70
	public DirectoryInfo get_Parent() { }

	// RVA: 0x1C27290 Offset: 0x1C25C90 VA: 0x181C27290
	public FileInfo[] GetFiles() { }

	// RVA: 0x1C27330 Offset: 0x1C25D30 VA: 0x181C27330
	public FileInfo[] GetFiles(string searchPattern) { }

	// RVA: 0x1C273D0 Offset: 0x1C25DD0 VA: 0x181C273D0
	public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1C27090 Offset: 0x1C25A90 VA: 0x181C27090
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x1C271D0 Offset: 0x1C25BD0 VA: 0x181C271D0
	public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1C26FE0 Offset: 0x1C259E0 VA: 0x181C26FE0
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1C27060 Offset: 0x1C25A60 VA: 0x181C27060
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1C27890 Offset: 0x1C26290 VA: 0x181C27890
	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	// RVA: 0x1C26FC0 Offset: 0x1C259C0 VA: 0x181C26FC0 Slot: 11
	public override void Delete() { }

	// RVA: 0x1C26FD0 Offset: 0x1C259D0 VA: 0x181C26FD0
	public void Delete(bool recursive) { }

	// RVA: 0x1C27F50 Offset: 0x1C26950 VA: 0x181C27F50
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}
