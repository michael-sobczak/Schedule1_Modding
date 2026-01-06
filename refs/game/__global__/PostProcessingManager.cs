public class PostProcessingManager : Singleton<PostProcessingManager> // TypeDefIndex: 3390
{
	// Fields
	[Header("References")]
	public UniversalRendererData rendererData; // 0x28
	public Volume GlobalVolume; // 0x30
	[Header("Vignette")]
	public float Vig_DefaultIntensity; // 0x38
	public float Vig_DefaultSmoothness; // 0x3C
	[Header("Blur")]
	public float MinBlur; // 0x40
	public float MaxBlur; // 0x44
	[Header("Smoothers")]
	public FloatSmoother ChromaticAberrationController; // 0x48
	public FloatSmoother SaturationController; // 0x50
	public FloatSmoother BloomController; // 0x58
	public HDRColorSmoother ColorFilterController; // 0x60
	private Vignette vig; // 0x68
	private DepthOfField DoF; // 0x70
	private GodRaysVolume GodRays; // 0x78
	private ColorAdjustments ColorAdjustments; // 0x80
	private Beautify beautifySettings; // 0x88
	private Bloom bloom; // 0x90
	private ChromaticAberration chromaticAberration; // 0x98
	private ColorAdjustments colorAdjustments; // 0xA0
	private PsychedelicFullScreenFeature _psychedelicFullScreenFeature; // 0xA8

	// Methods

	// RVA: 0xA766F0 Offset: 0xA750F0 VA: 0x180A766F0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA77690 Offset: 0xA76090 VA: 0x180A77690
	public void Update() { }

	// RVA: 0xA76DF0 Offset: 0xA757F0 VA: 0x180A76DF0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0xA77470 Offset: 0xA75E70 VA: 0x180A77470
	private void UpdateEffects() { }

	// RVA: 0xA76EA0 Offset: 0xA758A0 VA: 0x180A76EA0
	public void OverrideVignette(float intensity, float smoothness) { }

	// RVA: 0xA76FF0 Offset: 0xA759F0 VA: 0x180A76FF0
	public void ResetVignette() { }

	// RVA: 0xA77160 Offset: 0xA75B60 VA: 0x180A77160
	public void SetGodRayIntensity(float intensity) { }

	// RVA: 0xA77120 Offset: 0xA75B20 VA: 0x180A77120
	public void SetContrast(float value) { }

	// RVA: 0xA77440 Offset: 0xA75E40 VA: 0x180A77440
	public void SetSaturation(float value) { }

	// RVA: 0xA77060 Offset: 0xA75A60 VA: 0x180A77060
	public void SetBloomThreshold(float threshold) { }

	// RVA: 0xA770A0 Offset: 0xA75AA0 VA: 0x180A770A0
	public void SetBlur(float blurLevel) { }

	// RVA: 0xA771A0 Offset: 0xA75BA0 VA: 0x180A771A0
	public void SetPsychedelicEffectActive(bool isActive) { }

	// RVA: 0xA77230 Offset: 0xA75C30 VA: 0x180A77230
	public void SetPsychedelicEffectProperties(PsychedelicFullScreenData data) { }

	// RVA: 0xA77380 Offset: 0xA75D80 VA: 0x180A77380
	public void SetPsychedelicEffectProperties(PsychedelicFullScreenFeature.MaterialProperties properties) { }

	// RVA: 0xA76D90 Offset: 0xA75790 VA: 0x180A76D90
	public PsychedelicFullScreenFeature.MaterialProperties GetActivePsychedelicEffectProperties() { }

	// RVA: 0xA76DC0 Offset: 0xA757C0 VA: 0x180A76DC0
	public PsychedelicFullScreenData GetPsychedelicEffectDataPreset(string presetName) { }

	// RVA: 0xA76F10 Offset: 0xA75910 VA: 0x180A76F10
	public void PrintValueOfPsychedelicEffectBlend() { }

	// RVA: 0xA776A0 Offset: 0xA760A0 VA: 0x180A776A0
	public void .ctor() { }
}
