public abstract class Constraint // TypeDefIndex: 14050
{
	// Fields
	public Transform transform; // 0x10
	public float weight; // 0x18

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x1EA3FC0 Offset: 0x1EA29C0 VA: 0x181EA3FC0
	public bool get_isValid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void UpdateConstraint();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
