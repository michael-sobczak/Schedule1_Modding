public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 16984
{
	// Fields
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	[Range(0, 360)]
	public FloatParameter shutterAngle; // 0x30
	[Range(4, 32)]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	public IntParameter sampleCount; // 0x38

	// Methods

	// RVA: 0x29A01D0 Offset: 0x299EBD0 VA: 0x1829A01D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x29A0280 Offset: 0x299EC80 VA: 0x1829A0280
	public void .ctor() { }
}
