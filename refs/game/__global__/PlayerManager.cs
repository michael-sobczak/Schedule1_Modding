public class PlayerManager : Singleton<PlayerManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1352
{
	// Fields
	private PlayersLoader loader; // 0x28
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x44
	[SerializeField]
	protected List<PlayerData> loadedPlayerData; // 0x48
	protected List<string> loadedPlayerDataPaths; // 0x50
	protected List<string> loadedPlayerFileNames; // 0x58
	public NavMeshSurface PlayerRecoverySurface; // 0x60

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

	// RVA: 0x666590 Offset: 0x664F90 VA: 0x180666590 Slot: 8
	public string get_SaveFolderName() { }

	// RVA: 0x666560 Offset: 0x664F60 VA: 0x180666560 Slot: 9
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

	// RVA: 0x664C80 Offset: 0x663680 VA: 0x180664C80 Slot: 5
	protected override void Awake() { }

	// RVA: 0x664D10 Offset: 0x663710 VA: 0x180664D10 Slot: 31
	public virtual void InitializeSaveable() { }

	// RVA: 0x664CD0 Offset: 0x6636D0 VA: 0x180664CD0 Slot: 32
	public virtual string GetSaveString() { }

	// RVA: 0x665E60 Offset: 0x664860 VA: 0x180665E60 Slot: 33
	public virtual List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x665170 Offset: 0x663B70 VA: 0x180665170
	public void SavePlayer(Player player) { }

	// RVA: 0x664DA0 Offset: 0x6637A0 VA: 0x180664DA0
	public void LoadPlayer(PlayerData data, string containerPath) { }

	// RVA: 0x664900 Offset: 0x663300 VA: 0x180664900
	public void AllPlayerFilesLoaded() { }

	// RVA: 0x665600 Offset: 0x664000 VA: 0x180665600
	public bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out VariableData[] variables) { }

	// RVA: 0x6663D0 Offset: 0x664DD0 VA: 0x1806663D0
	public void .ctor() { }
}
