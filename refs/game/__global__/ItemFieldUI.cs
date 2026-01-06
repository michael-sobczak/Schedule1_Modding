public class ItemFieldUI : MonoBehaviour // TypeDefIndex: 2879
{
	// Fields
	[CompilerGenerated]
	private List<ItemField> <Fields>k__BackingField; // 0x20
	public bool ShowNoneAsAny; // 0x28
	[Header("References")]
	public TextMeshProUGUI FieldLabel; // 0x30
	public Image IconImg; // 0x38
	public TextMeshProUGUI SelectionLabel; // 0x40
	public GameObject NoneSelected; // 0x48
	public GameObject MultipleSelected; // 0x50

	// Properties
	public List<ItemField> Fields { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<ItemField> get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Fields(List<ItemField> value) { }

	// RVA: 0x949D70 Offset: 0x948770 VA: 0x180949D70
	public void Bind(List<ItemField> field) { }

	// RVA: 0x94A580 Offset: 0x948F80 VA: 0x18094A580
	private void Refresh(ItemDefinition newVal) { }

	// RVA: 0x949C60 Offset: 0x948660 VA: 0x180949C60
	private bool AreFieldsUniform() { }

	// RVA: 0x949EF0 Offset: 0x9488F0 VA: 0x180949EF0
	public void Clicked() { }

	// RVA: 0x94A450 Offset: 0x948E50 VA: 0x18094A450
	private void OptionSelected(ItemSelector.Option option) { }

	// RVA: 0x94A790 Offset: 0x949190 VA: 0x18094A790
	public void .ctor() { }
}
