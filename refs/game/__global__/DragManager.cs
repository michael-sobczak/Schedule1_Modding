public class DragManager : NetworkSingleton<DragManager> // TypeDefIndex: 1533
{
	// Fields
	public const float DRAGGABLE_OFFSET = 1.25;
	public AudioSourceController ThrowSound; // 0x120
	[Header("Settings")]
	public float DragForce; // 0x128
	public float DampingFactor; // 0x12C
	public float TorqueForce; // 0x130
	public float TorqueDampingFactor; // 0x134
	public float ThrowForce; // 0x138
	public float MassInfluence; // 0x13C
	[CompilerGenerated]
	private Draggable <CurrentDraggable>k__BackingField; // 0x140
	private List<Draggable> AllDraggables; // 0x148
	private List<Draggable> CurrentlyUpdating; // 0x150
	private Draggable lastThrownDraggable; // 0x158
	private Draggable lastHeldDraggable; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted; // 0x169

	// Properties
	public Draggable CurrentDraggable { get; set; }
	public bool IsDragging { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public Draggable get_CurrentDraggable() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	protected void set_CurrentDraggable(Draggable value) { }

	// RVA: 0x6FB040 Offset: 0x6F9A40 VA: 0x1806FB040
	public bool get_IsDragging() { }

	// RVA: 0x6F7BF0 Offset: 0x6F65F0 VA: 0x1806F7BF0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x6FA640 Offset: 0x6F9040 VA: 0x1806FA640
	public void Update() { }

	// RVA: 0x6F7230 Offset: 0x6F5C30 VA: 0x1806F7230
	public void FixedUpdate() { }

	// RVA: 0x6F77E0 Offset: 0x6F61E0 VA: 0x1806F77E0
	public bool IsDraggingAllowed() { }

	// RVA: 0x6F7EA0 Offset: 0x6F68A0 VA: 0x1806F7EA0
	public void RegisterDraggable(Draggable draggable) { }

	// RVA: 0x6F6FC0 Offset: 0x6F59C0 VA: 0x1806F6FC0
	public void Deregister(Draggable draggable) { }

	// RVA: 0x6F9D70 Offset: 0x6F8770 VA: 0x1806F9D70
	public void StartDragging(Draggable draggable) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6F9630 Offset: 0x6F8030 VA: 0x1806F9630
	private void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position) { }

	[ObserversRpc]
	// RVA: 0x6F8030 Offset: 0x6F6A30 VA: 0x1806F8030
	private void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position) { }

	// RVA: 0x6F9F70 Offset: 0x6F8970 VA: 0x1806F9F70
	public void StopDragging(Vector3 velocity) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6F9AF0 Offset: 0x6F84F0 VA: 0x1806F9AF0
	private void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6F9C20 Offset: 0x6F8620 VA: 0x1806F9C20
	private void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	// RVA: 0x6F7640 Offset: 0x6F6040 VA: 0x1806F7640
	private Vector3 GetTargetPosition() { }

	[Button]
	// RVA: 0x6F7050 Offset: 0x6F5A50 VA: 0x1806F7050
	public void EnsureAllDraggableGUIDsAreValid() { }

	// RVA: 0x6FAF40 Offset: 0x6F9940 VA: 0x1806FAF40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6FA280 Offset: 0x6F8C80 VA: 0x1806FA280
	private void <OnSpawnServer>g__SendDraggableData|18_0(NetworkConnection conn) { }

	// RVA: 0x6F7A30 Offset: 0x6F6430 VA: 0x1806F7A30 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6F79E0 Offset: 0x6F63E0 VA: 0x1806F79E0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6F9630 Offset: 0x6F8030 VA: 0x1806F9630
	private void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position) { }

	// RVA: 0x6F8030 Offset: 0x6F6A30 VA: 0x1806F8030
	private void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position) { }

	// RVA: 0x6F8C50 Offset: 0x6F7650 VA: 0x1806F8C50
	private void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6F8030 Offset: 0x6F6A30 VA: 0x1806F8030
	private void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position) { }

	// RVA: 0x6F8420 Offset: 0x6F6E20 VA: 0x1806F8420
	private void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position) { }

	// RVA: 0x6F8910 Offset: 0x6F7310 VA: 0x1806F8910
	private void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6F9350 Offset: 0x6F7D50 VA: 0x1806F9350
	private void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	// RVA: 0x6F7F30 Offset: 0x6F6930 VA: 0x1806F7F30
	private void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	// RVA: 0x6F8A30 Offset: 0x6F7430 VA: 0x1806F8A30
	private void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6F9030 Offset: 0x6F7A30 VA: 0x1806F9030
	private void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	// RVA: 0x6F81E0 Offset: 0x6F6BE0 VA: 0x1806F81E0
	private void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	// RVA: 0x6F8740 Offset: 0x6F7140 VA: 0x1806F8740
	private void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6F97D0 Offset: 0x6F81D0 VA: 0x1806F97D0
	private void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity) { }

	// RVA: 0x6F8E60 Offset: 0x6F7860 VA: 0x1806F8E60
	private void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6F6F50 Offset: 0x6F5950 VA: 0x1806F6F50 Slot: 20
	public override void Awake() { }
}
