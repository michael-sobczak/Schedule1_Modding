public class CopyColorPass : ScriptableRenderPass // TypeDefIndex: 9133
{
	// Fields
	private int m_SampleOffsetShaderHandle; // 0xE0
	private Material m_SamplingMaterial; // 0xE8
	private Downsampling m_DownsamplingMethod; // 0xF0
	private Material m_CopyColorMaterial; // 0xF8
	[CompilerGenerated]
	private RTHandle <source>k__BackingField; // 0x100
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; // 0x108
	[CompilerGenerated]
	private int <destinationID>k__BackingField; // 0x110
	private CopyColorPass.PassData m_PassData; // 0x118

	// Properties
	private RTHandle source { get; set; }
	private RTHandle destination { get; set; }
	private int destinationID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	private RTHandle get_source() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	private void set_source(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	private RTHandle get_destination() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	private void set_destination(RTHandle value) { }

	[CompilerGenerated]
	// RVA: 0x21FCF70 Offset: 0x21FB970 VA: 0x1821FCF70
	private int get_destinationID() { }

	[CompilerGenerated]
	// RVA: 0x21FD300 Offset: 0x21FBD00 VA: 0x1821FD300
	private void set_destinationID(int value) { }

	// RVA: 0x2B60BC0 Offset: 0x2B5F5C0 VA: 0x182B60BC0
	public void .ctor(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial) { }

	// RVA: 0x2B5F760 Offset: 0x2B5E160 VA: 0x182B5F760
	public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[Obsolete("Use RTHandles for source and destination.")]
	// RVA: 0x2B60A90 Offset: 0x2B5F490 VA: 0x182B60A90
	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling) { }

	// RVA: 0x2B60A30 Offset: 0x2B5F430 VA: 0x182B60A30
	public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling) { }

	// RVA: 0x2B60000 Offset: 0x2B5EA00 VA: 0x182B60000 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B5FC40 Offset: 0x2B5E640 VA: 0x182B5FC40 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B5F7F0 Offset: 0x2B5E1F0 VA: 0x182B5F7F0
	private static void ExecutePass(CopyColorPass.PassData passData, RTHandle source, RTHandle destination, ref CommandBuffer cmd, bool useDrawProceduralBlit, bool disableFoveatedRenderingForPass) { }

	// RVA: 0x2B601F0 Offset: 0x2B5EBF0 VA: 0x182B601F0
	internal TextureHandle Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, Downsampling downsampling, ref RenderingData renderingData) { }

	// RVA: 0x2B5FEE0 Offset: 0x2B5E8E0 VA: 0x182B5FEE0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}
