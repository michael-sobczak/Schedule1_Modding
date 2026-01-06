public class RouteListFieldUI : MonoBehaviour // TypeDefIndex: 2891
{
	// Fields
	[CompilerGenerated]
	private List<RouteListField> <Fields>k__BackingField; // 0x20
	[Header("References")]
	public string FieldText; // 0x28
	public TextMeshProUGUI FieldLabel; // 0x30
	public RouteEntryUI[] RouteEntries; // 0x38
	public RectTransform MultiEditBlocker; // 0x40
	public Button AddButton; // 0x48

	// Properties
	public List<RouteListField> Fields { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<RouteListField> get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Fields(List<RouteListField> value) { }

	// RVA: 0x954ED0 Offset: 0x9538D0 VA: 0x180954ED0
	private void Start() { }

	// RVA: 0x9546F0 Offset: 0x9530F0 VA: 0x1809546F0
	public void Bind(List<RouteListField> field) { }

	// RVA: 0x954920 Offset: 0x953320 VA: 0x180954920
	private void Refresh(List<AdvancedTransitRoute> newVal) { }

	// RVA: 0x9548A0 Offset: 0x9532A0 VA: 0x1809548A0
	private void EntryDeleteClicked(RouteEntryUI entry) { }

	// RVA: 0x954650 Offset: 0x953050 VA: 0x180954650
	private void AddClicked() { }

	// RVA: 0x954E70 Offset: 0x953870 VA: 0x180954E70
	private void RouteChanged(ITransitEntity newEntity) { }

	// RVA: 0x9550C0 Offset: 0x953AC0 VA: 0x1809550C0
	public void .ctor() { }
}
