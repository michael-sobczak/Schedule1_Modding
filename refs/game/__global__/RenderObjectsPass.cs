public class RenderObjectsPass : ScriptableRenderPass // TypeDefIndex: 8654
{
	// Fields
	private RenderQueueType renderQueueType; // 0xE0
	private FilteringSettings m_FilteringSettings; // 0xE4
	private RenderObjects.CustomCameraSettings m_CameraSettings; // 0x100
	private string m_ProfilerTag; // 0x108
	private ProfilingSampler m_ProfilingSampler; // 0x110
	[CompilerGenerated]
	private Material <overrideMaterial>k__BackingField; // 0x118
	[CompilerGenerated]
	private int <overrideMaterialPassIndex>k__BackingField; // 0x120
	[CompilerGenerated]
	private Shader <overrideShader>k__BackingField; // 0x128
	[CompilerGenerated]
	private int <overrideShaderPassIndex>k__BackingField; // 0x130
	private List<ShaderTagId> m_ShaderTagIdList; // 0x138
	private RenderStateBlock m_RenderStateBlock; // 0x140

	// Properties
	public Material overrideMaterial { get; set; }
	public int overrideMaterialPassIndex { get; set; }
	public Shader overrideShader { get; set; }
	public int overrideShaderPassIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Material get_overrideMaterial() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	public void set_overrideMaterial(Material value) { }

	[CompilerGenerated]
	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public int get_overrideMaterialPassIndex() { }

	[CompilerGenerated]
	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	public void set_overrideMaterialPassIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public Shader get_overrideShader() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	public void set_overrideShader(Shader value) { }

	[CompilerGenerated]
	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public int get_overrideShaderPassIndex() { }

	[CompilerGenerated]
	// RVA: 0x523860 Offset: 0x522260 VA: 0x180523860
	public void set_overrideShaderPassIndex(int value) { }

	// RVA: 0x2A75B80 Offset: 0x2A74580 VA: 0x182A75B80
	public void SetDetphState(bool writeEnabled, CompareFunction function = 2) { }

	// RVA: 0x2A75C10 Offset: 0x2A74610 VA: 0x182A75C10
	public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp) { }

	// RVA: 0x2A75E20 Offset: 0x2A74820 VA: 0x182A75E20
	public void .ctor(string profilerTag, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings) { }

	// RVA: 0x2A75D20 Offset: 0x2A74720 VA: 0x182A75D20
	internal void .ctor(URPProfileId profileId, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings) { }

	// RVA: 0x2A74EF0 Offset: 0x2A738F0 VA: 0x182A74EF0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2A75760 Offset: 0x2A74160 VA: 0x182A75760 Slot: 10
	internal override void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData) { }
}
