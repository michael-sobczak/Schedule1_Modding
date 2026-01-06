public class GenericSaveablesManager : Singleton<GenericSaveablesManager>, IBaseSaveable, ISaveable // TypeDefIndex: 841
{
	// Fields
	protected List<IGenericSaveable> Saveables; // 0x28
	private GenericSaveablesLoader loader; // 0x30
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x38
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x4C

	// Properties
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	// RVA: 0x5A1E10 Offset: 0x5A0810 VA: 0x1805A1E10 Slot: 8
	public string get_SaveFolderName() { }

	// RVA: 0x5A1DE0 Offset: 0x5A07E0 VA: 0x1805A1DE0 Slot: 9
	public string get_SaveFileName() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 10
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 12
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 13
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 14
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0 Slot: 15
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0 Slot: 16
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480 Slot: 17
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0 Slot: 7
	public int get_LoadOrder() { }

	// RVA: 0x5A16D0 Offset: 0x5A00D0 VA: 0x1805A16D0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x5A18D0 Offset: 0x5A02D0 VA: 0x1805A18D0 Slot: 31
	public virtual void InitializeSaveable() { }

	// RVA: 0x5A1BC0 Offset: 0x5A05C0 VA: 0x1805A1BC0
	public void RegisterSaveable(IGenericSaveable saveable) { }

	// RVA: 0x5A1720 Offset: 0x5A0120 VA: 0x1805A1720 Slot: 32
	public virtual string GetSaveString() { }

	// RVA: 0x5A1960 Offset: 0x5A0360 VA: 0x1805A1960
	public void LoadSaveable(GenericSaveData data) { }

	// RVA: 0x5A1CA0 Offset: 0x5A06A0 VA: 0x1805A1CA0
	public void .ctor() { }
}
