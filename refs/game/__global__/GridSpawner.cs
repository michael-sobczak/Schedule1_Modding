public class GridSpawner : NetworkBehaviour // TypeDefIndex: 18079
{
	// Fields
	[SerializeField]
	private NetworkObject _staticPrefab; // 0x118
	[SerializeField]
	private NetworkObject _movingPrefab; // 0x120
	[SerializeField]
	private int _movingCount; // 0x128
	[SerializeField]
	private byte _spacing; // 0x12C
	private bool NetworkInitialize___EarlyFishNet.Demo.HashGrid.GridSpawnerFishNet.Demos.dll_Excuted; // 0x12D
	private bool NetworkInitialize__LateFishNet.Demo.HashGrid.GridSpawnerFishNet.Demos.dll_Excuted; // 0x12E

	// Properties
	private float _range { get; }

	// Methods

	// RVA: 0xCE6E00 Offset: 0xCE5800 VA: 0x180CE6E00
	private float get__range() { }

	// RVA: 0xCE6B50 Offset: 0xCE5550 VA: 0x180CE6B50 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xCE6DE0 Offset: 0xCE57E0 VA: 0x180CE6DE0
	public void .ctor() { }

	// RVA: 0xCE4B60 Offset: 0xCE3560 VA: 0x180CE4B60 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCE6B30 Offset: 0xCE5530 VA: 0x180CE6B30 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
