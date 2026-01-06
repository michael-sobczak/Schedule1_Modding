public class OldMixingStation : GridItem, IUsable, IItemSlotOwner // TypeDefIndex: 3268
{
	// Fields
	public int MIX_TIME_PER_ITEM; // 0x210
	public int MIN_MIX_TIME; // 0x214
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x218
	[CompilerGenerated]
	private MixOperation <CurrentMixOperation>k__BackingField; // 0x220
	public ItemSlot ProductSlot; // 0x228
	public ItemSlot MixerSlot; // 0x230
	public ItemSlot OutputSlot; // 0x238
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x240
	[CompilerGenerated]
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x248
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	[CompilerGenerated]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x250
	[Header("References")]
	public InteractableObject IntObj; // 0x258
	public Transform CameraPosition; // 0x260
	public StorageVisualizer InputVisuals; // 0x268
	public StorageVisualizer OutputVisuals; // 0x270
	public Animation Animation; // 0x278
	[Header("Screen")]
	public Canvas ScreenCanvas; // 0x280
	public Image OutputIcon; // 0x288
	public TextMeshProUGUI QuantityLabel; // 0x290
	public TextMeshProUGUI ProgressLabel; // 0x298
	[Header("Sounds")]
	public StartLoopStopAudio MachineSound; // 0x2A0
	public AudioSourceController StartSound; // 0x2A8
	public AudioSourceController StopSound; // 0x2B0
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x2B8
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x2C0
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted; // 0x2C8
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted; // 0x2C9

	// Properties
	public bool IsOpen { get; set; }
	public MixOperation CurrentMixOperation { get; set; }
	public List<ItemSlot> ItemSlots { get; set; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x860A30 Offset: 0x85F430 VA: 0x180860A30
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x860BA0 Offset: 0x85F5A0 VA: 0x180860BA0
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public MixOperation get_CurrentMixOperation() { }

	[CompilerGenerated]
	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00
	public void set_CurrentMixOperation(MixOperation value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70 Slot: 81
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80 Slot: 82
	public void set_ItemSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0 Slot: 73
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA2C470 Offset: 0xA2AE70 VA: 0x180A2C470 Slot: 74
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0 Slot: 75
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA2C510 Offset: 0xA2AF10 VA: 0x180A2C510 Slot: 76
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0xA2AAE0 Offset: 0xA294E0 VA: 0x180A2AAE0 Slot: 47
	public override void Awake() { }

	// RVA: 0xA2FD40 Offset: 0xA2E740 VA: 0x180A2FD40 Slot: 48
	protected override void Start() { }

	// RVA: 0xA2BD50 Offset: 0xA2A750 VA: 0x180A2BD50 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA2AE10 Offset: 0xA29810 VA: 0x180A2AE10 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA2B6C0 Offset: 0xA2A0C0 VA: 0x180A2B6C0
	private void MinPass() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA2EAD0 Offset: 0xA2D4D0 VA: 0x180A2EAD0
	public void SetMixOperation(NetworkConnection conn, MixOperation operation) { }

	// RVA: 0xA2B070 Offset: 0xA29A70 VA: 0x180A2B070
	private void EnableScreen() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpdateScreen() { }

	// RVA: 0xA2AF20 Offset: 0xA29920 VA: 0x180A2AF20
	private void DisableScreen() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void CompleteMixOperation() { }

	// RVA: 0xA2AF50 Offset: 0xA29950 VA: 0x180A2AF50
	public bool DoesOutputHaveSpace(StationRecipe recipe) { }

	// RVA: 0xA2B400 Offset: 0xA29E00 VA: 0x180A2B400
	public List<ItemInstance> GetIngredients() { }

	// RVA: 0xA2BDB0 Offset: 0xA2A7B0 VA: 0x180A2BDB0
	public void Open() { }

	// RVA: 0xA2AB30 Offset: 0xA29530 VA: 0x180A2AB30
	public void Close() { }

	// RVA: 0xA2B4D0 Offset: 0xA29ED0 VA: 0x180A2B4D0
	public void Hovered() { }

	// RVA: 0xA2B610 Offset: 0xA2A010 VA: 0x180A2B610
	public void Interacted() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA2FBB0 Offset: 0xA2E5B0 VA: 0x180A2FBB0 Slot: 83
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA2F8F0 Offset: 0xA2E2F0 VA: 0x180A2F8F0
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA2E960 Offset: 0xA2D360 VA: 0x180A2E960 Slot: 84
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA2E7B0 Offset: 0xA2D1B0 VA: 0x180A2E7B0
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA2F710 Offset: 0xA2E110 VA: 0x180A2F710 Slot: 85
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA2F3F0 Offset: 0xA2DDF0 VA: 0x180A2F3F0
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA2F250 Offset: 0xA2DC50 VA: 0x180A2F250 Slot: 86
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA2EF90 Offset: 0xA2D990 VA: 0x180A2EF90
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA2EE60 Offset: 0xA2D860 VA: 0x180A2EE60 Slot: 79
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA2ED30 Offset: 0xA2D730 VA: 0x180A2ED30 Slot: 80
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA2B0A0 Offset: 0xA29AA0 VA: 0x180A2B0A0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA2FE60 Offset: 0xA2E860 VA: 0x180A2FE60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__37_0() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__37_1() { }

	[CompilerGenerated]
	// RVA: 0xA0AAB0 Offset: 0xA094B0 VA: 0x180A0AAB0
	private void <Awake>b__37_2() { }

	// RVA: 0xA2B740 Offset: 0xA2A140 VA: 0x180A2B740 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA2B6D0 Offset: 0xA2A0D0 VA: 0x180A2B6D0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA2D3B0 Offset: 0xA2BDB0 VA: 0x180A2D3B0
	private void RpcWriter___Observers_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation) { }

	// RVA: 0xA2C310 Offset: 0xA2AD10 VA: 0x180A2C310
	public void RpcLogic___SetMixOperation_719366965(NetworkConnection conn, MixOperation operation) { }

	// RVA: 0xA2C8E0 Offset: 0xA2B2E0 VA: 0x180A2C8E0
	private void RpcReader___Observers_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2E1E0 Offset: 0xA2CBE0 VA: 0x180A2E1E0
	private void RpcWriter___Target_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation) { }

	// RVA: 0xA2CFC0 Offset: 0xA2B9C0 VA: 0x180A2CFC0
	private void RpcReader___Target_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2E070 Offset: 0xA2CA70 VA: 0x180A2E070
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA2C770 Offset: 0xA2B170 VA: 0x180A2C770 Slot: 92
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA2CF00 Offset: 0xA2B900 VA: 0x180A2CF00
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA2E640 Offset: 0xA2D040 VA: 0x180A2E640
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA2C780 Offset: 0xA2B180 VA: 0x180A2C780
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA2D1A0 Offset: 0xA2BBA0 VA: 0x180A2D1A0
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2D810 Offset: 0xA2C210 VA: 0x180A2D810
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0xA2CAC0 Offset: 0xA2B4C0 VA: 0x180A2CAC0
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2D990 Offset: 0xA2C390 VA: 0x180A2D990
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA2C280 Offset: 0xA2AC80 VA: 0x180A2C280 Slot: 93
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA2CB50 Offset: 0xA2B550 VA: 0x180A2CB50
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA2D230 Offset: 0xA2BC30 VA: 0x180A2D230
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA2C290 Offset: 0xA2AC90 VA: 0x180A2C290
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0xA2C840 Offset: 0xA2B240 VA: 0x180A2C840
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2DEE0 Offset: 0xA2C8E0 VA: 0x180A2DEE0
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA2C6B0 Offset: 0xA2B0B0 VA: 0x180A2C6B0 Slot: 94
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA2CDF0 Offset: 0xA2B7F0 VA: 0x180A2CDF0
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA2E4B0 Offset: 0xA2CEB0 VA: 0x180A2E4B0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA2C6C0 Offset: 0xA2B0C0 VA: 0x180A2C6C0
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA2D0B0 Offset: 0xA2BAB0 VA: 0x180A2D0B0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2D670 Offset: 0xA2C070 VA: 0x180A2D670
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0xA2C9D0 Offset: 0xA2B3D0 VA: 0x180A2C9D0
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2DD70 Offset: 0xA2C770 VA: 0x180A2DD70
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA2C5B0 Offset: 0xA2AFB0 VA: 0x180A2C5B0 Slot: 95
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA2CD00 Offset: 0xA2B700 VA: 0x180A2CD00
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA2D4F0 Offset: 0xA2BEF0 VA: 0x180A2D4F0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA2C630 Offset: 0xA2B030 VA: 0x180A2C630
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA2C940 Offset: 0xA2B340 VA: 0x180A2C940
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2E340 Offset: 0xA2CD40 VA: 0x180A2E340
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0xA2D020 Offset: 0xA2BA20 VA: 0x180A2D020
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA2DC40 Offset: 0xA2C640 VA: 0x180A2DC40
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA2C510 Offset: 0xA2AF10 VA: 0x180A2C510 Slot: 96
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA2CC80 Offset: 0xA2B680 VA: 0x180A2CC80
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA2DB10 Offset: 0xA2C510 VA: 0x180A2DB10
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA2C470 Offset: 0xA2AE70 VA: 0x180A2C470 Slot: 97
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA2CC00 Offset: 0xA2B600 VA: 0x180A2CC00
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA2FF20 Offset: 0xA2E920 VA: 0x180A2FF20
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA2C150 Offset: 0xA2AB50 VA: 0x180A2C150 Slot: 98
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.OldMixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA2FFE0 Offset: 0xA2E9E0 VA: 0x180A2FFE0
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA2A650 Offset: 0xA29050 VA: 0x180A2A650 Slot: 99
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.OldMixingStation_Assembly-CSharp.dll() { }
}
