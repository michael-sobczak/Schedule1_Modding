internal class DropdownField : FormField // TypeDefIndex: 18027
{
	// Fields
	[Tooltip("The label to prepend to this field on the report (won't be included if left blank)")]
	public string Label; // 0x38
	private IDropdown sourceField; // 0x40

	// Methods

	// RVA: 0x43D310 Offset: 0x43BD10 VA: 0x18043D310 Slot: 7
	public override void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected override void FormClosed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected override void FormOpened() { }

	// RVA: 0x43D350 Offset: 0x43BD50 VA: 0x18043D350 Slot: 5
	protected override void FormSubmitted() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
