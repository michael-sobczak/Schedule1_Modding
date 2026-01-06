public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 16980
{
	// Fields
	[Tooltip("Enable the use of colored grain.")]
	public BoolParameter colored; // 0x30
	[Range(0, 1)]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	public FloatParameter intensity; // 0x38
	[Range(0.3, 3)]
	[Tooltip("Grain particle size.")]
	public FloatParameter size; // 0x40
	[Range(0, 1)]
	[DisplayName("Luminance Contribution")]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	public FloatParameter lumContrib; // 0x48

	// Methods

	// RVA: 0x2997CC0 Offset: 0x29966C0 VA: 0x182997CC0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x299EDD0 Offset: 0x299D7D0 VA: 0x18299EDD0
	public void .ctor() { }
}
