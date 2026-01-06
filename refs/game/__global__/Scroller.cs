public class Scroller : VisualElement // TypeDefIndex: 6402
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<float> valueChanged; // 0x3C8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Slider <slider>k__BackingField; // 0x3D0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RepeatButton <lowButton>k__BackingField; // 0x3D8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private RepeatButton <highButton>k__BackingField; // 0x3E0
	public static readonly string ussClassName; // 0x0
	public static readonly string horizontalVariantUssClassName; // 0x8
	public static readonly string verticalVariantUssClassName; // 0x10
	public static readonly string sliderUssClassName; // 0x18
	public static readonly string lowButtonUssClassName; // 0x20
	public static readonly string highButtonUssClassName; // 0x28

	// Properties
	public Slider slider { get; set; }
	public RepeatButton lowButton { get; set; }
	public RepeatButton highButton { get; set; }
	public float value { get; set; }
	public float lowValue { get; set; }
	public float highValue { get; set; }
	public SliderDirection direction { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E7C2B0 Offset: 0x2E7ACB0 VA: 0x182E7C2B0
	public void add_valueChanged(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0x2E7C440 Offset: 0x2E7AE40 VA: 0x182E7C440
	public void remove_valueChanged(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240
	public Slider get_slider() { }

	[CompilerGenerated]
	// RVA: 0x67A2C0 Offset: 0x678CC0 VA: 0x18067A2C0
	private void set_slider(Slider value) { }

	[CompilerGenerated]
	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290
	public RepeatButton get_lowButton() { }

	[CompilerGenerated]
	// RVA: 0x67A2A0 Offset: 0x678CA0 VA: 0x18067A2A0
	private void set_lowButton(RepeatButton value) { }

	[CompilerGenerated]
	// RVA: 0x67A250 Offset: 0x678C50 VA: 0x18067A250
	public RepeatButton get_highButton() { }

	[CompilerGenerated]
	// RVA: 0x2E7C6D0 Offset: 0x2E7B0D0 VA: 0x182E7C6D0
	private void set_highButton(RepeatButton value) { }

	// RVA: 0x2E7C410 Offset: 0x2E7AE10 VA: 0x182E7C410
	public float get_value() { }

	// RVA: 0x2E7C7B0 Offset: 0x2E7B1B0 VA: 0x182E7C7B0
	public void set_value(float value) { }

	// RVA: 0x2E7C3C0 Offset: 0x2E7ADC0 VA: 0x182E7C3C0
	public float get_lowValue() { }

	// RVA: 0x2E7C750 Offset: 0x2E7B150 VA: 0x182E7C750
	public void set_lowValue(float value) { }

	// RVA: 0x2E7C370 Offset: 0x2E7AD70 VA: 0x182E7C370
	public float get_highValue() { }

	// RVA: 0x2E7C6F0 Offset: 0x2E7B0F0 VA: 0x182E7C6F0
	public void set_highValue(float value) { }

	// RVA: 0x2E7C500 Offset: 0x2E7AF00 VA: 0x182E7C500
	public void set_direction(SliderDirection value) { }

	// RVA: 0x2E7BE40 Offset: 0x2E7A840 VA: 0x182E7BE40
	public void .ctor() { }

	// RVA: 0x2E7BE70 Offset: 0x2E7A870 VA: 0x182E7BE70
	public void .ctor(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = 1) { }

	// RVA: 0x2E7B610 Offset: 0x2E7A010 VA: 0x182E7B610
	public void Adjust(float factor) { }

	// RVA: 0x2E7B690 Offset: 0x2E7A090 VA: 0x182E7B690
	private void OnSliderValueChange(ChangeEvent<float> evt) { }

	// RVA: 0x2E7BAF0 Offset: 0x2E7A4F0 VA: 0x182E7BAF0
	public void ScrollPageUp() { }

	// RVA: 0x2E7B890 Offset: 0x2E7A290 VA: 0x182E7B890
	public void ScrollPageDown() { }

	// RVA: 0x2E7B9B0 Offset: 0x2E7A3B0 VA: 0x182E7B9B0
	public void ScrollPageUp(float factor) { }

	// RVA: 0x2E7B750 Offset: 0x2E7A150 VA: 0x182E7B750
	public void ScrollPageDown(float factor) { }

	// RVA: 0x2E7BC20 Offset: 0x2E7A620 VA: 0x182E7BC20
	private static void .cctor() { }
}
