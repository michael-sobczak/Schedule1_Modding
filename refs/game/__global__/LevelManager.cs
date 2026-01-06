public class LevelManager : NetworkSingleton<LevelManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1276
{
	// Fields
	public const int TIERS_PER_RANK = 5;
	public const int XP_PER_TIER_MIN = 200;
	public const int XP_PER_TIER_MAX = 2500;
	[CompilerGenerated]
	private ERank <Rank>k__BackingField; // 0x120
	private int rankCount; // 0x124
	[CompilerGenerated]
	private int <Tier>k__BackingField; // 0x128
	[CompilerGenerated]
	private int <XP>k__BackingField; // 0x12C
	[CompilerGenerated]
	private int <TotalXP>k__BackingField; // 0x130
	public Action<FullRank, FullRank> onRankUp; // 0x138
	public Action<FullRank, FullRank> onRankChanged; // 0x140
	public Dictionary<FullRank, List<Unlockable>> Unlockables; // 0x148
	private RankLoader loader; // 0x150
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x158
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x160
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x168
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x16C
	private bool NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted; // 0x170
	private bool NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted; // 0x171

	// Properties
	public ERank Rank { get; set; }
	public int Tier { get; set; }
	public int XP { get; set; }
	public int TotalXP { get; set; }
	public float XPToNextTier { get; }
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
	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public ERank get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	private void set_Rank(ERank value) { }

	[CompilerGenerated]
	// RVA: 0x51D950 Offset: 0x51C350 VA: 0x18051D950
	public int get_Tier() { }

	[CompilerGenerated]
	// RVA: 0x618170 Offset: 0x616B70 VA: 0x180618170
	private void set_Tier(int value) { }

	[CompilerGenerated]
	// RVA: 0x618100 Offset: 0x616B00 VA: 0x180618100
	public int get_XP() { }

	[CompilerGenerated]
	// RVA: 0x618180 Offset: 0x616B80 VA: 0x180618180
	private void set_XP(int value) { }

	[CompilerGenerated]
	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public int get_TotalXP() { }

	[CompilerGenerated]
	// RVA: 0x523860 Offset: 0x522260 VA: 0x180523860
	private void set_TotalXP(int value) { }

	// RVA: 0x618090 Offset: 0x616A90 VA: 0x180618090
	public float get_XPToNextTier() { }

	// RVA: 0x618060 Offset: 0x616A60 VA: 0x180618060 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x618030 Offset: 0x616A30 VA: 0x180618030 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x618140 Offset: 0x616B40 VA: 0x180618140 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x617FF0 Offset: 0x6169F0 VA: 0x180617FF0 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x618110 Offset: 0x616B10 VA: 0x180618110 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x618000 Offset: 0x616A00 VA: 0x180618000 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x615310 Offset: 0x613D10 VA: 0x180615310 Slot: 20
	public override void Awake() { }

	// RVA: 0x617E40 Offset: 0x616840 VA: 0x180617E40 Slot: 19
	protected override void Start() { }

	// RVA: 0x616260 Offset: 0x614C60 VA: 0x180616260 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x615F30 Offset: 0x614930 VA: 0x180615F30 Slot: 49
	public virtual void InitializeSaveable() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x615100 Offset: 0x613B00 VA: 0x180615100
	public void AddXP(int xp) { }

	[ObserversRpc]
	// RVA: 0x614FB0 Offset: 0x6139B0 VA: 0x180614FB0
	private void AddXPLocal(int xp) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x617850 Offset: 0x616250 VA: 0x180617850
	public void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x617BE0 Offset: 0x6165E0 VA: 0x180617BE0
	public void SetUnlockedRegions(NetworkConnection conn, List<EMapRegion> unlockedRegions) { }

	[ObserversRpc]
	// RVA: 0x615D00 Offset: 0x614700 VA: 0x180615D00
	private void IncreaseTierNetworked(FullRank before, FullRank after) { }

	// RVA: 0x615E70 Offset: 0x614870 VA: 0x180615E70
	private void IncreaseTier() { }

	// RVA: 0x615860 Offset: 0x614260 VA: 0x180615860 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x615410 Offset: 0x613E10 VA: 0x180615410
	public FullRank GetFullRank() { }

	// RVA: 0x614D20 Offset: 0x613720 VA: 0x180614D20
	public void AddUnlockable(Unlockable unlockable) { }

	// RVA: 0x6159F0 Offset: 0x6143F0 VA: 0x1806159F0
	public int GetTotalXPForRank(FullRank fullrank) { }

	// RVA: 0x615430 Offset: 0x613E30 VA: 0x180615430
	public FullRank GetFullRank(int totalXp) { }

	// RVA: 0x615C90 Offset: 0x614690 VA: 0x180615C90
	public int GetXPForTier(ERank rank) { }

	// RVA: 0x6156F0 Offset: 0x6140F0 VA: 0x1806156F0
	public static float GetOrderLimitMultiplier(FullRank rank) { }

	// RVA: 0x6157B0 Offset: 0x6141B0 VA: 0x1806157B0
	private static float GetRankOrderLimitMultiplier(ERank rank) { }

	// RVA: 0x617E90 Offset: 0x616890 VA: 0x180617E90
	public void .ctor() { }

	// RVA: 0x616010 Offset: 0x614A10 VA: 0x180616010 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x615FC0 Offset: 0x6149C0 VA: 0x180615FC0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x615100 Offset: 0x613B00 VA: 0x180615100
	private void RpcWriter___Server_AddXP_3316948804(int xp) { }

	// RVA: 0x614FB0 Offset: 0x6139B0 VA: 0x180614FB0
	public void RpcLogic___AddXP_3316948804(int xp) { }

	// RVA: 0x616F40 Offset: 0x615940 VA: 0x180616F40
	private void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x614FB0 Offset: 0x6139B0 VA: 0x180614FB0
	private void RpcWriter___Observers_AddXPLocal_3316948804(int xp) { }

	// RVA: 0x616360 Offset: 0x614D60 VA: 0x180616360
	private void RpcLogic___AddXPLocal_3316948804(int xp) { }

	// RVA: 0x616C20 Offset: 0x615620 VA: 0x180616C20
	private void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x617240 Offset: 0x615C40 VA: 0x180617240
	private void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp) { }

	// RVA: 0x616A30 Offset: 0x615430 VA: 0x180616A30
	public void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp) { }

	// RVA: 0x616DD0 Offset: 0x6157D0 VA: 0x180616DD0
	private void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x617540 Offset: 0x615F40 VA: 0x180617540
	private void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp) { }

	// RVA: 0x6170D0 Offset: 0x615AD0 VA: 0x1806170D0
	private void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x617400 Offset: 0x615E00 VA: 0x180617400
	private void RpcWriter___Observers_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions) { }

	// RVA: 0x616AB0 Offset: 0x6154B0 VA: 0x180616AB0
	public void RpcLogic___SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions) { }

	// RVA: 0x616EE0 Offset: 0x6158E0 VA: 0x180616EE0
	private void RpcReader___Observers_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6176F0 Offset: 0x6160F0 VA: 0x1806176F0
	private void RpcWriter___Target_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions) { }

	// RVA: 0x6171E0 Offset: 0x615BE0 VA: 0x1806171E0
	private void RpcReader___Target_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x615D00 Offset: 0x614700 VA: 0x180615D00
	private void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after) { }

	// RVA: 0x616910 Offset: 0x615310 VA: 0x180616910
	private void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after) { }

	// RVA: 0x616C80 Offset: 0x615680 VA: 0x180616C80
	private void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x615240 Offset: 0x613C40 VA: 0x180615240 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Levelling.LevelManager_Assembly-CSharp.dll() { }
}
