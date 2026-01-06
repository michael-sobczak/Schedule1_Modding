public sealed class ColorLookup : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8912
{
	// Fields
	[Tooltip("A 2D Lookup Texture (LUT) to use for color grading.")]
	public TextureParameter texture; // 0x38
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	public ClampedFloatParameter contribution; // 0x40

	// Methods

	// RVA: 0x2AFE9C0 Offset: 0x2AFD3C0 VA: 0x182AFE9C0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2AFEA10 Offset: 0x2AFD410 VA: 0x182AFEA10
	public bool ValidateLUT() { }

	// RVA: 0x2AFECC0 Offset: 0x2AFD6C0 VA: 0x182AFECC0
	public void .ctor() { }
}
