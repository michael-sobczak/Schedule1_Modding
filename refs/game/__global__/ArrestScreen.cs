public class ArrestScreen : Singleton<ArrestScreen> // TypeDefIndex: 2663
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas canvas; // 0x30
	public CanvasGroup group; // 0x38
	public AudioSourceController Sound; // 0x40
	public Animation Anim; // 0x48

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	// RVA: 0x8F4700 Offset: 0x8F3100 VA: 0x1808F4700 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F4890 Offset: 0x8F3290 VA: 0x1808F4890
	private void Continue() { }

	// RVA: 0x8F4910 Offset: 0x8F3310 VA: 0x1808F4910
	private void LoadSaveClicked() { }

	// RVA: 0x8F4920 Offset: 0x8F3320 VA: 0x1808F4920
	public void Open() { }

	// RVA: 0x8F4780 Offset: 0x8F3180 VA: 0x1808F4780
	public void Close() { }

	// RVA: 0x8F4B30 Offset: 0x8F3530 VA: 0x1808F4B30
	public void .ctor() { }

	[IteratorStateMachine(typeof(ArrestScreen.<<Continue>g__Routine|9_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F4A50 Offset: 0x8F3450 VA: 0x1808F4A50
	private IEnumerator <Continue>g__Routine|9_0() { }

	[IteratorStateMachine(typeof(ArrestScreen.<<Open>g__Routine|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F4AC0 Offset: 0x8F34C0 VA: 0x1808F4AC0
	private IEnumerator <Open>g__Routine|11_0() { }
}
