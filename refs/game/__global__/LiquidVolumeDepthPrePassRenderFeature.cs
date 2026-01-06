public class LiquidVolumeDepthPrePassRenderFeature : ScriptableRendererFeature // TypeDefIndex: 396
{
	// Fields
	public static readonly List<LiquidVolume> lvBackRenderers; // 0x0
	public static readonly List<LiquidVolume> lvFrontRenderers; // 0x8
	[HideInInspector]
	[SerializeField]
	private Shader shader; // 0x20
	public static bool installed; // 0x10
	private Material mat; // 0x28
	private LiquidVolumeDepthPrePassRenderFeature.DepthPass backPass; // 0x30
	private LiquidVolumeDepthPrePassRenderFeature.DepthPass frontPass; // 0x38
	[Tooltip("Renders each irregular liquid volume completely before rendering the next one.")]
	public bool interleavedRendering; // 0x40
	public RenderPassEvent renderPassEvent; // 0x44

	// Methods

	// RVA: 0x8C7B30 Offset: 0x8C6530 VA: 0x1808C7B30
	public static void AddLiquidToBackRenderers(LiquidVolume lv) { }

	// RVA: 0x8C81D0 Offset: 0x8C6BD0 VA: 0x1808C81D0
	public static void RemoveLiquidFromBackRenderers(LiquidVolume lv) { }

	// RVA: 0x8C7C50 Offset: 0x8C6650 VA: 0x1808C7C50
	public static void AddLiquidToFrontRenderers(LiquidVolume lv) { }

	// RVA: 0x8C82E0 Offset: 0x8C6CE0 VA: 0x1808C82E0
	public static void RemoveLiquidFromFrontRenderers(LiquidVolume lv) { }

	// RVA: 0x8C80A0 Offset: 0x8C6AA0 VA: 0x1808C80A0
	private void OnDestroy() { }

	// RVA: 0x8C7F10 Offset: 0x8C6910 VA: 0x1808C7F10 Slot: 5
	public override void Create() { }

	// RVA: 0x8C7D70 Offset: 0x8C6770 VA: 0x1808C7D70 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x8C84C0 Offset: 0x8C6EC0 VA: 0x1808C84C0
	public void .ctor() { }

	// RVA: 0x8C83F0 Offset: 0x8C6DF0 VA: 0x1808C83F0
	private static void .cctor() { }
}
