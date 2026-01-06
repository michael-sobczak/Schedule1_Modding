public class EnvironmentFX : Singleton<EnvironmentFX> // TypeDefIndex: 3383
{
	// Fields
	[SerializeField]
	[Header("References")]
	protected WindZone windZone; // 0x28
	[SerializeField]
	protected TimeOfDayController timeOfDayController; // 0x30
	public VolumetricFog VolumetricFog; // 0x38
	public Light SunLight; // 0x40
	public Light MoonLight; // 0x48
	[SerializeField]
	[Header("Height Fog")]
	protected Gradient HeightFogColor; // 0x50
	[SerializeField]
	protected AnimationCurve HeightFogIntensityCurve; // 0x58
	[SerializeField]
	protected float HeightFogIntensityMultiplier; // 0x60
	[SerializeField]
	protected AnimationCurve HeightFogDirectionalIntensityCurve; // 0x68
	[Header("Volumetric Fog")]
	[SerializeField]
	protected Gradient VolumetricFogColor; // 0x70
	[SerializeField]
	protected AnimationCurve VolumetricFogIntensityCurve; // 0x78
	[SerializeField]
	protected float VolumetricFogIntensityMultiplier; // 0x80
	[Header("Fog")]
	[SerializeField]
	private float fogEndDistanceMultiplier; // 0x84
	[SerializeField]
	[Header("God rays")]
	protected AnimationCurve godRayIntensityCurve; // 0x88
	[Header("Contrast")]
	[SerializeField]
	protected AnimationCurve contrastCurve; // 0x90
	[SerializeField]
	protected float contractMultiplier; // 0x98
	[Header("Saturation")]
	[SerializeField]
	protected AnimationCurve saturationCurve; // 0xA0
	[SerializeField]
	protected float saturationMultiplier; // 0xA8
	[SerializeField]
	[Header("Grass")]
	protected Material grassMat; // 0xB0
	[SerializeField]
	protected Gradient grassColorGradient; // 0xB8
	[Header("Trees")]
	public Material distanceTreeMat; // 0xC0
	public AnimationCurve distanceTreeColorCurve; // 0xC8
	[Header("Stealth settings")]
	public AnimationCurve environmentalBrightnessCurve; // 0xD0
	[Header("Bloom")]
	public AnimationCurve bloomThreshholdCurve; // 0xD8
	[SerializeField]
	[Header("Gloabl Shader Properties")]
	private float _environmentScrollSpeed; // 0xE0
	[SerializeField]
	private float _testPercentage; // 0xE4
	private float _scrollTime; // 0xE8
	private float _scrollValue; // 0xEC
	private bool _scrollTActive; // 0xF0
	private bool started; // 0xF1
	public FloatSmoother FogEndDistanceController; // 0xF8

	// Properties
	public float normalizedEnvironmentalBrightness { get; }
	public float FogEndDistanceMultiplier { get; }

	// Methods

	// RVA: 0xA646C0 Offset: 0xA630C0 VA: 0x180A646C0
	public float get_normalizedEnvironmentalBrightness() { }

	// RVA: 0xA64690 Offset: 0xA63090 VA: 0x180A64690
	public float get_FogEndDistanceMultiplier() { }

	// RVA: 0xA63CE0 Offset: 0xA626E0 VA: 0x180A63CE0 Slot: 4
	protected override void Start() { }

	// RVA: 0xA64420 Offset: 0xA62E20 VA: 0x180A64420
	private void Update() { }

	// RVA: 0xA63E50 Offset: 0xA62850 VA: 0x180A63E50
	private void UpdateVisuals() { }

	// RVA: 0xA63CC0 Offset: 0xA626C0 VA: 0x180A63CC0
	public void SetEnvironmentScrollingActive(bool active) { }

	// RVA: 0xA63CD0 Offset: 0xA626D0 VA: 0x180A63CD0
	public void SetEnvironmentScrollingSpeedByPercentage(float percentage) { }

	// RVA: 0xA63C80 Offset: 0xA62680 VA: 0x180A63C80 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0xA64620 Offset: 0xA63020 VA: 0x180A64620
	public void .ctor() { }
}
