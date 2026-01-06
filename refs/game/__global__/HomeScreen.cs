public class HomeScreen : PlayerSingleton<HomeScreen> // TypeDefIndex: 2804
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x20
	[SerializeField]
	[Header("References")]
	protected Canvas canvas; // 0x28
	[SerializeField]
	protected Text timeText; // 0x30
	[SerializeField]
	protected RectTransform appIconContainer; // 0x38
	[Header("Prefabs")]
	[SerializeField]
	protected GameObject appIconPrefab; // 0x40
	protected List<Button> appIcons; // 0x48
	private Coroutine delayedSetOpenRoutine; // 0x50

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_isOpen(bool value) { }

	// RVA: 0x92D700 Offset: 0x92C100 VA: 0x18092D700 Slot: 5
	protected override void Start() { }

	// RVA: 0x92D250 Offset: 0x92BC50 VA: 0x18092D250 Slot: 6
	public override void OnStartClient(bool IsOwner) { }

	// RVA: 0x92D110 Offset: 0x92BB10 VA: 0x18092D110 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x92D610 Offset: 0x92C010 VA: 0x18092D610
	protected void PhoneOpened() { }

	// RVA: 0x92D580 Offset: 0x92BF80 VA: 0x18092D580
	protected void PhoneClosed() { }

	[IteratorStateMachine(typeof(HomeScreen.<DelayedSetCanvasActive>d__15))]
	// RVA: 0x92CD80 Offset: 0x92B780 VA: 0x18092CD80
	private IEnumerator DelayedSetCanvasActive(bool active, float delay) { }

	// RVA: 0x92D6B0 Offset: 0x92C0B0 VA: 0x18092D6B0
	public void SetIsOpen(bool o) { }

	// RVA: 0x92D660 Offset: 0x92C060 VA: 0x18092D660
	public void SetCanvasActive(bool a) { }

	// RVA: 0x92D770 Offset: 0x92C170 VA: 0x18092D770 Slot: 8
	protected virtual void Update() { }

	// RVA: 0x92CE10 Offset: 0x92B810 VA: 0x18092CE10 Slot: 9
	protected virtual void MinPass() { }

	// RVA: -1 Offset: -1
	public Button GenerateAppIcon<T>(App<T> prog) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC4660 Offset: 0xEC3060 VA: 0x180EC4660
	|-HomeScreen.GenerateAppIcon<object>
	*/

	// RVA: 0x92D930 Offset: 0x92C330 VA: 0x18092D930
	public void .ctor() { }
}
