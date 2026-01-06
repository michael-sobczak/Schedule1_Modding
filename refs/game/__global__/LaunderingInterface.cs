public class LaunderingInterface : MonoBehaviour // TypeDefIndex: 2632
{
	// Fields
	protected const float fovOverride = 65;
	protected const float lerpTime = 0.15;
	protected const int minLaunderAmount = 10;
	[CompilerGenerated]
	private Business <business>k__BackingField; // 0x20
	[Header("References")]
	[SerializeField]
	protected Transform cameraPosition; // 0x28
	[SerializeField]
	protected InteractableObject intObj; // 0x30
	[SerializeField]
	protected Button launderButton; // 0x38
	[SerializeField]
	protected GameObject amountSelectorScreen; // 0x40
	[SerializeField]
	protected Slider amountSlider; // 0x48
	[SerializeField]
	protected TMP_InputField amountInputField; // 0x50
	[SerializeField]
	protected RectTransform notchContainer; // 0x58
	[SerializeField]
	protected TextMeshProUGUI currentTotalAmountLabel; // 0x60
	[SerializeField]
	protected TextMeshProUGUI launderCapacityLabel; // 0x68
	[SerializeField]
	protected TextMeshProUGUI insufficientCashLabel; // 0x70
	[SerializeField]
	protected RectTransform entryContainer; // 0x78
	[SerializeField]
	protected RectTransform noEntries; // 0x80
	public CashStackVisuals[] CashStacks; // 0x88
	[SerializeField]
	[Header("Prefabs")]
	protected GameObject timelineNotchPrefab; // 0x90
	[SerializeField]
	protected GameObject entryPrefab; // 0x98
	[SerializeField]
	[Header("UI references")]
	protected Canvas canvas; // 0xA0
	private int selectedAmountToLaunder; // 0xA8
	private Dictionary<LaunderingOperation, RectTransform> operationToNotch; // 0xB0
	private List<RectTransform> notches; // 0xB8
	private bool ignoreSliderChange; // 0xC0
	private Dictionary<LaunderingOperation, RectTransform> operationToEntry; // 0xC8

	// Properties
	protected int maxLaunderAmount { get; }
	public Business business { get; set; }
	public bool isOpen { get; }

	// Methods

	// RVA: 0x8EE350 Offset: 0x8ECD50 VA: 0x1808EE350
	protected int get_maxLaunderAmount() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Business get_business() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_business(Business value) { }

	// RVA: 0x8EE2B0 Offset: 0x8ECCB0 VA: 0x1808EE2B0
	public bool get_isOpen() { }

	// RVA: 0x8EBBF0 Offset: 0x8EA5F0 VA: 0x1808EBBF0
	public void Initialize(Business bus) { }

	// RVA: 0x8EC680 Offset: 0x8EB080 VA: 0x1808EC680
	private void OnDestroy() { }

	// RVA: 0x8EC5F0 Offset: 0x8EAFF0 VA: 0x1808EC5F0 Slot: 4
	protected virtual void MinPass() { }

	// RVA: 0x8EBA60 Offset: 0x8EA460 VA: 0x1808EBA60
	protected void Exit(ExitAction exit) { }

	// RVA: 0x8EDA70 Offset: 0x8EC470 VA: 0x1808EDA70
	protected void UpdateTimeline() { }

	// RVA: 0x8ED5C0 Offset: 0x8EBFC0 VA: 0x1808ED5C0
	protected void UpdateCurrentTotal() { }

	// RVA: 0x8EB7D0 Offset: 0x8EA1D0 VA: 0x1808EB7D0
	private void CreateEntry(LaunderingOperation op) { }

	// RVA: 0x8ED1B0 Offset: 0x8EBBB0 VA: 0x1808ED1B0
	private void RemoveEntry(LaunderingOperation op) { }

	// RVA: 0x8ED620 Offset: 0x8EC020 VA: 0x1808ED620
	private void UpdateEntryTimes() { }

	// RVA: 0x8ED4C0 Offset: 0x8EBEC0 VA: 0x1808ED4C0
	private void UpdateCashStacks(LaunderingOperation op) { }

	// RVA: 0x8ECF60 Offset: 0x8EB960 VA: 0x1808ECF60
	private void RefreshLaunderButton() { }

	// RVA: 0x8ECA80 Offset: 0x8EB480 VA: 0x1808ECA80
	public void OpenAmountSelector() { }

	// RVA: 0x8EB230 Offset: 0x8E9C30 VA: 0x1808EB230
	public void CloseAmountSelector() { }

	// RVA: 0x8EB560 Offset: 0x8E9F60 VA: 0x1808EB560
	public void ConfirmAmount() { }

	// RVA: 0x8ED330 Offset: 0x8EBD30 VA: 0x1808ED330
	public void SliderValueChanged() { }

	// RVA: 0x8EC4F0 Offset: 0x8EAEF0 VA: 0x1808EC4F0
	public void InputValueChanged() { }

	// RVA: 0x8EBB30 Offset: 0x8EA530 VA: 0x1808EBB30
	public void Hovered() { }

	// RVA: 0x8EC5A0 Offset: 0x8EAFA0 VA: 0x1808EC5A0
	public void Interacted() { }

	// RVA: 0x8ECB70 Offset: 0x8EB570 VA: 0x1808ECB70 Slot: 5
	public virtual void Open() { }

	// RVA: 0x8EB260 Offset: 0x8E9C60 VA: 0x1808EB260 Slot: 6
	public virtual void Close() { }

	// RVA: 0x8EE1A0 Offset: 0x8ECBA0 VA: 0x1808EE1A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8ED3B0 Offset: 0x8EBDB0 VA: 0x1808ED3B0
	private void <Initialize>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0x8ED450 Offset: 0x8EBE50 VA: 0x1808ED450
	private bool <UpdateTimeline>b__36_0(KeyValuePair<LaunderingOperation, RectTransform> x) { }
}
