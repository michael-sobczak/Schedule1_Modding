public class NPCManager : NetworkSingleton<NPCManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1647
{
	// Fields
	public static List<NPC> NPCRegistry; // 0x0
	public Transform[] NPCWarpPoints; // 0x120
	public Transform NPCContainer; // 0x128
	[Header("Prefabs")]
	public NPCPoI NPCPoIPrefab; // 0x130
	public NPCPoI PotentialCustomerPoIPrefab; // 0x138
	public NPCPoI PotentialDealerPoIPrefab; // 0x140
	private NPCsLoader loader; // 0x148
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x150
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x158
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x160
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x164
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted; // 0x169

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

	// RVA: 0x71DBC0 Offset: 0x71C5C0 VA: 0x18071DBC0 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x71DB90 Offset: 0x71C590 VA: 0x18071DB90 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x71DB60 Offset: 0x71C560 VA: 0x18071DB60 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x71DBF0 Offset: 0x71C5F0 VA: 0x18071DBF0 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x71DB70 Offset: 0x71C570 VA: 0x18071DB70 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x71CAA0 Offset: 0x71B4A0 VA: 0x18071CAA0 Slot: 20
	public override void Awake() { }

	// RVA: 0x71D5B0 Offset: 0x71BFB0 VA: 0x18071D5B0 Slot: 19
	protected override void Start() { }

	// RVA: 0x71D480 Offset: 0x71BE80 VA: 0x18071D480 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x71CB20 Offset: 0x71B520 VA: 0x18071CB20
	public static NPC GetNPC(string id) { }

	// RVA: 0x71CCD0 Offset: 0x71B6D0 VA: 0x18071CCD0
	public static List<NPC> GetNPCsInRegion(EMapRegion region) { }

	// RVA: 0x71D260 Offset: 0x71BC60 VA: 0x18071D260 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x71D130 Offset: 0x71BB30 VA: 0x18071D130
	public List<Transform> GetOrderedDistanceWarpPoints(Vector3 origin) { }

	// RVA: 0x71D730 Offset: 0x71C130 VA: 0x18071D730 Slot: 51
	public virtual List<string> WriteData(string parentFolderPath) { }

	[Button]
	// RVA: 0x71CED0 Offset: 0x71B8D0 VA: 0x18071CED0
	public void GetNPCsWithSewerKey() { }

	// RVA: 0x71DA60 Offset: 0x71C460 VA: 0x18071DA60
	public void .ctor() { }

	// RVA: 0x71D9D0 Offset: 0x71C3D0 VA: 0x18071D9D0
	private static void .cctor() { }

	// RVA: 0x71D560 Offset: 0x71BF60 VA: 0x18071D560 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x71D510 Offset: 0x71BF10 VA: 0x18071D510 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x71CA50 Offset: 0x71B450 VA: 0x18071CA50 Slot: 52
	protected override void Awake_UserLogic_ScheduleOne.NPCs.NPCManager_Assembly-CSharp.dll() { }
}
