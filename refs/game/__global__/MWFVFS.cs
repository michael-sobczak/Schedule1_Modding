internal class MWFVFS // TypeDefIndex: 5344
{
	// Fields
	private FileSystem fileSystem; // 0x10
	public static readonly string DesktopPrefix; // 0x0
	public static readonly string PersonalPrefix; // 0x8
	public static readonly string MyComputerPrefix; // 0x10
	public static readonly string RecentlyUsedPrefix; // 0x18
	public static readonly string MyNetworkPrefix; // 0x20
	public static readonly string MyComputerPersonalPrefix; // 0x28
	public static Hashtable MyComputerDevicesPrefix; // 0x30
	private MWFVFS.UpdateDelegate updateDelegate; // 0x18
	private Control calling_control; // 0x20
	private ThreadStart get_folder_content_thread_start; // 0x28
	private Thread worker; // 0x30
	private MWFVFS.WorkerThread workerThread; // 0x38
	private StringCollection the_filters; // 0x40

	// Methods

	// RVA: 0x233ABD0 Offset: 0x23395D0 VA: 0x18233ABD0
	public void .ctor() { }

	// RVA: 0x233A9C0 Offset: 0x23393C0 VA: 0x18233A9C0
	private static void .cctor() { }

	// RVA: 0x233A330 Offset: 0x2338D30 VA: 0x18233A330
	public FSEntry ChangeDirectory(string folder) { }

	// RVA: 0x233A430 Offset: 0x2338E30 VA: 0x18233A430
	public void GetFolderContent() { }

	// RVA: 0x233A440 Offset: 0x2338E40 VA: 0x18233A440
	public void GetFolderContent(StringCollection filters) { }

	// RVA: 0x233A660 Offset: 0x2339060 VA: 0x18233A660
	public ArrayList GetFoldersOnly() { }

	// RVA: 0x233A990 Offset: 0x2339390 VA: 0x18233A990
	public void WriteRecentlyUsedFiles(string filename) { }

	// RVA: 0x46FFD0 Offset: 0x46E9D0 VA: 0x18046FFD0
	public ArrayList GetMyComputerContent() { }

	// RVA: 0x233A350 Offset: 0x2338D50 VA: 0x18233A350
	public bool CreateFolder(string new_folder) { }

	// RVA: 0x233A810 Offset: 0x2339210 VA: 0x18233A810
	public bool MoveFolder(string sourceDirName, string destDirName) { }

	// RVA: 0x233A6D0 Offset: 0x23390D0 VA: 0x18233A6D0
	public bool MoveFile(string sourceFileName, string destFileName) { }

	// RVA: 0x233A680 Offset: 0x2339080 VA: 0x18233A680
	public string GetParent() { }

	// RVA: 0x233A950 Offset: 0x2339350 VA: 0x18233A950
	public void RegisterUpdateDelegate(MWFVFS.UpdateDelegate updateDelegate, Control control) { }
}
