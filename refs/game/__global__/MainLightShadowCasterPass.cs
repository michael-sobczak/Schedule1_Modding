public class MainLightShadowCasterPass : ScriptableRenderPass // TypeDefIndex: 9162
{
	// Fields
	private const int k_MaxCascades = 4;
	private const int k_ShadowmapBufferBits = 16;
	private float m_CascadeBorder; // 0xE0
	private float m_MaxShadowDistanceSq; // 0xE4
	private int m_ShadowCasterCascadesCount; // 0xE8
	private int m_MainLightShadowmapID; // 0xEC
	internal RTHandle m_MainLightShadowmapTexture; // 0xF0
	private RTHandle m_EmptyMainLightShadowmapTexture; // 0xF8
	private const int k_EmptyShadowMapDimensions = 1;
	private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture";
	private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture";
	private static readonly Vector4 s_EmptyShadowParams; // 0x0
	private static readonly Vector4 s_EmptyShadowmapSize; // 0x10
	private Matrix4x4[] m_MainLightShadowMatrices; // 0x100
	private ShadowSliceData[] m_CascadeSlices; // 0x108
	private Vector4[] m_CascadeSplitDistances; // 0x110
	private bool m_CreateEmptyShadowmap; // 0x118
	private int renderTargetWidth; // 0x11C
	private int renderTargetHeight; // 0x120
	private ProfilingSampler m_ProfilingSetupSampler; // 0x128

	// Methods

	// RVA: 0x2B79000 Offset: 0x2B77A00 VA: 0x182B79000
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2B76C10 Offset: 0x2B75610 VA: 0x182B76C10
	public void Dispose() { }

	// RVA: 0x2B78920 Offset: 0x2B77320 VA: 0x182B78920
	public bool Setup(ref RenderingData renderingData) { }

	// RVA: 0x2B781F0 Offset: 0x2B76BF0 VA: 0x182B781F0
	private bool SetupForEmptyRendering(ref RenderingData renderingData) { }

	// RVA: 0x2B76BB0 Offset: 0x2B755B0 VA: 0x182B76BB0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2B76C50 Offset: 0x2B75650 VA: 0x182B76C50 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B76A10 Offset: 0x2B75410 VA: 0x182B76A10
	private void Clear() { }

	// RVA: 0x2B77F80 Offset: 0x2B76980 VA: 0x182B77F80
	private void SetEmptyMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B78110 Offset: 0x2B76B10 VA: 0x182B78110
	internal static void SetEmptyMainLightShadowParams(CommandBuffer cmd) { }

	// RVA: 0x2B76EB0 Offset: 0x2B758B0 VA: 0x182B76EB0
	private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B782D0 Offset: 0x2B76CD0 VA: 0x182B782D0
	private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref VisibleLight shadowLight, ref ShadowData shadowData) { }

	// RVA: 0x2B77640 Offset: 0x2B76040 VA: 0x182B77640
	internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData) { }

	// RVA: 0x2B76CE0 Offset: 0x2B756E0 VA: 0x182B76CE0
	private void InitPassData(ref MainLightShadowCasterPass.PassData passData, ref RenderingData renderingData, ref RenderGraph graph) { }

	// RVA: 0x2B78F90 Offset: 0x2B77990 VA: 0x182B78F90
	private static void .cctor() { }
}
