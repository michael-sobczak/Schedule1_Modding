public class SpraySurface : NetworkBehaviour, IGUIDRegisterable // TypeDefIndex: 1385
{
	// Fields
	public const float PIXEL_SIZE = 0.006666671;
	public const int PADDING = 8;
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x118
	[CompilerGenerated]
	private NetworkObject <CurrentEditor>k__BackingField; // 0x128
	[CompilerGenerated]
	private EMapRegion <Region>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <HasDrawingBeenFinalized>k__BackingField; // 0x134
	[Header("Settings")]
	public string BakedGUID; // 0x138
	[Range(1, 1000)]
	public int Width; // 0x140
	[Range(1, 1000)]
	public int Height; // 0x144
	public AnimationCurve FalloffCurve; // 0x148
	[Range(0, 100)]
	public int FalloffRadius; // 0x150
	[Header("References")]
	public Transform BottomLeftPoint; // 0x158
	public DecalProjector Projector; // 0x160
	private Drawing drawing; // 0x168
	private Drawing cachedDrawing; // 0x170
	public Action onDrawingChanged; // 0x178
	private List<int> pastRequestIDs; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	public Guid GUID { get; set; }
	public NetworkObject CurrentEditor { get; set; }
	public int DrawingStrokeCount { get; }
	public Texture DrawingOutputTexture { get; }
	public int DrawingPaintedPixelCount { get; }
	public EMapRegion Region { get; set; }
	public bool HasDrawingBeenFinalized { get; set; }
	public Vector3 TopRightPoint { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x66FB70 Offset: 0x66E570 VA: 0x18066FB70 Slot: 19
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x66FC20 Offset: 0x66E620 VA: 0x18066FC20
	protected void set_GUID(Guid value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public NetworkObject get_CurrentEditor() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_CurrentEditor(NetworkObject value) { }

	// RVA: 0x66FB10 Offset: 0x66E510 VA: 0x18066FB10
	public int get_DrawingStrokeCount() { }

	// RVA: 0x66FAD0 Offset: 0x66E4D0 VA: 0x18066FAD0
	public Texture get_DrawingOutputTexture() { }

	// RVA: 0x66FAF0 Offset: 0x66E4F0 VA: 0x18066FAF0
	public int get_DrawingPaintedPixelCount() { }

	[CompilerGenerated]
	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public EMapRegion get_Region() { }

	[CompilerGenerated]
	// RVA: 0x523860 Offset: 0x522260 VA: 0x180523860
	private void set_Region(EMapRegion value) { }

	[CompilerGenerated]
	// RVA: 0x66FB80 Offset: 0x66E580 VA: 0x18066FB80
	public bool get_HasDrawingBeenFinalized() { }

	[CompilerGenerated]
	// RVA: 0x66FC30 Offset: 0x66E630 VA: 0x18066FC30
	private void set_HasDrawingBeenFinalized(bool value) { }

	// RVA: 0x66FB90 Offset: 0x66E590 VA: 0x18066FB90
	public Vector3 get_TopRightPoint() { }

	// RVA: 0x66C650 Offset: 0x66B050 VA: 0x18066C650 Slot: 22
	public override void Awake() { }

	// RVA: 0x66F770 Offset: 0x66E170 VA: 0x18066F770
	private void Start() { }

	// RVA: 0x66D780 Offset: 0x66C180 VA: 0x18066D780 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x66D920 Offset: 0x66C320 VA: 0x18066D920
	private void ResizeProjector() { }

	// RVA: 0x66C790 Offset: 0x66B190 VA: 0x18066C790
	public bool CanBeEdited() { }

	// RVA: 0x66D530 Offset: 0x66BF30 VA: 0x18066D530 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x66D7F0 Offset: 0x66C1F0 VA: 0x18066D7F0
	public void ReplicateTo(NetworkConnection conn) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x66ED80 Offset: 0x66D780 VA: 0x18066ED80
	public void SetCurrentEditor_Server(NetworkObject player) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x66F170 Offset: 0x66DB70 VA: 0x18066F170
	private void SetCurrentEditor_Client(NetworkConnection conn, NetworkObject player) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x66C470 Offset: 0x66AE70 VA: 0x18066C470
	public void AddStrokes_Server(List<SprayStroke> newStrokes, int requestID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x66C300 Offset: 0x66AD00 VA: 0x18066C300
	private void AddStrokes_Client(List<SprayStroke> newStrokes, int requestID) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x66C850 Offset: 0x66B250 VA: 0x18066C850
	public void ClearDrawing() { }

	// RVA: 0x66CE00 Offset: 0x66B800 VA: 0x18066CE00
	public void EnsureDrawingExists() { }

	// RVA: 0x66C960 Offset: 0x66B360 VA: 0x18066C960
	private void CreateNewDrawing() { }

	// RVA: 0x66C700 Offset: 0x66B100 VA: 0x18066C700
	public void CacheDrawing() { }

	// RVA: 0x66DA80 Offset: 0x66C480 VA: 0x18066DA80
	public void RestoreFromCache() { }

	// RVA: 0x66F980 Offset: 0x66E380 VA: 0x18066F980
	public Vector3 ToWorldPosition(UShort2 coordinate, float offset = 0) { }

	// RVA: 0x66CD70 Offset: 0x66B770 VA: 0x18066CD70
	public void DrawPaintedPixel(PixelData data, bool applyTexture) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x66D0C0 Offset: 0x66BAC0 VA: 0x18066D0C0
	public void MarkDrawingFinalized() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x66DE90 Offset: 0x66C890 VA: 0x18066DE90
	private void SetFinalized() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x66F450 Offset: 0x66DE50 VA: 0x18066F450
	public void Set(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized) { }

	// RVA: 0x66CDD0 Offset: 0x66B7D0 VA: 0x18066CDD0
	private void DrawingChanged() { }

	// RVA: 0x66CE20 Offset: 0x66B820 VA: 0x18066CE20
	private float[] GetFalloffTable() { }

	// RVA: 0x66F3E0 Offset: 0x66DDE0 VA: 0x18066F3E0 Slot: 21
	public void SetGUID(Guid guid) { }

	[Button]
	// RVA: 0x66D7A0 Offset: 0x66C1A0 VA: 0x18066D7A0
	public void RegenerateGUID() { }

	// RVA: 0x66F6F0 Offset: 0x66E0F0 VA: 0x18066F6F0
	public bool ShouldSave() { }

	// RVA: 0x66CFD0 Offset: 0x66B9D0 VA: 0x18066CFD0
	public SpraySurfaceData GetSaveData() { }

	// RVA: 0x66FA00 Offset: 0x66E400 VA: 0x18066FA00
	public void .ctor() { }

	// RVA: 0x66D230 Offset: 0x66BC30 VA: 0x18066D230 Slot: 23
	public override void NetworkInitialize___Early() { }

	// RVA: 0x66D210 Offset: 0x66BC10 VA: 0x18066D210 Slot: 24
	public override void NetworkInitialize__Late() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x66ED80 Offset: 0x66D780 VA: 0x18066ED80
	private void RpcWriter___Server_SetCurrentEditor_Server_3323014238(NetworkObject player) { }

	// RVA: 0x66DFD0 Offset: 0x66C9D0 VA: 0x18066DFD0
	public void RpcLogic___SetCurrentEditor_Server_3323014238(NetworkObject player) { }

	// RVA: 0x66E420 Offset: 0x66CE20 VA: 0x18066E420
	private void RpcReader___Server_SetCurrentEditor_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x66E730 Offset: 0x66D130 VA: 0x18066E730
	private void RpcWriter___Observers_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player) { }

	// RVA: 0x5EAB40 Offset: 0x5E9540 VA: 0x1805EAB40
	private void RpcLogic___SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player) { }

	// RVA: 0x66E110 Offset: 0x66CB10 VA: 0x18066E110
	private void RpcReader___Observers_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x66EEB0 Offset: 0x66D8B0 VA: 0x18066EEB0
	private void RpcWriter___Target_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player) { }

	// RVA: 0x66E490 Offset: 0x66CE90 VA: 0x18066E490
	private void RpcReader___Target_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x66EB00 Offset: 0x66D500 VA: 0x18066EB00
	private void RpcWriter___Server_AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID) { }

	// RVA: 0x66C300 Offset: 0x66AD00 VA: 0x18066C300
	public void RpcLogic___AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID) { }

	// RVA: 0x66E270 Offset: 0x66CC70 VA: 0x18066E270
	private void RpcReader___Server_AddStrokes_Server_1511871282(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x66E5B0 Offset: 0x66CFB0 VA: 0x18066E5B0
	private void RpcWriter___Observers_AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID) { }

	// RVA: 0x66DCD0 Offset: 0x66C6D0 VA: 0x18066DCD0
	private void RpcLogic___AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID) { }

	// RVA: 0x66E080 Offset: 0x66CA80 VA: 0x18066E080
	private void RpcReader___Observers_AddStrokes_Client_1511871282(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x66C850 Offset: 0x66B250 VA: 0x18066C850
	private void RpcWriter___Server_ClearDrawing_2166136261() { }

	// RVA: 0x66DDE0 Offset: 0x66C7E0 VA: 0x18066DDE0
	public void RpcLogic___ClearDrawing_2166136261() { }

	// RVA: 0x66E310 Offset: 0x66CD10 VA: 0x18066E310
	private void RpcReader___Server_ClearDrawing_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x66EC70 Offset: 0x66D670 VA: 0x18066EC70
	private void RpcWriter___Server_MarkDrawingFinalized_2166136261() { }

	// RVA: 0x66DE90 Offset: 0x66C890 VA: 0x18066DE90
	public void RpcLogic___MarkDrawingFinalized_2166136261() { }

	// RVA: 0x66E3D0 Offset: 0x66CDD0 VA: 0x18066E3D0
	private void RpcReader___Server_MarkDrawingFinalized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x66E870 Offset: 0x66D270 VA: 0x18066E870
	private void RpcWriter___Observers_SetFinalized_2166136261() { }

	// RVA: 0x66DFE0 Offset: 0x66C9E0 VA: 0x18066DFE0
	private void RpcLogic___SetFinalized_2166136261() { }

	// RVA: 0x66E190 Offset: 0x66CB90 VA: 0x18066E190
	private void RpcReader___Observers_SetFinalized_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x66E990 Offset: 0x66D390 VA: 0x18066E990
	private void RpcWriter___Observers_Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized) { }

	// RVA: 0x66DFF0 Offset: 0x66C9F0 VA: 0x18066DFF0
	public void RpcLogic___Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized) { }

	// RVA: 0x66E1C0 Offset: 0x66CBC0 VA: 0x18066E1C0
	private void RpcReader___Observers_Set_4105842735(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x66F010 Offset: 0x66DA10 VA: 0x18066F010
	private void RpcWriter___Target_Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized) { }

	// RVA: 0x66E510 Offset: 0x66CF10 VA: 0x18066E510
	private void RpcReader___Target_Set_4105842735(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x66C5D0 Offset: 0x66AFD0 VA: 0x18066C5D0
	private void Awake_UserLogic_ScheduleOne.Graffiti.SpraySurface_Assembly-CSharp.dll() { }
}
