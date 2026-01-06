internal abstract class FileSystem // TypeDefIndex: 5347
{
	// Fields
	protected string currentTopFolder; // 0x10
	protected FSEntry currentFolderFSEntry; // 0x18
	protected FSEntry currentTopFolderFSEntry; // 0x20
	private FileSystem.FileInfoComparer fileInfoComparer; // 0x28
	private FileSystem.FSEntryComparer fsEntryComparer; // 0x30

	// Methods

	// RVA: 0x23258A0 Offset: 0x23242A0 VA: 0x1823258A0
	protected void .ctor() { }

	// RVA: 0x2323FB0 Offset: 0x23229B0 VA: 0x182323FB0
	public FSEntry ChangeDirectory(string folder) { }

	// RVA: 0x2325860 Offset: 0x2324260 VA: 0x182325860
	public string GetParent() { }

	// RVA: 0x23248B0 Offset: 0x23232B0 VA: 0x1823248B0
	public void GetFolderContent(StringCollection filters, out ArrayList directories_out, out ArrayList files_out) { }

	// RVA: 0x2324E50 Offset: 0x2323850 VA: 0x182324E50
	public ArrayList GetFoldersOnly() { }

	// RVA: 0x23252A0 Offset: 0x2323CA0 VA: 0x1823252A0
	protected void GetNormalFolderContent(string from_folder, StringCollection filters, out ArrayList directories_out, out ArrayList files_out) { }

	// RVA: 0x2325730 Offset: 0x2324130 VA: 0x182325730
	protected ArrayList GetNormalFolders(string from_folder) { }

	// RVA: 0x2324640 Offset: 0x2323040 VA: 0x182324640 Slot: 4
	protected virtual FSEntry GetDirectoryFSEntry(DirectoryInfo dirinfo, FSEntry topFolderFSEntry) { }

	// RVA: 0x2324770 Offset: 0x2323170 VA: 0x182324770 Slot: 5
	protected virtual FSEntry GetFileFSEntry(FileInfo fileinfo) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract FSEntry GetDesktopFSEntry();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract FSEntry GetRecentlyUsedFSEntry();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract FSEntry GetPersonalFSEntry();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract FSEntry GetMyComputerPersonalFSEntry();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract FSEntry GetMyComputerFSEntry();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract FSEntry GetMyNetworkFSEntry();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteRecentlyUsedFiles(string fileToAdd);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract ArrayList GetRecentlyUsedFiles();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ArrayList GetMyComputerContent();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract ArrayList GetMyNetworkContent();
}
