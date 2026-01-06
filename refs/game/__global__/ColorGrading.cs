public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 16969
{
	// Fields
	[DisplayName("Mode")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	public GradingModeParameter gradingMode; // 0x30
	[DisplayName("Lookup Texture")]
	[Tooltip("A custom 3D log-encoded texture.")]
	public TextureParameter externalLut; // 0x38
	[DisplayName("Mode")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	public TonemapperParameter tonemapper; // 0x40
	[DisplayName("Toe Strength")]
	[Range(0, 1)]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveToeStrength; // 0x48
	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	[Range(0, 1)]
	[DisplayName("Toe Length")]
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayName("Shoulder Strength")]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	[Range(0, 1)]
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayName("Shoulder Length")]
	[Min(0)]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayName("Shoulder Angle")]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	[Range(0, 1)]
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[Min(0.001)]
	[DisplayName("Gamma")]
	[Tooltip("Applies a gamma function to the curve.")]
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut; // 0x78
	[Range(0, 1)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	[DisplayName("Contribution")]
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayName("Temperature")]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	[Range(-100, 100)]
	public FloatParameter temperature; // 0x88
	[DisplayName("Tint")]
	[Range(-100, 100)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public FloatParameter tint; // 0x90
	[ColorUsage(False, True)]
	[DisplayName("Color Filter")]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; // 0x98
	[DisplayName("Hue Shift")]
	[Range(-180, 180)]
	[Tooltip("Shift the hue of all colors.")]
	public FloatParameter hueShift; // 0xA0
	[DisplayName("Saturation")]
	[Range(-100, 100)]
	[Tooltip("Pushes the intensity of all colors.")]
	public FloatParameter saturation; // 0xA8
	[Tooltip("Makes the image brighter or darker.")]
	[Range(-100, 100)]
	[DisplayName("Brightness")]
	public FloatParameter brightness; // 0xB0
	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; // 0xB8
	[Range(-100, 100)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	[DisplayName("Contrast")]
	public FloatParameter contrast; // 0xC0
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200, 200)]
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[DisplayName("Red")]
	[Range(-200, 200)]
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200, 200)]
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Range(-200, 200)]
	[DisplayName("Red")]
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[Range(-200, 200)]
	[DisplayName("Green")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200, 200)]
	[DisplayName("Blue")]
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(1)]
	public Vector4Parameter lift; // 0x110
	[Trackball(2)]
	[DisplayName("Gamma")]
	[Tooltip("Power function that controls mid-range tones.")]
	public Vector4Parameter gamma; // 0x118
	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(3)]
	public Vector4Parameter gain; // 0x120
	public SplineParameter masterCurve; // 0x128
	public SplineParameter redCurve; // 0x130
	public SplineParameter greenCurve; // 0x138
	public SplineParameter blueCurve; // 0x140
	public SplineParameter hueVsHueCurve; // 0x148
	public SplineParameter hueVsSatCurve; // 0x150
	public SplineParameter satVsSatCurve; // 0x158
	public SplineParameter lumVsSatCurve; // 0x160

	// Methods

	// RVA: 0x299B8B0 Offset: 0x299A2B0 VA: 0x18299B8B0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x299B900 Offset: 0x299A300 VA: 0x18299B900
	public void .ctor() { }
}
