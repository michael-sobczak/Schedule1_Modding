public class MoveRandomly : NetworkBehaviour // TypeDefIndex: 18080
{
	// Fields
	[SerializeField]
	private Renderer _renderer; // 0x118
	private float _moveRate; // 0x120
	public const float Range = 25;
	private Vector3 _goal; // 0x124
	private Vector3 _start; // 0x130
	private bool NetworkInitialize___EarlyFishNet.Demo.HashGrid.MoveRandomlyFishNet.Demos.dll_Excuted; // 0x13C
	private bool NetworkInitialize__LateFishNet.Demo.HashGrid.MoveRandomlyFishNet.Demos.dll_Excuted; // 0x13D

	// Methods

	// RVA: 0xCE8580 Offset: 0xCE6F80 VA: 0x180CE8580
	private void Update() { }

	// RVA: 0xCE7CC0 Offset: 0xCE66C0 VA: 0x180CE7CC0 Slot: 4
	public override void OnStartNetwork() { }

	// RVA: 0xCE7FA0 Offset: 0xCE69A0 VA: 0x180CE7FA0 Slot: 5
	public override void OnStopNetwork() { }

	// RVA: 0xCE8260 Offset: 0xCE6C60 VA: 0x180CE8260
	private void RandomizeGoal() { }

	// RVA: 0xCE8050 Offset: 0xCE6A50 VA: 0x180CE8050
	private Vector3 RandomInsideRange() { }

	// RVA: 0xCE8870 Offset: 0xCE7270 VA: 0x180CE8870
	public void .ctor() { }

	// RVA: 0xCE7AE0 Offset: 0xCE64E0 VA: 0x180CE7AE0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCE7AA0 Offset: 0xCE64A0 VA: 0x180CE7AA0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
