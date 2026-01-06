public class MixingStationCanvas : Singleton<MixingStationCanvas> // TypeDefIndex: 2747
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private MixingStation <MixingStation>k__BackingField; // 0x30
	[Header("Prefabs")]
	public StationRecipeEntry RecipeEntryPrefab; // 0x38
	[Header("References")]
	public Canvas Canvas; // 0x40
	public RectTransform Container; // 0x48
	public ItemSlotUI ProductSlotUI; // 0x50
	public TextMeshProUGUI ProductPropertiesLabel; // 0x58
	public ItemSlotUI IngredientSlotUI; // 0x60
	public TextMeshProUGUI IngredientProblemLabel; // 0x68
	public ItemSlotUI PreviewSlotUI; // 0x70
	public Image PreviewIcon; // 0x78
	public TextMeshProUGUI PreviewLabel; // 0x80
	public RectTransform UnknownOutputIcon; // 0x88
	public TextMeshProUGUI PreviewPropertiesLabel; // 0x90
	public ItemSlotUI OutputSlotUI; // 0x98
	public TextMeshProUGUI InstructionLabel; // 0xA0
	public RectTransform TitleContainer; // 0xA8
	public RectTransform MainContainer; // 0xB0
	public Button BeginButton; // 0xB8
	public RectTransform ProductHint; // 0xC0
	public RectTransform MixerHint; // 0xC8
	private StationRecipe selectedRecipe; // 0xD0

	// Properties
	public bool isOpen { get; set; }
	public MixingStation MixingStation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public MixingStation get_MixingStation() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_MixingStation(MixingStation value) { }

	// RVA: 0x9105C0 Offset: 0x90EFC0 VA: 0x1809105C0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x912AE0 Offset: 0x9114E0 VA: 0x180912AE0 Slot: 4
	protected override void Start() { }

	// RVA: 0x910F40 Offset: 0x90F940 VA: 0x180910F40
	private void Exit(ExitAction action) { }

	// RVA: 0x913A60 Offset: 0x912460 VA: 0x180913A60 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpdateUI() { }

	// RVA: 0x913000 Offset: 0x911A00 VA: 0x180913000
	private void UpdateInput() { }

	// RVA: 0x911B20 Offset: 0x910520 VA: 0x180911B20
	public void Open(MixingStation station) { }

	// RVA: 0x910A30 Offset: 0x90F430 VA: 0x180910A30
	public void Close(bool enablePlayerControl = True) { }

	// RVA: 0x911650 Offset: 0x910050 VA: 0x180911650
	private void MixingDone() { }

	// RVA: 0x912C60 Offset: 0x911660 VA: 0x180912C60
	private void StationContentsChanged() { }

	// RVA: 0x912E00 Offset: 0x911800 VA: 0x180912E00
	private void UpdateDisplayMode() { }

	// RVA: 0x913020 Offset: 0x911A20 VA: 0x180913020
	private void UpdateInstruction() { }

	// RVA: 0x913170 Offset: 0x911B70 VA: 0x180913170
	private void UpdatePreview() { }

	// RVA: 0x911080 Offset: 0x90FA80 VA: 0x180911080
	private string GetPropertyListString(List<Effect> properties) { }

	// RVA: 0x911170 Offset: 0x90FB70 VA: 0x180911170
	private string GetPropertyString(Effect property) { }

	// RVA: 0x910FF0 Offset: 0x90F9F0 VA: 0x180910FF0
	private List<Effect> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer) { }

	// RVA: 0x9112A0 Offset: 0x90FCA0 VA: 0x1809112A0
	private bool IsOutputKnown(out ProductDefinition knownProduct) { }

	// RVA: 0x912D30 Offset: 0x911730 VA: 0x180912D30
	private void UpdateBeginButton() { }

	// RVA: 0x910680 Offset: 0x90F080 VA: 0x180910680
	public void BeginButtonPressed() { }

	// RVA: 0x912990 Offset: 0x911390 VA: 0x180912990
	public void StartMixOperation(MixOperation mixOperation) { }

	// RVA: 0x911490 Offset: 0x90FE90 VA: 0x180911490
	private void MixNamed(string mixName) { }

	// RVA: 0x913B00 Offset: 0x912500 VA: 0x180913B00
	public void .ctor() { }
}
