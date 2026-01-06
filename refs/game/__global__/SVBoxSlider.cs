public class SVBoxSlider : MonoBehaviour, IEndDragHandler, IEventSystemHandler // TypeDefIndex: 18756
{
	// Fields
	public ColorPicker picker; // 0x20
	private BoxSlider slider; // 0x28
	private RawImage image; // 0x30
	private int textureWidth; // 0x38
	private int textureHeight; // 0x3C
	private float lastH; // 0x40
	private bool listen; // 0x44
	[Header("Event")]
	public SliderOnChangeEndEvent onSliderChangeEndEvent; // 0x48

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1A4E500 Offset: 0x1A4CF00 VA: 0x181A4E500
	public RectTransform get_rectTransform() { }

	// RVA: 0x1A4DA40 Offset: 0x1A4C440 VA: 0x181A4DA40
	private void Awake() { }

	// RVA: 0x1A4DE20 Offset: 0x1A4C820 VA: 0x181A4DE20
	private void OnEnable() { }

	// RVA: 0x1A4DCC0 Offset: 0x1A4C6C0 VA: 0x181A4DCC0
	private void OnDisable() { }

	// RVA: 0x1A4DC10 Offset: 0x1A4C610 VA: 0x181A4DC10
	private void OnDestroy() { }

	// RVA: 0x1A4E350 Offset: 0x1A4CD50 VA: 0x181A4E350
	private void SliderChanged(float saturation, float value) { }

	// RVA: 0x1A4DAC0 Offset: 0x1A4C4C0 VA: 0x181A4DAC0
	private void HSVChanged(float h, float s, float v) { }

	// RVA: 0x1A4E070 Offset: 0x1A4CA70 VA: 0x181A4E070
	private void RegenerateSVTexture() { }

	// RVA: 0x1A4E000 Offset: 0x1A4CA00 VA: 0x181A4E000 Slot: 5
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A4E460 Offset: 0x1A4CE60 VA: 0x181A4E460
	public void .ctor() { }
}
