public class TimeOfDayController : MonoBehaviour // TypeDefIndex: 468
{
	// Fields
	[CompilerGenerated]
	private static TimeOfDayController <instance>k__BackingField; // 0x0
	[Tooltip("Sky profile defines the skyColors configuration for times of day. This script will animate between those skyColors values based on the time of day.")]
	[SerializeField]
	private SkyProfile m_SkyProfile; // 0x20
	[Tooltip("Time is expressed in a fractional number of days that have completed.")]
	[SerializeField]
	private float m_SkyTime; // 0x28
	[Tooltip("Automatically advance time at fixed speed.")]
	public bool automaticTimeIncrement; // 0x2C
	[Tooltip("Create a copy of the sky profile at runtime, so modifications don't affect the original Sky Profile in your project.")]
	public bool copySkyProfile; // 0x2D
	private SkyMaterialController m_SkyMaterialController; // 0x30
	[Range(0, 1)]
	[Tooltip("Speed at which to advance time by if in automatic increment is enabled.")]
	public float automaticIncrementSpeed; // 0x38
	[Tooltip("Sun orbit.")]
	public OrbitingBody sunOrbit; // 0x40
	[Tooltip("Moon orbit.")]
	public OrbitingBody moonOrbit; // 0x48
	[Tooltip("Controller for managing weather effects")]
	public WeatherController weatherController; // 0x50
	[Tooltip("If true we'll invoke DynamicGI.UpdateEnvironment() when skybox changes. This is an expensive operation.")]
	public bool updateGlobalIllumination; // 0x58
	[Tooltip("Configurable prefab that determines how to animate between 2 sky profiles. You can override individual feature animations, ex: 'skyBlender', to create a custom sky blending effect.")]
	public BlendSkyProfiles skyProfileTransitionPrefab; // 0x60
	[Header("Overrides")]
	public SkyProfileOverride[] SkyProfileOverrideStack; // 0x68
	[CompilerGenerated]
	private TimeOfDayController.TimeOfDayDidChange timeChangedCallback; // 0x70
	private bool m_DidInitialUpdate; // 0x78

	// Properties
	public static TimeOfDayController instance { get; set; }
	public SkyProfile skyProfile { get; set; }
	public float skyTime { get; set; }
	public SkyMaterialController SkyMaterial { get; }
	public float timeOfDay { get; }
	public int daysElapsed { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9F8520 Offset: 0x9F6F20 VA: 0x1809F8520
	public static TimeOfDayController get_instance() { }

	[CompilerGenerated]
	// RVA: 0x9F8620 Offset: 0x9F7020 VA: 0x1809F8620
	private static void set_instance(TimeOfDayController value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public SkyProfile get_skyProfile() { }

	// RVA: 0x9F8680 Offset: 0x9F7080 VA: 0x1809F8680
	public void set_skyProfile(SkyProfile value) { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_skyTime() { }

	// RVA: 0x9F8760 Offset: 0x9F7160 VA: 0x1809F8760
	public void set_skyTime(float value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public SkyMaterialController get_SkyMaterial() { }

	[CompilerGenerated]
	// RVA: 0x9F8470 Offset: 0x9F6E70 VA: 0x1809F8470
	public void add_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value) { }

	[CompilerGenerated]
	// RVA: 0x9F8580 Offset: 0x9F6F80 VA: 0x1809F8580
	public void remove_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value) { }

	// RVA: 0x9F8560 Offset: 0x9F6F60 VA: 0x1809F8560
	public float get_timeOfDay() { }

	// RVA: 0x9F8510 Offset: 0x9F6F10 VA: 0x1809F8510
	public int get_daysElapsed() { }

	// RVA: 0x9F1F20 Offset: 0x9F0920 VA: 0x1809F1F20
	private void Awake() { }

	// RVA: 0x9F2200 Offset: 0x9F0C00 VA: 0x1809F2200
	private void OnEnabled() { }

	// RVA: 0x9F2220 Offset: 0x9F0C20 VA: 0x1809F2220
	private void OnValidate() { }

	// RVA: 0x9F8400 Offset: 0x9F6E00 VA: 0x1809F8400
	private void WarnInvalidSkySetup() { }

	// RVA: 0x9F7CF0 Offset: 0x9F66F0 VA: 0x1809F7CF0
	private void Update() { }

	// RVA: 0x9F2940 Offset: 0x9F1340 VA: 0x1809F2940
	public void UpdateGlobalIllumination() { }

	// RVA: 0x9F2610 Offset: 0x9F1010 VA: 0x1809F2610
	private void SynchronizeAllShaderKeywords() { }

	// RVA: 0x9F27F0 Offset: 0x9F11F0 VA: 0x1809F27F0
	private void SynchronizedShaderKeyword(string featureKey, string shaderKeyword) { }

	// RVA: 0x9F2010 Offset: 0x9F0A10 VA: 0x1809F2010
	private Vector3 GetPrimaryLightDirection() { }

	// RVA: 0x9F2280 Offset: 0x9F0C80 VA: 0x1809F2280
	public bool StartSkyProfileTransition(SkyProfile toProfile, float duration = 1) { }

	// RVA: 0x9F1F80 Offset: 0x9F0980 VA: 0x1809F1F80
	public void CancelSkyProfileTransition() { }

	// RVA: 0x9F21C0 Offset: 0x9F0BC0 VA: 0x1809F21C0
	public void OnBlendComplete(BlendSkyProfiles blender) { }

	// RVA: 0x9F2150 Offset: 0x9F0B50 VA: 0x1809F2150
	public bool IsBlendingInProgress() { }

	// RVA: 0x9F2950 Offset: 0x9F1350 VA: 0x1809F2950
	public void UpdateSkyForCurrentTime() { }

	// RVA: 0x9F8460 Offset: 0x9F6E60 VA: 0x1809F8460
	public void .ctor() { }
}
