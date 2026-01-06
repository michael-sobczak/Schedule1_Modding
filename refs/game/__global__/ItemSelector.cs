public class ItemSelector : ClipboardScreen // TypeDefIndex: 2897
{
	// Fields
	[Header("References")]
	public RectTransform OptionContainer; // 0x48
	public TextMeshProUGUI TitleLabel; // 0x50
	public TextMeshProUGUI HoveredItemLabel; // 0x58
	public GameObject OptionPrefab; // 0x60
	[Header("Settings")]
	public Sprite EmptyOptionSprite; // 0x68
	private Coroutine lerpRoutine; // 0x70
	private List<ItemSelector.Option> options; // 0x78
	private ItemSelector.Option selectedOption; // 0x80
	private List<RectTransform> optionButtons; // 0x88
	private Action<ItemSelector.Option> optionCallback; // 0x90

	// Methods

	// RVA: 0x961E90 Offset: 0x960890 VA: 0x180961E90
	public void Initialize(string selectionTitle, List<ItemSelector.Option> _options, ItemSelector.Option _selectedOption, Action<ItemSelector.Option> _optionCallback) { }

	// RVA: 0x9620A0 Offset: 0x960AA0 VA: 0x1809620A0 Slot: 5
	public override void Open() { }

	// RVA: 0x961590 Offset: 0x95FF90 VA: 0x180961590 Slot: 6
	public override void Close() { }

	// RVA: 0x9613D0 Offset: 0x95FDD0 VA: 0x1809613D0
	private void ButtonClicked(ItemSelector.Option option) { }

	// RVA: 0x961450 Offset: 0x95FE50 VA: 0x180961450
	private void ButtonHovered(ItemSelector.Option option) { }

	// RVA: 0x961420 Offset: 0x95FE20 VA: 0x180961420
	private void ButtonHoverEnd(ItemSelector.Option option) { }

	// RVA: 0x961650 Offset: 0x960050 VA: 0x180961650
	private void CreateOptions(List<ItemSelector.Option> options) { }

	// RVA: 0x961D70 Offset: 0x960770 VA: 0x180961D70
	private void DeleteOptions() { }

	// RVA: 0x962140 Offset: 0x960B40 VA: 0x180962140
	public void .ctor() { }
}
