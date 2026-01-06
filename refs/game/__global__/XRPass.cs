public class XRPass // TypeDefIndex: 13497
{
	// Fields
	private readonly List<XRView> m_Views; // 0x10
	private readonly XROcclusionMesh m_OcclusionMesh; // 0x18
	[CompilerGenerated]
	private bool <copyDepth>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <multipassId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <cullingPassId>k__BackingField; // 0x28
	[CompilerGenerated]
	private RenderTargetIdentifier <renderTarget>k__BackingField; // 0x30
	[CompilerGenerated]
	private RenderTextureDescriptor <renderTargetDesc>k__BackingField; // 0x58
	[CompilerGenerated]
	private ScriptableCullingParameters <cullingParams>k__BackingField; // 0x90
	[CompilerGenerated]
	private IntPtr <foveatedRenderingInfo>k__BackingField; // 0x6C0
	[CompilerGenerated]
	private float <occlusionMeshScale>k__BackingField; // 0x6C8

	// Properties
	public bool enabled { get; }
	public bool supportsFoveatedRendering { get; }
	public bool copyDepth { get; set; }
	public int multipassId { get; set; }
	public int cullingPassId { get; set; }
	public RenderTargetIdentifier renderTarget { get; set; }
	public RenderTextureDescriptor renderTargetDesc { get; set; }
	public ScriptableCullingParameters cullingParams { get; set; }
	public int viewCount { get; }
	public bool singlePassEnabled { get; }
	public IntPtr foveatedRenderingInfo { get; set; }
	public bool isHDRDisplayOutputActive { get; }
	public ColorGamut hdrDisplayOutputColorGamut { get; }
	public HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation { get; }
	public float occlusionMeshScale { get; set; }
	public bool hasValidOcclusionMesh { get; }

	// Methods

	// RVA: 0x29E0EA0 Offset: 0x29DF8A0 VA: 0x1829E0EA0
	public void .ctor() { }

	// RVA: 0x29E0240 Offset: 0x29DEC40 VA: 0x1829E0240
	public static XRPass CreateDefault(XRPassCreateInfo createInfo) { }

	// RVA: 0x29E0AC0 Offset: 0x29DF4C0 VA: 0x1829E0AC0 Slot: 4
	public virtual void Release() { }

	// RVA: 0x29E0FA0 Offset: 0x29DF9A0 VA: 0x1829E0FA0
	public bool get_enabled() { }

	// RVA: 0x29E1550 Offset: 0x29DFF50 VA: 0x1829E1550
	public bool get_supportsFoveatedRendering() { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_copyDepth() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_copyDepth(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_multipassId() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	private void set_multipassId(int value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_cullingPassId() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_cullingPassId(int value) { }

	[CompilerGenerated]
	// RVA: 0x29E14E0 Offset: 0x29DFEE0 VA: 0x1829E14E0
	public RenderTargetIdentifier get_renderTarget() { }

	[CompilerGenerated]
	// RVA: 0x29E16E0 Offset: 0x29E00E0 VA: 0x1829E16E0
	private void set_renderTarget(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	// RVA: 0x29E14B0 Offset: 0x29DFEB0 VA: 0x1829E14B0
	public RenderTextureDescriptor get_renderTargetDesc() { }

	[CompilerGenerated]
	// RVA: 0x29E16B0 Offset: 0x29E00B0 VA: 0x1829E16B0
	private void set_renderTargetDesc(RenderTextureDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x29E0F70 Offset: 0x29DF970 VA: 0x1829E0F70
	public ScriptableCullingParameters get_cullingParams() { }

	[CompilerGenerated]
	// RVA: 0x29E1670 Offset: 0x29E0070 VA: 0x1829E1670
	private void set_cullingParams(ScriptableCullingParameters value) { }

	// RVA: 0x29E1630 Offset: 0x29E0030 VA: 0x1829E1630
	public int get_viewCount() { }

	// RVA: 0x29E1500 Offset: 0x29DFF00 VA: 0x1829E1500
	public bool get_singlePassEnabled() { }

	[CompilerGenerated]
	// RVA: 0x29E0FF0 Offset: 0x29DF9F0 VA: 0x1829E0FF0
	public IntPtr get_foveatedRenderingInfo() { }

	[CompilerGenerated]
	// RVA: 0x29E1690 Offset: 0x29E0090 VA: 0x1829E1690
	private void set_foveatedRenderingInfo(IntPtr value) { }

	// RVA: 0x29E13F0 Offset: 0x29DFDF0 VA: 0x1829E13F0
	public bool get_isHDRDisplayOutputActive() { }

	// RVA: 0x29E10D0 Offset: 0x29DFAD0 VA: 0x1829E10D0
	public ColorGamut get_hdrDisplayOutputColorGamut() { }

	// RVA: 0x29E1180 Offset: 0x29DFB80 VA: 0x1829E1180
	public HDROutputUtils.HDRDisplayInformation get_hdrDisplayOutputInformation() { }

	[CompilerGenerated]
	// RVA: 0x29E14A0 Offset: 0x29DFEA0 VA: 0x1829E14A0
	public float get_occlusionMeshScale() { }

	[CompilerGenerated]
	// RVA: 0x29E16A0 Offset: 0x29E00A0 VA: 0x1829E16A0
	private void set_occlusionMeshScale(float value) { }

	// RVA: 0x29E05D0 Offset: 0x29DEFD0 VA: 0x1829E05D0
	public Matrix4x4 GetProjMatrix(int viewIndex = 0) { }

	// RVA: 0x29E06E0 Offset: 0x29DF0E0 VA: 0x1829E06E0
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	// RVA: 0x29E0780 Offset: 0x29DF180 VA: 0x1829E0780
	public Rect GetViewport(int viewIndex = 0) { }

	// RVA: 0x29E0560 Offset: 0x29DEF60 VA: 0x1829E0560
	public Mesh GetOcclusionMesh(int viewIndex = 0) { }

	// RVA: 0x29E0670 Offset: 0x29DF070 VA: 0x1829E0670
	public int GetTextureArraySlice(int viewIndex = 0) { }

	// RVA: 0x29E0B60 Offset: 0x29DF560 VA: 0x1829E0B60
	public void StartSinglePass(CommandBuffer cmd) { }

	// RVA: 0x29E0D90 Offset: 0x29DF790 VA: 0x1829E0D90
	public void StopSinglePass(CommandBuffer cmd) { }

	// RVA: 0x29E1000 Offset: 0x29DFA00 VA: 0x1829E1000
	public bool get_hasValidOcclusionMesh() { }

	// RVA: 0x29E0B20 Offset: 0x29DF520 VA: 0x1829E0B20
	public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = False) { }

	// RVA: 0x29DFEB0 Offset: 0x29DE8B0 VA: 0x1829DFEB0
	public Vector4 ApplyXRViewCenterOffset(Vector2 center) { }

	// RVA: 0x29E00F0 Offset: 0x29DEAF0 VA: 0x1829E00F0
	internal void AssignView(int viewId, XRView xrView) { }

	// RVA: 0x29E0060 Offset: 0x29DEA60 VA: 0x1829E0060
	internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams) { }

	// RVA: 0x29E0E80 Offset: 0x29DF880 VA: 0x1829E0E80
	internal void UpdateCombinedOcclusionMesh() { }

	// RVA: 0x29E0800 Offset: 0x29DF200 VA: 0x1829E0800
	public void InitBase(XRPassCreateInfo createInfo) { }

	// RVA: 0x29DFBC0 Offset: 0x29DE5C0 VA: 0x1829DFBC0
	internal void AddView(XRView xrView) { }
}
