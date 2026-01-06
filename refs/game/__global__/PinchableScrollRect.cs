public class PinchableScrollRect : ScrollRect, IPinchStartHandler, IPinchEndHandler, IPinchZoomHandler // TypeDefIndex: 19168
{
	// Fields
	[Header("Pinch Settings")]
	[SerializeField]
	protected bool resetOnEnable; // 0x130
	[SerializeField]
	protected bool lockPinchCenter; // 0x131
	private Vector2 initPivot; // 0x134
	private Vector2 initAnchored; // 0x13C
	private Vector3 initScale; // 0x144
	private float zoomVelocity; // 0x150
	private Vector2 zoomPosDelta; // 0x154
	private bool updatePivot; // 0x15C
	protected bool isZooming; // 0x15D
	protected Vector2 pinchStartPos; // 0x160
	public Vector3 lowerScale; // 0x168
	public Vector3 upperScale; // 0x174
	[SerializeField]
	protected float pinchSensitivity; // 0x180
	[SerializeField]
	protected float zoomMaxSpeed; // 0x184
	[SerializeField]
	[Range(1, 0)]
	protected float zoomDeceleration; // 0x188
	private bool initialized; // 0x18C
	[SerializeField]
	private PinchableScrollRect.PinchEvent _onScaleChanged; // 0x190

	// Properties
	public PinchableScrollRect.PinchEvent onScaleChanged { get; set; }

	// Methods

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public PinchableScrollRect.PinchEvent get_onScaleChanged() { }

	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	public void set_onScaleChanged(PinchableScrollRect.PinchEvent value) { }

	// RVA: 0x1A507F0 Offset: 0x1A4F1F0 VA: 0x181A507F0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1A4FD50 Offset: 0x1A4E750 VA: 0x181A4FD50 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A4FEB0 Offset: 0x1A4E8B0 VA: 0x181A4FEB0 Slot: 64
	public virtual void OnPinchStart(PinchEventData eventData) { }

	// RVA: 0x1A4FE40 Offset: 0x1A4E840 VA: 0x181A4FE40 Slot: 65
	public virtual void OnPinchEnd(PinchEventData eventData) { }

	// RVA: 0x1A4FFB0 Offset: 0x1A4E9B0 VA: 0x181A4FFB0 Slot: 66
	public virtual void OnPinchZoom(PinchEventData eventData) { }

	// RVA: 0x1A50240 Offset: 0x1A4EC40 VA: 0x181A50240 Slot: 42
	public override void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1A508D0 Offset: 0x1A4F2D0 VA: 0x181A508D0 Slot: 67
	protected virtual void Update() { }

	// RVA: 0x1A4FC80 Offset: 0x1A4E680 VA: 0x181A4FC80 Slot: 48
	protected override void LateUpdate() { }

	// RVA: 0x1A4F8D0 Offset: 0x1A4E2D0 VA: 0x181A4F8D0 Slot: 68
	protected virtual void HandleZoom(float zoomValue) { }

	// RVA: 0x1A50670 Offset: 0x1A4F070 VA: 0x181A50670 Slot: 69
	protected virtual void SetContentPivotPosition(Vector2 pivot) { }

	// RVA: 0x1A505D0 Offset: 0x1A4EFD0 VA: 0x181A505D0 Slot: 70
	protected virtual void SetContentLocalScale(Vector3 newScale) { }

	// RVA: 0x1A50560 Offset: 0x1A4EF60 VA: 0x181A50560
	protected void ResetZoom() { }

	// RVA: 0x1A50730 Offset: 0x1A4F130 VA: 0x181A50730
	public void SetNormalizedScale(float normalized) { }

	// RVA: 0x1A50420 Offset: 0x1A4EE20 VA: 0x181A50420 Slot: 71
	public virtual void ResetContent() { }

	// RVA: 0x1A4FD00 Offset: 0x1A4E700 VA: 0x181A4FD00 Slot: 46
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A4FCB0 Offset: 0x1A4E6B0 VA: 0x181A4FCB0 Slot: 44
	public override void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A4FDF0 Offset: 0x1A4E7F0 VA: 0x181A4FDF0 Slot: 45
	public override void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A50970 Offset: 0x1A4F370 VA: 0x181A50970
	public void .ctor() { }
}
