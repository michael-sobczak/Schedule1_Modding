public sealed class ColorCurves : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8911
{
	// Fields
	[Tooltip("Affects the luminance across the whole image.")]
	public TextureCurveParameter master; // 0x38
	[Tooltip("Affects the red channel intensity across the whole image.")]
	public TextureCurveParameter red; // 0x40
	[Tooltip("Affects the green channel intensity across the whole image.")]
	public TextureCurveParameter green; // 0x48
	[Tooltip("Affects the blue channel intensity across the whole image.")]
	public TextureCurveParameter blue; // 0x50
	[Tooltip("Shifts the input hue (x-axis) according to the output hue (y-axis).")]
	public TextureCurveParameter hueVsHue; // 0x58
	[Tooltip("Adjusts saturation (y-axis) according to the input hue (x-axis).")]
	public TextureCurveParameter hueVsSat; // 0x60
	[Tooltip("Adjusts saturation (y-axis) according to the input saturation (x-axis).")]
	public TextureCurveParameter satVsSat; // 0x68
	[Tooltip("Adjusts saturation (y-axis) according to the input luminance (x-axis).")]
	public TextureCurveParameter lumVsSat; // 0x70

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2AFE240 Offset: 0x2AFCC40 VA: 0x182AFE240
	public void .ctor() { }
}
