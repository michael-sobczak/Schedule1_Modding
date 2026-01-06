internal interface ILight2DCullResult // TypeDefIndex: 8701
{
	// Properties
	public abstract List<Light2D> visibleLights { get; }
	public abstract List<ShadowCasterGroup2D> visibleShadows { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<Light2D> get_visibleLights();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<ShadowCasterGroup2D> get_visibleShadows();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LightStats GetLightStatsByLayer(int layer);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsSceneLit();
}
