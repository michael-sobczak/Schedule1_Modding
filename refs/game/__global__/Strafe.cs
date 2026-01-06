public class Strafe : NetworkBehaviour // TypeDefIndex: 18112
{
	// Fields
	public float MoveRate; // 0x118
	public float MoveDistance; // 0x11C
	private bool _movingRight; // 0x120
	private float _startX; // 0x124
	private bool NetworkInitialize___EarlyFishNet.Example.ColliderRollbacks.StrafeFishNet.Demos.dll_Excuted; // 0x128
	private bool NetworkInitialize__LateFishNet.Example.ColliderRollbacks.StrafeFishNet.Demos.dll_Excuted; // 0x129

	// Methods

	// RVA: 0xCEF2C0 Offset: 0xCEDCC0 VA: 0x180CEF2C0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xCEF300 Offset: 0xCEDD00 VA: 0x180CEF300
	private void Update() { }

	// RVA: 0xCEF650 Offset: 0xCEE050 VA: 0x180CEF650
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
