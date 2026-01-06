public class LabOvenCanvas : Singleton<LabOvenCanvas> // TypeDefIndex: 2746
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private LabOven <Oven>k__BackingField; // 0x30
	[Header("References")]
	public Canvas Canvas; // 0x38
	public GameObject Container; // 0x40
	public ItemSlotUI IngredientSlotUI; // 0x48
	public ItemSlotUI OutputSlotUI; // 0x50
	public TextMeshProUGUI InstructionLabel; // 0x58
	public TextMeshProUGUI ErrorLabel; // 0x60
	public Button BeginButton; // 0x68
	public TextMeshProUGUI BeginButtonLabel; // 0x70
	public RectTransform ProgressContainer; // 0x78
	public Image IngredientIcon; // 0x80
	public Image ProgressImg; // 0x88
	public Image ProductIcon; // 0x90

	// Properties
	public bool isOpen { get; set; }
	public LabOven Oven { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public LabOven get_Oven() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_Oven(LabOven value) { }

	// RVA: 0x90EF50 Offset: 0x90D950 VA: 0x18090EF50 Slot: 5
	protected override void Awake() { }

	// RVA: 0x90FAC0 Offset: 0x90E4C0 VA: 0x18090FAC0 Slot: 4
	protected override void Start() { }

	// RVA: 0x90FBB0 Offset: 0x90E5B0 VA: 0x18090FBB0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x90F450 Offset: 0x90DE50 VA: 0x18090F450
	public void SetIsOpen(LabOven oven, bool open, bool removeUI = True) { }

	// RVA: 0x90F010 Offset: 0x90DA10 VA: 0x18090F010
	public void BeginButtonPressed() { }

	// RVA: 0x90F220 Offset: 0x90DC20 VA: 0x18090F220
	public bool CanBegin() { }

	// RVA: 0x90F2F0 Offset: 0x90DCF0 VA: 0x18090F2F0
	private bool DoesOvenOutputHaveSpace() { }

	// RVA: 0x90F3B0 Offset: 0x90DDB0 VA: 0x18090F3B0
	private void RefreshActiveOperation() { }

	// RVA: 0x910050 Offset: 0x90EA50 VA: 0x180910050
	public void .ctor() { }
}
