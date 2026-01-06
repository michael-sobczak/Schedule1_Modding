internal class MeshHandle : LinkedPoolItem<MeshHandle> // TypeDefIndex: 7077
{
	// Fields
	internal Alloc allocVerts; // 0x18
	internal Alloc allocIndices; // 0x30
	internal uint triangleCount; // 0x48
	internal Page allocPage; // 0x50
	internal uint allocTime; // 0x58
	internal uint updateAllocID; // 0x5C

	// Methods

	// RVA: 0x2DFDD30 Offset: 0x2DFC730 VA: 0x182DFDD30
	public void .ctor() { }
}
