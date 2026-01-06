public class DepthRenderPrePassFeature : ScriptableRendererFeature // TypeDefIndex: 9205
{
	// Fields
	private DepthRenderPrePassFeature.DepthRenderPass m_ScriptablePass; // 0x20
	public static bool installed; // 0x0
	[Tooltip("Specify which cameras can execute this render feature. If you have several cameras in your scene, make sure only the correct cameras use this feature in order to optimize performance.")]
	public LayerMask cameraLayerMask; // 0x28
	[Tooltip("Ignores reflection probes from executing this render feature")]
	public bool ignoreReflectionProbes; // 0x2C
	[Tooltip("Uses an optimized shader to compute depth for the objects included in the transparent pass. If this option is disabled, the original shader of the objects will be used instead (this can be useful if the original shaders include vertex transformations).")]
	public bool useOptimizedDepthOnlyShader; // 0x2D

	// Methods

	// RVA: 0x2A91F40 Offset: 0x2A90940 VA: 0x182A91F40 Slot: 5
	public override void Create() { }

	// RVA: 0x2A91FB0 Offset: 0x2A909B0 VA: 0x182A91FB0
	private void OnDestroy() { }

	// RVA: 0x2A91D90 Offset: 0x2A90790 VA: 0x182A91D90 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2A92060 Offset: 0x2A90A60 VA: 0x182A92060
	public void .ctor() { }
}
