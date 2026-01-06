public class ProgressSlider : Singleton<ProgressSlider> // TypeDefIndex: 2686
{
	// Fields
	[Header("References")]
	public GameObject Container; // 0x28
	public TextMeshProUGUI Label; // 0x30
	public Slider Slider; // 0x38
	public Image SliderFill; // 0x40
	private bool progressSetThisFrame; // 0x48

	// Methods

	// RVA: 0x900DC0 Offset: 0x8FF7C0 VA: 0x180900DC0
	private void LateUpdate() { }

	// RVA: 0x900E00 Offset: 0x8FF800 VA: 0x180900E00
	public void ShowProgress(float progress) { }

	// RVA: 0x900D30 Offset: 0x8FF730 VA: 0x180900D30
	public void Configure(string label, Color sliderFillColor) { }

	// RVA: 0x900E30 Offset: 0x8FF830 VA: 0x180900E30
	public void .ctor() { }
}
