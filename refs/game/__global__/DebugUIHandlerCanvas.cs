public class DebugUIHandlerCanvas : MonoBehaviour // TypeDefIndex: 13949
{
	// Fields
	private int m_DebugTreeState; // 0x20
	private Dictionary<Type, Transform> m_PrefabsMap; // 0x28
	public Transform panelPrefab; // 0x30
	public List<DebugUIPrefabBundle> prefabs; // 0x38
	private List<DebugUIHandlerPanel> m_UIPanels; // 0x40
	private int m_SelectedPanel; // 0x48
	private DebugUIHandlerWidget m_SelectedWidget; // 0x50
	private string m_CurrentQueryPath; // 0x58

	// Methods

	// RVA: 0x2A48C50 Offset: 0x2A47650 VA: 0x182A48C50
	private void OnEnable() { }

	// RVA: 0x2A4A090 Offset: 0x2A48A90 VA: 0x182A4A090
	private void Update() { }

	// RVA: 0x1663D60 Offset: 0x1662760 VA: 0x181663D60
	internal void RequestHierarchyReset() { }

	// RVA: 0x2A495A0 Offset: 0x2A47FA0 VA: 0x182A495A0
	private void ResetAllHierarchy() { }

	// RVA: 0x2A48DA0 Offset: 0x2A477A0 VA: 0x182A48DA0
	private void Rebuild() { }

	// RVA: 0x2A49B30 Offset: 0x2A48530 VA: 0x182A49B30
	private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler) { }

	// RVA: 0x2A48720 Offset: 0x2A47120 VA: 0x182A48720
	private DebugUIHandlerWidget GetWidgetFromPath(string queryPath) { }

	// RVA: 0x2A480F0 Offset: 0x2A46AF0 VA: 0x182A480F0
	private void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget) { }

	// RVA: 0x2A484D0 Offset: 0x2A46ED0 VA: 0x182A484D0
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	// RVA: 0x2A49920 Offset: 0x2A48320 VA: 0x182A49920
	internal void SelectPreviousItem() { }

	// RVA: 0x2A498B0 Offset: 0x2A482B0 VA: 0x182A498B0
	internal void SelectNextPanel() { }

	// RVA: 0x2A499E0 Offset: 0x2A483E0 VA: 0x182A499E0
	internal void SelectPreviousPanel() { }

	// RVA: 0x2A497F0 Offset: 0x2A481F0 VA: 0x182A497F0
	internal void SelectNextItem() { }

	// RVA: 0x2A483C0 Offset: 0x2A46DC0 VA: 0x182A483C0
	private void ChangeSelectionValue(float multiplier) { }

	// RVA: 0x2A48340 Offset: 0x2A46D40 VA: 0x182A48340
	private void ActivateSelection() { }

	// RVA: 0x2A48860 Offset: 0x2A47260 VA: 0x182A48860
	private void HandleInput() { }

	// RVA: 0x2A49A50 Offset: 0x2A48450 VA: 0x182A49A50
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
