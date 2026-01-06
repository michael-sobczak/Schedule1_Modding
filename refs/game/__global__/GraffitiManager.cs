public class GraffitiManager : NetworkSingleton<GraffitiManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1381
{
	// Fields
	private const string SPRAY_PAINT_STOCK_VARIABLE = "SprayPaintStock";
	private const string SPRAY_PAINTS_PURCHASED_VARIABLE = "SprayPaintsPurchased";
	[CompilerGenerated]
	private List<SpraySurface> <SpraySurfaces>k__BackingField; // 0x120
	private GraffitiLoader loader; // 0x128
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x130
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x138
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x140
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x144
	private List<Tuple<SpraySurface, NetworkConnection>> surfaceReplicationQueue; // 0x148
	private float timeUntilNextReplication; // 0x150
	private bool NetworkInitialize___EarlyScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted; // 0x154
	private bool NetworkInitialize__LateScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted; // 0x155

	// Properties
	public List<SpraySurface> SpraySurfaces { get; set; }
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
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public List<SpraySurface> get_SpraySurfaces() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_SpraySurfaces(List<SpraySurface> value) { }

	// RVA: 0x65D890 Offset: 0x65C290 VA: 0x18065D890 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x65D860 Offset: 0x65C260 VA: 0x18065D860 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x512C40 Offset: 0x511640 VA: 0x180512C40 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x65D8C0 Offset: 0x65C2C0 VA: 0x18065D8C0 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x513060 Offset: 0x511A60 VA: 0x180513060 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x65CA70 Offset: 0x65B470 VA: 0x18065CA70 Slot: 20
	public override void Awake() { }

	// RVA: 0x65CF40 Offset: 0x65B940 VA: 0x18065CF40 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x65CE10 Offset: 0x65B810 VA: 0x18065CE10 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x65D460 Offset: 0x65BE60 VA: 0x18065D460
	private void SprayPaintPurchaseCountChanged(float newValue) { }

	// RVA: 0x65D460 Offset: 0x65BE60 VA: 0x18065D460
	private void RankChange(FullRank oldRank, FullRank newRank) { }

	// RVA: 0x65D470 Offset: 0x65BE70 VA: 0x18065D470
	private void UpdateSprayPaintStockVariable() { }

	// RVA: 0x65CAF0 Offset: 0x65B4F0 VA: 0x18065CAF0 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x65D300 Offset: 0x65BD00 VA: 0x18065D300
	public void QueueSurfaceToReplicate(SpraySurface surface, NetworkConnection conn) { }

	// RVA: 0x65D6A0 Offset: 0x65C0A0 VA: 0x18065D6A0
	public void .ctor() { }

	// RVA: 0x65CEF0 Offset: 0x65B8F0 VA: 0x18065CEF0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x65CEA0 Offset: 0x65B8A0 VA: 0x18065CEA0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x65CA20 Offset: 0x65B420 VA: 0x18065CA20 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Graffiti.GraffitiManager_Assembly-CSharp.dll() { }
}
