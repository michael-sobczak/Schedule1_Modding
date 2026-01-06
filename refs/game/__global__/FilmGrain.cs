public sealed class FilmGrain : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8917
{
	// Fields
	[Tooltip("The type of grain to use. You can select a preset or provide your own texture by selecting Custom.")]
	public FilmGrainLookupParameter type; // 0x38
	[Tooltip("Use the slider to set the strength of the Film Grain effect.")]
	public ClampedFloatParameter intensity; // 0x40
	[Tooltip("Controls the noisiness response curve based on scene luminance. Higher values mean less noise in light areas.")]
	public ClampedFloatParameter response; // 0x48
	[Tooltip("A tileable texture to use for the grain. The neutral value is 0.5 where no grain is applied.")]
	public NoInterpTextureParameter texture; // 0x50

	// Methods

	// RVA: 0x2B00EA0 Offset: 0x2AFF8A0 VA: 0x182B00EA0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B00F70 Offset: 0x2AFF970 VA: 0x182B00F70
	public void .ctor() { }
}
