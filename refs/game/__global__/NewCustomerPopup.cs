public class NewCustomerPopup : Singleton<NewCustomerPopup> // TypeDefIndex: 2642
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
	public RectTransform[] Entries; // 0x58
	public AudioSourceController SoundEffect; // 0x60
	private Coroutine routine; // 0x68

	// Properties
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsPlaying(bool value) { }

	// RVA: 0x8F7BB0 Offset: 0x8F65B0 VA: 0x1808F7BB0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F7CC0 Offset: 0x8F66C0 VA: 0x1808F7CC0
	public void PlayPopup(Customer customer) { }

	// RVA: 0x8F7C30 Offset: 0x8F6630 VA: 0x1808F7C30
	private void DisableEntries() { }

	// RVA: 0x8F80E0 Offset: 0x8F6AE0 VA: 0x1808F80E0
	public void .ctor() { }

	[IteratorStateMachine(typeof(NewCustomerPopup.<<PlayPopup>g__Routine|13_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F8070 Offset: 0x8F6A70 VA: 0x1808F8070
	private IEnumerator <PlayPopup>g__Routine|13_0() { }

	[CompilerGenerated]
	// RVA: 0x8F8030 Offset: 0x8F6A30 VA: 0x1808F8030
	private bool <PlayPopup>b__13_2() { }
}
