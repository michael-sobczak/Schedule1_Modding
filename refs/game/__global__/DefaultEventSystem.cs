internal class DefaultEventSystem // TypeDefIndex: 6457
{
	// Fields
	internal static Func<bool> IsEditorRemoteConnected; // 0x0
	private DefaultEventSystem.IInput m_Input; // 0x10
	private readonly string m_HorizontalAxis; // 0x18
	private readonly string m_VerticalAxis; // 0x20
	private readonly string m_SubmitButton; // 0x28
	private readonly string m_CancelButton; // 0x30
	private readonly float m_InputActionsPerSecond; // 0x38
	private readonly float m_RepeatDelay; // 0x3C
	private bool m_SendingTouchEvents; // 0x40
	private bool m_SendingPenEvent; // 0x41
	private Event m_Event; // 0x48
	private BaseRuntimePanel m_FocusedPanel; // 0x50
	private BaseRuntimePanel m_PreviousFocusedPanel; // 0x58
	private Focusable m_PreviousFocusedElement; // 0x60
	private EventModifiers m_CurrentModifiers; // 0x68
	private int m_LastMousePressButton; // 0x6C
	private float m_NextMousePressTime; // 0x70
	private int m_LastMouseClickCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private bool m_MouseProcessedAtLeastOnce; // 0x80
	private int m_ConsecutiveMoveCount; // 0x84
	private Vector2 m_LastMoveVector; // 0x88
	private float m_PrevActionTime; // 0x90
	private bool m_IsMoveFromKeyboard; // 0x94

	// Properties
	private bool isAppFocused { get; }
	internal DefaultEventSystem.IInput input { get; }
	public BaseRuntimePanel focusedPanel { get; set; }

	// Methods

	// RVA: 0x2E72E60 Offset: 0x2E71860 VA: 0x182E72E60
	private bool get_isAppFocused() { }

	// RVA: 0x2E72E20 Offset: 0x2E71820 VA: 0x182E72E20
	internal DefaultEventSystem.IInput get_input() { }

	// RVA: 0x2E70110 Offset: 0x2E6EB10 VA: 0x182E70110
	private DefaultEventSystem.IInput GetDefaultInput() { }

	// RVA: 0x2E726F0 Offset: 0x2E710F0 VA: 0x182E726F0
	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public BaseRuntimePanel get_focusedPanel() { }

	// RVA: 0x2E705D0 Offset: 0x2E6EFD0 VA: 0x182E705D0
	public void set_focusedPanel(BaseRuntimePanel value) { }

	// RVA: 0x2E72AC0 Offset: 0x2E714C0 VA: 0x182E72AC0
	public void Update(DefaultEventSystem.UpdateMode updateMode = 0) { }

	// RVA: 0x2E700E0 Offset: 0x2E6EAE0 VA: 0x182E700E0
	internal DefaultEventSystem.FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	// RVA: 0x2E71B40 Offset: 0x2E70540 VA: 0x182E71B40
	private void SendIMGUIEvents() { }

	// RVA: 0x2E70630 Offset: 0x2E6F030 VA: 0x182E70630
	private void ProcessMouseEvents() { }

	// RVA: 0x2E723A0 Offset: 0x2E70DA0 VA: 0x182E723A0
	private void SendInputEvents() { }

	// RVA: 0x2E705D0 Offset: 0x2E6EFD0 VA: 0x182E705D0
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	// RVA: -1 Offset: -1
	internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7AC10 Offset: 0xE79610 VA: 0x180E7AC10
	|-DefaultEventSystem.SendFocusBasedEvent<ValueTuple<Int32Enum, Int32Enum, object>>
	|
	|-RVA: 0xE7A7E0 Offset: 0xE791E0 VA: 0x180E7A7E0
	|-DefaultEventSystem.SendFocusBasedEvent<object>
	|
	|-RVA: 0xE7A2D0 Offset: 0xE78CD0 VA: 0x180E7A2D0
	|-DefaultEventSystem.SendFocusBasedEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<int> targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7D270 Offset: 0xE7BC70 VA: 0x180E7D270
	|-DefaultEventSystem.SendPositionBasedEvent<ValueTuple<Int32Enum, Vector2>>
	|-DefaultEventSystem.SendPositionBasedEvent<ValueTuple<int, int, Int32Enum>>
	|
	|-RVA: 0xE7C1B0 Offset: 0xE7ABB0 VA: 0x180E7C1B0
	|-DefaultEventSystem.SendPositionBasedEvent<object>
	|
	|-RVA: 0xE7B940 Offset: 0xE7A340 VA: 0x180E7B940
	|-DefaultEventSystem.SendPositionBasedEvent<PenData>
	|
	|-RVA: 0xE7C9F0 Offset: 0xE7B3F0 VA: 0x180E7C9F0
	|-DefaultEventSystem.SendPositionBasedEvent<Touch>
	|
	|-RVA: 0xE7B060 Offset: 0xE79A60 VA: 0x180E7B060
	|-DefaultEventSystem.SendPositionBasedEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E72A10 Offset: 0x2E71410 VA: 0x182E72A10
	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) { }

	// RVA: 0x2E704C0 Offset: 0x2E6EEC0 VA: 0x182E704C0
	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x2E703D0 Offset: 0x2E6EDD0 VA: 0x182E703D0
	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x2E71600 Offset: 0x2E70000 VA: 0x182E71600
	private bool ProcessTouchEvents() { }

	// RVA: 0x2E71080 Offset: 0x2E6FA80 VA: 0x182E71080
	private bool ProcessPenEvents() { }

	// RVA: 0x2E701F0 Offset: 0x2E6EBF0 VA: 0x182E701F0
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x2E72710 Offset: 0x2E71110 VA: 0x182E72710
	private bool ShouldSendMoveFromInput() { }

	// RVA: 0x2E71430 Offset: 0x2E6FE30 VA: 0x182E71430
	private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

	// RVA: 0x2E72CC0 Offset: 0x2E716C0 VA: 0x182E72CC0
	public void .ctor() { }

	// RVA: 0x2E72BF0 Offset: 0x2E715F0 VA: 0x182E72BF0
	private static void .cctor() { }
}
