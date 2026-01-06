public class TouchInputModule : PointerInputModule // TypeDefIndex: 16558
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private PointerEventData m_InputPointerEvent; // 0x78
	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	private bool m_ForceModuleActive; // 0x80

	// Properties
	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x2F56C90 Offset: 0x2F55690 VA: 0x182F56C90
	protected void .ctor() { }

	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x779970 Offset: 0x778370 VA: 0x180779970
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_forceModuleActive() { }

	// RVA: 0x779970 Offset: 0x778370 VA: 0x180779970
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x2F56AE0 Offset: 0x2F554E0 VA: 0x182F56AE0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x2F556A0 Offset: 0x2F540A0 VA: 0x182F556A0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x2F56710 Offset: 0x2F55110 VA: 0x182F56710 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x2F56C50 Offset: 0x2F55650 VA: 0x182F56C50
	private bool UseFakeInput() { }

	// RVA: 0x2F56550 Offset: 0x2F54F50 VA: 0x182F56550 Slot: 17
	public override void Process() { }

	// RVA: 0x2F55530 Offset: 0x2F53F30 VA: 0x182F55530
	private void FakeTouches() { }

	// RVA: 0x2F556F0 Offset: 0x2F540F0 VA: 0x182F556F0
	private void ProcessTouchEvents() { }

	// RVA: 0x2F55E70 Offset: 0x2F54870 VA: 0x182F55E70
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x2F52C70 Offset: 0x2F51670 VA: 0x182F52C70 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x2F56830 Offset: 0x2F55230 VA: 0x182F56830 Slot: 3
	public override string ToString() { }
}
