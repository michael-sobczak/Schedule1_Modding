public class ColorPicker : MonoBehaviour // TypeDefIndex: 18746
{
	// Fields
	private float _hue; // 0x20
	private float _saturation; // 0x24
	private float _brightness; // 0x28
	[SerializeField]
	private Color _color; // 0x2C
	[Header("Setup")]
	public ColorPickerSetup Setup; // 0x40
	[Header("Event")]
	public ColorChangedEvent onValueChanged; // 0x48
	public HSVChangedEvent onHSVChanged; // 0x50

	// Properties
	public Color CurrentColor { get; set; }
	public float H { get; set; }
	public float S { get; set; }
	public float V { get; set; }
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	private float A { get; set; }

	// Methods

	// RVA: 0x1A4A650 Offset: 0x1A49050 VA: 0x181A4A650
	public Color get_CurrentColor() { }

	// RVA: 0x1A49E20 Offset: 0x1A48820 VA: 0x181A49E20
	public void set_CurrentColor(Color value) { }

	// RVA: 0x1A49EC0 Offset: 0x1A488C0 VA: 0x181A49EC0
	private void Awake() { }

	// RVA: 0x1A4A0B0 Offset: 0x1A48AB0 VA: 0x181A4A0B0
	private void OnEnable() { }

	// RVA: 0x1A4A190 Offset: 0x1A48B90 VA: 0x181A4A190
	private void Regenerate() { }

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_H() { }

	// RVA: 0x1A4A700 Offset: 0x1A49100 VA: 0x181A4A700
	public void set_H(float value) { }

	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_S() { }

	// RVA: 0x1A4A7B0 Offset: 0x1A491B0 VA: 0x181A4A7B0
	public void set_S(float value) { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_V() { }

	// RVA: 0x1A4A830 Offset: 0x1A49230 VA: 0x181A4A830
	public void set_V(float value) { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_R() { }

	// RVA: 0x1A4A770 Offset: 0x1A49170 VA: 0x181A4A770
	public void set_R(float value) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_G() { }

	// RVA: 0x1A4A6C0 Offset: 0x1A490C0 VA: 0x181A4A6C0
	public void set_G(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_B() { }

	// RVA: 0x1A4A680 Offset: 0x1A49080 VA: 0x181A4A680
	public void set_B(float value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	private float get_A() { }

	// RVA: 0x1A4A660 Offset: 0x1A49060 VA: 0x181A4A660
	private void set_A(float value) { }

	// RVA: 0x1A4A0E0 Offset: 0x1A48AE0 VA: 0x181A4A0E0
	private void RGBChanged() { }

	// RVA: 0x1A49FB0 Offset: 0x1A489B0 VA: 0x181A49FB0
	private void HSVChanged() { }

	// RVA: 0x1A4A300 Offset: 0x1A48D00 VA: 0x181A4A300
	private void SendChangedEvent() { }

	// RVA: 0x1A49C60 Offset: 0x1A48660 VA: 0x181A49C60
	public void AssignColor(ColorValues type, float value) { }

	// RVA: 0x1A49E20 Offset: 0x1A48820 VA: 0x181A49E20
	public void AssignColor(Color color) { }

	// RVA: 0x1A49ED0 Offset: 0x1A488D0 VA: 0x181A49ED0
	public float GetValue(ColorValues type) { }

	// RVA: 0x1A4A390 Offset: 0x1A48D90 VA: 0x181A4A390
	public void ToggleColorSliders() { }

	// RVA: 0x1A4A460 Offset: 0x1A48E60 VA: 0x181A4A460
	private void UpdateColorToggleText() { }

	// RVA: 0x1A4A010 Offset: 0x1A48A10 VA: 0x181A4A010
	private void HandleHeaderSetting(ColorPickerSetup.ColorHeaderShowing setupShowHeader) { }

	// RVA: 0x1A4A560 Offset: 0x1A48F60 VA: 0x181A4A560
	public void .ctor() { }
}
