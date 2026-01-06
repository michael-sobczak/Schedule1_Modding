public class PlayerController : NetworkBehaviour // TypeDefIndex: 18084
{
	// Fields
	[SerializeField]
	private GameObject _camera; // 0x118
	[SerializeField]
	private float _moveRate; // 0x120
	[SerializeField]
	private bool _clientAuth; // 0x124
	private bool NetworkInitialize___EarlyFishNet.Example.Scened.PlayerControllerFishNet.Demos.dll_Excuted; // 0x125
	private bool NetworkInitialize__LateFishNet.Example.Scened.PlayerControllerFishNet.Demos.dll_Excuted; // 0x126

	// Methods

	// RVA: 0xCEA310 Offset: 0xCE8D10 VA: 0x180CEA310 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xCEA5F0 Offset: 0xCE8FF0 VA: 0x180CEA5F0
	private void Update() { }

	[ServerRpc]
	// RVA: 0xCEA5E0 Offset: 0xCE8FE0 VA: 0x180CEA5E0
	private void ServerMove(float hor, float ver) { }

	// RVA: 0xCE9F20 Offset: 0xCE8920 VA: 0x180CE9F20
	private void Move(float hor, float ver) { }

	// RVA: 0xCEA900 Offset: 0xCE9300 VA: 0x180CEA900
	public void .ctor() { }

	// RVA: 0xCEA280 Offset: 0xCE8C80 VA: 0x180CEA280 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCEA260 Offset: 0xCE8C60 VA: 0x180CEA260 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xCEA3F0 Offset: 0xCE8DF0 VA: 0x180CEA3F0
	private void RpcWriter___Server_ServerMove_1138564871(float hor, float ver) { }

	// RVA: 0xCEA350 Offset: 0xCE8D50 VA: 0x180CEA350
	private void RpcLogic___ServerMove_1138564871(float hor, float ver) { }

	// RVA: 0xCEA360 Offset: 0xCE8D60 VA: 0x180CEA360
	private void RpcReader___Server_ServerMove_1138564871(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
