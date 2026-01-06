public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 16982
{
	// Fields
	[Range(-100, 100)]
	[Tooltip("Total distortion amount.")]
	public FloatParameter intensity; // 0x30
	[DisplayName("X Multiplier")]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	[Range(0, 1)]
	public FloatParameter intensityX; // 0x38
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	[DisplayName("Y Multiplier")]
	[Range(0, 1)]
	public FloatParameter intensityY; // 0x40
	[Space]
	[Tooltip("Distortion center point (x-axis).")]
	[Range(-1, 1)]
	public FloatParameter centerX; // 0x48
	[Range(-1, 1)]
	[Tooltip("Distortion center point (y-axis).")]
	public FloatParameter centerY; // 0x50
	[Space]
	[Range(0.01, 5)]
	[Tooltip("Global screen scaling.")]
	public FloatParameter scale; // 0x58

	// Methods

	// RVA: 0x299F280 Offset: 0x299DC80 VA: 0x18299F280 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x299F3A0 Offset: 0x299DDA0 VA: 0x18299F3A0
	public void .ctor() { }
}
