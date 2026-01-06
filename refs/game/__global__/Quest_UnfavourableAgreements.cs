public class Quest_UnfavourableAgreements : Quest // TypeDefIndex: 724
{
	// Fields
	public LandVehicle MeetingVehicle; // 0x138
	public ParkingLot MeetingParkingLot; // 0x140
	public ParkingLot ManorParkingLot; // 0x148
	public Thomas Thomas; // 0x150
	public QuestEntry ReadMessageQuestEntry; // 0x158
	public QuestEntry MeetingQuestEntry; // 0x160
	public Quest PrereqQuest; // 0x168
	public UnityEvent onMeetingConcluded; // 0x170

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0 Slot: 30
	protected override void Awake() { }

	// RVA: 0xAE58F0 Offset: 0xAE42F0 VA: 0x180AE58F0 Slot: 31
	protected override void Start() { }

	// RVA: 0xAE5130 Offset: 0xAE3B30 VA: 0x180AE5130
	private void CheckQuestStart() { }

	// RVA: 0xAE5100 Offset: 0xAE3B00 VA: 0x180AE5100 Slot: 34
	public override void Begin(bool network = True) { }

	// RVA: 0xAE55A0 Offset: 0xAE3FA0 VA: 0x180AE55A0 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAE5770 Offset: 0xAE4170 VA: 0x180AE5770 Slot: 40
	public override void SetQuestState(EQuestState state, bool network = True) { }

	// RVA: 0xAE5480 Offset: 0xAE3E80 VA: 0x180AE5480
	private void MeetingEnded() { }

	// RVA: 0xAE5450 Offset: 0xAE3E50 VA: 0x180AE5450
	private void DriveCallback(VehicleAgent.ENavigationResult result) { }

	// RVA: 0xAE56C0 Offset: 0xAE40C0 VA: 0x180AE56C0
	private void Park() { }

	// RVA: 0xAE5B40 Offset: 0xAE4540 VA: 0x180AE5B40
	public void .ctor() { }

	[IteratorStateMachine(typeof(Quest_UnfavourableAgreements.<<MeetingEnded>g__Wait|14_0>d))]
	[CompilerGenerated]
	// RVA: 0xAE5AD0 Offset: 0xAE44D0 VA: 0x180AE5AD0
	private IEnumerator <MeetingEnded>g__Wait|14_0() { }
}
