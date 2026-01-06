public class UnsignedLongField : TextValueField<ulong> // TypeDefIndex: 6444
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	private UnsignedLongField.UnsignedLongInput unsignedLongInput { get; }

	// Methods

	// RVA: 0x2E84410 Offset: 0x2E82E10 VA: 0x182E84410
	private UnsignedLongField.UnsignedLongInput get_unsignedLongInput() { }

	// RVA: 0x2E83EB0 Offset: 0x2E828B0 VA: 0x182E83EB0 Slot: 119
	protected override string ValueToString(ulong v) { }

	// RVA: 0x2E83D90 Offset: 0x2E82790 VA: 0x182E83D90 Slot: 120
	protected override ulong StringToValue(string str) { }

	// RVA: 0x2E84250 Offset: 0x2E82C50 VA: 0x182E84250
	public void .ctor() { }

	// RVA: 0x2E84070 Offset: 0x2E82A70 VA: 0x182E84070
	public void .ctor(string label, int maxLength = 1000) { }

	// RVA: 0x2E83D60 Offset: 0x2E82760 VA: 0x182E83D60 Slot: 129
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x2E83C80 Offset: 0x2E82680 VA: 0x182E83C80 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

	// RVA: 0x2E83F50 Offset: 0x2E82950 VA: 0x182E83F50
	private static void .cctor() { }
}
