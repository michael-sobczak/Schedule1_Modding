public class Taser : AvatarRangedWeapon // TypeDefIndex: 3164
{
	// Fields
	public const float TaseDuration = 2;
	public const float TaseMoveSpeedMultiplier = 0.5;
	[Header("References")]
	public GameObject FlashObject; // 0x100
	public AudioSourceController ChargeSound; // 0x108
	[Header("Prefabs")]
	public GameObject RayPrefab; // 0x110
	private Coroutine flashRoutine; // 0x118

	// Methods

	// RVA: 0x9BC1C0 Offset: 0x9BABC0 VA: 0x1809BC1C0 Slot: 5
	public override void Equip(Avatar _avatar) { }

	// RVA: 0x9BC430 Offset: 0x9BAE30 VA: 0x1809BC430 Slot: 12
	protected override void Shoot(Vector3 endPoint) { }

	// RVA: 0x9BC110 Offset: 0x9BAB10 VA: 0x1809BC110 Slot: 13
	public override void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint) { }

	// RVA: 0x9BC390 Offset: 0x9BAD90 VA: 0x1809BC390 Slot: 11
	public override void SetIsRaised(bool raised) { }

	[IteratorStateMachine(typeof(Taser.<Flash>d__10))]
	// RVA: 0x9BC300 Offset: 0x9BAD00 VA: 0x1809BC300
	private IEnumerator Flash(Vector3 endPoint) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50 Slot: 14
	public override float GetIdealUseRange() { }

	// RVA: 0x9AF130 Offset: 0x9ADB30 VA: 0x1809AF130
	public void .ctor() { }
}
