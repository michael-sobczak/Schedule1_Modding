public class StandaloneFileBrowser // TypeDefIndex: 365
{
	// Fields
	private static IStandaloneFileBrowser _platformWrapper; // 0x0

	// Methods

	// RVA: 0x7B8F10 Offset: 0x7B7910 VA: 0x1807B8F10
	private static void .cctor() { }

	// RVA: 0x7B8270 Offset: 0x7B6C70 VA: 0x1807B8270
	public static string[] OpenFilePanel(string title, string directory, string extension, bool multiselect) { }

	// RVA: 0x7B84B0 Offset: 0x7B6EB0 VA: 0x1807B84B0
	public static string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect) { }

	// RVA: 0x7B8020 Offset: 0x7B6A20 VA: 0x1807B8020
	public static void OpenFilePanelAsync(string title, string directory, string extension, bool multiselect, Action<string[]> cb) { }

	// RVA: 0x7B7EF0 Offset: 0x7B68F0 VA: 0x1807B7EF0
	public static void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb) { }

	// RVA: 0x7B8700 Offset: 0x7B7100 VA: 0x1807B8700
	public static string[] OpenFolderPanel(string title, string directory, bool multiselect) { }

	// RVA: 0x7B85D0 Offset: 0x7B6FD0 VA: 0x1807B85D0
	public static void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<string[]> cb) { }

	// RVA: 0x7B8CD0 Offset: 0x7B76D0 VA: 0x1807B8CD0
	public static string SaveFilePanel(string title, string directory, string defaultName, string extension) { }

	// RVA: 0x7B8BA0 Offset: 0x7B75A0 VA: 0x1807B8BA0
	public static string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions) { }

	// RVA: 0x7B8950 Offset: 0x7B7350 VA: 0x1807B8950
	public static void SaveFilePanelAsync(string title, string directory, string defaultName, string extension, Action<string> cb) { }

	// RVA: 0x7B8820 Offset: 0x7B7220 VA: 0x1807B8820
	public static void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
