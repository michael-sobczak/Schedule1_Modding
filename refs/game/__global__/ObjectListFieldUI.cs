public class ObjectListFieldUI : MonoBehaviour // TypeDefIndex: 2886
{
	// Fields
	[CompilerGenerated]
	private List<ObjectListField> <Fields>k__BackingField; // 0x20
	[Header("References")]
	public string FieldText; // 0x28
	public string InstructionText; // 0x30
	public string ExtendedInstructionText; // 0x38
	public TextMeshProUGUI FieldLabel; // 0x40
	public GameObject NoneSelected; // 0x48
	public GameObject MultipleSelected; // 0x50
	public RectTransform[] Entries; // 0x58
	public Button Button; // 0x60
	public GameObject EditIcon; // 0x68
	public GameObject NoMultiEdit; // 0x70

	// Properties
	public List<ObjectListField> Fields { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<ObjectListField> get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Fields(List<ObjectListField> value) { }

	// RVA: 0x9517C0 Offset: 0x9501C0 VA: 0x1809517C0
	public void Bind(List<ObjectListField> field) { }

	// RVA: 0x952330 Offset: 0x950D30 VA: 0x180952330
	private void Refresh(List<BuildableItem> newVal) { }

	// RVA: 0x9528E0 Offset: 0x9512E0 VA: 0x1809528E0
	private void RemoveEntryClicked(int index) { }

	// RVA: 0x9516D0 Offset: 0x9500D0 VA: 0x1809516D0
	private bool AreFieldsUniform() { }

	// RVA: 0x951D30 Offset: 0x950730 VA: 0x180951D30
	public void Clicked() { }

	// RVA: 0x952040 Offset: 0x950A40 VA: 0x180952040
	private bool ObjectValid(BuildableItem obj, out string reason) { }

	// RVA: 0x952190 Offset: 0x950B90 VA: 0x180952190
	public void ObjectsSelected(List<BuildableItem> objs) { }

	// RVA: 0x951BE0 Offset: 0x9505E0 VA: 0x180951BE0
	public void Clear() { }

	// RVA: 0x9529E0 Offset: 0x9513E0 VA: 0x1809529E0
	public void .ctor() { }
}
