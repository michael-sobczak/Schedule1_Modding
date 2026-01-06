public class Control : Component, IDisposable, IComponent, ISynchronizeInvoke, IBindableComponent, IWin32Window // TypeDefIndex: 5290
{
	// Fields
	internal Rectangle bounds; // 0x28
	private Rectangle explicit_bounds; // 0x38
	internal object creator_thread; // 0x48
	internal Control.ControlNativeWindow window; // 0x50
	private IWindowTarget window_target; // 0x58
	private string name; // 0x60
	private bool is_created; // 0x68
	internal bool has_focus; // 0x69
	internal bool is_visible; // 0x6A
	internal bool is_entered; // 0x6B
	internal bool is_enabled; // 0x6C
	private bool is_captured; // 0x6D
	internal bool is_toplevel; // 0x6E
	private bool is_recreating; // 0x6F
	private bool causes_validation; // 0x70
	private bool is_focusing; // 0x71
	private int tab_index; // 0x74
	private bool tab_stop; // 0x78
	private bool is_disposed; // 0x79
	private bool is_disposing; // 0x7A
	private Size client_size; // 0x7C
	private Rectangle client_rect; // 0x84
	private ControlStyles control_style; // 0x94
	private ImeMode ime_mode; // 0x98
	internal int mouse_clicks; // 0x9C
	private Cursor cursor; // 0xA0
	internal bool allow_drop; // 0xA8
	private Region clip_region; // 0xB0
	internal Color foreground_color; // 0xB8
	internal Color background_color; // 0xD0
	private Image background_image; // 0xE8
	internal Font font; // 0xF0
	private string text; // 0xF8
	internal BorderStyle border_style; // 0x100
	private bool show_keyboard_cues; // 0x104
	internal bool show_focus_cues; // 0x105
	internal bool force_double_buffer; // 0x106
	private LayoutEngine layout_engine; // 0x108
	internal int layout_suspended; // 0x110
	private bool layout_pending; // 0x114
	internal AnchorStyles anchor_style; // 0x118
	internal DockStyle dock_style; // 0x11C
	private Control.LayoutType layout_type; // 0x120
	private bool recalculate_distances; // 0x124
	internal int dist_right; // 0x128
	internal int dist_bottom; // 0x12C
	private Control.ControlCollection child_controls; // 0x130
	private Control parent; // 0x138
	private BindingContext binding_context; // 0x140
	private RightToLeft right_to_left; // 0x148
	private ContextMenu context_menu; // 0x150
	internal bool use_compatible_text_rendering; // 0x158
	private bool use_wait_cursor; // 0x159
	private AccessibleRole accessible_role; // 0x15C
	private Control.DoubleBuffer backbuffer; // 0x160
	private ControlBindingsCollection data_bindings; // 0x168
	private static bool verify_thread_handle; // 0x0
	private Padding padding; // 0x170
	private ImageLayout backgroundimage_layout; // 0x184
	private Size maximum_size; // 0x188
	private Size minimum_size; // 0x190
	private Padding margin; // 0x198
	private ContextMenuStrip context_menu_strip; // 0x1B0
	private bool nested_layout; // 0x1B8
	private AutoSizeMode auto_size_mode; // 0x1BC
	private bool suppressing_key_press; // 0x1C0
	private MenuTracker active_tracker; // 0x1C8
	private bool auto_size; // 0x1D0
	private static object AutoSizeChangedEvent; // 0x8
	private static object BackColorChangedEvent; // 0x10
	private static object BackgroundImageChangedEvent; // 0x18
	private static object BackgroundImageLayoutChangedEvent; // 0x20
	private static object BindingContextChangedEvent; // 0x28
	private static object CausesValidationChangedEvent; // 0x30
	private static object ChangeUICuesEvent; // 0x38
	private static object ClickEvent; // 0x40
	private static object ClientSizeChangedEvent; // 0x48
	private static object ContextMenuChangedEvent; // 0x50
	private static object ContextMenuStripChangedEvent; // 0x58
	private static object ControlAddedEvent; // 0x60
	private static object ControlRemovedEvent; // 0x68
	private static object CursorChangedEvent; // 0x70
	private static object DockChangedEvent; // 0x78
	private static object DoubleClickEvent; // 0x80
	private static object DragDropEvent; // 0x88
	private static object DragEnterEvent; // 0x90
	private static object DragLeaveEvent; // 0x98
	private static object DragOverEvent; // 0xA0
	private static object EnabledChangedEvent; // 0xA8
	private static object EnterEvent; // 0xB0
	private static object FontChangedEvent; // 0xB8
	private static object ForeColorChangedEvent; // 0xC0
	private static object GiveFeedbackEvent; // 0xC8
	private static object GotFocusEvent; // 0xD0
	private static object HandleCreatedEvent; // 0xD8
	private static object HandleDestroyedEvent; // 0xE0
	private static object HelpRequestedEvent; // 0xE8
	private static object ImeModeChangedEvent; // 0xF0
	private static object InvalidatedEvent; // 0xF8
	private static object KeyDownEvent; // 0x100
	private static object KeyPressEvent; // 0x108
	private static object KeyUpEvent; // 0x110
	private static object LayoutEvent; // 0x118
	private static object LeaveEvent; // 0x120
	private static object LocationChangedEvent; // 0x128
	private static object LostFocusEvent; // 0x130
	private static object MarginChangedEvent; // 0x138
	private static object MouseCaptureChangedEvent; // 0x140
	private static object MouseClickEvent; // 0x148
	private static object MouseDoubleClickEvent; // 0x150
	private static object MouseDownEvent; // 0x158
	private static object MouseEnterEvent; // 0x160
	private static object MouseHoverEvent; // 0x168
	private static object MouseLeaveEvent; // 0x170
	private static object MouseMoveEvent; // 0x178
	private static object MouseUpEvent; // 0x180
	private static object MouseWheelEvent; // 0x188
	private static object MoveEvent; // 0x190
	private static object PaddingChangedEvent; // 0x198
	private static object PaintEvent; // 0x1A0
	private static object ParentChangedEvent; // 0x1A8
	private static object PreviewKeyDownEvent; // 0x1B0
	private static object QueryAccessibilityHelpEvent; // 0x1B8
	private static object QueryContinueDragEvent; // 0x1C0
	private static object RegionChangedEvent; // 0x1C8
	private static object ResizeEvent; // 0x1D0
	private static object RightToLeftChangedEvent; // 0x1D8
	private static object SizeChangedEvent; // 0x1E0
	private static object StyleChangedEvent; // 0x1E8
	private static object SystemColorsChangedEvent; // 0x1F0
	private static object TabIndexChangedEvent; // 0x1F8
	private static object TabStopChangedEvent; // 0x200
	private static object TextChangedEvent; // 0x208
	private static object ValidatedEvent; // 0x210
	private static object ValidatingEvent; // 0x218
	private static object VisibleChangedEvent; // 0x220

	// Properties
	internal Rectangle PaddingClientRectangle { get; }
	internal MenuTracker ActiveTracker { get; set; }
	internal bool InternalSelected { get; }
	internal bool InternalContainsFocus { get; }
	internal bool Entered { get; }
	internal bool VisibleInternal { get; }
	internal Control.LayoutType ControlLayoutType { get; }
	internal BorderStyle InternalBorderStyle { get; set; }
	internal Size InternalClientSize { set; }
	internal virtual bool ActivateOnShow { get; }
	internal Rectangle ExplicitBounds { get; set; }
	internal bool ValidationFailed { get; set; }
	internal bool IsRecreating { get; }
	internal Graphics DeviceContext { get; }
	private bool UseDoubleBuffering { get; }
	public static Color DefaultBackColor { get; }
	public static Font DefaultFont { get; }
	public static Color DefaultForeColor { get; }
	public static Keys ModifierKeys { get; }
	public static Point MousePosition { get; }
	[DefaultValue(False)]
	[MWFCategory("Behavior")]
	public virtual bool AllowDrop { get; }
	[Localizable(True)]
	[MWFCategory("Layout")]
	[RefreshProperties(2)]
	[DefaultValue(5)]
	public virtual AnchorStyles Anchor { get; set; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(1)]
	[DefaultValue(False)]
	[RefreshProperties(1)]
	[Localizable(True)]
	[Browsable(False)]
	public virtual bool AutoSize { get; set; }
	[MWFCategory("Layout")]
	[AmbientValue("{Width=0, Height=0}")]
	public virtual Size MaximumSize { get; }
	[MWFCategory("Layout")]
	public virtual Size MinimumSize { get; set; }
	[DispId(-501)]
	[MWFCategory("Appearance")]
	public virtual Color BackColor { get; set; }
	[DefaultValue(null)]
	[Localizable(True)]
	[MWFCategory("Appearance")]
	public virtual Image BackgroundImage { get; }
	[DefaultValue(1)]
	[Localizable(True)]
	[MWFCategory("Appearance")]
	public virtual ImageLayout BackgroundImageLayout { get; set; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual BindingContext BindingContext { get; set; }
	[Browsable(False)]
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	public int Bottom { get; }
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public Rectangle Bounds { get; set; }
	[Browsable(False)]
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	public bool CanFocus { get; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	[Browsable(False)]
	public bool CanSelect { get; }
	internal virtual bool InternalCapture { get; set; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public bool Capture { get; set; }
	[MWFCategory("Focus")]
	[DefaultValue(True)]
	public bool CausesValidation { get; set; }
	[Browsable(False)]
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	public Rectangle ClientRectangle { get; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	[Browsable(False)]
	public Size ClientSize { get; set; }
	[DefaultValue(null)]
	[MWFCategory("Behavior")]
	[Browsable(False)]
	public virtual ContextMenu ContextMenu { get; set; }
	internal virtual ContextMenu ContextMenuInternal { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(2)]
	public Control.ControlCollection Controls { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	public bool Created { get; }
	[AmbientValue(null)]
	[MWFCategory("Appearance")]
	public virtual Cursor Cursor { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	public virtual Rectangle DisplayRectangle { get; }
	[DefaultValue(0)]
	[MWFCategory("Layout")]
	[Localizable(True)]
	[RefreshProperties(2)]
	public virtual DockStyle Dock { get; set; }
	protected virtual bool DoubleBuffered { get; }
	[Localizable(True)]
	[MWFCategory("Behavior")]
	[DispId(-514)]
	public bool Enabled { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(2)]
	public virtual bool Focused { get; }
	[MWFCategory("Appearance")]
	[AmbientValue(null)]
	[DispId(-512)]
	[Localizable(True)]
	public virtual Font Font { get; set; }
	[DispId(-513)]
	[MWFCategory("Appearance")]
	public virtual Color ForeColor { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[DispId(-515)]
	public IntPtr Handle { get; }
	[EditorBrowsable(0)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public int Height { get; set; }
	[AmbientValue(-1)]
	[MWFCategory("Behavior")]
	[Localizable(True)]
	public ImeMode ImeMode { set; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	[Browsable(False)]
	public bool InvokeRequired { get; }
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool IsDisposed { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(2)]
	public bool IsHandleCreated { get; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	public virtual LayoutEngine LayoutEngine { get; }
	[EditorBrowsable(0)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Left { get; set; }
	[MWFCategory("Layout")]
	[Localizable(True)]
	public Point Location { get; set; }
	[MWFCategory("Layout")]
	[Localizable(True)]
	public Padding Margin { get; }
	[Browsable(False)]
	public string Name { get; set; }
	[Localizable(True)]
	[MWFCategory("Layout")]
	public Padding Padding { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public Control Parent { get; }
	[Browsable(False)]
	public Size PreferredSize { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(2)]
	public bool RecreatingHandle { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(2)]
	public Region Region { set; }
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Right { get; }
	[AmbientValue(2)]
	[MWFCategory("Appearance")]
	[Localizable(True)]
	public virtual RightToLeft RightToLeft { get; }
	[EditorBrowsable(2)]
	public override ISite Site { get; set; }
	[Localizable(True)]
	[MWFCategory("Layout")]
	public Size Size { get; set; }
	[Localizable(True)]
	[MergableProperty(False)]
	[MWFCategory("Behavior")]
	public int TabIndex { set; }
	[DispId(-516)]
	[MWFCategory("Behavior")]
	[DefaultValue(True)]
	public bool TabStop { get; set; }
	[MWFCategory("Appearance")]
	[DispId(-517)]
	[Bindable(True)]
	[Localizable(True)]
	public virtual string Text { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(0)]
	public int Top { get; set; }
	[Browsable(False)]
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	public Control TopLevelControl { get; }
	[Localizable(True)]
	[MWFCategory("Behavior")]
	public bool Visible { get; set; }
	[Browsable(False)]
	[EditorBrowsable(0)]
	[DesignerSerializationVisibility(0)]
	public int Width { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(1)]
	public IWindowTarget WindowTarget { get; }
	protected override bool CanRaiseEvents { get; }
	protected virtual CreateParams CreateParams { get; }
	protected virtual Cursor DefaultCursor { get; }
	protected virtual Padding DefaultMargin { get; }
	protected virtual Padding DefaultPadding { get; }
	protected virtual Size DefaultSize { get; }
	protected int FontHeight { get; }
	[EditorBrowsable(2)]
	protected virtual bool ScaleChildren { get; }
	internal virtual bool ScaleChildrenInternal { get; }
	[EditorBrowsable(2)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	protected internal virtual bool ShowFocusCues { get; }
	internal bool ShowKeyboardCuesInternal { get; }

	// Methods

	// RVA: 0x23000F0 Offset: 0x22FEAF0 VA: 0x1823000F0
	public void .ctor() { }

	// RVA: 0x22FED20 Offset: 0x22FD720 VA: 0x1822FED20
	private static void .cctor() { }

	// RVA: 0x2300550 Offset: 0x22FEF50 VA: 0x182300550
	public void add_BackgroundImageChanged(EventHandler value) { }

	// RVA: 0x2302E50 Offset: 0x2301850 VA: 0x182302E50
	public void remove_BackgroundImageChanged(EventHandler value) { }

	// RVA: 0x23005E0 Offset: 0x22FEFE0 VA: 0x1823005E0
	public void add_Click(EventHandler value) { }

	// RVA: 0x2302EE0 Offset: 0x23018E0 VA: 0x182302EE0
	public void remove_Click(EventHandler value) { }

	// RVA: 0x2300670 Offset: 0x22FF070 VA: 0x182300670
	public void add_ControlRemoved(ControlEventHandler value) { }

	// RVA: 0x2302F70 Offset: 0x2301970 VA: 0x182302F70
	public void remove_ControlRemoved(ControlEventHandler value) { }

	// RVA: 0x2300700 Offset: 0x22FF100 VA: 0x182300700
	public void add_DoubleClick(EventHandler value) { }

	// RVA: 0x2303000 Offset: 0x2301A00 VA: 0x182303000
	public void remove_DoubleClick(EventHandler value) { }

	// RVA: 0x2300790 Offset: 0x22FF190 VA: 0x182300790
	public void add_EnabledChanged(EventHandler value) { }

	// RVA: 0x2303090 Offset: 0x2301A90 VA: 0x182303090
	public void remove_EnabledChanged(EventHandler value) { }

	// RVA: 0x2300820 Offset: 0x22FF220 VA: 0x182300820
	public void add_FontChanged(EventHandler value) { }

	// RVA: 0x2303120 Offset: 0x2301B20 VA: 0x182303120
	public void remove_FontChanged(EventHandler value) { }

	// RVA: 0x23008B0 Offset: 0x22FF2B0 VA: 0x1823008B0
	public void add_ForeColorChanged(EventHandler value) { }

	// RVA: 0x23031B0 Offset: 0x2301BB0 VA: 0x1823031B0
	public void remove_ForeColorChanged(EventHandler value) { }

	// RVA: 0x2300940 Offset: 0x22FF340 VA: 0x182300940
	public void add_GotFocus(EventHandler value) { }

	// RVA: 0x2303240 Offset: 0x2301C40 VA: 0x182303240
	public void remove_GotFocus(EventHandler value) { }

	// RVA: 0x23009D0 Offset: 0x22FF3D0 VA: 0x1823009D0
	public void add_HandleCreated(EventHandler value) { }

	// RVA: 0x23032D0 Offset: 0x2301CD0 VA: 0x1823032D0
	public void remove_HandleCreated(EventHandler value) { }

	// RVA: 0x2300A60 Offset: 0x22FF460 VA: 0x182300A60
	public void add_HandleDestroyed(EventHandler value) { }

	// RVA: 0x2303360 Offset: 0x2301D60 VA: 0x182303360
	public void remove_HandleDestroyed(EventHandler value) { }

	// RVA: 0x2300AF0 Offset: 0x22FF4F0 VA: 0x182300AF0
	public void add_Invalidated(InvalidateEventHandler value) { }

	// RVA: 0x23033F0 Offset: 0x2301DF0 VA: 0x1823033F0
	public void remove_Invalidated(InvalidateEventHandler value) { }

	// RVA: 0x2300B80 Offset: 0x22FF580 VA: 0x182300B80
	public void add_KeyDown(KeyEventHandler value) { }

	// RVA: 0x2303480 Offset: 0x2301E80 VA: 0x182303480
	public void remove_KeyDown(KeyEventHandler value) { }

	// RVA: 0x2300C10 Offset: 0x22FF610 VA: 0x182300C10
	public void add_KeyPress(KeyPressEventHandler value) { }

	// RVA: 0x2303510 Offset: 0x2301F10 VA: 0x182303510
	public void remove_KeyPress(KeyPressEventHandler value) { }

	// RVA: 0x2300CA0 Offset: 0x22FF6A0 VA: 0x182300CA0
	public void add_LocationChanged(EventHandler value) { }

	// RVA: 0x23035A0 Offset: 0x2301FA0 VA: 0x1823035A0
	public void remove_LocationChanged(EventHandler value) { }

	// RVA: 0x2300D30 Offset: 0x22FF730 VA: 0x182300D30
	public void add_LostFocus(EventHandler value) { }

	// RVA: 0x2303630 Offset: 0x2302030 VA: 0x182303630
	public void remove_LostFocus(EventHandler value) { }

	// RVA: 0x2300DC0 Offset: 0x22FF7C0 VA: 0x182300DC0
	public void add_MouseCaptureChanged(EventHandler value) { }

	// RVA: 0x23036C0 Offset: 0x23020C0 VA: 0x1823036C0
	public void remove_MouseCaptureChanged(EventHandler value) { }

	// RVA: 0x2300E50 Offset: 0x22FF850 VA: 0x182300E50
	public void add_MouseDown(MouseEventHandler value) { }

	// RVA: 0x2303750 Offset: 0x2302150 VA: 0x182303750
	public void remove_MouseDown(MouseEventHandler value) { }

	// RVA: 0x2300EE0 Offset: 0x22FF8E0 VA: 0x182300EE0
	public void add_MouseEnter(EventHandler value) { }

	// RVA: 0x23037E0 Offset: 0x23021E0 VA: 0x1823037E0
	public void remove_MouseEnter(EventHandler value) { }

	// RVA: 0x2300F70 Offset: 0x22FF970 VA: 0x182300F70
	public void add_MouseHover(EventHandler value) { }

	// RVA: 0x2303870 Offset: 0x2302270 VA: 0x182303870
	public void remove_MouseHover(EventHandler value) { }

	// RVA: 0x2301000 Offset: 0x22FFA00 VA: 0x182301000
	public void add_MouseLeave(EventHandler value) { }

	// RVA: 0x2303900 Offset: 0x2302300 VA: 0x182303900
	public void remove_MouseLeave(EventHandler value) { }

	// RVA: 0x2301090 Offset: 0x22FFA90 VA: 0x182301090
	public void add_MouseMove(MouseEventHandler value) { }

	// RVA: 0x2303990 Offset: 0x2302390 VA: 0x182303990
	public void remove_MouseMove(MouseEventHandler value) { }

	// RVA: 0x2301120 Offset: 0x22FFB20 VA: 0x182301120
	public void add_MouseUp(MouseEventHandler value) { }

	// RVA: 0x2303A20 Offset: 0x2302420 VA: 0x182303A20
	public void remove_MouseUp(MouseEventHandler value) { }

	// RVA: 0x23011B0 Offset: 0x22FFBB0 VA: 0x1823011B0
	public void add_MouseWheel(MouseEventHandler value) { }

	// RVA: 0x2303AB0 Offset: 0x23024B0 VA: 0x182303AB0
	public void remove_MouseWheel(MouseEventHandler value) { }

	// RVA: 0x2301240 Offset: 0x22FFC40 VA: 0x182301240
	public void add_PaddingChanged(EventHandler value) { }

	// RVA: 0x2303B40 Offset: 0x2302540 VA: 0x182303B40
	public void remove_PaddingChanged(EventHandler value) { }

	// RVA: 0x23012D0 Offset: 0x22FFCD0 VA: 0x1823012D0
	public void add_Paint(PaintEventHandler value) { }

	// RVA: 0x2303BD0 Offset: 0x23025D0 VA: 0x182303BD0
	public void remove_Paint(PaintEventHandler value) { }

	// RVA: 0x2301360 Offset: 0x22FFD60 VA: 0x182301360
	public void add_ParentChanged(EventHandler value) { }

	// RVA: 0x2303C60 Offset: 0x2302660 VA: 0x182303C60
	public void remove_ParentChanged(EventHandler value) { }

	// RVA: 0x23013F0 Offset: 0x22FFDF0 VA: 0x1823013F0
	public void add_Resize(EventHandler value) { }

	// RVA: 0x2303CF0 Offset: 0x23026F0 VA: 0x182303CF0
	public void remove_Resize(EventHandler value) { }

	// RVA: 0x2301480 Offset: 0x22FFE80 VA: 0x182301480
	public void add_RightToLeftChanged(EventHandler value) { }

	// RVA: 0x2303D80 Offset: 0x2302780 VA: 0x182303D80
	public void remove_RightToLeftChanged(EventHandler value) { }

	// RVA: 0x2301510 Offset: 0x22FFF10 VA: 0x182301510
	public void add_SizeChanged(EventHandler value) { }

	// RVA: 0x2303E10 Offset: 0x2302810 VA: 0x182303E10
	public void remove_SizeChanged(EventHandler value) { }

	// RVA: 0x23015A0 Offset: 0x22FFFA0 VA: 0x1823015A0
	public void add_TextChanged(EventHandler value) { }

	// RVA: 0x2303EA0 Offset: 0x23028A0 VA: 0x182303EA0
	public void remove_TextChanged(EventHandler value) { }

	// RVA: 0x2301630 Offset: 0x2300030 VA: 0x182301630
	public void add_Validating(CancelEventHandler value) { }

	// RVA: 0x2303F30 Offset: 0x2302930 VA: 0x182303F30
	public void remove_Validating(CancelEventHandler value) { }

	// RVA: 0x23016C0 Offset: 0x23000C0 VA: 0x1823016C0
	public void add_VisibleChanged(EventHandler value) { }

	// RVA: 0x2303FC0 Offset: 0x23029C0 VA: 0x182303FC0
	public void remove_VisibleChanged(EventHandler value) { }

	// RVA: 0x22EFF40 Offset: 0x22EE940 VA: 0x1822EFF40 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2302860 Offset: 0x2301260 VA: 0x182302860
	internal Rectangle get_PaddingClientRectangle() { }

	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	internal MenuTracker get_ActiveTracker() { }

	// RVA: 0x2304050 Offset: 0x2302A50 VA: 0x182304050
	internal void set_ActiveTracker(MenuTracker value) { }

	// RVA: 0x23025A0 Offset: 0x2300FA0 VA: 0x1823025A0
	internal bool get_InternalSelected() { }

	// RVA: 0x23024A0 Offset: 0x2300EA0 VA: 0x1823024A0
	internal bool get_InternalContainsFocus() { }

	// RVA: 0xCE3D80 Offset: 0xCE2780 VA: 0x180CE3D80
	internal bool get_Entered() { }

	// RVA: 0xCE3DD0 Offset: 0xCE27D0 VA: 0x180CE3DD0
	internal bool get_VisibleInternal() { }

	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	internal Control.LayoutType get_ControlLayoutType() { }

	// RVA: 0x2302490 Offset: 0x2300E90 VA: 0x182302490
	internal BorderStyle get_InternalBorderStyle() { }

	// RVA: 0x2305340 Offset: 0x2303D40 VA: 0x182305340
	internal void set_InternalBorderStyle(BorderStyle value) { }

	// RVA: 0xCE3E10 Offset: 0xCE2810 VA: 0x180CE3E10
	internal void set_InternalClientSize(Size value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 18
	internal virtual bool get_ActivateOnShow() { }

	// RVA: 0x4F9F20 Offset: 0x4F8920 VA: 0x1804F9F20
	internal Rectangle get_ExplicitBounds() { }

	// RVA: 0x1440050 Offset: 0x143EA50 VA: 0x181440050
	internal void set_ExplicitBounds(Rectangle value) { }

	// RVA: 0x2302DF0 Offset: 0x23017F0 VA: 0x182302DF0
	internal bool get_ValidationFailed() { }

	// RVA: 0x23061C0 Offset: 0x2304BC0 VA: 0x1823061C0
	internal void set_ValidationFailed(bool value) { }

	// RVA: 0x22EED20 Offset: 0x22ED720 VA: 0x1822EED20
	internal IAsyncResult BeginInvokeInternal(Delegate method, object[] args) { }

	// RVA: 0x22EED70 Offset: 0x22ED770 VA: 0x1822EED70
	internal IAsyncResult BeginInvokeInternal(Delegate method, object[] args, Control control) { }

	// RVA: 0x22F1890 Offset: 0x22F0290 VA: 0x1822F1890
	private IntPtr GetInvokableHandle() { }

	// RVA: 0x22F7BD0 Offset: 0x22F65D0 VA: 0x1822F7BD0
	internal void PointToClient(ref int x, ref int y) { }

	// RVA: 0x2302760 Offset: 0x2301160 VA: 0x182302760
	internal bool get_IsRecreating() { }

	// RVA: 0x2302070 Offset: 0x2300A70 VA: 0x182302070
	internal Graphics get_DeviceContext() { }

	// RVA: 0x17C2860 Offset: 0x17C1260 VA: 0x1817C2860 Slot: 19
	internal virtual int OverrideHeight(int height) { }

	// RVA: 0x22F7F30 Offset: 0x22F6930 VA: 0x1822F7F30
	private void ProcessActiveTracker(ref Message m) { }

	// RVA: 0x22F0C30 Offset: 0x22EF630 VA: 0x1822F0C30
	private Control FindControlToInvokeOn() { }

	// RVA: 0x22F2650 Offset: 0x22F1050 VA: 0x1822F2650
	private void InvalidateBackBuffer() { }

	// RVA: 0x22F1470 Offset: 0x22EFE70 VA: 0x1822F1470
	private Control.DoubleBuffer GetBackBuffer() { }

	// RVA: 0x22EFEF0 Offset: 0x22EE8F0 VA: 0x1822EFEF0
	private void DisposeBackBuffer() { }

	// RVA: 0x22F9820 Offset: 0x22F8220 VA: 0x1822F9820
	internal static void SetChildColor(Control parent) { }

	// RVA: 0x22F8EF0 Offset: 0x22F78F0 VA: 0x1822F8EF0
	internal bool Select(Control control) { }

	// RVA: 0x22F2FC0 Offset: 0x22F19C0 VA: 0x1822F2FC0
	internal static IntPtr MakeParam(int low, int high) { }

	// RVA: 0x1BC6B40 Offset: 0x1BC5540 VA: 0x181BC6B40
	internal static int LowOrder(int param) { }

	// RVA: 0x22F22B0 Offset: 0x22F0CB0 VA: 0x1822F22B0
	internal static int HighOrder(long param) { }

	// RVA: 0x22F7270 Offset: 0x22F5C70 VA: 0x1822F7270 Slot: 20
	internal virtual void PaintControlBackground(PaintEventArgs pevent) { }

	// RVA: 0x22F0300 Offset: 0x22EED00 VA: 0x1822F0300
	private void DrawBackgroundImage(Graphics g) { }

	// RVA: 0x22F0280 Offset: 0x22EEC80 VA: 0x1822F0280 Slot: 21
	internal virtual void DndEnter(DragEventArgs e) { }

	// RVA: 0x22F02E0 Offset: 0x22EECE0 VA: 0x1822F02E0 Slot: 22
	internal virtual void DndOver(DragEventArgs e) { }

	// RVA: 0x22F01D0 Offset: 0x22EEBD0 VA: 0x1822F01D0 Slot: 23
	internal virtual void DndDrop(DragEventArgs e) { }

	// RVA: 0x22F02C0 Offset: 0x22EECC0 VA: 0x1822F02C0 Slot: 24
	internal virtual void DndLeave(EventArgs e) { }

	// RVA: 0x22F02A0 Offset: 0x22EECA0 VA: 0x1822F02A0 Slot: 25
	internal virtual void DndFeedback(GiveFeedbackEventArgs e) { }

	// RVA: 0x22F01B0 Offset: 0x22EEBB0 VA: 0x1822F01B0 Slot: 26
	internal virtual void DndContinueDrag(QueryContinueDragEventArgs e) { }

	// RVA: 0x22F13A0 Offset: 0x22EFDA0 VA: 0x1822F13A0
	internal static MouseButtons FromParamToMouseButtons(long param) { }

	// RVA: 0x22F1160 Offset: 0x22EFB60 VA: 0x1822F1160 Slot: 27
	internal virtual void FireEnter() { }

	// RVA: 0x22F11D0 Offset: 0x22EFBD0 VA: 0x1822F11D0 Slot: 28
	internal virtual void FireLeave() { }

	// RVA: 0x22F12B0 Offset: 0x22EFCB0 VA: 0x1822F12B0 Slot: 29
	internal virtual void FireValidating(CancelEventArgs ce) { }

	// RVA: 0x22F1240 Offset: 0x22EFC40 VA: 0x1822F1240 Slot: 30
	internal virtual void FireValidated() { }

	// RVA: 0x22F8240 Offset: 0x22F6C40 VA: 0x1822F8240 Slot: 31
	internal virtual bool ProcessControlMnemonic(char charCode) { }

	// RVA: 0x22F0EE0 Offset: 0x22EF8E0 VA: 0x1822F0EE0
	private static Control FindFlatForward(Control container, Control start) { }

	// RVA: 0x22F0AE0 Offset: 0x22EF4E0 VA: 0x1822F0AE0
	private static Control FindControlForward(Control container, Control start) { }

	// RVA: 0x22F0D40 Offset: 0x22EF740 VA: 0x1822F0D40
	private static Control FindFlatBackward(Control container, Control start) { }

	// RVA: 0x22F0950 Offset: 0x22EF350 VA: 0x1822F0950
	private static Control FindControlBackward(Control container, Control start) { }

	// RVA: 0x22F21D0 Offset: 0x22F0BD0 VA: 0x1822F21D0 Slot: 32
	internal virtual void HandleClick(int clicks, MouseEventArgs me) { }

	// RVA: 0x22EEFD0 Offset: 0x22ED9D0 VA: 0x1822EEFD0
	internal void CaptureWithConfine(Control ConfineWindow) { }

	// RVA: 0x22EF650 Offset: 0x22EE050 VA: 0x1822EF650
	private void CheckDataBindings() { }

	// RVA: 0x22EF070 Offset: 0x22EDA70 VA: 0x1822EF070
	private void ChangeParent(Control new_parent) { }

	// RVA: 0x22F2540 Offset: 0x22F0F40 VA: 0x1822F2540
	internal Size InternalSizeFromClientSize(Size clientSize) { }

	// RVA: 0x22EF840 Offset: 0x22EE240 VA: 0x1822EF840
	internal Size ClientSizeFromSize(Size size) { }

	// RVA: 0x1C912C0 Offset: 0x1C8FCC0 VA: 0x181C912C0
	internal CreateParams GetCreateParams() { }

	// RVA: 0x22F1B00 Offset: 0x22F0500 VA: 0x1822F1B00 Slot: 33
	internal virtual Size GetPreferredSizeCore(Size proposedSize) { }

	// RVA: 0x22FAA70 Offset: 0x22F9470 VA: 0x1822FAA70
	private void UpdateDistances() { }

	// RVA: 0x22F13D0 Offset: 0x22EFDD0 VA: 0x1822F13D0
	private Cursor GetAvailableCursor() { }

	// RVA: 0x22FA910 Offset: 0x22F9310 VA: 0x1822FA910
	private void UpdateCursor() { }

	// RVA: 0x2302D10 Offset: 0x2301710 VA: 0x182302D10
	private bool get_UseDoubleBuffering() { }

	// RVA: 0x22F69A0 Offset: 0x22F53A0 VA: 0x1822F69A0
	internal void OnSizeInitializedOrChanged() { }

	// RVA: 0x2301DE0 Offset: 0x23007E0 VA: 0x182301DE0
	public static Color get_DefaultBackColor() { }

	// RVA: 0x2301EB0 Offset: 0x23008B0 VA: 0x182301EB0
	public static Font get_DefaultFont() { }

	// RVA: 0x2301F50 Offset: 0x2300950 VA: 0x182301F50
	public static Color get_DefaultForeColor() { }

	// RVA: 0x2302840 Offset: 0x2301240 VA: 0x182302840
	public static Keys get_ModifierKeys() { }

	// RVA: 0x2302850 Offset: 0x2301250 VA: 0x182302850
	public static Point get_MousePosition() { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0 Slot: 34
	public virtual bool get_AllowDrop() { }

	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0 Slot: 35
	public virtual AnchorStyles get_Anchor() { }

	// RVA: 0x23040A0 Offset: 0x2302AA0 VA: 0x1823040A0 Slot: 36
	public virtual void set_Anchor(AnchorStyles value) { }

	// RVA: 0xAADD90 Offset: 0xAAC790 VA: 0x180AADD90 Slot: 37
	public virtual bool get_AutoSize() { }

	// RVA: 0x2304170 Offset: 0x2302B70 VA: 0x182304170 Slot: 38
	public virtual void set_AutoSize(bool value) { }

	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380 Slot: 39
	public virtual Size get_MaximumSize() { }

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290 Slot: 40
	public virtual Size get_MinimumSize() { }

	// RVA: 0x2305820 Offset: 0x2304220 VA: 0x182305820 Slot: 41
	public virtual void set_MinimumSize(Size value) { }

	// RVA: 0x2301750 Offset: 0x2300150 VA: 0x182301750 Slot: 42
	public virtual Color get_BackColor() { }

	// RVA: 0x2304250 Offset: 0x2302C50 VA: 0x182304250 Slot: 43
	public virtual void set_BackColor(Color value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0 Slot: 44
	public virtual Image get_BackgroundImage() { }

	// RVA: 0x726440 Offset: 0x724E40 VA: 0x180726440 Slot: 45
	public virtual ImageLayout get_BackgroundImageLayout() { }

	// RVA: 0x2304410 Offset: 0x2302E10 VA: 0x182304410 Slot: 46
	public virtual void set_BackgroundImageLayout(ImageLayout value) { }

	// RVA: 0x2301910 Offset: 0x2300310 VA: 0x182301910 Slot: 47
	public virtual BindingContext get_BindingContext() { }

	// RVA: 0x2304600 Offset: 0x2303000 VA: 0x182304600 Slot: 48
	public virtual void set_BindingContext(BindingContext value) { }

	// RVA: 0x2301980 Offset: 0x2300380 VA: 0x182301980
	public int get_Bottom() { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510 Slot: 49
	public Rectangle get_Bounds() { }

	// RVA: 0x23046A0 Offset: 0x23030A0 VA: 0x1823046A0
	public void set_Bounds(Rectangle value) { }

	// RVA: 0x2301990 Offset: 0x2300390 VA: 0x182301990
	public bool get_CanFocus() { }

	// RVA: 0x2301A00 Offset: 0x2300400 VA: 0x182301A00
	public bool get_CanSelect() { }

	// RVA: 0xC0DCB0 Offset: 0xC0C6B0 VA: 0x180C0DCB0 Slot: 50
	internal virtual bool get_InternalCapture() { }

	// RVA: 0x23055A0 Offset: 0x2303FA0 VA: 0x1823055A0 Slot: 51
	internal virtual void set_InternalCapture(bool value) { }

	// RVA: 0xC0DCB0 Offset: 0xC0C6B0 VA: 0x180C0DCB0
	public bool get_Capture() { }

	// RVA: 0x2304800 Offset: 0x2303200 VA: 0x182304800
	public void set_Capture(bool value) { }

	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_CausesValidation() { }

	// RVA: 0x23048C0 Offset: 0x23032C0 VA: 0x1823048C0
	public void set_CausesValidation(bool value) { }

	// RVA: 0x2301A50 Offset: 0x2300450 VA: 0x182301A50
	public Rectangle get_ClientRectangle() { }

	// RVA: 0xCE3DB0 Offset: 0xCE27B0 VA: 0x180CE3DB0
	public Size get_ClientSize() { }

	// RVA: 0x2304940 Offset: 0x2303340 VA: 0x182304940
	public void set_ClientSize(Size value) { }

	// RVA: 0x2301A80 Offset: 0x2300480 VA: 0x182301A80 Slot: 52
	public virtual ContextMenu get_ContextMenu() { }

	// RVA: 0x2304A80 Offset: 0x2303480 VA: 0x182304A80 Slot: 53
	public virtual void set_ContextMenu(ContextMenu value) { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010 Slot: 54
	internal virtual ContextMenu get_ContextMenuInternal() { }

	// RVA: 0x23049E0 Offset: 0x23033E0 VA: 0x1823049E0 Slot: 55
	internal virtual void set_ContextMenuInternal(ContextMenu value) { }

	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public Control.ControlCollection get_Controls() { }

	// RVA: 0x2301D30 Offset: 0x2300730 VA: 0x182301D30
	public bool get_Created() { }

	// RVA: 0x2301D50 Offset: 0x2300750 VA: 0x182301D50 Slot: 56
	public virtual Cursor get_Cursor() { }

	// RVA: 0x2304AA0 Offset: 0x23034A0 VA: 0x182304AA0 Slot: 57
	public virtual void set_Cursor(Cursor value) { }

	// RVA: 0x2301A50 Offset: 0x2300450 VA: 0x182301A50 Slot: 58
	public virtual Rectangle get_DisplayRectangle() { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340 Slot: 59
	public virtual DockStyle get_Dock() { }

	// RVA: 0x2304B50 Offset: 0x2303550 VA: 0x182304B50 Slot: 60
	public virtual void set_Dock(DockStyle value) { }

	// RVA: 0x23020B0 Offset: 0x2300AB0 VA: 0x1823020B0 Slot: 61
	protected virtual bool get_DoubleBuffered() { }

	// RVA: 0x23020C0 Offset: 0x2300AC0 VA: 0x1823020C0
	public bool get_Enabled() { }

	// RVA: 0x2304DB0 Offset: 0x23037B0 VA: 0x182304DB0
	public void set_Enabled(bool value) { }

	// RVA: 0xCE3D90 Offset: 0xCE2790 VA: 0x180CE3D90 Slot: 62
	public virtual bool get_Focused() { }

	// RVA: 0x2302120 Offset: 0x2300B20 VA: 0x182302120 Slot: 63
	public virtual Font get_Font() { }

	// RVA: 0x2304F70 Offset: 0x2303970 VA: 0x182304F70 Slot: 64
	public virtual void set_Font(Font value) { }

	// RVA: 0x2302240 Offset: 0x2300C40 VA: 0x182302240 Slot: 65
	public virtual Color get_ForeColor() { }

	// RVA: 0x2305060 Offset: 0x2303A60 VA: 0x182305060 Slot: 66
	public virtual void set_ForeColor(Color value) { }

	// RVA: 0x2302390 Offset: 0x2300D90 VA: 0x182302390 Slot: 17
	public IntPtr get_Handle() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_Height() { }

	// RVA: 0x2305180 Offset: 0x2303B80 VA: 0x182305180
	public void set_Height(int value) { }

	// RVA: 0x23052B0 Offset: 0x2303CB0 VA: 0x1823052B0
	public void set_ImeMode(ImeMode value) { }

	// RVA: 0x2302680 Offset: 0x2301080 VA: 0x182302680 Slot: 14
	public bool get_InvokeRequired() { }

	// RVA: 0x1E01A60 Offset: 0x1E00460 VA: 0x181E01A60
	public bool get_IsDisposed() { }

	// RVA: 0x23026C0 Offset: 0x23010C0 VA: 0x1823026C0
	public bool get_IsHandleCreated() { }

	// RVA: 0x2302770 Offset: 0x2301170 VA: 0x182302770 Slot: 67
	public virtual LayoutEngine get_LayoutEngine() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_Left() { }

	// RVA: 0x23055B0 Offset: 0x2303FB0 VA: 0x1823055B0
	public void set_Left(int value) { }

	// RVA: 0x23027F0 Offset: 0x23011F0 VA: 0x1823027F0
	public Point get_Location() { }

	// RVA: 0x23056E0 Offset: 0x23040E0 VA: 0x1823056E0
	public void set_Location(Point value) { }

	// RVA: 0x2302820 Offset: 0x2301220 VA: 0x182302820
	public Padding get_Margin() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Name() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Name(string value) { }

	// RVA: 0x2302A00 Offset: 0x2301400 VA: 0x182302A00
	public Padding get_Padding() { }

	// RVA: 0x23058B0 Offset: 0x23042B0 VA: 0x1823058B0
	public void set_Padding(Padding value) { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public Control get_Parent() { }

	// RVA: 0x2302A20 Offset: 0x2301420 VA: 0x182302A20
	public Size get_PreferredSize() { }

	// RVA: 0x2302760 Offset: 0x2301160 VA: 0x182302760
	public bool get_RecreatingHandle() { }

	// RVA: 0x2305A10 Offset: 0x2304410 VA: 0x182305A10
	public void set_Region(Region value) { }

	// RVA: 0x2302AC0 Offset: 0x23014C0 VA: 0x182302AC0
	public int get_Right() { }

	// RVA: 0x2302A80 Offset: 0x2301480 VA: 0x182302A80 Slot: 68
	public virtual RightToLeft get_RightToLeft() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 10
	public override ISite get_Site() { }

	// RVA: 0x2305B00 Offset: 0x2304500 VA: 0x182305B00 Slot: 11
	public override void set_Site(ISite value) { }

	// RVA: 0x2302C30 Offset: 0x2301630 VA: 0x182302C30
	public Size get_Size() { }

	// RVA: 0x2305CF0 Offset: 0x23046F0 VA: 0x182305CF0
	public void set_Size(Size value) { }

	// RVA: 0x2305E30 Offset: 0x2304830 VA: 0x182305E30
	public void set_TabIndex(int value) { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_TabStop() { }

	// RVA: 0x2305EB0 Offset: 0x23048B0 VA: 0x182305EB0
	public void set_TabStop(bool value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 69
	public virtual string get_Text() { }

	// RVA: 0x2305F30 Offset: 0x2304930 VA: 0x182305F30 Slot: 70
	public virtual void set_Text(string value) { }

	// RVA: 0x22FABE0 Offset: 0x22F95E0 VA: 0x1822FABE0 Slot: 71
	internal virtual void UpdateWindowText() { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_Top() { }

	// RVA: 0x2306090 Offset: 0x2304A90 VA: 0x182306090
	public void set_Top(int value) { }

	// RVA: 0x2302C60 Offset: 0x2301660 VA: 0x182302C60
	public Control get_TopLevelControl() { }

	// RVA: 0x2302E20 Offset: 0x2301820 VA: 0x182302E20
	public bool get_Visible() { }

	// RVA: 0x23061F0 Offset: 0x2304BF0 VA: 0x1823061F0
	public void set_Visible(bool value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_Width() { }

	// RVA: 0x2306270 Offset: 0x2304C70 VA: 0x182306270
	public void set_Width(int value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public IWindowTarget get_WindowTarget() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	protected override bool get_CanRaiseEvents() { }

	// RVA: 0x2301AA0 Offset: 0x23004A0 VA: 0x182301AA0 Slot: 72
	protected virtual CreateParams get_CreateParams() { }

	// RVA: 0x2301EA0 Offset: 0x23008A0 VA: 0x182301EA0 Slot: 73
	protected virtual Cursor get_DefaultCursor() { }

	// RVA: 0x2302010 Offset: 0x2300A10 VA: 0x182302010 Slot: 74
	protected virtual Padding get_DefaultMargin() { }

	// RVA: 0x2239370 Offset: 0x2237D70 VA: 0x182239370 Slot: 75
	protected virtual Padding get_DefaultPadding() { }

	// RVA: 0x2302040 Offset: 0x2300A40 VA: 0x182302040 Slot: 76
	protected virtual Size get_DefaultSize() { }

	// RVA: 0x23020F0 Offset: 0x2300AF0 VA: 0x1823020F0
	protected int get_FontHeight() { }

	// RVA: 0x2302AD0 Offset: 0x23014D0 VA: 0x182302AD0 Slot: 77
	protected virtual bool get_ScaleChildren() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 78
	internal virtual bool get_ScaleChildrenInternal() { }

	// RVA: 0x2302AF0 Offset: 0x23014F0 VA: 0x182302AF0 Slot: 79
	protected internal virtual bool get_ShowFocusCues() { }

	// RVA: 0x2302BF0 Offset: 0x23015F0 VA: 0x182302BF0
	internal bool get_ShowKeyboardCuesInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F1390 Offset: 0x22EFD90 VA: 0x1822F1390
	public static Control FromHandle(IntPtr handle) { }

	// RVA: 0x22F2ED0 Offset: 0x22F18D0 VA: 0x1822F2ED0
	public static bool IsMnemonic(char charCode, string text) { }

	[EditorBrowsable(2)]
	// RVA: 0x22EED20 Offset: 0x22ED720 VA: 0x1822EED20 Slot: 15
	public IAsyncResult BeginInvoke(Delegate method, object[] args) { }

	// RVA: 0x22EEF10 Offset: 0x22ED910 VA: 0x1822EEF10
	public void BringToFront() { }

	// RVA: 0x22EF900 Offset: 0x22EE300 VA: 0x1822EF900
	public bool Contains(Control ctl) { }

	// RVA: 0x22EF920 Offset: 0x22EE320 VA: 0x1822EF920
	public void CreateControl() { }

	// RVA: 0x22EFAA0 Offset: 0x22EE4A0 VA: 0x1822EFAA0
	public Graphics CreateGraphics() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F0830 Offset: 0x22EF230 VA: 0x1822F0830 Slot: 80
	public object EndInvoke(IAsyncResult asyncResult) { }

	// RVA: 0x22F1120 Offset: 0x22EFB20 VA: 0x1822F1120
	internal Control FindRootParent() { }

	// RVA: 0x22F1080 Offset: 0x22EFA80 VA: 0x1822F1080
	public Form FindForm() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F1370 Offset: 0x22EFD70 VA: 0x1822F1370
	public bool Focus() { }

	// RVA: 0x22F12D0 Offset: 0x22EFCD0 VA: 0x1822F12D0 Slot: 81
	internal virtual bool FocusInternal(bool skip_check) { }

	// RVA: 0x22F1BB0 Offset: 0x22F05B0 VA: 0x1822F1BB0
	internal Control GetRealChildAtPoint(Point pt) { }

	// RVA: 0x22F14F0 Offset: 0x22EFEF0 VA: 0x1822F14F0
	public Control GetChildAtPoint(Point pt) { }

	// RVA: 0x22F1500 Offset: 0x22EFF00 VA: 0x1822F1500
	public Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue) { }

	// RVA: 0x22F17F0 Offset: 0x22F01F0 VA: 0x1822F17F0
	public IContainerControl GetContainerControl() { }

	// RVA: 0x22F22C0 Offset: 0x22F0CC0 VA: 0x1822F22C0
	internal ContainerControl InternalGetContainerControl() { }

	// RVA: 0x22F18E0 Offset: 0x22F02E0 VA: 0x1822F18E0
	public Control GetNextControl(Control ctl, bool forward) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F1B10 Offset: 0x22F0510 VA: 0x1822F1B10 Slot: 82
	public virtual Size GetPreferredSize(Size proposedSize) { }

	// RVA: 0x22F22A0 Offset: 0x22F0CA0 VA: 0x1822F22A0
	public void Hide() { }

	// RVA: 0x22F2C40 Offset: 0x22F1640 VA: 0x1822F2C40
	public void Invalidate() { }

	// RVA: 0x22F2C80 Offset: 0x22F1680 VA: 0x1822F2C80
	public void Invalidate(bool invalidateChildren) { }

	// RVA: 0x22F2750 Offset: 0x22F1150 VA: 0x1822F2750
	public void Invalidate(Rectangle rc) { }

	// RVA: 0x22F2870 Offset: 0x22F1270 VA: 0x1822F2870
	public void Invalidate(Rectangle rc, bool invalidateChildren) { }

	// RVA: 0x22F2670 Offset: 0x22F1070 VA: 0x1822F2670
	public void Invalidate(Region region) { }

	// RVA: 0x22F2780 Offset: 0x22F1180 VA: 0x1822F2780
	public void Invalidate(Region region, bool invalidateChildren) { }

	// RVA: 0x22F2CC0 Offset: 0x22F16C0 VA: 0x1822F2CC0 Slot: 83
	public object Invoke(Delegate method, object[] args) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F79A0 Offset: 0x22F63A0 VA: 0x1822F79A0
	public void PerformLayout() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F79B0 Offset: 0x22F63B0 VA: 0x1822F79B0
	public void PerformLayout(Control affectedControl, string affectedProperty) { }

	// RVA: 0x22F7B20 Offset: 0x22F6520 VA: 0x1822F7B20
	public Point PointToClient(Point p) { }

	// RVA: 0x22F7C50 Offset: 0x22F6650 VA: 0x1822F7C50
	public Point PointToScreen(Point p) { }

	// RVA: 0x22F7D00 Offset: 0x22F6700 VA: 0x1822F7D00
	internal PreProcessControlState PreProcessControlMessageInternal(ref Message msg) { }

	// RVA: 0x22F7F10 Offset: 0x22F6910 VA: 0x1822F7F10 Slot: 84
	public virtual bool PreProcessMessage(ref Message msg) { }

	// RVA: 0x22F2370 Offset: 0x22F0D70 VA: 0x1822F2370 Slot: 85
	internal virtual bool InternalPreProcessMessage(ref Message msg) { }

	// RVA: 0x22F8620 Offset: 0x22F7020 VA: 0x1822F8620 Slot: 86
	public virtual void Refresh() { }

	[EditorBrowsable(1)]
	// RVA: 0x22F86A0 Offset: 0x22F70A0 VA: 0x1822F86A0 Slot: 87
	public virtual void ResetCursor() { }

	// RVA: 0x22F8870 Offset: 0x22F7270 VA: 0x1822F8870
	public void ResumeLayout() { }

	// RVA: 0x22F86C0 Offset: 0x22F70C0 VA: 0x1822F86C0
	public void ResumeLayout(bool performLayout) { }

	[EditorBrowsable(1)]
	[Obsolete]
	// RVA: 0x22F8DC0 Offset: 0x22F77C0 VA: 0x1822F8DC0
	public void Scale(float dx, float dy) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F8B90 Offset: 0x22F7590 VA: 0x1822F8B90
	public void Scale(SizeF factor) { }

	// RVA: 0x22F08B0 Offset: 0x22EF2B0 VA: 0x1822F08B0
	internal ContainerControl FindContainer(Control c) { }

	// RVA: 0x22F2DD0 Offset: 0x22F17D0 VA: 0x1822F2DD0
	private bool IsContainerAutoScaling(Control c) { }

	// RVA: 0x22F90B0 Offset: 0x22F7AB0 VA: 0x1822F90B0
	public void Select() { }

	// RVA: 0x22F8DE0 Offset: 0x22F77E0 VA: 0x1822F8DE0
	public bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap) { }

	// RVA: 0x22F91F0 Offset: 0x22F7BF0 VA: 0x1822F91F0
	public void SendToBack() { }

	// RVA: 0x22F97D0 Offset: 0x22F81D0 VA: 0x1822F97D0
	public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x22F9650 Offset: 0x22F8050 VA: 0x1822F9650
	internal void SetBoundsInternal(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x22F9F00 Offset: 0x22F8900 VA: 0x1822F9F00
	public void Show() { }

	// RVA: 0x22F9F20 Offset: 0x22F8920 VA: 0x1822F9F20
	public void SuspendLayout() { }

	// RVA: 0x22FAF60 Offset: 0x22F9960 VA: 0x1822FAF60
	public void Update() { }

	[EditorBrowsable(2)]
	// RVA: 0x22EFA40 Offset: 0x22EE440 VA: 0x1822EFA40 Slot: 88
	protected virtual Control.ControlCollection CreateControlsInstance() { }

	[EditorBrowsable(2)]
	// RVA: 0x22EFAF0 Offset: 0x22EE4F0 VA: 0x1822EFAF0 Slot: 89
	protected virtual void CreateHandle() { }

	[EditorBrowsable(2)]
	// RVA: 0x22EFE90 Offset: 0x22EE890 VA: 0x1822EFE90 Slot: 90
	protected virtual void DefWndProc(ref Message m) { }

	[EditorBrowsable(2)]
	// RVA: 0x22EFEB0 Offset: 0x22EE8B0 VA: 0x1822EFEB0 Slot: 91
	protected virtual void DestroyHandle() { }

	// RVA: 0x8D2060 Offset: 0x8D0A60 VA: 0x1808D2060
	protected internal AutoSizeMode GetAutoSizeMode() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F1F10 Offset: 0x22F0910 VA: 0x1822F1F10 Slot: 92
	protected virtual Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x22F1CC0 Offset: 0x22F06C0 VA: 0x1822F1CC0
	private Rectangle GetScaledBoundsOld(Rectangle bounds, SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x22F21B0 Offset: 0x22F0BB0 VA: 0x1822F21B0
	protected internal bool GetStyle(ControlStyles flag) { }

	// RVA: 0x22F21C0 Offset: 0x22F0BC0 VA: 0x1822F21C0
	protected bool GetTopLevel() { }

	[EditorBrowsable(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 93
	protected virtual void InitLayout() { }

	// RVA: 0x22F2E70 Offset: 0x22F1870 VA: 0x1822F2E70 Slot: 94
	protected virtual bool IsInputChar(char charCode) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 95
	internal virtual bool IsInputCharInternal(char charCode) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 96
	protected virtual bool IsInputKey(Keys keyData) { }

	[EditorBrowsable(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 97
	protected virtual void NotifyInvalidate(Rectangle invalidatedArea) { }

	// RVA: 0x22F81A0 Offset: 0x22F6BA0 VA: 0x1822F81A0 Slot: 98
	protected virtual bool ProcessCmdKey(ref Message msg, Keys keyData) { }

	// RVA: 0x22F8260 Offset: 0x22F6C60 VA: 0x1822F8260 Slot: 99
	protected virtual bool ProcessDialogChar(char charCode) { }

	// RVA: 0x22F8290 Offset: 0x22F6C90 VA: 0x1822F8290 Slot: 100
	protected virtual bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x22F82C0 Offset: 0x22F6CC0 VA: 0x1822F82C0 Slot: 101
	protected virtual bool ProcessKeyEventArgs(ref Message m) { }

	// RVA: 0x22F84D0 Offset: 0x22F6ED0 VA: 0x1822F84D0 Slot: 102
	protected internal virtual bool ProcessKeyMessage(ref Message m) { }

	// RVA: 0x22F8540 Offset: 0x22F6F40 VA: 0x1822F8540 Slot: 103
	protected virtual bool ProcessKeyPreview(ref Message m) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 104
	protected virtual bool ProcessMnemonic(char charCode) { }

	// RVA: 0x22F9AE0 Offset: 0x22F84E0 VA: 0x1822F9AE0
	private void SetIsRecreating() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F8590 Offset: 0x22F6F90 VA: 0x1822F8590
	protected void RecreateHandle() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F8880 Offset: 0x22F7280 VA: 0x1822F8880 Slot: 105
	protected virtual void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	[EditorBrowsable(1)]
	// RVA: 0x22F8930 Offset: 0x22F7330 VA: 0x1822F8930 Slot: 106
	protected virtual void ScaleCore(float dx, float dy) { }

	// RVA: 0x22F90D0 Offset: 0x22F7AD0 VA: 0x1822F90D0 Slot: 107
	protected virtual void Select(bool directed, bool forward) { }

	// RVA: 0x22F9260 Offset: 0x22F7C60 VA: 0x1822F9260
	protected void SetAutoSizeMode(AutoSizeMode mode) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F9630 Offset: 0x22F8030 VA: 0x1822F9630 Slot: 108
	protected virtual void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	// RVA: 0x22F92C0 Offset: 0x22F7CC0 VA: 0x1822F92C0 Slot: 109
	internal virtual void SetBoundsCoreInternal(int x, int y, int width, int height, BoundsSpecified specified) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F9920 Offset: 0x22F8320 VA: 0x1822F9920 Slot: 110
	protected virtual void SetClientSizeCore(int x, int y) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F9B60 Offset: 0x22F8560 VA: 0x1822F9B60
	protected internal void SetStyle(ControlStyles flag, bool value) { }

	// RVA: 0x22F9B80 Offset: 0x22F8580 VA: 0x1822F9B80 Slot: 111
	protected virtual void SetVisibleCore(bool value) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F9F10 Offset: 0x22F8910 VA: 0x1822F9F10 Slot: 112
	protected virtual Size SizeFromClientSize(Size clientSize) { }

	[EditorBrowsable(2)]
	// RVA: 0x22FA090 Offset: 0x22F8A90 VA: 0x1822FA090
	protected void UpdateBounds() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F9F30 Offset: 0x22F8930 VA: 0x1822F9F30
	protected void UpdateBounds(int x, int y, int width, int height) { }

	[EditorBrowsable(2)]
	// RVA: 0x22FA200 Offset: 0x22F8C00 VA: 0x1822FA200
	protected void UpdateBounds(int x, int y, int width, int height, int clientWidth, int clientHeight) { }

	[EditorBrowsable(2)]
	// RVA: 0x22FAAE0 Offset: 0x22F94E0 VA: 0x1822FAAE0
	protected void UpdateStyles() { }

	// RVA: 0x22FAC60 Offset: 0x22F9660 VA: 0x1822FAC60
	private void UpdateZOrderOfChild(Control child) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 113
	internal virtual IntPtr AfterTopMostControl() { }

	// RVA: 0x22FA4A0 Offset: 0x22F8EA0 VA: 0x1822FA4A0
	internal void UpdateChildrenZOrder() { }

	[EditorBrowsable(2)]
	// RVA: 0x22FAF40 Offset: 0x22F9940 VA: 0x1822FAF40
	protected void UpdateZOrder() { }

	// RVA: 0x22FDBC0 Offset: 0x22FC5C0 VA: 0x1822FDBC0 Slot: 114
	protected virtual void WndProc(ref Message m) { }

	// RVA: 0x22FB640 Offset: 0x22FA040 VA: 0x1822FB640
	private void WmDestroy(ref Message m) { }

	// RVA: 0x22FDB30 Offset: 0x22FC530 VA: 0x1822FDB30
	private void WmWindowPosChanged(ref Message m) { }

	// RVA: 0x22FC910 Offset: 0x22FB310 VA: 0x1822FC910
	private void WmPaint(ref Message m) { }

	// RVA: 0x22FB700 Offset: 0x22FA100 VA: 0x1822FB700
	private void WmEraseBackground(ref Message m) { }

	// RVA: 0x22FBD90 Offset: 0x22FA790 VA: 0x1822FBD90
	private void WmLButtonUp(ref Message m) { }

	// RVA: 0x22FBB20 Offset: 0x22FA520 VA: 0x1822FBB20
	private void WmLButtonDown(ref Message m) { }

	// RVA: 0x22FB9C0 Offset: 0x22FA3C0 VA: 0x1822FB9C0
	private void WmLButtonDblClick(ref Message m) { }

	// RVA: 0x22FC250 Offset: 0x22FAC50 VA: 0x1822FC250
	private void WmMButtonUp(ref Message m) { }

	// RVA: 0x22FC100 Offset: 0x22FAB00 VA: 0x1822FC100
	private void WmMButtonDown(ref Message m) { }

	// RVA: 0x22FBFA0 Offset: 0x22FA9A0 VA: 0x1822FBFA0
	private void WmMButtonDblClick(ref Message m) { }

	// RVA: 0x22FCE80 Offset: 0x22FB880 VA: 0x1822FCE80
	private void WmRButtonUp(ref Message m) { }

	// RVA: 0x22FCCB0 Offset: 0x22FB6B0 VA: 0x1822FCCB0
	private void WmRButtonDown(ref Message m) { }

	// RVA: 0x22FCB50 Offset: 0x22FB550 VA: 0x1822FCB50
	private void WmRButtonDblClick(ref Message m) { }

	// RVA: 0x22FB2D0 Offset: 0x22F9CD0 VA: 0x1822FB2D0
	private void WmContextMenu(ref Message m) { }

	// RVA: 0x22FB5D0 Offset: 0x22F9FD0 VA: 0x1822FB5D0
	private void WmCreate(ref Message m) { }

	// RVA: 0x22FC7A0 Offset: 0x22FB1A0 VA: 0x1822FC7A0
	private void WmMouseWheel(ref Message m) { }

	// RVA: 0x22FC540 Offset: 0x22FAF40 VA: 0x1822FC540
	private void WmMouseMove(ref Message m) { }

	// RVA: 0x22FC3E0 Offset: 0x22FADE0 VA: 0x1822FC3E0
	private void WmMouseEnter(ref Message m) { }

	// RVA: 0x22FC4D0 Offset: 0x22FAED0 VA: 0x1822FC4D0
	private void WmMouseLeave(ref Message m) { }

	// RVA: 0x22FC460 Offset: 0x22FAE60 VA: 0x1822FC460
	private void WmMouseHover(ref Message m) { }

	// RVA: 0x22FD300 Offset: 0x22FBD00 VA: 0x1822FD300
	private void WmShowWindow(ref Message m) { }

	// RVA: 0x22FD870 Offset: 0x22FC270 VA: 0x1822FD870
	private void WmSysKeyUp(ref Message m) { }

	// RVA: 0x22FB8F0 Offset: 0x22FA2F0 VA: 0x1822FB8F0
	private void WmKeys(ref Message m) { }

	// RVA: 0x22FB720 Offset: 0x22FA120 VA: 0x1822FB720
	private void WmHelp(ref Message m) { }

	// RVA: 0x22FB950 Offset: 0x22FA350 VA: 0x1822FB950
	private void WmKillFocus(ref Message m) { }

	// RVA: 0x22FD280 Offset: 0x22FBC80 VA: 0x1822FD280
	private void WmSetFocus(ref Message m) { }

	// RVA: 0x22FD780 Offset: 0x22FC180 VA: 0x1822FD780
	private void WmSysColorChange(ref Message m) { }

	// RVA: 0x22FD160 Offset: 0x22FBB60 VA: 0x1822FD160
	private void WmSetCursor(ref Message m) { }

	// RVA: 0x22FAFD0 Offset: 0x22F99D0 VA: 0x1822FAFD0
	private void WmCaptureChanged(ref Message m) { }

	// RVA: 0x22FB060 Offset: 0x22F9A60 VA: 0x1822FB060
	private void WmChangeUIState(ref Message m) { }

	// RVA: 0x22FD9C0 Offset: 0x22FC3C0 VA: 0x1822FD9C0
	private void WmUpdateUIState(ref Message m) { }

	// RVA: 0x22F2FF0 Offset: 0x22F19F0 VA: 0x1822F2FF0 Slot: 115
	protected virtual void OnAutoSizeChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F30D0 Offset: 0x22F1AD0 VA: 0x1822F30D0 Slot: 116
	protected virtual void OnBackColorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3230 Offset: 0x22F1C30 VA: 0x1822F3230 Slot: 117
	protected virtual void OnBackgroundImageLayoutChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3310 Offset: 0x22F1D10 VA: 0x1822F3310 Slot: 118
	protected virtual void OnBindingContextChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3480 Offset: 0x22F1E80 VA: 0x1822F3480 Slot: 119
	protected virtual void OnCausesValidationChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3560 Offset: 0x22F1F60 VA: 0x1822F3560 Slot: 120
	protected virtual void OnChangeUICues(UICuesEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3640 Offset: 0x22F2040 VA: 0x1822F3640 Slot: 121
	protected virtual void OnClick(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3720 Offset: 0x22F2120 VA: 0x1822F3720 Slot: 122
	protected virtual void OnClientSizeChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3800 Offset: 0x22F2200 VA: 0x1822F3800 Slot: 123
	protected virtual void OnContextMenuChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F38E0 Offset: 0x22F22E0 VA: 0x1822F38E0 Slot: 124
	protected virtual void OnControlAdded(ControlEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F39C0 Offset: 0x22F23C0 VA: 0x1822F39C0 Slot: 125
	protected virtual void OnControlRemoved(ControlEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 126
	protected virtual void OnCreateControl() { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3AA0 Offset: 0x22F24A0 VA: 0x1822F3AA0 Slot: 127
	protected virtual void OnCursorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3C00 Offset: 0x22F2600 VA: 0x1822F3C00 Slot: 128
	protected virtual void OnDockChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3CE0 Offset: 0x22F26E0 VA: 0x1822F3CE0 Slot: 129
	protected virtual void OnDoubleClick(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3DC0 Offset: 0x22F27C0 VA: 0x1822F3DC0 Slot: 130
	protected virtual void OnDragDrop(DragEventArgs drgevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3EA0 Offset: 0x22F28A0 VA: 0x1822F3EA0 Slot: 131
	protected virtual void OnDragEnter(DragEventArgs drgevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F3F80 Offset: 0x22F2980 VA: 0x1822F3F80 Slot: 132
	protected virtual void OnDragLeave(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4060 Offset: 0x22F2A60 VA: 0x1822F4060 Slot: 133
	protected virtual void OnDragOver(DragEventArgs drgevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4140 Offset: 0x22F2B40 VA: 0x1822F4140 Slot: 134
	protected virtual void OnEnabledChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4390 Offset: 0x22F2D90 VA: 0x1822F4390 Slot: 135
	protected virtual void OnEnter(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4470 Offset: 0x22F2E70 VA: 0x1822F4470 Slot: 136
	protected virtual void OnFontChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F45E0 Offset: 0x22F2FE0 VA: 0x1822F45E0 Slot: 137
	protected virtual void OnForeColorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4750 Offset: 0x22F3150 VA: 0x1822F4750 Slot: 138
	protected virtual void OnGiveFeedback(GiveFeedbackEventArgs gfbevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4830 Offset: 0x22F3230 VA: 0x1822F4830 Slot: 139
	protected virtual void OnGotFocus(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4910 Offset: 0x22F3310 VA: 0x1822F4910 Slot: 140
	protected virtual void OnHandleCreated(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F49F0 Offset: 0x22F33F0 VA: 0x1822F49F0 Slot: 141
	protected virtual void OnHandleDestroyed(EventArgs e) { }

	// RVA: 0x22F8570 Offset: 0x22F6F70 VA: 0x1822F8570
	internal void RaiseHelpRequested(HelpEventArgs hevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4AD0 Offset: 0x22F34D0 VA: 0x1822F4AD0 Slot: 142
	protected virtual void OnHelpRequested(HelpEventArgs hevent) { }

	// RVA: 0x22F4BB0 Offset: 0x22F35B0 VA: 0x1822F4BB0 Slot: 143
	protected virtual void OnImeModeChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4C90 Offset: 0x22F3690 VA: 0x1822F4C90 Slot: 144
	protected virtual void OnInvalidated(InvalidateEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4E40 Offset: 0x22F3840 VA: 0x1822F4E40 Slot: 145
	protected virtual void OnKeyDown(KeyEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F4F20 Offset: 0x22F3920 VA: 0x1822F4F20 Slot: 146
	protected virtual void OnKeyPress(KeyPressEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5000 Offset: 0x22F3A00 VA: 0x1822F5000 Slot: 147
	protected virtual void OnKeyUp(KeyEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F50E0 Offset: 0x22F3AE0 VA: 0x1822F50E0 Slot: 148
	protected virtual void OnLayout(LayoutEventArgs levent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5290 Offset: 0x22F3C90 VA: 0x1822F5290 Slot: 149
	protected virtual void OnLeave(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5370 Offset: 0x22F3D70 VA: 0x1822F5370 Slot: 150
	protected virtual void OnLocationChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5460 Offset: 0x22F3E60 VA: 0x1822F5460 Slot: 151
	protected virtual void OnLostFocus(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5540 Offset: 0x22F3F40 VA: 0x1822F5540 Slot: 152
	protected virtual void OnMouseCaptureChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5620 Offset: 0x22F4020 VA: 0x1822F5620 Slot: 153
	protected virtual void OnMouseClick(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5700 Offset: 0x22F4100 VA: 0x1822F5700 Slot: 154
	protected virtual void OnMouseDoubleClick(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F57E0 Offset: 0x22F41E0 VA: 0x1822F57E0 Slot: 155
	protected virtual void OnMouseDown(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F58C0 Offset: 0x22F42C0 VA: 0x1822F58C0 Slot: 156
	protected virtual void OnMouseEnter(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F59A0 Offset: 0x22F43A0 VA: 0x1822F59A0 Slot: 157
	protected virtual void OnMouseHover(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5A80 Offset: 0x22F4480 VA: 0x1822F5A80 Slot: 158
	protected virtual void OnMouseLeave(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5B60 Offset: 0x22F4560 VA: 0x1822F5B60 Slot: 159
	protected virtual void OnMouseMove(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5C40 Offset: 0x22F4640 VA: 0x1822F5C40 Slot: 160
	protected virtual void OnMouseUp(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5D20 Offset: 0x22F4720 VA: 0x1822F5D20 Slot: 161
	protected virtual void OnMouseWheel(MouseEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5E00 Offset: 0x22F4800 VA: 0x1822F5E00 Slot: 162
	protected virtual void OnMove(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 163
	protected virtual void OnNotifyMessage(Message m) { }

	// RVA: 0x22F5EE0 Offset: 0x22F48E0 VA: 0x1822F5EE0 Slot: 164
	protected virtual void OnPaddingChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F5FC0 Offset: 0x22F49C0 VA: 0x1822F5FC0 Slot: 165
	protected virtual void OnPaint(PaintEventArgs e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 166
	internal virtual void OnPaintBackgroundInternal(PaintEventArgs e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 167
	internal virtual void OnPaintInternal(PaintEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 168
	protected virtual void OnPaintBackground(PaintEventArgs pevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F60A0 Offset: 0x22F4AA0 VA: 0x1822F60A0 Slot: 169
	protected virtual void OnParentBackColorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6130 Offset: 0x22F4B30 VA: 0x1822F6130 Slot: 170
	protected virtual void OnParentBindingContextChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22EC430 Offset: 0x22EAE30 VA: 0x1822EC430 Slot: 171
	protected virtual void OnParentChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 172
	protected virtual void OnParentCursorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F61A0 Offset: 0x22F4BA0 VA: 0x1822F61A0 Slot: 173
	protected virtual void OnParentEnabledChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F61C0 Offset: 0x22F4BC0 VA: 0x1822F61C0 Slot: 174
	protected virtual void OnParentFontChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6230 Offset: 0x22F4C30 VA: 0x1822F6230 Slot: 175
	protected virtual void OnParentForeColorChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F62B0 Offset: 0x22F4CB0 VA: 0x1822F62B0 Slot: 176
	protected virtual void OnParentRightToLeftChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6320 Offset: 0x22F4D20 VA: 0x1822F6320 Slot: 177
	protected virtual void OnParentVisibleChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6420 Offset: 0x22F4E20 VA: 0x1822F6420 Slot: 178
	protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6340 Offset: 0x22F4D40 VA: 0x1822F6340 Slot: 179
	protected virtual void OnPreviewKeyDown(PreviewKeyDownEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6500 Offset: 0x22F4F00 VA: 0x1822F6500 Slot: 180
	protected virtual void OnRegionChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F66E0 Offset: 0x22F50E0 VA: 0x1822F66E0 Slot: 181
	protected virtual void OnResize(EventArgs e) { }

	// RVA: 0x22F65E0 Offset: 0x22F4FE0 VA: 0x1822F65E0 Slot: 182
	internal virtual void OnResizeInternal(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6700 Offset: 0x22F5100 VA: 0x1822F6700 Slot: 183
	protected virtual void OnRightToLeftChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6870 Offset: 0x22F5270 VA: 0x1822F6870 Slot: 184
	protected virtual void OnSizeChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6AA0 Offset: 0x22F54A0 VA: 0x1822F6AA0 Slot: 185
	protected virtual void OnStyleChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6B80 Offset: 0x22F5580 VA: 0x1822F6B80 Slot: 186
	protected virtual void OnSystemColorsChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6C60 Offset: 0x22F5660 VA: 0x1822F6C60 Slot: 187
	protected virtual void OnTabIndexChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6D40 Offset: 0x22F5740 VA: 0x1822F6D40 Slot: 188
	protected virtual void OnTabStopChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6E20 Offset: 0x22F5820 VA: 0x1822F6E20 Slot: 189
	protected virtual void OnTextChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6F00 Offset: 0x22F5900 VA: 0x1822F6F00 Slot: 190
	protected virtual void OnValidated(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F6FE0 Offset: 0x22F59E0 VA: 0x1822F6FE0 Slot: 191
	protected virtual void OnValidating(CancelEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x22F70C0 Offset: 0x22F5AC0 VA: 0x1822F70C0 Slot: 192
	protected virtual void OnVisibleChanged(EventArgs e) { }
}
