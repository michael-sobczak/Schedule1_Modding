public sealed class CanvasRenderer : Component // TypeDefIndex: 18971
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativeProperty("ShouldCull", False, 0)]
	public bool cull { get; set; }
	public Vector2 clippingSoftness { set; }

	// Methods

	// RVA: 0x2F15200 Offset: 0x2F13C00 VA: 0x182F15200
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x2F15090 Offset: 0x2F13A90 VA: 0x182F15090
	public int get_materialCount() { }

	// RVA: 0x2F15250 Offset: 0x2F13C50 VA: 0x182F15250
	public void set_materialCount(int value) { }

	// RVA: 0x2F15290 Offset: 0x2F13C90 VA: 0x182F15290
	public void set_popMaterialCount(int value) { }

	// RVA: 0x2F14F90 Offset: 0x2F13990 VA: 0x182F14F90
	public int get_absoluteDepth() { }

	// RVA: 0x2F15050 Offset: 0x2F13A50 VA: 0x182F15050
	public bool get_hasMoved() { }

	// RVA: 0x2F14FD0 Offset: 0x2F139D0 VA: 0x182F14FD0
	public bool get_cullTransparentMesh() { }

	// RVA: 0x2F15160 Offset: 0x2F13B60 VA: 0x182F15160
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x2F15010 Offset: 0x2F13A10 VA: 0x182F15010
	public bool get_cull() { }

	// RVA: 0x2F151B0 Offset: 0x2F13BB0 VA: 0x182F151B0
	public void set_cull(bool value) { }

	// RVA: 0x2F14BA0 Offset: 0x2F135A0 VA: 0x182F14BA0
	public void SetColor(Color color) { }

	// RVA: 0x2F14A30 Offset: 0x2F13430 VA: 0x182F14A30
	public Color GetColor() { }

	// RVA: 0x2F14990 Offset: 0x2F13390 VA: 0x182F14990
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x2F15120 Offset: 0x2F13B20 VA: 0x182F15120
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x2F14900 Offset: 0x2F13300 VA: 0x182F14900
	public void DisableRectClipping() { }

	// RVA: 0x2F14D10 Offset: 0x2F13710 VA: 0x182F14D10
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x2F14AC0 Offset: 0x2F134C0 VA: 0x182F14AC0
	public Material GetMaterial(int index) { }

	// RVA: 0x2F14DC0 Offset: 0x2F137C0 VA: 0x182F14DC0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x2F14E20 Offset: 0x2F13820 VA: 0x182F14E20
	public void SetTexture(Texture texture) { }

	// RVA: 0x2F14B00 Offset: 0x2F13500 VA: 0x182F14B00
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x2F14D70 Offset: 0x2F13770 VA: 0x182F14D70
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x2F14850 Offset: 0x2F13250 VA: 0x182F14850
	public void Clear() { }

	// RVA: 0x2F14BF0 Offset: 0x2F135F0 VA: 0x182F14BF0
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x2F14A80 Offset: 0x2F13480 VA: 0x182F14A80
	public Material GetMaterial() { }

	// RVA: 0x2F14EC0 Offset: 0x2F138C0 VA: 0x182F14EC0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2F14890 Offset: 0x2F13290 VA: 0x182F14890
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x2F147E0 Offset: 0x2F131E0 VA: 0x182F147E0
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x2F14E70 Offset: 0x2F13870 VA: 0x182F14E70
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x2F147E0 Offset: 0x2F131E0 VA: 0x182F147E0
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x2F14890 Offset: 0x2F13290 VA: 0x182F14890
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2F14B50 Offset: 0x2F13550 VA: 0x182F14B50
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x2F149E0 Offset: 0x2F133E0 VA: 0x182F149E0
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x2F14940 Offset: 0x2F13340 VA: 0x182F14940
	private void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x2F150D0 Offset: 0x2F13AD0 VA: 0x182F150D0
	private void set_clippingSoftness_Injected(ref Vector2 value) { }
}
