public class ToolTip : Component, IExtenderProvider // TypeDefIndex: 5660
{
	// Fields
	internal bool is_active; // 0x28
	internal int automatic_delay; // 0x2C
	internal int autopop_delay; // 0x30
	internal int initial_delay; // 0x34
	internal int re_show_delay; // 0x38
	internal bool show_always; // 0x3C
	internal Color back_color; // 0x40
	internal Color fore_color; // 0x58
	internal ToolTip.ToolTipWindow tooltip_window; // 0x70
	internal Hashtable tooltip_strings; // 0x78
	internal ArrayList controls; // 0x80
	internal Control active_control; // 0x88
	internal Control last_control; // 0x90
	internal Timer timer; // 0x98
	private Form hooked_form; // 0xA0
	private bool isBalloon; // 0xA8
	private bool owner_draw; // 0xA9
	private bool stripAmpersands; // 0xAA
	private bool useAnimation; // 0xAB
	private bool useFading; // 0xAC
	private static object UnPopupEvent; // 0x0
	private ToolTip.TipState state; // 0xB0
	private static object PopupEvent; // 0x8
	private static object DrawEvent; // 0x10
	private static PopupEventHandler UIAUnPopup; // 0x18
	private static ControlEventHandler UIAToolTipHookUp; // 0x20
	private static ControlEventHandler UIAToolTipUnhookUp; // 0x28

	// Properties
	[DefaultValue(True)]
	public bool Active { get; set; }
	[RefreshProperties(1)]
	public int InitialDelay { set; }
	[DefaultValue(False)]
	public bool OwnerDraw { get; }
	[RefreshProperties(1)]
	public int ReshowDelay { set; }
	internal bool Visible { get; }

	// Methods

	// RVA: 0x2259110 Offset: 0x2257B10 VA: 0x182259110
	public void .ctor() { }

	// RVA: 0x2259010 Offset: 0x2257A10 VA: 0x182259010
	private static void .cctor() { }

	// RVA: 0x2259660 Offset: 0x2258060 VA: 0x182259660
	internal void add_UnPopup(PopupEventHandler value) { }

	// RVA: 0x2259880 Offset: 0x2258280 VA: 0x182259880
	internal void remove_UnPopup(PopupEventHandler value) { }

	// RVA: 0x22583A0 Offset: 0x2256DA0 VA: 0x1822583A0
	internal static void OnUIAUnPopup(object sender, PopupEventArgs args) { }

	// RVA: 0x2258260 Offset: 0x2256C60 VA: 0x182258260
	internal static void OnUIAToolTipHookUp(object sender, ControlEventArgs args) { }

	// RVA: 0x2258300 Offset: 0x2256D00 VA: 0x182258300
	internal static void OnUIAToolTipUnhookUp(object sender, ControlEventArgs args) { }

	// RVA: 0x2257D00 Offset: 0x2256700 VA: 0x182257D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_Active() { }

	// RVA: 0x2259910 Offset: 0x2258310 VA: 0x182259910
	public void set_Active(bool value) { }

	// RVA: 0x2259980 Offset: 0x2258380 VA: 0x182259980
	public void set_InitialDelay(int value) { }

	// RVA: 0x1DEF7C0 Offset: 0x1DEE1C0 VA: 0x181DEF7C0
	public bool get_OwnerDraw() { }

	// RVA: 0x2259990 Offset: 0x2258390 VA: 0x182259990
	public void set_ReshowDelay(int value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	public bool CanExtend(object target) { }

	// RVA: 0x2258530 Offset: 0x2256F30 VA: 0x182258530
	public void SetToolTip(Control control, string caption) { }

	// RVA: 0x2258B90 Offset: 0x2257590 VA: 0x182258B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2257E10 Offset: 0x2256810 VA: 0x182257E10
	public void Hide(IWin32Window win) { }

	// RVA: 0x2257970 Offset: 0x2256370 VA: 0x182257970 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2258EC0 Offset: 0x22578C0 VA: 0x182258EC0
	private void UnhookFormEvents() { }

	// RVA: 0x2257D70 Offset: 0x2256770 VA: 0x182257D70
	private void Form_Resize(object sender, EventArgs e) { }

	// RVA: 0x2257D40 Offset: 0x2256740 VA: 0x182257D40
	private void Form_Closed(object sender, EventArgs e) { }

	// RVA: 0x2257D40 Offset: 0x2256740 VA: 0x182257D40
	private void Form_Deactivate(object sender, EventArgs e) { }

	// RVA: 0x2258510 Offset: 0x2256F10 VA: 0x182258510
	internal void Present(Control control, string text) { }

	// RVA: 0x2259780 Offset: 0x2258180 VA: 0x182259780
	private void control_MouseEnter(object sender, EventArgs e) { }

	// RVA: 0x22589C0 Offset: 0x22573C0 VA: 0x1822589C0
	private void ShowTooltip(Control control) { }

	// RVA: 0x22599A0 Offset: 0x22583A0 VA: 0x1822599A0
	private void timer_Tick(object sender, EventArgs e) { }

	// RVA: 0x2259D20 Offset: 0x2258720 VA: 0x182259D20
	private void tooltip_window_Popup(object sender, PopupEventArgs e) { }

	// RVA: 0x2259B70 Offset: 0x2258570 VA: 0x182259B70
	private void tooltip_window_Draw(object sender, DrawToolTipEventArgs e) { }

	// RVA: 0x2257F90 Offset: 0x2256990 VA: 0x182257F90
	private bool MouseInControl(Control control, bool fuzzy) { }

	// RVA: 0x22596F0 Offset: 0x22580F0 VA: 0x1822596F0
	private void control_MouseLeave(object sender, EventArgs e) { }

	// RVA: 0x22596F0 Offset: 0x22580F0 VA: 0x1822596F0
	private void control_MouseDown(object sender, MouseEventArgs e) { }

	// RVA: 0x2259810 Offset: 0x2258210 VA: 0x182259810
	private void control_MouseMove(object sender, MouseEventArgs e) { }

	// RVA: 0x22580A0 Offset: 0x2256AA0 VA: 0x1822580A0
	internal void OnDraw(DrawToolTipEventArgs e) { }

	// RVA: 0x2258180 Offset: 0x2256B80 VA: 0x182258180
	internal void OnPopup(PopupEventArgs e) { }

	// RVA: 0x2258440 Offset: 0x2256E40 VA: 0x182258440
	internal void OnUnPopup(PopupEventArgs e) { }

	// RVA: 0x2259860 Offset: 0x2258260 VA: 0x182259860
	internal bool get_Visible() { }

	[CompilerGenerated]
	// RVA: 0x2258DF0 Offset: 0x22577F0 VA: 0x182258DF0
	private void <ToolTip>m__B(object sender, PopupEventArgs args) { }
}
