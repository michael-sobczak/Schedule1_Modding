public class ColorSliderImage : MonoBehaviour // TypeDefIndex: 18754
{
	// Fields
	public ColorPicker picker; // 0x20
	public ColorValues type; // 0x28
	public Slider.Direction direction; // 0x2C
	private RawImage image; // 0x30

	// Properties
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1A4C5A0 Offset: 0x1A4AFA0 VA: 0x181A4C5A0
	private RectTransform get_rectTransform() { }

	// RVA: 0x1A4B860 Offset: 0x1A4A260 VA: 0x181A4B860
	private void Awake() { }

	// RVA: 0x1A4BB40 Offset: 0x1A4A540 VA: 0x181A4BB40
	private void OnEnable() { }

	// RVA: 0x1A4B9F0 Offset: 0x1A4A3F0 VA: 0x181A4B9F0
	private void OnDisable() { }

	// RVA: 0x1A4B940 Offset: 0x1A4A340 VA: 0x181A4B940
	private void OnDestroy() { }

	// RVA: 0x1A4B8F0 Offset: 0x1A4A2F0 VA: 0x181A4B8F0
	private void ColorChanged(Color newColor) { }

	// RVA: 0x1A4B8F0 Offset: 0x1A4A2F0 VA: 0x181A4B8F0
	private void HSVChanged(float hue, float saturation, float value) { }

	// RVA: 0x1A4BCC0 Offset: 0x1A4A6C0 VA: 0x181A4BCC0
	private void RegenerateTexture() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
