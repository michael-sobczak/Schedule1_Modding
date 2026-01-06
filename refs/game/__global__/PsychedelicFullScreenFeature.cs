public class PsychedelicFullScreenFeature : ScriptableRendererFeature // TypeDefIndex: 3394
{
	// Fields
	[Header("Settings")]
	[SerializeField]
	private PsychedelicFullScreenFeature.Settings _settings; // 0x20
	private static readonly int BLEND_ID; // 0x0
	private static readonly int NOISE_SCALE_ID; // 0x4
	private static readonly int PAN_SPEED_ID; // 0x8
	private static readonly int DOES_BOUNCE_ID; // 0xC
	private static readonly int AMPLITUDE_ID; // 0x10
	private PsychedelicFullScreenPass _psychedelicPass; // 0x28

	// Properties
	public PsychedelicFullScreenFeature.Settings FeatureSettings { get; }
	public PsychedelicFullScreenFeature.MaterialProperties ActiveMaterialProperties { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public PsychedelicFullScreenFeature.Settings get_FeatureSettings() { }

	// RVA: 0xA77FE0 Offset: 0xA769E0 VA: 0x180A77FE0
	public PsychedelicFullScreenFeature.MaterialProperties get_ActiveMaterialProperties() { }

	// RVA: 0xA77A70 Offset: 0xA76470 VA: 0x180A77A70 Slot: 5
	public override void Create() { }

	// RVA: 0xA77980 Offset: 0xA76380 VA: 0x180A77980 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0xA77D80 Offset: 0xA76780 VA: 0x180A77D80
	public void SetActiveMaterialProperties(PsychedelicFullScreenFeature.MaterialProperties properties) { }

	// RVA: 0xA77CB0 Offset: 0xA766B0 VA: 0x180A77CB0
	public void PrintMaterialValue() { }

	// RVA: 0xA77B50 Offset: 0xA76550 VA: 0x180A77B50
	public PsychedelicFullScreenData GetMaterialPreset(string presetName) { }

	// RVA: 0xA77F30 Offset: 0xA76930 VA: 0x180A77F30
	public void .ctor() { }

	// RVA: 0xA77E30 Offset: 0xA76830 VA: 0x180A77E30
	private static void .cctor() { }
}
