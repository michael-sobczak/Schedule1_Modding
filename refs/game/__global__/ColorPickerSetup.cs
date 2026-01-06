public class ColorPickerSetup // TypeDefIndex: 18749
{
	// Fields
	public bool ShowRgb; // 0x10
	public bool ShowHsv; // 0x11
	public bool ShowAlpha; // 0x12
	public bool ShowColorBox; // 0x13
	public bool ShowColorSliderToggle; // 0x14
	[Tooltip("Re-initialise the colour picker settings every time the picker is made active.")]
	public bool RegenerateOnOpen; // 0x15
	[Tooltip("Enable the user to add presets, up to the maximum preset limit.")]
	public bool UserCanAddPresets; // 0x16
	public ColorPickerSetup.ColorHeaderShowing ShowHeader; // 0x18
	public ColorPickerSetup.UiElements RgbSliders; // 0x20
	public ColorPickerSetup.UiElements HsvSliders; // 0x28
	public ColorPickerSetup.UiElements ColorToggleElement; // 0x30
	public ColorPickerSetup.UiElements AlphaSlidiers; // 0x38
	public ColorPickerSetup.UiElements ColorHeader; // 0x40
	public ColorPickerSetup.UiElements ColorCode; // 0x48
	public ColorPickerSetup.UiElements ColorPreview; // 0x50
	public ColorPickerSetup.UiElements ColorBox; // 0x58
	public TMP_Text SliderToggleButtonText; // 0x60
	public string PresetColorsId; // 0x68
	public Color[] DefaultPresetColors; // 0x70

	// Methods

	// RVA: 0x1A499E0 Offset: 0x1A483E0 VA: 0x181A499E0
	public void .ctor() { }
}
