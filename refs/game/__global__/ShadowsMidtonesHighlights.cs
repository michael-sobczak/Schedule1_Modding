public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8927
{
	// Fields
	[Tooltip("Use this to control and apply a hue to the shadows.")]
	public Vector4Parameter shadows; // 0x38
	[Tooltip("Use this to control and apply a hue to the midtones.")]
	public Vector4Parameter midtones; // 0x40
	[Tooltip("Use this to control and apply a hue to the highlights.")]
	public Vector4Parameter highlights; // 0x48
	[Tooltip("Start point of the transition between shadows and midtones.")]
	[Header("Shadow Limits")]
	public MinFloatParameter shadowsStart; // 0x50
	[Tooltip("End point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsEnd; // 0x58
	[Header("Highlight Limits")]
	[Tooltip("Start point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsStart; // 0x60
	[Tooltip("End point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsEnd; // 0x68

	// Methods

	// RVA: 0x2B13310 Offset: 0x2B11D10 VA: 0x182B13310 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B133C0 Offset: 0x2B11DC0 VA: 0x182B133C0
	public void .ctor() { }
}
