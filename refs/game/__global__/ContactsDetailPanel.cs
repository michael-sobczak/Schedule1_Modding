public class ContactsDetailPanel : MonoBehaviour // TypeDefIndex: 2859
{
	// Fields
	[CompilerGenerated]
	private NPC <SelectedNPC>k__BackingField; // 0x20
	[Header("Settings")]
	public Color DependenceColor_Min; // 0x28
	public Color DependenceColor_Max; // 0x38
	[Header("References")]
	public VerticalLayoutGroup LayoutGroup; // 0x48
	public Text NameLabel; // 0x50
	public Text TypeLabel; // 0x58
	public Text UnlockHintLabel; // 0x60
	public RectTransform RelationshipContainer; // 0x68
	public Scrollbar RelationshipScrollbar; // 0x70
	public Text RelationshipLabel; // 0x78
	public RectTransform AddictionContainer; // 0x80
	public Scrollbar AddictionScrollbar; // 0x88
	public Text AddictionLabel; // 0x90
	public RectTransform PropertiesContainer; // 0x98
	public Text PropertiesLabel; // 0xA0
	public Button ShowOnMapButton; // 0xA8
	public RectTransform StandardsContainer; // 0xB0
	public Image StandardsStar; // 0xB8
	public Text StandardsLabel; // 0xC0
	private POI poi; // 0xC8

	// Properties
	public NPC SelectedNPC { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public NPC get_SelectedNPC() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_SelectedNPC(NPC value) { }

	// RVA: 0x942F70 Offset: 0x941970 VA: 0x180942F70
	public void Open(NPC npc) { }

	// RVA: 0x9441E0 Offset: 0x942BE0 VA: 0x1809441E0
	public void ShowOnMap() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
