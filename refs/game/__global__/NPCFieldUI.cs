public class NPCFieldUI : MonoBehaviour // TypeDefIndex: 2881
{
	// Fields
	[CompilerGenerated]
	private List<NPCField> <Fields>k__BackingField; // 0x20
	[Header("References")]
	public TextMeshProUGUI FieldLabel; // 0x28
	public Image IconImg; // 0x30
	public TextMeshProUGUI SelectionLabel; // 0x38
	public GameObject NoneSelected; // 0x40
	public GameObject MultipleSelected; // 0x48
	public RectTransform ClearButton; // 0x50

	// Properties
	public List<NPCField> Fields { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<NPCField> get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Fields(List<NPCField> value) { }

	// RVA: 0x94F5E0 Offset: 0x94DFE0 VA: 0x18094F5E0
	public void Bind(List<NPCField> field) { }

	// RVA: 0x94FB30 Offset: 0x94E530 VA: 0x18094FB30
	private void Refresh(NPC newVal) { }

	// RVA: 0x94F4D0 Offset: 0x94DED0 VA: 0x18094F4D0
	private bool AreFieldsUniform() { }

	// RVA: 0x94F770 Offset: 0x94E170 VA: 0x18094F770
	public void Clicked() { }

	// RVA: 0x94F900 Offset: 0x94E300 VA: 0x18094F900
	public void NPCSelected(NPC npc) { }

	// RVA: 0x94F760 Offset: 0x94E160 VA: 0x18094F760
	public void ClearClicked() { }

	// RVA: 0x94FE80 Offset: 0x94E880 VA: 0x18094FE80
	public void .ctor() { }
}
