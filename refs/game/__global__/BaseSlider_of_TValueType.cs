public abstract class BaseSlider<TValueType> : BaseField<TValueType>, IValueField<TValueType> // TypeDefIndex: 6224
{
	// Fields
	private float m_AdjustedPageSizeFromClick; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <dragContainer>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <dragElement>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <trackElement>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <dragBorderElement>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextField <inputTextField>k__BackingField; // 0x0
	private bool m_IsEditingTextField; // 0x0
	[SerializeField]
	private TValueType m_LowValue; // 0x0
	[SerializeField]
	private TValueType m_HighValue; // 0x0
	private float m_PageSize; // 0x0
	private bool m_ShowInputField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <clamped>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ClampedDragger<TValueType> <clampedDragger>k__BackingField; // 0x0
	private Rect m_DragElementStartPos; // 0x0
	private SliderDirection m_Direction; // 0x0
	private bool m_Inverted; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	public static readonly string horizontalVariantUssClassName; // 0x0
	public static readonly string verticalVariantUssClassName; // 0x0
	public static readonly string dragContainerUssClassName; // 0x0
	public static readonly string trackerUssClassName; // 0x0
	public static readonly string draggerUssClassName; // 0x0
	public static readonly string draggerBorderUssClassName; // 0x0
	public static readonly string textFieldClassName; // 0x0

	// Properties
	internal VisualElement dragContainer { get; set; }
	internal VisualElement dragElement { get; set; }
	internal VisualElement trackElement { get; set; }
	internal VisualElement dragBorderElement { get; set; }
	internal TextField inputTextField { get; set; }
	internal override bool canSwitchToMixedValue { get; }
	public TValueType lowValue { get; set; }
	public TValueType highValue { get; set; }
	public virtual float pageSize { get; set; }
	public virtual bool showInputField { get; set; }
	internal bool clamped { get; set; }
	internal ClampedDragger<TValueType> clampedDragger { get; set; }
	public override TValueType value { get; set; }
	public SliderDirection direction { get; set; }
	public bool inverted { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal VisualElement get_dragContainer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243710 Offset: 0x1242110 VA: 0x181243710
	|-BaseSlider<int>.get_dragContainer
	|-BaseSlider<float>.get_dragContainer
	|
	|-RVA: 0xFF0CD0 Offset: 0xFEF6D0 VA: 0x180FF0CD0
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_dragContainer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_dragContainer(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A730 Offset: 0x1419130 VA: 0x18141A730
	|-BaseSlider<int>.set_dragContainer
	|-BaseSlider<float>.set_dragContainer
	|
	|-RVA: 0x1424F80 Offset: 0x1423980 VA: 0x181424F80
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_dragContainer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal VisualElement get_dragElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243720 Offset: 0x1242120 VA: 0x181243720
	|-BaseSlider<int>.get_dragElement
	|-BaseSlider<float>.get_dragElement
	|
	|-RVA: 0x129F560 Offset: 0x129DF60 VA: 0x18129F560
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_dragElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_dragElement(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A750 Offset: 0x1419150 VA: 0x18141A750
	|-BaseSlider<int>.set_dragElement
	|-BaseSlider<float>.set_dragElement
	|
	|-RVA: 0x129F780 Offset: 0x129E180 VA: 0x18129F780
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_dragElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal VisualElement get_trackElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A540 Offset: 0x1418F40 VA: 0x18141A540
	|-BaseSlider<int>.get_trackElement
	|-BaseSlider<float>.get_trackElement
	|
	|-RVA: 0x125FF20 Offset: 0x125E920 VA: 0x18125FF20
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_trackElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_trackElement(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A9C0 Offset: 0x14193C0 VA: 0x18141A9C0
	|-BaseSlider<int>.set_trackElement
	|-BaseSlider<float>.set_trackElement
	|
	|-RVA: 0x1425870 Offset: 0x1424270 VA: 0x181425870
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_trackElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal VisualElement get_dragBorderElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A4D0 Offset: 0x1418ED0 VA: 0x18141A4D0
	|-BaseSlider<int>.get_dragBorderElement
	|-BaseSlider<float>.get_dragBorderElement
	|
	|-RVA: 0x12F3220 Offset: 0x12F1C20 VA: 0x1812F3220
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_dragBorderElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_dragBorderElement(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A710 Offset: 0x1419110 VA: 0x18141A710
	|-BaseSlider<int>.set_dragBorderElement
	|-BaseSlider<float>.set_dragBorderElement
	|
	|-RVA: 0x12F3700 Offset: 0x12F2100 VA: 0x1812F3700
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_dragBorderElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal TextField get_inputTextField() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A4F0 Offset: 0x1418EF0 VA: 0x18141A4F0
	|-BaseSlider<int>.get_inputTextField
	|-BaseSlider<float>.get_inputTextField
	|
	|-RVA: 0x1424990 Offset: 0x1423390 VA: 0x181424990
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_inputTextField
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_inputTextField(TextField value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A850 Offset: 0x1419250 VA: 0x18141A850
	|-BaseSlider<int>.set_inputTextField
	|-BaseSlider<float>.set_inputTextField
	|
	|-RVA: 0x14252D0 Offset: 0x1423CD0 VA: 0x1814252D0
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_inputTextField
	*/

	// RVA: -1 Offset: -1 Slot: 113
	internal override bool get_canSwitchToMixedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A390 Offset: 0x1418D90 VA: 0x18141A390
	|-BaseSlider<int>.get_canSwitchToMixedValue
	|
	|-RVA: 0x1424560 Offset: 0x1422F60 VA: 0x181424560
	|-BaseSlider<float>.get_canSwitchToMixedValue
	|
	|-RVA: 0x1424670 Offset: 0x1423070 VA: 0x181424670
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_canSwitchToMixedValue
	*/

	// RVA: -1 Offset: -1
	public TValueType get_lowValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A510 Offset: 0x1418F10 VA: 0x18141A510
	|-BaseSlider<int>.get_lowValue
	|
	|-RVA: 0x1424B00 Offset: 0x1423500 VA: 0x181424B00
	|-BaseSlider<float>.get_lowValue
	|
	|-RVA: 0x14249F0 Offset: 0x14233F0 VA: 0x1814249F0
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_lowValue
	*/

	// RVA: -1 Offset: -1
	public void set_lowValue(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A8A0 Offset: 0x14192A0 VA: 0x18141A8A0
	|-BaseSlider<int>.set_lowValue
	|
	|-RVA: 0x1425630 Offset: 0x1424030 VA: 0x181425630
	|-BaseSlider<float>.set_lowValue
	|
	|-RVA: 0x1425430 Offset: 0x1423E30 VA: 0x181425430
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_lowValue
	*/

	// RVA: -1 Offset: -1
	public TValueType get_highValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A4E0 Offset: 0x1418EE0 VA: 0x18141A4E0
	|-BaseSlider<int>.get_highValue
	|
	|-RVA: 0x1424870 Offset: 0x1423270 VA: 0x181424870
	|-BaseSlider<float>.get_highValue
	|
	|-RVA: 0x1424880 Offset: 0x1423280 VA: 0x181424880
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_highValue
	*/

	// RVA: -1 Offset: -1
	public void set_highValue(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A770 Offset: 0x1419170 VA: 0x18141A770
	|-BaseSlider<int>.set_highValue
	|
	|-RVA: 0x14251F0 Offset: 0x1423BF0 VA: 0x1814251F0
	|-BaseSlider<float>.set_highValue
	|
	|-RVA: 0x1424FF0 Offset: 0x14239F0 VA: 0x181424FF0
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_highValue
	*/

	// RVA: -1 Offset: -1
	internal void SetHighValueWithoutNotify(TValueType newHighValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14178F0 Offset: 0x14162F0 VA: 0x1814178F0
	|-BaseSlider<int>.SetHighValueWithoutNotify
	|
	|-RVA: 0x141DA60 Offset: 0x141C460 VA: 0x18141DA60
	|-BaseSlider<float>.SetHighValueWithoutNotify
	|
	|-RVA: 0x141DB00 Offset: 0x141C500 VA: 0x18141DB00
	|-BaseSlider<__Il2CppFullySharedGenericType>.SetHighValueWithoutNotify
	*/

	// RVA: -1 Offset: -1 Slot: 124
	public virtual float get_pageSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A520 Offset: 0x1418F20 VA: 0x18141A520
	|-BaseSlider<int>.get_pageSize
	|-BaseSlider<float>.get_pageSize
	|
	|-RVA: 0x1424B10 Offset: 0x1423510 VA: 0x181424B10
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_pageSize
	*/

	// RVA: -1 Offset: -1 Slot: 125
	public virtual void set_pageSize(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A980 Offset: 0x1419380 VA: 0x18141A980
	|-BaseSlider<int>.set_pageSize
	|-BaseSlider<float>.set_pageSize
	|
	|-RVA: 0x1425710 Offset: 0x1424110 VA: 0x181425710
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_pageSize
	*/

	// RVA: -1 Offset: -1 Slot: 126
	public virtual bool get_showInputField() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A530 Offset: 0x1418F30 VA: 0x18141A530
	|-BaseSlider<int>.get_showInputField
	|-BaseSlider<float>.get_showInputField
	|
	|-RVA: 0x1424B40 Offset: 0x1423540 VA: 0x181424B40
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_showInputField
	*/

	// RVA: -1 Offset: -1 Slot: 127
	public virtual void set_showInputField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A990 Offset: 0x1419390 VA: 0x18141A990
	|-BaseSlider<int>.set_showInputField
	|
	|-RVA: 0x1425780 Offset: 0x1424180 VA: 0x181425780
	|-BaseSlider<float>.set_showInputField
	|
	|-RVA: 0x14257B0 Offset: 0x14241B0 VA: 0x1814257B0
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_showInputField
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal bool get_clamped() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A4B0 Offset: 0x1418EB0 VA: 0x18141A4B0
	|-BaseSlider<int>.get_clamped
	|-BaseSlider<float>.get_clamped
	|
	|-RVA: 0x1424810 Offset: 0x1423210 VA: 0x181424810
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_clamped
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_clamped(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A5A0 Offset: 0x1418FA0 VA: 0x18141A5A0
	|-BaseSlider<int>.set_clamped
	|-BaseSlider<float>.set_clamped
	|
	|-RVA: 0x1424D10 Offset: 0x1423710 VA: 0x181424D10
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_clamped
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal ClampedDragger<TValueType> get_clampedDragger() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A4A0 Offset: 0x1418EA0 VA: 0x18141A4A0
	|-BaseSlider<int>.get_clampedDragger
	|-BaseSlider<float>.get_clampedDragger
	|
	|-RVA: 0x14247E0 Offset: 0x14231E0 VA: 0x1814247E0
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_clampedDragger
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_clampedDragger(ClampedDragger<TValueType> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A580 Offset: 0x1418F80 VA: 0x18141A580
	|-BaseSlider<int>.set_clampedDragger
	|-BaseSlider<float>.set_clampedDragger
	|
	|-RVA: 0x1424CA0 Offset: 0x14236A0 VA: 0x181424CA0
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_clampedDragger
	*/

	// RVA: -1 Offset: -1
	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416C00 Offset: 0x1415600 VA: 0x181416C00
	|-BaseSlider<int>.Clamp
	|
	|-RVA: 0x141B840 Offset: 0x141A240 VA: 0x18141B840
	|-BaseSlider<float>.Clamp
	|
	|-RVA: 0x141B440 Offset: 0x1419E40 VA: 0x18141B440
	|-BaseSlider<__Il2CppFullySharedGenericType>.Clamp
	*/

	// RVA: -1 Offset: -1
	private TValueType GetClampedValue(TValueType newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417120 Offset: 0x1415B20 VA: 0x181417120
	|-BaseSlider<int>.GetClampedValue
	|
	|-RVA: 0x141C5F0 Offset: 0x141AFF0 VA: 0x18141C5F0
	|-BaseSlider<float>.GetClampedValue
	|
	|-RVA: 0x141C700 Offset: 0x141B100 VA: 0x18141C700
	|-BaseSlider<__Il2CppFullySharedGenericType>.GetClampedValue
	*/

	// RVA: -1 Offset: -1 Slot: 107
	public override TValueType get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A550 Offset: 0x1418F50 VA: 0x18141A550
	|-BaseSlider<int>.get_value
	|
	|-RVA: 0x1424C70 Offset: 0x1423670 VA: 0x181424C70
	|-BaseSlider<float>.get_value
	|
	|-RVA: 0x1424B70 Offset: 0x1423570 VA: 0x181424B70
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 108
	public override void set_value(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A9E0 Offset: 0x14193E0 VA: 0x18141A9E0
	|-BaseSlider<int>.set_value
	|
	|-RVA: 0x14258E0 Offset: 0x14242E0 VA: 0x1814258E0
	|-BaseSlider<float>.set_value
	|
	|-RVA: 0x1425940 Offset: 0x1424340 VA: 0x181425940
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1 Slot: 128
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-BaseSlider<int>.ApplyInputDeviceDelta
	|-BaseSlider<float>.ApplyInputDeviceDelta
	|-BaseSlider<__Il2CppFullySharedGenericType>.ApplyInputDeviceDelta
	*/

	// RVA: -1 Offset: -1 Slot: 122
	private void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-BaseSlider<int>.UnityEngine.UIElements.IValueField<TValueType>.StartDragging
	|-BaseSlider<float>.UnityEngine.UIElements.IValueField<TValueType>.StartDragging
	|-BaseSlider<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.IValueField<TValueType>.StartDragging
	*/

	// RVA: -1 Offset: -1 Slot: 123
	private void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-BaseSlider<int>.UnityEngine.UIElements.IValueField<TValueType>.StopDragging
	|-BaseSlider<float>.UnityEngine.UIElements.IValueField<TValueType>.StopDragging
	|-BaseSlider<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.IValueField<TValueType>.StopDragging
	*/

	// RVA: -1 Offset: -1 Slot: 118
	public override void SetValueWithoutNotify(TValueType newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14182A0 Offset: 0x1416CA0 VA: 0x1814182A0
	|-BaseSlider<int>.SetValueWithoutNotify
	|
	|-RVA: 0x141F540 Offset: 0x141DF40 VA: 0x18141F540
	|-BaseSlider<float>.SetValueWithoutNotify
	|
	|-RVA: 0x141F5D0 Offset: 0x141DFD0 VA: 0x18141F5D0
	|-BaseSlider<__Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/

	// RVA: -1 Offset: -1
	public SliderDirection get_direction() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A4C0 Offset: 0x1418EC0 VA: 0x18141A4C0
	|-BaseSlider<int>.get_direction
	|-BaseSlider<float>.get_direction
	|
	|-RVA: 0x1424840 Offset: 0x1423240 VA: 0x181424840
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_direction
	*/

	// RVA: -1 Offset: -1
	public void set_direction(SliderDirection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A5B0 Offset: 0x1418FB0 VA: 0x18141A5B0
	|-BaseSlider<int>.set_direction
	|-BaseSlider<float>.set_direction
	|
	|-RVA: 0x1424D80 Offset: 0x1423780 VA: 0x181424D80
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_direction
	*/

	// RVA: -1 Offset: -1
	public bool get_inverted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A500 Offset: 0x1418F00 VA: 0x18141A500
	|-BaseSlider<int>.get_inverted
	|-BaseSlider<float>.get_inverted
	|
	|-RVA: 0x14249C0 Offset: 0x14233C0 VA: 0x1814249C0
	|-BaseSlider<__Il2CppFullySharedGenericType>.get_inverted
	*/

	// RVA: -1 Offset: -1
	public void set_inverted(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141A870 Offset: 0x1419270 VA: 0x18141A870
	|-BaseSlider<int>.set_inverted
	|
	|-RVA: 0x1425400 Offset: 0x1423E00 VA: 0x181425400
	|-BaseSlider<float>.set_inverted
	|
	|-RVA: 0x1425340 Offset: 0x1423D40 VA: 0x181425340
	|-BaseSlider<__Il2CppFullySharedGenericType>.set_inverted
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(string label, TValueType start, TValueType end, SliderDirection direction = 0, float pageSize = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1419970 Offset: 0x1418370 VA: 0x181419970
	|-BaseSlider<int>..ctor
	|
	|-RVA: 0x1423B20 Offset: 0x1422520 VA: 0x181423B20
	|-BaseSlider<float>..ctor
	|
	|-RVA: 0x1422D00 Offset: 0x1421700 VA: 0x181422D00
	|-BaseSlider<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected static float GetClosestPowerOfTen(float positiveNumber) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417200 Offset: 0x1415C00 VA: 0x181417200
	|-BaseSlider<int>.GetClosestPowerOfTen
	|
	|-RVA: 0x141CB60 Offset: 0x141B560 VA: 0x18141CB60
	|-BaseSlider<float>.GetClosestPowerOfTen
	|-BaseSlider<__Il2CppFullySharedGenericType>.GetClosestPowerOfTen
	*/

	// RVA: -1 Offset: -1
	protected static float RoundToMultipleOf(float value, float roundingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14178A0 Offset: 0x14162A0 VA: 0x1814178A0
	|-BaseSlider<int>.RoundToMultipleOf
	|-BaseSlider<float>.RoundToMultipleOf
	|-BaseSlider<__Il2CppFullySharedGenericType>.RoundToMultipleOf
	*/

	// RVA: -1 Offset: -1
	private void ClampValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416BB0 Offset: 0x14155B0 VA: 0x181416BB0
	|-BaseSlider<int>.ClampValue
	|
	|-RVA: 0x141B3F0 Offset: 0x1419DF0 VA: 0x18141B3F0
	|-BaseSlider<float>.ClampValue
	|
	|-RVA: 0x141B300 Offset: 0x1419D00 VA: 0x18141B300
	|-BaseSlider<__Il2CppFullySharedGenericType>.ClampValue
	*/

	// RVA: -1 Offset: -1 Slot: 129
	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseSlider<__Il2CppFullySharedGenericType>.SliderLerpUnclamped
	*/

	// RVA: -1 Offset: -1 Slot: 130
	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseSlider<__Il2CppFullySharedGenericType>.SliderNormalizeValue
	*/

	// RVA: -1 Offset: -1 Slot: 131
	internal abstract TValueType ParseStringToValue(string previousValue, string newValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseSlider<__Il2CppFullySharedGenericType>.ParseStringToValue
	*/

	// RVA: -1 Offset: -1 Slot: 132
	internal abstract void ComputeValueFromKey(BaseSlider.SliderKey<TValueType> sliderKey, bool isShift);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseSlider<__Il2CppFullySharedGenericType>.ComputeValueFromKey
	*/

	// RVA: -1 Offset: -1
	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418330 Offset: 0x1416D30 VA: 0x181418330
	|-BaseSlider<int>.SliderLerpDirectionalUnclamped
	|
	|-RVA: 0x141FAA0 Offset: 0x141E4A0 VA: 0x18141FAA0
	|-BaseSlider<float>.SliderLerpDirectionalUnclamped
	|
	|-RVA: 0x141F820 Offset: 0x141E220 VA: 0x18141F820
	|-BaseSlider<__Il2CppFullySharedGenericType>.SliderLerpDirectionalUnclamped
	*/

	// RVA: -1 Offset: -1
	private void SetSliderValueFromDrag() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418100 Offset: 0x1416B00 VA: 0x181418100
	|-BaseSlider<int>.SetSliderValueFromDrag
	|
	|-RVA: 0x141F0E0 Offset: 0x141DAE0 VA: 0x18141F0E0
	|-BaseSlider<float>.SetSliderValueFromDrag
	|
	|-RVA: 0x141F280 Offset: 0x141DC80 VA: 0x18141F280
	|-BaseSlider<__Il2CppFullySharedGenericType>.SetSliderValueFromDrag
	*/

	// RVA: -1 Offset: -1
	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416EE0 Offset: 0x14158E0 VA: 0x181416EE0
	|-BaseSlider<int>.ComputeValueAndDirectionFromDrag
	|
	|-RVA: 0x141C270 Offset: 0x141AC70 VA: 0x18141C270
	|-BaseSlider<float>.ComputeValueAndDirectionFromDrag
	|
	|-RVA: 0x141C030 Offset: 0x141AA30 VA: 0x18141C030
	|-BaseSlider<__Il2CppFullySharedGenericType>.ComputeValueAndDirectionFromDrag
	*/

	// RVA: -1 Offset: -1
	private void SetSliderValueFromClick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417990 Offset: 0x1416390 VA: 0x181417990
	|-BaseSlider<int>.SetSliderValueFromClick
	|
	|-RVA: 0x141E9D0 Offset: 0x141D3D0 VA: 0x18141E9D0
	|-BaseSlider<float>.SetSliderValueFromClick
	|
	|-RVA: 0x141DD80 Offset: 0x141C780 VA: 0x18141DD80
	|-BaseSlider<__Il2CppFullySharedGenericType>.SetSliderValueFromClick
	*/

	// RVA: -1 Offset: -1
	private void OnKeyDown(KeyDownEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417310 Offset: 0x1415D10 VA: 0x181417310
	|-BaseSlider<int>.OnKeyDown
	|
	|-RVA: 0x141CBB0 Offset: 0x141B5B0 VA: 0x18141CBB0
	|-BaseSlider<float>.OnKeyDown
	|
	|-RVA: 0x141CD10 Offset: 0x141B710 VA: 0x18141CD10
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnKeyDown
	*/

	// RVA: -1 Offset: -1
	private void OnNavigationMove(NavigationMoveEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417470 Offset: 0x1415E70 VA: 0x181417470
	|-BaseSlider<int>.OnNavigationMove
	|
	|-RVA: 0x141CEF0 Offset: 0x141B8F0 VA: 0x18141CEF0
	|-BaseSlider<float>.OnNavigationMove
	|
	|-RVA: 0x141CFD0 Offset: 0x141B9D0 VA: 0x18141CFD0
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnNavigationMove
	*/

	// RVA: -1 Offset: -1 Slot: 133
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416C90 Offset: 0x1415690 VA: 0x181416C90
	|-BaseSlider<int>.ComputeValueAndDirectionFromClick
	|
	|-RVA: 0x141B8E0 Offset: 0x141A2E0 VA: 0x18141B8E0
	|-BaseSlider<float>.ComputeValueAndDirectionFromClick
	|
	|-RVA: 0x141BB20 Offset: 0x141A520 VA: 0x18141BB20
	|-BaseSlider<__Il2CppFullySharedGenericType>.ComputeValueAndDirectionFromClick
	*/

	// RVA: -1 Offset: -1
	public void AdjustDragElement(float factor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416750 Offset: 0x1415150 VA: 0x181416750
	|-BaseSlider<int>.AdjustDragElement
	|
	|-RVA: 0x141AA40 Offset: 0x1419440 VA: 0x18141AA40
	|-BaseSlider<float>.AdjustDragElement
	|
	|-RVA: 0x141AE30 Offset: 0x1419830 VA: 0x18141AE30
	|-BaseSlider<__Il2CppFullySharedGenericType>.AdjustDragElement
	*/

	// RVA: -1 Offset: -1
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418950 Offset: 0x1417350 VA: 0x181418950
	|-BaseSlider<int>.UpdateDragElementPosition
	|
	|-RVA: 0x1420A40 Offset: 0x141F440 VA: 0x181420A40
	|-BaseSlider<float>.UpdateDragElementPosition
	|
	|-RVA: 0x141FE40 Offset: 0x141E840 VA: 0x18141FE40
	|-BaseSlider<__Il2CppFullySharedGenericType>.UpdateDragElementPosition
	*/

	// RVA: -1 Offset: -1 Slot: 96
	internal override void OnViewDataReady() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14176C0 Offset: 0x14160C0 VA: 0x1814176C0
	|-BaseSlider<int>.OnViewDataReady
	|
	|-RVA: 0x141D6B0 Offset: 0x141C0B0 VA: 0x18141D6B0
	|-BaseSlider<float>.OnViewDataReady
	|
	|-RVA: 0x141D650 Offset: 0x141C050 VA: 0x18141D650
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnViewDataReady
	*/

	// RVA: -1 Offset: -1
	private bool SameValues(float a, float b, float epsilon) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14178D0 Offset: 0x14162D0 VA: 0x1814178D0
	|-BaseSlider<int>.SameValues
	|-BaseSlider<float>.SameValues
	|-BaseSlider<__Il2CppFullySharedGenericType>.SameValues
	*/

	// RVA: -1 Offset: -1
	private void UpdateDragElementPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418500 Offset: 0x1416F00 VA: 0x181418500
	|-BaseSlider<int>.UpdateDragElementPosition
	|
	|-RVA: 0x141FEC0 Offset: 0x141E8C0 VA: 0x18141FEC0
	|-BaseSlider<float>.UpdateDragElementPosition
	|
	|-RVA: 0x1420310 Offset: 0x141ED10 VA: 0x181420310
	|-BaseSlider<__Il2CppFullySharedGenericType>.UpdateDragElementPosition
	*/

	[EventInterest(new[] { typeof(GeometryChangedEvent) })]
	// RVA: -1 Offset: -1 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416FA0 Offset: 0x14159A0 VA: 0x181416FA0
	|-BaseSlider<int>.ExecuteDefaultAction
	|
	|-RVA: 0x141C340 Offset: 0x141AD40 VA: 0x18141C340
	|-BaseSlider<float>.ExecuteDefaultAction
	|
	|-RVA: 0x141C4C0 Offset: 0x141AEC0 VA: 0x18141C4C0
	|-BaseSlider<__Il2CppFullySharedGenericType>.ExecuteDefaultAction
	*/

	// RVA: -1 Offset: -1
	private void UpdateTextFieldVisibility() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418B90 Offset: 0x1417590 VA: 0x181418B90
	|-BaseSlider<int>.UpdateTextFieldVisibility
	|
	|-RVA: 0x1421660 Offset: 0x1420060 VA: 0x181421660
	|-BaseSlider<float>.UpdateTextFieldVisibility
	|
	|-RVA: 0x1420FD0 Offset: 0x141F9D0 VA: 0x181420FD0
	|-BaseSlider<__Il2CppFullySharedGenericType>.UpdateTextFieldVisibility
	*/

	// RVA: -1 Offset: -1
	private void UpdateTextFieldValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418A90 Offset: 0x1417490 VA: 0x181418A90
	|-BaseSlider<int>.UpdateTextFieldValue
	|
	|-RVA: 0x1420ED0 Offset: 0x141F8D0 VA: 0x181420ED0
	|-BaseSlider<float>.UpdateTextFieldValue
	|
	|-RVA: 0x1420D20 Offset: 0x141F720 VA: 0x181420D20
	|-BaseSlider<__Il2CppFullySharedGenericType>.UpdateTextFieldValue
	*/

	// RVA: -1 Offset: -1
	private void OnTextFieldFocusIn(FocusInEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417550 Offset: 0x1415F50 VA: 0x181417550
	|-BaseSlider<int>.OnTextFieldFocusIn
	|-BaseSlider<float>.OnTextFieldFocusIn
	|
	|-RVA: 0x141D0F0 Offset: 0x141BAF0 VA: 0x18141D0F0
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnTextFieldFocusIn
	*/

	// RVA: -1 Offset: -1
	private void OnTextFieldFocusOut(FocusOutEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417560 Offset: 0x1415F60 VA: 0x181417560
	|-BaseSlider<int>.OnTextFieldFocusOut
	|
	|-RVA: 0x141D1F0 Offset: 0x141BBF0 VA: 0x18141D1F0
	|-BaseSlider<float>.OnTextFieldFocusOut
	|
	|-RVA: 0x141D160 Offset: 0x141BB60 VA: 0x18141D160
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnTextFieldFocusOut
	*/

	// RVA: -1 Offset: -1
	private void OnInputNavigationMoveEvent(NavigationMoveEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12333F0 Offset: 0x1231DF0 VA: 0x1812333F0
	|-BaseSlider<int>.OnInputNavigationMoveEvent
	|-BaseSlider<float>.OnInputNavigationMoveEvent
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnInputNavigationMoveEvent
	*/

	// RVA: -1 Offset: -1
	private void OnTextFieldValueChange(ChangeEvent<string> evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417580 Offset: 0x1415F80 VA: 0x181417580
	|-BaseSlider<int>.OnTextFieldValueChange
	|
	|-RVA: 0x141D210 Offset: 0x141BC10 VA: 0x18141D210
	|-BaseSlider<float>.OnTextFieldValueChange
	|
	|-RVA: 0x141D350 Offset: 0x141BD50 VA: 0x18141D350
	|-BaseSlider<__Il2CppFullySharedGenericType>.OnTextFieldValueChange
	*/

	// RVA: -1 Offset: -1 Slot: 117
	protected override void UpdateMixedValueContent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14189D0 Offset: 0x14173D0 VA: 0x1814189D0
	|-BaseSlider<int>.UpdateMixedValueContent
	|
	|-RVA: 0x1420C60 Offset: 0x141F660 VA: 0x181420C60
	|-BaseSlider<float>.UpdateMixedValueContent
	|
	|-RVA: 0x1420AC0 Offset: 0x141F4C0 VA: 0x181420AC0
	|-BaseSlider<__Il2CppFullySharedGenericType>.UpdateMixedValueContent
	*/

	// RVA: -1 Offset: -1 Slot: 115
	internal override void RegisterEditingCallbacks() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1417720 Offset: 0x1416120 VA: 0x181417720
	|-BaseSlider<int>.RegisterEditingCallbacks
	|
	|-RVA: 0x141D8E0 Offset: 0x141C2E0 VA: 0x18141D8E0
	|-BaseSlider<float>.RegisterEditingCallbacks
	|
	|-RVA: 0x141D710 Offset: 0x141C110 VA: 0x18141D710
	|-BaseSlider<__Il2CppFullySharedGenericType>.RegisterEditingCallbacks
	*/

	// RVA: -1 Offset: -1 Slot: 116
	internal override void UnregisterEditingCallbacks() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1418380 Offset: 0x1416D80 VA: 0x181418380
	|-BaseSlider<int>.UnregisterEditingCallbacks
	|
	|-RVA: 0x141FAF0 Offset: 0x141E4F0 VA: 0x18141FAF0
	|-BaseSlider<float>.UnregisterEditingCallbacks
	|
	|-RVA: 0x141FC70 Offset: 0x141E670 VA: 0x18141FC70
	|-BaseSlider<__Il2CppFullySharedGenericType>.UnregisterEditingCallbacks
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14190B0 Offset: 0x1417AB0 VA: 0x1814190B0
	|-BaseSlider<int>..cctor
	|
	|-RVA: 0x1422440 Offset: 0x1420E40 VA: 0x181422440
	|-BaseSlider<float>..cctor
	|
	|-RVA: 0x1421B80 Offset: 0x1420580 VA: 0x181421B80
	|-BaseSlider<__Il2CppFullySharedGenericType>..cctor
	*/
}
