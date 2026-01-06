public class DealCompletionPopup : Singleton<DealCompletionPopup> // TypeDefIndex: 2587
{
	// Fields
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public RectTransform Container; // 0x38
	public CanvasGroup Group; // 0x40
	public Animation Anim; // 0x48
	public TextMeshProUGUI Title; // 0x50
	public TextMeshProUGUI PaymentLabel; // 0x58
	public TextMeshProUGUI SatisfactionValueLabel; // 0x60
	public RelationCircle RelationCircle; // 0x68
	public TextMeshProUGUI RelationshipLabel; // 0x70
	public Gradient SatisfactionGradient; // 0x78
	public AudioSourceController SoundEffect; // 0x80
	public TextMeshProUGUI[] BonusLabels; // 0x88
	private Coroutine routine; // 0x90

	// Properties
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsPlaying(bool value) { }

	// RVA: 0x8DFE70 Offset: 0x8DE870 VA: 0x1808DFE70 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8DFEF0 Offset: 0x8DE8F0 VA: 0x1808DFEF0
	public void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses) { }

	// RVA: 0x8E0050 Offset: 0x8DEA50 VA: 0x1808E0050
	private void SetRelationshipLabel(float delta) { }

	// RVA: 0x8E01C0 Offset: 0x8DEBC0 VA: 0x1808E01C0
	public void .ctor() { }
}
