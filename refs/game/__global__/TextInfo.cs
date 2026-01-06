internal class TextInfo // TypeDefIndex: 16749
{
	// Fields
	private static Vector2 s_InfinityVectorPositive; // 0x0
	private static Vector2 s_InfinityVectorNegative; // 0x8
	public int characterCount; // 0x10
	public int spriteCount; // 0x14
	public int spaceCount; // 0x18
	public int wordCount; // 0x1C
	public int linkCount; // 0x20
	public int lineCount; // 0x24
	public int pageCount; // 0x28
	public int materialCount; // 0x2C
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public PageInfo[] pageInfo; // 0x50
	public MeshInfo[] meshInfo; // 0x58
	public bool isDirty; // 0x60
	public bool hasMultipleColors; // 0x61

	// Methods

	// RVA: 0x2D865D0 Offset: 0x2D84FD0 VA: 0x182D865D0
	public void .ctor() { }

	// RVA: 0x2D86500 Offset: 0x2D84F00 VA: 0x182D86500
	internal void Clear() { }

	// RVA: 0x2D86340 Offset: 0x2D84D40 VA: 0x182D86340
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x2D860B0 Offset: 0x2D84AB0 VA: 0x182D860B0
	internal void ClearLineInfo() { }

	// RVA: 0x2D86400 Offset: 0x2D84E00 VA: 0x182D86400
	internal void ClearPageInfo() { }

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C010 Offset: 0xF5AA10 VA: 0x180F5C010
	|-TextInfo.Resize<LinkInfo>
	|-TextInfo.Resize<WordInfo>
	|
	|-RVA: 0xF5BF10 Offset: 0xF5A910 VA: 0x180F5BF10
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C070 Offset: 0xF5AA70 VA: 0x180F5C070
	|-TextInfo.Resize<MeshInfo>
	|-TextInfo.Resize<PageInfo>
	|-TextInfo.Resize<TextElementInfo>
	|
	|-RVA: 0xF5BF80 Offset: 0xF5A980 VA: 0x180F5BF80
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D86570 Offset: 0x2D84F70 VA: 0x182D86570
	private static void .cctor() { }
}
