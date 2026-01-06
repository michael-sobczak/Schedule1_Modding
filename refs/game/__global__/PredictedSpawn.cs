public class PredictedSpawn : NetworkBehaviour // TypeDefIndex: 12672
{
	// Fields
	[Tooltip("True to allow clients to predicted spawn this object.")]
	[SerializeField]
	private bool _allowSpawning; // 0x118
	[SerializeField]
	[Tooltip("True to allow clients to predicted despawn this object.")]
	private bool _allowDespawning; // 0x119
	[SerializeField]
	[Tooltip("True to allow clients to predicted set syncTypes prior to spawning the item. Set values will be applied on the server and sent to other clients.")]
	private bool _allowSyncTypes; // 0x11A
	private bool NetworkInitialize___EarlyFishNet.Component.Ownership.PredictedSpawnFishNet.Runtime.dll_Excuted; // 0x11B
	private bool NetworkInitialize__LateFishNet.Component.Ownership.PredictedSpawnFishNet.Runtime.dll_Excuted; // 0x11C

	// Methods

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool GetAllowSpawning() { }

	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	public void SetAllowSpawning(bool value) { }

	// RVA: 0x732530 Offset: 0x730F30 VA: 0x180732530
	public bool GetAllowDespawning() { }

	// RVA: 0x732580 Offset: 0x730F80 VA: 0x180732580
	public void SetAllowDespawning(bool value) { }

	// RVA: 0xD544A0 Offset: 0xD52EA0 VA: 0x180D544A0
	public bool GetAllowSyncTypes() { }

	// RVA: 0xD544F0 Offset: 0xD52EF0 VA: 0x180D544F0
	public void SetAllowSyncTypes(bool value) { }

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980 Slot: 19
	public virtual bool OnTrySpawnClient(NetworkConnection owner) { }

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980 Slot: 20
	public virtual bool OnTrySpawnServer(NetworkConnection spawner, NetworkConnection owner) { }

	// RVA: 0x732530 Offset: 0x730F30 VA: 0x180732530 Slot: 21
	public virtual bool OnTryDespawnClient() { }

	// RVA: 0x732530 Offset: 0x730F30 VA: 0x180732530 Slot: 22
	public virtual bool OnTryDepawnServer(NetworkConnection despawner) { }

	// RVA: 0xD54500 Offset: 0xD52F00 VA: 0x180D54500
	public void .ctor() { }

	// RVA: 0xD544D0 Offset: 0xD52ED0 VA: 0x180D544D0 Slot: 23
	public override void NetworkInitialize___Early() { }

	// RVA: 0xD544B0 Offset: 0xD52EB0 VA: 0x180D544B0 Slot: 24
	public override void NetworkInitialize__Late() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 25
	public override void Awake() { }
}
