public class NPCSignal_UseVendingMachine : NPCSignal // TypeDefIndex: 1888
{
	// Fields
	private const float destinationThreshold = 1;
	public VendingMachine MachineOverride; // 0x150
	private VendingMachine TargetMachine; // 0x158
	private Coroutine purchaseCoroutine; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted; // 0x169

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x789880 Offset: 0x788280 VA: 0x180789880
	public string get_ActionName() { }

	// RVA: 0x789880 Offset: 0x788280 VA: 0x180789880 Slot: 36
	public override string GetName() { }

	// RVA: 0x78AA10 Offset: 0x789410 VA: 0x18078AA10 Slot: 22
	public override void Started() { }

	// RVA: 0x789FD0 Offset: 0x7889D0 VA: 0x180789FD0 Slot: 34
	public override void MinPassed() { }

	// RVA: 0x788770 Offset: 0x787170 VA: 0x180788770 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x789C50 Offset: 0x788650 VA: 0x180789C50 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x7891F0 Offset: 0x787BF0 VA: 0x1807891F0 Slot: 27
	public override void Resume() { }

	// RVA: 0x7873C0 Offset: 0x785DC0 VA: 0x1807873C0 Slot: 29
	public override void Skipped() { }

	// RVA: 0x789D70 Offset: 0x788770 VA: 0x180789D70
	private bool IsAtDestination() { }

	// RVA: 0x7898B0 Offset: 0x7882B0 VA: 0x1807898B0
	private VendingMachine GetTargetMachine() { }

	// RVA: 0x78ABE0 Offset: 0x7895E0 VA: 0x18078ABE0 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x78A540 Offset: 0x788F40 VA: 0x18078A540
	public void Purchase() { }

	// RVA: 0x789710 Offset: 0x788110 VA: 0x180789710
	private bool CheckItem() { }

	// RVA: 0x789F30 Offset: 0x788930 VA: 0x180789F30
	private void ItemWasStolen() { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	[IteratorStateMachine(typeof(NPCSignal_UseVendingMachine.<<Purchase>g__Purchase|16_0>d))]
	[CompilerGenerated]
	// RVA: 0x78AB70 Offset: 0x789570 VA: 0x18078AB70
	private IEnumerator <Purchase>g__Purchase|16_0() { }

	// RVA: 0x78A490 Offset: 0x788E90 VA: 0x18078A490 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x78A450 Offset: 0x788E50 VA: 0x18078A450 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x78A900 Offset: 0x789300 VA: 0x18078A900
	private void RpcWriter___Observers_Purchase_2166136261() { }

	// RVA: 0x78A660 Offset: 0x789060 VA: 0x18078A660
	public void RpcLogic___Purchase_2166136261() { }

	// RVA: 0x78A8C0 Offset: 0x7892C0 VA: 0x18078A8C0
	private void RpcReader___Observers_Purchase_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
