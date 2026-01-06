internal class UIRStylePainter : IStylePainter // TypeDefIndex: 7156
{
	// Fields
	private RenderChain m_Owner; // 0x10
	private List<UIRStylePainter.Entry> m_Entries; // 0x18
	private AtlasBase m_Atlas; // 0x20
	private VectorImageManager m_VectorImageManager; // 0x28
	private UIRStylePainter.Entry m_CurrentEntry; // 0x30
	private UIRStylePainter.ClosingInfo m_ClosingInfo; // 0x80
	private int m_MaskDepth; // 0xB8
	private int m_StencilRef; // 0xBC
	private BMPAlloc m_ClipRectID; // 0xC0
	private int m_SVGBackgroundEntryIndex; // 0xC8
	private TempAllocator<Vertex> m_VertsPool; // 0xD0
	private TempAllocator<ushort> m_IndicesPool; // 0xD8
	private List<MeshWriteData> m_MeshWriteDataPool; // 0xE0
	private int m_NextMeshWriteDataPoolItem; // 0xE8
	private List<UIRStylePainter.RepeatRectUV>[] m_RepeatRectUVList; // 0xF0
	private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate; // 0xF8
	private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate; // 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshGenerationContext <meshGenerationContext>k__BackingField; // 0x108
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <currentElement>k__BackingField; // 0x110
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <totalVertices>k__BackingField; // 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <totalIndices>k__BackingField; // 0x11C
	private TextInfo m_TextInfo; // 0x120

	// Properties
	public MeshGenerationContext meshGenerationContext { get; }
	public VisualElement currentElement { get; set; }
	public List<UIRStylePainter.Entry> entries { get; }
	public UIRStylePainter.ClosingInfo closingInfo { get; }
	public int totalVertices { get; set; }
	public int totalIndices { get; set; }
	public VisualElement visualElement { get; }

	// Methods

	// RVA: 0x2E28F30 Offset: 0x2E27930 VA: 0x182E28F30
	private MeshWriteData GetPooledMeshWriteData() { }

	// RVA: 0x2E209F0 Offset: 0x2E1F3F0 VA: 0x182E209F0
	private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) { }

	// RVA: 0x2E20AE0 Offset: 0x2E1F4E0 VA: 0x182E20AE0
	private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) { }

	// RVA: 0x2E2A960 Offset: 0x2E29360 VA: 0x182E2A960
	public void .ctor(RenderChain renderChain) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public MeshGenerationContext get_meshGenerationContext() { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public VisualElement get_currentElement() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	private void set_currentElement(VisualElement value) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public List<UIRStylePainter.Entry> get_entries() { }

	// RVA: 0x2E2ACF0 Offset: 0x2E296F0 VA: 0x182E2ACF0
	public UIRStylePainter.ClosingInfo get_closingInfo() { }

	[CompilerGenerated]
	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0
	public int get_totalVertices() { }

	[CompilerGenerated]
	// RVA: 0x7EDA60 Offset: 0x7EC460 VA: 0x1807EDA60
	private void set_totalVertices(int value) { }

	[CompilerGenerated]
	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public int get_totalIndices() { }

	[CompilerGenerated]
	// RVA: 0x9C2380 Offset: 0x9C0D80 VA: 0x1809C2380
	private void set_totalIndices(int value) { }

	// RVA: 0x2E20D40 Offset: 0x2E1F740 VA: 0x182E20D40
	public void Begin(VisualElement ve) { }

	// RVA: 0x2E290B0 Offset: 0x2E27AB0 VA: 0x182E290B0
	public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) { }

	// RVA: 0x2E29010 Offset: 0x2E27A10 VA: 0x182E29010
	public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset) { }

	// RVA: 0x2E22010 Offset: 0x2E20A10 VA: 0x182E22010 Slot: 7
	public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags) { }

	// RVA: 0x2E2A340 Offset: 0x2E28D40 VA: 0x182E2A340
	internal void TryAtlasTexture(Texture texture, MeshGenerationContext.MeshFlags flags, out Rect outUVRegion, out bool outIsAtlas, out TextureId outTextureId, out VertexFlags outAddFlags) { }

	// RVA: 0x2E21240 Offset: 0x2E1FC40 VA: 0x182E21240
	internal void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshGenerationContext.MeshFlags flags, Rect uvRegion, VertexFlags addFlags) { }

	// RVA: 0x2E21720 Offset: 0x2E20120 VA: 0x182E21720
	internal void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId) { }

	// RVA: 0x2E21B40 Offset: 0x2E20540 VA: 0x182E21B40
	public void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData) { }

	// RVA: 0x2E25F80 Offset: 0x2E24980 VA: 0x182E25F80 Slot: 4
	public void DrawText(TextElement te) { }

	// RVA: 0x2E258F0 Offset: 0x2E242F0 VA: 0x182E258F0
	private void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints) { }

	// RVA: 0x2E248F0 Offset: 0x2E232F0 VA: 0x182E248F0 Slot: 5
	public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) { }

	// RVA: 0x2E21DC0 Offset: 0x2E207C0 VA: 0x182E21DC0 Slot: 8
	public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams) { }

	// RVA: 0x2E21EC0 Offset: 0x2E208C0 VA: 0x182E21EC0 Slot: 6
	public void DrawImmediate(Action callback, bool cullingEnabled) { }

	// RVA: 0x2E2AD30 Offset: 0x2E29730 VA: 0x182E2AD30 Slot: 9
	public VisualElement get_visualElement() { }

	// RVA: 0x2E26610 Offset: 0x2E25010 VA: 0x182E26610
	public void DrawVisualElementBackground() { }

	// RVA: 0x2E22520 Offset: 0x2E20F20 VA: 0x182E22520
	private void DrawRectangleRepeat(MeshGenerationContextUtils.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x2E29E10 Offset: 0x2E28810 VA: 0x182E29E10
	private void StampRectangleWithSubRect(MeshGenerationContextUtils.RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV) { }

	// RVA: 0x2E27BB0 Offset: 0x2E265B0 VA: 0x182E27BB0
	public void DrawVisualElementBorder() { }

	// RVA: 0x2E20B10 Offset: 0x2E1F510 VA: 0x182E20B10
	public void ApplyVisualElementClipping() { }

	// RVA: 0x2E20560 Offset: 0x2E1EF60 VA: 0x182E20560
	private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices) { }

	// RVA: 0x2E25100 Offset: 0x2E23B00 VA: 0x182E25100
	public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams) { }

	// RVA: 0x2E26050 Offset: 0x2E24A50 VA: 0x182E26050
	public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams) { }

	// RVA: 0x2E29130 Offset: 0x2E27B30 VA: 0x182E29130
	private void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, out int finalVertexCount, out int finalIndexCount) { }

	// RVA: 0x2E29D60 Offset: 0x2E28760 VA: 0x182E29D60
	internal void Reset() { }

	// RVA: 0x2E2A560 Offset: 0x2E28F60 VA: 0x182E2A560
	private void ValidateMeshWriteData() { }

	// RVA: 0x2E283B0 Offset: 0x2E26DB0 VA: 0x182E283B0
	private void GenerateStencilClipEntryForRoundedRectBackground() { }

	// RVA: 0x2E28C20 Offset: 0x2E27620 VA: 0x182E28C20
	private void GenerateStencilClipEntryForSVGBackground() { }
}
