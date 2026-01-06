public abstract class ToolStripItem : Component, IDisposable, IComponent // TypeDefIndex: 5626
{
	// Fields
	private ToolStripItemAlignment alignment; // 0x28
	private AnchorStyles anchor; // 0x2C
	private bool available; // 0x30
	private bool auto_size; // 0x31
	private bool auto_tool_tip; // 0x32
	private Color back_color; // 0x38
	private Image background_image; // 0x50
	private ImageLayout background_image_layout; // 0x58
	private Rectangle bounds; // 0x5C
	private bool can_select; // 0x6C
	private ToolStripItemDisplayStyle display_style; // 0x70
	private DockStyle dock; // 0x74
	private bool enabled; // 0x78
	private Size explicit_size; // 0x7C
	private Font font; // 0x88
	private Color fore_color; // 0x90
	private Image image; // 0xA8
	private ContentAlignment image_align; // 0xB0
	private int image_index; // 0xB4
	private string image_key; // 0xB8
	private ToolStripItemImageScaling image_scaling; // 0xC0
	private Color image_transparent_color; // 0xC8
	private bool is_disposed; // 0xE0
	internal bool is_pressed; // 0xE1
	private bool is_selected; // 0xE2
	private Padding margin; // 0xE4
	private MergeAction merge_action; // 0xF8
	private int merge_index; // 0xFC
	private string name; // 0x100
	private ToolStripItemOverflow overflow; // 0x108
	private ToolStrip owner; // 0x110
	internal ToolStripItem owner_item; // 0x118
	private Padding padding; // 0x120
	private ToolStripItemPlacement placement; // 0x134
	private RightToLeft right_to_left; // 0x138
	private bool right_to_left_auto_mirror_image; // 0x13C
	private string text; // 0x140
	private ContentAlignment text_align; // 0x148
	private ToolStripTextDirection text_direction; // 0x14C
	private TextImageRelation text_image_relation; // 0x150
	private string tool_tip_text; // 0x158
	private bool visible; // 0x160
	private EventHandler frame_handler; // 0x168
	private ToolStrip parent; // 0x170
	private Size text_size; // 0x178
	private static object AvailableChangedEvent; // 0x0
	private static object BackColorChangedEvent; // 0x8
	private static object ClickEvent; // 0x10
	private static object DisplayStyleChangedEvent; // 0x18
	private static object DoubleClickEvent; // 0x20
	private static object DragDropEvent; // 0x28
	private static object DragEnterEvent; // 0x30
	private static object DragLeaveEvent; // 0x38
	private static object DragOverEvent; // 0x40
	private static object EnabledChangedEvent; // 0x48
	private static object ForeColorChangedEvent; // 0x50
	private static object GiveFeedbackEvent; // 0x58
	private static object LocationChangedEvent; // 0x60
	private static object MouseDownEvent; // 0x68
	private static object MouseEnterEvent; // 0x70
	private static object MouseHoverEvent; // 0x78
	private static object MouseLeaveEvent; // 0x80
	private static object MouseMoveEvent; // 0x88
	private static object MouseUpEvent; // 0x90
	private static object OwnerChangedEvent; // 0x98
	private static object PaintEvent; // 0xA0
	private static object QueryAccessibilityHelpEvent; // 0xA8
	private static object QueryContinueDragEvent; // 0xB0
	private static object RightToLeftChangedEvent; // 0xB8
	private static object TextChangedEvent; // 0xC0
	private static object VisibleChangedEvent; // 0xC8
	private static object UIASelectionChangedEvent; // 0xD0

	// Properties
	[DefaultValue(0)]
	public ToolStripItemAlignment Alignment { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[DefaultValue(5)]
	public AnchorStyles Anchor { get; }
	[DefaultValue(True)]
	[Localizable(True)]
	[DesignerSerializationVisibility(1)]
	[RefreshProperties(1)]
	public bool AutoSize { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool Available { get; set; }
	public virtual Color BackColor { get; }
	[Localizable(True)]
	[DefaultValue(null)]
	public virtual Image BackgroundImage { get; }
	[DefaultValue(1)]
	[Localizable(True)]
	public virtual ImageLayout BackgroundImageLayout { get; }
	[Browsable(False)]
	public virtual Rectangle Bounds { get; }
	[Browsable(False)]
	public virtual bool CanSelect { get; }
	[Browsable(False)]
	public Rectangle ContentRectangle { get; }
	public virtual ToolStripItemDisplayStyle DisplayStyle { set; }
	[Browsable(False)]
	public bool IsDisposed { get; }
	[DefaultValue(0)]
	[Browsable(False)]
	public DockStyle Dock { get; }
	[Localizable(True)]
	[DefaultValue(True)]
	public virtual bool Enabled { get; set; }
	[Localizable(True)]
	public virtual Font Font { get; }
	public virtual Color ForeColor { get; }
	[EditorBrowsable(0)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public int Height { get; set; }
	[Localizable(True)]
	public virtual Image Image { get; set; }
	[Localizable(True)]
	public Color ImageTransparentColor { get; }
	[Browsable(False)]
	public bool IsOnDropDown { get; }
	public Padding Margin { get; }
	[DefaultValue(0)]
	public MergeAction MergeAction { get; }
	[DefaultValue(-1)]
	public int MergeIndex { get; set; }
	[DefaultValue(2)]
	public ToolStripItemOverflow Overflow { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public ToolStrip Owner { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public ToolStripItem OwnerItem { get; }
	[Browsable(False)]
	public ToolStripItemPlacement Placement { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual bool Pressed { get; }
	[MonoTODO("RTL not implemented")]
	[Localizable(True)]
	public virtual RightToLeft RightToLeft { get; }
	[Localizable(True)]
	[DefaultValue(False)]
	public bool RightToLeftAutoMirrorImage { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual bool Selected { get; }
	[Localizable(True)]
	public virtual Size Size { get; set; }
	[Localizable(True)]
	[DefaultValue("")]
	public virtual string Text { get; set; }
	[DefaultValue(32)]
	[Localizable(True)]
	public virtual ContentAlignment TextAlign { get; }
	public virtual ToolStripTextDirection TextDirection { get; }
	[Localizable(True)]
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string ToolTipText { set; }
	[Localizable(True)]
	public bool Visible { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(0)]
	public int Width { get; set; }
	protected virtual bool DefaultAutoToolTip { get; }
	protected virtual ToolStripItemDisplayStyle DefaultDisplayStyle { get; }
	protected internal virtual Padding DefaultMargin { get; }
	protected virtual Padding DefaultPadding { get; }
	protected virtual Size DefaultSize { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	protected internal ToolStrip Parent { get; set; }
	private static Font DefaultFont { get; }
	internal virtual ToolStripTextDirection DefaultTextDirection { get; }
	internal bool ShowMargin { get; }
	internal bool UseImageMargin { get; }
	internal virtual bool InternalVisible { get; }
	internal ToolStrip InternalOwner { set; }
	internal Point Location { get; set; }
	internal int Top { get; set; }
	internal int Left { get; set; }
	internal int Right { get; }
	internal int Bottom { get; }

	// Methods

	// RVA: 0x2238F60 Offset: 0x2237960 VA: 0x182238F60
	protected void .ctor() { }

	// RVA: 0x2238BB0 Offset: 0x22375B0 VA: 0x182238BB0
	protected void .ctor(string text, Image image, EventHandler onClick, string name) { }

	// RVA: 0x22383F0 Offset: 0x2236DF0 VA: 0x1822383F0
	private static void .cctor() { }

	// RVA: 0x2238FC0 Offset: 0x22379C0 VA: 0x182238FC0
	public void add_Click(EventHandler value) { }

	// RVA: 0x2239B30 Offset: 0x2238530 VA: 0x182239B30
	public void remove_Click(EventHandler value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public ToolStripItemAlignment get_Alignment() { }

	// RVA: 0x2239BC0 Offset: 0x22385C0 VA: 0x182239BC0
	public void set_Alignment(ToolStripItemAlignment value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public AnchorStyles get_Anchor() { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_AutoSize() { }

	// RVA: 0x2239D30 Offset: 0x2238730 VA: 0x182239D30
	public void set_AutoSize(bool value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_Available() { }

	// RVA: 0x2239D40 Offset: 0x2238740 VA: 0x182239D40
	public void set_Available(bool value) { }

	// RVA: 0x2239050 Offset: 0x2237A50 VA: 0x182239050 Slot: 14
	public virtual Color get_BackColor() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 15
	public virtual Image get_BackgroundImage() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30 Slot: 16
	public virtual ImageLayout get_BackgroundImageLayout() { }

	// RVA: 0x8D2040 Offset: 0x8D0A40 VA: 0x1808D2040 Slot: 17
	public virtual Rectangle get_Bounds() { }

	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490 Slot: 18
	public virtual bool get_CanSelect() { }

	// RVA: 0x2239160 Offset: 0x2237B60 VA: 0x182239160
	public Rectangle get_ContentRectangle() { }

	// RVA: 0x2239E10 Offset: 0x2238810 VA: 0x182239E10 Slot: 19
	public virtual void set_DisplayStyle(ToolStripItemDisplayStyle value) { }

	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_IsDisposed() { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	public DockStyle get_Dock() { }

	// RVA: 0x22393B0 Offset: 0x2237DB0 VA: 0x1822393B0 Slot: 20
	public virtual bool get_Enabled() { }

	// RVA: 0x2239EA0 Offset: 0x22388A0 VA: 0x182239EA0 Slot: 21
	public virtual void set_Enabled(bool value) { }

	// RVA: 0x2239410 Offset: 0x2237E10 VA: 0x182239410 Slot: 22
	public virtual Font get_Font() { }

	// RVA: 0x2239500 Offset: 0x2237F00 VA: 0x182239500 Slot: 23
	public virtual Color get_ForeColor() { }

	// RVA: 0x2239610 Offset: 0x2238010 VA: 0x182239610
	public int get_Height() { }

	// RVA: 0x2239F50 Offset: 0x2238950 VA: 0x182239F50
	public void set_Height(int value) { }

	// RVA: 0x2239650 Offset: 0x2238050 VA: 0x182239650 Slot: 24
	public virtual Image get_Image() { }

	// RVA: 0x223A030 Offset: 0x2238A30 VA: 0x18223A030 Slot: 25
	public virtual void set_Image(Image value) { }

	// RVA: 0x2239630 Offset: 0x2238030 VA: 0x182239630
	public Color get_ImageTransparentColor() { }

	// RVA: 0x2239790 Offset: 0x2238190 VA: 0x182239790
	public bool get_IsOnDropDown() { }

	// RVA: 0x2239820 Offset: 0x2238220 VA: 0x182239820
	public Padding get_Margin() { }

	// RVA: 0x2239840 Offset: 0x2238240 VA: 0x182239840
	public MergeAction get_MergeAction() { }

	// RVA: 0x5232A0 Offset: 0x521CA0 VA: 0x1805232A0
	public int get_MergeIndex() { }

	// RVA: 0x7C2510 Offset: 0x7C0F10 VA: 0x1807C2510
	public void set_MergeIndex(int value) { }

	// RVA: 0x51D970 Offset: 0x51C370 VA: 0x18051D970
	public ToolStripItemOverflow get_Overflow() { }

	// RVA: 0x223A2D0 Offset: 0x2238CD0 VA: 0x18223A2D0
	public void set_Overflow(ToolStripItemOverflow value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public ToolStrip get_Owner() { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public ToolStripItem get_OwnerItem() { }

	// RVA: 0x512ED0 Offset: 0x5118D0 VA: 0x180512ED0
	public ToolStripItemPlacement get_Placement() { }

	// RVA: 0x516280 Offset: 0x514C80 VA: 0x180516280 Slot: 26
	public virtual bool get_Pressed() { }

	// RVA: 0x858810 Offset: 0x857210 VA: 0x180858810 Slot: 27
	public virtual RightToLeft get_RightToLeft() { }

	// RVA: 0x67E950 Offset: 0x67D350 VA: 0x18067E950
	public bool get_RightToLeftAutoMirrorImage() { }

	// RVA: 0x516270 Offset: 0x514C70 VA: 0x180516270 Slot: 28
	public virtual bool get_Selected() { }

	// RVA: 0x2239940 Offset: 0x2238340 VA: 0x182239940 Slot: 29
	public virtual Size get_Size() { }

	// RVA: 0x223A4B0 Offset: 0x2238EB0 VA: 0x18223A4B0 Slot: 30
	public virtual void set_Size(Size value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 31
	public virtual string get_Text() { }

	// RVA: 0x223A530 Offset: 0x2238F30 VA: 0x18223A530 Slot: 32
	public virtual void set_Text(string value) { }

	// RVA: 0x6BFD70 Offset: 0x6BE770 VA: 0x1806BFD70 Slot: 33
	public virtual ContentAlignment get_TextAlign() { }

	// RVA: 0x22399B0 Offset: 0x22383B0 VA: 0x1822399B0 Slot: 34
	public virtual ToolStripTextDirection get_TextDirection() { }

	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120
	public void set_ToolTipText(string value) { }

	// RVA: 0x2239AD0 Offset: 0x22384D0 VA: 0x182239AD0
	public bool get_Visible() { }

	// RVA: 0x223A6B0 Offset: 0x22390B0 VA: 0x18223A6B0
	public void set_Visible(bool value) { }

	// RVA: 0x2239B10 Offset: 0x2238510 VA: 0x182239B10
	public int get_Width() { }

	// RVA: 0x223A700 Offset: 0x2239100 VA: 0x18223A700
	public void set_Width(int value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 35
	protected virtual bool get_DefaultAutoToolTip() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 36
	protected virtual ToolStripItemDisplayStyle get_DefaultDisplayStyle() { }

	// RVA: 0x2239330 Offset: 0x2237D30 VA: 0x182239330 Slot: 37
	protected internal virtual Padding get_DefaultMargin() { }

	// RVA: 0x2239370 Offset: 0x2237D70 VA: 0x182239370 Slot: 38
	protected virtual Padding get_DefaultPadding() { }

	// RVA: 0x2239380 Offset: 0x2237D80 VA: 0x182239380 Slot: 39
	protected virtual Size get_DefaultSize() { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	protected internal ToolStrip get_Parent() { }

	// RVA: 0x223A450 Offset: 0x2238E50 VA: 0x18223A450
	protected internal void set_Parent(ToolStrip value) { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public ToolStrip GetCurrentParent() { }

	// RVA: 0x22365A0 Offset: 0x2234FA0 VA: 0x1822365A0 Slot: 40
	public virtual Size GetPreferredSize(Size constrainingSize) { }

	// RVA: 0x22366A0 Offset: 0x22350A0 VA: 0x1822366A0
	public void Invalidate() { }

	// RVA: 0x2237E30 Offset: 0x2236830 VA: 0x182237E30
	public void PerformClick() { }

	// RVA: 0x2238000 Offset: 0x2236A00 VA: 0x182238000
	public void Select() { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 3
	public override string ToString() { }

	// RVA: 0x2236150 Offset: 0x2234B50 VA: 0x182236150 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2236B60 Offset: 0x2235560 VA: 0x182236B60 Slot: 41
	protected virtual void OnAvailableChanged(EventArgs e) { }

	// RVA: 0x222EFF0 Offset: 0x222D9F0 VA: 0x18222EFF0 Slot: 42
	protected virtual void OnBoundsChanged() { }

	// RVA: 0x2236C30 Offset: 0x2235630 VA: 0x182236C30 Slot: 43
	protected virtual void OnClick(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x2236D10 Offset: 0x2235710 VA: 0x182236D10 Slot: 44
	protected virtual void OnDisplayStyleChanged(EventArgs e) { }

	// RVA: 0x2236DF0 Offset: 0x22357F0 VA: 0x182236DF0 Slot: 45
	protected virtual void OnEnabledChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	protected virtual void OnFontChanged(EventArgs e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 47
	protected virtual void OnLayout(LayoutEventArgs e) { }

	// RVA: 0x2236ED0 Offset: 0x22358D0 VA: 0x182236ED0 Slot: 48
	protected virtual void OnLocationChanged(EventArgs e) { }

	// RVA: 0x2236FB0 Offset: 0x22359B0 VA: 0x182236FB0 Slot: 49
	protected virtual void OnMouseDown(MouseEventArgs e) { }

	// RVA: 0x22370D0 Offset: 0x2235AD0 VA: 0x1822370D0 Slot: 50
	protected virtual void OnMouseEnter(EventArgs e) { }

	// RVA: 0x22371B0 Offset: 0x2235BB0 VA: 0x1822371B0 Slot: 51
	protected virtual void OnMouseHover(EventArgs e) { }

	// RVA: 0x222DF30 Offset: 0x222C930 VA: 0x18222DF30 Slot: 52
	protected virtual void OnMouseLeave(EventArgs e) { }

	// RVA: 0x22372A0 Offset: 0x2235CA0 VA: 0x1822372A0 Slot: 53
	protected virtual void OnMouseMove(MouseEventArgs mea) { }

	// RVA: 0x22373A0 Offset: 0x2235DA0 VA: 0x1822373A0 Slot: 54
	protected virtual void OnMouseUp(MouseEventArgs e) { }

	// RVA: 0x2237770 Offset: 0x2236170 VA: 0x182237770 Slot: 55
	protected virtual void OnOwnerChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x2237850 Offset: 0x2236250 VA: 0x182237850 Slot: 56
	protected internal virtual void OnOwnerFontChanged(EventArgs e) { }

	// RVA: 0x22378D0 Offset: 0x22362D0 VA: 0x1822378D0 Slot: 57
	protected virtual void OnPaint(PaintEventArgs e) { }

	// RVA: 0x2237A30 Offset: 0x2236430 VA: 0x182237A30 Slot: 58
	protected virtual void OnParentChanged(ToolStrip oldParent, ToolStrip newParent) { }

	// RVA: 0x2237B30 Offset: 0x2236530 VA: 0x182237B30 Slot: 59
	protected internal virtual void OnParentEnabledChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x2237B50 Offset: 0x2236550 VA: 0x182237B50 Slot: 60
	protected internal virtual void OnParentRightToLeftChanged(EventArgs e) { }

	// RVA: 0x222F460 Offset: 0x222DE60 VA: 0x18222F460 Slot: 61
	protected virtual void OnRightToLeftChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x2237B70 Offset: 0x2236570 VA: 0x182237B70 Slot: 62
	protected virtual void OnTextChanged(EventArgs e) { }

	// RVA: 0x2237D50 Offset: 0x2236750 VA: 0x182237D50 Slot: 63
	protected virtual void OnVisibleChanged(EventArgs e) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 64
	protected internal virtual bool ProcessCmdKey(ref Message m, Keys keyData) { }

	// RVA: 0x2237EA0 Offset: 0x22368A0 VA: 0x182237EA0 Slot: 65
	protected internal virtual bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x2237F40 Offset: 0x2236940 VA: 0x182237F40 Slot: 66
	protected internal virtual bool ProcessMnemonic(char charCode) { }

	// RVA: 0x2238180 Offset: 0x2236B80 VA: 0x182238180 Slot: 67
	protected internal virtual void SetBounds(Rectangle bounds) { }

	// RVA: 0x22381F0 Offset: 0x2236BF0 VA: 0x1822381F0 Slot: 68
	protected virtual void SetVisibleCore(bool visible) { }

	// RVA: 0x2235360 Offset: 0x2233D60 VA: 0x182235360
	internal Rectangle AlignInRectangle(Rectangle outer, Size inner, ContentAlignment align) { }

	// RVA: 0x2235610 Offset: 0x2234010 VA: 0x182235610
	internal void CalculateAutoSize() { }

	// RVA: 0x22357D0 Offset: 0x22341D0 VA: 0x1822357D0 Slot: 69
	internal virtual Size CalculatePreferredSize(Size constrainingSize) { }

	// RVA: 0x2236090 Offset: 0x2234A90 VA: 0x182236090
	internal void CalculateTextAndImageRectangles(out Rectangle text_rect, out Rectangle image_rect) { }

	// RVA: 0x2235B30 Offset: 0x2234530 VA: 0x182235B30
	internal void CalculateTextAndImageRectangles(Rectangle contentRectangle, out Rectangle text_rect, out Rectangle image_rect) { }

	// RVA: 0x22392D0 Offset: 0x2237CD0 VA: 0x1822392D0
	private static Font get_DefaultFont() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 70
	internal virtual ToolStripTextDirection get_DefaultTextDirection() { }

	// RVA: 0x22360F0 Offset: 0x2234AF0 VA: 0x1822360F0 Slot: 71
	internal virtual void Dismiss(ToolStripDropDownCloseReason reason) { }

	// RVA: 0x2236610 Offset: 0x2235010 VA: 0x182236610 Slot: 72
	internal virtual ToolStrip GetTopLevelToolStrip() { }

	// RVA: 0x22366D0 Offset: 0x22350D0 VA: 0x1822366D0
	private void LayoutTextBeforeOrAfterImage(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, ContentAlignment textAlign, ContentAlignment imageAlign, out Rectangle textRect, out Rectangle imageRect) { }

	// RVA: 0x22145D0 Offset: 0x2212FD0 VA: 0x1822145D0
	private HorizontalAlignment GetHorizontalAlignment(ContentAlignment align) { }

	// RVA: 0x2236480 Offset: 0x2234E80 VA: 0x182236480
	internal Size GetImageSize() { }

	// RVA: 0x22365C0 Offset: 0x2234FC0 VA: 0x1822365C0
	internal string GetToolTip() { }

	// RVA: 0x2236200 Offset: 0x2234C00 VA: 0x182236200
	internal void FireEvent(EventArgs e, ToolStripItemEventType met) { }

	// RVA: 0x2236640 Offset: 0x2235040 VA: 0x182236640 Slot: 73
	internal virtual void HandleClick(EventArgs e) { }

	// RVA: 0x22381E0 Offset: 0x2236BE0 VA: 0x1822381E0 Slot: 74
	internal virtual void SetPlacement(ToolStripItemPlacement placement) { }

	// RVA: 0x2235520 Offset: 0x2233F20 VA: 0x182235520
	private void BeginAnimation() { }

	// RVA: 0x22369E0 Offset: 0x22353E0 VA: 0x1822369E0
	private void OnAnimateImage(object sender, EventArgs e) { }

	// RVA: 0x22382B0 Offset: 0x2236CB0 VA: 0x1822382B0
	private void StopAnimation() { }

	// RVA: 0x2238350 Offset: 0x2236D50 VA: 0x182238350
	private void UpdateAnimatedImage(object sender, EventArgs e) { }

	// RVA: 0x2239860 Offset: 0x2238260 VA: 0x182239860
	internal bool get_ShowMargin() { }

	// RVA: 0x22399F0 Offset: 0x22383F0 VA: 0x1822399F0
	internal bool get_UseImageMargin() { }

	// RVA: 0x71DB60 Offset: 0x71C560 VA: 0x18071DB60 Slot: 75
	internal virtual bool get_InternalVisible() { }

	// RVA: 0x223A100 Offset: 0x2238B00 VA: 0x18223A100
	internal void set_InternalOwner(ToolStrip value) { }

	// RVA: 0x2239810 Offset: 0x2238210 VA: 0x182239810
	internal Point get_Location() { }

	// RVA: 0x223A220 Offset: 0x2238C20 VA: 0x18223A220
	internal void set_Location(Point value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	internal int get_Top() { }

	// RVA: 0x223A630 Offset: 0x2239030 VA: 0x18223A630
	internal void set_Top(int value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	internal int get_Left() { }

	// RVA: 0x223A1A0 Offset: 0x2238BA0 VA: 0x18223A1A0
	internal void set_Left(int value) { }

	// RVA: 0x2239850 Offset: 0x2238250 VA: 0x182239850
	internal int get_Right() { }

	// RVA: 0x2239150 Offset: 0x2237B50 VA: 0x182239150
	internal int get_Bottom() { }

	// RVA: 0x2237C50 Offset: 0x2236650 VA: 0x182237C50
	internal void OnUIASelectionChanged() { }
}
