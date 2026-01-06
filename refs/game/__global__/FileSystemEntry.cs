public struct FileSystemEntry // TypeDefIndex: 5120
{
	// Fields
	internal Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info; // 0x0
	[CompilerGenerated]
	private ReadOnlySpan<char> <Directory>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReadOnlySpan<char> <RootDirectory>k__BackingField; // 0x18
	[CompilerGenerated]
	private ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField; // 0x28

	// Properties
	public ReadOnlySpan<char> Directory { get; set; }
	public ReadOnlySpan<char> RootDirectory { get; set; }
	public ReadOnlySpan<char> OriginalRootDirectory { get; set; }
	public ReadOnlySpan<char> FileName { get; }
	public FileAttributes Attributes { get; }
	public bool IsDirectory { get; }

	// Methods

	// RVA: 0x1C2E420 Offset: 0x1C2CE20 VA: 0x181C2E420
	internal static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	public ReadOnlySpan<char> get_Directory() { }

	[CompilerGenerated]
	// RVA: 0x1C2E7D0 Offset: 0x1C2D1D0 VA: 0x181C2E7D0
	private void set_Directory(ReadOnlySpan<char> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public ReadOnlySpan<char> get_RootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x691670 Offset: 0x690070 VA: 0x180691670
	private void set_RootDirectory(ReadOnlySpan<char> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public ReadOnlySpan<char> get_OriginalRootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	private void set_OriginalRootDirectory(ReadOnlySpan<char> value) { }

	// RVA: 0x1C2E780 Offset: 0x1C2D180 VA: 0x181C2E780
	public ReadOnlySpan<char> get_FileName() { }

	// RVA: 0x1C2E760 Offset: 0x1C2D160 VA: 0x181C2E760
	public FileAttributes get_Attributes() { }

	// RVA: 0x1C2E7B0 Offset: 0x1C2D1B0 VA: 0x181C2E7B0
	public bool get_IsDirectory() { }

	// RVA: 0x1C2E440 Offset: 0x1C2CE40 VA: 0x181C2E440
	public FileSystemInfo ToFileSystemInfo() { }

	// RVA: 0x1C2E560 Offset: 0x1C2CF60 VA: 0x181C2E560
	public string ToSpecifiedFullPath() { }
}
