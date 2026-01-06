public class TMP_TextInfo // TypeDefIndex: 14995
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x2C2FC70 Offset: 0x2C2E670 VA: 0x182C2FC70
	public void .ctor() { }

	// RVA: 0x2C2FF60 Offset: 0x2C2E960 VA: 0x182C2FF60
	internal void .ctor(int characterCount) { }

	// RVA: 0x2C2FDB0 Offset: 0x2C2E7B0 VA: 0x182C2FDB0
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x2C2F5B0 Offset: 0x2C2DFB0 VA: 0x182C2F5B0
	internal void Clear() { }

	// RVA: 0x2C2EE50 Offset: 0x2C2D850 VA: 0x182C2EE50
	internal void ClearAllData() { }

	// RVA: 0x2C2F330 Offset: 0x2C2DD30 VA: 0x182C2F330
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x2C2EFA0 Offset: 0x2C2D9A0 VA: 0x182C2EFA0
	public void ClearAllMeshInfo() { }

	// RVA: 0x2C2FB50 Offset: 0x2C2E550 VA: 0x182C2FB50
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x2C2F4F0 Offset: 0x2C2DEF0 VA: 0x182C2F4F0
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x2C2F050 Offset: 0x2C2DA50 VA: 0x182C2F050
	internal void ClearLineInfo() { }

	// RVA: 0x2C2F3F0 Offset: 0x2C2DDF0 VA: 0x182C2F3F0
	internal void ClearPageInfo() { }

	// RVA: 0x2C2F620 Offset: 0x2C2E020 VA: 0x182C2F620
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C010 Offset: 0xF5AA10 VA: 0x180F5C010
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	|
	|-RVA: 0xF5BF10 Offset: 0xF5A910 VA: 0x180F5BF10
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C070 Offset: 0xF5AA70 VA: 0x180F5C070
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	|
	|-RVA: 0xF5BF80 Offset: 0xF5A980 VA: 0x180F5BF80
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C2FC10 Offset: 0x2C2E610 VA: 0x182C2FC10
	private static void .cctor() { }
}
