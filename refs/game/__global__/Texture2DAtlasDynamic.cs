internal class Texture2DAtlasDynamic // TypeDefIndex: 13832
{
	// Fields
	private RTHandle m_AtlasTexture; // 0x10
	private bool isAtlasTextureOwner; // 0x18
	private int m_Width; // 0x1C
	private int m_Height; // 0x20
	private GraphicsFormat m_Format; // 0x24
	private AtlasAllocatorDynamic m_AtlasAllocator; // 0x28
	private Dictionary<int, Vector4> m_AllocationCache; // 0x30

	// Properties
	public RTHandle AtlasTexture { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public RTHandle get_AtlasTexture() { }

	// RVA: 0x2A42820 Offset: 0x2A41220 VA: 0x182A42820
	public void .ctor(int width, int height, int capacity, GraphicsFormat format) { }

	// RVA: 0x2A426F0 Offset: 0x2A410F0 VA: 0x182A426F0
	public void .ctor(int width, int height, int capacity, RTHandle atlasTexture) { }

	// RVA: 0x2A42460 Offset: 0x2A40E60 VA: 0x182A42460
	public void Release() { }

	// RVA: 0x2A425D0 Offset: 0x2A40FD0 VA: 0x182A425D0
	public void ResetAllocator() { }

	// RVA: 0x2A41E90 Offset: 0x2A40890 VA: 0x182A41E90
	public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture) { }

	// RVA: 0x2A422D0 Offset: 0x2A40CD0 VA: 0x182A422D0
	public bool IsCached(out Vector4 scaleOffset, int key) { }

	// RVA: 0x2A42170 Offset: 0x2A40B70 VA: 0x182A42170
	public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height) { }

	// RVA: 0x2A42340 Offset: 0x2A40D40 VA: 0x182A42340
	public void ReleaseTextureSlot(int key) { }
}
