public class GameManager : NetworkSingleton<GameManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1904
{
	// Fields
	public const bool IS_DEMO = False;
	public static bool IS_BETA; // 0x0
	[SerializeField]
	private int seed; // 0x120
	public string OrganisationName; // 0x128
	[CompilerGenerated]
	private Sprite <OrganisationLogo>k__BackingField; // 0x130
	public GameSettings Settings; // 0x138
	public Transform SpawnPoint; // 0x140
	public Transform NoHomeRespawnPoint; // 0x148
	public Transform Temp; // 0x150
	public UnityEvent onSettingsLoaded; // 0x158
	private GameDataLoader loader; // 0x160
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x168
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x170
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x178
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x17C
	private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public static bool IS_TUTORIAL { get; }
	public static int Seed { get; }
	public Sprite OrganisationLogo { get; set; }
	public bool IsTutorial { get; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	// RVA: 0x77BBF0 Offset: 0x77A5F0 VA: 0x18077BBF0
	public static bool get_IS_TUTORIAL() { }

	// RVA: 0x77BD40 Offset: 0x77A740 VA: 0x18077BD40
	public static int get_Seed() { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public Sprite get_OrganisationLogo() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	protected void set_OrganisationLogo(Sprite value) { }

	// RVA: 0x77BC60 Offset: 0x77A660 VA: 0x18077BC60
	public bool get_IsTutorial() { }

	// RVA: 0x77BD10 Offset: 0x77A710 VA: 0x18077BD10 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x77BCE0 Offset: 0x77A6E0 VA: 0x18077BCE0 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x73B390 Offset: 0x739D90 VA: 0x18073B390 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x73B510 Offset: 0x739F10 VA: 0x18073B510 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x77BCD0 Offset: 0x77A6D0 VA: 0x18077BCD0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x77AED0 Offset: 0x7798D0 VA: 0x18077AED0 Slot: 20
	public override void Awake() { }

	// RVA: 0x77B980 Offset: 0x77A380 VA: 0x18077B980 Slot: 19
	protected override void Start() { }

	// RVA: 0x77B500 Offset: 0x779F00 VA: 0x18077B500 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[TargetRpc]
	// RVA: 0x77B820 Offset: 0x77A220 VA: 0x18077B820
	public void SetGameData(NetworkConnection conn, GameData data) { }

	// RVA: 0x77B300 Offset: 0x779D00 VA: 0x18077B300 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x77B250 Offset: 0x779C50 VA: 0x18077B250 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x77B390 Offset: 0x779D90 VA: 0x18077B390
	public void Load(GameData data, string path) { }

	[Button]
	// RVA: 0x77AF60 Offset: 0x779960 VA: 0x18077AF60
	public void EndTutorial(bool natural) { }

	// RVA: 0x77B9C0 Offset: 0x77A3C0 VA: 0x18077B9C0
	public void .ctor() { }

	// RVA: 0x77B460 Offset: 0x779E60 VA: 0x18077B460 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x77B410 Offset: 0x779E10 VA: 0x18077B410 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x77B820 Offset: 0x77A220 VA: 0x18077B820
	private void RpcWriter___Target_SetGameData_3076874643(NetworkConnection conn, GameData data) { }

	// RVA: 0x77B700 Offset: 0x77A100 VA: 0x18077B700
	public void RpcLogic___SetGameData_3076874643(NetworkConnection conn, GameData data) { }

	// RVA: 0x77B780 Offset: 0x77A180 VA: 0x18077B780
	private void RpcReader___Target_SetGameData_3076874643(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77AE70 Offset: 0x779870 VA: 0x18077AE70 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.DevUtilities.GameManager_Assembly-CSharp.dll() { }
}
