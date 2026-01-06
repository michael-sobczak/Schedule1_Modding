public class BuildManager : Singleton<BuildManager> // TypeDefIndex: 2103
{
	// Fields
	public List<BuildManager.BuildSound> PlaceSounds; // 0x28
	[Header("References")]
	[SerializeField]
	protected Transform tempContainer; // 0x30
	public NetworkObject networkObject; // 0x38
	[SerializeField]
	[Header("Prefabs")]
	protected GameObject storedItemBuildHandler; // 0x40
	[SerializeField]
	protected GameObject cashBuildHandler; // 0x48
	[Header("Materials")]
	public Material ghostMaterial_White; // 0x50
	public Material ghostMaterial_Red; // 0x58
	[CompilerGenerated]
	private bool <isBuilding>k__BackingField; // 0x60
	[CompilerGenerated]
	private GameObject <currentBuildHandler>k__BackingField; // 0x68

	// Properties
	public Transform _tempContainer { get; }
	public bool isBuilding { get; set; }
	public GameObject currentBuildHandler { get; set; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Transform get__tempContainer() { }

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_isBuilding() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	protected void set_isBuilding(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public GameObject get_currentBuildHandler() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	protected void set_currentBuildHandler(GameObject value) { }

	// RVA: 0x7F3DE0 Offset: 0x7F27E0 VA: 0x1807F3DE0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7F4D10 Offset: 0x7F3710 VA: 0x1807F4D10
	public void StartBuilding(ItemInstance item) { }

	// RVA: 0x7F5020 Offset: 0x7F3A20 VA: 0x1807F5020
	public void StopBuilding() { }

	// RVA: 0x7F4BD0 Offset: 0x7F35D0 VA: 0x1807F4BD0
	public void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point) { }

	// RVA: 0x7F4760 Offset: 0x7F3160 VA: 0x1807F4760
	public void DisableColliders(GameObject obj) { }

	// RVA: 0x7F4800 Offset: 0x7F3200 VA: 0x1807F4800
	public void DisableLights(GameObject obj) { }

	// RVA: 0x7F4A70 Offset: 0x7F3470 VA: 0x1807F4A70
	public void DisableNetworking(GameObject obj) { }

	// RVA: 0x7F4B30 Offset: 0x7F3530 VA: 0x1807F4B30
	public void DisableSpriteRenderers(GameObject obj) { }

	// RVA: 0x7F3BE0 Offset: 0x7F25E0 VA: 0x1807F3BE0
	public void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = True) { }

	// RVA: 0x7F4910 Offset: 0x7F3310 VA: 0x1807F4910
	public void DisableNavigation(GameObject obj) { }

	// RVA: 0x7F46C0 Offset: 0x7F30C0 VA: 0x1807F46C0
	public void DisableCanvases(GameObject obj) { }

	// RVA: 0x7F3E20 Offset: 0x7F2820 VA: 0x1807F3E20
	public GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "", Action<GridItem> onBeforeSpawn) { }

	// RVA: 0x7F4150 Offset: 0x7F2B50 VA: 0x1807F4150
	public ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "") { }

	// RVA: 0x7F43E0 Offset: 0x7F2DE0 VA: 0x1807F43E0
	public SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "") { }

	// RVA: 0x7F5090 Offset: 0x7F3A90 VA: 0x1807F5090
	public void .ctor() { }
}
