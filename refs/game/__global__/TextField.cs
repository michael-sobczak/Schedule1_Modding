internal class TextField : FormField // TypeDefIndex: 18031
{
	// Fields
	[Tooltip("The label to prepend to this field on the report (won't be included if left blank)")]
	public string Label; // 0x38
	private IInputField sourceField; // 0x40
	private string lastValue; // 0x48

	// Methods

	// RVA: 0x443680 Offset: 0x442080 VA: 0x180443680 Slot: 7
	public override void Awake() { }

	// RVA: 0x443AB0 Offset: 0x4424B0 VA: 0x180443AB0
	private void OnValueChanged(string val) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected override void FormClosed() { }

	// RVA: 0x4437D0 Offset: 0x4421D0 VA: 0x1804437D0 Slot: 4
	protected override void FormOpened() { }

	// RVA: 0x443820 Offset: 0x442220 VA: 0x180443820 Slot: 5
	protected override void FormSubmitted() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
