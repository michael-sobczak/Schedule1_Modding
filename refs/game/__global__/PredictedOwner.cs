public class PredictedOwner : NetworkBehaviour // TypeDefIndex: 12671
{
	// Fields
	[CompilerGenerated]
	private bool <TakingOwnership>k__BackingField; // 0x118
	[CompilerGenerated]
	private NetworkConnection <PreviousOwner>k__BackingField; // 0x120
	[SyncVar(SendRate = 0)]
	[Tooltip("True if to enable this component.")]
	[SerializeField]
	public bool _allowTakeOwnership; // 0x128
	public SyncVar<bool> syncVar____allowTakeOwnership; // 0x130
	private bool NetworkInitialize___EarlyFishNet.Component.Ownership.PredictedOwnerFishNet.Runtime.dll_Excuted; // 0x138
	private bool NetworkInitialize__LateFishNet.Component.Ownership.PredictedOwnerFishNet.Runtime.dll_Excuted; // 0x139

	// Properties
	public bool TakingOwnership { get; set; }
	public NetworkConnection PreviousOwner { get; set; }
	public bool SyncAccessor__allowTakeOwnership { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_TakingOwnership() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	private void set_TakingOwnership(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public NetworkConnection get_PreviousOwner() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_PreviousOwner(NetworkConnection value) { }

	[Server]
	// RVA: 0xD53FC0 Offset: 0xD529C0 VA: 0x180D53FC0
	public void SetAllowTakeOwnership(bool value) { }

	// RVA: 0xD53BE0 Offset: 0xD525E0 VA: 0x180D53BE0 Slot: 13
	public override void OnOwnershipClient(NetworkConnection prevOwner) { }

	[Client]
	// RVA: 0xD54100 Offset: 0xD52B00 VA: 0x180D54100 Slot: 19
	public virtual void TakeOwnership() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xD53EB0 Offset: 0xD528B0 VA: 0x180D53EB0
	private void ServerTakeOwnership(NetworkConnection caller) { }

	[Server]
	// RVA: 0xD53C20 Offset: 0xD52620 VA: 0x180D53C20 Slot: 20
	protected virtual void OnTakeOwnership(NetworkConnection caller) { }

	// RVA: 0xD54330 Offset: 0xD52D30 VA: 0x180D54330
	public void .ctor() { }

	// RVA: 0xD53A40 Offset: 0xD52440 VA: 0x180D53A40 Slot: 21
	public override void NetworkInitialize___Early() { }

	// RVA: 0xD539F0 Offset: 0xD523F0 VA: 0x180D539F0 Slot: 22
	public override void NetworkInitialize__Late() { }

	// RVA: 0xD4EFD0 Offset: 0xD4D9D0 VA: 0x180D4EFD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xD53EB0 Offset: 0xD528B0 VA: 0x180D53EB0
	private void RpcWriter___Server_ServerTakeOwnership_328543758(NetworkConnection caller) { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50
	private void RpcLogic___ServerTakeOwnership_328543758(NetworkConnection caller) { }

	// RVA: 0xD53E70 Offset: 0xD52870 VA: 0x180D53E70
	private void RpcReader___Server_ServerTakeOwnership_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x67E960 Offset: 0x67D360 VA: 0x18067E960
	public bool sync___get_value__allowTakeOwnership() { }

	// RVA: 0xD543E0 Offset: 0xD52DE0 VA: 0x180D543E0
	public void sync___set_value__allowTakeOwnership(bool value, bool asServer) { }

	// RVA: 0xD53D30 Offset: 0xD52730 VA: 0x180D53D30 Slot: 23
	public override bool ReadSyncVar___FishNet.Component.Ownership.PredictedOwner(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0xD4EFD0 Offset: 0xD4D9D0 VA: 0x180D4EFD0 Slot: 24
	public override void Awake() { }
}
