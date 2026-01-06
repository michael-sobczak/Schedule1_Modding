public sealed class RenderTextureFactory : IDisposable // TypeDefIndex: 222
{
	// Fields
	private HashSet<RenderTexture> m_TemporaryRTs; // 0x10

	// Methods

	// RVA: 0x6A0040 Offset: 0x69EA40 VA: 0x1806A0040
	public void .ctor() { }

	// RVA: 0x69FBD0 Offset: 0x69E5D0 VA: 0x18069FBD0
	public RenderTexture Get(RenderTexture baseRenderTexture) { }

	// RVA: 0x69FD70 Offset: 0x69E770 VA: 0x18069FD70
	public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = 2, RenderTextureReadWrite rw = 0, FilterMode filterMode = 1, TextureWrapMode wrapMode = 1, string name = "FactoryTempTexture") { }

	// RVA: 0x69FF20 Offset: 0x69E920 VA: 0x18069FF20
	public void Release(RenderTexture rt) { }

	// RVA: 0x69FE40 Offset: 0x69E840 VA: 0x18069FE40
	public void ReleaseAll() { }

	// RVA: 0x69FBC0 Offset: 0x69E5C0 VA: 0x18069FBC0 Slot: 4
	public void Dispose() { }
}
