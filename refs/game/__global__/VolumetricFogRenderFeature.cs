public class VolumetricFogRenderFeature : ScriptableRendererFeature // TypeDefIndex: 9212
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private Shader blurShader; // 0x20
	private VolumetricFogRenderFeature.VolumetricFogRenderPass fogRenderPass; // 0x28
	private VolumetricFogRenderFeature.BlurRenderPass blurRenderPass; // 0x30
	public static bool installed; // 0x0
	public static bool isRenderingBeforeTransparents; // 0x1
	public RenderPassEvent renderPassEvent; // 0x38
	[Tooltip("Specify which fog volumes will be rendered by this feature.")]
	public LayerMask fogLayerMask; // 0x3C
	[Tooltip("Specify which cameras can execute this render feature. If you have several cameras in your scene, make sure only the correct cameras use this feature in order to optimize performance.")]
	public LayerMask cameraLayerMask; // 0x40
	[Tooltip("Ignores reflection probes from executing this render feature")]
	public bool ignoreReflectionProbes; // 0x44

	// Methods

	// RVA: 0x2A99B90 Offset: 0x2A98590 VA: 0x182A99B90
	public static int GetScaledSize(int size, float factor) { }

	// RVA: 0x2A99C30 Offset: 0x2A98630 VA: 0x182A99C30
	private void OnDisable() { }

	// RVA: 0x2A99BC0 Offset: 0x2A985C0 VA: 0x182A99BC0
	private void OnDestroy() { }

	// RVA: 0x2A99A10 Offset: 0x2A98410 VA: 0x182A99A10 Slot: 5
	public override void Create() { }

	// RVA: 0x2A99590 Offset: 0x2A97F90 VA: 0x182A99590 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2A99CF0 Offset: 0x2A986F0 VA: 0x182A99CF0
	public void .ctor() { }
}
