public class NPCSignal_UseATM : NPCSignal // TypeDefIndex: 1886
{
	// Fields
	private const float destinationThreshold = 2;
	public ATM ATM; // 0x150
	private Coroutine purchaseCoroutine; // 0x158
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted; // 0x160
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted; // 0x161

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x788920 Offset: 0x787320 VA: 0x180788920
	public string get_ActionName() { }

	// RVA: 0x788920 Offset: 0x787320 VA: 0x180788920 Slot: 36
	public override string GetName() { }

	// RVA: 0x789530 Offset: 0x787F30 VA: 0x180789530 Slot: 22
	public override void Started() { }

	// RVA: 0x788D20 Offset: 0x787720 VA: 0x180788D20 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x788770 Offset: 0x787170 VA: 0x180788770 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x788950 Offset: 0x787350 VA: 0x180788950 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x7891F0 Offset: 0x787BF0 VA: 0x1807891F0 Slot: 27
	public override void Resume() { }

	// RVA: 0x7873C0 Offset: 0x785DC0 VA: 0x1807873C0 Slot: 29
	public override void Skipped() { }

	// RVA: 0x788A70 Offset: 0x787470 VA: 0x180788A70
	private bool IsAtDestination() { }

	// RVA: 0x7896D0 Offset: 0x7880D0 VA: 0x1807896D0 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7890D0 Offset: 0x787AD0 VA: 0x1807890D0
	public void Purchase() { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(NPCSignal_UseATM.<<Purchase>g__Purchase|14_0>d))]
	// RVA: 0x789660 Offset: 0x788060 VA: 0x180789660
	private IEnumerator <Purchase>g__Purchase|14_0() { }

	// RVA: 0x788C70 Offset: 0x787670 VA: 0x180788C70 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x788C30 Offset: 0x787630 VA: 0x180788C30 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x789420 Offset: 0x787E20 VA: 0x180789420
	private void RpcWriter___Observers_Purchase_2166136261() { }

	// RVA: 0x789200 Offset: 0x787C00 VA: 0x180789200
	public void RpcLogic___Purchase_2166136261() { }

	// RVA: 0x7893E0 Offset: 0x787DE0 VA: 0x1807893E0
	private void RpcReader___Observers_Purchase_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
