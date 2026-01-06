public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 16564
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x28
	[SerializeField]
	protected LayerMask m_EventMask; // 0x30
	[SerializeField]
	protected int m_MaxRayIntersections; // 0x34
	protected int m_LastMaxRayIntersections; // 0x38
	private RaycastHit[] m_Hits; // 0x40

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x2F4DDA0 Offset: 0x2F4C7A0 VA: 0x182F4DDA0
	protected void .ctor() { }

	// RVA: 0x2F4E730 Offset: 0x2F4D130 VA: 0x182F4E730 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x2F4E670 Offset: 0x2F4D070 VA: 0x182F4E670 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x2F4E800 Offset: 0x2F4D200 VA: 0x182F4E800
	public int get_finalEventMask() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public LayerMask get_eventMask() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_maxRayIntersections() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x2F4DDD0 Offset: 0x2F4C7D0 VA: 0x182F4DDD0
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x2F4E160 Offset: 0x2F4CB60 VA: 0x182F4E160 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}
