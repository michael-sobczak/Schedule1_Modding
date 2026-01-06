public class BoxSlider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 18760
{
	// Fields
	[SerializeField]
	private RectTransform m_HandleRect; // 0x100
	[Space(6)]
	[SerializeField]
	private float m_MinValue; // 0x108
	[SerializeField]
	private float m_MaxValue; // 0x10C
	[SerializeField]
	private bool m_WholeNumbers; // 0x110
	[SerializeField]
	private float m_Value; // 0x114
	[SerializeField]
	private float m_ValueY; // 0x118
	[Space(6)]
	[SerializeField]
	private BoxSlider.BoxSliderEvent m_OnValueChanged; // 0x120
	private Transform m_HandleTransform; // 0x128
	private RectTransform m_HandleContainerRect; // 0x130
	private Vector2 m_Offset; // 0x138
	private DrivenRectTransformTracker m_Tracker; // 0x140

	// Properties
	public RectTransform handleRect { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public float value { get; set; }
	public float normalizedValue { get; set; }
	public float valueY { get; set; }
	public float normalizedValueY { get; set; }
	public BoxSlider.BoxSliderEvent onValueChanged { get; set; }
	private float stepSize { get; }

	// Methods

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public RectTransform get_handleRect() { }

	// RVA: 0x1A48DE0 Offset: 0x1A477E0 VA: 0x181A48DE0
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x528060 Offset: 0x526A60 VA: 0x180528060
	public float get_minValue() { }

	// RVA: 0x1A48EE0 Offset: 0x1A478E0 VA: 0x181A48EE0
	public void set_minValue(float value) { }

	// RVA: 0x1A48C00 Offset: 0x1A47600 VA: 0x181A48C00
	public float get_maxValue() { }

	// RVA: 0x1A48E50 Offset: 0x1A47850 VA: 0x181A48E50
	public void set_maxValue(float value) { }

	// RVA: 0x9876C0 Offset: 0x9860C0 VA: 0x1809876C0
	public bool get_wholeNumbers() { }

	// RVA: 0x1A49010 Offset: 0x1A47A10 VA: 0x181A49010
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x1A48DC0 Offset: 0x1A477C0 VA: 0x181A48DC0
	public float get_value() { }

	// RVA: 0x1A484D0 Offset: 0x1A46ED0 VA: 0x181A484D0
	public void set_value(float value) { }

	// RVA: 0x1A48CC0 Offset: 0x1A476C0 VA: 0x181A48CC0
	public float get_normalizedValue() { }

	// RVA: 0x1A48FC0 Offset: 0x1A479C0 VA: 0x181A48FC0
	public void set_normalizedValue(float value) { }

	// RVA: 0x1A48DA0 Offset: 0x1A477A0 VA: 0x181A48DA0
	public float get_valueY() { }

	// RVA: 0x1A484C0 Offset: 0x1A46EC0 VA: 0x181A484C0
	public void set_valueY(float value) { }

	// RVA: 0x1A48C10 Offset: 0x1A47610 VA: 0x181A48C10
	public float get_normalizedValueY() { }

	// RVA: 0x1A48F70 Offset: 0x1A47970 VA: 0x181A48F70
	public void set_normalizedValueY(float value) { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public BoxSlider.BoxSliderEvent get_onValueChanged() { }

	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	public void set_onValueChanged(BoxSlider.BoxSliderEvent value) { }

	// RVA: 0x1A48D70 Offset: 0x1A47770 VA: 0x181A48D70
	private float get_stepSize() { }

	// RVA: 0x1A48AF0 Offset: 0x1A474F0 VA: 0x181A48AF0
	protected void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 43
	public void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 44
	public void GraphicUpdateComplete() { }

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE59050 Offset: 0xE57A50 VA: 0x180E59050
	|-BoxSlider.SetClass<object>
	*/

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE590B0 Offset: 0xE57AB0 VA: 0x180E590B0
	|-BoxSlider.SetStruct<bool>
	|
	|-RVA: 0xE592D0 Offset: 0xE57CD0 VA: 0x180E592D0
	|-BoxSlider.SetStruct<float>
	|
	|-RVA: 0xE59160 Offset: 0xE57B60 VA: 0x180E59160
	|-BoxSlider.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x1A48000 Offset: 0x1A46A00 VA: 0x181A48000 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A47F50 Offset: 0x1A46950 VA: 0x181A47F50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A485D0 Offset: 0x1A46FD0 VA: 0x181A485D0
	private void UpdateCachedReferences() { }

	// RVA: 0x1A484D0 Offset: 0x1A46ED0 VA: 0x181A484D0
	private void Set(float input) { }

	// RVA: 0x1A484E0 Offset: 0x1A46EE0 VA: 0x181A484E0
	private void Set(float input, bool sendCallback) { }

	// RVA: 0x1A484C0 Offset: 0x1A46EC0 VA: 0x181A484C0
	private void SetY(float input) { }

	// RVA: 0x1A483D0 Offset: 0x1A46DD0 VA: 0x181A483D0
	private void SetY(float input, bool sendCallback) { }

	// RVA: 0x1A483B0 Offset: 0x1A46DB0 VA: 0x181A483B0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A489A0 Offset: 0x1A473A0 VA: 0x181A489A0
	private void UpdateVisuals() { }

	// RVA: 0x1A48710 Offset: 0x1A47110 VA: 0x181A48710
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1A47EE0 Offset: 0x1A468E0 VA: 0x181A47EE0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1A48160 Offset: 0x1A46B60 VA: 0x181A48160 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A47F80 Offset: 0x1A46980 VA: 0x181A47F80 Slot: 47
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A48140 Offset: 0x1A46B40 VA: 0x181A48140 Slot: 48
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
