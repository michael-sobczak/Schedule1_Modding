internal struct SliderHandler // TypeDefIndex: 17620
{
	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x2D21E10 Offset: 0x2D20810 VA: 0x182D21E10
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x2D20590 Offset: 0x2D1EF90 VA: 0x182D20590
	public float Handle() { }

	// RVA: 0x2D208F0 Offset: 0x2D1F2F0 VA: 0x182D208F0
	private float OnMouseDown() { }

	// RVA: 0x2D20DB0 Offset: 0x2D1F7B0 VA: 0x182D20DB0
	private float OnMouseDrag() { }

	// RVA: 0x2D20EF0 Offset: 0x2D1F8F0 VA: 0x182D20EF0
	private float OnMouseUp() { }

	// RVA: 0x2D20F80 Offset: 0x2D1F980 VA: 0x182D20F80
	private float OnRepaint() { }

	// RVA: 0x2D204B0 Offset: 0x2D1EEB0 VA: 0x182D204B0
	private EventType CurrentEventType() { }

	// RVA: 0x2D204F0 Offset: 0x2D1EEF0 VA: 0x182D204F0
	private int CurrentScrollTroughSide() { }

	// RVA: 0x2D20820 Offset: 0x2D1F220 VA: 0x182D20820
	private bool IsEmptySlider() { }

	// RVA: 0x2D217E0 Offset: 0x2D201E0 VA: 0x182D217E0
	private bool SupportsPageMovements() { }

	// RVA: 0x2D21520 Offset: 0x2D1FF20 VA: 0x182D21520
	private float PageMovementValue() { }

	// RVA: 0x2D21630 Offset: 0x2D20030 VA: 0x182D21630
	private float PageUpMovementBound() { }

	// RVA: 0x2D204E0 Offset: 0x2D1EEE0 VA: 0x182D204E0
	private Event CurrentEvent() { }

	// RVA: 0x2D21A40 Offset: 0x2D20440 VA: 0x182D21A40
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x2D20450 Offset: 0x2D1EE50 VA: 0x182D20450
	private float Clamp(float value) { }

	// RVA: 0x2D21930 Offset: 0x2D20330 VA: 0x182D21930
	private Rect ThumbSelectionRect() { }

	// RVA: 0x2D21780 Offset: 0x2D20180 VA: 0x182D21780
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x2D21690 Offset: 0x2D20090 VA: 0x182D21690
	private SliderState SliderState() { }

	// RVA: 0x2D21840 Offset: 0x2D20240 VA: 0x182D21840
	private Rect ThumbExtRect() { }

	// RVA: 0x2D21930 Offset: 0x2D20330 VA: 0x182D21930
	private Rect ThumbRect() { }

	// RVA: 0x2D21C30 Offset: 0x2D20630 VA: 0x182D21C30
	private Rect VerticalThumbRect() { }

	// RVA: 0x2D20640 Offset: 0x2D1F040 VA: 0x182D20640
	private Rect HorizontalThumbRect() { }

	// RVA: 0x2D20480 Offset: 0x2D1EE80 VA: 0x182D20480
	private float ClampedCurrentValue() { }

	// RVA: 0x2D20870 Offset: 0x2D1F270 VA: 0x182D20870
	private float MousePosition() { }

	// RVA: 0x2D21B70 Offset: 0x2D20570 VA: 0x182D21B70
	private float ValuesPerPixel() { }

	// RVA: 0x2D21980 Offset: 0x2D20380 VA: 0x182D21980
	private float ThumbSize() { }

	// RVA: 0x2D20840 Offset: 0x2D1F240 VA: 0x182D20840
	private float MaxValue() { }

	// RVA: 0x2D20860 Offset: 0x2D1F260 VA: 0x182D20860
	private float MinValue() { }
}
