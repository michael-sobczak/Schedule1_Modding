public sealed class Fog // TypeDefIndex: 16979
{
	// Fields
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	public bool enabled; // 0x10
	[Tooltip("Mark true for the fog to ignore the skybox")]
	public bool excludeSkybox; // 0x11

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x299E0A0 Offset: 0x299CAA0 VA: 0x18299E0A0
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x299E1C0 Offset: 0x299CBC0 VA: 0x18299E1C0
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x299E560 Offset: 0x299CF60 VA: 0x18299E560
	public void .ctor() { }
}
