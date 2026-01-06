public class SewerManager : NetworkSingleton<SewerManager>, IBaseSaveable, ISaveable // TypeDefIndex: 3362
{
	// Fields
	[CompilerGenerated]
	private bool <IsSewerUnlocked>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsRandomWorldKeyCollected>k__BackingField; // 0x121
	[CompilerGenerated]
	private int <RandomSewerKeyLocationIndex>k__BackingField; // 0x124
	[CompilerGenerated]
	private bool <HasSewerKingBeenDefeated>k__BackingField; // 0x128
	[CompilerGenerated]
	private int <RandomSewerPossessorIndex>k__BackingField; // 0x12C
	public ItemDefinition SewerKeyItem; // 0x130
	public AudioSourceController SewerUnlockSound; // 0x138
	public NetworkedItemPickup RandomWorldSewerKeyPickup; // 0x140
	public Transform[] RandomSewerKeyLocations; // 0x148
	public SewerKing SewerKingNPC; // 0x150
	public SewerGoblin SewerGoblinNPC; // 0x158
	public SewerManager.KeyPossessor[] SewerKeyPossessors; // 0x160
	public SewerMushrooms SewerMushrooms; // 0x168
	private SewerLoader loader; // 0x170
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x178
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x180
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x188
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x18C
	private bool NetworkInitialize___EarlyScheduleOne.Map.SewerManagerAssembly-CSharp.dll_Excuted; // 0x190
	private bool NetworkInitialize__LateScheduleOne.Map.SewerManagerAssembly-CSharp.dll_Excuted; // 0x191

	// Properties
	public bool IsSewerUnlocked { get; set; }
	public bool IsRandomWorldKeyCollected { get; set; }
	public int RandomSewerKeyLocationIndex { get; set; }
	public bool HasSewerKingBeenDefeated { get; set; }
	public int RandomSewerPossessorIndex { get; set; }
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
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_IsSewerUnlocked() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	private void set_IsSewerUnlocked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x60EB50 Offset: 0x60D550 VA: 0x18060EB50
	public bool get_IsRandomWorldKeyCollected() { }

	[CompilerGenerated]
	// RVA: 0x60EB70 Offset: 0x60D570 VA: 0x18060EB70
	private void set_IsRandomWorldKeyCollected(bool value) { }

	[CompilerGenerated]
	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	public int get_RandomSewerKeyLocationIndex() { }

	[CompilerGenerated]
	// RVA: 0x7049D0 Offset: 0x7033D0 VA: 0x1807049D0
	public void set_RandomSewerKeyLocationIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x67E960 Offset: 0x67D360 VA: 0x18067E960
	public bool get_HasSewerKingBeenDefeated() { }

	[CompilerGenerated]
	// RVA: 0x67EAB0 Offset: 0x67D4B0 VA: 0x18067EAB0
	private void set_HasSewerKingBeenDefeated(bool value) { }

	[CompilerGenerated]
	// RVA: 0x618100 Offset: 0x616B00 VA: 0x180618100
	public int get_RandomSewerPossessorIndex() { }

	[CompilerGenerated]
	// RVA: 0x618180 Offset: 0x616B80 VA: 0x180618180
	public void set_RandomSewerPossessorIndex(int value) { }

	// RVA: 0xA59CE0 Offset: 0xA586E0 VA: 0x180A59CE0 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0xA59CB0 Offset: 0xA586B0 VA: 0x180A59CB0 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0xA59C90 Offset: 0xA58690 VA: 0x180A59C90 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0xA59D10 Offset: 0xA58710 VA: 0x180A59D10 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0xA59CA0 Offset: 0xA586A0 VA: 0x180A59CA0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0xA562D0 Offset: 0xA54CD0 VA: 0x180A562D0 Slot: 20
	public override void Awake() { }

	// RVA: 0xA59790 Offset: 0xA58190 VA: 0x180A59790 Slot: 19
	protected override void Start() { }

	// RVA: 0xA56B50 Offset: 0xA55550 VA: 0x180A56B50 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0xA57220 Offset: 0xA55C20 VA: 0x180A57220 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA59650 Offset: 0xA58050 VA: 0x180A59650
	public void SetSewerUnlocked_Server() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA593B0 Offset: 0xA57DB0 VA: 0x180A593B0
	private void SetSewerUnlocked_Client(NetworkConnection conn) { }

	// RVA: 0xA58DA0 Offset: 0xA577A0 VA: 0x180A58DA0
	public void SetRandomWorldKeyCollected() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA58DA0 Offset: 0xA577A0 VA: 0x180A58DA0
	private void SetRandomKeyCollected_Server() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA58B30 Offset: 0xA57530 VA: 0x180A58B30
	private void SetRandomKeyCollected_Client(NetworkConnection conn) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA59130 Offset: 0xA57B30 VA: 0x180A59130
	private void SetSewerKeyLocation(NetworkConnection conn, int locationIndex) { }

	// RVA: 0xA59780 Offset: 0xA58180 VA: 0x180A59780
	private void SewerKingDefeated() { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0xA56320 Offset: 0xA54D20 VA: 0x180A56320
	private void DisableSewerKing(NetworkConnection conn) { }

	// RVA: 0xA566D0 Offset: 0xA550D0 VA: 0x180A566D0
	public List<Player> GetPlayersInSewer() { }

	// RVA: 0xA56990 Offset: 0xA55390 VA: 0x180A56990 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0xA56BE0 Offset: 0xA555E0 VA: 0x180A56BE0
	public void Load(SewerData sewerData) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA58EB0 Offset: 0xA578B0 VA: 0x180A58EB0
	private void SetRandomKeyPossessor(NetworkConnection conn, int possessorIndex) { }

	// RVA: 0xA55FD0 Offset: 0xA549D0 VA: 0x180A55FD0
	private void AskedAboutSewerKey() { }

	// RVA: 0xA56520 Offset: 0xA54F20 VA: 0x180A56520
	private void EnsureKeyPosessorHasKey() { }

	// RVA: 0xA56B00 Offset: 0xA55500 VA: 0x180A56B00
	public SewerManager.KeyPossessor GetSewerKeyPossessor() { }

	// RVA: 0xA59B70 Offset: 0xA58570 VA: 0x180A59B70
	public void .ctor() { }

	// RVA: 0xA56E80 Offset: 0xA55880 VA: 0x180A56E80 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA56E30 Offset: 0xA55830 VA: 0x180A56E30 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA583B0 Offset: 0xA56DB0 VA: 0x180A583B0
	private void RpcWriter___Server_SetSewerUnlocked_Server_2166136261() { }

	// RVA: 0x5EAB30 Offset: 0x5E9530 VA: 0x1805EAB30
	public void RpcLogic___SetSewerUnlocked_Server_2166136261() { }

	// RVA: 0xA57A30 Offset: 0xA56430 VA: 0x180A57A30
	private void RpcReader___Server_SetSewerUnlocked_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA58180 Offset: 0xA56B80 VA: 0x180A58180
	private void RpcWriter___Observers_SetSewerUnlocked_Client_328543758(NetworkConnection conn) { }

	// RVA: 0xA577A0 Offset: 0xA561A0 VA: 0x180A577A0
	private void RpcLogic___SetSewerUnlocked_Client_328543758(NetworkConnection conn) { }

	// RVA: 0xA579A0 Offset: 0xA563A0 VA: 0x180A579A0
	private void RpcReader___Observers_SetSewerUnlocked_Client_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA58A00 Offset: 0xA57400 VA: 0x180A58A00
	private void RpcWriter___Target_SetSewerUnlocked_Client_328543758(NetworkConnection conn) { }

	// RVA: 0xA57C20 Offset: 0xA56620 VA: 0x180A57C20
	private void RpcReader___Target_SetSewerUnlocked_Client_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA582A0 Offset: 0xA56CA0 VA: 0x180A582A0
	private void RpcWriter___Server_SetRandomKeyCollected_Server_2166136261() { }

	// RVA: 0xA573D0 Offset: 0xA55DD0 VA: 0x180A573D0
	private void RpcLogic___SetRandomKeyCollected_Server_2166136261() { }

	// RVA: 0xA579E0 Offset: 0xA563E0 VA: 0x180A579E0
	private void RpcReader___Server_SetRandomKeyCollected_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA57DC0 Offset: 0xA567C0 VA: 0x180A57DC0
	private void RpcWriter___Observers_SetRandomKeyCollected_Client_328543758(NetworkConnection conn) { }

	// RVA: 0xA57390 Offset: 0xA55D90 VA: 0x180A57390
	private void RpcLogic___SetRandomKeyCollected_Client_328543758(NetworkConnection conn) { }

	// RVA: 0xA57860 Offset: 0xA56260 VA: 0x180A57860
	private void RpcReader___Observers_SetRandomKeyCollected_Client_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA585F0 Offset: 0xA56FF0 VA: 0x180A585F0
	private void RpcWriter___Target_SetRandomKeyCollected_Client_328543758(NetworkConnection conn) { }

	// RVA: 0xA57AE0 Offset: 0xA564E0 VA: 0x180A57AE0
	private void RpcReader___Target_SetRandomKeyCollected_Client_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA58030 Offset: 0xA56A30 VA: 0x180A58030
	private void RpcWriter___Observers_SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex) { }

	// RVA: 0xA57620 Offset: 0xA56020 VA: 0x180A57620
	private void RpcLogic___SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex) { }

	// RVA: 0xA57930 Offset: 0xA56330 VA: 0x180A57930
	private void RpcReader___Observers_SetSewerKeyLocation_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA58890 Offset: 0xA57290 VA: 0x180A58890
	private void RpcWriter___Target_SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex) { }

	// RVA: 0xA57BB0 Offset: 0xA565B0 VA: 0x180A57BB0
	private void RpcReader___Target_SetSewerKeyLocation_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA57CA0 Offset: 0xA566A0 VA: 0x180A57CA0
	private void RpcWriter___Observers_DisableSewerKing_328543758(NetworkConnection conn) { }

	// RVA: 0xA57350 Offset: 0xA55D50 VA: 0x180A57350
	private void RpcLogic___DisableSewerKing_328543758(NetworkConnection conn) { }

	// RVA: 0xA57810 Offset: 0xA56210 VA: 0x180A57810
	private void RpcReader___Observers_DisableSewerKing_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA584C0 Offset: 0xA56EC0 VA: 0x180A584C0
	private void RpcWriter___Target_DisableSewerKing_328543758(NetworkConnection conn) { }

	// RVA: 0xA57A80 Offset: 0xA56480 VA: 0x180A57A80
	private void RpcReader___Target_DisableSewerKing_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA57EE0 Offset: 0xA568E0 VA: 0x180A57EE0
	private void RpcWriter___Observers_SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex) { }

	// RVA: 0xA573E0 Offset: 0xA55DE0 VA: 0x180A573E0
	private void RpcLogic___SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex) { }

	// RVA: 0xA578C0 Offset: 0xA562C0 VA: 0x180A578C0
	private void RpcReader___Observers_SetRandomKeyPossessor_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA58720 Offset: 0xA57120 VA: 0x180A58720
	private void RpcWriter___Target_SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex) { }

	// RVA: 0xA57B40 Offset: 0xA56540 VA: 0x180A57B40
	private void RpcReader___Target_SetRandomKeyPossessor_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA560C0 Offset: 0xA54AC0 VA: 0x180A560C0 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Map.SewerManager_Assembly-CSharp.dll() { }
}
