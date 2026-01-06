public class TransitEntitySelector : MonoBehaviour // TypeDefIndex: 2910
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
	private List<ITransitEntity> selectedObjects; // 0x50
	private List<Type> typeRequirements; // 0x58
	private TransitEntitySelector.ObjectFilter objectFilter; // 0x60
	private Action<List<ITransitEntity>> callback; // 0x68
	private ITransitEntity hoveredObj; // 0x70
	private ITransitEntity highlightedObj; // 0x78
	private string selectionTitle; // 0x80
	private bool changesMade; // 0x88
	private List<Transform> transitSources; // 0x90
	private List<TransitLineVisuals> transitLines; // 0x98
	private bool selectDestination; // 0xA0

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x96F090 Offset: 0x96DA90 VA: 0x18096F090
	private void Start() { }

	// RVA: 0x96E8D0 Offset: 0x96D2D0 VA: 0x18096E8D0 Slot: 4
	public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Type> _typeRequirements, TransitEntitySelector.ObjectFilter _objectFilter, Action<List<ITransitEntity>> _callback, List<Transform> transitLineSources, bool selectingDestination = True) { }

	// RVA: 0x96F3D0 Offset: 0x96DDD0 VA: 0x18096F3D0
	private void UpdateTransitLines() { }

	// RVA: 0x96DED0 Offset: 0x96C8D0 VA: 0x18096DED0 Slot: 5
	public virtual void Close(bool returnToClipboard, bool pushChanges) { }

	// RVA: 0x96F7F0 Offset: 0x96E1F0 VA: 0x18096F7F0
	private void Update() { }

	// RVA: 0x96E6D0 Offset: 0x96D0D0 VA: 0x18096E6D0
	private void LateUpdate() { }

	// RVA: 0x96F1E0 Offset: 0x96DBE0 VA: 0x18096F1E0
	private void UpdateInstructions() { }

	// RVA: 0x96E420 Offset: 0x96CE20 VA: 0x18096E420
	private ITransitEntity GetHoveredObject() { }

	// RVA: 0x96E520 Offset: 0x96CF20 VA: 0x18096E520
	public bool IsObjectTypeValid(ITransitEntity obj, out string reason) { }

	// RVA: 0x96E6E0 Offset: 0x96D0E0 VA: 0x18096E6E0
	public void ObjectClicked(ITransitEntity obj) { }

	// RVA: 0x96EF90 Offset: 0x96D990 VA: 0x18096EF90
	private void SetSelectionOutline(ITransitEntity obj, bool on) { }

	// RVA: 0x967200 Offset: 0x965C00 VA: 0x180967200
	private void ClipboardClosed() { }

	// RVA: 0x9677B0 Offset: 0x9661B0 VA: 0x1809677B0
	private void Exit(ExitAction exitAction) { }

	// RVA: 0x96FCB0 Offset: 0x96E6B0 VA: 0x18096FCB0
	public void .ctor() { }
}
