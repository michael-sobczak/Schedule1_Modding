public class DebugUIHandlerPanel : MonoBehaviour // TypeDefIndex: 13968
{
	// Fields
	public Text nameLabel; // 0x20
	public ScrollRect scrollRect; // 0x28
	public RectTransform viewport; // 0x30
	public DebugUIHandlerCanvas Canvas; // 0x38
	private RectTransform m_ScrollTransform; // 0x40
	private RectTransform m_ContentTransform; // 0x48
	private RectTransform m_MaskTransform; // 0x50
	private DebugUIHandlerWidget m_ScrollTarget; // 0x58
	protected internal DebugUI.Panel m_Panel; // 0x60

	// Methods

	// RVA: 0x2A4E160 Offset: 0x2A4CB60 VA: 0x182A4E160
	private void OnEnable() { }

	// RVA: 0x2A4E3E0 Offset: 0x2A4CDE0 VA: 0x182A4E3E0
	internal void SetPanel(DebugUI.Panel panel) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal DebugUI.Panel GetPanel() { }

	// RVA: 0x2A4E2F0 Offset: 0x2A4CCF0 VA: 0x182A4E2F0
	public void SelectNextItem() { }

	// RVA: 0x2A4E360 Offset: 0x2A4CD60 VA: 0x182A4E360
	public void SelectPreviousItem() { }

	// RVA: 0x2A4E230 Offset: 0x2A4CC30 VA: 0x182A4E230
	public void OnScrollbarClicked() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	internal void SetScrollTarget(DebugUIHandlerWidget target) { }

	// RVA: 0x2A4E440 Offset: 0x2A4CE40 VA: 0x182A4E440
	internal void UpdateScroll() { }

	// RVA: 0x2A4DFF0 Offset: 0x2A4C9F0 VA: 0x182A4DFF0
	private float GetYPosInScroll(RectTransform target) { }

	// RVA: 0x2A4DFA0 Offset: 0x2A4C9A0 VA: 0x182A4DFA0
	internal DebugUIHandlerWidget GetFirstItem() { }

	// RVA: 0x2A4E290 Offset: 0x2A4CC90 VA: 0x182A4E290
	public void ResetDebugManager() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
