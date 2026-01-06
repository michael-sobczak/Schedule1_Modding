internal class ColumnMover : PointerManipulator // TypeDefIndex: 7215
{
	// Fields
	private float m_StartPos; // 0x38
	private float m_LastPos; // 0x3C
	private bool m_Active; // 0x40
	private bool m_Moving; // 0x41
	private bool m_Cancelled; // 0x42
	private MultiColumnCollectionHeader m_Header; // 0x48
	private VisualElement m_PreviewElement; // 0x50
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x58
	private Column m_ColumnToMove; // 0x60
	private float m_ColumnToMovePos; // 0x68
	private float m_ColumnToMoveWidth; // 0x6C
	private Column m_DestinationColumn; // 0x70
	private bool m_MoveBeforeDestination; // 0x78
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ColumnLayout <columnLayout>k__BackingField; // 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ColumnMover> activeChanged; // 0x88
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<ColumnMover> movingChanged; // 0x90

	// Properties
	public ColumnLayout columnLayout { get; set; }
	public bool active { get; set; }
	public bool moving { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_active() { }

	// RVA: 0x2E426A0 Offset: 0x2E410A0 VA: 0x182E426A0
	public void set_active(bool value) { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	public bool get_moving() { }

	// RVA: 0x2E426D0 Offset: 0x2E410D0 VA: 0x182E426D0
	public void set_moving(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E423A0 Offset: 0x2E40DA0 VA: 0x182E423A0
	public void add_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x2E42520 Offset: 0x2E40F20 VA: 0x182E42520
	public void remove_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x2E42460 Offset: 0x2E40E60 VA: 0x182E42460
	public void add_movingChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x2E425E0 Offset: 0x2E40FE0 VA: 0x182E425E0
	public void remove_movingChanged(Action<ColumnMover> value) { }

	// RVA: 0x2E422B0 Offset: 0x2E40CB0 VA: 0x182E422B0
	public void .ctor() { }

	// RVA: 0x2E41450 Offset: 0x2E3FE50 VA: 0x182E41450 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x2E41910 Offset: 0x2E40310 VA: 0x182E41910 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x2E40780 Offset: 0x2E3F180 VA: 0x182E40780
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x2E40850 Offset: 0x2E3F250 VA: 0x182E40850
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x2E408C0 Offset: 0x2E3F2C0 VA: 0x182E408C0
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x2E40700 Offset: 0x2E3F100 VA: 0x182E40700
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x2E40B30 Offset: 0x2E3F530 VA: 0x182E40B30
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x2E40C50 Offset: 0x2E3F650 VA: 0x182E40C50
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x2E40D60 Offset: 0x2E3F760 VA: 0x182E40D60
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2E409A0 Offset: 0x2E3F3A0 VA: 0x182E409A0
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x2E40A70 Offset: 0x2E3F470 VA: 0x182E40A70
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x2E405C0 Offset: 0x2E3EFC0 VA: 0x182E405C0
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x2E40E90 Offset: 0x2E3F890 VA: 0x182E40E90
	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x2E40620 Offset: 0x2E3F020 VA: 0x182E40620
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x2E40FF0 Offset: 0x2E3F9F0 VA: 0x182E40FF0
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x2E41200 Offset: 0x2E3FC00 VA: 0x182E41200
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	// RVA: 0x2E41340 Offset: 0x2E3FD40 VA: 0x182E41340
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x2E3FF20 Offset: 0x2E3E920 VA: 0x182E3FF20
	private void BeginDragMove(float pos) { }

	// RVA: 0x2E40450 Offset: 0x2E3EE50 VA: 0x182E40450
	internal void DragMove(float pos) { }

	// RVA: 0x2E41FC0 Offset: 0x2E409C0 VA: 0x182E41FC0
	private void UpdatePreviewPosition() { }

	// RVA: 0x2E41DD0 Offset: 0x2E407D0 VA: 0x182E41DD0
	private void UpdateMoveLocation() { }

	// RVA: 0x2E40460 Offset: 0x2E3EE60 VA: 0x182E40460
	private void EndDragMove(bool cancelled) { }
}
