public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 16555
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x58
	private readonly PointerInputModule.MouseState m_MouseState; // 0x60

	// Methods

	// RVA: 0x2F50A20 Offset: 0x2F4F420 VA: 0x182F50A20
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x2F51320 Offset: 0x2F4FD20 VA: 0x182F51320
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x2F50B20 Offset: 0x2F4F520 VA: 0x182F50B20
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x2F50040 Offset: 0x2F4EA40 VA: 0x182F50040
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x2F513D0 Offset: 0x2F4FDD0 VA: 0x182F513D0
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x2F502B0 Offset: 0x2F4ECB0 VA: 0x182F502B0 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x2F502D0 Offset: 0x2F4ECD0 VA: 0x182F502D0 Slot: 28
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x2F50280 Offset: 0x2F4EC80 VA: 0x182F50280
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x2F51380 Offset: 0x2F4FD80 VA: 0x182F51380
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x2F512D0 Offset: 0x2F4FCD0 VA: 0x182F512D0 Slot: 29
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x2F51010 Offset: 0x2F4FA10 VA: 0x182F51010 Slot: 30
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x2F50F80 Offset: 0x2F4F980 VA: 0x182F50F80 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x2F4FEA0 Offset: 0x2F4E8A0 VA: 0x182F4FEA0
	protected void ClearSelection() { }

	// RVA: 0x2F51490 Offset: 0x2F4FE90 VA: 0x182F51490 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F501A0 Offset: 0x2F4EBA0 VA: 0x182F501A0
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x2F51710 Offset: 0x2F50110 VA: 0x182F51710
	protected void .ctor() { }
}
