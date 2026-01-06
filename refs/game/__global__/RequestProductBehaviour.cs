public class RequestProductBehaviour : Behaviour // TypeDefIndex: 1856
{
	// Fields
	public const float CONVERSATION_RANGE = 2.5;
	public const float FOLLOW_MAX_RANGE = 5;
	public const int MINS_TO_ASK_AGAIN = 90;
	[CompilerGenerated]
	private Player <TargetPlayer>k__BackingField; // 0x168
	[CompilerGenerated]
	private RequestProductBehaviour.EState <State>k__BackingField; // 0x170
	private int minsSinceLastDialogue; // 0x174
	private DialogueController.GreetingOverride requestGreeting; // 0x178
	private DialogueController.DialogueChoice acceptRequestChoice; // 0x180
	private DialogueController.DialogueChoice followChoice; // 0x188
	private DialogueController.DialogueChoice rejectChoice; // 0x190
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted; // 0x198
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted; // 0x199

	// Properties
	public Player TargetPlayer { get; set; }
	public RequestProductBehaviour.EState State { get; set; }
	private Customer customer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public Player get_TargetPlayer() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_TargetPlayer(Player value) { }

	[CompilerGenerated]
	// RVA: 0x74C8E0 Offset: 0x74B2E0 VA: 0x18074C8E0
	public RequestProductBehaviour.EState get_State() { }

	[CompilerGenerated]
	// RVA: 0x74C910 Offset: 0x74B310 VA: 0x18074C910
	private void set_State(RequestProductBehaviour.EState value) { }

	// RVA: 0x770700 Offset: 0x76F100 VA: 0x180770700
	private Customer get_customer() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x76D4E0 Offset: 0x76BEE0 VA: 0x18076D4E0
	public void AssignTarget(NetworkObject plr) { }

	// RVA: 0x770680 Offset: 0x76F080 VA: 0x180770680 Slot: 34
	protected virtual void Start() { }

	// RVA: 0x76D190 Offset: 0x76BB90 VA: 0x18076D190 Slot: 22
	public override void Activate() { }

	// RVA: 0x76D8F0 Offset: 0x76C2F0 VA: 0x18076D8F0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x73D060 Offset: 0x73BA60 VA: 0x18073D060 Slot: 21
	public override void Disable() { }

	// RVA: 0x76E8B0 Offset: 0x76D2B0 VA: 0x18076E8B0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x76E450 Offset: 0x76CE50 VA: 0x18076E450
	private bool IsTargetDestinationValid() { }

	// RVA: 0x76DB70 Offset: 0x76C570 VA: 0x18076DB70
	private bool GetNewDestination(out Vector3 dest) { }

	// RVA: 0x76E640 Offset: 0x76D040 VA: 0x18076E640
	public static bool IsTargetValid(Player player) { }

	// RVA: 0x76D6A0 Offset: 0x76C0A0 VA: 0x18076D6A0
	public bool CanStartDialogue() { }

	// RVA: 0x76FE30 Offset: 0x76E830 VA: 0x18076FE30
	private void SetUpDialogue() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x76FD20 Offset: 0x76E720 VA: 0x18076FD20
	private void SendStartInitialDialogue() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x770560 Offset: 0x76EF60 VA: 0x180770560
	private void StartInitialDialogue() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x76FC10 Offset: 0x76E610 VA: 0x18076FC10
	private void SendStartFollowUpDialogue() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x76F090 Offset: 0x76DA90 VA: 0x18076F090
	private void StartFollowUpDialogue() { }

	// RVA: 0x76D9B0 Offset: 0x76C3B0 VA: 0x18076D9B0
	private bool DialogueActive(bool enabled) { }

	// RVA: 0x76ED80 Offset: 0x76D780 VA: 0x18076ED80
	private void RequestAccepted() { }

	// RVA: 0x76DD70 Offset: 0x76C770 VA: 0x18076DD70
	private void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice) { }

	// RVA: 0x76D9F0 Offset: 0x76C3F0 VA: 0x18076D9F0
	private void Follow() { }

	// RVA: 0x76EF60 Offset: 0x76D960 VA: 0x18076EF60
	private void RequestRejected() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(RequestProductBehaviour.<<HandoverClosed>g__Wait|36_0>d))]
	[CompilerGenerated]
	// RVA: 0x770690 Offset: 0x76F090 VA: 0x180770690
	private IEnumerator <HandoverClosed>g__Wait|36_0() { }

	// RVA: 0x76E700 Offset: 0x76D100 VA: 0x18076E700 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x74BCD0 Offset: 0x74A6D0 VA: 0x18074BCD0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x76F670 Offset: 0x76E070 VA: 0x18076F670
	private void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr) { }

	// RVA: 0x76EFE0 Offset: 0x76D9E0 VA: 0x18076EFE0
	public void RpcLogic___AssignTarget_3323014238(NetworkObject plr) { }

	// RVA: 0x76F460 Offset: 0x76DE60 VA: 0x18076F460
	private void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x76FB00 Offset: 0x76E500 VA: 0x18076FB00
	private void RpcWriter___Server_SendStartInitialDialogue_2166136261() { }

	// RVA: 0x76F1B0 Offset: 0x76DBB0 VA: 0x18076F1B0
	private void RpcLogic___SendStartInitialDialogue_2166136261() { }

	// RVA: 0x76F620 Offset: 0x76E020 VA: 0x18076F620
	private void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x76F8D0 Offset: 0x76E2D0 VA: 0x18076F8D0
	private void RpcWriter___Observers_StartInitialDialogue_2166136261() { }

	// RVA: 0x76F310 Offset: 0x76DD10 VA: 0x18076F310
	private void RpcLogic___StartInitialDialogue_2166136261() { }

	// RVA: 0x76F590 Offset: 0x76DF90 VA: 0x18076F590
	private void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x76F9F0 Offset: 0x76E3F0 VA: 0x18076F9F0
	private void RpcWriter___Server_SendStartFollowUpDialogue_2166136261() { }

	// RVA: 0x76F090 Offset: 0x76DA90 VA: 0x18076F090
	private void RpcLogic___SendStartFollowUpDialogue_2166136261() { }

	// RVA: 0x76F5D0 Offset: 0x76DFD0 VA: 0x18076F5D0
	private void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x76F7B0 Offset: 0x76E1B0 VA: 0x18076F7B0
	private void RpcWriter___Observers_StartFollowUpDialogue_2166136261() { }

	// RVA: 0x76F1C0 Offset: 0x76DBC0 VA: 0x18076F1C0
	private void RpcLogic___StartFollowUpDialogue_2166136261() { }

	// RVA: 0x76F550 Offset: 0x76DF50 VA: 0x18076F550
	private void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
