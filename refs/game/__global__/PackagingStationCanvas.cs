public class PackagingStationCanvas : Singleton<PackagingStationCanvas> // TypeDefIndex: 2749
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private PackagingStation <PackagingStation>k__BackingField; // 0x30
	public bool ShowHintOnOpen; // 0x38
	public bool ShowShiftClickHint; // 0x39
	public PackagingStation.EMode CurrentMode; // 0x3C
	public Color InstructionWarningColor; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x50
	public GameObject Container; // 0x58
	public ItemSlotUI PackagingSlotUI; // 0x60
	public ItemSlotUI ProductSlotUI; // 0x68
	public ItemSlotUI OutputSlotUI; // 0x70
	public TextMeshProUGUI InstructionLabel; // 0x78
	public Image InstructionShadow; // 0x80
	public Button BeginButton; // 0x88
	public Animation ModeAnimation; // 0x90
	public TextMeshProUGUI ButtonLabel; // 0x98

	// Properties
	public bool isOpen { get; set; }
	public PackagingStation PackagingStation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public PackagingStation get_PackagingStation() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_PackagingStation(PackagingStation value) { }

	// RVA: 0x930B40 Offset: 0x92F540 VA: 0x180930B40 Slot: 5
	protected override void Awake() { }

	// RVA: 0x931740 Offset: 0x930140 VA: 0x180931740 Slot: 4
	protected override void Start() { }

	// RVA: 0x931B60 Offset: 0x930560 VA: 0x180931B60 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x930D80 Offset: 0x92F780 VA: 0x180930D80
	public void SetIsOpen(PackagingStation station, bool open, bool removeUI = True) { }

	// RVA: 0x930C00 Offset: 0x92F600 VA: 0x180930C00
	public void BeginButtonPressed() { }

	// RVA: 0x931850 Offset: 0x930250 VA: 0x180931850
	private void UpdateSlotPositions() { }

	// RVA: 0x931830 Offset: 0x930230 VA: 0x180931830
	public void ToggleMode() { }

	// RVA: 0x931420 Offset: 0x92FE20 VA: 0x180931420
	public void SetMode(PackagingStation.EMode mode) { }

	// RVA: 0x9320A0 Offset: 0x930AA0 VA: 0x1809320A0
	public void .ctor() { }
}
