public class Clickable : PointerManipulator // TypeDefIndex: 6179
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<EventBase> clickedWithEventInfo; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action clicked; // 0x40
	private readonly long m_Delay; // 0x48
	private readonly long m_Interval; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <active>k__BackingField; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <lastMousePosition>k__BackingField; // 0x5C
	private int m_ActivePointerId; // 0x64
	private bool m_AcceptClicksIfDisabled; // 0x68
	private IVisualElementScheduledItem m_Repeater; // 0x70

	// Properties
	protected bool active { get; set; }
	public Vector2 lastMousePosition { get; set; }
	internal bool acceptClicksIfDisabled { get; set; }
	private InvokePolicy invokePolicy { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2DB5510 Offset: 0x2DB3F10 VA: 0x182DB5510
	public void add_clickedWithEventInfo(Action<EventBase> value) { }

	[CompilerGenerated]
	// RVA: 0x2DB5690 Offset: 0x2DB4090 VA: 0x182DB5690
	public void remove_clickedWithEventInfo(Action<EventBase> value) { }

	[CompilerGenerated]
	// RVA: 0x2DB55C0 Offset: 0x2DB3FC0 VA: 0x182DB55C0
	public void add_clicked(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2DB5740 Offset: 0x2DB4140 VA: 0x182DB5740
	public void remove_clicked(Action value) { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	protected bool get_active() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	protected void set_active(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2DB5670 Offset: 0x2DB4070 VA: 0x182DB5670
	public Vector2 get_lastMousePosition() { }

	[CompilerGenerated]
	// RVA: 0x1A7B080 Offset: 0x1A79A80 VA: 0x181A7B080
	private void set_lastMousePosition(Vector2 value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	internal bool get_acceptClicksIfDisabled() { }

	// RVA: 0x2DB57E0 Offset: 0x2DB41E0 VA: 0x182DB57E0
	internal void set_acceptClicksIfDisabled(bool value) { }

	// RVA: 0x2DB5660 Offset: 0x2DB4060 VA: 0x182DB5660
	private InvokePolicy get_invokePolicy() { }

	// RVA: 0x2DB5180 Offset: 0x2DB3B80 VA: 0x182DB5180
	public void .ctor(Action handler, long delay, long interval) { }

	// RVA: 0x2DB52C0 Offset: 0x2DB3CC0 VA: 0x182DB52C0
	public void .ctor(Action<EventBase> handler) { }

	// RVA: 0x2DB53E0 Offset: 0x2DB3DE0 VA: 0x182DB53E0
	public void .ctor(Action handler) { }

	// RVA: 0x2DB3F90 Offset: 0x2DB2990 VA: 0x182DB3F90
	private void OnTimer(TimerState timerState) { }

	// RVA: 0x2DB3770 Offset: 0x2DB2170 VA: 0x182DB3770
	private bool IsRepeatable() { }

	// RVA: 0x2DB46C0 Offset: 0x2DB30C0 VA: 0x182DB46C0 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x2DB4D40 Offset: 0x2DB3740 VA: 0x182DB4D40 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x2DB3820 Offset: 0x2DB2220 VA: 0x182DB3820
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x2DB3900 Offset: 0x2DB2300 VA: 0x182DB3900
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x2DB3980 Offset: 0x2DB2380 VA: 0x182DB3980
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x2DB3790 Offset: 0x2DB2190 VA: 0x182DB3790
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x2DB3C20 Offset: 0x2DB2620 VA: 0x182DB3C20
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x2DB3D50 Offset: 0x2DB2750 VA: 0x182DB3D50
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x2DB3E60 Offset: 0x2DB2860 VA: 0x182DB3E60
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2DB3A70 Offset: 0x2DB2470 VA: 0x182DB3A70
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x2DB3B50 Offset: 0x2DB2550 VA: 0x182DB3B50
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x2DB3640 Offset: 0x2DB2040 VA: 0x182DB3640
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x2DB3710 Offset: 0x2DB2110 VA: 0x182DB3710
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x2DB36C0 Offset: 0x2DB20C0 VA: 0x182DB36C0
	protected void Invoke(EventBase evt) { }

	// RVA: 0x2DB4B90 Offset: 0x2DB3590 VA: 0x182DB4B90
	internal void SimulateSingleClick(EventBase evt, int delayMs = 100) { }

	// RVA: 0x2DB41C0 Offset: 0x2DB2BC0 VA: 0x182DB41C0 Slot: 8
	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x2DB44A0 Offset: 0x2DB2EA0 VA: 0x182DB44A0 Slot: 9
	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	// RVA: 0x2DB4530 Offset: 0x2DB2F30 VA: 0x182DB4530 Slot: 10
	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x2DB40A0 Offset: 0x2DB2AA0 VA: 0x182DB40A0 Slot: 11
	protected virtual void ProcessCancelEvent(EventBase evt, int pointerId) { }

	[CompilerGenerated]
	// RVA: 0x2DB4D00 Offset: 0x2DB3700 VA: 0x182DB4D00
	private void <SimulateSingleClick>b__43_0() { }
}
