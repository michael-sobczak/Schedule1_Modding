public class RecipeSelector : ClipboardScreen // TypeDefIndex: 2906
{
	// Fields
	[Header("References")]
	public RectTransform OptionContainer; // 0x48
	public TextMeshProUGUI TitleLabel; // 0x50
	public GameObject OptionPrefab; // 0x58
	[Header("Settings")]
	public Sprite EmptyOptionSprite; // 0x60
	private Coroutine lerpRoutine; // 0x68
	private List<StationRecipe> options; // 0x70
	private StationRecipe selectedOption; // 0x78
	private List<RectTransform> optionButtons; // 0x80
	private Action<StationRecipe> optionCallback; // 0x88

	// Methods

	// RVA: 0x96A420 Offset: 0x968E20 VA: 0x18096A420
	public void Initialize(string selectionTitle, List<StationRecipe> _options, StationRecipe _selectedOption, Action<StationRecipe> _optionCallback) { }

	// RVA: 0x96A620 Offset: 0x969020 VA: 0x18096A620 Slot: 5
	public override void Open() { }

	// RVA: 0x969DC0 Offset: 0x9687C0 VA: 0x180969DC0 Slot: 6
	public override void Close() { }

	// RVA: 0x969D70 Offset: 0x968770 VA: 0x180969D70
	private void ButtonClicked(StationRecipe option) { }

	// RVA: 0x969EA0 Offset: 0x9688A0 VA: 0x180969EA0
	private void CreateOptions(List<StationRecipe> options) { }

	// RVA: 0x96A300 Offset: 0x968D00 VA: 0x18096A300
	private void DeleteOptions() { }

	// RVA: 0x96A7A0 Offset: 0x9691A0 VA: 0x18096A7A0
	public void .ctor() { }
}
