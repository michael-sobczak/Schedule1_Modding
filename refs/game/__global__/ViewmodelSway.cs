public class ViewmodelSway : PlayerSingleton<ViewmodelSway> // TypeDefIndex: 1358
{
	// Fields
	public bool DEBUG; // 0x20
	[Header("Settings - Breathing")]
	public bool breatheBobbingEnabled; // 0x21
	[SerializeField]
	[Range(0, 0.0004)]
	protected float breathingHeightMultiplier; // 0x24
	[SerializeField]
	[Range(0, 10)]
	protected float breathingSpeedMultiplier; // 0x28
	private float lastHeight; // 0x2C
	private Vector3 breatheBobPos; // 0x30
	[Header("Settings - Sway - Movement")]
	public bool swayingEnabled; // 0x3C
	[SerializeField]
	[Range(0, 0.1)]
	protected float horizontalSwayMultiplier; // 0x40
	[Range(0, 0.1)]
	[SerializeField]
	protected float verticalSwayMultiplier; // 0x44
	[Range(0, 0.5)]
	[SerializeField]
	protected float maxHorizontal; // 0x48
	[SerializeField]
	[Range(0, 0.5)]
	protected float maxVertical; // 0x4C
	[SerializeField]
	protected float swaySmooth; // 0x50
	[SerializeField]
	protected float returnMultiplier; // 0x54
	private Vector3 initialPos; // 0x58
	private Vector3 swayPos; // 0x64
	[Header("Settings - Walk Bob")]
	public bool walkBobbingEnabled; // 0x70
	[SerializeField]
	protected AnimationCurve verticalMovement; // 0x78
	[SerializeField]
	protected AnimationCurve horizontalMovement; // 0x80
	[Range(0, 0.1)]
	[SerializeField]
	protected float verticalBobHeight; // 0x88
	[SerializeField]
	[Range(0, 5)]
	protected float verticalBobSpeed; // 0x8C
	[Range(0, 0.1)]
	[SerializeField]
	protected float horizontalBobWidth; // 0x90
	[SerializeField]
	[Range(0, 5)]
	protected float horizontalBobSpeed; // 0x94
	[SerializeField]
	protected float walkBobSmooth; // 0x98
	[SerializeField]
	protected float sprintSpeedMultiplier; // 0x9C
	[HideInInspector]
	public float walkBobMultiplier; // 0xA0
	private Vector3 walkBobPos; // 0xA4
	private float timeSinceWalkStart_vert; // 0xB0
	private float timeSinceWalkStart_horiz; // 0xB4
	[Header("Settings - Jump Jolt")]
	public bool jumpJoltEnabled; // 0xB8
	[SerializeField]
	protected AnimationCurve jumpCurve; // 0xC0
	[SerializeField]
	protected float jumpJoltTime; // 0xC8
	[SerializeField]
	protected float jumpJoltHeight; // 0xCC
	[SerializeField]
	protected float jumpJoltSmooth; // 0xD0
	[SerializeField]
	[Header("Settings - Equip Bop")]
	protected float equipBopVerticalOffset; // 0xD4
	[SerializeField]
	protected float equipBopTime; // 0xD8
	private Vector3 equipBopPos; // 0xDC
	private float timeSinceJumpStart; // 0xE8
	private Vector3 jumpPos; // 0xEC
	[SerializeField]
	[Range(0, 1)]
	[Header("Settings - Falling")]
	protected float fallOffsetRate; // 0xF8
	[SerializeField]
	[Range(0, 2)]
	protected float maxFallOffsetAmount; // 0xFC
	private Vector3 fallOffsetPos; // 0x100
	[Header("Settings - Land Jolt")]
	[SerializeField]
	protected AnimationCurve landCurve; // 0x110
	[SerializeField]
	protected float landJoltTime; // 0x118
	[SerializeField]
	protected float landJoltSmooth; // 0x11C
	private Vector3 landPos; // 0x120
	private float timeSinceLanded; // 0x12C
	private float landJoltMultiplier; // 0x130

	// Properties
	protected float calculatedJumpJoltHeight { get; }

	// Methods

	// RVA: 0x673C50 Offset: 0x672650 VA: 0x180673C50
	protected float get_calculatedJumpJoltHeight() { }

	// RVA: 0x6728A0 Offset: 0x6712A0 VA: 0x1806728A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x671D60 Offset: 0x670760 VA: 0x180671D60 Slot: 4
	protected override void Awake() { }

	// RVA: 0x671EF0 Offset: 0x6708F0 VA: 0x180671EF0 Slot: 6
	public override void OnStartClient(bool IsOwner) { }

	// RVA: 0x673240 Offset: 0x671C40 VA: 0x180673240
	protected void Update() { }

	// RVA: 0x671E30 Offset: 0x670830 VA: 0x180671E30
	private void InventoryStateChanged(bool active) { }

	// RVA: 0x671EE0 Offset: 0x6708E0 VA: 0x180671EE0
	private void OnEquippedSlotChanged(int slotIndex) { }

	// RVA: 0x6723A0 Offset: 0x670DA0 VA: 0x1806723A0
	public void RefreshViewmodel() { }

	// RVA: 0x671DD0 Offset: 0x6707D0 VA: 0x180671DD0
	protected void BreatheBob() { }

	// RVA: 0x6728E0 Offset: 0x6712E0 VA: 0x1806728E0
	protected void Sway() { }

	// RVA: 0x673560 Offset: 0x671F60 VA: 0x180673560
	protected void WalkBob() { }

	// RVA: 0x672890 Offset: 0x671290 VA: 0x180672890
	protected void StartJump() { }

	// RVA: 0x672D20 Offset: 0x671720 VA: 0x180672D20
	protected void UpdateJump() { }

	// RVA: 0x671E40 Offset: 0x670840 VA: 0x180671E40
	protected void Land() { }

	// RVA: 0x673A20 Offset: 0x672420 VA: 0x180673A20
	public void .ctor() { }
}
