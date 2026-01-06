public class AvatarRangedWeapon : AvatarWeapon // TypeDefIndex: 3161
{
	// Fields
	[Header("Weapon Settings")]
	public int MagazineSize; // 0x80
	public float ReloadTime; // 0x84
	public float MaxFireRate; // 0x88
	public float EquipTime; // 0x8C
	public float RaiseTime; // 0x90
	public float Damage; // 0x94
	public float ImpactForce; // 0x98
	public bool CanShootWhileMoving; // 0x9C
	public int MaxMovingShotsBeforeReposition; // 0xA0
	public int MaxStationaryShotsBeforeReposition; // 0xA4
	public bool RepositionAfterHit; // 0xA8
	[Header("Accuracy")]
	public float HitChance_MinRange; // 0xAC
	public float HitChance_MaxRange; // 0xB0
	[Header("Aiming")]
	public float AimTime_Min; // 0xB4
	public float AimTime_Max; // 0xB8
	[Header("References")]
	public Transform MuzzlePoint; // 0xC0
	public AudioSourceController FireSound; // 0xC8
	[Header("Animation Settings")]
	public string LoweredAnimationTrigger; // 0xD0
	public string RaisedAnimationTrigger; // 0xD8
	public string RecoilAnimationTrigger; // 0xE0
	[CompilerGenerated]
	private bool <IsRaised>k__BackingField; // 0xE8
	private bool isReloading; // 0xE9
	private float timeEquipped; // 0xEC
	private float timeRaised; // 0xF0
	private float timeSinceLastShot; // 0xF4
	private int currentAmmo; // 0xF8

	// Properties
	public bool IsRaised { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x510B30 Offset: 0x50F530 VA: 0x180510B30
	public bool get_IsRaised() { }

	[CompilerGenerated]
	// RVA: 0x9B36D0 Offset: 0x9B20D0 VA: 0x1809B36D0
	protected void set_IsRaised(bool value) { }

	// RVA: 0x9B2A40 Offset: 0x9B1440 VA: 0x1809B2A40 Slot: 5
	public override void Equip(Avatar _avatar) { }

	// RVA: 0x9B3560 Offset: 0x9B1F60 VA: 0x1809B3560 Slot: 7
	public override void Unequip() { }

	// RVA: 0x9B3350 Offset: 0x9B1D50 VA: 0x1809B3350 Slot: 11
	public virtual void SetIsRaised(bool raised) { }

	// RVA: 0x9B35A0 Offset: 0x9B1FA0 VA: 0x1809B35A0
	private void Update() { }

	// RVA: 0x9B31A0 Offset: 0x9B1BA0 VA: 0x1809B31A0 Slot: 8
	public override void ReceiveMessage(string message, object data) { }

	// RVA: 0x9B29E0 Offset: 0x9B13E0 VA: 0x1809B29E0
	public bool CanShoot() { }

	// RVA: 0x9B33D0 Offset: 0x9B1DD0 VA: 0x1809B33D0 Slot: 12
	protected virtual void Shoot(Vector3 endPoint) { }

	// RVA: 0x9B27D0 Offset: 0x9B11D0 VA: 0x1809B27D0 Slot: 13
	public virtual void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint) { }

	[IteratorStateMachine(typeof(AvatarRangedWeapon.<Reload>d__37))]
	// RVA: 0x9B32E0 Offset: 0x9B1CE0 VA: 0x1809B32E0
	private IEnumerator Reload() { }

	// RVA: 0x9B2B70 Offset: 0x9B1570 VA: 0x1809B2B70
	public bool IsTargetInLoS(ICombatTargetable target) { }

	// RVA: 0x9B2B50 Offset: 0x9B1550 VA: 0x1809B2B50 Slot: 14
	public virtual float GetIdealUseRange() { }

	// RVA: 0x9B3620 Offset: 0x9B2020 VA: 0x1809B3620
	public void .ctor() { }
}
