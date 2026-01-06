public class LongField : TextValueField<long> // TypeDefIndex: 6347
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	private LongField.LongInput longInput { get; }

	// Methods

	// RVA: 0x2E63670 Offset: 0x2E62070 VA: 0x182E63670
	private LongField.LongInput get_longInput() { }

	// RVA: 0x2E63110 Offset: 0x2E61B10 VA: 0x182E63110 Slot: 119
	protected override string ValueToString(long v) { }

	// RVA: 0x2E62FF0 Offset: 0x2E619F0 VA: 0x182E62FF0 Slot: 120
	protected override long StringToValue(string str) { }

	// RVA: 0x2E634B0 Offset: 0x2E61EB0 VA: 0x182E634B0
	public void .ctor() { }

	// RVA: 0x2E632D0 Offset: 0x2E61CD0 VA: 0x182E632D0
	public void .ctor(string label, int maxLength = 1000) { }

	// RVA: 0x2E62FC0 Offset: 0x2E619C0 VA: 0x182E62FC0 Slot: 129
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x2E62EE0 Offset: 0x2E618E0 VA: 0x182E62EE0 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

	// RVA: 0x2E631B0 Offset: 0x2E61BB0 VA: 0x182E631B0
	private static void .cctor() { }
}
