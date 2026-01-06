public class HitReaction : OffsetModifier // TypeDefIndex: 14193
{
	// Fields
	[Tooltip("Hit points for the FBBIK effectors")]
	public HitReaction.HitPointEffector[] effectorHitPoints; // 0x38
	[Tooltip(" Hit points for bones without an effector, such as the head")]
	public HitReaction.HitPointBone[] boneHitPoints; // 0x40

	// Properties
	public bool inProgress { get; }

	// Methods

	// RVA: 0x1F21E40 Offset: 0x1F20840 VA: 0x181F21E40
	public bool get_inProgress() { }

	// RVA: 0x1F21D50 Offset: 0x1F20750 VA: 0x181F21D50 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F21AE0 Offset: 0x1F204E0 VA: 0x181F21AE0
	public void Hit(Collider collider, Vector3 force, Vector3 point) { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	public void .ctor() { }
}
