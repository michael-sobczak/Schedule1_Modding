public class Employee : NPC // TypeDefIndex: 1423
{
	// Fields
	public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;
	public bool DEBUG; // 0x2F0
	[CompilerGenerated]
	private Property <AssignedProperty>k__BackingField; // 0x2F8
	[CompilerGenerated]
	private int <EmployeeIndex>k__BackingField; // 0x300
	[SyncVar]
	[CompilerGenerated]
	public bool <PaidForToday>k__BackingField; // 0x304
	[CompilerGenerated]
	private bool <Fired>k__BackingField; // 0x305
	[CompilerGenerated]
	private bool <IsMale>k__BackingField; // 0x306
	[CompilerGenerated]
	private int <AppearanceIndex>k__BackingField; // 0x308
	[SerializeField]
	protected EEmployeeType Type; // 0x30C
	[Header("Payment")]
	public float SigningFee; // 0x310
	public float DailyWage; // 0x314
	[Header("References")]
	public IdleBehaviour WaitOutside; // 0x318
	public MoveItemBehaviour MoveItemBehaviour; // 0x320
	public DialogueContainer BedNotAssignedDialogue; // 0x328
	public DialogueContainer NotPaidDialogue; // 0x330
	public DialogueContainer WorkIssueDialogueTemplate; // 0x338
	public DialogueContainer FireDialogue; // 0x340
	public DialogueContainer TransferDialogue; // 0x348
	private List<Employee.NoWorkReason> WorkIssues; // 0x350
	[CompilerGenerated]
	private int <TimeSinceLastWorked>k__BackingField; // 0x358
	protected bool initialized; // 0x35C
	protected int consecutivePathingFailures; // 0x360
	private float timeOnLastPathingFailure; // 0x364
	private Transform cachedNPCSpawnPoint; // 0x368
	public SyncVar<bool> syncVar___<PaidForToday>k__BackingField; // 0x370
	private bool NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted; // 0x378
	private bool NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted; // 0x379

	// Properties
	public Property AssignedProperty { get; set; }
	public int EmployeeIndex { get; set; }
	public bool PaidForToday { get; set; }
	public bool Fired { get; set; }
	public bool IsWaitingOutside { get; }
	public bool IsMale { get; set; }
	protected int AppearanceIndex { get; set; }
	public EEmployeeType EmployeeType { get; }
	public int TimeSinceLastWorked { get; set; }
	public bool SyncAccessor_<PaidForToday>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260
	public Property get_AssignedProperty() { }

	[CompilerGenerated]
	// RVA: 0x6C87A0 Offset: 0x6C71A0 VA: 0x1806C87A0
	protected void set_AssignedProperty(Property value) { }

	[CompilerGenerated]
	// RVA: 0x6C8700 Offset: 0x6C7100 VA: 0x1806C8700
	public int get_EmployeeIndex() { }

	[CompilerGenerated]
	// RVA: 0x6C87C0 Offset: 0x6C71C0 VA: 0x1806C87C0
	protected void set_EmployeeIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x6C8770 Offset: 0x6C7170 VA: 0x1806C8770
	public bool get_PaidForToday() { }

	[CompilerGenerated]
	// RVA: 0x6C87F0 Offset: 0x6C71F0 VA: 0x1806C87F0
	private void set_PaidForToday(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6C8720 Offset: 0x6C7120 VA: 0x1806C8720
	public bool get_Fired() { }

	[CompilerGenerated]
	// RVA: 0x6C87D0 Offset: 0x6C71D0 VA: 0x1806C87D0
	private void set_Fired(bool value) { }

	// RVA: 0x6C8740 Offset: 0x6C7140 VA: 0x1806C8740
	public bool get_IsWaitingOutside() { }

	[CompilerGenerated]
	// RVA: 0x6C8730 Offset: 0x6C7130 VA: 0x1806C8730
	public bool get_IsMale() { }

	[CompilerGenerated]
	// RVA: 0x6C87E0 Offset: 0x6C71E0 VA: 0x1806C87E0
	private void set_IsMale(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6C86F0 Offset: 0x6C70F0 VA: 0x1806C86F0
	protected int get_AppearanceIndex() { }

	[CompilerGenerated]
	// RVA: 0x6C8790 Offset: 0x6C7190 VA: 0x1806C8790
	private void set_AppearanceIndex(int value) { }

	// RVA: 0x6C8710 Offset: 0x6C7110 VA: 0x1806C8710
	public EEmployeeType get_EmployeeType() { }

	[CompilerGenerated]
	// RVA: 0x6C8780 Offset: 0x6C7180 VA: 0x1806C8780
	public int get_TimeSinceLastWorked() { }

	[CompilerGenerated]
	// RVA: 0x6C8880 Offset: 0x6C7280 VA: 0x1806C8880
	private void set_TimeSinceLastWorked(int value) { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }

	// RVA: 0x6C77A0 Offset: 0x6C61A0 VA: 0x1806C77A0 Slot: 71
	protected override void Start() { }

	// RVA: 0x6C5890 Offset: 0x6C4290 VA: 0x1806C5890 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x6C57A0 Offset: 0x6C41A0 VA: 0x1806C57A0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x6C4C10 Offset: 0x6C3610 VA: 0x1806C4C10 Slot: 111
	public virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex) { }

	// RVA: 0x6C3BF0 Offset: 0x6C25F0 VA: 0x1806C3BF0 Slot: 112
	protected virtual void AssignProperty(Property prop, bool warp) { }

	// RVA: 0x6C8260 Offset: 0x6C6C60 VA: 0x1806C8260 Slot: 113
	protected virtual void UnassignProperty() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6C70F0 Offset: 0x6C5AF0 VA: 0x1806C70F0
	public void SendTransfer(string propertyCode) { }

	[ObserversRpc]
	// RVA: 0x6C60D0 Offset: 0x6C4AD0 VA: 0x1806C60D0
	private void TransferToProperty(string code) { }

	// RVA: 0x6C8060 Offset: 0x6C6A60 VA: 0x1806C8060 Slot: 114
	protected virtual void TransferToProperty(Property prop) { }

	// RVA: 0x6C4A80 Offset: 0x6C3480 VA: 0x1806C4A80 Slot: 115
	protected virtual void InitializeInfo(string firstName, string lastName, string id) { }

	// RVA: 0x6C45D0 Offset: 0x6C2FD0 VA: 0x1806C45D0 Slot: 116
	protected virtual void InitializeAppearance(bool male, int index) { }

	// RVA: 0x6C3E40 Offset: 0x6C2840 VA: 0x1806C3E40 Slot: 117
	protected virtual void CheckDialogueChoice(string choiceLabel) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6C6FE0 Offset: 0x6C59E0 VA: 0x1806C6FE0
	public void SendFire() { }

	[ObserversRpc]
	// RVA: 0x6C5B10 Offset: 0x6C4510 VA: 0x1806C5B10
	private void ReceiveFire() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 118
	protected virtual void ResetConfiguration() { }

	// RVA: 0x6C3F90 Offset: 0x6C2990 VA: 0x1806C3F90 Slot: 119
	protected virtual void Fire() { }

	// RVA: 0x6C3D80 Offset: 0x6C2780 VA: 0x1806C3D80
	protected bool CanWork() { }

	// RVA: 0x6C5520 Offset: 0x6C3F20 VA: 0x1806C5520 Slot: 72
	protected override void OnDestroy() { }

	// RVA: 0x6C8310 Offset: 0x6C6D10 VA: 0x1806C8310 Slot: 120
	protected virtual void UpdateBehaviour() { }

	// RVA: 0x6C5160 Offset: 0x6C3B60 VA: 0x1806C5160
	protected void MarkIsWorking() { }

	// RVA: 0x6C76B0 Offset: 0x6C60B0 VA: 0x1806C76B0
	private void SetWaitOutside(bool wait) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 121
	protected virtual bool ShouldIdle() { }

	// RVA: 0x6C5940 Offset: 0x6C4340 VA: 0x1806C5940 Slot: 74
	protected override void OnTick() { }

	// RVA: 0x6C5790 Offset: 0x6C4190 VA: 0x1806C5790
	private void OnSleepEnd() { }

	// RVA: 0x6C76A0 Offset: 0x6C60A0 VA: 0x1806C76A0
	public void SetIsPaid() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 93
	public override bool ShouldSave() { }

	// RVA: 0x6C4140 Offset: 0x6C2B40 VA: 0x1806C4140 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x6C40E0 Offset: 0x6C2AE0 VA: 0x1806C40E0 Slot: 122
	public virtual EmployeeHome GetHome() { }

	// RVA: 0x6C4FC0 Offset: 0x6C39C0 VA: 0x1806C4FC0
	public bool IsPayAvailable() { }

	// RVA: 0x6C5C30 Offset: 0x6C4630 VA: 0x1806C5C30
	public void RemoveDailyWage() { }

	// RVA: 0x6C4330 Offset: 0x6C2D30 VA: 0x1806C4330 Slot: 123
	public virtual bool GetWorkIssue(out DialogueContainer notWorkingReason) { }

	// RVA: 0x6C7690 Offset: 0x6C6090 VA: 0x1806C7690 Slot: 124
	public virtual void SetIdle(bool idle) { }

	// RVA: 0x6C5060 Offset: 0x6C3A60 VA: 0x1806C5060
	protected void LeavePropertyAndDespawn() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6C7C10 Offset: 0x6C6610 VA: 0x1806C7C10
	public void SubmitNoWorkReason(string reason, string fix, int priority = 0) { }

	// RVA: 0x6C7740 Offset: 0x6C6140 VA: 0x1806C7740
	private bool ShouldShowNoWorkDialogue(bool enabled) { }

	// RVA: 0x6C5730 Offset: 0x6C4130 VA: 0x1806C5730
	private void OnNotWorkingDialogue() { }

	// RVA: 0x6C7730 Offset: 0x6C6130 VA: 0x1806C7730
	private bool ShouldShowFireDialogue(bool enabled) { }

	// RVA: 0x6C7EB0 Offset: 0x6C68B0 VA: 0x1806C7EB0
	private void TradeItems() { }

	// RVA: 0x6C7DB0 Offset: 0x6C67B0 VA: 0x1806C7DB0
	private void TradeItemsDone() { }

	// RVA: 0x6C73F0 Offset: 0x6C5DF0 VA: 0x1806C73F0
	protected void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = True) { }

	// RVA: 0x6C74A0 Offset: 0x6C5EA0 VA: 0x1806C74A0
	protected void SetDestination(Vector3 position, bool teleportIfFail = True) { }

	// RVA: 0x6C8600 Offset: 0x6C7000 VA: 0x1806C8600 Slot: 125
	protected virtual void WalkCallback(NPCMovement.WalkResult result) { }

	// RVA: 0x6C8650 Offset: 0x6C7050 VA: 0x1806C8650
	public void .ctor() { }

	// RVA: 0x6C51D0 Offset: 0x6C3BD0 VA: 0x1806C51D0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6C5170 Offset: 0x6C3B70 VA: 0x1806C5170 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6C6C90 Offset: 0x6C5690 VA: 0x1806C6C90
	private void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex) { }

	// RVA: 0x6C5CE0 Offset: 0x6C46E0 VA: 0x1806C5CE0 Slot: 126
	public virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex) { }

	// RVA: 0x6C6520 Offset: 0x6C4F20 VA: 0x1806C6520
	private void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C7220 Offset: 0x6C5C20 VA: 0x1806C7220
	private void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex) { }

	// RVA: 0x6C6B60 Offset: 0x6C5560 VA: 0x1806C6B60
	private void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C70F0 Offset: 0x6C5AF0 VA: 0x1806C70F0
	private void RpcWriter___Server_SendTransfer_3615296227(string propertyCode) { }

	// RVA: 0x6C60D0 Offset: 0x6C4AD0 VA: 0x1806C60D0
	public void RpcLogic___SendTransfer_3615296227(string propertyCode) { }

	// RVA: 0x6C69F0 Offset: 0x6C53F0 VA: 0x1806C69F0
	private void RpcReader___Server_SendTransfer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6C60D0 Offset: 0x6C4AD0 VA: 0x1806C60D0
	private void RpcWriter___Observers_TransferToProperty_3615296227(string code) { }

	// RVA: 0x6C63D0 Offset: 0x6C4DD0 VA: 0x1806C63D0
	private void RpcLogic___TransferToProperty_3615296227(string code) { }

	// RVA: 0x6C6740 Offset: 0x6C5140 VA: 0x1806C6740
	private void RpcReader___Observers_TransferToProperty_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C6FE0 Offset: 0x6C59E0 VA: 0x1806C6FE0
	private void RpcWriter___Server_SendFire_2166136261() { }

	// RVA: 0x6C5B10 Offset: 0x6C4510 VA: 0x1806C5B10
	public void RpcLogic___SendFire_2166136261() { }

	// RVA: 0x6C68C0 Offset: 0x6C52C0 VA: 0x1806C68C0
	private void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6C5B10 Offset: 0x6C4510 VA: 0x1806C5B10
	private void RpcWriter___Observers_ReceiveFire_2166136261() { }

	// RVA: 0x6C60B0 Offset: 0x6C4AB0 VA: 0x1806C60B0
	private void RpcLogic___ReceiveFire_2166136261() { }

	// RVA: 0x6C6650 Offset: 0x6C5050 VA: 0x1806C6650
	private void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C6E60 Offset: 0x6C5860 VA: 0x1806C6E60
	private void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0) { }

	// RVA: 0x6C6210 Offset: 0x6C4C10 VA: 0x1806C6210
	public void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0) { }

	// RVA: 0x6C6690 Offset: 0x6C5090 VA: 0x1806C6690
	private void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C8770 Offset: 0x6C7170 VA: 0x1806C8770
	public bool sync___get_value_<PaidForToday>k__BackingField() { }

	// RVA: 0x6C8890 Offset: 0x6C7290 VA: 0x1806C8890
	public void sync___set_value_<PaidForToday>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x6C59D0 Offset: 0x6C43D0 VA: 0x1806C59D0 Slot: 127
	public override bool ReadSyncVar___ScheduleOne.Employees.Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6C3D20 Offset: 0x6C2720 VA: 0x1806C3D20 Slot: 128
	protected override void Awake_UserLogic_ScheduleOne.Employees.Employee_Assembly-CSharp.dll() { }
}
