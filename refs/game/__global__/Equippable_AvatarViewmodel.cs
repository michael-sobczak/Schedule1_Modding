public class Equippable_AvatarViewmodel : Equippable_Viewmodel // TypeDefIndex: 2532
{
	// Fields
	public RuntimeAnimatorController AnimatorController; // 0x60
	public Vector3 ViewmodelAvatarOffset; // 0x68
	public Vector3 ViewmodelAvatarRotationOffset; // 0x74
	[Header("Equipping")]
	public float EquipTime; // 0x80
	public string EquipTrigger; // 0x88
	protected float timeEquipped; // 0x90

	// Properties
	protected bool equipAnimDone { get; }

	// Methods

	// RVA: 0x8ADE70 Offset: 0x8AC870 VA: 0x1808ADE70
	protected bool get_equipAnimDone() { }

	// RVA: 0x8AD870 Offset: 0x8AC270 VA: 0x1808AD870 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8ADC60 Offset: 0x8AC660 VA: 0x1808ADC60 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8ADAF0 Offset: 0x8AC4F0 VA: 0x1808ADAF0 Slot: 7
	protected override void PlayEquipAnimation() { }

	// RVA: 0x8ADD10 Offset: 0x8AC710 VA: 0x1808ADD10 Slot: 6
	protected override void Update() { }

	// RVA: 0x8ADD50 Offset: 0x8AC750 VA: 0x1808ADD50
	public void .ctor() { }
}
