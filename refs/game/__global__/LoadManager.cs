public class LoadManager : PersistentSingleton<LoadManager> // TypeDefIndex: 864
{
	// Fields
	public const int LOADS_PER_FRAME = 50;
	public const bool DEBUG = False;
	public const float LOAD_ERROR_TIMEOUT = 90;
	public const float NETWORK_TIMEOUT = 30;
	public static List<string> LoadHistory; // 0x0
	public static SaveInfo[] SaveGames; // 0x8
	public static SaveInfo LastPlayedGame; // 0x10
	[CompilerGenerated]
	private bool <IsGameLoaded>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsLoading>k__BackingField; // 0x29
	[CompilerGenerated]
	private float <TimeSinceGameLoaded>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <DebugMode>k__BackingField; // 0x30
	[CompilerGenerated]
	private LoadManager.ELoadStatus <LoadStatus>k__BackingField; // 0x34
	[CompilerGenerated]
	private string <LoadedGameFolderPath>k__BackingField; // 0x38
	[CompilerGenerated]
	private SaveInfo <ActiveSaveInfo>k__BackingField; // 0x40
	[CompilerGenerated]
	private SaveInfo <StoredSaveInfo>k__BackingField; // 0x48
	private List<LoadRequest> loadRequests; // 0x50
	public List<ItemLoader> ItemLoaders; // 0x58
	public List<BuildableItemLoader> ObjectLoaders; // 0x60
	public List<LegacyNPCLoader> LegacyNPCLoaders; // 0x68
	public List<NPCLoader> NPCLoaders; // 0x70
	public UnityEvent onPreSceneChange; // 0x78
	public UnityEvent onPreLoad; // 0x80
	public UnityEvent onLoadComplete; // 0x88
	public UnityEvent onSaveInfoLoaded; // 0x90
	private List<IStaggeredReplicator> staggeredReplicators; // 0x98

	// Properties
	public string DefaultTutorialSaveFolder { get; }
	public bool IsGameLoaded { get; set; }
	public bool IsLoading { get; set; }
	public float TimeSinceGameLoaded { get; set; }
	public bool DebugMode { get; set; }
	public LoadManager.ELoadStatus LoadStatus { get; set; }
	public string LoadedGameFolderPath { get; set; }
	public SaveInfo ActiveSaveInfo { get; set; }
	public SaveInfo StoredSaveInfo { get; set; }

	// Methods

	// RVA: 0x5A9C80 Offset: 0x5A8680 VA: 0x1805A9C80
	public string get_DefaultTutorialSaveFolder() { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsGameLoaded() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsGameLoaded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_IsLoading() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	protected void set_IsLoading(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_TimeSinceGameLoaded() { }

	[CompilerGenerated]
	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	protected void set_TimeSinceGameLoaded(float value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_DebugMode() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_DebugMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public LoadManager.ELoadStatus get_LoadStatus() { }

	[CompilerGenerated]
	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	protected void set_LoadStatus(LoadManager.ELoadStatus value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_LoadedGameFolderPath() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_LoadedGameFolderPath(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public SaveInfo get_ActiveSaveInfo() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_ActiveSaveInfo(SaveInfo value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public SaveInfo get_StoredSaveInfo() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_StoredSaveInfo(SaveInfo value) { }

	// RVA: 0x5A60A0 Offset: 0x5A4AA0 VA: 0x1805A60A0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x5A8790 Offset: 0x5A7190 VA: 0x1805A8790 Slot: 4
	protected override void Start() { }

	// RVA: 0x5A60E0 Offset: 0x5A4AE0 VA: 0x1805A60E0
	private void Bananas() { }

	// RVA: 0x5A75C0 Offset: 0x5A5FC0 VA: 0x1805A75C0
	private void InitializeItemLoaders() { }

	// RVA: 0x5A7940 Offset: 0x5A6340 VA: 0x1805A7940
	private void InitializeObjectLoaders() { }

	// RVA: 0x5A7780 Offset: 0x5A6180 VA: 0x1805A7780
	private void InitializeNPCLoaders() { }

	// RVA: 0x5A9920 Offset: 0x5A8320 VA: 0x1805A9920
	public void Update() { }

	// RVA: 0x5A7F00 Offset: 0x5A6900 VA: 0x1805A7F00
	public void QueueLoadRequest(LoadRequest request) { }

	// RVA: 0x5A6B00 Offset: 0x5A5500 VA: 0x1805A6B00
	public void DequeueLoadRequest(LoadRequest request) { }

	// RVA: 0x5A6F00 Offset: 0x5A5900 VA: 0x1805A6F00
	public ItemLoader GetItemLoader(string itemType) { }

	// RVA: 0x5A7480 Offset: 0x5A5E80 VA: 0x1805A7480
	public BuildableItemLoader GetObjectLoader(string objectType) { }

	// RVA: 0x5A7040 Offset: 0x5A5A40 VA: 0x1805A7040
	public LegacyNPCLoader GetLegacyNPCLoader(string npcType) { }

	// RVA: 0x5A7340 Offset: 0x5A5D40 VA: 0x1805A7340
	public NPCLoader GetNPCLoader(string npcType) { }

	// RVA: 0x5A7180 Offset: 0x5A5B80 VA: 0x1805A7180
	public string GetLoadStatusText() { }

	// RVA: 0x5A8450 Offset: 0x5A6E50 VA: 0x1805A8450
	public void StartGame(SaveInfo info, bool allowLoadStacking = False, bool allowSaveBackup = True) { }

	// RVA: 0x5A7E10 Offset: 0x5A6810 VA: 0x1805A7E10
	public void LoadTutorialAsClient() { }

	// RVA: 0x5A7C70 Offset: 0x5A6670 VA: 0x1805A7C70
	public void LoadAsClient(string steamId64) { }

	// RVA: 0x5A8710 Offset: 0x5A7110 VA: 0x1805A8710
	private void StartLoadErrorAutosubmit() { }

	// RVA: 0x5A8440 Offset: 0x5A6E40 VA: 0x1805A8440
	public void SetWaitingForHostLoad() { }

	// RVA: 0x5A7D80 Offset: 0x5A6780 VA: 0x1805A7D80
	public void LoadLastSave() { }

	// RVA: 0x5A64F0 Offset: 0x5A4EF0 VA: 0x1805A64F0
	private void CleanUp() { }

	// RVA: 0x5A6B60 Offset: 0x5A5560 VA: 0x1805A6B60
	public void ExitToMenu(SaveInfo autoLoadSave, MainMenuPopup.Data mainMenuPopup, bool preventLeaveLobby = False) { }

	// RVA: 0x5A8DA0 Offset: 0x5A77A0 VA: 0x1805A8DA0
	public static bool TryLoadSaveInfo(string saveFolderPath, int saveSlotIndex, out SaveInfo saveInfo, bool requireGameFile = False) { }

	// RVA: 0x5A7FB0 Offset: 0x5A69B0 VA: 0x1805A7FB0
	public void RefreshSaveInfo() { }

	// RVA: 0x5A5FC0 Offset: 0x5A49C0 VA: 0x1805A5FC0
	public void AddStaggeredReplicator(IStaggeredReplicator replicator) { }

	// RVA: 0x5A9A60 Offset: 0x5A8460 VA: 0x1805A9A60
	public void .ctor() { }

	// RVA: 0x5A9960 Offset: 0x5A8360 VA: 0x1805A9960
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x5A9740 Offset: 0x5A8140 VA: 0x1805A9740
	internal static void <LoadAsClient>g__PlayerSpawned|68_6() { }

	[IteratorStateMachine(typeof(LoadManager.<<StartLoadErrorAutosubmit>g__Wait|69_0>d))]
	[CompilerGenerated]
	// RVA: 0x5A98B0 Offset: 0x5A82B0 VA: 0x1805A98B0
	private IEnumerator <StartLoadErrorAutosubmit>g__Wait|69_0() { }
}
