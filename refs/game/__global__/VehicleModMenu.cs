public class VehicleModMenu : Singleton<VehicleModMenu> // TypeDefIndex: 2724
{
	// Fields
	public static float repaintCost; // 0x0
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("UI References")]
	[SerializeField]
	protected Canvas canvas; // 0x30
	[SerializeField]
	protected RectTransform buttonContainer; // 0x38
	[SerializeField]
	protected RectTransform tempIndicator; // 0x40
	[SerializeField]
	protected RectTransform permIndicator; // 0x48
	[SerializeField]
	protected Button confirmButton_Online; // 0x50
	[SerializeField]
	protected TextMeshProUGUI confirmText_Online; // 0x58
	[Header("References")]
	public Transform CameraPosition; // 0x60
	public Transform VehiclePosition; // 0x68
	[Header("Prefabs")]
	[SerializeField]
	protected GameObject buttonPrefab; // 0x70
	public UnityEvent onPaintPurchased; // 0x78
	protected LandVehicle currentVehicle; // 0x80
	protected List<RectTransform> colorButtons; // 0x88
	protected Dictionary<EVehicleColor, RectTransform> colorToButton; // 0x90
	protected EVehicleColor selectedColor; // 0x98
	private Coroutine openCloseRoutine; // 0xA0

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	// RVA: 0x91FDB0 Offset: 0x91E7B0 VA: 0x18091FDB0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x920450 Offset: 0x91EE50 VA: 0x180920450 Slot: 4
	protected override void Start() { }

	// RVA: 0x920140 Offset: 0x91EB40 VA: 0x180920140
	private void Exit(ExitAction action) { }

	// RVA: 0x920C10 Offset: 0x91F610 VA: 0x180920C10 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x9201A0 Offset: 0x91EBA0 VA: 0x1809201A0
	public void Open(LandVehicle vehicle) { }

	// RVA: 0x91FE60 Offset: 0x91E860 VA: 0x18091FE60
	public void Close() { }

	// RVA: 0x91FF50 Offset: 0x91E950 VA: 0x18091FF50
	public void ColorClicked(EVehicleColor col) { }

	// RVA: 0x920B10 Offset: 0x91F510 VA: 0x180920B10
	private void UpdateConfirmButton() { }

	// RVA: 0x920340 Offset: 0x91ED40 VA: 0x180920340
	private void RefreshSelectionIndicator() { }

	// RVA: 0x91FFA0 Offset: 0x91E9A0 VA: 0x18091FFA0
	public void ConfirmButtonClicked() { }

	// RVA: 0x920C60 Offset: 0x91F660 VA: 0x180920C60
	public void .ctor() { }

	// RVA: 0x920C20 Offset: 0x91F620 VA: 0x180920C20
	private static void .cctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(VehicleModMenu.<<Open>g__Close|24_0>d))]
	// RVA: 0x920AA0 Offset: 0x91F4A0 VA: 0x180920AA0
	private IEnumerator <Open>g__Close|24_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(VehicleModMenu.<<Close>g__Close|25_0>d))]
	// RVA: 0x920A30 Offset: 0x91F430 VA: 0x180920A30
	private IEnumerator <Close>g__Close|25_0() { }
}
