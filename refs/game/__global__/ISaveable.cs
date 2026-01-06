public interface ISaveable // TypeDefIndex: 844
{
	// Properties
	public abstract string SaveFolderName { get; }
	public abstract string SaveFileName { get; }
	public abstract Loader Loader { get; }
	public abstract bool ShouldSaveUnderFolder { get; }
	public abstract List<string> LocalExtraFiles { get; set; }
	public abstract List<string> LocalExtraFolders { get; set; }
	public abstract bool HasChanged { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_SaveFolderName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_SaveFileName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Loader get_Loader();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_ShouldSaveUnderFolder();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract List<string> get_LocalExtraFiles();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LocalExtraFiles(List<string> value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract List<string> get_LocalExtraFolders();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_LocalExtraFolders(List<string> value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_HasChanged();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_HasChanged(bool value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void InitializeSaveable();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string GetSaveString();

	// RVA: 0x5A3CB0 Offset: 0x5A26B0 VA: 0x1805A3CB0 Slot: 12
	public virtual string Save(string parentFolderPath) { }

	// RVA: 0x5A4100 Offset: 0x5A2B00 VA: 0x1805A4100 Slot: 13
	public virtual void WriteBaseData(string parentFolderPath, string saveString) { }

	// RVA: 0x5A3BF0 Offset: 0x5A25F0 VA: 0x1805A3BF0 Slot: 14
	public virtual string GetLocalPath(out bool isFolder) { }

	// RVA: 0x5A3140 Offset: 0x5A1B40 VA: 0x1805A3140 Slot: 15
	public virtual void CompleteSave(string parentFolderPath, bool writeDataFile) { }

	// RVA: 0x5A44A0 Offset: 0x5A2EA0 VA: 0x1805A44A0 Slot: 16
	public virtual List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void DeleteUnapprovedFiles(string parentFolderPath) { }

	// RVA: 0x5A3AA0 Offset: 0x5A24A0 VA: 0x1805A3AA0 Slot: 18
	public virtual string GetContainerFolder(string parentFolderPath) { }

	// RVA: 0x5A4940 Offset: 0x5A3340 VA: 0x1805A4940 Slot: 19
	public virtual string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents) { }

	// RVA: 0x5A4500 Offset: 0x5A2F00 VA: 0x1805A4500 Slot: 20
	public virtual string WriteFolder(string parentPath, string localPath_NoExtensions) { }

	// RVA: 0x5A3FF0 Offset: 0x5A29F0 VA: 0x1805A3FF0 Slot: 21
	public virtual bool TryLoadFile(string parentPath, string fileName, out string contents) { }

	// RVA: 0x5A3E10 Offset: 0x5A2810 VA: 0x1805A3E10 Slot: 22
	public virtual bool TryLoadFile(string path, out string contents, bool autoAddExtension = True) { }
}
