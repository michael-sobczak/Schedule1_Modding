public class ColorSlider : MonoBehaviour, IEndDragHandler, IEventSystemHandler // TypeDefIndex: 18753
{
	// Fields
	public ColorPicker hsvpicker; // 0x20
	public ColorValues type; // 0x28
	private Slider slider; // 0x30
	private bool listen; // 0x38
	[Header("Event")]
	public SliderOnChangeEndEvent onSliderChangeEndEvent; // 0x40

	// Methods

	// RVA: 0x1A4C600 Offset: 0x1A4B000 VA: 0x181A4C600
	private void Awake() { }

	// RVA: 0x1A4C9B0 Offset: 0x1A4B3B0 VA: 0x181A4C9B0
	private void OnDestroy() { }

	// RVA: 0x1A4C8A0 Offset: 0x1A4B2A0 VA: 0x181A4C8A0
	private void ColorChanged(Color newColor) { }

	// RVA: 0x1A4C940 Offset: 0x1A4B340 VA: 0x181A4C940
	private void HSVChanged(float hue, float saturation, float value) { }

	// RVA: 0x1A4CBB0 Offset: 0x1A4B5B0 VA: 0x181A4CBB0
	private void SliderChanged(float newValue) { }

	// RVA: 0x1A4CB40 Offset: 0x1A4B540 VA: 0x181A4CB40 Slot: 5
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A4CC00 Offset: 0x1A4B600 VA: 0x181A4CC00
	public void SliderClicked(BaseEventData data) { }

	// RVA: 0x1A4CC70 Offset: 0x1A4B670 VA: 0x181A4CC70
	public void .ctor() { }
}
