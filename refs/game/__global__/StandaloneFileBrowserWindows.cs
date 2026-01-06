public class StandaloneFileBrowserWindows : IStandaloneFileBrowser // TypeDefIndex: 367
{
	// Methods

	// RVA: 0x7B72F0 Offset: 0x7B5CF0 VA: 0x1807B72F0
	private static extern IntPtr GetActiveWindow() { }

	// RVA: 0x7B76F0 Offset: 0x7B60F0 VA: 0x1807B76F0 Slot: 4
	public string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect) { }

	// RVA: 0x7B76A0 Offset: 0x7B60A0 VA: 0x1807B76A0 Slot: 7
	public void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb) { }

	// RVA: 0x7B7AA0 Offset: 0x7B64A0 VA: 0x1807B7AA0 Slot: 5
	public string[] OpenFolderPanel(string title, string directory, bool multiselect) { }

	// RVA: 0x7B78E0 Offset: 0x7B62E0 VA: 0x1807B78E0 Slot: 8
	public void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<string[]> cb) { }

	// RVA: 0x7B7C90 Offset: 0x7B6690 VA: 0x1807B7C90 Slot: 6
	public string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions) { }

	// RVA: 0x7B7C40 Offset: 0x7B6640 VA: 0x1807B7C40 Slot: 9
	public void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb) { }

	// RVA: 0x7B74B0 Offset: 0x7B5EB0 VA: 0x1807B74B0
	private static string GetFilterFromFileExtensionList(ExtensionFilter[] extensions) { }

	// RVA: 0x7B7360 Offset: 0x7B5D60 VA: 0x1807B7360
	private static string GetDirectoryPath(string directory) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
