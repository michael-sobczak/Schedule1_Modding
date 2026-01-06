public class BlackjackInterface : Singleton<BlackjackInterface> // TypeDefIndex: 2050
{
	// Fields
	[CompilerGenerated]
	private BlackjackGameController <CurrentGame>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public CasinoGamePlayerDisplay PlayerDisplay; // 0x38
	public RectTransform BetContainer; // 0x40
	public TextMeshProUGUI BetTitleLabel; // 0x48
	public Slider BetSlider; // 0x50
	public TextMeshProUGUI BetAmount; // 0x58
	public Button ReadyButton; // 0x60
	public TextMeshProUGUI ReadyLabel; // 0x68
	public RectTransform WaitingContainer; // 0x70
	public TextMeshProUGUI WaitingLabel; // 0x78
	public TextMeshProUGUI DealerScoreLabel; // 0x80
	public TextMeshProUGUI PlayerScoreLabel; // 0x88
	public Button HitButton; // 0x90
	public Button StandButton; // 0x98
	public Animation InputContainerAnimation; // 0xA0
	public CanvasGroup InputContainerCanvasGroup; // 0xA8
	public AnimationClip InputContainerFadeIn; // 0xB0
	public AnimationClip InputContainerFadeOut; // 0xB8
	public RectTransform SelectionIndicator; // 0xC0
	public Animation ScoresContainerAnimation; // 0xC8
	public CanvasGroup ScoresContainerCanvasGroup; // 0xD0
	public TextMeshProUGUI PositiveOutcomeLabel; // 0xD8
	public TextMeshProUGUI PayoutLabel; // 0xE0
	public UnityEvent onBust; // 0xE8
	public UnityEvent onBlackjack; // 0xF0
	public UnityEvent onWin; // 0xF8
	public UnityEvent onLose; // 0x100
	public UnityEvent onPush; // 0x108

	// Properties
	public BlackjackGameController CurrentGame { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public BlackjackGameController get_CurrentGame() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_CurrentGame(BlackjackGameController value) { }

	// RVA: 0x7DC150 Offset: 0x7DAB50 VA: 0x1807DC150 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7DC9D0 Offset: 0x7DB3D0 VA: 0x1807DC9D0
	private void FixedUpdate() { }

	// RVA: 0x7DD310 Offset: 0x7DBD10 VA: 0x1807DD310
	public void Open(BlackjackGameController game) { }

	// RVA: 0x7DC410 Offset: 0x7DAE10 VA: 0x1807DC410
	public void Close() { }

	// RVA: 0x7DC390 Offset: 0x7DAD90 VA: 0x1807DC390
	private void BetSliderChanged(float newValue) { }

	// RVA: 0x7DCE20 Offset: 0x7DB820 VA: 0x1807DCE20
	private float GetBetFromSliderValue(float sliderVal) { }

	// RVA: 0x7DD920 Offset: 0x7DC320 VA: 0x1807DD920
	private void RefreshDisplayedBet() { }

	// RVA: 0x7DDA00 Offset: 0x7DC400 VA: 0x1807DDA00
	private void RefreshReadyButton() { }

	// RVA: 0x7DD0D0 Offset: 0x7DBAD0 VA: 0x1807DD0D0
	private void LocalPlayerReadyForInput() { }

	// RVA: 0x7DDC20 Offset: 0x7DC620 VA: 0x1807DDC20
	private void ShowScores() { }

	// RVA: 0x7DCE70 Offset: 0x7DB870 VA: 0x1807DCE70
	private void HideScores() { }

	// RVA: 0x7DCEB0 Offset: 0x7DB8B0 VA: 0x1807DCEB0
	private void HitClicked() { }

	// RVA: 0x7DDC60 Offset: 0x7DC660 VA: 0x1807DDC60
	private void StandClicked() { }

	// RVA: 0x7DD020 Offset: 0x7DBA20 VA: 0x1807DD020
	private void LocalPlayerExitRound() { }

	// RVA: 0x7DD900 Offset: 0x7DC300 VA: 0x1807DD900
	private void ReadyButtonClicked() { }

	// RVA: 0x7DD160 Offset: 0x7DBB60 VA: 0x1807DD160
	private void OnLocalPlayerBust() { }

	// RVA: 0x7DD180 Offset: 0x7DBB80 VA: 0x1807DD180
	private void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout) { }

	// RVA: 0x7DDDD0 Offset: 0x7DC7D0 VA: 0x1807DDDD0
	public void .ctor() { }
}
