internal class TextureLerper // TypeDefIndex: 17078
{
	// Fields
	private static TextureLerper m_Instance; // 0x0
	private CommandBuffer m_Command; // 0x10
	private PropertySheetFactory m_PropertySheets; // 0x18
	private PostProcessResources m_Resources; // 0x20
	private List<RenderTexture> m_Recycled; // 0x28
	private List<RenderTexture> m_Actives; // 0x30

	// Properties
	internal static TextureLerper instance { get; }

	// Methods

	// RVA: 0x29C6910 Offset: 0x29C5310 VA: 0x1829C6910
	internal static TextureLerper get_instance() { }

	// RVA: 0x29C6860 Offset: 0x29C5260 VA: 0x1829C6860
	private void .ctor() { }

	// RVA: 0x29C5080 Offset: 0x29C3A80 VA: 0x1829C5080
	internal void BeginFrame(PostProcessRenderContext context) { }

	// RVA: 0x29C5350 Offset: 0x29C3D50 VA: 0x1829C5350
	internal void EndFrame() { }

	// RVA: 0x29C5550 Offset: 0x29C3F50 VA: 0x1829C5550
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	// RVA: 0x29C5870 Offset: 0x29C4270 VA: 0x1829C5870
	internal Texture Lerp(Texture from, Texture to, float t) { }

	// RVA: 0x29C6090 Offset: 0x29C4A90 VA: 0x1829C6090
	internal Texture Lerp(Texture from, Color to, float t) { }

	// RVA: 0x29C50E0 Offset: 0x29C3AE0 VA: 0x1829C50E0
	internal void Clear() { }
}
