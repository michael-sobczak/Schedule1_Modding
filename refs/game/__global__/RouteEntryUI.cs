public class RouteEntryUI : MonoBehaviour // TypeDefIndex: 2889
{
	// Fields
	[CompilerGenerated]
	private AdvancedTransitRoute <AssignedRoute>k__BackingField; // 0x20
	[Header("References")]
	public TextMeshProUGUI SourceLabel; // 0x28
	public TextMeshProUGUI DestinationLabel; // 0x30
	public Image FilterIcon; // 0x38
	public UnityEvent onDeleteClicked; // 0x40
	private bool settingSource; // 0x48
	private bool settingDestination; // 0x49

	// Properties
	public AdvancedTransitRoute AssignedRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public AdvancedTransitRoute get_AssignedRoute() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_AssignedRoute(AdvancedTransitRoute value) { }

	// RVA: 0x953BB0 Offset: 0x9525B0 VA: 0x180953BB0
	public void AssignRoute(AdvancedTransitRoute route) { }

	// RVA: 0x5717F0 Offset: 0x5701F0 VA: 0x1805717F0
	public void ClearRoute() { }

	// RVA: 0x9541E0 Offset: 0x952BE0 VA: 0x1809541E0
	public void RefreshUI() { }

	// RVA: 0x954330 Offset: 0x952D30 VA: 0x180954330
	public void SourceClicked() { }

	// RVA: 0x953D30 Offset: 0x952730 VA: 0x180953D30
	public void DestinationClicked() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void FilterClicked() { }

	// RVA: 0x953D10 Offset: 0x952710 VA: 0x180953D10
	public void DeleteClicked() { }

	// RVA: 0x953FE0 Offset: 0x9529E0 VA: 0x180953FE0
	private bool ObjectValid(ITransitEntity obj, out string reason) { }

	// RVA: 0x9540D0 Offset: 0x952AD0 VA: 0x1809540D0
	public void ObjectsSelected(List<ITransitEntity> objs) { }

	// RVA: 0x9545E0 Offset: 0x952FE0 VA: 0x1809545E0
	public void .ctor() { }
}
