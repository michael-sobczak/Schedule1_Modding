public class BrickPressCanvas : Singleton<BrickPressCanvas> // TypeDefIndex: 2736
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private BrickPress <Press>k__BackingField; // 0x30
	[Header("References")]
	public Canvas Canvas; // 0x38
	public RectTransform Container; // 0x40
	public ItemSlotUI[] ProductSlotUIs; // 0x48
	public ItemSlotUI OutputSlotUI; // 0x50
	public TextMeshProUGUI InstructionLabel; // 0x58
	public Button BeginButton; // 0x60

	// Properties
	public bool isOpen { get; set; }
	public BrickPress Press { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public BrickPress get_Press() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_Press(BrickPress value) { }

	// RVA: 0x9099F0 Offset: 0x9083F0 VA: 0x1809099F0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x90A2C0 Offset: 0x908CC0 VA: 0x18090A2C0 Slot: 4
	protected override void Start() { }

	// RVA: 0x90A3B0 Offset: 0x908DB0 VA: 0x18090A3B0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x909BB0 Offset: 0x9085B0 VA: 0x180909BB0
	public void SetIsOpen(BrickPress press, bool open, bool removeUI = True) { }

	// RVA: 0x909AB0 Offset: 0x9084B0 VA: 0x180909AB0
	public void BeginButtonPressed() { }

	// RVA: 0x90A5F0 Offset: 0x908FF0 VA: 0x18090A5F0
	public void .ctor() { }
}
