public class NPCInventory : NetworkBehaviour, IItemSlotOwner // TypeDefIndex: 1644
{
	// Fields
	public InteractableObject PickpocketIntObj; // 0x118
	public const float COOLDOWN = 30;
	[Header("Settings")]
	public int SlotCount; // 0x120
	public bool CanBePickpocketed; // 0x124
	public float PickpocketDifficultyMultiplier; // 0x128
	public bool ClearInventoryEachNight; // 0x12C
	public ItemDefinition[] TestItems; // 0x130
	public ItemDefinition[] StartupItems; // 0x138
	[Header("Random cash")]
	public bool RandomCash; // 0x140
	public int RandomCashMin; // 0x144
	public int RandomCashMax; // 0x148
	[Header("Random items")]
	public bool RandomItems; // 0x14C
	public bool AllowDuplicateRandomItems; // 0x14D
	public NPCInventory.RandomInventoryItem[] RandomInventoryItems; // 0x150
	public int RandomItemMin; // 0x158
	public int RandomItemMax; // 0x15C
	private NPC npc; // 0x160
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x168
	public UnityEvent onContentsChanged; // 0x170
	private float timeOnLastExpire; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted; // 0x17C
	private bool NetworkInitialize__LateScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted; // 0x17D

	// Properties
	public List<ItemSlot> ItemSlots { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610 Slot: 19
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660 Slot: 20
	public void set_ItemSlots(List<ItemSlot> value) { }

	// RVA: 0x705180 Offset: 0x703B80 VA: 0x180705180 Slot: 30
	public override void Awake() { }

	// RVA: 0x70A330 Offset: 0x708D30 VA: 0x18070A330 Slot: 31
	protected virtual void Start() { }

	// RVA: 0x706F30 Offset: 0x705930 VA: 0x180706F30 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x706AA0 Offset: 0x7054A0 VA: 0x180706AA0
	private void OnDestroy() { }

	// RVA: 0x706C10 Offset: 0x705610 VA: 0x180706C10 Slot: 32
	protected virtual void OnSleepStart() { }

	// RVA: 0x704C90 Offset: 0x703690 VA: 0x180704C90
	public void AddRandomItemsToInventory() { }

	// RVA: 0x704BD0 Offset: 0x7035D0 VA: 0x180704BD0
	private void AddRandomCashInstance() { }

	// RVA: 0x705E40 Offset: 0x704840 VA: 0x180705E40
	private StorableItemDefinition GetRandomInventoryItem(List<string> excludeIDs) { }

	[Button]
	// RVA: 0x706080 Offset: 0x704A80 VA: 0x180706080
	public float GetTotalRandomInventoryItemWeight() { }

	// RVA: 0x705B60 Offset: 0x704560 VA: 0x180705B60
	public int GetIdenticalItemAmount(ItemInstance item) { }

	// RVA: 0x705CB0 Offset: 0x7046B0 VA: 0x180705CB0
	public int GetMaxItemCount(string[] ids) { }

	// RVA: 0x7051D0 Offset: 0x703BD0 VA: 0x1807051D0
	public bool CanItemFit(ItemInstance item) { }

	// RVA: 0x705540 Offset: 0x703F40 VA: 0x180705540
	public int GetCapacityForItem(ItemInstance item) { }

	// RVA: 0x706260 Offset: 0x704C60 VA: 0x180706260
	public void InsertItem(ItemInstance item, bool network = True) { }

	// RVA: 0x7059E0 Offset: 0x7043E0 VA: 0x1807059E0
	public ItemInstance GetFirstItem(string id, NPCInventory.ItemFilter filter) { }

	// RVA: 0x705860 Offset: 0x704260 VA: 0x180705860
	public ItemInstance GetFirstIdenticalItem(ItemInstance item, NPCInventory.ItemFilter filter) { }

	// RVA: 0x7066E0 Offset: 0x7050E0 VA: 0x1807066E0 Slot: 33
	protected virtual void InventoryContentsChanged() { }

	// RVA: 0x7061A0 Offset: 0x704BA0 VA: 0x1807061A0
	public void Hovered() { }

	// RVA: 0x706640 Offset: 0x705040 VA: 0x180706640
	public void Interacted() { }

	// RVA: 0x70A2A0 Offset: 0x708CA0 VA: 0x18070A2A0
	private void StartPickpocket() { }

	// RVA: 0x705520 Offset: 0x703F20 VA: 0x180705520
	public void ExpirePickpocket() { }

	// RVA: 0x705200 Offset: 0x703C00 VA: 0x180705200
	private bool CanPickpocket() { }

	[Button]
	// RVA: 0x7070B0 Offset: 0x705AB0 VA: 0x1807070B0
	public void PrintInventoryContents() { }

	// RVA: 0x705470 Offset: 0x703E70 VA: 0x180705470
	public void Clear() { }

	// RVA: 0x705770 Offset: 0x704170 VA: 0x180705770
	public float GetCashInInventory() { }

	// RVA: 0x707340 Offset: 0x705D40 VA: 0x180707340
	public void RemoveCash(float amountToRemove) { }

	// RVA: 0x704AC0 Offset: 0x7034C0 VA: 0x180704AC0
	public void AddCash(float amountToAdd) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x70A100 Offset: 0x708B00 VA: 0x18070A100 Slot: 21
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x709E40 Offset: 0x708840 VA: 0x180709E40
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x709360 Offset: 0x707D60 VA: 0x180709360 Slot: 22
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7091B0 Offset: 0x707BB0 VA: 0x1807091B0
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x709C50 Offset: 0x708650 VA: 0x180709C50 Slot: 23
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x709930 Offset: 0x708330 VA: 0x180709930
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x709790 Offset: 0x708190 VA: 0x180709790 Slot: 24
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x7094D0 Offset: 0x707ED0 VA: 0x1807094D0
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x70A580 Offset: 0x708F80 VA: 0x18070A580
	public void .ctor() { }

	// RVA: 0x706760 Offset: 0x705160 VA: 0x180706760 Slot: 34
	public override void NetworkInitialize___Early() { }

	// RVA: 0x706740 Offset: 0x705140 VA: 0x180706740 Slot: 35
	public override void NetworkInitialize__Late() { }

	// RVA: 0x706700 Offset: 0x705100 VA: 0x180706700 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x708BD0 Offset: 0x7075D0 VA: 0x180708BD0
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x707750 Offset: 0x706150 VA: 0x180707750 Slot: 36
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x707E30 Offset: 0x706830 VA: 0x180707E30
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7085D0 Offset: 0x706FD0 VA: 0x1807085D0
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x7077D0 Offset: 0x7061D0 VA: 0x1807077D0
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x707AB0 Offset: 0x7064B0 VA: 0x180707AB0
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x709040 Offset: 0x707A40 VA: 0x180709040
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x7080A0 Offset: 0x706AA0 VA: 0x1807080A0
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x708750 Offset: 0x707150 VA: 0x180708750
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x707490 Offset: 0x705E90 VA: 0x180707490 Slot: 37
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x707B40 Offset: 0x706540 VA: 0x180707B40
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x708130 Offset: 0x706B30 VA: 0x180708130
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x7074A0 Offset: 0x705EA0 VA: 0x1807074A0
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x707890 Offset: 0x706290 VA: 0x180707890
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x708A40 Offset: 0x707440 VA: 0x180708A40
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x707620 Offset: 0x706020 VA: 0x180707620 Slot: 38
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x707CE0 Offset: 0x7066E0 VA: 0x180707CE0
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x708EB0 Offset: 0x7078B0 VA: 0x180708EB0
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x7076A0 Offset: 0x7060A0 VA: 0x1807076A0
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x707FB0 Offset: 0x7069B0 VA: 0x180707FB0
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x708430 Offset: 0x706E30 VA: 0x180708430
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x7079C0 Offset: 0x7063C0 VA: 0x1807079C0
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7088D0 Offset: 0x7072D0 VA: 0x1807088D0
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x707520 Offset: 0x705F20 VA: 0x180707520 Slot: 39
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x707BF0 Offset: 0x7065F0 VA: 0x180707BF0
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7082B0 Offset: 0x706CB0 VA: 0x1807082B0
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x7075A0 Offset: 0x705FA0 VA: 0x1807075A0
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x707930 Offset: 0x706330 VA: 0x180707930
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x708D40 Offset: 0x707740 VA: 0x180708D40
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x707F20 Offset: 0x706920 VA: 0x180707F20
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x704E40 Offset: 0x703840 VA: 0x180704E40 Slot: 40
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCInventory_Assembly-CSharp.dll() { }
}
