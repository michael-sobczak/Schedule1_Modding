public class DebugUIHandlerUIntField : DebugUIHandlerWidget // TypeDefIndex: 13977
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.UIntField m_Field; // 0x70

	// Methods

	// RVA: 0x2A50AC0 Offset: 0x2A4F4C0 VA: 0x182A50AC0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A4C220 Offset: 0x2A4AC20 VA: 0x182A4C220 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A4C1A0 Offset: 0x2A4ABA0 VA: 0x182A4C1A0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A50A30 Offset: 0x2A4F430 VA: 0x182A50A30 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A50990 Offset: 0x2A4F390 VA: 0x182A50990 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A508E0 Offset: 0x2A4F2E0 VA: 0x182A508E0
	private void ChangeValue(bool fast, int multiplier) { }

	// RVA: 0x2A50B60 Offset: 0x2A4F560 VA: 0x182A50B60
	private void UpdateValueLabel() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
