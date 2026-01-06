public class DemoUI : MonoBehaviour // TypeDefIndex: 18720
{
	// Fields
	[Header("Renderer References")]
	public GodRaysRenderFeature feature; // 0x20
	[Header("Settings References")]
	public Text frametime; // 0x28
	public Dropdown VolumeTextureQuality; // 0x30
	public Dropdown VolumeStepQuality; // 0x38
	public Dropdown BilateralBlurSamples; // 0x40
	public Toggle blurToggle; // 0x48
	public Slider blurSlider; // 0x50

	// Methods

	// RVA: 0xCBF270 Offset: 0xCBDC70 VA: 0x180CBF270
	private void Start() { }

	// RVA: 0xCBF560 Offset: 0xCBDF60 VA: 0x180CBF560
	private void Update() { }

	// RVA: 0xCBF1C0 Offset: 0xCBDBC0 VA: 0x180CBF1C0
	public void OnDropdownVolumeTextureQuality(int index) { }

	// RVA: 0xCBF140 Offset: 0xCBDB40 VA: 0x180CBF140
	public void OnDropdownVolumeStepQuality(int index) { }

	// RVA: 0xCBF0C0 Offset: 0xCBDAC0 VA: 0x180CBF0C0
	public void OnDropdownBilateralBlurSamples(int index) { }

	// RVA: 0xCBF240 Offset: 0xCBDC40 VA: 0x180CBF240
	public void OnToggleblurToggle(bool enabled) { }

	// RVA: 0xCBF030 Offset: 0xCBDA30 VA: 0x180CBF030
	public void OnBlurSlider(float value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
