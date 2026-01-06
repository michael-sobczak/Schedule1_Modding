internal class ToggleField : FormField // TypeDefIndex: 18032
{
	// Fields
	[Tooltip("The label to prepend to this field on the report (won't be included if left blank)")]
	public string Label; // 0x38
	[Tooltip("The default value of the toggle")]
	public bool Default; // 0x40
	private Toggle sourceField; // 0x48

	// Methods

	// RVA: 0x4445A0 Offset: 0x442FA0 VA: 0x1804445A0 Slot: 7
	public override void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected override void FormClosed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected override void FormOpened() { }

	// RVA: 0x444610 Offset: 0x443010 VA: 0x180444610 Slot: 5
	protected override void FormSubmitted() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
