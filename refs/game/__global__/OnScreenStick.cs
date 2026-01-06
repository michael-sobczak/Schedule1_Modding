public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7546
{
	// Fields
	private const string kDynamicOriginClickable = "DynamicOriginClickable";
	[FormerlySerializedAs("movementRange")]
	[SerializeField]
	[Min(0)]
	private float m_MovementRange; // 0x38
	[Min(0)]
	[Tooltip("Defines the circular region where the onscreen control may have it's origin placed.")]
	[SerializeField]
	private float m_DynamicOriginRange; // 0x3C
	[SerializeField]
	[InputControl(layout = "Vector2")]
	private string m_ControlPath; // 0x40
	[Tooltip("Choose how the onscreen stick will move relative to it's origin and the press position.

RelativePositionWithStaticOrigin: The control's center of origin is fixed. The control will begin un-actuated at it's centered position and then move relative to the pointer or finger motion.

ExactPositionWithStaticOrigin: The control's center of origin is fixed. The stick will immediately jump to the exact position of the click or touch and begin tracking motion from there.

ExactPositionWithDynamicOrigin: The control's center of origin is determined by the initial press position. The stick will begin un-actuated at this center position and then track the current pointer or finger position.")]
	[SerializeField]
	private OnScreenStick.Behaviour m_Behaviour; // 0x48
	[Tooltip("Set this to true to prevent cancellation of pointer events due to device switching. Cancellation will appear as the stick jumping back and forth between the pointer position and the stick center.")]
	[SerializeField]
	private bool m_UseIsolatedInputActions; // 0x4C
	[Tooltip("The action that will be used to detect pointer down events on the stick control. Note that if no bindings are set, default ones will be provided.")]
	[SerializeField]
	private InputAction m_PointerDownAction; // 0x50
	[Tooltip("The action that will be used to detect pointer movement on the stick control. Note that if no bindings are set, default ones will be provided.")]
	[SerializeField]
	private InputAction m_PointerMoveAction; // 0x58
	private Vector3 m_StartPos; // 0x60
	private Vector2 m_PointerDownPos; // 0x6C
	private List<RaycastResult> m_RaycastResults; // 0x78
	private PointerEventData m_PointerEventData; // 0x80
	private TouchControl m_TouchControl; // 0x88
	private bool m_IsIsolationActive; // 0x90

	// Properties
	public float movementRange { get; set; }
	public float dynamicOriginRange { get; set; }
	public bool useIsolatedInputActions { get; set; }
	protected override string controlPathInternal { get; set; }
	public OnScreenStick.Behaviour behaviour { get; set; }

	// Methods

	// RVA: 0x284D360 Offset: 0x284BD60 VA: 0x18284D360 Slot: 8
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x284C9A0 Offset: 0x284B3A0 VA: 0x18284C9A0 Slot: 10
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x284D640 Offset: 0x284C040 VA: 0x18284D640 Slot: 9
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x284D650 Offset: 0x284C050 VA: 0x18284D650
	private void Start() { }

	// RVA: 0x284C900 Offset: 0x284B300 VA: 0x18284C900
	private void OnDestroy() { }

	// RVA: 0x284BF70 Offset: 0x284A970 VA: 0x18284BF70
	private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x284C590 Offset: 0x284AF90 VA: 0x18284C590
	private void MoveStick(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x284C370 Offset: 0x284AD70 VA: 0x18284C370
	private void EndInteraction() { }

	// RVA: 0x284CEC0 Offset: 0x284B8C0 VA: 0x18284CEC0
	private void OnPointerDown(InputAction.CallbackContext ctx) { }

	// RVA: 0x284CD70 Offset: 0x284B770 VA: 0x18284CD70
	private void OnPointerChanged(InputAction.CallbackContext ctx) { }

	// RVA: 0x284D410 Offset: 0x284BE10 VA: 0x18284D410
	private void OnPointerMove(InputAction.CallbackContext ctx) { }

	// RVA: 0x284D530 Offset: 0x284BF30 VA: 0x18284D530
	private void OnPointerUp(InputAction.CallbackContext ctx) { }

	// RVA: 0x284C460 Offset: 0x284AE60 VA: 0x18284C460
	private Camera GetCameraFromCanvas() { }

	// RVA: 0x284CA50 Offset: 0x284B450 VA: 0x18284CA50
	private void OnDrawGizmosSelected() { }

	// RVA: 0x284C1E0 Offset: 0x284ABE0 VA: 0x18284C1E0
	private void DrawGizmoCircle(Vector2 center, float radius) { }

	// RVA: 0x284DD90 Offset: 0x284C790 VA: 0x18284DD90
	private void UpdateDynamicOriginClickableArea() { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_movementRange() { }

	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	public void set_movementRange(float value) { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_dynamicOriginRange() { }

	// RVA: 0x284DEB0 Offset: 0x284C8B0 VA: 0x18284DEB0
	public void set_dynamicOriginRange(float value) { }

	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0
	public bool get_useIsolatedInputActions() { }

	// RVA: 0xAEE590 Offset: 0xAECF90 VA: 0x180AEE590
	public void set_useIsolatedInputActions(bool value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 4
	protected override string get_controlPathInternal() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0 Slot: 5
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public OnScreenStick.Behaviour get_behaviour() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_behaviour(OnScreenStick.Behaviour value) { }

	// RVA: 0x284DE90 Offset: 0x284C890 VA: 0x18284DE90
	public void .ctor() { }
}
