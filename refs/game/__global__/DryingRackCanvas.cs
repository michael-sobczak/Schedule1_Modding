public class DryingRackCanvas : Singleton<DryingRackCanvas> // TypeDefIndex: 2745
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private DryingRack <Rack>k__BackingField; // 0x30
	[Header("References")]
	public Canvas Canvas; // 0x38
	public RectTransform Container; // 0x40
	public ItemSlotUI InputSlotUI; // 0x48
	public ItemSlotUI OutputSlotUI; // 0x50
	public TextMeshProUGUI InstructionLabel; // 0x58
	public TextMeshProUGUI CapacityLabel; // 0x60
	public Button InsertButton; // 0x68
	public RectTransform IndicatorContainer; // 0x70
	public RectTransform[] IndicatorAlignments; // 0x78
	[Header("Prefabs")]
	public DryingOperationUI IndicatorPrefab; // 0x80
	private List<DryingOperationUI> operationUIs; // 0x88

	// Properties
	public bool isOpen { get; set; }
	public DryingRack Rack { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public DryingRack get_Rack() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_Rack(DryingRack value) { }

	// RVA: 0x90E790 Offset: 0x90D190 VA: 0x18090E790 Slot: 4
	protected override void Start() { }

	// RVA: 0x90D9D0 Offset: 0x90C3D0 VA: 0x18090D9D0
	private void MinPass() { }

	// RVA: 0x90EEB0 Offset: 0x90D8B0 VA: 0x18090EEB0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x90ECE0 Offset: 0x90D6E0 VA: 0x18090ECE0
	private void UpdateUI() { }

	// RVA: 0x90E940 Offset: 0x90D340 VA: 0x18090E940
	private void UpdateDryingOperations() { }

	// RVA: 0x90EBE0 Offset: 0x90D5E0 VA: 0x18090EBE0
	private void UpdateQuantities() { }

	// RVA: 0x90D9E0 Offset: 0x90C3E0 VA: 0x18090D9E0
	public void SetIsOpen(DryingRack rack, bool open) { }

	// RVA: 0x90D700 Offset: 0x90C100 VA: 0x18090D700
	private void CreateOperationUI(DryingOperation operation) { }

	// RVA: 0x90D830 Offset: 0x90C230 VA: 0x18090D830
	private void DestroyOperationUI(DryingOperation operation) { }

	// RVA: 0x90D9B0 Offset: 0x90C3B0 VA: 0x18090D9B0
	public void Insert() { }

	// RVA: 0x90EEC0 Offset: 0x90D8C0 VA: 0x18090EEC0
	public void .ctor() { }
}
