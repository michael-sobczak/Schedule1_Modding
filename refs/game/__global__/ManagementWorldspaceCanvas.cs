public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas> // TypeDefIndex: 2900
{
	// Fields
	public const float VISIBILITY_RANGE = 5;
	public const float PROPERTY_CANVAS_RANGE = 50;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public AnimationCurve ScaleCurve; // 0x38
	public TransitLineVisuals TransitRouteVisualsPrefab; // 0x40
	public InputPrompt CrosshairPrompt; // 0x48
	[Header("Settings")]
	public LayerMask ObjectSelectionLayerMask; // 0x50
	public Color HoveredOutlineColor; // 0x54
	public Color SelectedOutlineColor; // 0x64
	private List<IConfigurable> ShownConfigurables; // 0x78
	public IConfigurable HoveredConfigurable; // 0x80
	private IConfigurable OutlinedConfigurable; // 0x88
	public List<IConfigurable> SelectedConfigurables; // 0x90

	// Properties
	public bool IsOpen { get; set; }
	public Property CurrentProperty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	// RVA: 0x965BD0 Offset: 0x9645D0 VA: 0x180965BD0
	public Property get_CurrentProperty() { }

	// RVA: 0x9641B0 Offset: 0x962BB0 VA: 0x1809641B0
	public void Open() { }

	// RVA: 0x9634D0 Offset: 0x961ED0 VA: 0x1809634D0
	public void Close(bool preserveSelection = False) { }

	// RVA: 0x965830 Offset: 0x964230 VA: 0x180965830
	private void Update() { }

	// RVA: 0x964750 Offset: 0x963150 VA: 0x180964750
	private void UpdateInputPrompt() { }

	// RVA: 0x9651C0 Offset: 0x963BC0 VA: 0x1809651C0
	private void UpdateUIs() { }

	// RVA: 0x963CF0 Offset: 0x9626F0 VA: 0x180963CF0
	private void LateUpdate() { }

	// RVA: 0x9649F0 Offset: 0x9633F0 VA: 0x1809649F0
	private void UpdateSelection() { }

	// RVA: 0x9632E0 Offset: 0x961CE0 VA: 0x1809632E0
	private void AddToSelection(IConfigurable config) { }

	// RVA: 0x9643E0 Offset: 0x962DE0 VA: 0x1809643E0
	private void RemoveFromSelection(IConfigurable config) { }

	// RVA: 0x963420 Offset: 0x961E20 VA: 0x180963420
	private void ClearSelection() { }

	// RVA: 0x964540 Offset: 0x962F40 VA: 0x180964540
	private void RemoveNullConfigurables() { }

	// RVA: 0x963BC0 Offset: 0x9625C0 VA: 0x180963BC0
	private IConfigurable GetHoveredConfigurable() { }

	// RVA: 0x963610 Offset: 0x962010 VA: 0x180963610
	private List<IConfigurable> GetConfigurablesToShow() { }

	// RVA: 0x9646A0 Offset: 0x9630A0 VA: 0x1809646A0
	public void ShowCrosshairPrompt(string message) { }

	// RVA: 0x963CC0 Offset: 0x9626C0 VA: 0x180963CC0
	public void HideCrosshairPrompt() { }

	// RVA: 0x965B00 Offset: 0x964500 VA: 0x180965B00
	public void .ctor() { }
}
