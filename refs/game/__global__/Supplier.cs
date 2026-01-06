public class Supplier : NPC // TypeDefIndex: 1527
{
	// Fields
	public const float MEETUP_RELATIONSHIP_REQUIREMENT = 4;
	public const int MEETUP_DURATION_MINS = 360;
	public const int MEETING_COOLDOWN_MINS = 720;
	public const int DEADDROP_WAIT_PER_ITEM = 30;
	public const int DEADDROP_MAX_WAIT = 360;
	public const int DEADDROP_ITEM_LIMIT = 10;
	public const float DELIVERY_RELATIONSHIP_REQUIREMENT = 5;
	public static Color32 SupplierLabelColor; // 0x0
	[CompilerGenerated]
	private Supplier.ESupplierStatus <Status>k__BackingField; // 0x2F0
	[CompilerGenerated]
	private bool <DeliveriesEnabled>k__BackingField; // 0x2F4
	[Header("Supplier Settings")]
	public float MinOrderLimit; // 0x2F8
	public float MaxOrderLimit; // 0x2FC
	public PhoneShopInterface.Listing[] OnlineShopItems; // 0x300
	[TextArea(3, 10)]
	public string SupplierRecommendMessage; // 0x308
	[TextArea(3, 10)]
	public string SupplierUnlockHint; // 0x310
	[Header("References")]
	public ShopInterface Shop; // 0x318
	public SupplierStash Stash; // 0x320
	public UnityEvent onDeaddropReady; // 0x328
	private int minsSinceMeetingStart; // 0x330
	private int minsSinceLastMeetingEnd; // 0x334
	private SupplierLocation currentLocation; // 0x338
	private DialogueController dialogueController; // 0x340
	private DialogueController.GreetingOverride meetingGreeting; // 0x348
	private DialogueController.DialogueChoice meetingChoice; // 0x350
	[SyncVar]
	public float debt; // 0x358
	[SyncVar]
	public bool deadDropPreparing; // 0x35C
	[CompilerGenerated]
	private int <minsUntilDeaddropReady>k__BackingField; // 0x360
	private StringIntPair[] deaddropItems; // 0x368
	private int minsSinceDeaddropOrder; // 0x370
	private bool repaymentReminderSent; // 0x374
	public SyncVar<float> syncVar___debt; // 0x378
	public SyncVar<bool> syncVar___deadDropPreparing; // 0x380
	private bool NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted; // 0x388
	private bool NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted; // 0x389

	// Properties
	public Supplier.ESupplierStatus Status { get; set; }
	public bool DeliveriesEnabled { get; set; }
	public float Debt { get; }
	public int minsUntilDeaddropReady { get; set; }
	public float SyncAccessor_debt { get; set; }
	public bool SyncAccessor_deadDropPreparing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6E6200 Offset: 0x6E4C00 VA: 0x1806E6200
	public Supplier.ESupplierStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x6E6230 Offset: 0x6E4C30 VA: 0x1806E6230
	private void set_Status(Supplier.ESupplierStatus value) { }

	[CompilerGenerated]
	// RVA: 0x6E61F0 Offset: 0x6E4BF0 VA: 0x1806E61F0
	public bool get_DeliveriesEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6E6220 Offset: 0x6E4C20 VA: 0x1806E6220
	private void set_DeliveriesEnabled(bool value) { }

	// RVA: 0x6E61E0 Offset: 0x6E4BE0 VA: 0x1806E61E0
	public float get_Debt() { }

	[CompilerGenerated]
	// RVA: 0x6E6210 Offset: 0x6E4C10 VA: 0x1806E6210
	public int get_minsUntilDeaddropReady() { }

	[CompilerGenerated]
	// RVA: 0x6E6240 Offset: 0x6E4C40 VA: 0x1806E6240
	private void set_minsUntilDeaddropReady(int value) { }

	// RVA: 0x6E00C0 Offset: 0x6DEAC0 VA: 0x1806E00C0 Slot: 65
	public override void Awake() { }

	// RVA: 0x6E5260 Offset: 0x6E3C60 VA: 0x1806E5260 Slot: 71
	protected override void Start() { }

	// RVA: 0x6E3410 Offset: 0x6E1E10 VA: 0x1806E3410 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6E4C30 Offset: 0x6E3630 VA: 0x1806E4C30
	public void SendUnlocked() { }

	[ObserversRpc]
	// RVA: 0x6E40E0 Offset: 0x6E2AE0 VA: 0x1806E40E0
	private void SetUnlocked() { }

	// RVA: 0x6E2DD0 Offset: 0x6E17D0 VA: 0x1806E2DD0 Slot: 73
	protected override void MinPass() { }

	// RVA: 0x6E2210 Offset: 0x6E0C10 VA: 0x1806E2210
	protected void HourPass() { }

	// RVA: 0x6E3500 Offset: 0x6E1F00 VA: 0x1806E3500
	private void OnTimeSkip(int minsSlept) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6E2A90 Offset: 0x6E1490 VA: 0x1806E2A90
	public void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn) { }

	// RVA: 0x6E1A20 Offset: 0x6E0420 VA: 0x1806E1A20
	public void EndMeeting() { }

	// RVA: 0x6E5B90 Offset: 0x6E4590 VA: 0x1806E5B90 Slot: 111
	protected virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify) { }

	// RVA: 0x6E37F0 Offset: 0x6E21F0 VA: 0x1806E37F0 Slot: 112
	protected virtual void RelationshipChange(float change) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6E17D0 Offset: 0x6E01D0 VA: 0x1806E17D0
	private void EnableDeliveries(NetworkConnection conn) { }

	// RVA: 0x6E5150 Offset: 0x6E3B50 VA: 0x1806E5150
	private void SendUnlockMessage() { }

	// RVA: 0x6E0850 Offset: 0x6DF250 VA: 0x1806E0850 Slot: 68
	protected override void CreateMessageConversation() { }

	// RVA: 0x6E15F0 Offset: 0x6DFFF0 VA: 0x1806E15F0 Slot: 113
	protected virtual void DeaddropRequested() { }

	// RVA: 0x6E0C30 Offset: 0x6DF630 VA: 0x1806E0C30 Slot: 114
	protected virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x6E4D40 Offset: 0x6E3740 VA: 0x1806E4D40
	private void SetDeaddrop(StringIntPair[] items, int minsUntilReady) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6E0120 Offset: 0x6DEB20 VA: 0x1806E0120
	private void ChangeDebt(float amount) { }

	// RVA: 0x6E5D10 Offset: 0x6E4710 VA: 0x1806E5D10
	private void TryRecoverDebt() { }

	// RVA: 0x6E0250 Offset: 0x6DEC50 VA: 0x1806E0250
	private void CompleteDeaddrop() { }

	// RVA: 0x6E4FE0 Offset: 0x6E39E0 VA: 0x1806E4FE0
	private void SendDebtReminder() { }

	// RVA: 0x6E2C40 Offset: 0x6E1640 VA: 0x1806E2C40 Slot: 115
	protected virtual void MeetupRequested() { }

	// RVA: 0x6E3520 Offset: 0x6E1F20 VA: 0x1806E3520 Slot: 116
	protected virtual void PayDebtRequested() { }

	// RVA: 0x6E1AF0 Offset: 0x6E04F0 VA: 0x1806E1AF0
	protected SupplierLocation GetAppropriateLocation(out int locationIndex) { }

	// RVA: 0x6E2410 Offset: 0x6E0E10 VA: 0x1806E2410
	private bool IsDeadDropValid(SendableMessage message, out string invalidReason) { }

	// RVA: 0x6E24A0 Offset: 0x6E0EA0 VA: 0x1806E24A0
	private bool IsMeetupValid(SendableMessage message, out string invalidReason) { }

	// RVA: 0x6E20C0 Offset: 0x6E0AC0 VA: 0x1806E20C0 Slot: 117
	public virtual float GetDeadDropLimit() { }

	// RVA: 0x6E2130 Offset: 0x6E0B30 VA: 0x1806E2130 Slot: 97
	public override NPCData GetNPCData() { }

	// RVA: 0x6E2790 Offset: 0x6E1190 VA: 0x1806E2790 Slot: 100
	public override void Load(NPCData data, string containerPath) { }

	// RVA: 0x6E2580 Offset: 0x6E0F80 VA: 0x1806E2580 Slot: 101
	public override void Load(DynamicSaveData dynamicData, NPCData npcData) { }

	// RVA: 0x6E6120 Offset: 0x6E4B20 VA: 0x1806E6120
	public void .ctor() { }

	// RVA: 0x6E60D0 Offset: 0x6E4AD0 VA: 0x1806E60D0
	private static void .cctor() { }

	[IteratorStateMachine(typeof(Supplier.<<SupplierUnlocked>g__WaitForPlayer|52_0>d))]
	[CompilerGenerated]
	// RVA: 0x6E6060 Offset: 0x6E4A60 VA: 0x1806E6060
	private IEnumerator <SupplierUnlocked>g__WaitForPlayer|52_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Supplier.<<EnableDeliveries>g__Wait|54_0>d))]
	// RVA: 0x6E5FF0 Offset: 0x6E49F0 VA: 0x1806E5FF0
	private IEnumerator <EnableDeliveries>g__Wait|54_0() { }

	// RVA: 0x6E2FF0 Offset: 0x6E19F0 VA: 0x1806E2FF0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6E2F80 Offset: 0x6E1980 VA: 0x1806E2F80 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6E4C30 Offset: 0x6E3630 VA: 0x1806E4C30
	private void RpcWriter___Server_SendUnlocked_2166136261() { }

	// RVA: 0x6E40E0 Offset: 0x6E2AE0 VA: 0x1806E40E0
	public void RpcLogic___SendUnlocked_2166136261() { }

	// RVA: 0x6E4550 Offset: 0x6E2F50 VA: 0x1806E4550
	private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6E40E0 Offset: 0x6E2AE0 VA: 0x1806E40E0
	private void RpcWriter___Observers_SetUnlocked_2166136261() { }

	// RVA: 0x6E4340 Offset: 0x6E2D40 VA: 0x1806E4340
	private void RpcLogic___SetUnlocked_2166136261() { }

	// RVA: 0x6E4480 Offset: 0x6E2E80 VA: 0x1806E4480
	private void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6E4960 Offset: 0x6E3360 VA: 0x1806E4960
	private void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn) { }

	// RVA: 0x6E3C60 Offset: 0x6E2660 VA: 0x1806E3C60
	public void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn) { }

	// RVA: 0x6E43C0 Offset: 0x6E2DC0 VA: 0x1806E43C0
	private void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6E4840 Offset: 0x6E3240 VA: 0x1806E4840
	private void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn) { }

	// RVA: 0x6E3B70 Offset: 0x6E2570 VA: 0x1806E3B70
	private void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn) { }

	// RVA: 0x6E4380 Offset: 0x6E2D80 VA: 0x1806E4380
	private void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6E4EB0 Offset: 0x6E38B0 VA: 0x1806E4EB0
	private void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn) { }

	// RVA: 0x6E4800 Offset: 0x6E3200 VA: 0x1806E4800
	private void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6E4D40 Offset: 0x6E3740 VA: 0x1806E4D40
	private void RpcWriter___Server_SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady) { }

	// RVA: 0x6E4200 Offset: 0x6E2C00 VA: 0x1806E4200
	private void RpcLogic___SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady) { }

	// RVA: 0x6E4680 Offset: 0x6E3080 VA: 0x1806E4680
	private void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6E4AF0 Offset: 0x6E34F0 VA: 0x1806E4AF0
	private void RpcWriter___Server_ChangeDebt_431000436(float amount) { }

	// RVA: 0x6E3AA0 Offset: 0x6E24A0 VA: 0x1806E3AA0
	private void RpcLogic___ChangeDebt_431000436(float amount) { }

	// RVA: 0x6E44D0 Offset: 0x6E2ED0 VA: 0x1806E44D0
	private void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6E61E0 Offset: 0x6E4BE0 VA: 0x1806E61E0
	public float sync___get_value_debt() { }

	// RVA: 0x6E6320 Offset: 0x6E4D20 VA: 0x1806E6320
	public void sync___set_value_debt(float value, bool asServer) { }

	// RVA: 0x6E3650 Offset: 0x6E2050 VA: 0x1806E3650 Slot: 118
	public override bool ReadSyncVar___ScheduleOne.Economy.Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6E6250 Offset: 0x6E4C50 VA: 0x1806E6250
	public bool sync___get_value_deadDropPreparing() { }

	// RVA: 0x6E6260 Offset: 0x6E4C60 VA: 0x1806E6260
	public void sync___set_value_deadDropPreparing(bool value, bool asServer) { }

	// RVA: 0x6E0080 Offset: 0x6DEA80 VA: 0x1806E0080 Slot: 119
	protected override void Awake_UserLogic_ScheduleOne.Economy.Supplier_Assembly-CSharp.dll() { }
}
