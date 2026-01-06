public class DealerAttendDealBehaviour : Behaviour // TypeDefIndex: 1784
{
	// Fields
	private Dealer _dealer; // 0x168
	private Contract _contract; // 0x170
	private Customer _customer; // 0x178
	private Coroutine _handoverRoutine; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviourAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviourAssembly-CSharp.dll_Excuted; // 0x189

	// Methods

	// RVA: 0x73E1F0 Offset: 0x73CBF0 VA: 0x18073E1F0 Slot: 19
	public override void Awake() { }

	// RVA: 0x73E060 Offset: 0x73CA60 VA: 0x18073E060
	public void AssignContract(Contract contract) { }

	// RVA: 0x73DFF0 Offset: 0x73C9F0 VA: 0x18073DFF0 Slot: 22
	public override void Activate() { }

	// RVA: 0x73EC30 Offset: 0x73D630 VA: 0x18073EC30 Slot: 25
	public override void Resume() { }

	// RVA: 0x73EBE0 Offset: 0x73D5E0 VA: 0x18073EBE0 Slot: 24
	public override void Pause() { }

	// RVA: 0x73E3B0 Offset: 0x73CDB0 VA: 0x18073E3B0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x73E8A0 Offset: 0x73D2A0 VA: 0x18073E8A0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x73E310 Offset: 0x73CD10 VA: 0x18073E310
	private void BeginHandover() { }

	// RVA: 0x73ECA0 Offset: 0x73D6A0 VA: 0x18073ECA0
	private void StopHandover() { }

	// RVA: 0x73E6F0 Offset: 0x73D0F0 VA: 0x18073E6F0
	private bool IsAtDestination() { }

	// RVA: 0x73E840 Offset: 0x73D240 VA: 0x18073E840
	private bool IsCustomerReadyForHandover() { }

	// RVA: 0x73E560 Offset: 0x73CF60 VA: 0x18073E560
	private Vector3 GetStandPosition() { }

	// RVA: 0x73E430 Offset: 0x73CE30 VA: 0x18073E430
	private Vector3 GetDirectionToFace() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(DealerAttendDealBehaviour.<<BeginHandover>g__Routine|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x73ECF0 Offset: 0x73D6F0 VA: 0x18073ECF0
	private IEnumerator <BeginHandover>g__Routine|11_0() { }

	[CompilerGenerated]
	// RVA: 0x73E840 Offset: 0x73D240 VA: 0x18073E840
	private bool <BeginHandover>b__11_1() { }

	// RVA: 0x73E870 Offset: 0x73D270 VA: 0x18073E870 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x730950 Offset: 0x72F350 VA: 0x180730950 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x73E0F0 Offset: 0x73CAF0 VA: 0x18073E0F0 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviour_Assembly-CSharp.dll() { }
}
