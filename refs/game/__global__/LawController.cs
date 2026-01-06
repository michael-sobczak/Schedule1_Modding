public class LawController : Singleton<LawController>, IBaseSaveable, ISaveable // TypeDefIndex: 1303
{
	// Fields
	public const float DAILY_INTENSITY_DRAIN = 0.05;
	[Range(1, 10)]
	public int LE_Intensity; // 0x28
	private float internalLawIntensity; // 0x2C
	[Header("Settings")]
	public LawActivitySettings MondaySettings; // 0x30
	public LawActivitySettings TuesdaySettings; // 0x38
	public LawActivitySettings WednesdaySettings; // 0x40
	public LawActivitySettings ThursdaySettings; // 0x48
	public LawActivitySettings FridaySettings; // 0x50
	public LawActivitySettings SaturdaySettings; // 0x58
	public LawActivitySettings SundaySettings; // 0x60
	[Header("Demo Settings")]
	public float IntensityIncreasePerDay; // 0x68
	[CompilerGenerated]
	private bool <OverrideSettings>k__BackingField; // 0x6C
	[CompilerGenerated]
	private LawActivitySettings <OverriddenSettings>k__BackingField; // 0x70
	[CompilerGenerated]
	private LawActivitySettings <CurrentSettings>k__BackingField; // 0x78
	private LawLoader loader; // 0x80
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x88
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x9C

	// Properties
	public bool OverrideSettings { get; set; }
	public LawActivitySettings OverriddenSettings { get; set; }
	public LawActivitySettings CurrentSettings { get; set; }
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
	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490
	public bool get_OverrideSettings() { }

	[CompilerGenerated]
	// RVA: 0x614530 Offset: 0x612F30 VA: 0x180614530
	protected void set_OverrideSettings(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public LawActivitySettings get_OverriddenSettings() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	protected void set_OverriddenSettings(LawActivitySettings value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public LawActivitySettings get_CurrentSettings() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	protected void set_CurrentSettings(LawActivitySettings value) { }

	// RVA: 0x6144D0 Offset: 0x612ED0 VA: 0x1806144D0 Slot: 8
	public string get_SaveFolderName() { }

	// RVA: 0x6144A0 Offset: 0x612EA0 VA: 0x1806144A0 Slot: 9
	public string get_SaveFileName() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400 Slot: 10
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 12
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030 Slot: 13
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480 Slot: 14
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510 Slot: 15
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460 Slot: 16
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x614500 Offset: 0x612F00 VA: 0x180614500 Slot: 17
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x614470 Offset: 0x612E70 VA: 0x180614470 Slot: 7
	public int get_LoadOrder() { }

	// RVA: 0x6135A0 Offset: 0x611FA0 VA: 0x1806135A0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x613900 Offset: 0x612300 VA: 0x180613900 Slot: 31
	public virtual void InitializeSaveable() { }

	// RVA: 0x613F80 Offset: 0x612980 VA: 0x180613F80 Slot: 4
	protected override void Start() { }

	// RVA: 0x613AD0 Offset: 0x6124D0 VA: 0x180613AD0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x613E10 Offset: 0x612810 VA: 0x180613E10
	private void OnLoadComplete() { }

	// RVA: 0x613A00 Offset: 0x612400 VA: 0x180613A00
	private void MinPass() { }

	// RVA: 0x5D2020 Offset: 0x5D0A20 VA: 0x1805D2020
	private void HourPass() { }

	// RVA: 0x613660 Offset: 0x612060 VA: 0x180613660
	private void DayPass() { }

	// RVA: 0x6137E0 Offset: 0x6121E0 VA: 0x1806137E0
	public LawActivitySettings GetSettings() { }

	// RVA: 0x613780 Offset: 0x612180 VA: 0x180613780
	public LawActivitySettings GetSettings(EDay day) { }

	// RVA: 0x613EF0 Offset: 0x6128F0 VA: 0x180613EF0
	public void OverrideSetings(LawActivitySettings settings) { }

	// RVA: 0x6136E0 Offset: 0x6120E0 VA: 0x1806136E0
	public void EndOverride() { }

	// RVA: 0x6135F0 Offset: 0x611FF0 VA: 0x1806135F0
	public void ChangeInternalIntensity(float change) { }

	// RVA: 0x613F10 Offset: 0x612910 VA: 0x180613F10
	public void SetInternalIntensity(float intensity) { }

	// RVA: 0x613700 Offset: 0x612100 VA: 0x180613700 Slot: 32
	public virtual string GetSaveString() { }

	// RVA: 0x613990 Offset: 0x612390 VA: 0x180613990
	public void Load(LawData data) { }

	// RVA: 0x614350 Offset: 0x612D50 VA: 0x180614350
	public void .ctor() { }
}
