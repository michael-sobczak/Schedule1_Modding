public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 16514
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Properties
	public IPanel panel { get; set; }
	private GameObject selectableGameObject { get; }
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 23
	public IPanel get_panel() { }

	// RVA: 0x2F4D3F0 Offset: 0x2F4BDF0 VA: 0x182F4D3F0 Slot: 22
	public void set_panel(IPanel value) { }

	// RVA: 0x2F4D1C0 Offset: 0x2F4BBC0 VA: 0x182F4D1C0
	private void RegisterCallbacks() { }

	// RVA: 0x2F4D250 Offset: 0x2F4BC50 VA: 0x182F4D250
	private void UnregisterCallbacks() { }

	// RVA: 0x2F4CB60 Offset: 0x2F4B560 VA: 0x182F4CB60
	private void OnPanelDestroyed() { }

	// RVA: 0x2F4D360 Offset: 0x2F4BD60 VA: 0x182F4D360
	private GameObject get_selectableGameObject() { }

	// RVA: 0x2F4D380 Offset: 0x2F4BD80 VA: 0x182F4D380 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x2F4D2E0 Offset: 0x2F4BCE0 VA: 0x182F4D2E0 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x2F4CC90 Offset: 0x2F4B690 VA: 0x182F4CC90 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
