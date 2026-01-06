public class HospitalBillScreen : Singleton<HospitalBillScreen> // TypeDefIndex: 2671
{
	// Fields
	public const float BILL_COST = 250;
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public RectTransform Container; // 0x38
	public CanvasGroup CanvasGroup; // 0x40
	public TextMeshProUGUI PatientNameLabel; // 0x48
	public TextMeshProUGUI BillNumberLabel; // 0x50
	public TextMeshProUGUI PaidAmountLabel; // 0x58
	private bool arrested; // 0x60

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	// RVA: 0x8F5C30 Offset: 0x8F4630 VA: 0x1808F5C30 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F6070 Offset: 0x8F4A70 VA: 0x1808F6070
	private void Exit(ExitAction action) { }

	// RVA: 0x8F6380 Offset: 0x8F4D80 VA: 0x1808F6380
	private void PlayerSpawned() { }

	// RVA: 0x8F60C0 Offset: 0x8F4AC0 VA: 0x1808F60C0
	public void Open() { }

	// RVA: 0x8F5E60 Offset: 0x8F4860 VA: 0x1808F5E60
	public void Close() { }

	// RVA: 0x8F6480 Offset: 0x8F4E80 VA: 0x1808F6480
	public void .ctor() { }

	[IteratorStateMachine(typeof(HospitalBillScreen.<<Close>g__CloseRoutine|16_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F6410 Offset: 0x8F4E10 VA: 0x1808F6410
	private IEnumerator <Close>g__CloseRoutine|16_0() { }
}
