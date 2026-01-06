internal class Light2DCullResult : ILight2DCullResult // TypeDefIndex: 8703
{
	// Fields
	private List<Light2D> m_VisibleLights; // 0x10
	private List<ShadowCasterGroup2D> m_VisibleShadows; // 0x18

	// Properties
	public List<Light2D> visibleLights { get; }
	public List<ShadowCasterGroup2D> visibleShadows { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public List<Light2D> get_visibleLights() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public List<ShadowCasterGroup2D> get_visibleShadows() { }

	// RVA: 0x2A7BE50 Offset: 0x2A7A850 VA: 0x182A7BE50 Slot: 7
	public bool IsSceneLit() { }

	// RVA: 0x2A7BC70 Offset: 0x2A7A670 VA: 0x182A7BC70 Slot: 6
	public LightStats GetLightStatsByLayer(int layer) { }

	// RVA: 0x2A7BEF0 Offset: 0x2A7A8F0 VA: 0x182A7BEF0
	public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera) { }

	// RVA: 0x2A7C800 Offset: 0x2A7B200 VA: 0x182A7C800
	public void .ctor() { }
}
