public class BuildUpdate_Grid : BuildUpdate_Base // TypeDefIndex: 2114
{
	// Fields
	[CompilerGenerated]
	private GameObject <GhostModel>k__BackingField; // 0x20
	[CompilerGenerated]
	private GridItem <BuildableItemClass>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemInstance <ItemInstance>k__BackingField; // 0x30
	[Header("Settings")]
	public float detectionRange; // 0x38
	public LayerMask detectionMask; // 0x3C
	public float rotation_Smoothing; // 0x40
	public bool AllowRotation; // 0x44
	[Header("Temperature")]
	[SerializeField]
	private bool showTemperaturesByDefault; // 0x45
	[SerializeField]
	private bool allowToggleShowTemperatures; // 0x46
	protected bool _validPosition; // 0x47
	protected Material _currentGhostMaterial; // 0x48
	protected float _rotation; // 0x50
	private TileIntersection _closestIntersection; // 0x58
	private float verticalOffset; // 0x60
	protected bool _showTemperatures; // 0x64

	// Properties
	public GameObject GhostModel { get; set; }
	public GridItem BuildableItemClass { get; set; }
	public ItemInstance ItemInstance { get; set; }
	public bool AllowToggleShowTemperatures { get; }
	protected TileIntersection closestIntersection { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public GameObject get_GhostModel() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_GhostModel(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public GridItem get_BuildableItemClass() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_BuildableItemClass(GridItem value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ItemInstance get_ItemInstance() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_ItemInstance(ItemInstance value) { }

	// RVA: 0x7FB650 Offset: 0x7FA050 VA: 0x1807FB650
	public bool get_AllowToggleShowTemperatures() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	protected TileIntersection get_closestIntersection() { }

	// RVA: 0x7FB660 Offset: 0x7FA060 VA: 0x1807FB660
	protected void set_closestIntersection(TileIntersection value) { }

	// RVA: 0x7F8EA0 Offset: 0x7F78A0 VA: 0x1807F8EA0 Slot: 5
	public virtual void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel) { }

	// RVA: 0x7FACD0 Offset: 0x7F96D0 VA: 0x1807FACD0 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x7FB390 Offset: 0x7F9D90 VA: 0x1807FB390 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x7F8950 Offset: 0x7F7350 VA: 0x1807F8950
	private void CheckToggleTemperatureDisplay() { }

	// RVA: 0x7F8F40 Offset: 0x7F7940 VA: 0x1807F8F40 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x7FA5D0 Offset: 0x7F8FD0 VA: 0x1807FA5D0
	protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin) { }

	// RVA: 0x7F8840 Offset: 0x7F7240 VA: 0x1807F8840
	protected void CheckRotation() { }

	// RVA: 0x7F7550 Offset: 0x7F5F50 VA: 0x1807F7550
	protected void ApplyRotation() { }

	// RVA: 0x7F8CE0 Offset: 0x7F76E0 VA: 0x1807F8CE0
	private List<TileIntersection> GetRelevantIntersections(FootprintTile tile) { }

	// RVA: 0x7F79E0 Offset: 0x7F63E0 VA: 0x1807F79E0 Slot: 9
	protected virtual void CheckIntersections() { }

	// RVA: 0x7FB200 Offset: 0x7F9C00 VA: 0x1807FB200
	protected void UpdateMaterials() { }

	// RVA: 0x7F9FC0 Offset: 0x7F89C0 VA: 0x1807F9FC0 Slot: 10
	protected virtual GridItem Place() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void OnPlacedObjectPreSpawn(GridItem item) { }

	// RVA: 0x7F9E30 Offset: 0x7F8830 VA: 0x1807F9E30 Slot: 12
	protected virtual void OnClosestIntersectionChanged(TileIntersection previous, TileIntersection current) { }

	// RVA: 0x7FAC10 Offset: 0x7F9610 VA: 0x1807FAC10 Slot: 13
	protected virtual void SetShowTemperatures(bool show, Property property) { }

	// RVA: 0x7F8C10 Offset: 0x7F7610 VA: 0x1807F8C10
	private Vector2 GetOriginCoordinate() { }

	// RVA: 0x7F8AB0 Offset: 0x7F74B0 VA: 0x1807F8AB0
	private Grid GetHoveredGrid() { }

	// RVA: 0x7FB630 Offset: 0x7FA030 VA: 0x1807FB630
	public void .ctor() { }
}
