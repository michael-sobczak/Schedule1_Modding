public class ATMInterface : MonoBehaviour // TypeDefIndex: 2989
{
	// Fields
	[SerializeField]
	[Header("References")]
	protected Canvas canvas; // 0x20
	[SerializeField]
	protected ATM atm; // 0x28
	[SerializeField]
	protected AudioSourceController CompleteSound; // 0x30
	[Header("Menu")]
	[SerializeField]
	protected RectTransform menuScreen; // 0x38
	[SerializeField]
	protected Text menu_TitleText; // 0x40
	[SerializeField]
	protected Button menu_DepositButton; // 0x48
	[SerializeField]
	protected Button menu_WithdrawButton; // 0x50
	[SerializeField]
	[Header("Top bar")]
	protected Text depositLimitText; // 0x58
	[SerializeField]
	protected Text onlineBalanceText; // 0x60
	[SerializeField]
	protected Text cleanCashText; // 0x68
	[SerializeField]
	protected RectTransform depositLimitContainer; // 0x70
	[SerializeField]
	[Header("Amount screen")]
	protected RectTransform amountSelectorScreen; // 0x78
	[SerializeField]
	protected Text amountSelectorTitle; // 0x80
	[SerializeField]
	protected List<Button> amountButtons; // 0x88
	[SerializeField]
	protected Text amountLabelText; // 0x90
	[SerializeField]
	protected RectTransform amountBackground; // 0x98
	[SerializeField]
	protected RectTransform selectedButtonIndicator; // 0xA0
	[SerializeField]
	protected Button confirmAmountButton; // 0xA8
	[SerializeField]
	protected Text confirmButtonText; // 0xB0
	[Header("Processing screen")]
	[SerializeField]
	protected RectTransform processingScreen; // 0xB8
	[SerializeField]
	protected RectTransform processingScreenIndicator; // 0xC0
	[SerializeField]
	[Header("Success screen")]
	protected RectTransform successScreen; // 0xC8
	[SerializeField]
	protected Text successScreenSubtitle; // 0xD0
	[SerializeField]
	protected Button doneButton; // 0xD8
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0xE0
	private RectTransform activeScreen; // 0xE8
	public static int[] amounts; // 0x0
	private bool depositing; // 0xF0
	private int selectedAmountIndex; // 0xF4
	private float selectedAmount; // 0xF8

	// Properties
	public bool isOpen { get; set; }
	private float relevantBalance { get; }
	private static float remainingAllowedDeposit { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x973C20 Offset: 0x972620 VA: 0x180973C20
	protected void set_isOpen(bool value) { }

	// RVA: 0x973AE0 Offset: 0x9724E0 VA: 0x180973AE0
	private float get_relevantBalance() { }

	// RVA: 0x973BC0 Offset: 0x9725C0 VA: 0x180973BC0
	private static float get_remainingAllowedDeposit() { }

	// RVA: 0x9718B0 Offset: 0x9702B0 VA: 0x1809718B0
	private void Awake() { }

	// RVA: 0x972160 Offset: 0x970B60 VA: 0x180972160
	private void OnDestroy() { }

	// RVA: 0x972A00 Offset: 0x971400 VA: 0x180972A00 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x9722A0 Offset: 0x970CA0 VA: 0x1809722A0
	private void PlayerSpawned() { }

	// RVA: 0x9730D0 Offset: 0x971AD0 VA: 0x1809730D0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x972000 Offset: 0x970A00 VA: 0x180972000 Slot: 6
	protected virtual void LateUpdate() { }

	// RVA: 0x972670 Offset: 0x971070 VA: 0x180972670 Slot: 7
	public virtual void SetIsOpen(bool o) { }

	// RVA: 0x971D30 Offset: 0x970730 VA: 0x180971D30 Slot: 8
	public virtual void Exit(ExitAction action) { }

	// RVA: 0x9723C0 Offset: 0x970DC0 VA: 0x1809723C0
	public void SetActiveScreen(RectTransform screen) { }

	// RVA: 0x971AF0 Offset: 0x9704F0 VA: 0x180971AF0
	private void DefaultAmountSelection() { }

	// RVA: 0x971CA0 Offset: 0x9706A0 VA: 0x180971CA0
	public void DepositButtonPressed() { }

	// RVA: 0x973820 Offset: 0x972220 VA: 0x180973820
	public void WithdrawButtonPressed() { }

	// RVA: 0x971AC0 Offset: 0x9704C0 VA: 0x180971AC0
	public void CancelAmountSelection() { }

	// RVA: 0x971830 Offset: 0x970230 VA: 0x180971830
	public void AmountSelected(int amountIndex) { }

	// RVA: 0x972840 Offset: 0x971240 VA: 0x180972840
	private void SetSelectedAmount(float amount) { }

	// RVA: 0x971E90 Offset: 0x970890 VA: 0x180971E90
	public static float GetAmountFromIndex(int index, bool depositing) { }

	// RVA: 0x972DB0 Offset: 0x9717B0 VA: 0x180972DB0
	private void UpdateAvailableAmounts() { }

	// RVA: 0x971790 Offset: 0x970190 VA: 0x180971790
	public void AmountConfirmed() { }

	// RVA: 0x971AD0 Offset: 0x9704D0 VA: 0x180971AD0
	public void ChangeAmount(float amount) { }

	[IteratorStateMachine(typeof(ATMInterface.<ProcessTransaction>d__56))]
	// RVA: 0x972330 Offset: 0x970D30 VA: 0x180972330
	protected IEnumerator ProcessTransaction(float amount, bool depositing) { }

	// RVA: 0x971D10 Offset: 0x970710 VA: 0x180971D10
	public void DoneButtonPressed() { }

	// RVA: 0x971AC0 Offset: 0x9704C0 VA: 0x180971AC0
	public void ReturnToMenuButtonPressed() { }

	// RVA: 0x973A50 Offset: 0x972450 VA: 0x180973A50
	public void .ctor() { }

	// RVA: 0x9739C0 Offset: 0x9723C0 VA: 0x1809739C0
	private static void .cctor() { }
}
