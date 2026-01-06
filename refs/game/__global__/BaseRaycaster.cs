public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 16561
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Properties
	public abstract Camera eventCamera { get; }
	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x2F45F90 Offset: 0x2F44990 VA: 0x182F45F90 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x2F45F90 Offset: 0x2F44990 VA: 0x182F45F90 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x2F45FA0 Offset: 0x2F449A0 VA: 0x182F45FA0
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x2F45D60 Offset: 0x2F44760 VA: 0x182F45D60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F45C10 Offset: 0x2F44610 VA: 0x182F45C10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F45B10 Offset: 0x2F44510 VA: 0x182F45B10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x5717F0 Offset: 0x5701F0 VA: 0x1805717F0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x5717F0 Offset: 0x5701F0 VA: 0x1805717F0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
