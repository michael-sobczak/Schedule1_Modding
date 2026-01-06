public class FloatField : TextValueField<float> // TypeDefIndex: 6296
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	private FloatField.FloatInput floatInput { get; }

	// Methods

	// RVA: 0x2DCD540 Offset: 0x2DCBF40 VA: 0x182DCD540
	private FloatField.FloatInput get_floatInput() { }

	// RVA: 0x2DCCFE0 Offset: 0x2DCB9E0 VA: 0x182DCCFE0 Slot: 119
	protected override string ValueToString(float v) { }

	// RVA: 0x2DCCEC0 Offset: 0x2DCB8C0 VA: 0x182DCCEC0 Slot: 120
	protected override float StringToValue(string str) { }

	// RVA: 0x2DCD1A0 Offset: 0x2DCBBA0 VA: 0x182DCD1A0
	public void .ctor() { }

	// RVA: 0x2DCD360 Offset: 0x2DCBD60 VA: 0x182DCD360
	public void .ctor(string label, int maxLength = 1000) { }

	// RVA: 0x2DCCE90 Offset: 0x2DCB890 VA: 0x182DCCE90 Slot: 129
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x2DCCDB0 Offset: 0x2DCB7B0 VA: 0x182DCCDB0 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x2DCD080 Offset: 0x2DCBA80 VA: 0x182DCD080
	private static void .cctor() { }
}
