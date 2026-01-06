public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas> // TypeDefIndex: 2739
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private ChemistryStation <ChemistryStation>k__BackingField; // 0x30
	public List<StationRecipe> Recipes; // 0x38
	[Header("Prefabs")]
	public StationRecipeEntry RecipeEntryPrefab; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x48
	public RectTransform Container; // 0x50
	public RectTransform InputSlotsContainer; // 0x58
	public ItemSlotUI[] InputSlotUIs; // 0x60
	public ItemSlotUI OutputSlotUI; // 0x68
	public RectTransform RecipeSelectionContainer; // 0x70
	public TextMeshProUGUI InstructionLabel; // 0x78
	public Button BeginButton; // 0x80
	public RectTransform SelectionIndicator; // 0x88
	public RectTransform RecipeContainer; // 0x90
	public RectTransform CookingInProgressContainer; // 0x98
	public StationRecipeEntry InProgressRecipeEntry; // 0xA0
	public TextMeshProUGUI InProgressLabel; // 0xA8
	public TextMeshProUGUI ErrorLabel; // 0xB0
	private List<StationRecipeEntry> recipeEntries; // 0xB8
	private StationRecipeEntry selectedRecipe; // 0xC0

	// Properties
	public bool isOpen { get; set; }
	public ChemistryStation ChemistryStation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ChemistryStation get_ChemistryStation() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_ChemistryStation(ChemistryStation value) { }

	// RVA: 0x90B640 Offset: 0x90A040 VA: 0x18090B640 Slot: 5
	protected override void Awake() { }

	// RVA: 0x90CA50 Offset: 0x90B450 VA: 0x18090CA50 Slot: 4
	protected override void Start() { }

	// RVA: 0x90D260 Offset: 0x90BC60 VA: 0x18090D260 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x90BD20 Offset: 0x90A720 VA: 0x18090BD20
	private void LateUpdate() { }

	// RVA: 0x90CF50 Offset: 0x90B950 VA: 0x18090CF50
	private void UpdateUI() { }

	// RVA: 0x90CCD0 Offset: 0x90B6D0 VA: 0x18090CCD0
	private void UpdateInput() { }

	// RVA: 0x90BDF0 Offset: 0x90A7F0 VA: 0x18090BDF0
	public void Open(ChemistryStation station) { }

	// RVA: 0x90B950 Offset: 0x90A350 VA: 0x18090B950
	public void Close(bool removeUI) { }

	// RVA: 0x90B870 Offset: 0x90A270 VA: 0x18090B870
	public void BeginButtonPressed() { }

	// RVA: 0x90CB30 Offset: 0x90B530 VA: 0x18090CB30
	private void StationSlotsChanged() { }

	// RVA: 0x90C6E0 Offset: 0x90B0E0 VA: 0x18090C6E0
	private void SortRecipes(List<ItemInstance> ingredients) { }

	// RVA: 0x90C5C0 Offset: 0x90AFC0 VA: 0x18090C5C0
	private void SetSelectedRecipe(StationRecipeEntry entry) { }

	// RVA: 0x90D500 Offset: 0x90BF00 VA: 0x18090D500
	public void .ctor() { }
}
