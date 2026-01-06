public class RenderTexture : Texture // TypeDefIndex: 11730
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	public GraphicsFormat graphicsFormat { get; set; }
	[NativeProperty("MipMap")]
	public bool useMipMap { get; set; }
	[NativeProperty("SRGBReadWrite")]
	public bool sRGB { get; }
	[NativeProperty("VRUsage")]
	public VRTextureUsage vrUsage { set; }
	[NativeProperty("Memoryless")]
	public RenderTextureMemoryless memorylessMode { set; }
	public RenderTextureFormat format { get; }
	public GraphicsFormat stencilFormat { set; }
	public GraphicsFormat depthStencilFormat { set; }
	public bool autoGenerateMips { set; }
	public int volumeDepth { get; set; }
	public int antiAliasing { get; set; }
	public bool bindTextureMS { set; }
	public bool enableRandomWrite { get; set; }
	public bool useDynamicScale { get; set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public int depth { get; }
	public RenderTextureDescriptor descriptor { get; }

	// Methods

	// RVA: 0x2CAFC30 Offset: 0x2CAE630 VA: 0x182CAFC30 Slot: 5
	public override int get_width() { }

	// RVA: 0x2CB0000 Offset: 0x2CAEA00 VA: 0x182CB0000 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x2CAFAF0 Offset: 0x2CAE4F0 VA: 0x182CAFAF0 Slot: 7
	public override int get_height() { }

	// RVA: 0x2CAFE20 Offset: 0x2CAE820 VA: 0x182CAFE20 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x2CAF930 Offset: 0x2CAE330 VA: 0x182CAF930 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x2CAFD90 Offset: 0x2CAE790 VA: 0x182CAFD90 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	[NativeName("GetColorFormat")]
	// RVA: 0x2CAD050 Offset: 0x2CABA50 VA: 0x182CAD050
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	[NativeName("SetColorFormat")]
	// RVA: 0x2CAE230 Offset: 0x2CACC30 VA: 0x182CAE230
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x2CAFAB0 Offset: 0x2CAE4B0 VA: 0x182CAFAB0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x2CAE230 Offset: 0x2CACC30 VA: 0x182CAE230
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x2CAFBB0 Offset: 0x2CAE5B0 VA: 0x182CAFBB0
	public bool get_useMipMap() { }

	// RVA: 0x2CAFF30 Offset: 0x2CAE930 VA: 0x182CAFF30
	public void set_useMipMap(bool value) { }

	// RVA: 0x2CAFB30 Offset: 0x2CAE530 VA: 0x182CAFB30
	public bool get_sRGB() { }

	// RVA: 0x2CAFFC0 Offset: 0x2CAE9C0 VA: 0x182CAFFC0
	public void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x2CAFE60 Offset: 0x2CAE860 VA: 0x182CAFE60
	public void set_memorylessMode(RenderTextureMemoryless value) { }

	// RVA: 0x2CAF9B0 Offset: 0x2CAE3B0 VA: 0x182CAF9B0
	public RenderTextureFormat get_format() { }

	// RVA: 0x2CAFEA0 Offset: 0x2CAE8A0 VA: 0x182CAFEA0
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x2CAFD50 Offset: 0x2CAE750 VA: 0x182CAFD50
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x2CAFCB0 Offset: 0x2CAE6B0 VA: 0x182CAFCB0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x2CAFBF0 Offset: 0x2CAE5F0 VA: 0x182CAFBF0
	public int get_volumeDepth() { }

	// RVA: 0x2CAFF80 Offset: 0x2CAE980 VA: 0x182CAFF80
	public void set_volumeDepth(int value) { }

	// RVA: 0x2CAF760 Offset: 0x2CAE160 VA: 0x182CAF760
	public int get_antiAliasing() { }

	// RVA: 0x2CAFC70 Offset: 0x2CAE670 VA: 0x182CAFC70
	public void set_antiAliasing(int value) { }

	// RVA: 0x2CAFD00 Offset: 0x2CAE700 VA: 0x182CAFD00
	public void set_bindTextureMS(bool value) { }

	// RVA: 0x2CAF970 Offset: 0x2CAE370 VA: 0x182CAF970
	public bool get_enableRandomWrite() { }

	// RVA: 0x2CAFDD0 Offset: 0x2CAE7D0 VA: 0x182CAFDD0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x2CAFB70 Offset: 0x2CAE570 VA: 0x182CAFB70
	public bool get_useDynamicScale() { }

	// RVA: 0x2CAFEE0 Offset: 0x2CAE8E0 VA: 0x182CAFEE0
	public void set_useDynamicScale(bool value) { }

	[FreeFunction("RenderTexture::GetActive")]
	// RVA: 0x2CACF80 Offset: 0x2CAB980 VA: 0x182CACF80
	private static RenderTexture GetActive() { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	// RVA: 0x2CAE1F0 Offset: 0x2CACBF0 VA: 0x182CAE1F0
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x2CACF80 Offset: 0x2CAB980 VA: 0x182CACF80
	public static RenderTexture get_active() { }

	// RVA: 0x2CAE1F0 Offset: 0x2CACBF0 VA: 0x182CAE1F0
	public static void set_active(RenderTexture value) { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	// RVA: 0x2CAD000 Offset: 0x2CABA00 VA: 0x182CAD000
	private RenderBuffer GetColorBuffer() { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	// RVA: 0x2CAD280 Offset: 0x2CABC80 VA: 0x182CAD280
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x2CAE270 Offset: 0x2CACC70 VA: 0x182CAE270
	private void SetMipMapCount(int count) { }

	// RVA: 0x2CAF7A0 Offset: 0x2CAE1A0 VA: 0x182CAF7A0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x2CAF800 Offset: 0x2CAE200 VA: 0x182CAF800
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x2CACF20 Offset: 0x2CAB920 VA: 0x182CACF20
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x2CACEE0 Offset: 0x2CAB8E0 VA: 0x182CACEE0
	public void DiscardContents() { }

	// RVA: 0x2CACEA0 Offset: 0x2CAB8A0 VA: 0x182CACEA0
	public bool Create() { }

	// RVA: 0x2CAE1B0 Offset: 0x2CACBB0 VA: 0x182CAE1B0
	public void Release() { }

	// RVA: 0x2CAE130 Offset: 0x2CACB30 VA: 0x182CAE130
	public bool IsCreated() { }

	// RVA: 0x2CAE350 Offset: 0x2CACD50 VA: 0x182CAE350
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunction("RenderTextureScripting::Create")]
	// RVA: 0x2CAE0F0 Offset: 0x2CACAF0 VA: 0x182CAE0F0
	private static void Internal_Create(RenderTexture rt) { }

	[NativeName("SetRenderTextureDescFromScript")]
	// RVA: 0x2CAE300 Offset: 0x2CACD00 VA: 0x182CAE300
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeName("GetRenderTextureDesc")]
	// RVA: 0x2CAD430 Offset: 0x2CABE30 VA: 0x182CAD430
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	// RVA: 0x2CAD5D0 Offset: 0x2CABFD0 VA: 0x182CAD5D0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	// RVA: 0x2CAE170 Offset: 0x2CACB70 VA: 0x182CAE170
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
	// RVA: 0x2CAF860 Offset: 0x2CAE260 VA: 0x182CAF860
	public int get_depth() { }

	[RequiredByNativeCode]
	// RVA: 0x2CAF330 Offset: 0x2CADD30 VA: 0x182CAF330
	protected internal void .ctor() { }

	// RVA: 0x2CAEBA0 Offset: 0x2CAD5A0 VA: 0x182CAEBA0
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x2CAF520 Offset: 0x2CADF20 VA: 0x182CAF520
	public void .ctor(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAF230 Offset: 0x2CADC30 VA: 0x182CAF230
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAE8F0 Offset: 0x2CAD2F0 VA: 0x182CAE8F0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAEF20 Offset: 0x2CAD920 VA: 0x182CAEF20
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAE990 Offset: 0x2CAD390 VA: 0x182CAE990
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAF480 Offset: 0x2CADE80 VA: 0x182CAF480
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x2CAF150 Offset: 0x2CADB50 VA: 0x182CAF150
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAEE00 Offset: 0x2CAD800 VA: 0x182CAEE00
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAECE0 Offset: 0x2CAD6E0 VA: 0x182CAECE0
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAF3B0 Offset: 0x2CADDB0 VA: 0x182CAF3B0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x2CADF40 Offset: 0x2CAC940 VA: 0x182CADF40
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x2CAD360 Offset: 0x2CABD60 VA: 0x182CAD360
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x2CAD350 Offset: 0x2CABD50 VA: 0x182CAD350
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	// RVA: 0x2CAD350 Offset: 0x2CABD50 VA: 0x182CAD350
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x2CAD2D0 Offset: 0x2CABCD0 VA: 0x182CAD2D0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x2CAF8A0 Offset: 0x2CAE2A0 VA: 0x182CAF8A0
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x2CAE3A0 Offset: 0x2CACDA0 VA: 0x182CAE3A0
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x2CAD1D0 Offset: 0x2CABBD0 VA: 0x182CAD1D0
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x2CAD200 Offset: 0x2CABC00 VA: 0x182CAD200
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x2CAD0A0 Offset: 0x2CABAA0 VA: 0x182CAD0A0
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x2CADC20 Offset: 0x2CAC620 VA: 0x182CADC20
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x2CAD490 Offset: 0x2CABE90 VA: 0x182CAD490
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	// RVA: 0x2CADDF0 Offset: 0x2CAC7F0 VA: 0x182CADDF0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAD880 Offset: 0x2CAC280 VA: 0x182CAD880
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAD740 Offset: 0x2CAC140 VA: 0x182CAD740
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAD9C0 Offset: 0x2CAC3C0 VA: 0x182CAD9C0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocs]
	// RVA: 0x2CADAF0 Offset: 0x2CAC4F0 VA: 0x182CADAF0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x2CADCC0 Offset: 0x2CAC6C0 VA: 0x182CADCC0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAD610 Offset: 0x2CAC010 VA: 0x182CAD610
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	// RVA: 0x2CACFB0 Offset: 0x2CAB9B0 VA: 0x182CACFB0
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x2CAD230 Offset: 0x2CABC30 VA: 0x182CAD230
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x2CAE2B0 Offset: 0x2CACCB0 VA: 0x182CAE2B0
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x2CAD3E0 Offset: 0x2CABDE0 VA: 0x182CAD3E0
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x2CAD590 Offset: 0x2CABF90 VA: 0x182CAD590
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }
}
