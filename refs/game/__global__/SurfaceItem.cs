public class SurfaceItem : BuildableItem // TypeDefIndex: 1405
{
	// Fields
	[CompilerGenerated]
	private Surface <ParentSurface>k__BackingField; // 0x1D0
	[Header("Settings")]
	public List<Surface.ESurfaceType> ValidSurfaceTypes; // 0x1D8
	public bool AllowRotation; // 0x1E0
	[CompilerGenerated]
	private readonly float <RotationIncrement>k__BackingField; // 0x1E4
	protected Vector3 RelativePosition; // 0x1E8
	protected Quaternion RelativeRotation; // 0x1F4
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted; // 0x204
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted; // 0x205

	// Properties
	public Surface ParentSurface { get; set; }
	public float RotationIncrement { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public Surface get_ParentSurface() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_ParentSurface(Surface value) { }

	[CompilerGenerated]
	// RVA: 0x68E6F0 Offset: 0x68D0F0 VA: 0x18068E6F0
	public float get_RotationIncrement() { }

	// RVA: 0x68C7D0 Offset: 0x68B1D0 VA: 0x18068C7D0 Slot: 47
	public override void Awake() { }

	// RVA: 0x68DF60 Offset: 0x68C960 VA: 0x18068DF60 Slot: 54
	protected override void SendInitializationToServer() { }

	// RVA: 0x68DDF0 Offset: 0x68C7F0 VA: 0x18068DDF0 Slot: 53
	protected override void SendInitializationToClient(NetworkConnection conn) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x68CAE0 Offset: 0x68B4E0 VA: 0x18068CAE0
	private void InitializeSurfaceItem_Server(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x68C980 Offset: 0x68B380 VA: 0x18068C980
	private void InitializeSurfaceItem_Client(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68CB40 Offset: 0x68B540 VA: 0x18068CB40 Slot: 66
	public virtual void InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68E020 Offset: 0x68CA20 VA: 0x18068E020
	private void SetTransformData(string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68C970 Offset: 0x68B370 VA: 0x18068C970 Slot: 49
	protected override Property GetProperty(Transform searchTransform) { }

	// RVA: 0x68C820 Offset: 0x68B220 VA: 0x18068C820 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x68E510 Offset: 0x68CF10 VA: 0x18068E510
	public void .ctor() { }

	[IteratorStateMachine(typeof(SurfaceItem.<<SetTransformData>g__Routine|17_0>d))]
	[CompilerGenerated]
	// RVA: 0x68E4A0 Offset: 0x68CEA0 VA: 0x18068E4A0
	private IEnumerator <SetTransformData>g__Routine|17_0() { }

	[CompilerGenerated]
	// RVA: 0x67E710 Offset: 0x67D110 VA: 0x18067E710
	private bool <SetTransformData>b__17_1() { }

	// RVA: 0x68CDB0 Offset: 0x68B7B0 VA: 0x18068CDB0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x68CD80 Offset: 0x68B780 VA: 0x18068CD80 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x68D820 Offset: 0x68C220 VA: 0x18068D820
	private void RpcWriter___Server_InitializeSurfaceItem_Server_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68CF60 Offset: 0x68B960 VA: 0x18068CF60
	private void RpcLogic___InitializeSurfaceItem_Server_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68D1C0 Offset: 0x68BBC0 VA: 0x18068D1C0
	private void RpcReader___Server_InitializeSurfaceItem_Server_2652836379(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x68DAF0 Offset: 0x68C4F0 VA: 0x18068DAF0
	private void RpcWriter___Target_InitializeSurfaceItem_Client_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68CEE0 Offset: 0x68B8E0 VA: 0x18068CEE0
	private void RpcLogic___InitializeSurfaceItem_Client_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68D3B0 Offset: 0x68BDB0 VA: 0x18068D3B0
	private void RpcReader___Target_InitializeSurfaceItem_Client_2932264618(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x68D520 Offset: 0x68BF20 VA: 0x18068D520
	private void RpcWriter___Observers_InitializeSurfaceItem_Client_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation) { }

	// RVA: 0x68D050 Offset: 0x68BA50 VA: 0x18068D050
	private void RpcReader___Observers_InitializeSurfaceItem_Client_2932264618(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x68C7C0 Offset: 0x68B1C0 VA: 0x18068C7C0 Slot: 67
	protected override void Awake_UserLogic_ScheduleOne.EntityFramework.SurfaceItem_Assembly-CSharp.dll() { }
}
