public class MushroomSpawnStationInterface : Singleton<MushroomSpawnStationInterface> // TypeDefIndex: 2748
{
	// Fields
	private const float CameraLerpTime = 0.2;
	[Header("References")]
	[SerializeField]
	private Canvas _canvas; // 0x28
	[SerializeField]
	private RectTransform _container; // 0x30
	[SerializeField]
	private ItemSlotUI _grainBagSlotUI; // 0x38
	[SerializeField]
	private ItemSlotUI _syringeSlotUI; // 0x40
	[SerializeField]
	private ItemSlotUI _outputSlotUI; // 0x48
	[SerializeField]
	private Button _beginButton; // 0x50
	[SerializeField]
	private TextMeshProUGUI _instructionLabel; // 0x58
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x60
	[CompilerGenerated]
	private MushroomSpawnStation <Station>k__BackingField; // 0x68
	public Action OnExitStation; // 0x70

	// Properties
	public bool IsOpen { get; set; }
	public MushroomSpawnStation Station { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public MushroomSpawnStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_Station(MushroomSpawnStation value) { }

	// RVA: 0x92F860 Offset: 0x92E260 VA: 0x18092F860 Slot: 5
	protected override void Awake() { }

	// RVA: 0x930880 Offset: 0x92F280 VA: 0x180930880 Slot: 4
	protected override void Start() { }

	// RVA: 0x9301C0 Offset: 0x92EBC0 VA: 0x1809301C0
	private void Exit(ExitAction action) { }

	// RVA: 0x930A80 Offset: 0x92F480 VA: 0x180930A80
	private void Update() { }

	// RVA: 0x930210 Offset: 0x92EC10 VA: 0x180930210
	public void Open(MushroomSpawnStation station) { }

	// RVA: 0x92FDA0 Offset: 0x92E7A0 VA: 0x18092FDA0
	public void Close(bool exitStation) { }

	// RVA: 0x930950 Offset: 0x92F350 VA: 0x180930950
	private void StationContentsChanged() { }

	// RVA: 0x930A00 Offset: 0x92F400 VA: 0x180930A00
	private void UpdateInstruction() { }

	// RVA: 0x92FCC0 Offset: 0x92E6C0 VA: 0x18092FCC0
	private bool CanBeginTask(out string instruction) { }

	// RVA: 0x9309C0 Offset: 0x92F3C0 VA: 0x1809309C0
	private void UpdateBeginButton() { }

	// RVA: 0x92F9C0 Offset: 0x92E3C0 VA: 0x18092F9C0
	private void BeginTask() { }

	// RVA: 0x930B00 Offset: 0x92F500 VA: 0x180930B00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x9309B0 Offset: 0x92F3B0 VA: 0x1809309B0
	private void <BeginTask>g__TaskStopped|27_0() { }
}
