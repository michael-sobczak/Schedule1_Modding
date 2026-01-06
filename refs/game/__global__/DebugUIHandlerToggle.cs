public class DebugUIHandlerToggle : DebugUIHandlerWidget // TypeDefIndex: 13974
{
	// Fields
	public Text nameLabel; // 0x60
	public Toggle valueToggle; // 0x68
	public Image checkmarkImage; // 0x70
	protected internal DebugUI.BoolField m_Field; // 0x78

	// Methods

	// RVA: 0x2A50710 Offset: 0x2A4F110 VA: 0x182A50710 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A506E0 Offset: 0x2A4F0E0 VA: 0x182A506E0
	private void OnToggleValueChanged(bool value) { }

	// RVA: 0x2A4D3D0 Offset: 0x2A4BDD0 VA: 0x182A4D3D0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A4D360 Offset: 0x2A4BD60 VA: 0x182A4D360 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A50660 Offset: 0x2A4F060 VA: 0x182A50660 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A50840 Offset: 0x2A4F240 VA: 0x182A50840 Slot: 13
	protected internal virtual void UpdateValueLabel() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
