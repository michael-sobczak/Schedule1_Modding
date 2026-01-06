internal sealed class MultiScaleVO : IAmbientOcclusionMethod // TypeDefIndex: 16989
{
	// Fields
	private readonly float[] m_SampleThickness; // 0x10
	private readonly float[] m_InvThicknessTable; // 0x18
	private readonly float[] m_SampleWeightTable; // 0x20
	private readonly int[] m_Widths; // 0x28
	private readonly int[] m_Heights; // 0x30
	private readonly int[] m_ScaledWidths; // 0x38
	private readonly int[] m_ScaledHeights; // 0x40
	private AmbientOcclusion m_Settings; // 0x48
	private PropertySheet m_PropertySheet; // 0x50
	private PostProcessResources m_Resources; // 0x58
	private RenderTexture m_AmbientOnlyAO; // 0x60
	private RenderTextureFormat m_R8Format; // 0x68
	private RenderTextureFormat m_R16Format; // 0x6C
	private bool float4Texture; // 0x70
	private readonly RenderTargetIdentifier[] m_MRT; // 0x78

	// Methods

	// RVA: 0x29A4380 Offset: 0x29A2D80 VA: 0x1829A4380
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void SetResources(PostProcessResources resources) { }

	// RVA: 0x29A04A0 Offset: 0x299EEA0 VA: 0x1829A04A0
	private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale) { }

	// RVA: 0x29A0340 Offset: 0x299ED40 VA: 0x1829A0340
	private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale) { }

	// RVA: 0x1A37CD0 Offset: 0x1A366D0 VA: 0x181A37CD0
	private void Release(CommandBuffer cmd, int id) { }

	// RVA: 0x29A0680 Offset: 0x299F080 VA: 0x1829A0680
	private Vector4 CalculateZBufferParams(Camera camera) { }

	// RVA: 0x29A0600 Offset: 0x299F000 VA: 0x1829A0600
	private float CalculateTanHalfFovHeight(Camera camera) { }

	// RVA: 0x29A1980 Offset: 0x29A0380 VA: 0x1829A1980
	private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x29A1920 Offset: 0x29A0320 VA: 0x1829A1920
	private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x29A0BB0 Offset: 0x299F5B0 VA: 0x1829A0BB0
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	// RVA: 0x29A1B50 Offset: 0x29A0550 VA: 0x1829A1B50
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA, Camera camera) { }

	// RVA: 0x29A23C0 Offset: 0x29A0DC0 VA: 0x1829A23C0
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	// RVA: 0x29A2F10 Offset: 0x29A1910 VA: 0x1829A2F10
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	// RVA: 0x29A3760 Offset: 0x29A2160 VA: 0x1829A3760
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

	// RVA: 0x29A2CF0 Offset: 0x29A16F0 VA: 0x1829A2CF0
	private void PushReleaseCommands(CommandBuffer cmd) { }

	// RVA: 0x29A19E0 Offset: 0x29A03E0 VA: 0x1829A19E0
	private void PreparePropertySheet(PostProcessRenderContext context) { }

	// RVA: 0x29A0730 Offset: 0x299F130 VA: 0x1829A0730
	private void CheckAOTexture(PostProcessRenderContext context) { }

	// RVA: 0x29A2310 Offset: 0x29A0D10 VA: 0x1829A2310
	private void PushDebug(PostProcessRenderContext context) { }

	// RVA: 0x29A3D70 Offset: 0x29A2770 VA: 0x1829A3D70 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x29A41C0 Offset: 0x29A2BC0 VA: 0x1829A41C0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x29A0960 Offset: 0x299F360 VA: 0x1829A0960 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x29A3D00 Offset: 0x29A2700 VA: 0x1829A3D00 Slot: 8
	public void Release() { }
}
