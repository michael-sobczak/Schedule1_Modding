internal class RenderChain : IDisposable // TypeDefIndex: 7119
{
	// Fields
	private RenderChainCommand m_FirstCommand; // 0x10
	private RenderChain.DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
	private LinkedPool<RenderChainCommand> m_CommandPool; // 0x40
	private BasicNodePool<TextureEntry> m_TexturePool; // 0x48
	private List<RenderChain.RenderNodeData> m_RenderNodesData; // 0x50
	private Shader m_DefaultShader; // 0x58
	private Shader m_DefaultWorldSpaceShader; // 0x60
	private Material m_DefaultMat; // 0x68
	private Material m_DefaultWorldSpaceMat; // 0x70
	private bool m_BlockDirtyRegistration; // 0x78
	private int m_StaticIndex; // 0x7C
	private int m_ActiveRenderNodes; // 0x80
	private int m_CustomMaterialCommands; // 0x84
	private ChainBuilderStats m_Stats; // 0x88
	private uint m_StatsElementsAdded; // 0xE8
	private uint m_StatsElementsRemoved; // 0xEC
	private TextureRegistry m_TextureRegistry; // 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; // 0xF8
	private static ProfilerMarker s_MarkerProcess; // 0x0
	private static ProfilerMarker s_MarkerClipProcessing; // 0x8
	private static ProfilerMarker s_MarkerOpacityProcessing; // 0x10
	private static ProfilerMarker s_MarkerColorsProcessing; // 0x18
	private static ProfilerMarker s_MarkerTransformProcessing; // 0x20
	private static ProfilerMarker s_MarkerVisualsProcessing; // 0x28
	private static ProfilerMarker s_MarkerTextRegen; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x100
	internal static Action OnPreRender; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private BaseVisualElementPanel <panel>k__BackingField; // 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UIRenderDevice <device>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AtlasBase <atlas>k__BackingField; // 0x118
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VectorImageManager <vectorImageManager>k__BackingField; // 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TempAllocator<Vertex> <vertsPool>k__BackingField; // 0x128
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TempAllocator<ushort> <indicesPool>k__BackingField; // 0x130
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private JobManager <jobManager>k__BackingField; // 0x138
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x140
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UIRStylePainter <painter>k__BackingField; // 0x210
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <drawStats>k__BackingField; // 0x218
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <drawInCameras>k__BackingField; // 0x219

	// Properties
	public OpacityIdAccelerator opacityIdAccelerator { get; set; }
	protected bool disposed { get; set; }
	internal BaseVisualElementPanel panel { get; set; }
	internal UIRenderDevice device { get; set; }
	internal AtlasBase atlas { get; set; }
	internal VectorImageManager vectorImageManager { get; set; }
	internal TempAllocator<Vertex> vertsPool { get; set; }
	internal TempAllocator<ushort> indicesPool { get; set; }
	internal JobManager jobManager { get; set; }
	internal UIRStylePainter painter { get; set; }
	internal bool drawStats { get; set; }
	internal bool drawInCameras { get; set; }
	internal Shader defaultShader { set; }
	internal Shader defaultWorldSpaceShader { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	// RVA: 0x2E03DF0 Offset: 0x2E027F0 VA: 0x182E03DF0
	private static void .cctor() { }

	// RVA: 0x2E04250 Offset: 0x2E02C50 VA: 0x182E04250
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x2DFFCB0 Offset: 0x2DFE6B0 VA: 0x182DFFCB0
	private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) { }

	// RVA: 0x2E00350 Offset: 0x2DFED50 VA: 0x182E00350
	private void Destructor() { }

	[CompilerGenerated]
	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x6051F0 Offset: 0x603BF0 VA: 0x1806051F0
	private void set_disposed(bool value) { }

	// RVA: 0x2E00960 Offset: 0x2DFF360 VA: 0x182E00960 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E00930 Offset: 0x2DFF330 VA: 0x182E00930
	protected void Dispose(bool disposing) { }

	// RVA: 0x2E02200 Offset: 0x2E00C00 VA: 0x182E02200
	public void ProcessChanges() { }

	// RVA: 0x2E02A20 Offset: 0x2E01420 VA: 0x182E02A20
	public void Render() { }

	// RVA: 0x2E03180 Offset: 0x2E01B80 VA: 0x182E03180
	public void UIEOnChildAdded(VisualElement ve) { }

	// RVA: 0x2E03580 Offset: 0x2E01F80 VA: 0x182E03580
	public void UIEOnChildrenReordered(VisualElement ve) { }

	// RVA: 0x2E03480 Offset: 0x2E01E80 VA: 0x182E03480
	public void UIEOnChildRemoving(VisualElement ve) { }

	// RVA: 0x2E03B00 Offset: 0x2E02500 VA: 0x182E03B00
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	// RVA: 0x2E03880 Offset: 0x2E02280 VA: 0x182E03880
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x2E039C0 Offset: 0x2E023C0 VA: 0x182E039C0
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = False) { }

	// RVA: 0x2E03920 Offset: 0x2E02320 VA: 0x182E03920
	public void UIEOnColorChanged(VisualElement ve) { }

	// RVA: 0x2E03CB0 Offset: 0x2E026B0 VA: 0x182E03CB0
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	// RVA: 0x2E03D50 Offset: 0x2E02750 VA: 0x182E03D50
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x2E03A60 Offset: 0x2E02460 VA: 0x182E03A60
	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	internal BaseVisualElementPanel get_panel() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	private void set_panel(BaseVisualElementPanel value) { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	internal UIRenderDevice get_device() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	private void set_device(UIRenderDevice value) { }

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	internal AtlasBase get_atlas() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	internal VectorImageManager get_vectorImageManager() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_vectorImageManager(VectorImageManager value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	internal TempAllocator<Vertex> get_vertsPool() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_vertsPool(TempAllocator<Vertex> value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	internal TempAllocator<ushort> get_indicesPool() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	private void set_indicesPool(TempAllocator<ushort> value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	internal JobManager get_jobManager() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	private void set_jobManager(JobManager value) { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	internal UIRStylePainter get_painter() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	private void set_painter(UIRStylePainter value) { }

	[CompilerGenerated]
	// RVA: 0x860A30 Offset: 0x85F430 VA: 0x180860A30
	internal bool get_drawStats() { }

	[CompilerGenerated]
	// RVA: 0x860BA0 Offset: 0x85F5A0 VA: 0x180860BA0
	internal void set_drawStats(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E04650 Offset: 0x2E03050 VA: 0x182E04650
	internal bool get_drawInCameras() { }

	[CompilerGenerated]
	// RVA: 0x2E047E0 Offset: 0x2E031E0 VA: 0x182E047E0
	private void set_drawInCameras(bool value) { }

	// RVA: 0x2E04660 Offset: 0x2E03060 VA: 0x182E04660
	internal void set_defaultShader(Shader value) { }

	// RVA: 0x2E04720 Offset: 0x2E03120 VA: 0x182E04720
	internal void set_defaultWorldSpaceShader(Shader value) { }

	// RVA: 0x2E013E0 Offset: 0x2DFFDE0 VA: 0x182E013E0
	internal Material GetStandardMaterial() { }

	// RVA: 0x2E014E0 Offset: 0x2DFFEE0 VA: 0x182E014E0
	internal Material GetStandardWorldSpaceMaterial() { }

	// RVA: 0x2E012F0 Offset: 0x2DFFCF0 VA: 0x182E012F0
	internal void EnsureFitsDepth(int depth) { }

	// RVA: 0x2DFFC00 Offset: 0x2DFE600 VA: 0x182DFFC00
	internal void ChildWillBeRemoved(VisualElement ve) { }

	// RVA: 0x2DFFBA0 Offset: 0x2DFE5A0 VA: 0x182DFFBA0
	internal RenderChainCommand AllocCommand() { }

	// RVA: 0x2E01300 Offset: 0x2DFFD00 VA: 0x182E01300
	internal void FreeCommand(RenderChainCommand cmd) { }

	// RVA: 0x2E01FA0 Offset: 0x2E009A0 VA: 0x182E01FA0
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	// RVA: 0x2E02030 Offset: 0x2E00A30 VA: 0x182E02030
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	// RVA: 0x2DFFAB0 Offset: 0x2DFE4B0 VA: 0x182DFFAB0
	private static RenderChain.RenderNodeData AccessRenderNodeData(IntPtr obj) { }

	// RVA: 0x2E02070 Offset: 0x2E00A70 VA: 0x182E02070
	private static void OnRenderNodeExecute(IntPtr obj) { }

	// RVA: 0x2E01A60 Offset: 0x2E00460 VA: 0x182E01A60
	private static void OnRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x2E016A0 Offset: 0x2E000A0 VA: 0x182E016A0
	private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderChain.RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) { }

	// RVA: 0x2E02F00 Offset: 0x2E01900 VA: 0x182E02F00
	internal void RepaintTexturedElements() { }

	// RVA: 0x2E015E0 Offset: 0x2DFFFE0 VA: 0x182E015E0
	public void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	// RVA: 0x2E03050 Offset: 0x2E01A50 VA: 0x182E03050
	public void ResetTextures(VisualElement ve) { }

	// RVA: 0x2E009D0 Offset: 0x2DFF3D0 VA: 0x182E009D0
	private void DrawStats() { }

	// RVA: 0x2E013B0 Offset: 0x2DFFDB0 VA: 0x182E013B0
	private static VisualElement GetFirstElementInPanel(VisualElement ve) { }
}
