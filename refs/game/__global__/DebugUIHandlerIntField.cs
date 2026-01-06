public class DebugUIHandlerIntField : DebugUIHandlerWidget // TypeDefIndex: 13963
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.IntField m_Field; // 0x70

	// Methods

	// RVA: 0x2A4D5F0 Offset: 0x2A4BFF0 VA: 0x182A4D5F0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A4C220 Offset: 0x2A4AC20 VA: 0x182A4C220 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A4C1A0 Offset: 0x2A4ABA0 VA: 0x182A4C1A0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A4D5E0 Offset: 0x2A4BFE0 VA: 0x182A4D5E0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A4D5D0 Offset: 0x2A4BFD0 VA: 0x182A4D5D0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A4D520 Offset: 0x2A4BF20 VA: 0x182A4D520
	private void ChangeValue(bool fast, int multiplier) { }

	// RVA: 0x2A4D690 Offset: 0x2A4C090 VA: 0x182A4D690
	private void UpdateValueLabel() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
