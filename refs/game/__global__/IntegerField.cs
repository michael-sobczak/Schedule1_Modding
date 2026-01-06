public class IntegerField : TextValueField<int> // TypeDefIndex: 6337
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	private IntegerField.IntegerInput integerInput { get; }

	// Methods

	// RVA: 0x2E61580 Offset: 0x2E5FF80 VA: 0x182E61580
	private IntegerField.IntegerInput get_integerInput() { }

	// RVA: 0x2E61020 Offset: 0x2E5FA20 VA: 0x182E61020 Slot: 119
	protected override string ValueToString(int v) { }

	// RVA: 0x2E60F00 Offset: 0x2E5F900 VA: 0x182E60F00 Slot: 120
	protected override int StringToValue(string str) { }

	// RVA: 0x2E613C0 Offset: 0x2E5FDC0 VA: 0x182E613C0
	public void .ctor() { }

	// RVA: 0x2E611E0 Offset: 0x2E5FBE0 VA: 0x182E611E0
	public void .ctor(string label, int maxLength = 1000) { }

	// RVA: 0x2E60ED0 Offset: 0x2E5F8D0 VA: 0x182E60ED0 Slot: 129
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x2E60DF0 Offset: 0x2E5F7F0 VA: 0x182E60DF0 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x2E610C0 Offset: 0x2E5FAC0 VA: 0x182E610C0
	private static void .cctor() { }
}
