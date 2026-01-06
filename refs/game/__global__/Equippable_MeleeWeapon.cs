public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel // TypeDefIndex: 2536
{
	// Fields
	[CompilerGenerated]
	private bool <IsAttacking>k__BackingField; // 0x98
	[Header("Basic Settings")]
	public EImpactType ImpactType; // 0x9C
	public float Range; // 0xA0
	public float HitRadius; // 0xA4
	[Header("Timing")]
	public float MaxLoadTime; // 0xA8
	public float MinCooldown; // 0xAC
	public float MaxCooldown; // 0xB0
	public float MinHitDelay; // 0xB4
	public float MaxHitDelay; // 0xB8
	[Header("Damage")]
	public float MinDamage; // 0xBC
	public float MaxDamage; // 0xC0
	public float MinForce; // 0xC4
	public float MaxForce; // 0xC8
	[Header("Stamina Settings")]
	public float MinStaminaCost; // 0xCC
	public float MaxStaminaCost; // 0xD0
	[Header("Sound")]
	public AudioSourceController WhooshSound; // 0xD8
	public float WhooshSoundPitch; // 0xE0
	public AudioSourceController ImpactSound; // 0xE8
	[Header("Animation")]
	public string SwingAnimationTrigger; // 0xF0
	private float load; // 0xF8
	private float remainingCooldown; // 0xFC
	private Coroutine hitRoutine; // 0x100
	private bool loadQueued; // 0x108
	private bool clickReleased; // 0x109

	// Properties
	public bool IsLoading { get; }
	public bool IsAttacking { get; set; }

	// Methods

	// RVA: 0x8AFE10 Offset: 0x8AE810 VA: 0x1808AFE10
	public bool get_IsLoading() { }

	[CompilerGenerated]
	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460
	public bool get_IsAttacking() { }

	[CompilerGenerated]
	// RVA: 0x614500 Offset: 0x612F00 VA: 0x180614500
	private void set_IsAttacking(bool value) { }

	// RVA: 0x8AFC50 Offset: 0x8AE650 VA: 0x1808AFC50 Slot: 6
	protected override void Update() { }

	// RVA: 0x8AE890 Offset: 0x8AD290 VA: 0x1808AE890 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8AF760 Offset: 0x8AE160 VA: 0x1808AF760 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8AF810 Offset: 0x8AE210 VA: 0x1808AF810
	private void UpdateCooldown() { }

	// RVA: 0x8AF890 Offset: 0x8AE290 VA: 0x1808AF890
	private void UpdateInput() { }

	// RVA: 0x8AE7F0 Offset: 0x8AD1F0 VA: 0x1808AE7F0
	private bool CanStartLoading() { }

	// RVA: 0x8AF5C0 Offset: 0x8ADFC0 VA: 0x1808AF5C0
	private void StartLoad() { }

	// RVA: 0x8AF180 Offset: 0x8ADB80 VA: 0x1808AF180
	private void Release() { }

	// RVA: 0x8AEFC0 Offset: 0x8AD9C0 VA: 0x1808AEFC0
	private void Hit(float power) { }

	// RVA: 0x8AE8A0 Offset: 0x8AD2A0 VA: 0x1808AE8A0
	private void ExecuteHit(float power) { }

	// RVA: 0x8AFD70 Offset: 0x8AE770 VA: 0x1808AFD70
	public void .ctor() { }
}
