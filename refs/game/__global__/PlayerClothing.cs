public class PlayerClothing : NetworkBehaviour, IItemSlotOwner // TypeDefIndex: 1338
{
	// Fields
	public Player Player; // 0x118
	[CompilerGenerated]
	private List<ItemSlot> <ItemSlots>k__BackingField; // 0x120
	public Dictionary<EClothingSlot, ItemSlot> ClothingSlots; // 0x128
	private List<ClothingInstance> appliedClothing; // 0x130
	private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted; // 0x138
	private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted; // 0x139

	// Properties
	public List<ItemSlot> ItemSlots { get; set; }
	private AvatarSettings appearanceSettings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0 Slot: 19
	public List<ItemSlot> get_ItemSlots() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640 Slot: 20
	public void set_ItemSlots(List<ItemSlot> value) { }

	// RVA: 0x64FB30 Offset: 0x64E530 VA: 0x18064FB30
	private AvatarSettings get_appearanceSettings() { }

	// RVA: 0x64BA10 Offset: 0x64A410 VA: 0x18064BA10 Slot: 30
	public override void Awake() { }

	// RVA: 0x64C340 Offset: 0x64AD40 VA: 0x18064C340 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x64BA80 Offset: 0x64A480 VA: 0x18064BA80
	public void InsertClothing(ClothingInstance clothing) { }

	// RVA: 0x64BA60 Offset: 0x64A460 VA: 0x18064BA60 Slot: 31
	protected virtual void ClothingChanged() { }

	// RVA: 0x64C420 Offset: 0x64AE20 VA: 0x18064C420 Slot: 32
	public virtual void RefreshAppearance() { }

	// RVA: 0x64F750 Offset: 0x64E150 VA: 0x18064F750
	private bool TryGetInventoryClothing(string assetPath, Color color, out ClothingInstance clothing) { }

	// RVA: 0x64BC50 Offset: 0x64A650 VA: 0x18064BC50
	private bool IsClothingApplied(AvatarSettings settings, ClothingInstance clothing) { }

	// RVA: 0x64B310 Offset: 0x649D10 VA: 0x18064B310
	private void ApplyClothing(AvatarSettings settings, ClothingInstance clothing) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x64F5B0 Offset: 0x64DFB0 VA: 0x18064F5B0 Slot: 21
	public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x64F2F0 Offset: 0x64DCF0 VA: 0x18064F2F0
	private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x64E810 Offset: 0x64D210 VA: 0x18064E810 Slot: 22
	public void SetItemSlotQuantity(int itemSlotIndex, int quantity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x64E660 Offset: 0x64D060 VA: 0x18064E660
	private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x64F100 Offset: 0x64DB00 VA: 0x18064F100 Slot: 23
	public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x64EDE0 Offset: 0x64D7E0 VA: 0x18064EDE0
	private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x64EC40 Offset: 0x64D640 VA: 0x18064EC40 Slot: 24
	public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x64E980 Offset: 0x64D380 VA: 0x18064E980
	private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x64FA10 Offset: 0x64E410 VA: 0x18064FA10
	public void .ctor() { }

	// RVA: 0x64C000 Offset: 0x64AA00 VA: 0x18064C000 Slot: 33
	public override void NetworkInitialize___Early() { }

	// RVA: 0x64BFE0 Offset: 0x64A9E0 VA: 0x18064BFE0 Slot: 34
	public override void NetworkInitialize__Late() { }

	// RVA: 0x64BFA0 Offset: 0x64A9A0 VA: 0x18064BFA0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x64E080 Offset: 0x64CA80 VA: 0x18064E080
	private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x64CC00 Offset: 0x64B600 VA: 0x18064CC00 Slot: 35
	public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x64D2E0 Offset: 0x64BCE0 VA: 0x18064D2E0
	private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x64DA80 Offset: 0x64C480 VA: 0x18064DA80
	private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x64CC80 Offset: 0x64B680 VA: 0x18064CC80
	private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x64CF60 Offset: 0x64B960 VA: 0x18064CF60
	private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64E4F0 Offset: 0x64CEF0 VA: 0x18064E4F0
	private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance) { }

	// RVA: 0x64D550 Offset: 0x64BF50 VA: 0x18064D550
	private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64DC00 Offset: 0x64C600 VA: 0x18064DC00
	private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x64C940 Offset: 0x64B340 VA: 0x18064C940 Slot: 36
	public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x64CFF0 Offset: 0x64B9F0 VA: 0x18064CFF0
	private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x64D5E0 Offset: 0x64BFE0 VA: 0x18064D5E0
	private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x64C950 Offset: 0x64B350 VA: 0x18064C950
	private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity) { }

	// RVA: 0x64CD40 Offset: 0x64B740 VA: 0x18064CD40
	private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64DEF0 Offset: 0x64C8F0 VA: 0x18064DEF0
	private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x64CAD0 Offset: 0x64B4D0 VA: 0x18064CAD0 Slot: 37
	public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x64D190 Offset: 0x64BB90 VA: 0x18064D190
	private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x64E360 Offset: 0x64CD60 VA: 0x18064E360
	private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x64CB50 Offset: 0x64B550 VA: 0x18064CB50
	private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x64D460 Offset: 0x64BE60 VA: 0x18064D460
	private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64D8E0 Offset: 0x64C2E0 VA: 0x18064D8E0
	private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason) { }

	// RVA: 0x64CE70 Offset: 0x64B870 VA: 0x18064CE70
	private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64DD80 Offset: 0x64C780 VA: 0x18064DD80
	private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x64C9D0 Offset: 0x64B3D0 VA: 0x18064C9D0 Slot: 38
	public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x64D0A0 Offset: 0x64BAA0 VA: 0x18064D0A0
	private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x64D760 Offset: 0x64C160 VA: 0x18064D760
	private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x64CA50 Offset: 0x64B450 VA: 0x18064CA50
	private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x64CDE0 Offset: 0x64B7E0 VA: 0x18064CDE0
	private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64E1F0 Offset: 0x64CBF0 VA: 0x18064E1F0
	private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter) { }

	// RVA: 0x64D3D0 Offset: 0x64BDD0 VA: 0x18064D3D0
	private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x64B640 Offset: 0x64A040 VA: 0x18064B640 Slot: 39
	protected virtual void Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerClothing_Assembly-CSharp.dll() { }
}
