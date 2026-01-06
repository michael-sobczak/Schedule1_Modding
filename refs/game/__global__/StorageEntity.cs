public class StorageEntity : NetworkBehaviour, IItemSlotOwner // TypeDefIndex: 2395
{
	// Fields
	public const int MAX_SLOTS = 20;
	[CompilerGenerated]
	private Player <CurrentPlayerAccessor>k__BackingField; // 0x118
	[Header("Settings")]
	public string StorageEntityName; // 0x120
	public string StorageEntitySubtitle; // 0x128
	[Range(1, 20)]
	public int SlotCount; // 0x130
	public bool EmptyOnSleep; // 0x134
	public bool SlotsAreFilterable; // 0x135
	[Header("Display Settings")]
	[Tooltip("How many rows to enforce when display contents in StorageMenu")]
	[Range(1, 5)]
	public int DisplayRowCount; // 0x138
	[Header("Access Settings")]
	public StorageEntity.EAccessSettings AccessSettings; // 0x13C
	[Tooltip("If the distance between this StorageEntity and the player is greater than this, the StorageMenu will be closed.")]
	[Range(0, 10)]
	public float MaxAccessDistance; // 0x140
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x148
	public Action onOpened; // 0x150
	public Action onClosed; // 0x158
	public Action onContentsChanged; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted; // 0x169

	// Properties
	public bool IsOpened { get; }
	public Player CurrentPlayerAccessor { get; set; }
	public int ItemCount { get; }
	public List<ItemSlot> ItemSlots { get; set; }

	// Methods

	// RVA: 0x886150 Offset: 0x884B50 VA: 0x180886150
	public bool get_IsOpened() { }

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Player get_CurrentPlayerAccessor() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	protected void set_CurrentPlayerAccessor(Player value) { }

	// RVA: 0x8861B0 Offset: 0x884BB0 VA: 0x1808861B0
	public int get_ItemCount() { }

	[CompilerGenerated]
	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80 Slot: 19
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x79A930 Offset: 0x799330 VA: 0x18079A930 Slot: 20
	public void set_ItemSlots(List<ItemSlot> value) { }

	// RVA: 0x880D60 Offset: 0x87F760 VA: 0x180880D60 Slot: 30
	public override void Awake() { }

	// RVA: 0x885D00 Offset: 0x884700 VA: 0x180885D00 Slot: 31
	protected virtual void Start() { }

	// RVA: 0x882170 Offset: 0x880B70 VA: 0x180882170 Slot: 32
	protected virtual void OnDestroy() { }

	// RVA: 0x8816A0 Offset: 0x8800A0 VA: 0x1808816A0
	private void GetNetworth(MoneyManager.FloatContainer container) { }

	// RVA: 0x882460 Offset: 0x880E60 VA: 0x180882460 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[IteratorStateMachine(typeof(StorageEntity.<UpdateWhileOpen>d__30))]
	// RVA: 0x885FD0 Offset: 0x8849D0 VA: 0x180885FD0
	private IEnumerator UpdateWhileOpen() { }

	// RVA: 0x881390 Offset: 0x87FD90 VA: 0x180881390
	public Dictionary<StorableItemInstance, int> GetContentsDictionary() { }

	// RVA: 0x881000 Offset: 0x87FA00 VA: 0x180881000
	public bool CanItemFit(ItemInstance item, int quantity = 1) { }

	// RVA: 0x8817A0 Offset: 0x8801A0 VA: 0x1808817A0
	public int HowManyCanFit(ItemInstance item) { }

	// RVA: 0x8819A0 Offset: 0x8803A0 VA: 0x1808819A0
	public void InsertItem(ItemInstance item, bool network = True) { }

	// RVA: 0x881240 Offset: 0x87FC40 VA: 0x180881240 Slot: 33
	protected virtual void ContentsChanged() { }

	// RVA: 0x881270 Offset: 0x87FC70 VA: 0x180881270
	public List<ItemInstance> GetAllItems() { }

	// RVA: 0x881C90 Offset: 0x880690 VA: 0x180881C90
	public void LoadFromItemSet(ItemInstance[] items) { }

	// RVA: 0x881020 Offset: 0x87FA20 VA: 0x180881020
	public void ClearContents() { }

	// RVA: 0x882580 Offset: 0x880F80 VA: 0x180882580
	public void Open() { }

	// RVA: 0x8810D0 Offset: 0x87FAD0 VA: 0x1808810D0
	public void Close() { }

	// RVA: 0x882430 Offset: 0x880E30 VA: 0x180882430 Slot: 34
	protected virtual void OnOpened() { }

	// RVA: 0x882140 Offset: 0x880B40 VA: 0x180882140 Slot: 35
	protected virtual void OnClosed() { }

	// RVA: 0x880F20 Offset: 0x87F920 VA: 0x180880F20 Slot: 36
	public virtual bool CanBeOpened() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x884AE0 Offset: 0x8834E0 VA: 0x180884AE0
	private void SendAccessor(NetworkObject accessor) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8826C0 Offset: 0x8810C0 VA: 0x1808826C0
	private void SetAccessor(NetworkObject accessor) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x885B60 Offset: 0x884560 VA: 0x180885B60 Slot: 21
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8858A0 Offset: 0x8842A0 VA: 0x1808858A0
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x884DC0 Offset: 0x8837C0 VA: 0x180884DC0 Slot: 22
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x884C10 Offset: 0x883610 VA: 0x180884C10
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x8856B0 Offset: 0x8840B0 VA: 0x1808856B0 Slot: 23
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x885390 Offset: 0x883D90 VA: 0x180885390
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x8851F0 Offset: 0x883BF0 VA: 0x1808851F0 Slot: 24
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x884F30 Offset: 0x883930 VA: 0x180884F30
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x886040 Offset: 0x884A40 VA: 0x180886040
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x885F80 Offset: 0x884980 VA: 0x180885F80
	private void <OnSpawnServer>g__ReplicateInventory|29_0(NetworkConnection conn) { }

	// RVA: 0x881D80 Offset: 0x880780 VA: 0x180881D80 Slot: 37
	public override void NetworkInitialize___Early() { }

	// RVA: 0x881D60 Offset: 0x880760 VA: 0x180881D60 Slot: 38
	public override void NetworkInitialize__Late() { }

	// RVA: 0x870DC0 Offset: 0x86F7C0 VA: 0x180870DC0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x883F50 Offset: 0x882950 VA: 0x180883F50
	private void RpcWriter___Server_SendAccessor_3323014238(NetworkObject accessor) { }

	// RVA: 0x8826C0 Offset: 0x8810C0 VA: 0x1808826C0
	private void RpcLogic___SendAccessor_3323014238(NetworkObject accessor) { }

	// RVA: 0x883180 Offset: 0x881B80 VA: 0x180883180
	private void RpcReader___Server_SendAccessor_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8837F0 Offset: 0x8821F0 VA: 0x1808837F0
	private void RpcWriter___Observers_SetAccessor_3323014238(NetworkObject accessor) { }

	// RVA: 0x882800 Offset: 0x881200 VA: 0x180882800
	private void RpcLogic___SetAccessor_3323014238(NetworkObject accessor) { }

	// RVA: 0x882E60 Offset: 0x881860 VA: 0x180882E60
	private void RpcReader___Observers_SetAccessor_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x884500 Offset: 0x882F00 VA: 0x180884500
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x882D20 Offset: 0x881720 VA: 0x180882D20 Slot: 39
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x8834F0 Offset: 0x881EF0 VA: 0x1808834F0
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x883DD0 Offset: 0x8827D0 VA: 0x180883DD0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x882DA0 Offset: 0x8817A0 VA: 0x180882DA0
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x8830F0 Offset: 0x881AF0 VA: 0x1808830F0
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x884970 Offset: 0x883370 VA: 0x180884970
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x883760 Offset: 0x882160 VA: 0x180883760
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x884080 Offset: 0x882A80 VA: 0x180884080
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x882A60 Offset: 0x881460 VA: 0x180882A60 Slot: 40
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x883200 Offset: 0x881C00 VA: 0x180883200
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x883930 Offset: 0x882330 VA: 0x180883930
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x882A70 Offset: 0x881470 VA: 0x180882A70
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x882ED0 Offset: 0x8818D0 VA: 0x180882ED0
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x884370 Offset: 0x882D70 VA: 0x180884370
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x882BF0 Offset: 0x8815F0 VA: 0x180882BF0 Slot: 41
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x8833A0 Offset: 0x881DA0 VA: 0x1808833A0
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8847E0 Offset: 0x8831E0 VA: 0x1808847E0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x882C70 Offset: 0x881670 VA: 0x180882C70
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x883670 Offset: 0x882070 VA: 0x180883670
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x883C30 Offset: 0x882630 VA: 0x180883C30
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x883000 Offset: 0x881A00 VA: 0x180883000
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x884200 Offset: 0x882C00 VA: 0x180884200
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x882AF0 Offset: 0x8814F0 VA: 0x180882AF0 Slot: 42
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x8832B0 Offset: 0x881CB0 VA: 0x1808832B0
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x883AB0 Offset: 0x8824B0 VA: 0x180883AB0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x882B70 Offset: 0x881570 VA: 0x180882B70
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x882F70 Offset: 0x881970 VA: 0x180882F70
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x884670 Offset: 0x883070 VA: 0x180884670
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x8835E0 Offset: 0x881FE0 VA: 0x1808835E0
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x880BC0 Offset: 0x87F5C0 VA: 0x180880BC0 Slot: 43
	protected virtual void Awake_UserLogic_ScheduleOne.Storage.StorageEntity_Assembly-CSharp.dll() { }
}
