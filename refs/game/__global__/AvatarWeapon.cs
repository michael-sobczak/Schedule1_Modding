public class AvatarWeapon : AvatarEquippable // TypeDefIndex: 3162
{
	// Fields
	[Header("Range settings")]
	public float MinUseRange; // 0x50
	public float MaxUseRange; // 0x54
	[Header("Cooldown settings")]
	public float CooldownDuration; // 0x58
	[Header("Equipping")]
	public AudioClip[] EquipClips; // 0x60
	public AudioSourceController EquipSound; // 0x68
	[CompilerGenerated]
	private float <LastUseTime>k__BackingField; // 0x70
	public UnityEvent onSuccessfulHit; // 0x78

	// Properties
	public float LastUseTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD9D0 Offset: 0x4CC3D0 VA: 0x1804CD9D0
	public float get_LastUseTime() { }

	[CompilerGenerated]
	// RVA: 0x4E28D0 Offset: 0x4E12D0 VA: 0x1804E28D0
	private void set_LastUseTime(float value) { }

	// RVA: 0x9B5550 Offset: 0x9B3F50 VA: 0x1809B5550 Slot: 5
	public override void Equip(Avatar _avatar) { }

	// RVA: 0x9B5530 Offset: 0x9B3F30 VA: 0x1809B5530 Slot: 9
	public virtual void Attack() { }

	// RVA: 0x9B5650 Offset: 0x9B4050 VA: 0x1809B5650 Slot: 10
	public virtual bool IsReadyToAttack() { }

	// RVA: 0x9B5680 Offset: 0x9B4080 VA: 0x1809B5680
	public void .ctor() { }
}
