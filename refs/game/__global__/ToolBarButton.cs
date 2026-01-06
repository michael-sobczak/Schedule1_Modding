public class ToolBarButton : Component // TypeDefIndex: 5605
{
	// Fields
	private bool enabled; // 0x28
	private int image_index; // 0x2C
	private ContextMenu menu; // 0x30
	private ToolBar parent; // 0x38
	private bool partial_push; // 0x40
	private bool pushed; // 0x41
	private ToolBarButtonStyle style; // 0x44
	private string text; // 0x48
	private string tooltip; // 0x50
	private bool visible; // 0x58
	private string image_key; // 0x60
	private bool uiaHasFocus; // 0x68
	private static object UIAGotFocusEvent; // 0x0
	private static object UIALostFocusEvent; // 0x8
	private static object UIATextChangedEvent; // 0x10
	private static object UIAEnabledChangedEvent; // 0x18
	private static object UIADropDownMenuChangedEvent; // 0x20
	private static object UIAStyleChangedEvent; // 0x28

	// Properties
	internal Image Image { get; }
	[DefaultValue(null)]
	[TypeConverter(typeof(ReferenceConverter))]
	public Menu DropDownMenu { get; set; }
	[DefaultValue(True)]
	[Localizable(True)]
	public bool Enabled { get; set; }
	[RefreshProperties(2)]
	[DefaultValue(-1)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(True)]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int ImageIndex { get; set; }
	[Browsable(False)]
	public ToolBar Parent { get; }
	[DefaultValue(False)]
	public bool PartialPush { get; }
	[DefaultValue(False)]
	public bool Pushed { get; set; }
	public Rectangle Rectangle { get; }
	[RefreshProperties(2)]
	[DefaultValue(1)]
	public ToolBarButtonStyle Style { get; set; }
	[DefaultValue("")]
	[Localizable(True)]
	public string Text { get; }
	[Localizable(True)]
	[DefaultValue("")]
	public string ToolTipText { get; }
	[DefaultValue(True)]
	[Localizable(True)]
	public bool Visible { get; }
	internal bool UIAHasFocus { set; }

	// Methods

	// RVA: 0x2225E40 Offset: 0x2224840 VA: 0x182225E40
	public void .ctor() { }

	// RVA: 0x2225C70 Offset: 0x2224670 VA: 0x182225C70
	private static void .cctor() { }

	// RVA: 0x2225F10 Offset: 0x2224910 VA: 0x182225F10
	internal Image get_Image() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Menu get_DropDownMenu() { }

	// RVA: 0x22260B0 Offset: 0x2224AB0 VA: 0x1822260B0
	public void set_DropDownMenu(Menu value) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_Enabled() { }

	// RVA: 0x22262E0 Offset: 0x2224CE0 VA: 0x1822262E0
	public void set_Enabled(bool value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_ImageIndex() { }

	// RVA: 0x2226410 Offset: 0x2224E10 VA: 0x182226410
	public void set_ImageIndex(int value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public ToolBar get_Parent() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_PartialPush() { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	public bool get_Pushed() { }

	// RVA: 0x2226530 Offset: 0x2224F30 VA: 0x182226530
	public void set_Pushed(bool value) { }

	// RVA: 0x2225FE0 Offset: 0x22249E0 VA: 0x182225FE0
	public Rectangle get_Rectangle() { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public ToolBarButtonStyle get_Style() { }

	// RVA: 0x2226540 Offset: 0x2224F40 VA: 0x182226540
	public void set_Style(ToolBarButtonStyle value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_Text() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_ToolTipText() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_Visible() { }

	// RVA: 0x2225B50 Offset: 0x2224550 VA: 0x182225B50
	internal void SetParent(ToolBar parent) { }

	// RVA: 0x22257D0 Offset: 0x22241D0 VA: 0x1822257D0
	internal void Invalidate() { }

	// RVA: 0x2226680 Offset: 0x2225080 VA: 0x182226680
	internal void set_UIAHasFocus(bool value) { }

	// RVA: 0x2225990 Offset: 0x2224390 VA: 0x182225990
	private void OnUIAEnabledChanged(EventArgs e) { }

	// RVA: 0x22258B0 Offset: 0x22242B0 VA: 0x1822258B0
	private void OnUIADropDownMenuChanged(EventArgs e) { }

	// RVA: 0x2225A70 Offset: 0x2224470 VA: 0x182225A70
	private void OnUIAStyleChanged(EventArgs e) { }

	// RVA: 0x21CB3A0 Offset: 0x21C9DA0 VA: 0x1821CB3A0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2225BF0 Offset: 0x22245F0 VA: 0x182225BF0 Slot: 3
	public override string ToString() { }
}
