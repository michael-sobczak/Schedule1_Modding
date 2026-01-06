public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver // TypeDefIndex: 9057
{
	// Fields
	public PostProcessData postProcessData; // 0x40
	[Reload("Runtime/Data/XRSystemData.asset", 1)]
	public XRSystemData xrSystemData; // 0x48
	public UniversalRendererData.ShaderResources shaders; // 0x50
	private const int k_LatestAssetVersion = 2;
	[SerializeField]
	private int m_AssetVersion; // 0x58
	[SerializeField]
	private LayerMask m_OpaqueLayerMask; // 0x5C
	[SerializeField]
	private LayerMask m_TransparentLayerMask; // 0x60
	[SerializeField]
	private StencilStateData m_DefaultStencilState; // 0x68
	[SerializeField]
	private bool m_ShadowTransparentReceive; // 0x70
	[SerializeField]
	private RenderingMode m_RenderingMode; // 0x74
	[SerializeField]
	private DepthPrimingMode m_DepthPrimingMode; // 0x78
	[SerializeField]
	private CopyDepthMode m_CopyDepthMode; // 0x7C
	[SerializeField]
	private bool m_AccurateGbufferNormals; // 0x80
	[SerializeField]
	private IntermediateTextureMode m_IntermediateTextureMode; // 0x84

	// Properties
	public LayerMask opaqueLayerMask { get; set; }
	public LayerMask transparentLayerMask { get; set; }
	public StencilStateData defaultStencilState { get; set; }
	public bool shadowTransparentReceive { get; set; }
	public RenderingMode renderingMode { get; set; }
	public DepthPrimingMode depthPrimingMode { get; set; }
	public CopyDepthMode copyDepthMode { get; set; }
	public bool accurateGbufferNormals { get; set; }
	public IntermediateTextureMode intermediateTextureMode { get; set; }

	// Methods

	// RVA: 0x2B576C0 Offset: 0x2B560C0 VA: 0x182B576C0 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public LayerMask get_opaqueLayerMask() { }

	// RVA: 0x2B57930 Offset: 0x2B56330 VA: 0x182B57930
	public void set_opaqueLayerMask(LayerMask value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public LayerMask get_transparentLayerMask() { }

	// RVA: 0x2B579C0 Offset: 0x2B563C0 VA: 0x182B579C0
	public void set_transparentLayerMask(LayerMask value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public StencilStateData get_defaultStencilState() { }

	// RVA: 0x2B57890 Offset: 0x2B56290 VA: 0x182B57890
	public void set_defaultStencilState(StencilStateData value) { }

	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_shadowTransparentReceive() { }

	// RVA: 0x2B57990 Offset: 0x2B56390 VA: 0x182B57990
	public void set_shadowTransparentReceive(bool value) { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	public RenderingMode get_renderingMode() { }

	// RVA: 0x2B57960 Offset: 0x2B56360 VA: 0x182B57960
	public void set_renderingMode(RenderingMode value) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public DepthPrimingMode get_depthPrimingMode() { }

	// RVA: 0x2B578D0 Offset: 0x2B562D0 VA: 0x182B578D0
	public void set_depthPrimingMode(DepthPrimingMode value) { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public CopyDepthMode get_copyDepthMode() { }

	// RVA: 0x2B57860 Offset: 0x2B56260 VA: 0x182B57860
	public void set_copyDepthMode(CopyDepthMode value) { }

	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_accurateGbufferNormals() { }

	// RVA: 0x2B57830 Offset: 0x2B56230 VA: 0x182B57830
	public void set_accurateGbufferNormals(bool value) { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public IntermediateTextureMode get_intermediateTextureMode() { }

	// RVA: 0x2B57900 Offset: 0x2B56300 VA: 0x182B57900
	public void set_intermediateTextureMode(IntermediateTextureMode value) { }

	// RVA: 0x2B57740 Offset: 0x2B56140 VA: 0x182B57740 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ReloadAllNullProperties() { }

	// RVA: 0x2B57770 Offset: 0x2B56170 VA: 0x182B57770 Slot: 7
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2B57750 Offset: 0x2B56150 VA: 0x182B57750 Slot: 8
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2B57780 Offset: 0x2B56180 VA: 0x182B57780
	public void .ctor() { }
}
