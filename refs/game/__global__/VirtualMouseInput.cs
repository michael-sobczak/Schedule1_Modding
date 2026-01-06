public class VirtualMouseInput : MonoBehaviour // TypeDefIndex: 7527
{
	// Fields
	[Header("Cursor")]
	[SerializeField]
	[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by 'Cursor Graphic') will be hidden.")]
	private VirtualMouseInput.CursorMode m_CursorMode; // 0x20
	[SerializeField]
	[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see 'Cursor Mode') is used.")]
	private Graphic m_CursorGraphic; // 0x28
	[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see 'Cursor Mode'). Moving the cursor updates the anchored position of the transform.")]
	[SerializeField]
	private RectTransform m_CursorTransform; // 0x30
	[SerializeField]
	[Header("Motion")]
	[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from 'Stick Action'.")]
	private float m_CursorSpeed; // 0x38
	[SerializeField]
	[Tooltip("Scale factor to apply to 'Scroll Wheel Action' when setting the mouse 'scrollWheel' control.")]
	private float m_ScrollSpeed; // 0x3C
	[SerializeField]
	[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
	[Space(10)]
	private InputActionProperty m_StickAction; // 0x40
	[SerializeField]
	[Tooltip("Button action that triggers a left-click on the mouse.")]
	private InputActionProperty m_LeftButtonAction; // 0x58
	[Tooltip("Button action that triggers a middle-click on the mouse.")]
	[SerializeField]
	private InputActionProperty m_MiddleButtonAction; // 0x70
	[SerializeField]
	[Tooltip("Button action that triggers a right-click on the mouse.")]
	private InputActionProperty m_RightButtonAction; // 0x88
	[SerializeField]
	[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
	private InputActionProperty m_ForwardButtonAction; // 0xA0
	[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
	[SerializeField]
	private InputActionProperty m_BackButtonAction; // 0xB8
	[Tooltip("Vector2 action that feeds into the mouse 'scrollWheel' action (scaled by 'Scroll Speed').")]
	[SerializeField]
	private InputActionProperty m_ScrollWheelAction; // 0xD0
	private Canvas m_Canvas; // 0xE8
	private Mouse m_VirtualMouse; // 0xF0
	private Mouse m_SystemMouse; // 0xF8
	private Action m_AfterInputUpdateDelegate; // 0x100
	private Action<InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x108
	private double m_LastTime; // 0x110
	private Vector2 m_LastStickValue; // 0x118

	// Properties
	public RectTransform cursorTransform { get; set; }
	public float cursorSpeed { get; set; }
	public VirtualMouseInput.CursorMode cursorMode { get; set; }
	public Graphic cursorGraphic { get; set; }
	public float scrollSpeed { get; set; }
	public Mouse virtualMouse { get; }
	public InputActionProperty stickAction { get; set; }
	public InputActionProperty leftButtonAction { get; set; }
	public InputActionProperty rightButtonAction { get; set; }
	public InputActionProperty middleButtonAction { get; set; }
	public InputActionProperty forwardButtonAction { get; set; }
	public InputActionProperty backButtonAction { get; set; }
	public InputActionProperty scrollWheelAction { get; set; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public RectTransform get_cursorTransform() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_cursorTransform(RectTransform value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_cursorSpeed() { }

	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	public void set_cursorSpeed(float value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public VirtualMouseInput.CursorMode get_cursorMode() { }

	// RVA: 0x28534F0 Offset: 0x2851EF0 VA: 0x1828534F0
	public void set_cursorMode(VirtualMouseInput.CursorMode value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Graphic get_cursorGraphic() { }

	// RVA: 0x2853480 Offset: 0x2851E80 VA: 0x182853480
	public void set_cursorGraphic(Graphic value) { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_scrollSpeed() { }

	// RVA: 0x4E2CE0 Offset: 0x4E16E0 VA: 0x1804E2CE0
	public void set_scrollSpeed(float value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public Mouse get_virtualMouse() { }

	// RVA: 0x1BB9720 Offset: 0x1BB8120 VA: 0x181BB9720
	public InputActionProperty get_stickAction() { }

	// RVA: 0x2853A60 Offset: 0x2852460 VA: 0x182853A60
	public void set_stickAction(InputActionProperty value) { }

	// RVA: 0x2853330 Offset: 0x2851D30 VA: 0x182853330
	public InputActionProperty get_leftButtonAction() { }

	// RVA: 0x2853710 Offset: 0x2852110 VA: 0x182853710
	public void set_leftButtonAction(InputActionProperty value) { }

	// RVA: 0x143EEE0 Offset: 0x143D8E0 VA: 0x18143EEE0
	public InputActionProperty get_rightButtonAction() { }

	// RVA: 0x2853920 Offset: 0x2852320 VA: 0x182853920
	public void set_rightButtonAction(InputActionProperty value) { }

	// RVA: 0x2853350 Offset: 0x2851D50 VA: 0x182853350
	public InputActionProperty get_middleButtonAction() { }

	// RVA: 0x2853810 Offset: 0x2852210 VA: 0x182853810
	public void set_middleButtonAction(InputActionProperty value) { }

	// RVA: 0x143EE00 Offset: 0x143D800 VA: 0x18143EE00
	public InputActionProperty get_forwardButtonAction() { }

	// RVA: 0x2853600 Offset: 0x2852000 VA: 0x182853600
	public void set_forwardButtonAction(InputActionProperty value) { }

	// RVA: 0x222AFA0 Offset: 0x22299A0 VA: 0x18222AFA0
	public InputActionProperty get_backButtonAction() { }

	// RVA: 0x2853370 Offset: 0x2851D70 VA: 0x182853370
	public void set_backButtonAction(InputActionProperty value) { }

	// RVA: 0x222AD90 Offset: 0x2229790 VA: 0x18222AD90
	public InputActionProperty get_scrollWheelAction() { }

	// RVA: 0x2853A30 Offset: 0x2852430 VA: 0x182853A30
	public void set_scrollWheelAction(InputActionProperty value) { }

	// RVA: 0x2852520 Offset: 0x2850F20 VA: 0x182852520
	protected void OnEnable() { }

	// RVA: 0x2852190 Offset: 0x2850B90 VA: 0x182852190
	protected void OnDisable() { }

	// RVA: 0x2852EA0 Offset: 0x28518A0 VA: 0x182852EA0
	private void TryFindCanvas() { }

	// RVA: 0x2852C50 Offset: 0x2851650 VA: 0x182852C50
	private void TryEnableHardwareCursor() { }

	// RVA: 0x2852F00 Offset: 0x2851900 VA: 0x182852F00
	private void UpdateMotion() { }

	// RVA: 0x2851FA0 Offset: 0x28509A0 VA: 0x182851FA0
	private void OnButtonActionTriggered(InputAction.CallbackContext context) { }

	// RVA: 0x2852AB0 Offset: 0x28514B0 VA: 0x182852AB0
	private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = True) { }

	// RVA: 0x2852B30 Offset: 0x2851530 VA: 0x182852B30
	private static void SetAction(ref InputActionProperty field, InputActionProperty value) { }

	// RVA: 0x2851F90 Offset: 0x2850990 VA: 0x182851F90
	private void OnAfterInputUpdate() { }

	// RVA: 0x2853310 Offset: 0x2851D10 VA: 0x182853310
	public void .ctor() { }
}
