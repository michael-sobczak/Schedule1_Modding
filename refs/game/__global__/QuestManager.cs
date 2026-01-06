public class QuestManager : NetworkSingleton<QuestManager>, IBaseSaveable, ISaveable // TypeDefIndex: 698
{
	// Fields
	public const EQuestState DEFAULT_QUEST_STATE = 0;
	public Quest[] DefaultQuests; // 0x120
	[Header("References")]
	public Transform QuestContainer; // 0x128
	public Transform ContractContainer; // 0x130
	public AudioSourceController QuestCompleteSound; // 0x138
	public AudioSourceController QuestEntryCompleteSound; // 0x140
	[Header("Prefabs")]
	public Contract ContractPrefab; // 0x148
	public DeaddropQuest DeaddropCollectionPrefab; // 0x150
	private QuestsLoader loader; // 0x158
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x160
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x170
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x174
	private bool NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted; // 0x179

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

	// RVA: 0xADF730 Offset: 0xADE130 VA: 0x180ADF730 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0xADF700 Offset: 0xADE100 VA: 0x180ADF700 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x618140 Offset: 0x616B40 VA: 0x180618140 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E22C0 Offset: 0x7E0CC0 VA: 0x1807E22C0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0xAD9880 Offset: 0xAD8280 VA: 0x180AD9880 Slot: 20
	public override void Awake() { }

	// RVA: 0xADB570 Offset: 0xAD9F70 VA: 0x180ADB570 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0xADF470 Offset: 0xADDE70 VA: 0x180ADF470 Slot: 19
	protected override void Start() { }

	// RVA: 0xADBA70 Offset: 0xADA470 VA: 0x180ADBA70 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xADF4E0 Offset: 0xADDEE0 VA: 0x180ADF4E0
	private void UpdateVariables() { }

	// RVA: 0xAD9A40 Offset: 0xAD8440 VA: 0x180AD9A40
	public Contract ContractAccepted(Customer customer, ContractInfo contractData, bool track, string guid, Dealer dealer) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xADA490 Offset: 0xAD8E90 VA: 0x180ADA490
	public void CreateContract_Networked(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj) { }

	// RVA: 0xADA1F0 Offset: 0xAD8BF0 VA: 0x180ADA1F0
	public Contract CreateContract_Local(string title, string description, QuestEntryData[] entries, string guid, bool tracked, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, Dealer dealer) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xADF020 Offset: 0xADDA20 VA: 0x180ADF020
	public void SendQuestAction(string guid, QuestManager.EQuestAction action) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xADBDD0 Offset: 0xADA7D0 VA: 0x180ADBDD0
	private void ReceiveQuestAction(NetworkConnection conn, string guid, QuestManager.EQuestAction action) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xADF310 Offset: 0xADDD10 VA: 0x180ADF310
	public void SendQuestState(string guid, EQuestState state) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xADC350 Offset: 0xADAD50 VA: 0x180ADC350
	private void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state) { }

	[TargetRpc]
	// RVA: 0xADEEC0 Offset: 0xADD8C0 VA: 0x180ADEEC0
	private void SetQuestTracked(NetworkConnection conn, string guid, bool tracked) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xADF180 Offset: 0xADDB80 VA: 0x180ADF180
	public void SendQuestEntryState(string guid, int entryIndex, EQuestState state) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xADC070 Offset: 0xADAA70 VA: 0x180ADC070
	private void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state) { }

	[Button]
	// RVA: 0xADBC10 Offset: 0xADA610 VA: 0x180ADBC10
	public void PrintQuestStates() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xADAC50 Offset: 0xAD9650 VA: 0x180ADAC50
	public void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "") { }

	// RVA: 0xADA890 Offset: 0xAD9290 VA: 0x180ADA890
	public DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "") { }

	// RVA: 0xADBBB0 Offset: 0xADA5B0 VA: 0x180ADBBB0
	public void PlayCompleteQuestSound() { }

	// RVA: 0xADBB80 Offset: 0xADA580 VA: 0x180ADBB80
	public void PlayCompleteQuestEntrySound() { }

	// RVA: 0xADAEE0 Offset: 0xAD98E0 VA: 0x180ADAEE0 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0xADF5F0 Offset: 0xADDFF0 VA: 0x180ADF5F0
	public void .ctor() { }

	// RVA: 0xADB650 Offset: 0xADA050 VA: 0x180ADB650 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0xADB600 Offset: 0xADA000 VA: 0x180ADB600 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xADDB40 Offset: 0xADC540 VA: 0x180ADDB40
	private void RpcWriter___Observers_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj) { }

	// RVA: 0xADC5F0 Offset: 0xADAFF0 VA: 0x180ADC5F0
	public void RpcLogic___CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj) { }

	// RVA: 0xADD030 Offset: 0xADBA30 VA: 0x180ADD030
	private void RpcReader___Observers_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADE740 Offset: 0xADD140 VA: 0x180ADE740
	private void RpcWriter___Target_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj) { }

	// RVA: 0xADD5D0 Offset: 0xADBFD0 VA: 0x180ADD5D0
	private void RpcReader___Target_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADE310 Offset: 0xADCD10 VA: 0x180ADE310
	private void RpcWriter___Server_SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action) { }

	// RVA: 0xADCE70 Offset: 0xADB870 VA: 0x180ADCE70
	public void RpcLogic___SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action) { }

	// RVA: 0xADD3F0 Offset: 0xADBDF0 VA: 0x180ADD3F0
	private void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xADDEA0 Offset: 0xADC8A0 VA: 0x180ADDEA0
	private void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action) { }

	// RVA: 0xADC980 Offset: 0xADB380 VA: 0x180ADC980
	private void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action) { }

	// RVA: 0xADD240 Offset: 0xADBC40 VA: 0x180ADD240
	private void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADEA80 Offset: 0xADD480 VA: 0x180ADEA80
	private void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action) { }

	// RVA: 0xADD7E0 Offset: 0xADC1E0 VA: 0x180ADD7E0
	private void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADE5E0 Offset: 0xADCFE0 VA: 0x180ADE5E0
	private void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state) { }

	// RVA: 0xADCEC0 Offset: 0xADB8C0 VA: 0x180ADCEC0
	public void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state) { }

	// RVA: 0xADD540 Offset: 0xADBF40 VA: 0x180ADD540
	private void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xADE1A0 Offset: 0xADCBA0 VA: 0x180ADE1A0
	private void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state) { }

	// RVA: 0xADCD20 Offset: 0xADB720 VA: 0x180ADCD20
	private void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state) { }

	// RVA: 0xADD370 Offset: 0xADBD70 VA: 0x180ADD370
	private void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADED60 Offset: 0xADD760 VA: 0x180ADED60
	private void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state) { }

	// RVA: 0xADD910 Offset: 0xADC310 VA: 0x180ADD910
	private void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADEEC0 Offset: 0xADD8C0 VA: 0x180ADEEC0
	private void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked) { }

	// RVA: 0xADCEE0 Offset: 0xADB8E0 VA: 0x180ADCEE0
	private void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked) { }

	// RVA: 0xADD990 Offset: 0xADC390 VA: 0x180ADD990
	private void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADE470 Offset: 0xADCE70 VA: 0x180ADE470
	private void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state) { }

	// RVA: 0xADCE90 Offset: 0xADB890 VA: 0x180ADCE90
	public void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state) { }

	// RVA: 0xADD480 Offset: 0xADBE80 VA: 0x180ADD480
	private void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xADE010 Offset: 0xADCA10 VA: 0x180ADE010
	private void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state) { }

	// RVA: 0xADCBC0 Offset: 0xADB5C0 VA: 0x180ADCBC0
	private void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state) { }

	// RVA: 0xADD2C0 Offset: 0xADBCC0 VA: 0x180ADD2C0
	private void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADEBE0 Offset: 0xADD5E0 VA: 0x180ADEBE0
	private void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state) { }

	// RVA: 0xADD860 Offset: 0xADC260 VA: 0x180ADD860
	private void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADDD30 Offset: 0xADC730 VA: 0x180ADDD30
	private void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "") { }

	// RVA: 0xADC960 Offset: 0xADB360 VA: 0x180ADC960
	public void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "") { }

	// RVA: 0xADD1C0 Offset: 0xADBBC0 VA: 0x180ADD1C0
	private void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xADE920 Offset: 0xADD320 VA: 0x180ADE920
	private void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "") { }

	// RVA: 0xADD760 Offset: 0xADC160 VA: 0x180ADD760
	private void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD96F0 Offset: 0xAD80F0 VA: 0x180AD96F0 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Quests.QuestManager_Assembly-CSharp.dll() { }
}
