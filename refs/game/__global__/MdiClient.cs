public sealed class MdiClient : Control // TypeDefIndex: 5479
{
	// Fields
	private ImplicitHScrollBar hbar; // 0x1D8
	private ImplicitVScrollBar vbar; // 0x1E0
	private SizeGrip sizegrip; // 0x1E8
	private int hbar_value; // 0x1F0
	private int vbar_value; // 0x1F4
	private bool lock_sizing; // 0x1F8
	private bool initializing_scrollbars; // 0x1F9
	private bool setting_windowstates; // 0x1FA
	internal ArrayList mdi_child_list; // 0x200
	private string form_text; // 0x208
	private bool setting_form_text; // 0x210
	private Form active_child; // 0x218

	// Properties
	internal bool HorizontalScrollbarVisible { get; }
	internal bool VerticalScrollbarVisible { get; }
	internal Form ParentForm { get; }
	public Form[] MdiChildren { get; }
	internal Form ActiveMdiChild { get; }

	// Methods

	// RVA: 0x237A5F0 Offset: 0x2378FF0 VA: 0x18237A5F0
	internal void SendFocusToActiveChild() { }

	// RVA: 0x237C7E0 Offset: 0x237B1E0 VA: 0x18237C7E0
	internal bool get_HorizontalScrollbarVisible() { }

	// RVA: 0x237C960 Offset: 0x237B360 VA: 0x18237C960
	internal bool get_VerticalScrollbarVisible() { }

	// RVA: 0x237A670 Offset: 0x2379070 VA: 0x18237A670
	internal void SetParentText(bool text_changed) { }

	// RVA: 0x237C8F0 Offset: 0x237B2F0 VA: 0x18237C8F0
	internal Form get_ParentForm() { }

	// RVA: 0x237C810 Offset: 0x237B210 VA: 0x18237C810
	public Form[] get_MdiChildren() { }

	// RVA: 0x237BA30 Offset: 0x237A430 VA: 0x18237BA30
	internal void SizeScrollBars() { }

	// RVA: 0x2379500 Offset: 0x2377F00 VA: 0x182379500
	private void CalcHBar(int left, int right, bool vert_vis) { }

	// RVA: 0x23797C0 Offset: 0x23781C0 VA: 0x1823797C0
	private void CalcVBar(int top, int bottom, bool horz_vis) { }

	// RVA: 0x2379D50 Offset: 0x2378750 VA: 0x182379D50
	private void HBarValueChanged(object sender, EventArgs e) { }

	// RVA: 0x237C1F0 Offset: 0x237ABF0 VA: 0x18237C1F0
	private void VBarValueChanged(object sender, EventArgs e) { }

	// RVA: 0x2378F20 Offset: 0x2377920 VA: 0x182378F20
	internal void ArrangeIconicWindows(bool rearrange_all) { }

	// RVA: 0x2379A80 Offset: 0x2378480 VA: 0x182379A80
	internal void ChildFormClosed(Form form) { }

	// RVA: 0x2378C60 Offset: 0x2377660 VA: 0x182378C60
	internal void ActivateNextChild() { }

	// RVA: 0x2378E30 Offset: 0x2377830 VA: 0x182378E30
	internal void ActivatePreviousChild() { }

	// RVA: 0x2378760 Offset: 0x2377160 VA: 0x182378760
	internal void ActivateChild(Form form) { }

	// RVA: 0x237AAC0 Offset: 0x23794C0 VA: 0x18237AAC0
	internal bool SetWindowStates(MdiWindowManager wm) { }

	// RVA: 0x237A070 Offset: 0x2378A70 VA: 0x18237A070
	private MenuStrip LookForChildMenu(Control parent) { }

	// RVA: 0x237A310 Offset: 0x2378D10 VA: 0x18237A310
	internal void RemoveControlMenuItems(MdiWindowManager wm) { }

	// RVA: 0x237A860 Offset: 0x2379260 VA: 0x18237A860
	internal void SetWindowState(Form form, FormWindowState old_window_state, FormWindowState new_window_state, bool is_activating_child) { }

	// RVA: 0x237C510 Offset: 0x237AF10 VA: 0x18237C510
	internal Form get_ActiveMdiChild() { }

	// RVA: 0x23785A0 Offset: 0x2376FA0 VA: 0x1823785A0
	internal void ActivateActiveMdiChild() { }
}
