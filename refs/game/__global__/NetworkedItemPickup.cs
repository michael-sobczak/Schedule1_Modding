public class NetworkedItemPickup : NetworkBehaviour // TypeDefIndex: 3083
{
	// Fields
	public ItemDefinition ItemToGive; // 0x118
	public bool DestroyOnPickup; // 0x120
	public bool ConditionallyActive; // 0x121
	public Condition ActiveCondition; // 0x128
	public bool Networked; // 0x130
	[Header("References")]
	public InteractableObject IntObj; // 0x138
	public UnityEvent onPickup; // 0x140
	private bool NetworkInitialize___EarlyScheduleOne.ItemFramework.NetworkedItemPickupAssembly-CSharp.dll_Excuted; // 0x148
	private bool NetworkInitialize__LateScheduleOne.ItemFramework.NetworkedItemPickupAssembly-CSharp.dll_Excuted; // 0x149

	// Methods

	// RVA: 0x9A3D30 Offset: 0x9A2730 VA: 0x1809A3D30 Slot: 19
	public override void Awake() { }

	// RVA: 0x9A49B0 Offset: 0x9A33B0 VA: 0x1809A49B0
	private void Start() { }

	// RVA: 0x9A4230 Offset: 0x9A2C30 VA: 0x1809A4230
	private void Init() { }

	// RVA: 0x9A4140 Offset: 0x9A2B40 VA: 0x1809A4140 Slot: 20
	protected virtual void Hovered() { }

	// RVA: 0x9A4420 Offset: 0x9A2E20 VA: 0x1809A4420
	private void Interacted() { }

	// RVA: 0x9A3ED0 Offset: 0x9A28D0 VA: 0x1809A3ED0 Slot: 21
	protected virtual bool CanPickup() { }

	// RVA: 0x9A4500 Offset: 0x9A2F00 VA: 0x1809A4500 Slot: 22
	protected virtual void Pickup() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9A3FD0 Offset: 0x9A29D0 VA: 0x1809A3FD0
	public void Destroy() { }

	// RVA: 0x9A4BD0 Offset: 0x9A35D0 VA: 0x1809A4BD0
	public void .ctor() { }

	[IteratorStateMachine(typeof(NetworkedItemPickup.<<Init>g__Wait|9_0>d))]
	[CompilerGenerated]
	// RVA: 0x9A4B60 Offset: 0x9A3560 VA: 0x1809A4B60
	private IEnumerator <Init>g__Wait|9_0() { }

	// RVA: 0x9A4470 Offset: 0x9A2E70 VA: 0x1809A4470 Slot: 23
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7CB0F0 Offset: 0x7C9AF0 VA: 0x1807CB0F0 Slot: 24
	public override void NetworkInitialize__Late() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9A4840 Offset: 0x9A3240 VA: 0x1809A4840
	private void RpcWriter___Server_Destroy_2166136261() { }

	// RVA: 0x9A4770 Offset: 0x9A3170 VA: 0x1809A4770
	public void RpcLogic___Destroy_2166136261() { }

	// RVA: 0x9A47F0 Offset: 0x9A31F0 VA: 0x1809A47F0
	private void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9A3BC0 Offset: 0x9A25C0 VA: 0x1809A3BC0 Slot: 25
	protected virtual void Awake_UserLogic_ScheduleOne.ItemFramework.NetworkedItemPickup_Assembly-CSharp.dll() { }
}
