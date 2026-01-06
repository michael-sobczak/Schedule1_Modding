public struct RendererListDesc // TypeDefIndex: 12288
{
	// Fields
	public SortingCriteria sortingCriteria; // 0x0
	public PerObjectData rendererConfiguration; // 0x4
	public RenderQueueRange renderQueueRange; // 0x8
	public Nullable<RenderStateBlock> stateBlock; // 0x10
	public Shader overrideShader; // 0x80
	public Material overrideMaterial; // 0x88
	public bool excludeObjectMotionVectors; // 0x90
	public int layerMask; // 0x94
	public uint renderingLayerMask; // 0x98
	public int overrideMaterialPassIndex; // 0x9C
	public int overrideShaderPassIndex; // 0xA0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private CullingResults <cullingResult>k__BackingField; // 0xA8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Camera <camera>k__BackingField; // 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ShaderTagId <passName>k__BackingField; // 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ShaderTagId[] <passNames>k__BackingField; // 0xC8
	private static readonly ShaderTagId s_EmptyName; // 0x0

	// Properties
	internal CullingResults cullingResult { get; }
	internal Camera camera { get; }
	internal ShaderTagId passName { get; }
	internal ShaderTagId[] passNames { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5013A0 Offset: 0x4FFDA0 VA: 0x1805013A0
	internal CullingResults get_cullingResult() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	internal Camera get_camera() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	internal ShaderTagId get_passName() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	internal ShaderTagId[] get_passNames() { }

	// RVA: 0x2CF8C60 Offset: 0x2CF7660 VA: 0x182CF8C60
	public bool IsValid() { }

	// RVA: 0x2CF8280 Offset: 0x2CF6C80 VA: 0x182CF8280
	public static RendererListParams ConvertToParameters(in RendererListDesc desc) { }

	// RVA: 0x2CF8D90 Offset: 0x2CF7790 VA: 0x182CF8D90
	private static void .cctor() { }
}
