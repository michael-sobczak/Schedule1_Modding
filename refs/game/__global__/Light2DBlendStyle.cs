public struct Light2DBlendStyle // TypeDefIndex: 8699
{
	// Fields
	public string name; // 0x0
	[SerializeField]
	internal Light2DBlendStyle.TextureChannel maskTextureChannel; // 0x8
	[SerializeField]
	internal Light2DBlendStyle.BlendMode blendMode; // 0xC
	[CompilerGenerated]
	private bool <isDirty>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <hasRenderTarget>k__BackingField; // 0x11
	internal int renderTargetHandleId; // 0x14
	internal RTHandle renderTargetHandle; // 0x18

	// Properties
	internal Vector2 blendFactors { get; }
	internal Light2DBlendStyle.MaskChannelFilter maskTextureChannelFilter { get; }
	internal bool isDirty { get; set; }
	internal bool hasRenderTarget { get; set; }

	// Methods

	// RVA: 0x2A7BA90 Offset: 0x2A7A490 VA: 0x182A7BA90
	internal Vector2 get_blendFactors() { }

	// RVA: 0x2A7BAE0 Offset: 0x2A7A4E0 VA: 0x182A7BAE0
	internal Light2DBlendStyle.MaskChannelFilter get_maskTextureChannelFilter() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	internal bool get_isDirty() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	internal void set_isDirty(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	internal bool get_hasRenderTarget() { }

	[CompilerGenerated]
	// RVA: 0x498A90 Offset: 0x497490 VA: 0x180498A90
	internal void set_hasRenderTarget(bool value) { }
}
