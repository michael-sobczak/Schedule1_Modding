public class Quest_TheDeepEnd : Quest // TypeDefIndex: 722
{
	// Fields
	public const float MEETING_REMINDER_TIME = 36;
	public const float KIDNAP_TIME = 82;
	private bool kidnapQueued; // 0x138
	private bool meetingSetup; // 0x139
	public Thomas Thomas; // 0x140
	public ManorGate Gate; // 0x148
	public ModularSwitch Switch; // 0x150
	public Transform MeetingTeleportPoint; // 0x158
	public PhoneCallData PostMeetingCall; // 0x160
	public SystemTriggerObject PostMeetingTrigger; // 0x168

	// Methods

	// RVA: 0xAE4B70 Offset: 0xAE3570 VA: 0x180AE4B70 Slot: 31
	protected override void Start() { }

	// RVA: 0xAE46C0 Offset: 0xAE30C0 VA: 0x180AE46C0 Slot: 34
	public override void Begin(bool network = True) { }

	// RVA: 0xAE4920 Offset: 0xAE3320 VA: 0x180AE4920
	public void SetupFirstMeeting() { }

	// RVA: 0xAE4E80 Offset: 0xAE3880 VA: 0x180AE4E80
	private void ThomasDialogueNodeDisplayed(string nodeLabel) { }

	// RVA: 0xAE46E0 Offset: 0xAE30E0 VA: 0x180AE46E0
	private void HourPass() { }

	// RVA: 0xAE4610 Offset: 0xAE3010 VA: 0x180AE4610
	private void BeforeSleep() { }

	// RVA: 0xAE4A10 Offset: 0xAE3410 VA: 0x180AE4A10
	private void SleepFadeOut() { }

	// RVA: 0xAE4870 Offset: 0xAE3270 VA: 0x180AE4870 Slot: 42
	public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = True) { }

	// RVA: 0xAE50B0 Offset: 0xAE3AB0 VA: 0x180AE50B0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Quest_TheDeepEnd.<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d))]
	// RVA: 0xAE5040 Offset: 0xAE3A40 VA: 0x180AE5040
	private IEnumerator <ThomasDialogueNodeDisplayed>g__Wait|13_0() { }
}
