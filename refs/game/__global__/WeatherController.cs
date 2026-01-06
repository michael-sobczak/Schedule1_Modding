public class WeatherController : MonoBehaviour // TypeDefIndex: 492
{
	// Fields
	[CompilerGenerated]
	private RainDownfallController <rainDownfallController>k__BackingField; // 0x20
	[CompilerGenerated]
	private RainSplashController <rainSplashController>k__BackingField; // 0x28
	[CompilerGenerated]
	private LightningController <lightningController>k__BackingField; // 0x30
	[CompilerGenerated]
	private WeatherDepthCamera <weatherDepthCamera>k__BackingField; // 0x38
	private WeatherEnclosure m_Enclosure; // 0x40
	private MeshRenderer m_EnclosureMeshRenderer; // 0x48
	private WeatherEnclosureDetector detector; // 0x50
	private SkyProfile m_Profile; // 0x58
	private float m_TimeOfDay; // 0x60

	// Properties
	public RainDownfallController rainDownfallController { get; set; }
	public RainSplashController rainSplashController { get; set; }
	public LightningController lightningController { get; set; }
	public WeatherDepthCamera weatherDepthCamera { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public RainDownfallController get_rainDownfallController() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_rainDownfallController(RainDownfallController value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public RainSplashController get_rainSplashController() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_rainSplashController(RainSplashController value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public LightningController get_lightningController() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_lightningController(LightningController value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public WeatherDepthCamera get_weatherDepthCamera() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_weatherDepthCamera(WeatherDepthCamera value) { }

	// RVA: 0xA93760 Offset: 0xA92160 VA: 0x180A93760
	private void Awake() { }

	// RVA: 0xA93760 Offset: 0xA92160 VA: 0x180A93760
	private void Start() { }

	// RVA: 0xA93AD0 Offset: 0xA924D0 VA: 0x180A93AD0
	private void OnEnable() { }

	// RVA: 0xA93770 Offset: 0xA92170 VA: 0x180A93770
	private void DiscoverWeatherControllers() { }

	// RVA: 0xA93990 Offset: 0xA92390 VA: 0x180A93990
	private void OnDisable() { }

	// RVA: 0xA93D30 Offset: 0xA92730 VA: 0x180A93D30
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0xA93870 Offset: 0xA92270 VA: 0x180A93870
	private void LateUpdate() { }

	// RVA: 0xA93C60 Offset: 0xA92660 VA: 0x180A93C60
	private void OnEnclosureDidChange(WeatherEnclosure enclosure) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
