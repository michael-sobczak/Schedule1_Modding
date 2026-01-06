public class ObjectFieldUI : MonoBehaviour // TypeDefIndex: 2884
{
	// Fields
	[CompilerGenerated]
	private List<ObjectField> <Fields>k__BackingField; // 0x20
	[Header("References")]
	public string InstructionText; // 0x28
	public string ExtendedInstructionText; // 0x30
	public TextMeshProUGUI FieldLabel; // 0x38
	public Image IconImg; // 0x40
	public TextMeshProUGUI SelectionLabel; // 0x48
	public GameObject NoneSelected; // 0x50
	public GameObject MultipleSelected; // 0x58
	public RectTransform ClearButton; // 0x60

	// Properties
	public List<ObjectField> Fields { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<ObjectField> get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Fields(List<ObjectField> value) { }

	// RVA: 0x950870 Offset: 0x94F270 VA: 0x180950870
	public void Bind(List<ObjectField> field) { }

	// RVA: 0x9512A0 Offset: 0x94FCA0 VA: 0x1809512A0
	private void Refresh(BuildableItem newVal) { }

	// RVA: 0x950760 Offset: 0x94F160 VA: 0x180950760
	private bool AreFieldsUniform() { }

	// RVA: 0x950A00 Offset: 0x94F400 VA: 0x180950A00
	public void Clicked() { }

	// RVA: 0x9510D0 Offset: 0x94FAD0 VA: 0x1809510D0
	private bool ObjectValid(BuildableItem obj, out string reason) { }

	// RVA: 0x951220 Offset: 0x94FC20 VA: 0x180951220
	public void ObjectsSelected(List<BuildableItem> objs) { }

	// RVA: 0x950E70 Offset: 0x94F870 VA: 0x180950E70
	private void ObjectSelected(BuildableItem obj) { }

	// RVA: 0x9509F0 Offset: 0x94F3F0 VA: 0x1809509F0
	public void ClearClicked() { }

	// RVA: 0x951600 Offset: 0x950000 VA: 0x180951600
	public void .ctor() { }
}
