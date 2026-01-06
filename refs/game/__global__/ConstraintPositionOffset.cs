public class ConstraintPositionOffset : Constraint // TypeDefIndex: 14052
{
	// Fields
	public Vector3 offset; // 0x20
	private Vector3 defaultLocalPosition; // 0x2C
	private Vector3 lastLocalPosition; // 0x38
	private bool initiated; // 0x44

	// Properties
	private bool positionChanged { get; }

	// Methods

	// RVA: 0x1EA3860 Offset: 0x1EA2260 VA: 0x181EA3860 Slot: 4
	public override void UpdateConstraint() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Transform transform) { }

	// RVA: 0x1EA3AB0 Offset: 0x1EA24B0 VA: 0x181EA3AB0
	private bool get_positionChanged() { }
}
