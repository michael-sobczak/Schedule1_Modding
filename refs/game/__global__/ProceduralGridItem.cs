public class ProceduralGridItem : BuildableItem // TypeDefIndex: 1403
{
	// Fields
	[Header("Grid item data")]
	public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs; // 0x1D0
	public ProceduralTile.EProceduralTileType ProceduralTileType; // 0x1D8
	[SyncVar]
	[HideInInspector]
	public int Rotation; // 0x1DC
	[SyncVar]
	[HideInInspector]
	public List<CoordinateProceduralTilePair> footprintTileMatches; // 0x1E0
	public SyncVar<int> syncVar___Rotation; // 0x1E8
	public SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches; // 0x1F0
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted; // 0x1F8
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted; // 0x1F9

	// Properties
	public int FootprintXSize { get; }
	public int FootprintYSize { get; }
	public int SyncAccessor_Rotation { get; set; }
	public List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches { get; set; }

	// Methods

	// RVA: 0x688B70 Offset: 0x687570 VA: 0x180688B70
	public int get_FootprintXSize() { }

	// RVA: 0x688CC0 Offset: 0x6876C0 VA: 0x180688CC0
	public int get_FootprintYSize() { }

	// RVA: 0x686590 Offset: 0x684F90 VA: 0x180686590 Slot: 47
	public override void Awake() { }

	// RVA: 0x688490 Offset: 0x686E90 VA: 0x180688490 Slot: 54
	protected override void SendInitializationToServer() { }

	// RVA: 0x6883F0 Offset: 0x686DF0 VA: 0x1806883F0 Slot: 53
	protected override void SendInitializationToClient(NetworkConnection conn) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x687280 Offset: 0x685C80 VA: 0x180687280
	public void InitializeProceduralGridItem_Server(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x686F50 Offset: 0x685950 VA: 0x180686F50 Slot: 66
	public virtual void InitializeProceduralGridItem_Client(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x687400 Offset: 0x685E00 VA: 0x180687400 Slot: 67
	public virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x6886F0 Offset: 0x6870F0 VA: 0x1806886F0 Slot: 68
	protected virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches) { }

	// RVA: 0x687AF0 Offset: 0x6864F0 VA: 0x180687AF0
	private void RefreshTransform() { }

	// RVA: 0x686730 Offset: 0x685130 VA: 0x180686730
	private void ClearPositionData() { }

	// RVA: 0x686860 Offset: 0x685260 VA: 0x180686860 Slot: 56
	protected override void Destroy() { }

	// RVA: 0x686E60 Offset: 0x685860 VA: 0x180686E60 Slot: 49
	protected override Property GetProperty(Transform searchTransform) { }

	// RVA: 0x686670 Offset: 0x685070 VA: 0x180686670 Slot: 69
	public virtual void CalculateFootprintTileIntersections() { }

	// RVA: 0x688630 Offset: 0x687030 VA: 0x180688630
	public void SetFootprintTileVisiblity(bool visible) { }

	// RVA: 0x686D60 Offset: 0x685760 VA: 0x180686D60
	public FootprintTile GetFootprintTile(Coordinate coord) { }

	// RVA: 0x6869A0 Offset: 0x6853A0 VA: 0x1806869A0 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x688AA0 Offset: 0x6874A0 VA: 0x180688AA0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(ProceduralGridItem.<<SetProceduralGridData>g__Routine|15_0>d))]
	// RVA: 0x688A30 Offset: 0x687430 VA: 0x180688A30
	private IEnumerator <SetProceduralGridData>g__Routine|15_0() { }

	[CompilerGenerated]
	// RVA: 0x67E710 Offset: 0x67D110 VA: 0x18067E710
	private bool <SetProceduralGridData>b__15_1() { }

	// RVA: 0x6876D0 Offset: 0x6860D0 VA: 0x1806876D0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x687650 Offset: 0x686050 VA: 0x180687650 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x687280 Offset: 0x685C80 VA: 0x180687280
	private void RpcWriter___Server_InitializeProceduralGridItem_Server_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x687DF0 Offset: 0x6867F0 VA: 0x180687DF0
	public void RpcLogic___InitializeProceduralGridItem_Server_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x687F10 Offset: 0x686910 VA: 0x180687F10
	private void RpcReader___Server_InitializeProceduralGridItem_Server_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x688260 Offset: 0x686C60 VA: 0x180688260
	private void RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x687DA0 Offset: 0x6867A0 VA: 0x180687DA0 Slot: 70
	public virtual void RpcLogic___InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x687FE0 Offset: 0x6869E0 VA: 0x180687FE0
	private void RpcReader___Target_InitializeProceduralGridItem_Client_3164718044(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6880C0 Offset: 0x686AC0 VA: 0x1806880C0
	private void RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0x687E30 Offset: 0x686830 VA: 0x180687E30
	private void RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x688E10 Offset: 0x687810 VA: 0x180688E10
	public int sync___get_value_Rotation() { }

	// RVA: 0x688E30 Offset: 0x687830 VA: 0x180688E30
	public void sync___set_value_Rotation(int value, bool asServer) { }

	// RVA: 0x6879D0 Offset: 0x6863D0 VA: 0x1806879D0 Slot: 71
	public override bool ReadSyncVar___ScheduleOne.EntityFramework.ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public List<CoordinateProceduralTilePair> sync___get_value_footprintTileMatches() { }

	// RVA: 0x688EE0 Offset: 0x6878E0 VA: 0x180688EE0
	public void sync___set_value_footprintTileMatches(List<CoordinateProceduralTilePair> value, bool asServer) { }

	// RVA: 0x6864D0 Offset: 0x684ED0 VA: 0x1806864D0 Slot: 72
	protected override void Awake_UserLogic_ScheduleOne.EntityFramework.ProceduralGridItem_Assembly-CSharp.dll() { }
}
