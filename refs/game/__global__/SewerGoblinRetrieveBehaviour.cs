public class SewerGoblinRetrieveBehaviour : Behaviour // TypeDefIndex: 1860
{
	// Fields
	public const float PROXIMITY_THRESHOLD = 2;
	public const float TIMEOUT = 20;
	private SewerGoblin sewerGoblin; // 0x168
	public Action onRetrieveComplete; // 0x170
	public Action onRetrieveCancelled; // 0x178
	private float timeSinceStart; // 0x180
	private bool grabbing; // 0x184
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviourAssembly-CSharp.dll_Excuted; // 0x185
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviourAssembly-CSharp.dll_Excuted; // 0x186

	// Properties
	public Player Target { get; }

	// Methods

	// RVA: 0x7722C0 Offset: 0x770CC0 VA: 0x1807722C0
	public Player get_Target() { }

	// RVA: 0x771480 Offset: 0x76FE80 VA: 0x180771480 Slot: 19
	public override void Awake() { }

	// RVA: 0x771370 Offset: 0x76FD70 VA: 0x180771370 Slot: 22
	public override void Activate() { }

	// RVA: 0x771F10 Offset: 0x770910 VA: 0x180771F10 Slot: 25
	public override void Resume() { }

	// RVA: 0x771A90 Offset: 0x770490 VA: 0x180771A90 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x771EF0 Offset: 0x7708F0 VA: 0x180771EF0 Slot: 24
	public override void Pause() { }

	// RVA: 0x771F30 Offset: 0x770930 VA: 0x180771F30
	private void StartBehaviour() { }

	// RVA: 0x772030 Offset: 0x770A30 VA: 0x180772030
	private void StopBehaviour() { }

	// RVA: 0x771930 Offset: 0x770330 VA: 0x180771930
	public void CancelRetrieve() { }

	// RVA: 0x7719C0 Offset: 0x7703C0 VA: 0x1807719C0
	private void CompleteRetrieve() { }

	// RVA: 0x771590 Offset: 0x76FF90 VA: 0x180771590 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x771CC0 Offset: 0x7706C0 VA: 0x180771CC0
	private bool IsTargetDestinationValid() { }

	// RVA: 0x771AB0 Offset: 0x7704B0 VA: 0x180771AB0
	private bool GetNewDestination(out Vector3 dest) { }

	// RVA: 0x772150 Offset: 0x770B50 VA: 0x180772150
	private bool WithinRangeOfTarget() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(SewerGoblinRetrieveBehaviour.<<CompleteRetrieve>g__Routine|17_0>d))]
	[CompilerGenerated]
	// RVA: 0x7720E0 Offset: 0x770AE0 VA: 0x1807720E0
	private IEnumerator <CompleteRetrieve>g__Routine|17_0() { }

	// RVA: 0x771ED0 Offset: 0x7708D0 VA: 0x180771ED0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x771EB0 Offset: 0x7708B0 VA: 0x180771EB0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x771390 Offset: 0x76FD90 VA: 0x180771390 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviour_Assembly-CSharp.dll() { }
}
