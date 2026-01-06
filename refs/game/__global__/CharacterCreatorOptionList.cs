public class CharacterCreatorOptionList : CharacterCreatorField<string> // TypeDefIndex: 2984
{
	// Fields
	[Header("References")]
	public RectTransform OptionContainer; // 0x48
	[Header("Settings")]
	public bool CanSelectNone; // 0x50
	public List<CharacterCreatorOptionList.Option> Options; // 0x58
	public GameObject OptionPrefab; // 0x60
	private List<Button> optionButtons; // 0x68
	private Button selectedButton; // 0x70

	// Methods

	// RVA: 0x977BE0 Offset: 0x9765E0 VA: 0x180977BE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x9779E0 Offset: 0x9763E0 VA: 0x1809779E0 Slot: 6
	public override void ApplyValue() { }

	// RVA: 0x977FB0 Offset: 0x9769B0 VA: 0x180977FB0
	public void OptionClicked(string option) { }

	// RVA: 0x9780F0 Offset: 0x976AF0 VA: 0x1809780F0
	public void .ctor() { }
}
