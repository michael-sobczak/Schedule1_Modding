internal class ConstraintEnumerator // TypeDefIndex: 12882
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x2069370 Offset: 0x2067D70 VA: 0x182069370
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x2069140 Offset: 0x2067B40 VA: 0x182069140
	public bool GetNext() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Constraint GetConstraint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	protected Constraint get_CurrentObject() { }
}
