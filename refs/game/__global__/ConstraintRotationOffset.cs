public class ConstraintRotationOffset : Constraint // TypeDefIndex: 14054
{
	// Fields
	public Quaternion offset; // 0x20
	private Quaternion defaultRotation; // 0x30
	private Quaternion defaultLocalRotation; // 0x40
	private Quaternion lastLocalRotation; // 0x50
	private Quaternion defaultTargetLocalRotation; // 0x60
	private bool initiated; // 0x70

	// Properties
	private bool rotationChanged { get; }

	// Methods

	// RVA: 0x1EA3C60 Offset: 0x1EA2660 VA: 0x181EA3C60 Slot: 4
	public override void UpdateConstraint() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Transform transform) { }

	// RVA: 0x1EA3E60 Offset: 0x1EA2860 VA: 0x181EA3E60
	private bool get_rotationChanged() { }
}
