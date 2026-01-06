public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen> // TypeDefIndex: 2660
{
	// Fields
	public const float VEHICLE_POSSESSION_TIMEOUT = 30;
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public CanvasGroup CanvasGroup; // 0x38
	public RectTransform CrimeEntryContainer; // 0x40
	public RectTransform PenaltyEntryContainer; // 0x48
	[Header("Prefabs")]
	public RectTransform CrimeEntryPrefab; // 0x50
	public RectTransform PenaltyEntryPrefab; // 0x58
	private Dictionary<Crime, int> recordedCrimes; // 0x60
	private LandVehicle vehicle; // 0x68

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	// RVA: 0x8F2B30 Offset: 0x8F1530 VA: 0x1808F2B30 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F39E0 Offset: 0x8F23E0 VA: 0x1808F39E0
	private void PlayerSpawned() { }

	// RVA: 0x8F3370 Offset: 0x8F1D70 VA: 0x1808F3370
	private void Exit(ExitAction action) { }

	// RVA: 0x8F3460 Offset: 0x8F1E60 VA: 0x1808F3460
	public void Open() { }

	// RVA: 0x8F2E70 Offset: 0x8F1870 VA: 0x1808F2E70
	public void Close() { }

	// RVA: 0x8F3AB0 Offset: 0x8F24B0 VA: 0x1808F3AB0
	public void RecordCrimes() { }

	// RVA: 0x8F3F40 Offset: 0x8F2940 VA: 0x1808F3F40
	private void RecordPossession(EStealthLevel maxStealthLevel) { }

	// RVA: 0x8F2F20 Offset: 0x8F1920 VA: 0x1808F2F20
	private void ConfiscateItems(EStealthLevel maxStealthLevel) { }

	// RVA: 0x8F2D30 Offset: 0x8F1730 VA: 0x1808F2D30
	private void ClearEntries() { }

	// RVA: 0x8F4670 Offset: 0x8F3070 VA: 0x1808F4670
	public void .ctor() { }

	[IteratorStateMachine(typeof(ArrestNoticeScreen.<<Close>g__CloseRoutine|17_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F4600 Offset: 0x8F3000 VA: 0x1808F4600
	private IEnumerator <Close>g__CloseRoutine|17_0() { }
}
