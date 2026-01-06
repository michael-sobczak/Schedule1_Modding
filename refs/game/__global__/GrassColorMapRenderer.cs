public class GrassColorMapRenderer : MonoBehaviour // TypeDefIndex: 18848
{
	// Fields
	public static GrassColorMapRenderer Instance; // 0x0
	public UniversalRendererData renderData; // 0x20
	public GrassColorMap colorMap; // 0x28
	[Tooltip("These objects can be Unity Terrains or custom Mesh Terrains. Their size can be used to automatically fit the render area")]
	public List<GameObject> terrainObjects; // 0x30
	public int resIdx; // 0x38
	public int resolution; // 0x3C
	[Tooltip("Objects set to this layer will be included in the render")]
	public LayerMask renderLayer; // 0x40
	[Tooltip("Render objects on specific layers into the color map. When disabled, the terrain(s) are temporarily moved up 1000 units")]
	public bool useLayers; // 0x44
	[Tooltip("Enable this option if you're using a custom terrain shader which greatly alters the terrain color (eg. global noise).

When disabled, the terrains are temporarily rendered using an Unlit shader (based on the default Unity terrain shader)

This only applies to Unity terrain, not meshes")]
	public bool thirdPartyShader; // 0x45
	public Camera renderCam; // 0x48
	public bool showBounds; // 0x50
	public List<GrassColorMapRenderer.LayerScaleSettings> layerScaleSettings; // 0x58

	// Methods

	// RVA: 0x1F60910 Offset: 0x1F5F310 VA: 0x181F60910
	private void OnEnable() { }

	// RVA: 0x1F60620 Offset: 0x1F5F020 VA: 0x181F60620
	private void OnDisable() { }

	// RVA: 0x1F606A0 Offset: 0x1F5F0A0 VA: 0x181F606A0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1F60380 Offset: 0x1F5ED80 VA: 0x181F60380
	public void AssignActiveTerrains() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void AssignVegetationStudioMeshTerrains() { }

	// RVA: 0x1F60480 Offset: 0x1F5EE80 VA: 0x181F60480
	public void AssignChildMeshes() { }

	// RVA: 0x1F605A0 Offset: 0x1F5EFA0 VA: 0x181F605A0
	public void AssignColorMap() { }

	// RVA: 0x1F609D0 Offset: 0x1F5F3D0 VA: 0x181F609D0
	public void .ctor() { }
}
