public class PunchController : MonoBehaviour // TypeDefIndex: 1992
{
	// Fields
	public const float MAX_PUNCH_LOAD = 1;
	public const float MIN_COOLDOWN = 0.1;
	public const float MAX_COOLDOWN = 0.2;
	public const float PUNCH_RANGE = 1.25;
	public const float PUNCH_DEBOUNCE = 0.1;
	[CompilerGenerated]
	private bool <PunchingEnabled>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsPunching>k__BackingField; // 0x21
	[Header("Settings")]
	public Vector3 ViewmodelAvatarOffset; // 0x24
	public float MinPunchDamage; // 0x30
	public float MaxPunchDamage; // 0x34
	public float MinPunchForce; // 0x38
	public float MaxPunchForce; // 0x3C
	[Header("Stamina Settings")]
	public float MinStaminaCost; // 0x40
	public float MaxStaminaCost; // 0x44
	[Header("References")]
	public AudioSourceController PunchSound; // 0x48
	public RuntimeAnimatorController PunchAnimator; // 0x50
	private float punchLoad; // 0x58
	private float remainingCooldown; // 0x5C
	private Player player; // 0x60
	private Coroutine punchRoutine; // 0x68
	private bool itemEquippedLastFrame; // 0x70
	private float timeSincePunchingEnabled; // 0x74

	// Properties
	public bool PunchingEnabled { get; set; }
	public bool IsLoading { get; }
	public bool IsPunching { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_PunchingEnabled() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_PunchingEnabled(bool value) { }

	// RVA: 0x7A24C0 Offset: 0x7A0EC0 VA: 0x1807A24C0
	public bool get_IsLoading() { }

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_IsPunching() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	private void set_IsPunching(bool value) { }

	// RVA: 0x7A0C20 Offset: 0x79F620 VA: 0x1807A0C20
	private void Awake() { }

	// RVA: 0x7A1F80 Offset: 0x7A0980 VA: 0x1807A1F80
	private void Start() { }

	// RVA: 0x7A2380 Offset: 0x7A0D80 VA: 0x1807A2380
	private void Update() { }

	// RVA: 0x7A1370 Offset: 0x79FD70 VA: 0x1807A1370
	private void LateUpdate() { }

	// RVA: 0x7A2080 Offset: 0x7A0A80 VA: 0x1807A2080
	private void UpdateCooldown() { }

	// RVA: 0x7A20F0 Offset: 0x7A0AF0 VA: 0x1807A20F0
	private void UpdateInput() { }

	// RVA: 0x7A0C70 Offset: 0x79F670 VA: 0x1807A0C70
	private bool CanStartLoading() { }

	// RVA: 0x7A1CE0 Offset: 0x7A06E0 VA: 0x1807A1CE0
	private void StartLoad() { }

	// RVA: 0x7A1580 Offset: 0x79FF80 VA: 0x1807A1580
	private void Release() { }

	// RVA: 0x7A13C0 Offset: 0x79FDC0 VA: 0x1807A13C0
	private void Punch(float power) { }

	// RVA: 0x7A0CF0 Offset: 0x79F6F0 VA: 0x1807A0CF0
	private void ExecuteHit(float power) { }

	// RVA: 0x7A18D0 Offset: 0x7A02D0 VA: 0x1807A18D0
	private void SetPunchingEnabled(bool enabled) { }

	// RVA: 0x7A1A00 Offset: 0x7A0400 VA: 0x1807A1A00
	private bool ShouldBeEnabled() { }

	// RVA: 0x7A2470 Offset: 0x7A0E70 VA: 0x1807A2470
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7A2070 Offset: 0x7A0A70 VA: 0x1807A2070
	private void <Start>b__31_0() { }
}
