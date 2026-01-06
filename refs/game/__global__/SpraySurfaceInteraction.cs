public class SpraySurfaceInteraction : MonoBehaviour // TypeDefIndex: 1387
{
	// Fields
	public const float CAMERA_MOVE_TIME = 0.15;
	public const int MAX_PIXELS_BEFORE_NEW_STROKE = 1000;
	public const int MANHATTAN_DISTANCE_BETWEEN_PAINTED_PIXELS = 3;
	public const int XP_GAIN = 50;
	public const float CARTEL_INFLUENCE_CHANGE = -0.05;
	public const int PAINTED_PIXEL_LIMIT = 25000;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	public SpraySurface SpraySurface; // 0x28
	public InteractableObject IntObj; // 0x30
	public Transform CameraPosition; // 0x38
	public Canvas Canvas; // 0x40
	public Image SprayImg; // 0x48
	public AudioSourceController SpraySound; // 0x50
	public AudioSourceController CleanSound; // 0x58
	private ESprayColor selectedColor; // 0x60
	private UShort2 lastPaintedPixelCoord; // 0x62
	private bool paintedLastFrame; // 0x66
	private List<UShort2> currentStrokePixels; // 0x68
	private bool isPaintingStroke; // 0x70
	private float timeSinceStrokeStart; // 0x74

	// Properties
	public bool IsOpen { get; set; }
	private bool confirmationPanelOpen { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x68C730 Offset: 0x68B130 VA: 0x18068C730
	private bool get_confirmationPanelOpen() { }

	// RVA: 0x688FA0 Offset: 0x6879A0 VA: 0x180688FA0
	private void Awake() { }

	// RVA: 0x68C1F0 Offset: 0x68ABF0 VA: 0x18068C1F0
	private void Start() { }

	// RVA: 0x68B990 Offset: 0x68A390 VA: 0x18068B990
	private void PlayerSpawned() { }

	// RVA: 0x68AFF0 Offset: 0x6899F0 VA: 0x18068AFF0
	private void OnDestroy() { }

	// RVA: 0x68B170 Offset: 0x689B70 VA: 0x18068B170
	private void OnValidate() { }

	// RVA: 0x68BC00 Offset: 0x68A600 VA: 0x18068BC00
	private void ResizeCanvas() { }

	// RVA: 0x68C4F0 Offset: 0x68AEF0 VA: 0x18068C4F0
	private void Update() { }

	// RVA: 0x68C3A0 Offset: 0x68ADA0 VA: 0x18068C3A0
	private void UpdateCursor() { }

	// RVA: 0x689F70 Offset: 0x688970 VA: 0x180689F70
	private void FixedUpdate() { }

	// RVA: 0x68C190 Offset: 0x68AB90 VA: 0x18068C190
	private void StartStroke() { }

	// RVA: 0x689B80 Offset: 0x688580 VA: 0x180689B80
	private void EndStroke(bool stopSpraySound) { }

	// RVA: 0x68A580 Offset: 0x688F80 VA: 0x18068A580
	private bool GetCursorPositionOnSurface(out ushort pixelX, out ushort pixelY) { }

	// RVA: 0x68AAA0 Offset: 0x6894A0 VA: 0x18068AAA0
	private Ray GetCursorRay() { }

	// RVA: 0x68AB70 Offset: 0x689570 VA: 0x18068AB70
	private void Hovered() { }

	// RVA: 0x68AC70 Offset: 0x689670 VA: 0x18068AC70
	private void Interacted() { }

	// RVA: 0x68C590 Offset: 0x68AF90 VA: 0x18068C590
	private void UseGraffitiCleaner() { }

	// RVA: 0x689EC0 Offset: 0x6888C0 VA: 0x180689EC0
	private void Exit(ExitAction action) { }

	// RVA: 0x68B180 Offset: 0x689B80 VA: 0x18068B180
	private void Open() { }

	// RVA: 0x6891D0 Offset: 0x687BD0 VA: 0x1806891D0
	private void Close() { }

	// RVA: 0x68C020 Offset: 0x68AA20 VA: 0x18068C020
	private void Reward() { }

	// RVA: 0x689E50 Offset: 0x688850 VA: 0x180689E50
	private void EquippedSlotChanged(int equippedSlotIndex) { }

	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	private void SetColor(ESprayColor color) { }

	// RVA: 0x689130 Offset: 0x687B30 VA: 0x180689130
	private void Clear() { }

	// RVA: 0x68AEF0 Offset: 0x6898F0 VA: 0x18068AEF0
	private static bool IsSprayCanEquipped() { }

	// RVA: 0x68ADF0 Offset: 0x6897F0 VA: 0x18068ADF0
	private static bool IsGraffitiCleanerEquipped() { }

	// RVA: 0x68C6B0 Offset: 0x68B0B0 VA: 0x18068C6B0
	public void .ctor() { }
}
