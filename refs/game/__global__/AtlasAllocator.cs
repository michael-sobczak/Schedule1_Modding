internal class AtlasAllocator // TypeDefIndex: 13825
{
	// Fields
	private AtlasAllocator.AtlasNode m_Root; // 0x10
	private int m_Width; // 0x18
	private int m_Height; // 0x1C
	private bool powerOfTwoPadding; // 0x20
	private ObjectPool<AtlasAllocator.AtlasNode> m_NodePool; // 0x28

	// Methods

	// RVA: 0x2A2F500 Offset: 0x2A2DF00 VA: 0x182A2F500
	public void .ctor(int width, int height, bool potPadding) { }

	// RVA: 0x2A2F420 Offset: 0x2A2DE20 VA: 0x182A2F420
	public bool Allocate(ref Vector4 result, int width, int height) { }

	// RVA: 0x2A2F4A0 Offset: 0x2A2DEA0 VA: 0x182A2F4A0
	public void Reset() { }
}
