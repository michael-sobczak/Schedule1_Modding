public class AppsCanvas : PlayerSingleton<AppsCanvas> // TypeDefIndex: 2796
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x20
	[Header("References")]
	public Canvas canvas; // 0x28
	private Coroutine delayedSetOpenRoutine; // 0x30

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_isOpen(bool value) { }

	// RVA: 0x924400 Offset: 0x922E00 VA: 0x180924400 Slot: 4
	protected override void Awake() { }

	// RVA: 0x924500 Offset: 0x922F00 VA: 0x180924500 Slot: 6
	public override void OnStartClient(bool IsOwner) { }

	// RVA: 0x924800 Offset: 0x923200 VA: 0x180924800
	protected void PhoneOpened() { }

	// RVA: 0x924770 Offset: 0x923170 VA: 0x180924770
	protected void PhoneClosed() { }

	[IteratorStateMachine(typeof(AppsCanvas.<DelayedSetCanvasActive>d__10))]
	// RVA: 0x924470 Offset: 0x922E70 VA: 0x180924470
	private IEnumerator DelayedSetCanvasActive(bool active, float delay) { }

	// RVA: 0x9248A0 Offset: 0x9232A0 VA: 0x1809248A0
	public void SetIsOpen(bool o) { }

	// RVA: 0x924850 Offset: 0x923250 VA: 0x180924850
	private void SetCanvasActive(bool a) { }

	// RVA: 0x9248F0 Offset: 0x9232F0 VA: 0x1809248F0 Slot: 5
	protected override void Start() { }

	// RVA: 0x924990 Offset: 0x923390 VA: 0x180924990
	public void .ctor() { }
}
