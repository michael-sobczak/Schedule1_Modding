public class FloorRack : GridItem, IProceduralTileContainer // TypeDefIndex: 3216
{
	// Fields
	[Header("References")]
	public Transform leg_BottomLeft; // 0x210
	public Transform leg_BottomRight; // 0x218
	public Transform leg_TopLeft; // 0x220
	public Transform leg_TopRight; // 0x228
	public CornerObstacle obs_BottomLeft; // 0x230
	public CornerObstacle obs_BottomRight; // 0x238
	public CornerObstacle obs_TopLeft; // 0x240
	public CornerObstacle obs_TopRight; // 0x248
	public List<ProceduralTile> procTiles; // 0x250
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted; // 0x258
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted; // 0x259

	// Properties
	public List<ProceduralTile> ProceduralTiles { get; }

	// Methods

	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0 Slot: 71
	public List<ProceduralTile> get_ProceduralTiles() { }

	// RVA: 0x9CC2B0 Offset: 0x9CACB0 VA: 0x1809CC2B0 Slot: 72
	public virtual void UpdateLegVisibility() { }

	// RVA: 0x9CB890 Offset: 0x9CA290 VA: 0x1809CB890
	protected void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset) { }

	// RVA: 0x9CBED0 Offset: 0x9CA8D0 VA: 0x1809CBED0
	private FloorRack GetFloorRackFromOccupants(List<GridItem> occs) { }

	// RVA: 0x9CC000 Offset: 0x9CAA00 VA: 0x1809CC000
	public List<FloorRack> GetSurroundingRacks() { }

	// RVA: 0x9CB7D0 Offset: 0x9CA1D0 VA: 0x1809CB7D0 Slot: 69
	public override bool CanShareTileWith(List<GridItem> obstacles) { }

	// RVA: 0x9CB5D0 Offset: 0x9C9FD0 VA: 0x1809CB5D0 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0x9CC3C0 Offset: 0x9CADC0 VA: 0x1809CC3C0
	public void .ctor() { }

	// RVA: 0x9CC290 Offset: 0x9CAC90 VA: 0x1809CC290 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9CC270 Offset: 0x9CAC70 VA: 0x1809CC270 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }
}
