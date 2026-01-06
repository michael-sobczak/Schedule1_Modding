public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget // TypeDefIndex: 13961
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	public Func<float> getter; // 0x70
	public Action<float> setter; // 0x78
	public Func<float> incStepGetter; // 0x80
	public Func<float> incStepMultGetter; // 0x88
	public Func<float> decimalsGetter; // 0x90

	// Methods

	// RVA: 0x2A4D0F0 Offset: 0x2A4BAF0 VA: 0x182A4D0F0
	public void Init() { }

	// RVA: 0x2A4C220 Offset: 0x2A4AC20 VA: 0x182A4C220 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A4C1A0 Offset: 0x2A4ABA0 VA: 0x182A4C1A0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A4D110 Offset: 0x2A4BB10 VA: 0x182A4D110 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A4D100 Offset: 0x2A4BB00 VA: 0x182A4D100 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A4D010 Offset: 0x2A4BA10 VA: 0x182A4D010
	private void ChangeValue(bool fast, float multiplier) { }

	// RVA: 0x2A4D120 Offset: 0x2A4BB20 VA: 0x182A4D120
	private void UpdateValueLabel() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
