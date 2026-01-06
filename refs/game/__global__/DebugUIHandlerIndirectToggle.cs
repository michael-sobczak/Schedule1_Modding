public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget // TypeDefIndex: 13962
{
	// Fields
	public Text nameLabel; // 0x60
	public Toggle valueToggle; // 0x68
	public Image checkmarkImage; // 0x70
	public Func<int, bool> getter; // 0x78
	public Action<int, bool> setter; // 0x80
	internal int index; // 0x88

	// Methods

	// RVA: 0x2A4D230 Offset: 0x2A4BC30 VA: 0x182A4D230
	public void Init() { }

	// RVA: 0x2A4D440 Offset: 0x2A4BE40 VA: 0x182A4D440
	private void OnToggleValueChanged(bool value) { }

	// RVA: 0x2A4D3D0 Offset: 0x2A4BDD0 VA: 0x182A4D3D0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A4D360 Offset: 0x2A4BD60 VA: 0x182A4D360 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A4D2F0 Offset: 0x2A4BCF0 VA: 0x182A4D2F0 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A4D480 Offset: 0x2A4BE80 VA: 0x182A4D480
	internal void UpdateValueLabel() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
