public class PassOutScreen : Singleton<PassOutScreen> // TypeDefIndex: 2676
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	public const float CASH_LOSS_MIN = 50;
	public const float CASH_LOSS_MAX = 500;
	[Header("References")]
	public Canvas Canvas; // 0x30
	public CanvasGroup Group; // 0x38
	public Transform RecoveryPointsContainer; // 0x40
	public TextMeshProUGUI MainLabel; // 0x48
	public TextMeshProUGUI ContextLabel; // 0x50
	public Animation Anim; // 0x58
	private float cashLoss; // 0x60

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	// RVA: 0x8F9FF0 Offset: 0x8F89F0 VA: 0x1808F9FF0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8FA270 Offset: 0x8F8C70 VA: 0x1808FA270
	private void Continue() { }

	// RVA: 0x8FA2F0 Offset: 0x8F8CF0 VA: 0x1808FA2F0
	private void LoadSaveClicked() { }

	// RVA: 0x8FA300 Offset: 0x8F8D00 VA: 0x1808FA300
	public void Open() { }

	// RVA: 0x8FA070 Offset: 0x8F8A70 VA: 0x1808FA070
	public void Close() { }

	// RVA: 0x8FA5E0 Offset: 0x8F8FE0 VA: 0x1808FA5E0
	public void .ctor() { }

	[IteratorStateMachine(typeof(PassOutScreen.<<Continue>g__Routine|14_0>d))]
	[CompilerGenerated]
	// RVA: 0x8FA500 Offset: 0x8F8F00 VA: 0x1808FA500
	private IEnumerator <Continue>g__Routine|14_0() { }

	[IteratorStateMachine(typeof(PassOutScreen.<<Open>g__Routine|16_0>d))]
	[CompilerGenerated]
	// RVA: 0x8FA570 Offset: 0x8F8F70 VA: 0x1808FA570
	private IEnumerator <Open>g__Routine|16_0() { }
}
