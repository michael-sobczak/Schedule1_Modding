public class RTBInterface : Singleton<RTBInterface> // TypeDefIndex: 2054
{
	// Fields
	[CompilerGenerated]
	private RTBGameController <CurrentGame>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public CasinoGamePlayerDisplay PlayerDisplay; // 0x38
	public TextMeshProUGUI StatusLabel; // 0x40
	public RectTransform BetContainer; // 0x48
	public TextMeshProUGUI BetTitleLabel; // 0x50
	public Slider BetSlider; // 0x58
	public TextMeshProUGUI BetAmount; // 0x60
	public Button ReadyButton; // 0x68
	public TextMeshProUGUI ReadyLabel; // 0x70
	public TextMeshProUGUI WinningsMultiplierLabel; // 0x78
	[Header("Question and answers")]
	public RectTransform QuestionContainer; // 0x80
	public TextMeshProUGUI QuestionLabel; // 0x88
	public Slider TimerSlider; // 0x90
	public Button[] AnswerButtons; // 0x98
	public TextMeshProUGUI[] AnswerLabels; // 0xA0
	public Button ForfeitButton; // 0xA8
	public TextMeshProUGUI ForfeitLabel; // 0xB0
	public Animation QuestionContainerAnimation; // 0xB8
	public AnimationClip QuestionContainerFadeIn; // 0xC0
	public AnimationClip QuestionContainerFadeOut; // 0xC8
	public CanvasGroup QuestionCanvasGroup; // 0xD0
	public RectTransform SelectionIndicator; // 0xD8
	public UnityEvent onCorrect; // 0xE0
	public UnityEvent onFinalCorrect; // 0xE8
	public UnityEvent onIncorrect; // 0xF0

	// Properties
	public RTBGameController CurrentGame { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public RTBGameController get_CurrentGame() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_CurrentGame(RTBGameController value) { }

	// RVA: 0x7EA0C0 Offset: 0x7E8AC0 VA: 0x1807EA0C0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7EAAE0 Offset: 0x7E94E0 VA: 0x1807EAAE0
	private void FixedUpdate() { }

	// RVA: 0x7EAE20 Offset: 0x7E9820 VA: 0x1807EAE20
	private string GetStatusText() { }

	// RVA: 0x7EB0F0 Offset: 0x7E9AF0 VA: 0x1807EB0F0
	public void Open(RTBGameController game) { }

	// RVA: 0x7EA430 Offset: 0x7E8E30 VA: 0x1807EA430
	public void Close() { }

	// RVA: 0x7EA3B0 Offset: 0x7E8DB0 VA: 0x1807EA3B0
	private void BetSliderChanged(float newValue) { }

	// RVA: 0x7EADD0 Offset: 0x7E97D0 VA: 0x1807EADD0
	private float GetBetFromSliderValue(float sliderVal) { }

	// RVA: 0x7EBA60 Offset: 0x7EA460 VA: 0x1807EBA60
	private void RefreshDisplayedBet() { }

	// RVA: 0x7EBB40 Offset: 0x7EA540 VA: 0x1807EBB40
	private void RefreshReadyButton() { }

	// RVA: 0x7EB740 Offset: 0x7EA140 VA: 0x1807EB740
	private void QuestionReady(string question, string[] answers) { }

	// RVA: 0x7E9FC0 Offset: 0x7E89C0 VA: 0x1807E9FC0
	private void AnswerButtonClicked(int index) { }

	// RVA: 0x7EACC0 Offset: 0x7E96C0 VA: 0x1807EACC0
	private void ForfeitClicked() { }

	// RVA: 0x7EB6E0 Offset: 0x7EA0E0 VA: 0x1807EB6E0
	private void QuestionDone() { }

	// RVA: 0x7EB070 Offset: 0x7E9A70 VA: 0x1807EB070
	private void LocalPlayerExitRound() { }

	// RVA: 0x7EA9F0 Offset: 0x7E93F0 VA: 0x1807EA9F0
	private void Correct() { }

	// RVA: 0x7EB050 Offset: 0x7E9A50 VA: 0x1807EB050
	private void Incorrect() { }

	// RVA: 0x7EBA40 Offset: 0x7EA440 VA: 0x1807EBA40
	private void ReadyButtonClicked() { }

	// RVA: 0x7EBDD0 Offset: 0x7EA7D0 VA: 0x1807EBDD0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(RTBInterface.<<QuestionReady>g__Routine|38_0>d))]
	// RVA: 0x7EBD60 Offset: 0x7EA760 VA: 0x1807EBD60
	private IEnumerator <QuestionReady>g__Routine|38_0() { }
}
