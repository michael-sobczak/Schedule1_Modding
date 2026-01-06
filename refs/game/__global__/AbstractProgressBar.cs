public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float> // TypeDefIndex: 6387
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string containerUssClassName; // 0x8
	public static readonly string titleUssClassName; // 0x10
	public static readonly string titleContainerUssClassName; // 0x18
	public static readonly string progressUssClassName; // 0x20
	public static readonly string backgroundUssClassName; // 0x28
	private readonly VisualElement m_Background; // 0x3D8
	private readonly VisualElement m_Progress; // 0x3E0
	private readonly Label m_Title; // 0x3E8
	private float m_LowValue; // 0x3F0
	private float m_HighValue; // 0x3F4
	private float m_Value; // 0x3F8

	// Properties
	public string title { set; }
	public float lowValue { get; set; }
	public float highValue { get; set; }
	public virtual float value { get; set; }

	// Methods

	// RVA: 0x2E56FE0 Offset: 0x2E559E0 VA: 0x182E56FE0
	public void set_title(string value) { }

	// RVA: 0x2C19FD0 Offset: 0x2C189D0 VA: 0x182C19FD0
	public float get_lowValue() { }

	// RVA: 0x2E56FC0 Offset: 0x2E559C0 VA: 0x182E56FC0
	public void set_lowValue(float value) { }

	// RVA: 0x2C19FE0 Offset: 0x2C189E0 VA: 0x182C19FE0
	public float get_highValue() { }

	// RVA: 0x2E56FA0 Offset: 0x2E559A0 VA: 0x182E56FA0
	public void set_highValue(float value) { }

	// RVA: 0x2E56C70 Offset: 0x2E55670 VA: 0x182E56C70
	public void .ctor() { }

	// RVA: 0x2E567F0 Offset: 0x2E551F0 VA: 0x182E567F0
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x14117C0 Offset: 0x14101C0 VA: 0x1814117C0 Slot: 105
	public virtual float get_value() { }

	// RVA: 0x2E57010 Offset: 0x2E55A10 VA: 0x182E57010 Slot: 106
	public virtual void set_value(float value) { }

	// RVA: 0x2E56A10 Offset: 0x2E55410 VA: 0x182E56A10 Slot: 104
	public void SetValueWithoutNotify(float newValue) { }

	// RVA: 0x2E56820 Offset: 0x2E55220 VA: 0x182E56820
	private void SetProgress(float p) { }

	// RVA: 0x2E56740 Offset: 0x2E55140 VA: 0x182E56740
	private float CalculateProgressWidth(float width) { }

	// RVA: 0x2E56A50 Offset: 0x2E55450 VA: 0x182E56A50
	private static void .cctor() { }
}
