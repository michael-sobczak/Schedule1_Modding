public class NetworkedInteractableToggleable : NetworkBehaviour // TypeDefIndex: 1375
{
	// Fields
	[CompilerGenerated]
	private bool <IsActivated>k__BackingField; // 0x118
	public string ActivateMessage; // 0x120
	public string DeactivateMessage; // 0x128
	public float CoolDown; // 0x130
	[Header("References")]
	public InteractableObject IntObj; // 0x138
	public UnityEvent onToggle; // 0x140
	public UnityEvent onActivate; // 0x148
	public UnityEvent onDeactivate; // 0x150
	private float lastActivated; // 0x158
	private bool NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted; // 0x15C
	private bool NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted; // 0x15D

	// Properties
	public bool IsActivated { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsActivated() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	private void set_IsActivated(bool value) { }

	// RVA: 0x6620F0 Offset: 0x660AF0 VA: 0x1806620F0
	public void Start() { }

	// RVA: 0x661740 Offset: 0x660140 VA: 0x180661740 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x661560 Offset: 0x65FF60 VA: 0x180661560
	public void Hovered() { }

	// RVA: 0x6615F0 Offset: 0x65FFF0 VA: 0x1806615F0
	public void Interacted() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x661D70 Offset: 0x660770 VA: 0x180661D70
	public void SendToggle() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x661E90 Offset: 0x660890 VA: 0x180661E90
	public void SetState(NetworkConnection conn, bool activated) { }

	// RVA: 0x661780 Offset: 0x660180 VA: 0x180661780
	public void PoliceDetected() { }

	// RVA: 0x6621E0 Offset: 0x660BE0 VA: 0x1806621E0
	public void .ctor() { }

	// RVA: 0x661620 Offset: 0x660020 VA: 0x180661620 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x661600 Offset: 0x660000 VA: 0x180661600 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x661B00 Offset: 0x660500 VA: 0x180661B00
	private void RpcWriter___Server_SendToggle_2166136261() { }

	// RVA: 0x6617C0 Offset: 0x6601C0 VA: 0x1806617C0
	public void RpcLogic___SendToggle_2166136261() { }

	// RVA: 0x6618E0 Offset: 0x6602E0 VA: 0x1806618E0
	private void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6619C0 Offset: 0x6603C0 VA: 0x1806619C0
	private void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated) { }

	// RVA: 0x6617E0 Offset: 0x6601E0 VA: 0x1806617E0
	public void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated) { }

	// RVA: 0x661860 Offset: 0x660260 VA: 0x180661860
	private void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x661C10 Offset: 0x660610 VA: 0x180661C10
	private void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated) { }

	// RVA: 0x661940 Offset: 0x660340 VA: 0x180661940
	private void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
