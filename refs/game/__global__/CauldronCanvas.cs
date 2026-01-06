public class CauldronCanvas : Singleton<CauldronCanvas> // TypeDefIndex: 2737
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private Cauldron <Cauldron>k__BackingField; // 0x30
	[Header("References")]
	public Canvas Canvas; // 0x38
	public GameObject Container; // 0x40
	public List<ItemSlotUI> IngredientSlotUIs; // 0x48
	public ItemSlotUI LiquidSlotUI; // 0x50
	public ItemSlotUI OutputSlotUI; // 0x58
	public TextMeshProUGUI InstructionLabel; // 0x60
	public Button BeginButton; // 0x68

	// Properties
	public bool isOpen { get; set; }
	public Cauldron Cauldron { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Cauldron get_Cauldron() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_Cauldron(Cauldron value) { }

	// RVA: 0x90A860 Offset: 0x909260 VA: 0x18090A860 Slot: 5
	protected override void Awake() { }

	// RVA: 0x90B280 Offset: 0x909C80 VA: 0x18090B280 Slot: 4
	protected override void Start() { }

	// RVA: 0x90B370 Offset: 0x909D70 VA: 0x18090B370 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x90A9F0 Offset: 0x9093F0 VA: 0x18090A9F0
	public void SetIsOpen(Cauldron cauldron, bool open, bool removeUI = True) { }

	// RVA: 0x90A920 Offset: 0x909320 VA: 0x18090A920
	public void BeginButtonPressed() { }

	// RVA: 0x90B600 Offset: 0x90A000 VA: 0x18090B600
	public void .ctor() { }
}
