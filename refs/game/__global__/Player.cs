public class Player : NetworkBehaviour // TypeDefIndex: 18074
{
	// Fields
	[SerializeField]
	private Transform _ownerObjects; // 0x118
	[SerializeField]
	private float _moveRate; // 0x120
	private List<Waypoint> _wayPoints; // 0x128
	private int _goalIndex; // 0x130
	private Vector3 _goalOffset; // 0x134
	private bool NetworkInitialize___EarlyFishNet.Demo.AdditiveScenes.PlayerFishNet.Demos.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateFishNet.Demo.AdditiveScenes.PlayerFishNet.Demos.dll_Excuted; // 0x141

	// Methods

	// RVA: 0xCEAD10 Offset: 0xCE9710 VA: 0x180CEAD10 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xCEACC0 Offset: 0xCE96C0 VA: 0x180CEACC0 Slot: 13
	public override void OnOwnershipClient(NetworkConnection prevOwner) { }

	// RVA: 0xCEB0D0 Offset: 0xCE9AD0 VA: 0x180CEB0D0
	private void Update() { }

	// RVA: 0xCEB5A0 Offset: 0xCE9FA0 VA: 0x180CEB5A0
	public void .ctor() { }

	// RVA: 0x7C9EC0 Offset: 0x7C88C0 VA: 0x1807C9EC0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7C9EA0 Offset: 0x7C88A0 VA: 0x1807C9EA0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
