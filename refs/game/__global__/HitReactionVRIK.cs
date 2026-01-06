public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 14199
{
	// Fields
	public AnimationCurve[] offsetCurves; // 0x38
	[Tooltip("Hit points for the FBBIK effectors")]
	public HitReactionVRIK.PositionOffset[] positionOffsets; // 0x40
	[Tooltip(" Hit points for bones without an effector, such as the head")]
	public HitReactionVRIK.RotationOffset[] rotationOffsets; // 0x48

	// Methods

	// RVA: 0x1F21A00 Offset: 0x1F20400 VA: 0x181F21A00 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F21780 Offset: 0x1F20180 VA: 0x181F21780
	public void Hit(Collider collider, Vector3 force, Vector3 point) { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	public void .ctor() { }
}
