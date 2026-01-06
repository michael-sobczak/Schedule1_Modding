public class MinMaxSlider : BaseField<Vector2> // TypeDefIndex: 6351
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <dragElement>k__BackingField; // 0x448
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <dragMinThumb>k__BackingField; // 0x450
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <dragMaxThumb>k__BackingField; // 0x458
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ClampedDragger<float> <clampedDragger>k__BackingField; // 0x460
	private Vector2 m_DragElementStartPos; // 0x468
	private Vector2 m_ValueStartPos; // 0x470
	private Rect m_DragMinThumbRect; // 0x478
	private Rect m_DragMaxThumbRect; // 0x488
	private MinMaxSlider.DragState m_DragState; // 0x498
	private float m_MinLimit; // 0x49C
	private float m_MaxLimit; // 0x4A0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string trackerUssClassName; // 0x18
	public static readonly string draggerUssClassName; // 0x20
	public static readonly string minThumbUssClassName; // 0x28
	public static readonly string maxThumbUssClassName; // 0x30

	// Properties
	internal VisualElement dragElement { get; set; }
	internal VisualElement dragMinThumb { get; set; }
	internal VisualElement dragMaxThumb { get; set; }
	internal ClampedDragger<float> clampedDragger { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public override Vector2 value { get; set; }
	public float lowLimit { get; set; }
	public float highLimit { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x13D8020 Offset: 0x13D6A20 VA: 0x1813D8020
	internal VisualElement get_dragElement() { }

	[CompilerGenerated]
	// RVA: 0x2DE0DA0 Offset: 0x2DDF7A0 VA: 0x182DE0DA0
	private void set_dragElement(VisualElement value) { }

	[CompilerGenerated]
	// RVA: 0x1243710 Offset: 0x1242110 VA: 0x181243710
	internal VisualElement get_dragMinThumb() { }

	[CompilerGenerated]
	// RVA: 0x141A730 Offset: 0x1419130 VA: 0x18141A730
	private void set_dragMinThumb(VisualElement value) { }

	[CompilerGenerated]
	// RVA: 0x1243720 Offset: 0x1242120 VA: 0x181243720
	internal VisualElement get_dragMaxThumb() { }

	[CompilerGenerated]
	// RVA: 0x141A750 Offset: 0x1419150 VA: 0x18141A750
	private void set_dragMaxThumb(VisualElement value) { }

	[CompilerGenerated]
	// RVA: 0x141A540 Offset: 0x1418F40 VA: 0x18141A540
	internal ClampedDragger<float> get_clampedDragger() { }

	[CompilerGenerated]
	// RVA: 0x141A9C0 Offset: 0x14193C0 VA: 0x18141A9C0
	private void set_clampedDragger(ClampedDragger<float> value) { }

	// RVA: 0x2E66300 Offset: 0x2E64D00 VA: 0x182E66300
	public float get_minValue() { }

	// RVA: 0x2E66600 Offset: 0x2E65000 VA: 0x182E66600
	public void set_minValue(float value) { }

	// RVA: 0x2E662D0 Offset: 0x2E64CD0 VA: 0x182E662D0
	public float get_maxValue() { }

	// RVA: 0x2E66570 Offset: 0x2E64F70 VA: 0x182E66570
	public void set_maxValue(float value) { }

	// RVA: 0x2E66330 Offset: 0x2E64D30 VA: 0x182E66330 Slot: 107
	public override Vector2 get_value() { }

	// RVA: 0x2E66690 Offset: 0x2E65090 VA: 0x182E66690 Slot: 108
	public override void set_value(Vector2 value) { }

	// RVA: 0x2E64620 Offset: 0x2E63020 VA: 0x182E64620 Slot: 118
	public override void SetValueWithoutNotify(Vector2 newValue) { }

	// RVA: 0x2E662C0 Offset: 0x2E64CC0 VA: 0x182E662C0
	public float get_lowLimit() { }

	// RVA: 0x2E66470 Offset: 0x2E64E70 VA: 0x182E66470
	public void set_lowLimit(float value) { }

	// RVA: 0x2E662B0 Offset: 0x2E64CB0 VA: 0x182E662B0
	public float get_highLimit() { }

	// RVA: 0x2E66370 Offset: 0x2E64D70 VA: 0x182E66370
	public void set_highLimit(float value) { }

	// RVA: 0x2E65B50 Offset: 0x2E64550 VA: 0x182E65B50
	public void .ctor() { }

	// RVA: 0x2E65B90 Offset: 0x2E64590 VA: 0x182E65B90
	public void .ctor(string label, float minValue = 0, float maxValue = 10, float minLimit = -3.4028235E+38, float maxLimit = 3.4028235E+38) { }

	// RVA: 0x2E63BD0 Offset: 0x2E625D0 VA: 0x182E63BD0
	private Vector2 ClampValues(Vector2 valueToClamp) { }

	// RVA: 0x2E65490 Offset: 0x2E63E90 VA: 0x182E65490
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x2E64800 Offset: 0x2E63200 VA: 0x182E64800
	private void UpdateDragElementPosition() { }

	// RVA: 0x2E65500 Offset: 0x2E63F00 VA: 0x182E65500
	private void UpdateDragThumbsRect() { }

	// RVA: 0x2E64690 Offset: 0x2E63090 VA: 0x182E64690
	internal float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x2E646B0 Offset: 0x2E630B0 VA: 0x182E646B0
	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x2E63E80 Offset: 0x2E62880 VA: 0x182E63E80
	private float ComputeValueFromPosition(float positionToConvert) { }

	[EventInterest(new[] { typeof(GeometryChangedEvent) })]
	// RVA: 0x2E63FC0 Offset: 0x2E629C0 VA: 0x182E63FC0 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2E64590 Offset: 0x2E62F90 VA: 0x182E64590
	private void SetSliderValueFromDrag() { }

	// RVA: 0x2E64230 Offset: 0x2E62C30 VA: 0x182E64230
	private void SetSliderValueFromClick() { }

	// RVA: 0x2E63C60 Offset: 0x2E62660 VA: 0x182E63C60
	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 117
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x2E64100 Offset: 0x2E62B00 VA: 0x182E64100 Slot: 115
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x2E646D0 Offset: 0x2E630D0 VA: 0x182E646D0 Slot: 116
	internal override void UnregisterEditingCallbacks() { }

	// RVA: 0x2E658D0 Offset: 0x2E642D0 VA: 0x182E658D0
	private static void .cctor() { }
}
