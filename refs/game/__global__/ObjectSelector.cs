public class ObjectSelector : MonoBehaviour // TypeDefIndex: 2903
{
	// Fields
	public const float SELECTION_RANGE = 5;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public LayerMask DetectionMask; // 0x24
	public Color HoverOutlineColor; // 0x28
	public Color SelectOutlineColor; // 0x38
	private int maxSelectedObjects; // 0x48
	private List<BuildableItem> selectedObjects; // 0x50
	private List<Type> typeRequirements; // 0x58
	private ObjectSelector.ObjectFilter objectFilter; // 0x60
	private Action<List<BuildableItem>> callback; // 0x68
	private BuildableItem hoveredObj; // 0x70
	private BuildableItem highlightedObj; // 0x78
	private string selectionTitle; // 0x80
	private bool changesMade; // 0x88
	private List<Transform> transitSources; // 0x90
	private List<TransitLineVisuals> transitLines; // 0x98
	private Property targetProperty; // 0xA0

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x9684D0 Offset: 0x966ED0 VA: 0x1809684D0
	private void Start() { }

	// RVA: 0x967E20 Offset: 0x966820 VA: 0x180967E20 Slot: 4
	public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<BuildableItem> _selectedObjects, List<Type> _typeRequirements, Property property, ObjectSelector.ObjectFilter _objectFilter, Action<List<BuildableItem>> _callback, List<Transform> transitLineSources) { }

	// RVA: 0x968810 Offset: 0x967210 VA: 0x180968810
	private void UpdateTransitLines() { }

	// RVA: 0x967220 Offset: 0x965C20 VA: 0x180967220 Slot: 5
	public virtual void Close(bool returnToClipboard, bool pushChanges) { }

	// RVA: 0x968B80 Offset: 0x967580 VA: 0x180968B80
	private void Update() { }

	// RVA: 0x967B70 Offset: 0x966570 VA: 0x180967B70
	private void LateUpdate() { }

	// RVA: 0x968620 Offset: 0x967020 VA: 0x180968620
	private void UpdateInstructions() { }

	// RVA: 0x967820 Offset: 0x966220 VA: 0x180967820
	private BuildableItem GetHoveredObject() { }

	// RVA: 0x967920 Offset: 0x966320 VA: 0x180967920
	public bool IsObjectTypeValid(BuildableItem obj, out string reason) { }

	// RVA: 0x967B80 Offset: 0x966580 VA: 0x180967B80
	public void ObjectClicked(BuildableItem obj) { }

	// RVA: 0x968460 Offset: 0x966E60 VA: 0x180968460
	private void SetSelectionOutline(BuildableItem obj, bool on) { }

	// RVA: 0x967200 Offset: 0x965C00 VA: 0x180967200
	private void ClipboardClosed() { }

	// RVA: 0x9677B0 Offset: 0x9661B0 VA: 0x1809677B0
	private void Exit(ExitAction exitAction) { }

	// RVA: 0x969120 Offset: 0x967B20 VA: 0x180969120
	public void .ctor() { }
}
