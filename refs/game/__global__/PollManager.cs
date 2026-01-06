public class PollManager : MonoBehaviour // TypeDefIndex: 767
{
	// Fields
	public const string SERVER_URL = "https://us-central1-s1-polling-987345.cloudfunctions.net/poll";
	[CompilerGenerated]
	private PollData <ActivePoll>k__BackingField; // 0x20
	[CompilerGenerated]
	private PollData <ConfirmedPoll>k__BackingField; // 0x28
	[CompilerGenerated]
	private PollManager.EPollSubmissionResult <SubmissionResult>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <SubmisssionFailedMesssage>k__BackingField; // 0x38
	private CallResult<EncryptedAppTicketResponse_t> appTicketCallbackResponse; // 0x40
	private TaskCompletionSource<string> tokenCompletion; // 0x48
	private PollResponse receivedPollResponse; // 0x50
	private int sentResponse; // 0x58
	private string appTicket; // 0x60
	public Action<PollData> onActivePollReceived; // 0x68
	public Action<PollData> onConfirmedPollReceived; // 0x70
	private bool appTicketRequested; // 0x78

	// Properties
	public PollData ActivePoll { get; set; }
	public PollData ConfirmedPoll { get; set; }
	public PollManager.EPollSubmissionResult SubmissionResult { get; set; }
	public string SubmisssionFailedMesssage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public PollData get_ActivePoll() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ActivePoll(PollData value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public PollData get_ConfirmedPoll() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ConfirmedPoll(PollData value) { }

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public PollManager.EPollSubmissionResult get_SubmissionResult() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	private void set_SubmissionResult(PollManager.EPollSubmissionResult value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_SubmisssionFailedMesssage() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_SubmisssionFailedMesssage(string value) { }

	// RVA: 0x5922E0 Offset: 0x590CE0 VA: 0x1805922E0
	private void Start() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Update() { }

	// RVA: 0x591660 Offset: 0x590060 VA: 0x180591660
	public void GenerateAppTicket() { }

	// RVA: 0x592120 Offset: 0x590B20 VA: 0x180592120
	public void SelectPollResponse(int responseIndex) { }

	[AsyncStateMachine(typeof(PollManager.<InitAppTicket>d__30))]
	// RVA: 0x5918C0 Offset: 0x5902C0 VA: 0x1805918C0
	private Task InitAppTicket() { }

	[IteratorStateMachine(typeof(PollManager.<SubmitAnswerToServer>d__31))]
	// RVA: 0x5923F0 Offset: 0x590DF0 VA: 0x1805923F0
	private IEnumerator SubmitAnswerToServer(PollAnswer answer) { }

	[IteratorStateMachine(typeof(PollManager.<RequestPoll>d__32))]
	// RVA: 0x591BD0 Offset: 0x5905D0 VA: 0x180591BD0
	private IEnumerator RequestPoll(string url, Action<string> callback) { }

	// RVA: 0x591C60 Offset: 0x590660 VA: 0x180591C60
	private void ResponseCallback(string data) { }

	// RVA: 0x591990 Offset: 0x590390 VA: 0x180591990
	private void OnEncryptedAppTicketResponse(EncryptedAppTicketResponse_t response, bool ioFailure) { }

	// RVA: 0x5917A0 Offset: 0x5901A0 VA: 0x1805917A0
	private Task<string> GetAppTicket() { }

	// RVA: 0x591600 Offset: 0x590000 VA: 0x180591600
	private static string CleanTicket(string ticket) { }

	// RVA: 0x592480 Offset: 0x590E80 VA: 0x180592480
	public static bool TryGetExistingPollResponse(int pollId, out int response) { }

	// RVA: 0x591B20 Offset: 0x590520 VA: 0x180591B20
	private static void RecordSubmission(int pollId, int response) { }

	// RVA: 0x592570 Offset: 0x590F70 VA: 0x180592570
	public void .ctor() { }
}
