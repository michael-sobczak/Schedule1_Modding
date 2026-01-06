public class DoubleField : TextValueField<double> // TypeDefIndex: 6284
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	private DoubleField.DoubleInput doubleInput { get; }

	// Methods

	// RVA: 0x2DCB0F0 Offset: 0x2DC9AF0 VA: 0x182DCB0F0
	private DoubleField.DoubleInput get_doubleInput() { }

	// RVA: 0x2DCAB90 Offset: 0x2DC9590 VA: 0x182DCAB90 Slot: 119
	protected override string ValueToString(double v) { }

	// RVA: 0x2DCAA70 Offset: 0x2DC9470 VA: 0x182DCAA70 Slot: 120
	protected override double StringToValue(string str) { }

	// RVA: 0x2DCAF30 Offset: 0x2DC9930 VA: 0x182DCAF30
	public void .ctor() { }

	// RVA: 0x2DCAD50 Offset: 0x2DC9750 VA: 0x182DCAD50
	public void .ctor(string label, int maxLength = 1000) { }

	// RVA: 0x2DCAA40 Offset: 0x2DC9440 VA: 0x182DCAA40 Slot: 129
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x2DCA960 Offset: 0x2DC9360 VA: 0x182DCA960 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue) { }

	// RVA: 0x2DCAC30 Offset: 0x2DC9630 VA: 0x182DCAC30
	private static void .cctor() { }
}
