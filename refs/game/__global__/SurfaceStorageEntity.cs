public class SurfaceStorageEntity : SurfaceItem, IUsable // TypeDefIndex: 3284
{
	// Fields
	[Header("Reference")]
	public StorageEntity StorageEntity; // 0x208
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	[HideInInspector]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x210
	[SyncVar(WritePermissions = 1)]
	[HideInInspector]
	[CompilerGenerated]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x218
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x220
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x221
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x228
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x230
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted; // 0x238
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted; // 0x239

	// Properties
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80 Slot: 70
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA46BC0 Offset: 0xA455C0 VA: 0x180A46BC0 Slot: 71
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70 Slot: 72
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0xA46C60 Offset: 0xA45660 VA: 0x180A46C60 Slot: 73
	public void set_PlayerUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0xA472E0 Offset: 0xA45CE0 VA: 0x180A472E0
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0xA472D0 Offset: 0xA45CD0 VA: 0x180A472D0
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0xA472F0 Offset: 0xA45CF0 VA: 0x180A472F0
	public void set_IsAcceptingItems(bool value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA47190 Offset: 0xA45B90 VA: 0x180A47190 Slot: 76
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA47060 Offset: 0xA45A60 VA: 0x180A47060 Slot: 77
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0xA464E0 Offset: 0xA44EE0 VA: 0x180A464E0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0xA465E0 Offset: 0xA44FE0 VA: 0x180A465E0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA472C0 Offset: 0xA45CC0 VA: 0x180A472C0
	public void .ctor() { }

	// RVA: 0xA46800 Offset: 0xA45200 VA: 0x180A46800 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA46790 Offset: 0xA45190 VA: 0x180A46790 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA46F30 Offset: 0xA45930 VA: 0x180A46F30
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA46C60 Offset: 0xA45660 VA: 0x180A46C60 Slot: 78
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0xA46D80 Offset: 0xA45780 VA: 0x180A46D80
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA46E00 Offset: 0xA45800 VA: 0x180A46E00
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA46BC0 Offset: 0xA455C0 VA: 0x180A46BC0 Slot: 79
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0xA46D00 Offset: 0xA45700 VA: 0x180A46D00
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0xA47300 Offset: 0xA45D00 VA: 0x180A47300
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA46A90 Offset: 0xA45490 VA: 0x180A46A90 Slot: 80
	public override bool ReadSyncVar___ScheduleOne.ObjectScripts.SurfaceStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0xA473C0 Offset: 0xA45DC0 VA: 0x180A473C0
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0xA46490 Offset: 0xA44E90 VA: 0x180A46490 Slot: 47
	public override void Awake() { }
}
