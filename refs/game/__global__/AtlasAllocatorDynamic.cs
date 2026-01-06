internal class AtlasAllocatorDynamic // TypeDefIndex: 13831
{
	// Fields
	private int m_Width; // 0x10
	private int m_Height; // 0x14
	private AtlasAllocatorDynamic.AtlasNodePool m_Pool; // 0x18
	private short m_Root; // 0x20
	private Dictionary<int, short> m_NodeFromID; // 0x28

	// Methods

	// RVA: 0x2A2F280 Offset: 0x2A2DC80 VA: 0x182A2F280
	public void .ctor(int width, int height, int capacityAllocations) { }

	// RVA: 0x2A2EA50 Offset: 0x2A2D450 VA: 0x182A2EA50
	public bool Allocate(out Vector4 result, int key, int width, int height) { }

	// RVA: 0x2A2F0F0 Offset: 0x2A2DAF0 VA: 0x182A2F0F0
	public void Release(int key) { }

	// RVA: 0x2A2F1B0 Offset: 0x2A2DBB0 VA: 0x182A2F1B0
	public void Release() { }

	// RVA: 0x2A2F080 Offset: 0x2A2DA80 VA: 0x182A2F080
	public string DebugStringFromRoot(int depthMax = -1) { }

	// RVA: 0x2A2EB80 Offset: 0x2A2D580 VA: 0x182A2EB80
	private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0, int depthMax = -1) { }
}
