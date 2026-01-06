public class StylizedWaterRenderFeature : ScriptableRendererFeature // TypeDefIndex: 18267
{
	// Fields
	public StylizedWaterRenderFeature.ScreenSpaceReflectionSettings screenSpaceReflectionSettings; // 0x20
	[Tooltip("Project caustics from the main directional light.")]
	public bool directionalCaustics; // 0x28
	public DisplacementPrePass.Settings displacementPrePassSettings; // 0x30
	private SetupConstants constantsSetup; // 0x38
	private DisplacementPrePass displacementPass; // 0x40

	// Methods

	// RVA: 0x1F6F810 Offset: 0x1F6E210 VA: 0x181F6F810
	public static StylizedWaterRenderFeature GetDefault() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnEnable() { }

	// RVA: 0x1F6F6B0 Offset: 0x1F6E0B0 VA: 0x181F6F6B0 Slot: 5
	public override void Create() { }

	// RVA: 0x1F6F550 Offset: 0x1F6DF50 VA: 0x181F6F550 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x1F6F890 Offset: 0x1F6E290 VA: 0x181F6F890
	private void OnDestroy() { }

	// RVA: 0x1F6F9D0 Offset: 0x1F6E3D0 VA: 0x181F6F9D0
	public void .ctor() { }
}
