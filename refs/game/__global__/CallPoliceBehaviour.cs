public class CallPoliceBehaviour : Behaviour // TypeDefIndex: 1773
{
	// Fields
	public const float CALL_POLICE_TIME = 4;
	[Header("References")]
	public WorldspacePopup PhoneCallPopup; // 0x168
	public AvatarEquippable PhonePrefab; // 0x170
	public AudioSourceController CallSound; // 0x178
	private float currentCallTime; // 0x180
	public Player Target; // 0x188
	public Crime ReportedCrime; // 0x190
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted; // 0x198
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted; // 0x199

	// Methods

	// RVA: 0x736EA0 Offset: 0x7358A0 VA: 0x180736EA0 Slot: 22
	public override void Activate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetData(NetworkObject player, Crime crime) { }

	// RVA: 0x737720 Offset: 0x736120 VA: 0x180737720 Slot: 25
	public override void Resume() { }

	// RVA: 0x7372E0 Offset: 0x735CE0 VA: 0x1807372E0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x737630 Offset: 0x736030 VA: 0x180737630 Slot: 24
	public override void Pause() { }

	// RVA: 0x7370D0 Offset: 0x735AD0 VA: 0x1807370D0 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x7376F0 Offset: 0x7360F0 VA: 0x1807376F0
	private void RefreshIcon() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7373A0 Offset: 0x735DA0 VA: 0x1807373A0
	private void FinalizeCall() { }

	// RVA: 0x7374C0 Offset: 0x735EC0 VA: 0x1807374C0
	private bool IsTargetValid() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	// RVA: 0x737590 Offset: 0x735F90 VA: 0x180737590 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x737560 Offset: 0x735F60 VA: 0x180737560 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x737A10 Offset: 0x736410 VA: 0x180737A10
	private void RpcWriter___Observers_FinalizeCall_2166136261() { }

	// RVA: 0x737850 Offset: 0x736250 VA: 0x180737850
	private void RpcLogic___FinalizeCall_2166136261() { }

	// RVA: 0x7379D0 Offset: 0x7363D0 VA: 0x1807379D0
	private void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
