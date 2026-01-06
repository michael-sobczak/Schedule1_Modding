internal class TextSelectingManipulator // TypeDefIndex: 6914
{
	// Fields
	internal TextSelectingUtilities m_SelectingUtilities; // 0x10
	private bool selectAllOnMouseUp; // 0x18
	private TextElement m_TextElement; // 0x20
	private Vector2 m_ClickStartPosition; // 0x28
	private bool m_Dragged; // 0x30
	private bool m_IsClicking; // 0x31
	private const int k_DragThresholdSqr = 16;
	private int m_ConsecutiveMouseDownCount; // 0x34
	private long m_LastMouseDownTimeStamp; // 0x38
	private readonly Event m_ImguiEvent; // 0x40

	// Properties
	internal bool isClicking { get; set; }
	internal int cursorIndex { get; set; }
	internal int selectIndex { get; set; }

	// Methods

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	internal bool get_isClicking() { }

	// RVA: 0x2F0AB40 Offset: 0x2F09540 VA: 0x182F0AB40
	internal void set_isClicking(bool value) { }

	// RVA: 0x2F0A7D0 Offset: 0x2F091D0 VA: 0x182F0A7D0
	public void .ctor(TextElement textElement) { }

	// RVA: 0x2F0AAE0 Offset: 0x2F094E0 VA: 0x182F0AAE0
	internal int get_cursorIndex() { }

	// RVA: 0x2F0AB20 Offset: 0x2F09520 VA: 0x182F0AB20
	internal void set_cursorIndex(int value) { }

	// RVA: 0x2F0AB00 Offset: 0x2F09500 VA: 0x182F0AB00
	internal int get_selectIndex() { }

	// RVA: 0x2F0AB50 Offset: 0x2F09550 VA: 0x182F0AB50
	internal void set_selectIndex(int value) { }

	// RVA: 0x2F0A4F0 Offset: 0x2F08EF0 VA: 0x182F0A4F0
	private void OnRevealCursor() { }

	// RVA: 0x2F0A520 Offset: 0x2F08F20 VA: 0x182F0A520
	private void OnSelectIndexChange() { }

	// RVA: 0x2F09B30 Offset: 0x2F08530 VA: 0x182F09B30
	private void OnCursorIndexChange() { }

	// RVA: 0x2F0A7B0 Offset: 0x2F091B0 VA: 0x182F0A7B0
	internal bool RevealCursor() { }

	// RVA: 0x2F09A70 Offset: 0x2F08470 VA: 0x182F09A70
	internal bool HasSelection() { }

	// RVA: 0x2F09A50 Offset: 0x2F08450 VA: 0x182F09A50
	internal bool HasFocus() { }

	// RVA: 0x2F09390 Offset: 0x2F07D90 VA: 0x182F09390
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x2F09D50 Offset: 0x2F08750 VA: 0x182F09D50
	private void OnFocusEvent(FocusEvent evt) { }

	// RVA: 0x2F09AD0 Offset: 0x2F084D0 VA: 0x182F09AD0
	private void OnBlurEvent(BlurEvent evt) { }

	// RVA: 0x2F09EB0 Offset: 0x2F088B0 VA: 0x182F09EB0
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x2F09F20 Offset: 0x2F08920 VA: 0x182F09F20
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x2F0A2A0 Offset: 0x2F08CA0 VA: 0x182F0A2A0
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x2F0A440 Offset: 0x2F08E40 VA: 0x182F0A440
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x2F0A630 Offset: 0x2F09030 VA: 0x182F0A630
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x2F09C40 Offset: 0x2F08640 VA: 0x182F09C40
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x2F09A90 Offset: 0x2F08490 VA: 0x182F09A90
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }
}
