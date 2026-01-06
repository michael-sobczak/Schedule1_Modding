internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop // TypeDefIndex: 6461
{
	// Fields
	private readonly Hashtable m_GenericData; // 0x10
	private Label m_DraggedInfoLabel; // 0x18
	private DragVisualMode m_VisualMode; // 0x20
	private IEnumerable<Object> m_UnityObjectReferences; // 0x28

	// Properties
	public override object source { get; }
	public DragAndDropData data { get; }

	// Methods

	// RVA: 0x2E89500 Offset: 0x2E87F00 VA: 0x182E89500 Slot: 5
	public override object get_source() { }

	// RVA: 0x2E88C30 Offset: 0x2E87630 VA: 0x182E88C30 Slot: 4
	public override object GetGenericData(string key) { }

	// RVA: 0x2E88CA0 Offset: 0x2E876A0 VA: 0x182E88CA0 Slot: 6
	public void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	// RVA: 0x2E892B0 Offset: 0x2E87CB0 VA: 0x182E892B0 Slot: 7
	public void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public void AcceptDrag() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490 Slot: 10
	public void SetVisualMode(DragVisualMode mode) { }

	// RVA: 0x2E88BD0 Offset: 0x2E875D0 VA: 0x182E88BD0 Slot: 9
	public void DragCleanup() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 11
	public DragAndDropData get_data() { }

	// RVA: 0x2E89490 Offset: 0x2E87E90 VA: 0x182E89490
	public void .ctor() { }
}
