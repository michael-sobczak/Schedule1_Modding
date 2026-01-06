public sealed class PostProcessRenderContext // TypeDefIndex: 17053
{
	// Fields
	private Camera m_Camera; // 0x10
	[CompilerGenerated]
	private CommandBuffer <command>k__BackingField; // 0x18
	[CompilerGenerated]
	private RenderTargetIdentifier <source>k__BackingField; // 0x20
	[CompilerGenerated]
	private RenderTargetIdentifier <destination>k__BackingField; // 0x48
	[CompilerGenerated]
	private RenderTextureFormat <sourceFormat>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <flip>k__BackingField; // 0x74
	[CompilerGenerated]
	private PostProcessResources <resources>k__BackingField; // 0x78
	[CompilerGenerated]
	private PropertySheetFactory <propertySheets>k__BackingField; // 0x80
	[CompilerGenerated]
	private Dictionary<string, object> <userData>k__BackingField; // 0x88
	[CompilerGenerated]
	private PostProcessDebugLayer <debugLayer>k__BackingField; // 0x90
	[CompilerGenerated]
	private int <width>k__BackingField; // 0x98
	[CompilerGenerated]
	private int <height>k__BackingField; // 0x9C
	[CompilerGenerated]
	private bool <stereoActive>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <xrActiveEye>k__BackingField; // 0xA4
	[CompilerGenerated]
	private int <numberOfEyes>k__BackingField; // 0xA8
	[CompilerGenerated]
	private PostProcessRenderContext.StereoRenderingMode <stereoRenderingMode>k__BackingField; // 0xAC
	[CompilerGenerated]
	private int <screenWidth>k__BackingField; // 0xB0
	[CompilerGenerated]
	private int <screenHeight>k__BackingField; // 0xB4
	[CompilerGenerated]
	private bool <isSceneView>k__BackingField; // 0xB8
	[CompilerGenerated]
	private PostProcessLayer.Antialiasing <antialiasing>k__BackingField; // 0xBC
	[CompilerGenerated]
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; // 0xC0
	internal PropertySheet uberSheet; // 0xC8
	internal Texture autoExposureTexture; // 0xD0
	internal LogHistogram logHistogram; // 0xD8
	internal Texture logLut; // 0xE0
	internal AutoExposure autoExposure; // 0xE8
	internal int bloomBufferNameID; // 0xF0
	internal bool physicalCamera; // 0xF4
	private RenderTextureDescriptor m_sourceDescriptor; // 0xF8

	// Properties
	public Camera camera { get; set; }
	public CommandBuffer command { get; set; }
	public RenderTargetIdentifier source { get; set; }
	public RenderTargetIdentifier destination { get; set; }
	public RenderTextureFormat sourceFormat { get; set; }
	public bool flip { get; set; }
	public PostProcessResources resources { get; set; }
	public PropertySheetFactory propertySheets { get; set; }
	public Dictionary<string, object> userData { get; set; }
	public PostProcessDebugLayer debugLayer { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public bool stereoActive { get; set; }
	public int xrActiveEye { get; set; }
	public int numberOfEyes { get; set; }
	public PostProcessRenderContext.StereoRenderingMode stereoRenderingMode { get; set; }
	public int screenWidth { get; set; }
	public int screenHeight { get; set; }
	public bool isSceneView { get; set; }
	public PostProcessLayer.Antialiasing antialiasing { get; set; }
	public TemporalAntialiasing temporalAntialiasing { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Camera get_camera() { }

	// RVA: 0x29B9EF0 Offset: 0x29B88F0 VA: 0x1829B9EF0
	public void set_camera(Camera value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public CommandBuffer get_command() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_command(CommandBuffer value) { }

	[CompilerGenerated]
	// RVA: 0x29B9ED0 Offset: 0x29B88D0 VA: 0x1829B9ED0
	public RenderTargetIdentifier get_source() { }

	[CompilerGenerated]
	// RVA: 0x29BA0C0 Offset: 0x29B8AC0 VA: 0x1829BA0C0
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	// RVA: 0x29B9EB0 Offset: 0x29B88B0 VA: 0x1829B9EB0
	public RenderTargetIdentifier get_destination() { }

	[CompilerGenerated]
	// RVA: 0x29BA0A0 Offset: 0x29B8AA0 VA: 0x1829BA0A0
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGenerated]
	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGenerated]
	// RVA: 0x658700 Offset: 0x657100 VA: 0x180658700
	public bool get_flip() { }

	[CompilerGenerated]
	// RVA: 0x658840 Offset: 0x657240 VA: 0x180658840
	public void set_flip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public PostProcessResources get_resources() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	internal void set_resources(PostProcessResources value) { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public Dictionary<string, object> get_userData() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGenerated]
	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public int get_width() { }

	[CompilerGenerated]
	// RVA: 0x4B7090 Offset: 0x4B5A90 VA: 0x1804B7090
	private void set_width(int value) { }

	[CompilerGenerated]
	// RVA: 0x614470 Offset: 0x612E70 VA: 0x180614470
	public int get_height() { }

	[CompilerGenerated]
	// RVA: 0x286EEA0 Offset: 0x286D8A0 VA: 0x18286EEA0
	private void set_height(int value) { }

	[CompilerGenerated]
	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	public bool get_stereoActive() { }

	[CompilerGenerated]
	// RVA: 0xAE7D60 Offset: 0xAE6760 VA: 0x180AE7D60
	private void set_stereoActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	public int get_xrActiveEye() { }

	[CompilerGenerated]
	// RVA: 0xBBA830 Offset: 0xBB9230 VA: 0x180BBA830
	public void set_xrActiveEye(int value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public int get_numberOfEyes() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	private void set_numberOfEyes(int value) { }

	[CompilerGenerated]
	// RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGenerated]
	// RVA: 0xBBA820 Offset: 0xBB9220 VA: 0x180BBA820
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGenerated]
	// RVA: 0xBBA740 Offset: 0xBB9140 VA: 0x180BBA740
	public int get_screenWidth() { }

	[CompilerGenerated]
	// RVA: 0xBBA7C0 Offset: 0xBB91C0 VA: 0x180BBA7C0
	private void set_screenWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x10F9570 Offset: 0x10F7F70 VA: 0x1810F9570
	public int get_screenHeight() { }

	[CompilerGenerated]
	// RVA: 0x10F9800 Offset: 0x10F8200 VA: 0x1810F9800
	private void set_screenHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x4E8DE0 Offset: 0x4E77E0 VA: 0x1804E8DE0
	public bool get_isSceneView() { }

	[CompilerGenerated]
	// RVA: 0x4E8EA0 Offset: 0x4E78A0 VA: 0x1804E8EA0
	internal void set_isSceneView(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E8B70 Offset: 0x4E7570 VA: 0x1804E8B70
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGenerated]
	// RVA: 0x4E8E00 Offset: 0x4E7800 VA: 0x1804E8E00
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGenerated]
	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	// RVA: 0x29B9B20 Offset: 0x29B8520 VA: 0x1829B9B20
	public void Reset() { }

	// RVA: 0x29B9A80 Offset: 0x29B8480 VA: 0x1829B9A80
	public bool IsTemporalAntialiasingActive() { }

	// RVA: 0x29B9A50 Offset: 0x29B8450 VA: 0x1829B9A50
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	// RVA: 0x29B9AC0 Offset: 0x29B84C0 VA: 0x1829B9AC0
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x29B9700 Offset: 0x29B8100 VA: 0x1829B9700
	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x29B98B0 Offset: 0x29B82B0 VA: 0x1829B98B0
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x29B99C0 Offset: 0x29B83C0 VA: 0x1829B99C0
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x29B9D80 Offset: 0x29B8780 VA: 0x1829B9D80
	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
