public class PlayerMotor : NetworkBehaviour // TypeDefIndex: 18109
{
	// Fields
	[SerializeField]
	private float _moveRate; // 0x118
	private CharacterController _characterController; // 0x120
	private bool NetworkInitialize___EarlyFishNet.Example.ColliderRollbacks.PlayerMotorFishNet.Demos.dll_Excuted; // 0x128
	private bool NetworkInitialize__LateFishNet.Example.ColliderRollbacks.PlayerMotorFishNet.Demos.dll_Excuted; // 0x129

	// Methods

	// RVA: 0xCEAAB0 Offset: 0xCE94B0 VA: 0x180CEAAB0 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xCEAB20 Offset: 0xCE9520 VA: 0x180CEAB20
	private void Update() { }

	// RVA: 0xCEA920 Offset: 0xCE9320 VA: 0x180CEA920
	private void Move() { }

	// RVA: 0xCE8890 Offset: 0xCE7290 VA: 0x180CE8890
	public void .ctor() { }

	// RVA: 0x7A0C00 Offset: 0x79F600 VA: 0x1807A0C00 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7A0BE0 Offset: 0x79F5E0 VA: 0x1807A0BE0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
