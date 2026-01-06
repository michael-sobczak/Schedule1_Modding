public struct CameraData // TypeDefIndex: 9074
{
	// Fields
	private Matrix4x4 m_ViewMatrix; // 0x0
	private Matrix4x4 m_ProjectionMatrix; // 0x40
	private Matrix4x4 m_JitterMatrix; // 0x80
	public Camera camera; // 0xC0
	public CameraRenderType renderType; // 0xC8
	public RenderTexture targetTexture; // 0xD0
	public RenderTextureDescriptor cameraTargetDescriptor; // 0xD8
	internal Rect pixelRect; // 0x10C
	internal bool useScreenCoordOverride; // 0x11C
	internal Vector4 screenSizeOverride; // 0x120
	internal Vector4 screenCoordScaleBias; // 0x130
	internal int pixelWidth; // 0x140
	internal int pixelHeight; // 0x144
	internal float aspectRatio; // 0x148
	public float renderScale; // 0x14C
	internal ImageScalingMode imageScalingMode; // 0x150
	internal ImageUpscalingFilter upscalingFilter; // 0x154
	internal bool fsrOverrideSharpness; // 0x158
	internal float fsrSharpness; // 0x15C
	internal HDRColorBufferPrecision hdrColorBufferPrecision; // 0x160
	public bool clearDepth; // 0x164
	public CameraType cameraType; // 0x168
	public bool isDefaultViewport; // 0x16C
	public bool isHdrEnabled; // 0x16D
	public bool allowHDROutput; // 0x16E
	public bool requiresDepthTexture; // 0x16F
	public bool requiresOpaqueTexture; // 0x170
	public bool postProcessingRequiresDepthTexture; // 0x171
	public bool xrRendering; // 0x172
	internal bool stackLastCameraOutputToHDR; // 0x173
	public SortingCriteria defaultOpaqueSortFlags; // 0x174
	[CompilerGenerated]
	private XRPass <xr>k__BackingField; // 0x178
	[Obsolete("Please use xr.enabled instead.", True)]
	public bool isStereoEnabled; // 0x180
	public float maxShadowDistance; // 0x184
	public bool postProcessEnabled; // 0x188
	internal bool stackAnyPostProcessingEnabled; // 0x189
	public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions; // 0x190
	public LayerMask volumeLayerMask; // 0x198
	public Transform volumeTrigger; // 0x1A0
	public bool isStopNaNEnabled; // 0x1A8
	public bool isDitheringEnabled; // 0x1A9
	public AntialiasingMode antialiasing; // 0x1AC
	public AntialiasingQuality antialiasingQuality; // 0x1B0
	public ScriptableRenderer renderer; // 0x1B8
	public bool resolveFinalTarget; // 0x1C0
	public Vector3 worldSpaceCameraPos; // 0x1C4
	public Color backgroundColor; // 0x1D0
	internal TaaPersistentData taaPersistentData; // 0x1E0
	internal TemporalAA.Settings taaSettings; // 0x1E8
	public Camera baseCamera; // 0x208

	// Properties
	public int scaledWidth { get; }
	public int scaledHeight { get; }
	internal bool requireSrgbConversion { get; }
	public bool isSceneViewCamera { get; }
	public bool isPreviewCamera { get; }
	internal bool isRenderPassSupportedCamera { get; }
	internal bool resolveToScreen { get; }
	public bool isHDROutputActive { get; }
	public HDROutputUtils.HDRDisplayInformation hdrDisplayInformation { get; }
	public ColorGamut hdrDisplayColorGamut { get; }
	public bool rendersOverlayUI { get; }
	public XRPass xr { get; set; }
	internal XRPassUniversal xrUniversal { get; }
	internal bool resetHistory { get; }

	// Methods

	// RVA: 0x2B41280 Offset: 0x2B3FC80 VA: 0x182B41280
	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix) { }

	// RVA: 0x2B41330 Offset: 0x2B3FD30 VA: 0x182B41330
	internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix) { }

	// RVA: 0x2B40DE0 Offset: 0x2B3F7E0 VA: 0x182B40DE0
	internal void PushBuiltinShaderConstantsXR(CommandBuffer cmd, bool renderIntoTexture) { }

	// RVA: 0x2B40670 Offset: 0x2B3F070 VA: 0x182B40670
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	// RVA: 0x2B404B0 Offset: 0x2B3EEB0 VA: 0x182B404B0
	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0) { }

	// RVA: 0x2B40410 Offset: 0x2B3EE10 VA: 0x182B40410
	internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0) { }

	// RVA: 0x2B400D0 Offset: 0x2B3EAD0 VA: 0x182B400D0
	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0) { }

	// RVA: 0x2B3FFA0 Offset: 0x2B3E9A0 VA: 0x182B3FFA0
	public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0) { }

	// RVA: 0x2B402C0 Offset: 0x2B3ECC0 VA: 0x182B402C0
	internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0) { }

	// RVA: 0x2B419A0 Offset: 0x2B403A0 VA: 0x182B419A0
	public int get_scaledWidth() { }

	// RVA: 0x2B41950 Offset: 0x2B40350 VA: 0x182B41950
	public int get_scaledHeight() { }

	// RVA: 0x2B416D0 Offset: 0x2B400D0 VA: 0x182B416D0
	internal bool get_requireSrgbConversion() { }

	// RVA: 0x2B41650 Offset: 0x2B40050 VA: 0x182B41650
	public bool get_isSceneViewCamera() { }

	// RVA: 0x2B41620 Offset: 0x2B40020 VA: 0x182B41620
	public bool get_isPreviewCamera() { }

	// RVA: 0x2B41630 Offset: 0x2B40030 VA: 0x182B41630
	internal bool get_isRenderPassSupportedCamera() { }

	// RVA: 0x2B418A0 Offset: 0x2B402A0 VA: 0x182B418A0
	internal bool get_resolveToScreen() { }

	// RVA: 0x2B41570 Offset: 0x2B3FF70 VA: 0x182B41570
	public bool get_isHDROutputActive() { }

	// RVA: 0x2B41440 Offset: 0x2B3FE40 VA: 0x182B41440
	public HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation() { }

	// RVA: 0x2B413B0 Offset: 0x2B3FDB0 VA: 0x182B413B0
	public ColorGamut get_hdrDisplayColorGamut() { }

	// RVA: 0x2B41660 Offset: 0x2B40060 VA: 0x182B41660
	public bool get_rendersOverlayUI() { }

	// RVA: 0x2B40A10 Offset: 0x2B3F410 VA: 0x182B40A10
	public bool IsHandleYFlipped(RTHandle handle) { }

	// RVA: 0x2B40710 Offset: 0x2B3F110 VA: 0x182B40710
	public bool IsCameraProjectionMatrixFlipped() { }

	// RVA: 0x2B40C50 Offset: 0x2B3F650 VA: 0x182B40C50
	public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth) { }

	// RVA: 0x2B40D10 Offset: 0x2B3F710 VA: 0x182B40D10
	internal bool IsTemporalAAEnabled() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	public XRPass get_xr() { }

	[CompilerGenerated]
	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0
	internal void set_xr(XRPass value) { }

	// RVA: 0x2B419F0 Offset: 0x2B403F0 VA: 0x182B419F0
	internal XRPassUniversal get_xrUniversal() { }

	// RVA: 0x2B41890 Offset: 0x2B40290 VA: 0x182B41890
	internal bool get_resetHistory() { }
}
