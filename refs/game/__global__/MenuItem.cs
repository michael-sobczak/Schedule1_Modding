public class MenuItem : Menu // TypeDefIndex: 5493
{
	// Fields
	internal bool separator; // 0x70
	internal bool break_; // 0x71
	internal bool bar_break; // 0x72
	private Shortcut shortcut; // 0x74
	private string text; // 0x78
	private bool checked_; // 0x80
	private bool radiocheck; // 0x81
	private bool enabled; // 0x82
	private char mnemonic; // 0x84
	private bool showshortcut; // 0x86
	private int index; // 0x88
	private bool mdilist; // 0x8C
	private Hashtable mdilist_items; // 0x90
	private Hashtable mdilist_forms; // 0x98
	private MdiClient mdicontainer; // 0xA0
	private bool is_window_menu_item; // 0xA8
	private bool defaut_item; // 0xA9
	private bool visible; // 0xAA
	private bool ownerdraw; // 0xAB
	private int menuid; // 0xAC
	private int mergeorder; // 0xB0
	private int xtab; // 0xB4
	private int menuheight; // 0xB8
	private bool menubar; // 0xBC
	private MenuMerge mergetype; // 0xC0
	internal Rectangle bounds; // 0xC4
	private static object ClickEvent; // 0x0
	private static object DrawItemEvent; // 0x8
	private static object MeasureItemEvent; // 0x10
	private static object PopupEvent; // 0x18
	private static object SelectEvent; // 0x20
	private static object UIACheckedChangedEvent; // 0x28
	private static object UIARadioCheckChangedEvent; // 0x30
	private static object UIAEnabledChangedEvent; // 0x38
	private static object UIATextChangedEvent; // 0x40
	private bool selected; // 0xD4

	// Properties
	[DefaultValue(False)]
	[Browsable(False)]
	public bool BarBreak { get; set; }
	[DefaultValue(False)]
	[Browsable(False)]
	public bool Break { get; set; }
	[DefaultValue(False)]
	public bool Checked { get; set; }
	[DefaultValue(False)]
	public bool DefaultItem { get; set; }
	[Localizable(True)]
	[DefaultValue(True)]
	public bool Enabled { get; set; }
	[Browsable(False)]
	public int Index { get; set; }
	[DefaultValue(False)]
	public bool MdiList { get; set; }
	[DefaultValue(0)]
	public int MergeOrder { get; set; }
	[DefaultValue(0)]
	public MenuMerge MergeType { get; set; }
	[Browsable(False)]
	public char Mnemonic { get; }
	[DefaultValue(False)]
	public bool OwnerDraw { get; set; }
	[Browsable(False)]
	public Menu Parent { get; }
	[DefaultValue(False)]
	public bool RadioCheck { get; set; }
	[DefaultValue(0)]
	[Localizable(True)]
	public Shortcut Shortcut { get; set; }
	[Localizable(True)]
	[DefaultValue(True)]
	public bool ShowShortcut { get; set; }
	[Localizable(True)]
	public string Text { get; set; }
	[Localizable(True)]
	[DefaultValue(True)]
	public bool Visible { get; set; }
	internal int Height { get; set; }
	internal bool IsPopup { get; }
	internal bool MeasureEventDefined { get; }
	internal bool MenuBar { get; set; }
	internal int MenuHeight { get; set; }
	internal bool Selected { get; set; }
	internal bool Separator { get; }
	internal DrawItemState Status { get; }
	internal bool VisibleItems { get; }
	internal int Width { get; set; }
	internal int X { get; set; }
	internal int XTab { get; set; }
	internal int Y { get; set; }

	// Methods

	// RVA: 0x23895C0 Offset: 0x2387FC0 VA: 0x1823895C0
	public void .ctor() { }

	// RVA: 0x23893C0 Offset: 0x2387DC0 VA: 0x1823893C0
	public void .ctor(string text) { }

	// RVA: 0x23894B0 Offset: 0x2387EB0 VA: 0x1823894B0
	public void .ctor(string text, EventHandler onClick) { }

	// RVA: 0x2389120 Offset: 0x2387B20 VA: 0x182389120
	private static void .cctor() { }

	// RVA: 0x23896C0 Offset: 0x23880C0 VA: 0x1823896C0
	public void add_Click(EventHandler value) { }

	// RVA: 0x2389C10 Offset: 0x2388610 VA: 0x182389C10
	public void remove_Click(EventHandler value) { }

	// RVA: 0x2389750 Offset: 0x2388150 VA: 0x182389750
	public void add_DrawItem(DrawItemEventHandler value) { }

	// RVA: 0x2389CA0 Offset: 0x23886A0 VA: 0x182389CA0
	public void remove_DrawItem(DrawItemEventHandler value) { }

	// RVA: 0x23897E0 Offset: 0x23881E0 VA: 0x1823897E0
	public void add_MeasureItem(MeasureItemEventHandler value) { }

	// RVA: 0x2389D30 Offset: 0x2388730 VA: 0x182389D30
	public void remove_MeasureItem(MeasureItemEventHandler value) { }

	// RVA: 0x23865D0 Offset: 0x2384FD0 VA: 0x1823865D0
	private void CommonConstructor(string text) { }

	// RVA: 0x2387CE0 Offset: 0x23866E0 VA: 0x182387CE0
	internal void OnUIACheckedChanged(EventArgs e) { }

	// RVA: 0x2387EA0 Offset: 0x23868A0 VA: 0x182387EA0
	internal void OnUIARadioCheckChanged(EventArgs e) { }

	// RVA: 0x2387DC0 Offset: 0x23867C0 VA: 0x182387DC0
	internal void OnUIAEnabledChanged(EventArgs e) { }

	// RVA: 0x2387F80 Offset: 0x2386980 VA: 0x182387F80
	internal void OnUIATextChanged(EventArgs e) { }

	// RVA: 0x1D14B40 Offset: 0x1D13540 VA: 0x181D14B40
	public bool get_BarBreak() { }

	// RVA: 0x1D14D80 Offset: 0x1D13780 VA: 0x181D14D80
	public void set_BarBreak(bool value) { }

	// RVA: 0x2389870 Offset: 0x2388270 VA: 0x182389870
	public bool get_Break() { }

	// RVA: 0x2389DC0 Offset: 0x23887C0 VA: 0x182389DC0
	public void set_Break(bool value) { }

	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_Checked() { }

	// RVA: 0x2389DD0 Offset: 0x23887D0 VA: 0x182389DD0
	public void set_Checked(bool value) { }

	// RVA: 0x1DEF7C0 Offset: 0x1DEE1C0 VA: 0x181DEF7C0
	public bool get_DefaultItem() { }

	// RVA: 0x1DEF7D0 Offset: 0x1DEE1D0 VA: 0x181DEF7D0
	public void set_DefaultItem(bool value) { }

	// RVA: 0x1D32B60 Offset: 0x1D31560 VA: 0x181D32B60
	public bool get_Enabled() { }

	// RVA: 0x2389F00 Offset: 0x2388900 VA: 0x182389F00
	public void set_Enabled(bool value) { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	public int get_Index() { }

	// RVA: 0x238A040 Offset: 0x2388A40 VA: 0x18238A040
	public void set_Index(int value) { }

	// RVA: 0x1A37560 Offset: 0x1A35F60 VA: 0x181A37560
	public bool get_MdiList() { }

	// RVA: 0x238A130 Offset: 0x2388B30 VA: 0x18238A130
	public void set_MdiList(bool value) { }

	// RVA: 0xBBA740 Offset: 0xBB9140 VA: 0x180BBA740
	public int get_MergeOrder() { }

	// RVA: 0xBBA7C0 Offset: 0xBB91C0 VA: 0x180BBA7C0
	public void set_MergeOrder(int value) { }

	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	public MenuMerge get_MergeType() { }

	// RVA: 0x238A390 Offset: 0x2388D90 VA: 0x18238A390
	public void set_MergeType(MenuMerge value) { }

	// RVA: 0x1D85ED0 Offset: 0x1D848D0 VA: 0x181D85ED0
	public char get_Mnemonic() { }

	// RVA: 0x2389960 Offset: 0x2388360 VA: 0x182389960
	public bool get_OwnerDraw() { }

	// RVA: 0x238A4F0 Offset: 0x2388EF0 VA: 0x18238A4F0
	public void set_OwnerDraw(bool value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Menu get_Parent() { }

	// RVA: 0x1D85F50 Offset: 0x1D84950 VA: 0x181D85F50
	public bool get_RadioCheck() { }

	// RVA: 0x238A500 Offset: 0x2388F00 VA: 0x18238A500
	public void set_RadioCheck(bool value) { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	public Shortcut get_Shortcut() { }

	// RVA: 0x238A640 Offset: 0x2389040 VA: 0x18238A640
	public void set_Shortcut(Shortcut value) { }

	// RVA: 0x2389980 Offset: 0x2388380 VA: 0x182389980
	public bool get_ShowShortcut() { }

	// RVA: 0x238A870 Offset: 0x2389270 VA: 0x18238A870
	public void set_ShowShortcut(bool value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_Text() { }

	// RVA: 0x238A880 Offset: 0x2389280 VA: 0x18238A880
	public void set_Text(string value) { }

	// RVA: 0x2389C00 Offset: 0x2388600 VA: 0x182389C00
	public bool get_Visible() { }

	// RVA: 0x238AAD0 Offset: 0x23894D0 VA: 0x18238AAD0
	public void set_Visible(bool value) { }

	// RVA: 0x1A3AE30 Offset: 0x1A39830 VA: 0x181A3AE30
	internal int get_Height() { }

	// RVA: 0x1A3AF20 Offset: 0x1A39920 VA: 0x181A3AF20
	internal void set_Height(int value) { }

	// RVA: 0x2389880 Offset: 0x2388280 VA: 0x182389880
	internal bool get_IsPopup() { }

	// RVA: 0x23898C0 Offset: 0x23882C0 VA: 0x1823898C0
	internal bool get_MeasureEventDefined() { }

	// RVA: 0x2389950 Offset: 0x2388350 VA: 0x182389950
	internal bool get_MenuBar() { }

	// RVA: 0x238A380 Offset: 0x2388D80 VA: 0x18238A380
	internal void set_MenuBar(bool value) { }

	// RVA: 0x6A4D80 Offset: 0x6A3780 VA: 0x1806A4D80
	internal int get_MenuHeight() { }

	// RVA: 0x6A5560 Offset: 0x6A3F60 VA: 0x1806A5560
	internal void set_MenuHeight(int value) { }

	// RVA: 0x2389970 Offset: 0x2388370 VA: 0x182389970
	internal bool get_Selected() { }

	// RVA: 0x238A630 Offset: 0x2389030 VA: 0x18238A630
	internal void set_Selected(bool value) { }

	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	internal bool get_Separator() { }

	// RVA: 0x2389990 Offset: 0x2388390 VA: 0x182389990
	internal DrawItemState get_Status() { }

	// RVA: 0x2389A50 Offset: 0x2388450 VA: 0x182389A50
	internal bool get_VisibleItems() { }

	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	internal int get_Width() { }

	// RVA: 0x1A3AF40 Offset: 0x1A39940 VA: 0x181A3AF40
	internal void set_Width(int value) { }

	// RVA: 0x526FE0 Offset: 0x5259E0 VA: 0x180526FE0
	internal int get_X() { }

	// RVA: 0x1A3AED0 Offset: 0x1A398D0 VA: 0x181A3AED0
	internal void set_X(int value) { }

	// RVA: 0x10F9570 Offset: 0x10F7F70 VA: 0x1810F9570
	internal int get_XTab() { }

	// RVA: 0x10F9800 Offset: 0x10F8200 VA: 0x1810F9800
	internal void set_XTab(int value) { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	internal int get_Y() { }

	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	internal void set_Y(int value) { }

	// RVA: 0x2385D00 Offset: 0x2384700 VA: 0x182385D00 Slot: 18
	public virtual MenuItem CloneMenu() { }

	// RVA: 0x2385D70 Offset: 0x2384770 VA: 0x182385D70
	protected void CloneMenu(MenuItem itemSrc) { }

	// RVA: 0x2386640 Offset: 0x2385040 VA: 0x182386640 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2387880 Offset: 0x2386280 VA: 0x182387880
	public void MergeMenu(MenuItem itemSrc) { }

	// RVA: 0x2387890 Offset: 0x2386290 VA: 0x182387890 Slot: 19
	protected virtual void OnClick(EventArgs e) { }

	// RVA: 0x2387960 Offset: 0x2386360 VA: 0x182387960 Slot: 20
	protected virtual void OnDrawItem(DrawItemEventArgs e) { }

	// RVA: 0x2387A40 Offset: 0x2386440 VA: 0x182387A40 Slot: 21
	protected virtual void OnMeasureItem(MeasureItemEventArgs e) { }

	// RVA: 0x2387B20 Offset: 0x2386520 VA: 0x182387B20 Slot: 22
	protected virtual void OnPopup(EventArgs e) { }

	// RVA: 0x2387C00 Offset: 0x2386600 VA: 0x182387C00 Slot: 23
	protected virtual void OnSelect(EventArgs e) { }

	// RVA: 0x2388060 Offset: 0x2386A60 VA: 0x182388060
	public void PerformClick() { }

	// RVA: 0x2388230 Offset: 0x2386C30 VA: 0x182388230 Slot: 24
	public virtual void PerformSelect() { }

	// RVA: 0x2388D60 Offset: 0x2387760 VA: 0x182388D60 Slot: 3
	public override string ToString() { }

	// RVA: 0x23876F0 Offset: 0x23860F0 VA: 0x1823876F0 Slot: 25
	internal virtual void Invalidate() { }

	// RVA: 0x23881C0 Offset: 0x2386BC0 VA: 0x1823881C0
	internal void PerformPopup() { }

	// RVA: 0x23880D0 Offset: 0x2386AD0 VA: 0x1823880D0
	internal void PerformDrawItem(DrawItemEventArgs e) { }

	// RVA: 0x23882A0 Offset: 0x2386CA0 VA: 0x1823882A0
	private void PopulateWindowMenu() { }

	// RVA: 0xB1E1B0 Offset: 0xB1CBB0 VA: 0x180B1E1B0
	internal void PerformMeasureItem(MeasureItemEventArgs e) { }

	// RVA: 0x2388C30 Offset: 0x2387630 VA: 0x182388C30
	private void ProcessMnemonic() { }

	// RVA: 0x23866D0 Offset: 0x23850D0 VA: 0x1823866D0
	private string GetShortCutTextCtrl() { }

	// RVA: 0x23866A0 Offset: 0x23850A0 VA: 0x1823866A0
	private string GetShortCutTextAlt() { }

	// RVA: 0x2386700 Offset: 0x2385100 VA: 0x182386700
	private string GetShortCutTextShift() { }

	// RVA: 0x2386730 Offset: 0x2385130 VA: 0x182386730
	internal string GetShortCutText() { }

	// RVA: 0x23877C0 Offset: 0x23861C0 VA: 0x1823877C0
	private void MdiWindowClickHandler(object sender, EventArgs e) { }

	// RVA: 0x2389050 Offset: 0x2387A50 VA: 0x182389050
	private void UpdateMenuItem() { }
}
