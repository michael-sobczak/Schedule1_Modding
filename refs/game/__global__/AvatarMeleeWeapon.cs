public class AvatarMeleeWeapon : AvatarWeapon // TypeDefIndex: 3159
{
	// Fields
	[Header("References")]
	public AudioSourceController AttackSound; // 0x80
	public AudioSourceController HitSound; // 0x88
	[Header("Melee Weapon settings")]
	public EImpactType ImpactType; // 0x90
	public float AttackRange; // 0x94
	public float AttackRadius; // 0x98
	public float Damage; // 0x9C
	public float ImpactForce; // 0xA0
	public AvatarMeleeWeapon.MeleeAttack[] Attacks; // 0xA8
	public float GruntChance; // 0xB0
	private Coroutine attackRoutine; // 0xB8

	// Methods

	// RVA: 0x9B2730 Offset: 0x9B1130 VA: 0x1809B2730 Slot: 7
	public override void Unequip() { }

	// RVA: 0x9B26E0 Offset: 0x9B10E0 VA: 0x1809B26E0 Slot: 10
	public override bool IsReadyToAttack() { }

	// RVA: 0x9B24C0 Offset: 0x9B0EC0 VA: 0x1809B24C0 Slot: 9
	public override void Attack() { }

	// RVA: 0x9B2780 Offset: 0x9B1180 VA: 0x1809B2780
	public void .ctor() { }
}
