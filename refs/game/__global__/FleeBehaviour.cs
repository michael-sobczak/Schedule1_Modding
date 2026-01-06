public class FleeBehaviour : Behaviour // TypeDefIndex: 1837
{
	// Fields
	public const float FLEE_DIST_MIN = 20;
	public const float FLEE_DIST_MAX = 40;
	public const float FLEE_SPEED = 0.7;
	[CompilerGenerated]
	private NetworkObject <EntityToFlee>k__BackingField; // 0x168
	[CompilerGenerated]
	private FleeBehaviour.EFleeMode <FleeMode>k__BackingField; // 0x170
	[CompilerGenerated]
	private Vector3 <FleeOrigin>k__BackingField; // 0x174
	private Vector3 currentFleeTarget; // 0x180
	private float nextVO; // 0x18C
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted; // 0x190
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted; // 0x191

	// Properties
	public NetworkObject EntityToFlee { get; set; }
	public Vector3 PointToFlee { get; }
	public FleeBehaviour.EFleeMode FleeMode { get; set; }
	public Vector3 FleeOrigin { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public NetworkObject get_EntityToFlee() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_EntityToFlee(NetworkObject value) { }

	// RVA: 0x761510 Offset: 0x75FF10 VA: 0x180761510
	public Vector3 get_PointToFlee() { }

	[CompilerGenerated]
	// RVA: 0x74C8E0 Offset: 0x74B2E0 VA: 0x18074C8E0
	public FleeBehaviour.EFleeMode get_FleeMode() { }

	[CompilerGenerated]
	// RVA: 0x74C910 Offset: 0x74B310 VA: 0x18074C910
	private void set_FleeMode(FleeBehaviour.EFleeMode value) { }

	[CompilerGenerated]
	// RVA: 0x7614F0 Offset: 0x75FEF0 VA: 0x1807614F0
	public Vector3 get_FleeOrigin() { }

	[CompilerGenerated]
	// RVA: 0x761590 Offset: 0x75FF90 VA: 0x180761590
	private void set_FleeOrigin(Vector3 value) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x760F40 Offset: 0x75F940 VA: 0x180760F40
	public void SetEntityToFlee(NetworkObject entity) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7610A0 Offset: 0x75FAA0 VA: 0x1807610A0
	public void SetPointToFlee(Vector3 point) { }

	// RVA: 0x75FD00 Offset: 0x75E700 VA: 0x18075FD00 Slot: 22
	public override void Activate() { }

	// RVA: 0x760AA0 Offset: 0x75F4A0 VA: 0x180760AA0 Slot: 25
	public override void Resume() { }

	// RVA: 0x75FE20 Offset: 0x75E820 VA: 0x18075FE20 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x760A80 Offset: 0x75F480 VA: 0x180760A80 Slot: 24
	public override void Pause() { }

	// RVA: 0x761240 Offset: 0x75FC40 VA: 0x180761240
	private void StartFlee() { }

	// RVA: 0x7606F0 Offset: 0x75F0F0 VA: 0x1807606F0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x75FD70 Offset: 0x75E770 VA: 0x18075FD70 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x7613C0 Offset: 0x75FDC0 VA: 0x1807613C0
	private void Stop() { }

	// RVA: 0x75FEA0 Offset: 0x75E8A0 VA: 0x18075FEA0
	private void Flee() { }

	// RVA: 0x75FF30 Offset: 0x75E930 VA: 0x18075FF30
	public Vector3 GetFleePosition() { }

	// RVA: 0x761450 Offset: 0x75FE50 VA: 0x180761450
	public void .ctor() { }

	// RVA: 0x760610 Offset: 0x75F010 VA: 0x180760610 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7605F0 Offset: 0x75EFF0 VA: 0x1807605F0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x760C70 Offset: 0x75F670 VA: 0x180760C70
	private void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity) { }

	// RVA: 0x760AC0 Offset: 0x75F4C0 VA: 0x180760AC0
	public void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity) { }

	// RVA: 0x760B10 Offset: 0x75F510 VA: 0x180760B10
	private void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x760DB0 Offset: 0x75F7B0 VA: 0x180760DB0
	private void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point) { }

	// RVA: 0x760AF0 Offset: 0x75F4F0 VA: 0x180760AF0
	public void RpcLogic___SetPointToFlee_4276783012(Vector3 point) { }

	// RVA: 0x760BA0 Offset: 0x75F5A0 VA: 0x180760BA0
	private void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
