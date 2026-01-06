public class ForwardRendererData : ScriptableRendererData // TypeDefIndex: 8885
{
	// Fields
	private const string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";
	public ForwardRendererData.ShaderResources shaders; // 0x40
	public PostProcessData postProcessData; // 0x48
	[Reload("Runtime/Data/XRSystemData.asset", 1)]
	public XRSystemData xrSystemData; // 0x50
	[SerializeField]
	private LayerMask m_OpaqueLayerMask; // 0x58
	[SerializeField]
	private LayerMask m_TransparentLayerMask; // 0x5C
	[SerializeField]
	private StencilStateData m_DefaultStencilState; // 0x60
	[SerializeField]
	private bool m_ShadowTransparentReceive; // 0x68
	[SerializeField]
	private RenderingMode m_RenderingMode; // 0x6C
	[SerializeField]
	private DepthPrimingMode m_DepthPrimingMode; // 0x70
	[SerializeField]
	private bool m_AccurateGbufferNormals; // 0x74
	[SerializeField]
	private bool m_ClusteredRendering; // 0x75
	[SerializeField]
	private TileSize m_TileSize; // 0x78

	// Properties
	public LayerMask opaqueLayerMask { get; set; }
	public LayerMask transparentLayerMask { get; set; }
	public StencilStateData defaultStencilState { get; set; }
	public bool shadowTransparentReceive { get; set; }
	public RenderingMode renderingMode { get; set; }
	public bool accurateGbufferNormals { get; set; }

	// Methods

	// RVA: 0x2B010D0 Offset: 0x2AFFAD0 VA: 0x182B010D0 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x2B01210 Offset: 0x2AFFC10 VA: 0x182B01210
	public LayerMask get_opaqueLayerMask() { }

	// RVA: 0x2B013F0 Offset: 0x2AFFDF0 VA: 0x182B013F0
	public void set_opaqueLayerMask(LayerMask value) { }

	// RVA: 0x2B01300 Offset: 0x2AFFD00 VA: 0x182B01300
	public LayerMask get_transparentLayerMask() { }

	// RVA: 0x2B014E0 Offset: 0x2AFFEE0 VA: 0x182B014E0
	public void set_transparentLayerMask(LayerMask value) { }

	// RVA: 0x2B011C0 Offset: 0x2AFFBC0 VA: 0x182B011C0
	public StencilStateData get_defaultStencilState() { }

	// RVA: 0x2B013A0 Offset: 0x2AFFDA0 VA: 0x182B013A0
	public void set_defaultStencilState(StencilStateData value) { }

	// RVA: 0x2B012B0 Offset: 0x2AFFCB0 VA: 0x182B012B0
	public bool get_shadowTransparentReceive() { }

	// RVA: 0x2B01490 Offset: 0x2AFFE90 VA: 0x182B01490
	public void set_shadowTransparentReceive(bool value) { }

	// RVA: 0x2B01260 Offset: 0x2AFFC60 VA: 0x182B01260
	public RenderingMode get_renderingMode() { }

	// RVA: 0x2B01440 Offset: 0x2AFFE40 VA: 0x182B01440
	public void set_renderingMode(RenderingMode value) { }

	// RVA: 0x2B01170 Offset: 0x2AFFB70 VA: 0x182B01170
	public bool get_accurateGbufferNormals() { }

	// RVA: 0x2B01350 Offset: 0x2AFFD50 VA: 0x182B01350
	public void set_accurateGbufferNormals(bool value) { }

	// RVA: 0x2B01160 Offset: 0x2AFFB60 VA: 0x182B01160
	public void .ctor() { }
}
