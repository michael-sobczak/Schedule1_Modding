public class DebugUIHandlerFloatField : DebugUIHandlerWidget // TypeDefIndex: 13957
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.FloatField m_Field; // 0x70

	// Methods

	// RVA: 0x2A4C290 Offset: 0x2A4AC90 VA: 0x182A4C290 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A4C220 Offset: 0x2A4AC20 VA: 0x182A4C220 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A4C1A0 Offset: 0x2A4ABA0 VA: 0x182A4C1A0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A4C210 Offset: 0x2A4AC10 VA: 0x182A4C210 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A4C190 Offset: 0x2A4AB90 VA: 0x182A4C190 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A4C0E0 Offset: 0x2A4AAE0 VA: 0x182A4C0E0
	private void ChangeValue(bool fast, float multiplier) { }

	// RVA: 0x2A4C330 Offset: 0x2A4AD30 VA: 0x182A4C330
	private void UpdateValueLabel() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
