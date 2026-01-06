public abstract class ScriptableRenderPass // TypeDefIndex: 8861
{
	// Fields
	public static RTHandle k_CameraTarget; // 0x0
	[CompilerGenerated]
	private RenderPassEvent <renderPassEvent>k__BackingField; // 0x10
	private RenderBufferStoreAction[] m_ColorStoreActions; // 0x18
	private RenderBufferStoreAction m_DepthStoreAction; // 0x20
	private bool[] m_OverriddenColorStoreActions; // 0x28
	private bool m_OverriddenDepthStoreAction; // 0x30
	[CompilerGenerated]
	private ProfilingSampler <profilingSampler>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <overrideCameraTarget>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <isBlitRenderPass>k__BackingField; // 0x41
	[CompilerGenerated]
	private bool <useNativeRenderPass>k__BackingField; // 0x42
	[CompilerGenerated]
	private int <renderPassQueueIndex>k__BackingField; // 0x44
	internal NativeArray<int> m_ColorAttachmentIndices; // 0x48
	internal NativeArray<int> m_InputAttachmentIndices; // 0x58
	[CompilerGenerated]
	private GraphicsFormat[] <renderTargetFormat>k__BackingField; // 0x68
	internal bool m_UsesRTHandles; // 0x70
	private RTHandle[] m_ColorAttachments; // 0x78
	private RenderTargetIdentifier[] m_ColorAttachmentIds; // 0x80
	internal RTHandle[] m_InputAttachments; // 0x88
	internal bool[] m_InputAttachmentIsTransient; // 0x90
	private RTHandle m_DepthAttachment; // 0x98
	private RenderTargetIdentifier m_DepthAttachmentId; // 0xA0
	private ScriptableRenderPassInput m_Input; // 0xC8
	private ClearFlag m_ClearFlag; // 0xCC
	private Color m_ClearColor; // 0xD0

	// Properties
	public RenderPassEvent renderPassEvent { get; set; }
	[Obsolete("Use colorAttachmentHandles")]
	public RenderTargetIdentifier[] colorAttachments { get; }
	[Obsolete("Use colorAttachmentHandle")]
	public RenderTargetIdentifier colorAttachment { get; }
	[Obsolete("Use depthAttachmentHandle")]
	public RenderTargetIdentifier depthAttachment { get; }
	public RTHandle[] colorAttachmentHandles { get; }
	public RTHandle colorAttachmentHandle { get; }
	public RTHandle depthAttachmentHandle { get; }
	public RenderBufferStoreAction[] colorStoreActions { get; }
	public RenderBufferStoreAction depthStoreAction { get; }
	internal bool[] overriddenColorStoreActions { get; }
	internal bool overriddenDepthStoreAction { get; }
	public ScriptableRenderPassInput input { get; }
	public ClearFlag clearFlag { get; }
	public Color clearColor { get; }
	protected internal ProfilingSampler profilingSampler { get; set; }
	internal bool overrideCameraTarget { get; set; }
	internal bool isBlitRenderPass { get; set; }
	internal bool useNativeRenderPass { get; set; }
	internal int renderPassQueueIndex { get; set; }
	internal GraphicsFormat[] renderTargetFormat { get; set; }

	// Methods

	[EditorBrowsable(1)]
	// RVA: 0x2250F20 Offset: 0x224F920 VA: 0x182250F20 Slot: 4
	public virtual void FrameCleanup(CommandBuffer cmd) { }

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public RenderPassEvent get_renderPassEvent() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_renderPassEvent(RenderPassEvent value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public RenderTargetIdentifier[] get_colorAttachments() { }

	// RVA: 0x2AEA9E0 Offset: 0x2AE93E0 VA: 0x182AEA9E0
	public RenderTargetIdentifier get_colorAttachment() { }

	// RVA: 0x2AEAA30 Offset: 0x2AE9430 VA: 0x182AEAA30
	public RenderTargetIdentifier get_depthAttachment() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public RTHandle[] get_colorAttachmentHandles() { }

	// RVA: 0x1EDFB20 Offset: 0x1EDE520 VA: 0x181EDFB20
	public RTHandle get_colorAttachmentHandle() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public RTHandle get_depthAttachmentHandle() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public RenderBufferStoreAction[] get_colorStoreActions() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public RenderBufferStoreAction get_depthStoreAction() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal bool[] get_overriddenColorStoreActions() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	internal bool get_overriddenDepthStoreAction() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public ScriptableRenderPassInput get_input() { }

	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	public ClearFlag get_clearFlag() { }

	// RVA: 0x8D2100 Offset: 0x8D0B00 VA: 0x1808D2100
	public Color get_clearColor() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	protected internal ProfilingSampler get_profilingSampler() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected internal void set_profilingSampler(ProfilingSampler value) { }

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	internal bool get_overrideCameraTarget() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	internal void set_overrideCameraTarget(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	internal bool get_isBlitRenderPass() { }

	[CompilerGenerated]
	// RVA: 0x242D200 Offset: 0x242BC00 VA: 0x18242D200
	internal void set_isBlitRenderPass(bool value) { }

	[CompilerGenerated]
	// RVA: 0xC31540 Offset: 0xC2FF40 VA: 0x180C31540
	internal bool get_useNativeRenderPass() { }

	[CompilerGenerated]
	// RVA: 0xC31570 Offset: 0xC2FF70 VA: 0x180C31570
	internal void set_useNativeRenderPass(bool value) { }

	[CompilerGenerated]
	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	internal int get_renderPassQueueIndex() { }

	[CompilerGenerated]
	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	internal void set_renderPassQueueIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal GraphicsFormat[] get_renderTargetFormat() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	internal void set_renderTargetFormat(GraphicsFormat[] value) { }

	// RVA: 0x2AE9F20 Offset: 0x2AE8920 VA: 0x182AE9F20
	internal static DebugHandler GetActiveDebugHandler(ref RenderingData renderingData) { }

	// RVA: 0x2AEA460 Offset: 0x2AE8E60 VA: 0x182AEA460
	public void .ctor() { }

	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	public void ConfigureInput(ScriptableRenderPassInput passInput) { }

	// RVA: 0x2AE8D80 Offset: 0x2AE7780 VA: 0x182AE8D80
	public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0) { }

	// RVA: 0x2AE8DD0 Offset: 0x2AE77D0 VA: 0x182AE8DD0
	public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions) { }

	// RVA: 0x2AE8EA0 Offset: 0x2AE78A0 VA: 0x182AE8EA0
	public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction) { }

	// RVA: 0x2AE8EB0 Offset: 0x2AE78B0 VA: 0x182AE8EB0
	internal void ConfigureInputAttachments(RTHandle input, bool isTransient = False) { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	internal void ConfigureInputAttachments(RTHandle[] inputs) { }

	// RVA: 0x2AE8F50 Offset: 0x2AE7950 VA: 0x182AE8F50
	internal void ConfigureInputAttachments(RTHandle[] inputs, bool[] isTransient) { }

	// RVA: 0x2AEA360 Offset: 0x2AE8D60 VA: 0x182AEA360
	internal void SetInputAttachmentTransient(int idx, bool isTransient) { }

	// RVA: 0x2AEA0D0 Offset: 0x2AE8AD0 VA: 0x182AEA0D0
	internal bool IsInputAttachmentTransient(int idx) { }

	// RVA: 0x2AEA1B0 Offset: 0x2AE8BB0 VA: 0x182AEA1B0
	public void ResetTarget() { }

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	// RVA: 0x2AE90F0 Offset: 0x2AE7AF0 VA: 0x182AE90F0
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	// RVA: 0x2AE9AE0 Offset: 0x2AE84E0 VA: 0x182AE9AE0
	public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment) { }

	[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
	// RVA: 0x2AE8FA0 Offset: 0x2AE79A0 VA: 0x182AE8FA0
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment) { }

	// RVA: 0x2AE96F0 Offset: 0x2AE80F0 VA: 0x182AE96F0
	public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment) { }

	// RVA: 0x2AE9A70 Offset: 0x2AE8470 VA: 0x182AE9A70
	internal void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment, GraphicsFormat[] formats) { }

	[Obsolete("Use RTHandle for colorAttachment")]
	// RVA: 0x2AE9430 Offset: 0x2AE7E30 VA: 0x182AE9430
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment) { }

	// RVA: 0x2AE9220 Offset: 0x2AE7C20 VA: 0x182AE9220
	public void ConfigureTarget(RTHandle colorAttachment) { }

	[Obsolete("Use RTHandles for colorAttachments")]
	// RVA: 0x2AE9520 Offset: 0x2AE7F20 VA: 0x182AE9520
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments) { }

	// RVA: 0x2AE9A00 Offset: 0x2AE8400 VA: 0x182AE9A00
	public void ConfigureTarget(RTHandle[] colorAttachments) { }

	// RVA: 0x2AE8D60 Offset: 0x2AE7760 VA: 0x182AE8D60
	public void ConfigureClear(ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void OnFinishCameraStackRendering(CommandBuffer cmd) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

	// RVA: 0x2AEA110 Offset: 0x2AE8B10 VA: 0x182AEA110 Slot: 10
	internal virtual void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData) { }

	[Obsolete("Use RTHandles for source and destination")]
	// RVA: 0x2AE8A90 Offset: 0x2AE7490 VA: 0x182AE8A90
	public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0) { }

	// RVA: 0x2AE8970 Offset: 0x2AE7370 VA: 0x182AE8970
	public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int passIndex = 0) { }

	// RVA: 0x2AE8CA0 Offset: 0x2AE76A0 VA: 0x182AE8CA0
	public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0) { }

	// RVA: 0x2AE8C40 Offset: 0x2AE7640 VA: 0x182AE8C40
	public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0) { }

	// RVA: 0x2AE9E20 Offset: 0x2AE8820 VA: 0x182AE9E20
	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	// RVA: 0x2AE9D20 Offset: 0x2AE8720 VA: 0x182AE9D20
	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	// RVA: 0x2AEAB10 Offset: 0x2AE9510 VA: 0x182AEAB10
	public static bool op_LessThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	// RVA: 0x2AEAAE0 Offset: 0x2AE94E0 VA: 0x182AEAAE0
	public static bool op_GreaterThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	// RVA: 0x2AE9F70 Offset: 0x2AE8970 VA: 0x182AE9F70
	internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent) { }

	// RVA: 0x2AEA390 Offset: 0x2AE8D90 VA: 0x182AEA390
	private static void .cctor() { }
}
