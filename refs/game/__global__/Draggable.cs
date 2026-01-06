public class Draggable : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 1532
{
	// Fields
	public const float INITIAL_REPLICATION_DISTANCE = 1;
	public const float MAX_DRAG_START_RANGE = 2.5;
	public const float MAX_TARGET_OFFSET = 1.5;
	private bool isBeingDragged; // 0x20
	private Player currentDragger; // 0x28
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x30
	public string BakedGUID; // 0x40
	[Header("References")]
	public Rigidbody Rigidbody; // 0x48
	public InteractableObject IntObj; // 0x50
	public Transform DragOrigin; // 0x58
	[Header("Settings")]
	public bool CreateCoM; // 0x60
	[Range(0.5, 2)]
	public float HoldDistanceMultiplier; // 0x64
	[Range(0, 5)]
	public float DragForceMultiplier; // 0x68
	public Draggable.EInitialReplicationMode InitialReplicationMode; // 0x6C
	private float timeSinceLastDrag; // 0x70
	public UnityEvent onDragStart; // 0x78
	public UnityEvent onDragEnd; // 0x80
	public UnityEvent onHovered; // 0x88
	public UnityEvent onInteracted; // 0x90
	[CompilerGenerated]
	private Vector3 <initialPosition>k__BackingField; // 0x98

	// Properties
	public bool IsBeingDragged { get; }
	public Player CurrentDragger { get; set; }
	public Guid GUID { get; set; }
	public Vector3 initialPosition { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsBeingDragged() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Player get_CurrentDragger() { }

	// RVA: 0x6FC330 Offset: 0x6FAD30 VA: 0x1806FC330
	protected void set_CurrentDragger(Player value) { }

	[CompilerGenerated]
	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x6FC3B0 Offset: 0x6FADB0 VA: 0x1806FC3B0
	protected void set_GUID(Guid value) { }

	[Button]
	// RVA: 0x6FBEE0 Offset: 0x6FA8E0 VA: 0x1806FBEE0
	public void RegenerateGUID() { }

	[CompilerGenerated]
	// RVA: 0x66B010 Offset: 0x669A10 VA: 0x18066B010
	public Vector3 get_initialPosition() { }

	[CompilerGenerated]
	// RVA: 0x6FC3C0 Offset: 0x6FADC0 VA: 0x1806FC3C0
	private void set_initialPosition(Vector3 value) { }

	// RVA: 0x6FB6E0 Offset: 0x6FA0E0 VA: 0x1806FB6E0 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x6FBFF0 Offset: 0x6FA9F0 VA: 0x1806FBFF0 Slot: 8
	protected virtual void Start() { }

	// RVA: 0x6FBF30 Offset: 0x6FA930 VA: 0x1806FBF30 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x6FBE00 Offset: 0x6FA800 VA: 0x1806FBE00
	protected void OnValidate() { }

	// RVA: 0x6FBC40 Offset: 0x6FA640 VA: 0x1806FBC40
	protected void OnDestroy() { }

	// RVA: 0x6FC140 Offset: 0x6FAB40 VA: 0x1806FC140
	public void UpdateDraggable() { }

	// RVA: 0x6FB0C0 Offset: 0x6F9AC0 VA: 0x1806FB0C0
	public void ApplyDragForces(Vector3 targetPosition) { }

	// RVA: 0x6FBB00 Offset: 0x6FA500 VA: 0x1806FBB00 Slot: 9
	protected virtual void Hovered() { }

	// RVA: 0x6FBBB0 Offset: 0x6FA5B0 VA: 0x1806FBBB0 Slot: 10
	protected virtual void Interacted() { }

	// RVA: 0x6FBA20 Offset: 0x6FA420 VA: 0x1806FBA20
	private bool CanInteract() { }

	// RVA: 0x6FBFA0 Offset: 0x6FA9A0 VA: 0x1806FBFA0
	public void StartDragging(Player dragger) { }

	// RVA: 0x6FC0E0 Offset: 0x6FAAE0 VA: 0x1806FC0E0
	public void StopDragging() { }

	// RVA: 0x6FC2B0 Offset: 0x6FACB0 VA: 0x1806FC2B0
	public void .ctor() { }
}
