public class UnsignedIntegerField : TextValueField<uint> // TypeDefIndex: 6440
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	private UnsignedIntegerField.UnsignedIntegerInput integerInput { get; }

	// Methods

	// RVA: 0x2E83850 Offset: 0x2E82250 VA: 0x182E83850
	private UnsignedIntegerField.UnsignedIntegerInput get_integerInput() { }

	// RVA: 0x2E832F0 Offset: 0x2E81CF0 VA: 0x182E832F0 Slot: 119
	protected override string ValueToString(uint v) { }

	// RVA: 0x2E831D0 Offset: 0x2E81BD0 VA: 0x182E831D0 Slot: 120
	protected override uint StringToValue(string str) { }

	// RVA: 0x2E83690 Offset: 0x2E82090 VA: 0x182E83690
	public void .ctor() { }

	// RVA: 0x2E834B0 Offset: 0x2E81EB0 VA: 0x182E834B0
	public void .ctor(string label, int maxLength = 1000) { }

	// RVA: 0x2E831A0 Offset: 0x2E81BA0 VA: 0x182E831A0 Slot: 129
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x2E830C0 Offset: 0x2E81AC0 VA: 0x182E830C0 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

	// RVA: 0x2E83390 Offset: 0x2E81D90 VA: 0x182E83390
	private static void .cctor() { }
}
