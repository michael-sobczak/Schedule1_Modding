public class PawnShopInterface : Singleton<PawnShopInterface> // TypeDefIndex: 2654
{
	// Fields
	public const float PAYMENT_MIN = 1;
	public const float PAYMENT_MAX = 999999;
	public const float THINK_TIME = 0.75;
	public const float MIN_VALUE_MULTIPLIER = 0.5;
	public const float MAX_VALUE_MULTIPLIER = 2;
	public const int PAWN_SLOT_COUNT = 5;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	private PawnShopInterface.EState CurrentState; // 0x2C
	private PawnShopInterface.EPlayerResponse PlayerResponse; // 0x30
	private int CurrentNegotiationRound; // 0x34
	private float InitialShopOffer; // 0x38
	private float LastShopOffer; // 0x3C
	private float LastRefusedAmount; // 0x40
	public NPC PawnShopNPC; // 0x48
	[CompilerGenerated]
	private float <SelectedPayment>k__BackingField; // 0x50
	[CompilerGenerated]
	private float <NPCAnger>k__BackingField; // 0x54
	public AnimationCurve RandomCurve; // 0x58
	[Header("References")]
	public Canvas Canvas; // 0x60
	public RectTransform Container; // 0x68
	public ItemSlotUI[] Slots; // 0x70
	public TextMeshProUGUI[] ValueRangeLabels; // 0x78
	public TextMeshProUGUI TotalValueLabel; // 0x80
	public Button StartButton; // 0x88
	public Animation Step1Animation; // 0x90
	public CanvasGroup Step1CanvasGroup; // 0x98
	public Animation Step2Animation; // 0xA0
	public CanvasGroup Step2CanvasGroup; // 0xA8
	public AnimationClip FadeInAnim; // 0xB0
	public AnimationClip FadeOutAnim; // 0xB8
	public TMP_InputField OfferInputField; // 0xC0
	public Slider AngerSlider; // 0xC8
	public TextMeshProUGUI AcceptCounterButtonLabel; // 0xD0
	[Header("Settings")]
	public string[] OfferLines; // 0xD8
	public string[] ThinkLines; // 0xE0
	public string[] AcceptLines; // 0xE8
	public string[] CounterLines; // 0xF0
	public string[] RefusalLines; // 0xF8
	public string[] DealFinalizedLines; // 0x100
	public string[] AngeredLines; // 0x108
	public string[] CrashOutLines; // 0x110
	private ItemSlot[] PawnSlots; // 0x118
	private Coroutine routine; // 0x120

	// Properties
	public bool IsOpen { get; set; }
	public float SelectedPayment { get; set; }
	public float NPCAnger { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_SelectedPayment() { }

	[CompilerGenerated]
	// RVA: 0x6FF440 Offset: 0x6FDE40 VA: 0x1806FF440
	private void set_SelectedPayment(float value) { }

	[CompilerGenerated]
	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_NPCAnger() { }

	[CompilerGenerated]
	// RVA: 0x66B050 Offset: 0x669A50 VA: 0x18066B050
	private void set_NPCAnger(float value) { }

	// RVA: 0x8FB200 Offset: 0x8F9C00 VA: 0x1808FB200 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8FDAA0 Offset: 0x8FC4A0 VA: 0x1808FDAA0 Slot: 4
	protected override void Start() { }

	// RVA: 0x8FCA30 Offset: 0x8FB430 VA: 0x1808FCA30 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x8FCC70 Offset: 0x8FB670 VA: 0x1808FCC70
	public void Open() { }

	// RVA: 0x8FBAF0 Offset: 0x8FA4F0 VA: 0x1808FBAF0
	public void Close(bool returnItemsToPlayer) { }

	// RVA: 0x8FC380 Offset: 0x8FAD80 VA: 0x1808FC380
	private void Exit(ExitAction action) { }

	// RVA: 0x8FCC60 Offset: 0x8FB660 VA: 0x1808FCC60
	private void OnMinPass() { }

	// RVA: 0x8FCA20 Offset: 0x8FB420 VA: 0x1808FCA20
	private void OnDayPass() { }

	// RVA: 0x8FE320 Offset: 0x8FCD20 VA: 0x1808FE320
	private void Update() { }

	// RVA: 0x8FC8A0 Offset: 0x8FB2A0 VA: 0x1808FC8A0
	private List<ItemInstance> GetPawnItems() { }

	// RVA: 0x8FD100 Offset: 0x8FBB00 VA: 0x1808FD100
	private void PawnSlotChanged() { }

	// RVA: 0x8FDFF0 Offset: 0x8FC9F0 VA: 0x1808FDFF0
	private void UpdateValueRangeLabels() { }

	// RVA: 0x8FD9F0 Offset: 0x8FC3F0 VA: 0x1808FD9F0
	public void StartButtonPressed() { }

	// RVA: 0x8FD9F0 Offset: 0x8FC3F0 VA: 0x1808FD9F0
	private void StartNegotiation() { }

	// RVA: 0x8FD160 Offset: 0x8FBB60 VA: 0x1808FD160
	private void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter) { }

	// RVA: 0x8FC030 Offset: 0x8FAA30 VA: 0x1808FC030
	private PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange) { }

	// RVA: 0x8FBFB0 Offset: 0x8FA9B0 VA: 0x1808FBFB0
	private void EndNegotiation() { }

	// RVA: 0x8FD110 Offset: 0x8FBB10 VA: 0x1808FD110
	public void PaymentSubmitted(string value) { }

	// RVA: 0x8FBAE0 Offset: 0x8FA4E0 VA: 0x1808FBAE0
	public void ChangePayment(float change) { }

	// RVA: 0x8FD830 Offset: 0x8FC230 VA: 0x1808FD830
	public void SetSelectedPayment(float amount) { }

	// RVA: 0x8FD770 Offset: 0x8FC170 VA: 0x1808FD770
	public void SetPlayerResponse(PawnShopInterface.EPlayerResponse response) { }

	// RVA: 0x8FB1D0 Offset: 0x8F9BD0 VA: 0x1808FB1D0
	public void AcceptOrCounter() { }

	// RVA: 0x8FB710 Offset: 0x8FA110 VA: 0x1808FB710
	public void Cancel() { }

	// RVA: 0x8FB720 Offset: 0x8FA120 VA: 0x1808FB720
	private void ChangeAnger(float change) { }

	// RVA: 0x8FD550 Offset: 0x8FBF50 VA: 0x1808FD550
	private void SetAngeredToday(bool angered) { }

	// RVA: 0x8FDED0 Offset: 0x8FC8D0 VA: 0x1808FDED0
	private void Think() { }

	// RVA: 0x8FD620 Offset: 0x8FC020 VA: 0x1808FD620
	private void SetOffer(float amount) { }

	// RVA: 0x8FC3E0 Offset: 0x8FADE0 VA: 0x1808FC3E0
	private void FinalizeDeal(float amount) { }

	// RVA: 0x8FC980 Offset: 0x8FB380 VA: 0x1808FC980
	private float GetTotalValue() { }

	// RVA: 0x8FD400 Offset: 0x8FBE00 VA: 0x1808FD400
	private float RoundOffer(float offer) { }

	// RVA: 0x8FC510 Offset: 0x8FAF10 VA: 0x1808FC510
	private float GetItemValue(ItemInstance item) { }

	// RVA: 0x8FD350 Offset: 0x8FBD50 VA: 0x1808FD350
	private void ResetUI() { }

	// RVA: 0x8FE620 Offset: 0x8FD020 VA: 0x1808FE620
	public void .ctor() { }

	[IteratorStateMachine(typeof(PawnShopInterface.<<StartNegotiation>g__NegotiationRoutine|67_0>d))]
	[CompilerGenerated]
	// RVA: 0x8FDF80 Offset: 0x8FC980 VA: 0x1808FDF80
	private IEnumerator <StartNegotiation>g__NegotiationRoutine|67_0() { }

	[CompilerGenerated]
	// RVA: 0x8FDF70 Offset: 0x8FC970 VA: 0x1808FDF70
	private bool <StartNegotiation>b__67_1() { }

	[CompilerGenerated]
	// RVA: 0x8FDF70 Offset: 0x8FC970 VA: 0x1808FDF70
	private bool <StartNegotiation>b__67_2() { }
}
