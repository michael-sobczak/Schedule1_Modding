public class InputSystemUIInputModule : BaseInputModule // TypeDefIndex: 7517
{
	// Fields
	private const float kClickSpeed = 0.3;
	[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
	[SerializeField]
	[FormerlySerializedAs("m_RepeatDelay")]
	private float m_MoveRepeatDelay; // 0x58
	[Tooltip("The speed (in seconds) that the move action repeats itself once repeating (max 1 per frame).")]
	[SerializeField]
	[FormerlySerializedAs("m_RepeatRate")]
	private float m_MoveRepeatRate; // 0x5C
	[Tooltip("Scales the Eventsystem.DragThreshold, for tracked devices, to make selection easier.")]
	private float m_TrackedDeviceDragThresholdMultiplier; // 0x60
	[Tooltip("Transform representing the real world origin for tracking devices. When using the XR Interaction Toolkit, this should be pointing to the XR Rig's Transform.")]
	[SerializeField]
	private Transform m_XRTrackingOrigin; // 0x68
	private static DefaultInputActions defaultActions; // 0x0
	[HideInInspector]
	[SerializeField]
	private InputActionAsset m_ActionsAsset; // 0x70
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_PointAction; // 0x78
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_MoveAction; // 0x80
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_SubmitAction; // 0x88
	[SerializeField]
	[HideInInspector]
	private InputActionReference m_CancelAction; // 0x90
	[SerializeField]
	[HideInInspector]
	private InputActionReference m_LeftClickAction; // 0x98
	[SerializeField]
	[HideInInspector]
	private InputActionReference m_MiddleClickAction; // 0xA0
	[SerializeField]
	[HideInInspector]
	private InputActionReference m_RightClickAction; // 0xA8
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_ScrollWheelAction; // 0xB0
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_TrackedDevicePositionAction; // 0xB8
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_TrackedDeviceOrientationAction; // 0xC0
	[SerializeField]
	private bool m_DeselectOnBackgroundClick; // 0xC8
	[SerializeField]
	private UIPointerBehavior m_PointerBehavior; // 0xCC
	[SerializeField]
	[HideInInspector]
	internal InputSystemUIInputModule.CursorLockBehavior m_CursorLockBehavior; // 0xD0
	[SerializeField]
	private float m_ScrollDeltaPerTick; // 0xD4
	private static Dictionary<InputAction, InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts; // 0x8
	private bool m_ActionsHooked; // 0xD8
	private bool m_NeedToPurgeStalePointers; // 0xD9
	private Action<InputAction.CallbackContext> m_OnPointDelegate; // 0xE0
	private Action<InputAction.CallbackContext> m_OnMoveDelegate; // 0xE8
	private Action<InputAction.CallbackContext> m_OnSubmitCancelDelegate; // 0xF0
	private Action<InputAction.CallbackContext> m_OnLeftClickDelegate; // 0xF8
	private Action<InputAction.CallbackContext> m_OnRightClickDelegate; // 0x100
	private Action<InputAction.CallbackContext> m_OnMiddleClickDelegate; // 0x108
	private Action<InputAction.CallbackContext> m_OnScrollWheelDelegate; // 0x110
	private Action<InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate; // 0x118
	private Action<InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate; // 0x120
	private Action<object> m_OnControlsChangedDelegate; // 0x128
	private int m_CurrentPointerId; // 0x130
	private int m_CurrentPointerIndex; // 0x134
	internal UIPointerType m_CurrentPointerType; // 0x138
	internal InlinedArray<int> m_PointerIds; // 0x140
	internal InlinedArray<PointerModel> m_PointerStates; // 0x150
	private NavigationModel m_NavigationState; // 0x380
	private SubmitCancelModel m_SubmitCancelState; // 0x3A8
	private GameObject m_LocalMultiPlayerRoot; // 0x3B8

	// Properties
	public bool deselectOnBackgroundClick { get; set; }
	public UIPointerBehavior pointerBehavior { get; set; }
	public InputSystemUIInputModule.CursorLockBehavior cursorLockBehavior { get; set; }
	internal GameObject localMultiPlayerRoot { get; set; }
	public float scrollDeltaPerTick { get; set; }
	public float moveRepeatDelay { get; set; }
	public float moveRepeatRate { get; set; }
	private bool explictlyIgnoreFocus { get; }
	private bool shouldIgnoreFocus { get; }
	[Obsolete("'repeatRate' has been obsoleted; use 'moveRepeatRate' instead. (UnityUpgradable) -> moveRepeatRate", False)]
	public float repeatRate { get; set; }
	[Obsolete("'repeatDelay' has been obsoleted; use 'moveRepeatDelay' instead. (UnityUpgradable) -> moveRepeatDelay", False)]
	public float repeatDelay { get; set; }
	public Transform xrTrackingOrigin { get; set; }
	public float trackedDeviceDragThresholdMultiplier { get; set; }
	public InputActionReference point { get; set; }
	public InputActionReference scrollWheel { get; set; }
	public InputActionReference leftClick { get; set; }
	public InputActionReference middleClick { get; set; }
	public InputActionReference rightClick { get; set; }
	public InputActionReference move { get; set; }
	public InputActionReference submit { get; set; }
	public InputActionReference cancel { get; set; }
	public InputActionReference trackedDeviceOrientation { get; set; }
	public InputActionReference trackedDevicePosition { get; set; }
	[Obsolete("'trackedDeviceSelect' has been obsoleted; use 'leftClick' instead.", True)]
	public InputActionReference trackedDeviceSelect { get; set; }
	public InputActionAsset actionsAsset { get; set; }
	private bool sendPointerHoverToParent { get; }

	// Methods

	// RVA: 0x1A3AE20 Offset: 0x1A39820 VA: 0x181A3AE20
	public bool get_deselectOnBackgroundClick() { }

	// RVA: 0x1A3AF10 Offset: 0x1A39910 VA: 0x181A3AF10
	public void set_deselectOnBackgroundClick(bool value) { }

	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	public UIPointerBehavior get_pointerBehavior() { }

	// RVA: 0x1A3AF40 Offset: 0x1A39940 VA: 0x181A3AF40
	public void set_pointerBehavior(UIPointerBehavior value) { }

	// RVA: 0x1A3AE30 Offset: 0x1A39830 VA: 0x181A3AE30
	public InputSystemUIInputModule.CursorLockBehavior get_cursorLockBehavior() { }

	// RVA: 0x1A3AF20 Offset: 0x1A39920 VA: 0x181A3AF20
	public void set_cursorLockBehavior(InputSystemUIInputModule.CursorLockBehavior value) { }

	// RVA: 0x6CD170 Offset: 0x6CBB70 VA: 0x1806CD170
	internal GameObject get_localMultiPlayerRoot() { }

	// RVA: 0x6CD1A0 Offset: 0x6CBBA0 VA: 0x1806CD1A0
	internal void set_localMultiPlayerRoot(GameObject value) { }

	// RVA: 0x510B20 Offset: 0x50F520 VA: 0x180510B20
	public float get_scrollDeltaPerTick() { }

	// RVA: 0x284A340 Offset: 0x2848D40 VA: 0x18284A340
	public void set_scrollDeltaPerTick(float value) { }

	// RVA: 0x2842130 Offset: 0x2840B30 VA: 0x182842130 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x28447A0 Offset: 0x28431A0 VA: 0x1828447A0 Slot: 20
	public override bool IsPointerOverGameObject(int pointerOrTouchId) { }

	// RVA: 0x28432E0 Offset: 0x2841CE0 VA: 0x1828432E0
	public RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	// RVA: 0x2845710 Offset: 0x2844110 VA: 0x182845710
	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	// RVA: 0x2847750 Offset: 0x2846150 VA: 0x182847750
	private void ProcessPointer(ref PointerModel state) { }

	// RVA: 0x2845A50 Offset: 0x2844450 VA: 0x182845A50
	private bool PointerShouldIgnoreTransform(Transform t) { }

	// RVA: 0x2846DE0 Offset: 0x28457E0 VA: 0x182846DE0
	private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData) { }

	// RVA: 0x2846E40 Offset: 0x2845840 VA: 0x182846E40
	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	// RVA: 0x2846540 Offset: 0x2844F40 VA: 0x182846540
	private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData) { }

	// RVA: 0x2846240 Offset: 0x2844C40 VA: 0x182846240
	private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData) { }

	// RVA: 0x2847610 Offset: 0x2846010 VA: 0x182847610
	private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData) { }

	// RVA: 0x2845B40 Offset: 0x2844540 VA: 0x182845B40
	internal void ProcessNavigation(ref NavigationModel navigationState) { }

	// RVA: 0x2844580 Offset: 0x2842F80 VA: 0x182844580
	private bool IsMoveAllowed(AxisEventData eventData) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_moveRepeatDelay() { }

	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	public void set_moveRepeatDelay(float value) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_moveRepeatRate() { }

	// RVA: 0xD3E1E0 Offset: 0xD3CBE0 VA: 0x180D3E1E0
	public void set_moveRepeatRate(float value) { }

	// RVA: 0x28499B0 Offset: 0x28483B0 VA: 0x1828499B0
	private bool get_explictlyIgnoreFocus() { }

	// RVA: 0x2849A10 Offset: 0x2848410 VA: 0x182849A10
	private bool get_shouldIgnoreFocus() { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_repeatRate() { }

	// RVA: 0xD3E1E0 Offset: 0xD3CBE0 VA: 0x180D3E1E0
	public void set_repeatRate(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_repeatDelay() { }

	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	public void set_repeatDelay(float value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Transform get_xrTrackingOrigin() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_xrTrackingOrigin(Transform value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_trackedDeviceDragThresholdMultiplier() { }

	// RVA: 0x810840 Offset: 0x80F240 VA: 0x180810840
	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	// RVA: 0x2849140 Offset: 0x2847B40 VA: 0x182849140
	private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public InputActionReference get_point() { }

	// RVA: 0x284A2C0 Offset: 0x2848CC0 VA: 0x18284A2C0
	public void set_point(InputActionReference value) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public InputActionReference get_scrollWheel() { }

	// RVA: 0x284A350 Offset: 0x2848D50 VA: 0x18284A350
	public void set_scrollWheel(InputActionReference value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public InputActionReference get_leftClick() { }

	// RVA: 0x284A200 Offset: 0x2848C00 VA: 0x18284A200
	public void set_leftClick(InputActionReference value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public InputActionReference get_middleClick() { }

	// RVA: 0x284A240 Offset: 0x2848C40 VA: 0x18284A240
	public void set_middleClick(InputActionReference value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public InputActionReference get_rightClick() { }

	// RVA: 0x284A300 Offset: 0x2848D00 VA: 0x18284A300
	public void set_rightClick(InputActionReference value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public InputActionReference get_move() { }

	// RVA: 0x284A280 Offset: 0x2848C80 VA: 0x18284A280
	public void set_move(InputActionReference value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public InputActionReference get_submit() { }

	// RVA: 0x284A390 Offset: 0x2848D90 VA: 0x18284A390
	public void set_submit(InputActionReference value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public InputActionReference get_cancel() { }

	// RVA: 0x284A1C0 Offset: 0x2848BC0 VA: 0x18284A1C0
	public void set_cancel(InputActionReference value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public InputActionReference get_trackedDeviceOrientation() { }

	// RVA: 0x284A3D0 Offset: 0x2848DD0 VA: 0x18284A3D0
	public void set_trackedDeviceOrientation(InputActionReference value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public InputActionReference get_trackedDevicePosition() { }

	// RVA: 0x284A410 Offset: 0x2848E10 VA: 0x18284A410
	public void set_trackedDevicePosition(InputActionReference value) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x28486B0 Offset: 0x28470B0 VA: 0x1828486B0
	private static void ResetDefaultActions() { }

	// RVA: 0x2842460 Offset: 0x2840E60 VA: 0x182842460
	public void AssignDefaultActions() { }

	// RVA: 0x28495C0 Offset: 0x2847FC0 VA: 0x1828495C0
	public void UnassignActions() { }

	// RVA: 0x2849AC0 Offset: 0x28484C0 VA: 0x182849AC0
	public InputActionReference get_trackedDeviceSelect() { }

	// RVA: 0x284A450 Offset: 0x2848E50 VA: 0x18284A450
	public void set_trackedDeviceSelect(InputActionReference value) { }

	// RVA: 0x2842970 Offset: 0x2841370 VA: 0x182842970 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2844900 Offset: 0x2843300 VA: 0x182844900 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2844B70 Offset: 0x2843570 VA: 0x182844B70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2844940 Offset: 0x2843340 VA: 0x182844940 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2848760 Offset: 0x2847160 VA: 0x182848760
	private void ResetPointers() { }

	// RVA: 0x2843F10 Offset: 0x2842910 VA: 0x182843F10
	private bool HasNoActions() { }

	// RVA: 0x2842BF0 Offset: 0x28415F0 VA: 0x182842BF0
	private void EnableAllActions() { }

	// RVA: 0x2842B10 Offset: 0x2841510 VA: 0x182842B10
	private void DisableAllActions() { }

	// RVA: 0x2842CB0 Offset: 0x28416B0 VA: 0x182842CB0
	private void EnableInputAction(InputActionReference inputActionReference) { }

	// RVA: 0x2849410 Offset: 0x2847E10 VA: 0x182849410
	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = False) { }

	// RVA: 0x28434A0 Offset: 0x2841EA0 VA: 0x1828434A0
	private int GetPointerStateIndexFor(int pointerOrTouchId) { }

	// RVA: 0x28433B0 Offset: 0x2841DB0 VA: 0x1828433B0
	private ref PointerModel GetPointerStateForIndex(int index) { }

	// RVA: 0x2843240 Offset: 0x2841C40 VA: 0x182843240
	private int GetDisplayIndexFor(InputControl control) { }

	// RVA: 0x2843400 Offset: 0x2841E00 VA: 0x182843400
	private int GetPointerStateIndexFor(ref InputAction.CallbackContext context) { }

	// RVA: 0x28435F0 Offset: 0x2841FF0 VA: 0x1828435F0
	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = True) { }

	// RVA: 0x28421F0 Offset: 0x2840BF0 VA: 0x1828421F0
	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl) { }

	// RVA: 0x2848880 Offset: 0x2847280 VA: 0x182848880
	private bool SendPointerExitEventsAndRemovePointer(int index) { }

	// RVA: 0x28483A0 Offset: 0x2846DA0 VA: 0x1828483A0
	private bool RemovePointerAtIndex(int index) { }

	// RVA: 0x2848220 Offset: 0x2846C20 VA: 0x182848220
	private void PurgeStalePointers() { }

	// RVA: 0x2844080 Offset: 0x2842A80 VA: 0x182844080
	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	// RVA: 0x2845040 Offset: 0x2843A40 VA: 0x182845040
	private void OnPointCallback(InputAction.CallbackContext context) { }

	// RVA: 0x2844470 Offset: 0x2842E70 VA: 0x182844470
	private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed) { }

	// RVA: 0x2844D30 Offset: 0x2843730 VA: 0x182844D30
	private void OnLeftClickCallback(InputAction.CallbackContext context) { }

	// RVA: 0x2845160 Offset: 0x2843B60 VA: 0x182845160
	private void OnRightClickCallback(InputAction.CallbackContext context) { }

	// RVA: 0x2844E60 Offset: 0x2843860 VA: 0x182844E60
	private void OnMiddleClickCallback(InputAction.CallbackContext context) { }

	// RVA: 0x28429D0 Offset: 0x28413D0 VA: 0x1828429D0
	private bool CheckForRemovedDevice(ref InputAction.CallbackContext context) { }

	// RVA: 0x28452A0 Offset: 0x2843CA0 VA: 0x1828452A0
	private void OnScrollCallback(InputAction.CallbackContext context) { }

	// RVA: 0x2844FA0 Offset: 0x28439A0 VA: 0x182844FA0
	private void OnMoveCallback(InputAction.CallbackContext context) { }

	// RVA: 0x28453E0 Offset: 0x2843DE0 VA: 0x1828453E0
	private void OnSubmitCancelCallback(InputAction.CallbackContext context) { }

	// RVA: 0x2845420 Offset: 0x2843E20 VA: 0x182845420
	private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context) { }

	// RVA: 0x28455B0 Offset: 0x2843FB0 VA: 0x1828455B0
	private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context) { }

	// RVA: 0x28448F0 Offset: 0x28432F0 VA: 0x1828448F0
	private void OnControlsChanged(object obj) { }

	// RVA: 0x2842E50 Offset: 0x2841850 VA: 0x182842E50
	private void FilterPointerStatesByType() { }

	// RVA: 0x2847EA0 Offset: 0x28468A0 VA: 0x182847EA0 Slot: 17
	public override void Process() { }

	// RVA: 0x2842A40 Offset: 0x2841440 VA: 0x182842A40 Slot: 26
	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x2844150 Offset: 0x2842B50 VA: 0x182844150
	private void HookActions() { }

	// RVA: 0x2849820 Offset: 0x2848220 VA: 0x182849820
	private void UnhookActions() { }

	// RVA: 0x2848A40 Offset: 0x2847440 VA: 0x182848A40
	private void SetActionCallbacks(bool install) { }

	// RVA: 0x2848960 Offset: 0x2847360 VA: 0x182848960
	private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x2849840 Offset: 0x2848240 VA: 0x182849840
	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public InputActionAsset get_actionsAsset() { }

	// RVA: 0x2849B00 Offset: 0x2848500 VA: 0x182849B00
	public void set_actionsAsset(InputActionAsset value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool get_sendPointerHoverToParent() { }

	// RVA: 0x2849970 Offset: 0x2848370 VA: 0x182849970
	public void .ctor() { }

	// RVA: 0x28498E0 Offset: 0x28482E0 VA: 0x1828498E0
	private static void .cctor() { }
}
