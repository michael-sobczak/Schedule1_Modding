public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 16957
{
	// Fields
	[DisplayName("Filtering (%)")]
	[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
	[MinMax(1, 99)]
	public Vector2Parameter filtering; // 0x30
	[Range(-9, 9)]
	[DisplayName("Minimum (EV)")]
	[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter minLuminance; // 0x38
	[Range(-9, 9)]
	[DisplayName("Maximum (EV)")]
	[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter maxLuminance; // 0x40
	[DisplayName("Exposure Compensation")]
	[Tooltip("Use this to scale the global exposure of the scene.")]
	[Min(0)]
	public FloatParameter keyValue; // 0x48
	[DisplayName("Type")]
	[Tooltip("Use "Progressive" if you want auto exposure to be animated. Use "Fixed" otherwise.")]
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[Tooltip("Adaptation speed from a dark to a light environment.")]
	[Min(0)]
	public FloatParameter speedUp; // 0x58
	[Tooltip("Adaptation speed from a light to a dark environment.")]
	[Min(0)]
	public FloatParameter speedDown; // 0x60

	// Methods

	// RVA: 0x2996100 Offset: 0x2994B00 VA: 0x182996100 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2996270 Offset: 0x2994C70 VA: 0x182996270
	public void .ctor() { }
}
