public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 16398
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics; // 0x28
	[SerializeField]
	[FormerlySerializedAs("blockingObjects")]
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x2C
	[SerializeField]
	protected LayerMask m_BlockingMask; // 0x30
	private Canvas m_Canvas; // 0x38
	private List<Graphic> m_RaycastResults; // 0x40
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	public LayerMask blockingMask { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x2D9B2A0 Offset: 0x2D99CA0 VA: 0x182D9B2A0 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x2D9B240 Offset: 0x2D99C40 VA: 0x182D9B240 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public LayerMask get_blockingMask() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x2D9B060 Offset: 0x2D99A60 VA: 0x182D9B060
	protected void .ctor() { }

	// RVA: 0x2D9B0F0 Offset: 0x2D99AF0 VA: 0x182D9B0F0
	private Canvas get_canvas() { }

	// RVA: 0x2D9A130 Offset: 0x2D98B30 VA: 0x182D9A130 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x2D9B180 Offset: 0x2D99B80 VA: 0x182D9B180 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x2D99B50 Offset: 0x2D98550 VA: 0x182D99B50
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x2D9AFD0 Offset: 0x2D999D0 VA: 0x182D9AFD0
	private static void .cctor() { }
}
