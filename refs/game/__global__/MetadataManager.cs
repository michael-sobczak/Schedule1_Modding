public class MetadataManager : Singleton<MetadataManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1916
{
	// Fields
	[CompilerGenerated]
	private DateTime <CreationDate>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <CreationVersion>k__BackingField; // 0x30
	private MetadataLoader loader; // 0x38
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x40
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x54

	// Properties
	public DateTime CreationDate { get; set; }
	public string CreationVersion { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DateTime get_CreationDate() { }

	[CompilerGenerated]
	// RVA: 0x5E0880 Offset: 0x5DF280 VA: 0x1805E0880
	protected void set_CreationDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_CreationVersion() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_CreationVersion(string value) { }

	// RVA: 0x77E050 Offset: 0x77CA50 VA: 0x18077E050 Slot: 8
	public string get_SaveFolderName() { }

	// RVA: 0x77E020 Offset: 0x77CA20 VA: 0x18077E020 Slot: 9
	public string get_SaveFileName() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 10
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 12
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0 Slot: 13
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 14
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 15
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0 Slot: 16
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0 Slot: 17
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40 Slot: 7
	public int get_LoadOrder() { }

	// RVA: 0x77DC10 Offset: 0x77C610 VA: 0x18077DC10 Slot: 5
	protected override void Awake() { }

	// RVA: 0x77DE20 Offset: 0x77C820 VA: 0x18077DE20 Slot: 31
	public virtual void InitializeSaveable() { }

	// RVA: 0x77DCD0 Offset: 0x77C6D0 VA: 0x18077DCD0 Slot: 32
	public virtual string GetSaveString() { }

	// RVA: 0x77DEB0 Offset: 0x77C8B0 VA: 0x18077DEB0
	public void Load(MetaData data) { }

	// RVA: 0x77DF00 Offset: 0x77C900 VA: 0x18077DF00
	public void .ctor() { }
}
