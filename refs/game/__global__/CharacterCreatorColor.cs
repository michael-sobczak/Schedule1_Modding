public class CharacterCreatorColor : CharacterCreatorField<Color> // TypeDefIndex: 2977
{
	// Fields
	public static EClothingColor[] ClothingColorsToUse; // 0x0
	[Header("References")]
	public RectTransform OptionContainer; // 0x50
	[Header("Settings")]
	public bool UseClothingColors; // 0x58
	public List<Color> Colors; // 0x60
	public GameObject OptionPrefab; // 0x68
	private List<Button> optionButtons; // 0x70
	private Button selectedButton; // 0x78

	// Methods

	// RVA: 0x977220 Offset: 0x975C20 VA: 0x180977220 Slot: 4
	protected override void Awake() { }

	// RVA: 0x977030 Offset: 0x975A30 VA: 0x180977030 Slot: 6
	public override void ApplyValue() { }

	// RVA: 0x977680 Offset: 0x976080 VA: 0x180977680
	public void OptionClicked(Color color) { }

	// RVA: 0x977770 Offset: 0x976170 VA: 0x180977770
	public void .ctor() { }

	// RVA: 0x9776E0 Offset: 0x9760E0 VA: 0x1809776E0
	private static void .cctor() { }
}
