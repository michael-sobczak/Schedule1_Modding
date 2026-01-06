public class FeedbackForm : MonoBehaviour // TypeDefIndex: 17981
{
	// Fields
	public const int MAX_SUBMISSIONS_PER_SESSION = 5;
	[Tooltip("Easy Feedback configuration file")]
	public EFConfig Config; // 0x20
	[Tooltip("Include screenshot with reports?")]
	public bool IncludeScreenshot; // 0x28
	[Tooltip("Include save file with reports?")]
	public bool IncludeSaveFile; // 0x29
	[Tooltip("Method used to capture the screenshot.")]
	public ScreenshotMode ScreenshotCaptureMode; // 0x2C
	[Tooltip("Resizes screenshots larger than 1080p to help with Trello's filesize limit.
NOTE: Not supported in Legacy screenshot mode.")]
	public bool ResizeLargeScreenshots; // 0x30
	public Transform Form; // 0x38
	[Tooltip("Functions to be called when the form is first opened")]
	public UnityEvent OnFormOpened; // 0x40
	[Tooltip("Functions to be called when the form is submitted")]
	public UnityEvent OnFormSubmitted; // 0x48
	[Tooltip("Functions to be called when the form is closed")]
	public UnityEvent OnFormClosed; // 0x50
	[Tooltip("Called to notify of any errors during submission")]
	public FeedbackForm.SubmissionMessageEvent OnSubmissionError; // 0x58
	[Tooltip("Called when the submission has successfully completed")]
	public UnityEvent OnSubmissionSucceeded; // 0x60
	[Tooltip("Called if the submission fails")]
	public UnityEvent OnSubmissionFailed; // 0x68
	public Report CurrentReport; // 0x70
	private string screenshotPath; // 0x78
	private Coroutine ssCoroutine; // 0x80
	private Trello trello; // 0x88
	private int submissionCount; // 0x90

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x43EB30 Offset: 0x43D530 VA: 0x18043EB30
	public bool get_IsOpen() { }

	// RVA: 0x43DD60 Offset: 0x43C760 VA: 0x18043DD60 Slot: 4
	public virtual void Awake() { }

	// RVA: 0x43E5A0 Offset: 0x43CFA0 VA: 0x18043E5A0
	private void ReportError(string message) { }

	// RVA: 0x43E510 Offset: 0x43CF10 VA: 0x18043E510
	public void InitTrelloAPI() { }

	// RVA: 0x43E4B0 Offset: 0x43CEB0 VA: 0x18043E4B0
	private void InitCurrentReport() { }

	// RVA: 0x43E7B0 Offset: 0x43D1B0 VA: 0x18043E7B0
	public void Toggle() { }

	// RVA: 0x43E660 Offset: 0x43D060 VA: 0x18043E660
	public void Show() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void Submit() { }

	// RVA: 0x43E380 Offset: 0x43CD80 VA: 0x18043E380 Slot: 6
	protected virtual string GetTextToAppendToTitle() { }

	[IteratorStateMachine(typeof(FeedbackForm.<SubmitAsync>d__29))]
	// RVA: 0x43E740 Offset: 0x43D140 VA: 0x18043E740
	protected IEnumerator SubmitAsync() { }

	[IteratorStateMachine(typeof(FeedbackForm.<AttachFilesAsync>d__30))]
	// RVA: 0x43DCD0 Offset: 0x43C6D0 VA: 0x18043DCD0
	private IEnumerator AttachFilesAsync(string cardID) { }

	// RVA: 0x43E8C0 Offset: 0x43D2C0 VA: 0x18043E8C0
	private string WriteLocal(Report report) { }

	// RVA: 0x43DEC0 Offset: 0x43C8C0 VA: 0x18043DEC0
	public void DisableForm() { }

	// RVA: 0x43E120 Offset: 0x43CB20 VA: 0x18043E120
	public void EnableForm() { }

	// RVA: 0x43E3B0 Offset: 0x43CDB0 VA: 0x18043E3B0
	public void Hide() { }

	[IteratorStateMachine(typeof(FeedbackForm.<ScreenshotAndOpenForm>d__35))]
	// RVA: 0x43E5F0 Offset: 0x43CFF0 VA: 0x18043E5F0
	private IEnumerator ScreenshotAndOpenForm() { }

	// RVA: 0x43EB10 Offset: 0x43D510 VA: 0x18043EB10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43E800 Offset: 0x43D200 VA: 0x18043E800
	private void <ScreenshotAndOpenForm>b__35_0(byte[] ss) { }

	[CompilerGenerated]
	// RVA: 0x43E860 Offset: 0x43D260 VA: 0x18043E860
	private void <ScreenshotAndOpenForm>b__35_1(string err) { }
}
