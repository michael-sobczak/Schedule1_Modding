public class NetworkLodTester : NetworkBehaviour // TypeDefIndex: 18078
{
	// Fields
	[Header("General")]
	[SerializeField]
	private NetworkObject _prefab; // 0x118
	[SerializeField]
	private ObserverManager _observerManager; // 0x120
	[Range(1, 8)]
	[SerializeField]
	private byte _lodLevel; // 0x128
	[Header("Spawning")]
	[SerializeField]
	private int _count; // 0x12C
	[SerializeField]
	private float _xyRange; // 0x130
	[SerializeField]
	private float _zRange; // 0x134
	private bool NetworkInitialize___EarlyFishNet.Demo.NetworkLod.NetworkLodTesterFishNet.Demos.dll_Excuted; // 0x138
	private bool NetworkInitialize__LateFishNet.Demo.NetworkLod.NetworkLodTesterFishNet.Demos.dll_Excuted; // 0x139

	// Methods

	// RVA: 0xCE94F0 Offset: 0xCE7EF0 VA: 0x180CE94F0 Slot: 19
	public override void Awake() { }

	// RVA: 0xCE95E0 Offset: 0xCE7FE0 VA: 0x180CE95E0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xCE9760 Offset: 0xCE8160 VA: 0x180CE9760
	public void .ctor() { }

	// RVA: 0xCE95C0 Offset: 0xCE7FC0 VA: 0x180CE95C0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x64BFE0 Offset: 0x64A9E0 VA: 0x18064BFE0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xCE9450 Offset: 0xCE7E50 VA: 0x180CE9450
	private void Awake_UserLogic_FishNet.Demo.NetworkLod.NetworkLodTester_FishNet.Demos.dll() { }
}
