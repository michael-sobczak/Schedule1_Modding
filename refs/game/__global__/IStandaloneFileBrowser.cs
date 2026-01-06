public interface IStandaloneFileBrowser // TypeDefIndex: 363
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string[] OpenFolderPanel(string title, string directory, bool multiselect);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<string[]> cb);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
}
