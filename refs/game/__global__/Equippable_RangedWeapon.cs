public class Equippable_RangedWeapon : Equippable_AvatarViewmodel // TypeDefIndex: 2543
{
	// Fields
	public const float NPC_AIM_DETECTION_RANGE = 10;
	[CompilerGenerated]
	private float <Aim>k__BackingField; // 0x98
	[CompilerGenerated]
	private float <Accuracy>k__BackingField; // 0x9C
	[CompilerGenerated]
	private float <TimeSinceFire>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <IsReloading>k__BackingField; // 0xA4
	[CompilerGenerated]
	private bool <IsCocked>k__BackingField; // 0xA5
	[CompilerGenerated]
	private bool <IsCocking>k__BackingField; // 0xA6
	public int MagazineSize; // 0xA8
	[Header("Aim Settings")]
	public float AimDuration; // 0xAC
	public float AimFOVReduction; // 0xB0
	[Header("Firing")]
	public AudioSourceController FireSound; // 0xB8
	public AudioSourceController EmptySound; // 0xC0
	public float FireCooldown; // 0xC8
	public string[] FireAnimTriggers; // 0xD0
	public float AccuracyChangeDuration; // 0xD8
	[Header("Raycasting")]
	public float Range; // 0xDC
	public float RayRadius; // 0xE0
	[Header("Spread")]
	public float MinSpread; // 0xE4
	public float MaxSpread; // 0xE8
	[Header("Damage")]
	public float Damage; // 0xEC
	public float ImpactForce; // 0xF0
	[Header("Reloading")]
	public bool CanReload; // 0xF4
	public Equippable_RangedWeapon.EReloadType ReloadType; // 0xF8
	public StorableItemDefinition Magazine; // 0x100
	public float ReloadStartTime; // 0x108
	public float ReloadIndividalTime; // 0x10C
	public float ReloadEndTime; // 0x110
	public string ReloadStartAnimTrigger; // 0x118
	public string ReloadIndividualAnimTrigger; // 0x120
	public string ReloadEndAnimTrigger; // 0x128
	public TrashItem ReloadTrash; // 0x130
	[Header("Cocking")]
	public bool MustBeCocked; // 0x138
	public bool CockedByDefault; // 0x139
	public bool AutoCockAfterReload; // 0x13A
	public float CockTime; // 0x13C
	public string CockAnimTrigger; // 0x140
	[Header("Effects")]
	public float TracerSpeed; // 0x148
	public UnityEvent onFire; // 0x150
	public UnityEvent onReloadStart; // 0x158
	public UnityEvent onReloadIndividual; // 0x160
	public UnityEvent onReloadEnd; // 0x168
	public UnityEvent onCockStart; // 0x170
	protected IntegerItemInstance weaponItem; // 0x178
	private bool fovOverridden; // 0x180
	private float aimVelocity; // 0x184
	private Coroutine reloadRoutine; // 0x188
	private bool shotQueued; // 0x190
	private bool reloadQueued; // 0x191
	private float timeSincePrimaryClick; // 0x194
	private float timeSinceReloadStart; // 0x198
	private bool interruptReload; // 0x19C

	// Properties
	public float Aim { get; set; }
	public float Accuracy { get; set; }
	public float TimeSinceFire { get; set; }
	public bool IsReloading { get; set; }
	public bool IsCocked { get; set; }
	public bool IsCocking { get; set; }
	public int Ammo { get; }
	private float aimFov { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8B33F0 Offset: 0x8B1DF0 VA: 0x1808B33F0
	public float get_Aim() { }

	[CompilerGenerated]
	// RVA: 0x8B3500 Offset: 0x8B1F00 VA: 0x1808B3500
	private void set_Aim(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A5280 Offset: 0x6A3C80 VA: 0x1806A5280
	public float get_Accuracy() { }

	[CompilerGenerated]
	// RVA: 0x8B34F0 Offset: 0x8B1EF0 VA: 0x1808B34F0
	private void set_Accuracy(float value) { }

	[CompilerGenerated]
	// RVA: 0x8B3450 Offset: 0x8B1E50 VA: 0x1808B3450
	public float get_TimeSinceFire() { }

	[CompilerGenerated]
	// RVA: 0x8B3540 Offset: 0x8B1F40 VA: 0x1808B3540
	public void set_TimeSinceFire(float value) { }

	[CompilerGenerated]
	// RVA: 0x8B3440 Offset: 0x8B1E40 VA: 0x1808B3440
	public bool get_IsReloading() { }

	[CompilerGenerated]
	// RVA: 0x8B3530 Offset: 0x8B1F30 VA: 0x1808B3530
	private void set_IsReloading(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8B3420 Offset: 0x8B1E20 VA: 0x1808B3420
	public bool get_IsCocked() { }

	[CompilerGenerated]
	// RVA: 0x8B3510 Offset: 0x8B1F10 VA: 0x1808B3510
	private void set_IsCocked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8B3430 Offset: 0x8B1E30 VA: 0x1808B3430
	public bool get_IsCocking() { }

	[CompilerGenerated]
	// RVA: 0x8B3520 Offset: 0x8B1F20 VA: 0x1808B3520
	private void set_IsCocking(bool value) { }

	// RVA: 0x8B3400 Offset: 0x8B1E00 VA: 0x1808B3400
	public int get_Ammo() { }

	// RVA: 0x8B3460 Offset: 0x8B1E60 VA: 0x1808B3460
	private float get_aimFov() { }

	// RVA: 0x8B0B40 Offset: 0x8AF540 VA: 0x1808B0B40 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8B23C0 Offset: 0x8B0DC0 VA: 0x1808B23C0 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8B30E0 Offset: 0x8B1AE0 VA: 0x1808B30E0 Slot: 6
	protected override void Update() { }

	// RVA: 0x8B2670 Offset: 0x8B1070 VA: 0x1808B2670
	private void UpdateInput() { }

	// RVA: 0x8B25C0 Offset: 0x8B0FC0 VA: 0x1808B25C0
	private void UpdateAnim() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool CanAim() { }

	// RVA: 0x8B0D40 Offset: 0x8AF740 VA: 0x1808B0D40 Slot: 9
	public virtual void Fire() { }

	// RVA: 0x8B1A40 Offset: 0x8B0440 VA: 0x1808B1A40 Slot: 10
	protected virtual Vector3[] GetBulletDirections() { }

	// RVA: 0x8B2060 Offset: 0x8B0A60 VA: 0x1808B2060
	protected static Vector3 SpreadDirection(Vector3 direction, float maxAngle) { }

	// RVA: 0x8B1F60 Offset: 0x8B0960 VA: 0x1808B1F60 Slot: 11
	public virtual void Reload() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected virtual void NotifyIncrementalReload() { }

	// RVA: 0x8B1E90 Offset: 0x8B0890 VA: 0x1808B1E90
	private bool IsReloadReady(bool ignoreTiming) { }

	// RVA: 0x8B1B90 Offset: 0x8B0590 VA: 0x1808B1B90 Slot: 13
	protected virtual bool GetMagazine(out StorableItemInstance mag) { }

	// RVA: 0x8B0560 Offset: 0x8AEF60 VA: 0x1808B0560
	private bool CanFire(bool checkAmmo = True) { }

	// RVA: 0x8B04F0 Offset: 0x8AEEF0 VA: 0x1808B04F0
	private bool CanCock() { }

	// RVA: 0x8B0A70 Offset: 0x8AF470 VA: 0x1808B0A70
	private void Cock() { }

	// RVA: 0x8B1E40 Offset: 0x8B0840 VA: 0x1808B1E40
	protected float GetSpreadAngle() { }

	// RVA: 0x8B05D0 Offset: 0x8AEFD0 VA: 0x1808B05D0
	private void CheckAimingAtNPC() { }

	// RVA: 0x8B3270 Offset: 0x8B1C70 VA: 0x1808B3270
	public void .ctor() { }

	[IteratorStateMachine(typeof(Equippable_RangedWeapon.<<Reload>g__ReloadRoutine|83_0>d))]
	[CompilerGenerated]
	// RVA: 0x8B2350 Offset: 0x8B0D50 VA: 0x1808B2350
	private IEnumerator <Reload>g__ReloadRoutine|83_0() { }

	[IteratorStateMachine(typeof(Equippable_RangedWeapon.<<Cock>g__CockRoutine|89_0>d))]
	[CompilerGenerated]
	// RVA: 0x8B22E0 Offset: 0x8B0CE0 VA: 0x1808B22E0
	private IEnumerator <Cock>g__CockRoutine|89_0() { }
}
