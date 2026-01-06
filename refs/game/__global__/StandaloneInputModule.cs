public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 16557
{
	// Fields
	private float m_PrevActionTime; // 0x68
	private Vector2 m_LastMoveVector; // 0x6C
	private int m_ConsecutiveMoveCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private Vector2 m_MousePosition; // 0x80
	private GameObject m_CurrentFocusedGameObject; // 0x88
	private PointerEventData m_InputPointerEvent; // 0x90
	private const float doubleClickTime = 0.3;
	[SerializeField]
	private string m_HorizontalAxis; // 0x98
	[SerializeField]
	private string m_VerticalAxis; // 0xA0
	[SerializeField]
	private string m_SubmitButton; // 0xA8
	[SerializeField]
	private string m_CancelButton; // 0xB0
	[SerializeField]
	private float m_InputActionsPerSecond; // 0xB8
	[SerializeField]
	private float m_RepeatDelay; // 0xBC
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	private bool m_ForceModuleActive; // 0xC0

	// Properties
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public StandaloneInputModule.InputMode inputMode { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice { get; set; }
	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x2F55440 Offset: 0x2F53E40 VA: 0x182F55440
	protected void .ctor() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x4E8DF0 Offset: 0x4E77F0 VA: 0x1804E8DF0
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_forceModuleActive() { }

	// RVA: 0x4E8DF0 Offset: 0x4E77F0 VA: 0x1804E8DF0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x4F2360 Offset: 0x4F0D60 VA: 0x1804F2360
	public float get_inputActionsPerSecond() { }

	// RVA: 0x8B5710 Offset: 0x8B4110 VA: 0x1808B5710
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x4F2430 Offset: 0x4F0E30 VA: 0x1804F2430
	public float get_repeatDelay() { }

	// RVA: 0x8B5720 Offset: 0x8B4120 VA: 0x1808B5720
	public void set_repeatDelay(float value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_horizontalAxis() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	public void set_horizontalAxis(string value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public string get_verticalAxis() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_verticalAxis(string value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public string get_submitButton() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	public void set_submitButton(string value) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public string get_cancelButton() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_cancelButton(string value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x2F552F0 Offset: 0x2F53CF0 VA: 0x182F552F0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x2F545E0 Offset: 0x2F52FE0 VA: 0x182F545E0
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x2F550B0 Offset: 0x2F53AB0 VA: 0x182F550B0 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x2F52B10 Offset: 0x2F51510 VA: 0x182F52B10 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x2F52C70 Offset: 0x2F51670 VA: 0x182F52C70 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x2F54400 Offset: 0x2F52E00 VA: 0x182F54400 Slot: 17
	public override void Process() { }

	// RVA: 0x2F53510 Offset: 0x2F51F10 VA: 0x182F53510
	private bool ProcessTouchEvents() { }

	// RVA: 0x2F53CE0 Offset: 0x2F526E0 VA: 0x182F53CE0
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x2F54D10 Offset: 0x2F53710 VA: 0x182F54D10
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x2F52C80 Offset: 0x2F51680 VA: 0x182F52C80
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x2F549A0 Offset: 0x2F533A0 VA: 0x182F549A0
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x2F530B0 Offset: 0x2F51AB0 VA: 0x182F530B0
	protected void ProcessMouseEvent() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 31
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x2F52DF0 Offset: 0x2F517F0 VA: 0x182F52DF0
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x2F54F60 Offset: 0x2F53960 VA: 0x182F54F60
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x2F530C0 Offset: 0x2F51AC0 VA: 0x182F530C0
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	protected GameObject GetCurrentFocusedGameObject() { }
}
