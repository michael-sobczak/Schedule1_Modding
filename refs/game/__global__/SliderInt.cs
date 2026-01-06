public class SliderInt : BaseSlider<int> // TypeDefIndex: 6416
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	public override float pageSize { get; set; }

	// Methods

	// RVA: 0x2E7D110 Offset: 0x2E7BB10 VA: 0x182E7D110
	public void .ctor() { }

	// RVA: 0x2E7D240 Offset: 0x2E7BC40 VA: 0x182E7D240
	public void .ctor(string label, int start = 0, int end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	// RVA: 0x2E7D3A0 Offset: 0x2E7BDA0 VA: 0x182E7D3A0 Slot: 124
	public override float get_pageSize() { }

	// RVA: 0x2E7D3E0 Offset: 0x2E7BDE0 VA: 0x182E7D3E0 Slot: 125
	public override void set_pageSize(float value) { }

	// RVA: 0x2E7C7E0 Offset: 0x2E7B1E0 VA: 0x182E7C7E0 Slot: 128
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x2E7CF50 Offset: 0x2E7B950 VA: 0x182E7CF50 Slot: 129
	internal override int SliderLerpUnclamped(int a, int b, float interpolant) { }

	// RVA: 0x2E7CFC0 Offset: 0x2E7B9C0 VA: 0x182E7CFC0 Slot: 130
	internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	// RVA: 0x2E7CEA0 Offset: 0x2E7B8A0 VA: 0x182E7CEA0 Slot: 131
	internal override int ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x2E7C940 Offset: 0x2E7B340 VA: 0x182E7C940 Slot: 133
	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: 0x2E7CC60 Offset: 0x2E7B660 VA: 0x182E7CC60 Slot: 132
	internal override void ComputeValueFromKey(BaseSlider.SliderKey<int> sliderKey, bool isShift) { }

	// RVA: 0x2E7CFF0 Offset: 0x2E7B9F0 VA: 0x182E7CFF0
	private static void .cctor() { }
}
