public struct RenderTextureDescriptor // TypeDefIndex: 11732
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <width>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <msaaSamples>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <volumeDepth>k__BackingField; // 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <depthStencilFormat>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextureDimension <dimension>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { get; set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public GraphicsFormat stencilFormat { set; }
	public GraphicsFormat depthStencilFormat { get; set; }
	public RenderTextureFormat colorFormat { get; set; }
	public bool sRGB { get; set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { get; set; }
	public ShadowSamplingMode shadowSamplingMode { get; set; }
	public VRTextureUsage vrUsage { get; set; }
	public RenderTextureMemoryless memoryless { get; set; }
	public bool useMipMap { get; set; }
	public bool autoGenerateMips { get; set; }
	public bool enableRandomWrite { get; set; }
	public bool bindMS { get; set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_width() { }

	[CompilerGenerated]
	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_width(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_height() { }

	[CompilerGenerated]
	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_height(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_msaaSamples() { }

	[CompilerGenerated]
	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_msaaSamples(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_volumeDepth() { }

	[CompilerGenerated]
	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_volumeDepth(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_mipCount() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_mipCount(int value) { }

	// RVA: 0x1667070 Offset: 0x1665A70 VA: 0x181667070
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x2CACCE0 Offset: 0x2CAB6E0 VA: 0x182CACCE0
	public void set_graphicsFormat(GraphicsFormat value) { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_stencilFormat(GraphicsFormat value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public GraphicsFormat get_depthStencilFormat() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x2CACA30 Offset: 0x2CAB430 VA: 0x182CACA30
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x2CACBB0 Offset: 0x2CAB5B0 VA: 0x182CACBB0
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x2CACB00 Offset: 0x2CAB500 VA: 0x182CACB00
	public bool get_sRGB() { }

	// RVA: 0x2CACDA0 Offset: 0x2CAB7A0 VA: 0x182CACDA0
	public void set_sRGB(bool value) { }

	// RVA: 0x2CACAA0 Offset: 0x2CAB4A0 VA: 0x182CACAA0
	public int get_depthBufferBits() { }

	// RVA: 0x2CACC90 Offset: 0x2CAB690 VA: 0x182CACC90
	public void set_depthBufferBits(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public TextureDimension get_dimension() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_dimension(TextureDimension value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public VRTextureUsage get_vrUsage() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_memoryless(RenderTextureMemoryless value) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC4F0 Offset: 0x2CAAEF0 VA: 0x182CAC4F0
	public void .ctor(int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC780 Offset: 0x2CAB180 VA: 0x182CAC780
	public void .ctor(int width, int height, RenderTextureFormat colorFormat) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC960 Offset: 0x2CAB360 VA: 0x182CAC960
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC510 Offset: 0x2CAAF10 VA: 0x182CAC510
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC6E0 Offset: 0x2CAB0E0 VA: 0x182CAC6E0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x2CAC830 Offset: 0x2CAB230 VA: 0x182CAC830
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC7A0 Offset: 0x2CAB1A0 VA: 0x182CAC7A0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC600 Offset: 0x2CAB000 VA: 0x182CAC600
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	// RVA: 0x2CAC710 Offset: 0x2CAB110 VA: 0x182CAC710
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x2CAC4D0 Offset: 0x2CAAED0 VA: 0x182CAC4D0
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x2CACB60 Offset: 0x2CAB560 VA: 0x182CACB60
	public bool get_useMipMap() { }

	// RVA: 0x2CACE80 Offset: 0x2CAB880 VA: 0x182CACE80
	public void set_useMipMap(bool value) { }

	// RVA: 0x2CACA10 Offset: 0x2CAB410 VA: 0x182CACA10
	public bool get_autoGenerateMips() { }

	// RVA: 0x2CACB70 Offset: 0x2CAB570 VA: 0x182CACB70
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x2CACAF0 Offset: 0x2CAB4F0 VA: 0x182CACAF0
	public bool get_enableRandomWrite() { }

	// RVA: 0x2CACCC0 Offset: 0x2CAB6C0 VA: 0x182CACCC0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x2CACA20 Offset: 0x2CAB420 VA: 0x182CACA20
	public bool get_bindMS() { }

	// RVA: 0x2CACB90 Offset: 0x2CAB590 VA: 0x182CACB90
	public void set_bindMS(bool value) { }

	// RVA: 0x2CACC70 Offset: 0x2CAB670 VA: 0x182CACC70
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x2CACB50 Offset: 0x2CAB550 VA: 0x182CACB50
	public bool get_useDynamicScale() { }

	// RVA: 0x2CACE60 Offset: 0x2CAB860 VA: 0x182CACE60
	public void set_useDynamicScale(bool value) { }
}
