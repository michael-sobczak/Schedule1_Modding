public class Recycler : NetworkBehaviour // TypeDefIndex: 3203
{
	// Fields
	[CompilerGenerated]
	private Recycler.EState <State>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <IsHatchOpen>k__BackingField; // 0x11C
	public LayerMask DetectionMask; // 0x120
	[Header("References")]
	public InteractableObject HandleIntObj; // 0x128
	public InteractableObject ButtonIntObj; // 0x130
	public InteractableObject CashIntObj; // 0x138
	public ToggleableLight ButtonLight; // 0x140
	public Animation ButtonAnim; // 0x148
	public Animation HatchAnim; // 0x150
	public Animation CashAnim; // 0x158
	public RectTransform OpenHatchInstruction; // 0x160
	public RectTransform InsertTrashInstruction; // 0x168
	public RectTransform PressBeginInstruction; // 0x170
	public RectTransform ProcessingScreen; // 0x178
	public TextMeshProUGUI ProcessingLabel; // 0x180
	public TextMeshProUGUI ValueLabel; // 0x188
	public BoxCollider CheckCollider; // 0x190
	public Transform Cash; // 0x198
	public GameObject BankNote; // 0x1A0
	[Header("Sound")]
	public AudioSourceController OpenSound; // 0x1A8
	public AudioSourceController CloseSound; // 0x1B0
	public AudioSourceController PressSound; // 0x1B8
	public AudioSourceController DoneSound; // 0x1C0
	public AudioSourceController CashEjectSound; // 0x1C8
	private float cashValue; // 0x1D0
	public UnityEvent onStart; // 0x1D8
	public UnityEvent onStop; // 0x1E0
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted; // 0x1E8
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted; // 0x1E9

	// Properties
	public Recycler.EState State { get; set; }
	public bool IsHatchOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0
	public Recycler.EState get_State() { }

	[CompilerGenerated]
	// RVA: 0x7EDA60 Offset: 0x7EC460 VA: 0x1807EDA60
	protected void set_State(Recycler.EState value) { }

	[CompilerGenerated]
	// RVA: 0x5232C0 Offset: 0x521CC0 VA: 0x1805232C0
	public bool get_IsHatchOpen() { }

	[CompilerGenerated]
	// RVA: 0x7049E0 Offset: 0x7033E0 VA: 0x1807049E0
	private void set_IsHatchOpen(bool value) { }

	// RVA: 0x9D65E0 Offset: 0x9D4FE0 VA: 0x1809D65E0
	public void Start() { }

	// RVA: 0x9D4EB0 Offset: 0x9D38B0 VA: 0x1809D4EB0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x9D4BD0 Offset: 0x9D35D0 VA: 0x1809D4BD0
	private void OnDestroy() { }

	// RVA: 0x9D4810 Offset: 0x9D3210 VA: 0x1809D4810
	private void MinPass() { }

	// RVA: 0x9D4800 Offset: 0x9D3200 VA: 0x1809D4800
	public void HandleInteracted() { }

	// RVA: 0x9D3DC0 Offset: 0x9D27C0 VA: 0x1809D3DC0
	public void ButtonInteracted() { }

	// RVA: 0x9D4010 Offset: 0x9D2A10 VA: 0x1809D4010
	public void CashInteracted() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x9D5C40 Offset: 0x9D4640 VA: 0x1809D5C40
	private void SendCashCollected() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9D3EB0 Offset: 0x9D28B0 VA: 0x1809D3EB0
	private void CashCollected() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9D4330 Offset: 0x9D2D30 VA: 0x1809D4330
	private void EnableCash() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9D6120 Offset: 0x9D4B20 VA: 0x1809D6120
	private void SetCashValue(float amount) { }

	[IteratorStateMachine(typeof(Recycler.<Process>d__45))]
	// RVA: 0x9D4F00 Offset: 0x9D3900 VA: 0x1809D4F00
	private IEnumerator Process(bool startedByLocalPlayer) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9D5FE0 Offset: 0x9D49E0 VA: 0x1809D5FE0
	public void SendState(Recycler.EState state) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9D6340 Offset: 0x9D4D40 VA: 0x1809D6340
	private void SetState(NetworkConnection conn, Recycler.EState state, bool force = False) { }

	// RVA: 0x9D6260 Offset: 0x9D4C60 VA: 0x1809D6260
	private void SetHatchOpen(bool open) { }

	// RVA: 0x9D4460 Offset: 0x9D2E60 VA: 0x1809D4460
	private TrashItem[] GetTrash() { }

	// RVA: 0x9D4CF0 Offset: 0x9D36F0 VA: 0x1809D4CF0
	private void OnDrawGizmos() { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	// RVA: 0x9D49A0 Offset: 0x9D33A0 VA: 0x1809D49A0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9D4980 Offset: 0x9D3380 VA: 0x1809D4980 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9D5C40 Offset: 0x9D4640 VA: 0x1809D5C40
	private void RpcWriter___Server_SendCashCollected_2166136261() { }

	// RVA: 0x9D3EB0 Offset: 0x9D28B0 VA: 0x1809D3EB0
	private void RpcLogic___SendCashCollected_2166136261() { }

	// RVA: 0x9D54B0 Offset: 0x9D3EB0 VA: 0x1809D54B0
	private void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9D5740 Offset: 0x9D4140 VA: 0x1809D5740
	private void RpcWriter___Observers_CashCollected_2166136261() { }

	// RVA: 0x9D4F80 Offset: 0x9D3980 VA: 0x1809D4F80
	private void RpcLogic___CashCollected_2166136261() { }

	// RVA: 0x9D52F0 Offset: 0x9D3CF0 VA: 0x1809D52F0
	private void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9D5860 Offset: 0x9D4260 VA: 0x1809D5860
	private void RpcWriter___Observers_EnableCash_2166136261() { }

	// RVA: 0x9D4FD0 Offset: 0x9D39D0 VA: 0x1809D4FD0
	private void RpcLogic___EnableCash_2166136261() { }

	// RVA: 0x9D5360 Offset: 0x9D3D60 VA: 0x1809D5360
	private void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9D5980 Offset: 0x9D4380 VA: 0x1809D5980
	private void RpcWriter___Observers_SetCashValue_431000436(float amount) { }

	// RVA: 0x9D5020 Offset: 0x9D3A20 VA: 0x1809D5020
	private void RpcLogic___SetCashValue_431000436(float amount) { }

	// RVA: 0x9D53B0 Offset: 0x9D3DB0 VA: 0x1809D53B0
	private void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9D5D50 Offset: 0x9D4750 VA: 0x1809D5D50
	private void RpcWriter___Server_SendState_3569965459(Recycler.EState state) { }

	// RVA: 0x9D5000 Offset: 0x9D3A00 VA: 0x1809D5000
	public void RpcLogic___SendState_3569965459(Recycler.EState state) { }

	// RVA: 0x9D5620 Offset: 0x9D4020 VA: 0x1809D5620
	private void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9D5AD0 Offset: 0x9D44D0 VA: 0x1809D5AD0
	private void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = False) { }

	// RVA: 0x9D5030 Offset: 0x9D3A30 VA: 0x1809D5030
	private void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = False) { }

	// RVA: 0x9D5410 Offset: 0x9D3E10 VA: 0x1809D5410
	private void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9D5E80 Offset: 0x9D4880 VA: 0x1809D5E80
	private void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = False) { }

	// RVA: 0x9D56A0 Offset: 0x9D40A0 VA: 0x1809D56A0
	private void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
