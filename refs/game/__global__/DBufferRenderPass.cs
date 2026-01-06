internal class DBufferRenderPass : ScriptableRenderPass // TypeDefIndex: 8828
{
	// Fields
	private static string[] s_DBufferNames; // 0x0
	private static string s_DBufferDepthName; // 0x8
	private DecalDrawDBufferSystem m_DrawSystem; // 0xE0
	private DBufferSettings m_Settings; // 0xE8
	private Material m_DBufferClear; // 0xF0
	private FilteringSettings m_FilteringSettings; // 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; // 0x110
	private ProfilingSampler m_ProfilingSampler; // 0x118
	private ProfilingSampler m_DBufferClearSampler; // 0x120
	private bool m_DecalLayers; // 0x128
	private RTHandle m_DBufferDepth; // 0x130
	[CompilerGenerated]
	private RTHandle[] <dBufferColorHandles>k__BackingField; // 0x138
	[CompilerGenerated]
	private RTHandle <depthHandle>k__BackingField; // 0x140

	// Properties
	internal RTHandle[] dBufferColorHandles { get; set; }
	internal RTHandle depthHandle { get; set; }
	internal RTHandle dBufferDepth { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	internal RTHandle[] get_dBufferColorHandles() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	private void set_dBufferColorHandles(RTHandle[] value) { }

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	internal RTHandle get_depthHandle() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	private void set_depthHandle(RTHandle value) { }

	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	internal RTHandle get_dBufferDepth() { }

	// RVA: 0x2AC65F0 Offset: 0x2AC4FF0 VA: 0x182AC65F0
	public void .ctor(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers) { }

	// RVA: 0x2AC5720 Offset: 0x2AC4120 VA: 0x182AC5720
	public void Dispose() { }

	// RVA: 0x2AC6340 Offset: 0x2AC4D40 VA: 0x182AC6340
	public void Setup(in CameraData cameraData) { }

	// RVA: 0x2AC5F30 Offset: 0x2AC4930 VA: 0x182AC5F30
	public void Setup(in CameraData cameraData, RTHandle depthTextureHandle) { }

	// RVA: 0x2AC5F10 Offset: 0x2AC4910 VA: 0x182AC5F10 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2AC57A0 Offset: 0x2AC41A0 VA: 0x182AC57A0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AC5DF0 Offset: 0x2AC47F0 VA: 0x182AC5DF0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2AC6480 Offset: 0x2AC4E80 VA: 0x182AC6480
	private static void .cctor() { }
}
