public class GridItem : BuildableItem // TypeDefIndex: 1397
{
	// Fields
	[HideInInspector]
	public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs; // 0x1D0
	[CompilerGenerated]
	private Grid <OwnerGrid>k__BackingField; // 0x1D8
	protected Guid _ownerGridGUID; // 0x1E0
	protected Vector2 _originCoordinate; // 0x1F0
	protected int _rotation; // 0x1F8
	public List<CoordinatePair> CoordinatePairs; // 0x200
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted; // 0x208
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted; // 0x209

	// Properties
	public FootprintTile OriginFootprint { get; }
	public int FootprintX { get; }
	public int FootprintY { get; }
	public Grid OwnerGrid { get; set; }

	// Methods

	// RVA: 0x685540 Offset: 0x683F40 VA: 0x180685540
	public FootprintTile get_OriginFootprint() { }

	// RVA: 0x6852A0 Offset: 0x683CA0 VA: 0x1806852A0
	public int get_FootprintX() { }

	// RVA: 0x6853F0 Offset: 0x683DF0 VA: 0x1806853F0
	public int get_FootprintY() { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public Grid get_OwnerGrid() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_OwnerGrid(Grid value) { }

	// RVA: 0x6821E0 Offset: 0x680BE0 VA: 0x1806821E0 Slot: 47
	public override void Awake() { }

	// RVA: 0x684B20 Offset: 0x683520 VA: 0x180684B20 Slot: 54
	protected override void SendInitializationToServer() { }

	// RVA: 0x684A50 Offset: 0x683450 VA: 0x180684A50 Slot: 53
	protected override void SendInitializationToClient(NetworkConnection conn) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x682F20 Offset: 0x681920 VA: 0x180682F20
	public void InitializeGridItem_Server(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x682BA0 Offset: 0x6815A0 VA: 0x180682BA0
	private void InitializeGridItem_Client(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x6830B0 Offset: 0x681AB0 VA: 0x1806830B0 Slot: 66
	public virtual void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x684DE0 Offset: 0x6837E0 VA: 0x180684DE0
	protected void SetGridData(Guid gridGUID, Vector2 originCoordinate, int rotation) { }

	// RVA: 0x6850B0 Offset: 0x683AB0 VA: 0x1806850B0
	private int ValidateRotation(int rotation) { }

	// RVA: 0x6832E0 Offset: 0x681CE0 VA: 0x1806832E0
	private void ProcessGridData() { }

	// RVA: 0x683B70 Offset: 0x682570 VA: 0x180683B70
	private void RefreshTransform() { }

	// RVA: 0x682440 Offset: 0x680E40 VA: 0x180682440
	private void ClearPositionData() { }

	// RVA: 0x6826A0 Offset: 0x6810A0 VA: 0x1806826A0 Slot: 56
	protected override void Destroy() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 67
	protected virtual void OnTileTemperatureChanged(Tile tile, float newTemp) { }

	// RVA: 0x6827B0 Offset: 0x6811B0 VA: 0x1806827B0
	public float GetAverageTileTemperature() { }

	// RVA: 0x6826C0 Offset: 0x6810C0 VA: 0x1806826C0
	public float GetAverageCosmeticTileTemperature() { }

	// RVA: 0x6822C0 Offset: 0x680CC0 VA: 0x1806822C0 Slot: 68
	public virtual void CalculateFootprintTileIntersections() { }

	// RVA: 0x684D20 Offset: 0x683720 VA: 0x180684D20
	public void SetFootprintTileVisiblity(bool visible) { }

	// RVA: 0x682990 Offset: 0x681390 VA: 0x180682990
	public FootprintTile GetFootprintTile(Coordinate coord) { }

	// RVA: 0x682A90 Offset: 0x681490 VA: 0x180682A90
	public Tile GetParentTileAtFootprintCoordinate(Coordinate footprintCoord) { }

	// RVA: 0x682380 Offset: 0x680D80 VA: 0x180682380 Slot: 69
	public virtual bool CanShareTileWith(List<GridItem> obstacles) { }

	// RVA: 0x6828A0 Offset: 0x6812A0 VA: 0x1806828A0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x6851D0 Offset: 0x683BD0 VA: 0x1806851D0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(GridItem.<<ProcessGridData>g__Routine|23_0>d))]
	// RVA: 0x685040 Offset: 0x683A40 VA: 0x180685040
	private IEnumerator <ProcessGridData>g__Routine|23_0() { }

	[CompilerGenerated]
	// RVA: 0x67E710 Offset: 0x67D110 VA: 0x18067E710
	private bool <ProcessGridData>b__23_1() { }

	// RVA: 0x6831B0 Offset: 0x681BB0 VA: 0x1806831B0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x683180 Offset: 0x681B80 VA: 0x180683180 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6846E0 Offset: 0x6830E0 VA: 0x1806846E0
	private void RpcWriter___Server_InitializeGridItem_Server_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x6841B0 Offset: 0x682BB0 VA: 0x1806841B0
	public void RpcLogic___InitializeGridItem_Server_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x684300 Offset: 0x682D00 VA: 0x180684300
	private void RpcReader___Server_InitializeGridItem_Server_2821640832(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x684890 Offset: 0x683290 VA: 0x180684890
	private void RpcWriter___Target_InitializeGridItem_Client_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x6840C0 Offset: 0x682AC0 VA: 0x1806840C0
	private void RpcLogic___InitializeGridItem_Client_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x684400 Offset: 0x682E00 VA: 0x180684400
	private void RpcReader___Target_InitializeGridItem_Client_1883577149(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x684510 Offset: 0x682F10 VA: 0x180684510
	private void RpcWriter___Observers_InitializeGridItem_Client_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0x6841F0 Offset: 0x682BF0 VA: 0x1806841F0
	private void RpcReader___Observers_InitializeGridItem_Client_1883577149(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x682120 Offset: 0x680B20 VA: 0x180682120 Slot: 70
	protected override void Awake_UserLogic_ScheduleOne.EntityFramework.GridItem_Assembly-CSharp.dll() { }
}
