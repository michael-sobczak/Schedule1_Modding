public class PredictedBullet : NetworkBehaviour // TypeDefIndex: 18089
{
	// Fields
	[HideInInspector]
	[SyncVar(OnChange = "_startingForce_OnChange")]
	public Vector3 _startingForce; // 0x118
	private uint _stopTick; // 0x124
	public SyncVar<Vector3> syncVar____startingForce; // 0x128
	private bool NetworkInitialize___EarlyFishNet.Example.Prediction.Rigidbodies.PredictedBulletFishNet.Demos.dll_Excuted; // 0x130
	private bool NetworkInitialize__LateFishNet.Example.Prediction.Rigidbodies.PredictedBulletFishNet.Demos.dll_Excuted; // 0x131

	// Properties
	public Vector3 SyncAccessor__startingForce { get; set; }

	// Methods

	// RVA: 0xCEBED0 Offset: 0xCEA8D0 VA: 0x180CEBED0
	public void SetStartingForce(Vector3 value) { }

	// RVA: 0xCEBAE0 Offset: 0xCEA4E0 VA: 0x180CEBAE0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xCEB870 Offset: 0xCEA270 VA: 0x180CEB870 Slot: 4
	public override void OnStartNetwork() { }

	// RVA: 0xCEBCA0 Offset: 0xCEA6A0 VA: 0x180CEBCA0 Slot: 5
	public override void OnStopNetwork() { }

	// RVA: 0xCEC0A0 Offset: 0xCEAAA0 VA: 0x180CEC0A0
	private void TimeManager_OnTick() { }

	// RVA: 0xCEC1B0 Offset: 0xCEABB0 VA: 0x180CEC1B0
	private void _startingForce_OnChange(Vector3 prev, Vector3 next, bool asServer) { }

	// RVA: 0xCEBF80 Offset: 0xCEA980 VA: 0x180CEBF80
	public void SetVelocity(Vector3 value) { }

	[IteratorStateMachine(typeof(PredictedBullet.<__DelayDestroy>d__9))]
	// RVA: 0xCEC130 Offset: 0xCEAB30 VA: 0x180CEC130
	private IEnumerator __DelayDestroy(float time) { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	// RVA: 0xCEB680 Offset: 0xCEA080 VA: 0x180CEB680 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCEB630 Offset: 0xCEA030 VA: 0x180CEB630 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xCEC1E0 Offset: 0xCEABE0 VA: 0x180CEC1E0
	public Vector3 sync___get_value__startingForce() { }

	// RVA: 0xCEC200 Offset: 0xCEAC00 VA: 0x180CEC200
	public void sync___set_value__startingForce(Vector3 value, bool asServer) { }

	// RVA: 0xCEBD40 Offset: 0xCEA740 VA: 0x180CEBD40 Slot: 21
	public override bool ReadSyncVar___FishNet.Example.Prediction.Rigidbodies.PredictedBullet(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 22
	public override void Awake() { }
}
