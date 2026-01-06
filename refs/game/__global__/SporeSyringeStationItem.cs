public class SporeSyringeStationItem : StationItem // TypeDefIndex: 2436
{
	// Fields
	public const float MaxAngleDifferenceForInjection = 35;
	public const float PlungerPushSpeed = 0.8;
	public const float PlungerDragDistanceMultiplier = 2;
	[SerializeField]
	private GameObject _capHighlight; // 0x38
	[SerializeField]
	private Transform _capContainer; // 0x40
	[SerializeField]
	private Clickable _capClickable; // 0x48
	[SerializeField]
	private Draggable _syringeDraggable; // 0x50
	[SerializeField]
	private GameObject _plungerHighlight; // 0x58
	[SerializeField]
	private Transform _plungerTransform; // 0x60
	[SerializeField]
	private Transform _plungerExtendedPosition; // 0x68
	[SerializeField]
	private Transform _plungerCompressedPosition; // 0x70
	[SerializeField]
	private Transform _liquidTransform; // 0x78
	[SerializeField]
	private Clickable _plungerClickable; // 0x80
	[SerializeField]
	private AudioSourceController _plungerSound; // 0x88
	private Collider _injectionPortCollider; // 0x90
	public UnityEvent onCapRemoved; // 0x98
	public UnityEvent onInserted; // 0xA0
	public UnityEvent<float> onPlungerMoved; // 0xA8
	[CompilerGenerated]
	private float <PlungerPosition>k__BackingField; // 0xB0
	private bool _capRemoved; // 0xB4
	private Vector3 _initialPlungerHitPoint; // 0xB8
	private float timeOnPlungerClickStart; // 0xC4

	// Properties
	public float PlungerPosition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C1800 Offset: 0x7C0200 VA: 0x1807C1800
	public float get_PlungerPosition() { }

	[CompilerGenerated]
	// RVA: 0x7C2590 Offset: 0x7C0F90 VA: 0x1807C2590
	private void set_PlungerPosition(float value) { }

	// RVA: 0x8A7A20 Offset: 0x8A6420 VA: 0x1808A7A20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x8A8080 Offset: 0x8A6A80 VA: 0x1808A8080
	private void LateUpdate() { }

	// RVA: 0x8A8C00 Offset: 0x8A7600 VA: 0x1808A8C00
	public void SetCapInteractable(bool interactable) { }

	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void SetInjectionPortCollider(Collider collider) { }

	// RVA: 0x8A89D0 Offset: 0x8A73D0 VA: 0x1808A89D0
	private void RemoveCap() { }

	// RVA: 0x8A8E30 Offset: 0x8A7830 VA: 0x1808A8E30
	public void SetSyringeDraggable(bool draggable) { }

	// RVA: 0x8A86C0 Offset: 0x8A70C0 VA: 0x1808A86C0
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x8A7FE0 Offset: 0x8A69E0 VA: 0x1808A7FE0
	private void InsertSyringe() { }

	// RVA: 0x8A8C40 Offset: 0x8A7640 VA: 0x1808A8C40
	public void SetPlungerInteractable(bool interactable) { }

	// RVA: 0x8A8C60 Offset: 0x8A7660 VA: 0x1808A8C60
	private void SetPlungerPosition(float position) { }

	// RVA: 0x8A8640 Offset: 0x8A7040 VA: 0x1808A8640
	private void OnPlungerClickStart(RaycastHit hit) { }

	// RVA: 0x8A8610 Offset: 0x8A7010 VA: 0x1808A8610
	private void OnPlungerClickEnd() { }

	// RVA: 0x8A7C10 Offset: 0x8A6610 VA: 0x1808A7C10
	private Vector3 GetPlungerPlaneHit() { }

	// RVA: 0x873960 Offset: 0x872360 VA: 0x180873960
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8A8EE0 Offset: 0x8A78E0 VA: 0x1808A8EE0
	private void <Awake>b__25_0(RaycastHit h) { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(SporeSyringeStationItem.<<InsertSyringe>g__MoveSyringe|32_0>d))]
	// RVA: 0x8A8EF0 Offset: 0x8A78F0 VA: 0x1808A8EF0
	private IEnumerator <InsertSyringe>g__MoveSyringe|32_0() { }
}
