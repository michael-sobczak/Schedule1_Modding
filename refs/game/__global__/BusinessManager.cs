public class BusinessManager : Singleton<BusinessManager>, IBaseSaveable, ISaveable // TypeDefIndex: 739
{
	// Fields
	private BusinessesLoader loader; // 0x28
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x44

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

	// RVA: 0xACE680 Offset: 0xACD080 VA: 0x180ACE680 Slot: 8
	public string get_SaveFolderName() { }

	// RVA: 0xACE650 Offset: 0xACD050 VA: 0x180ACE650 Slot: 9
	public string get_SaveFileName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 10
	public Loader get_Loader() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 11
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 12
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0 Slot: 13
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 14
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 15
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0 Slot: 16
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920 Slot: 17
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500 Slot: 7
	public int get_LoadOrder() { }

	// RVA: 0xACDDD0 Offset: 0xACC7D0 VA: 0x180ACDDD0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xACDF40 Offset: 0xACC940 VA: 0x180ACDF40 Slot: 31
	public virtual void InitializeSaveable() { }

	// RVA: 0xACDF00 Offset: 0xACC900 VA: 0x180ACDF00 Slot: 32
	public virtual string GetSaveString() { }

	// RVA: 0xACE1E0 Offset: 0xACCBE0 VA: 0x180ACE1E0 Slot: 33
	public virtual List<string> WriteData(string parentFolderPath) { }

	// RVA: 0xACDE20 Offset: 0xACC820 VA: 0x180ACDE20 Slot: 34
	public virtual void DeleteUnapprovedFiles(string parentFolderPath) { }

	// RVA: 0xACDFD0 Offset: 0xACC9D0 VA: 0x180ACDFD0
	public void LoadBusiness(BusinessData businessData, string dataString) { }

	// RVA: 0xACE560 Offset: 0xACCF60 VA: 0x180ACE560
	public void .ctor() { }
}
