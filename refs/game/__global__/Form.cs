public class Form : ContainerControl // TypeDefIndex: 5374
{
	// Fields
	internal bool closing; // 0x278
	private bool closed; // 0x279
	private FormBorderStyle form_border_style; // 0x27C
	private bool is_active; // 0x280
	private bool autoscale; // 0x281
	private Size clientsize_set; // 0x284
	private Size autoscale_base_size; // 0x28C
	private bool allow_transparency; // 0x294
	private static Icon default_icon; // 0x0
	internal bool is_modal; // 0x295
	internal FormWindowState window_state; // 0x298
	private bool control_box; // 0x29C
	private bool minimize_box; // 0x29D
	private bool maximize_box; // 0x29E
	private bool help_button; // 0x29F
	private bool show_in_taskbar; // 0x2A0
	private bool topmost; // 0x2A1
	private IButtonControl accept_button; // 0x2A8
	private IButtonControl cancel_button; // 0x2B0
	private DialogResult dialog_result; // 0x2B8
	private FormStartPosition start_position; // 0x2BC
	private Form owner; // 0x2C0
	private Form.ControlCollection owned_forms; // 0x2C8
	private MdiClient mdi_container; // 0x2D0
	internal InternalWindowManager window_manager; // 0x2D8
	private Form mdi_parent; // 0x2E0
	private bool key_preview; // 0x2E8
	private MainMenu menu; // 0x2F0
	private Icon icon; // 0x2F8
	private Size maximum_size; // 0x300
	private Size minimum_size; // 0x308
	private SizeGripStyle size_grip_style; // 0x310
	private SizeGrip size_grip; // 0x318
	private Rectangle maximized_bounds; // 0x320
	private Rectangle default_maximized_bounds; // 0x330
	private double opacity; // 0x340
	internal ApplicationContext context; // 0x348
	private Color transparency_key; // 0x350
	private bool is_loaded; // 0x368
	internal int is_changing_visible_state; // 0x36C
	internal bool has_been_visible; // 0x370
	private bool shown_raised; // 0x371
	private bool close_raised; // 0x372
	private bool is_clientsize_set; // 0x373
	internal bool suppress_closing_events; // 0x374
	internal bool waiting_showwindow; // 0x375
	private bool is_minimizing; // 0x376
	private bool show_icon; // 0x377
	private MenuStrip main_menu_strip; // 0x378
	private Rectangle restore_bounds; // 0x380
	private bool autoscale_base_size_set; // 0x390
	private static object ActivatedEvent; // 0x8
	private static object ClosedEvent; // 0x10
	private static object ClosingEvent; // 0x18
	private static object DeactivateEvent; // 0x20
	private static object InputLanguageChangedEvent; // 0x28
	private static object InputLanguageChangingEvent; // 0x30
	private static object LoadEvent; // 0x38
	private static object MaximizedBoundsChangedEvent; // 0x40
	private static object MaximumSizeChangedEvent; // 0x48
	private static object MdiChildActivateEvent; // 0x50
	private static object MenuCompleteEvent; // 0x58
	private static object MenuStartEvent; // 0x60
	private static object MinimumSizeChangedEvent; // 0x68
	private static object FormClosingEvent; // 0x70
	private static object FormClosedEvent; // 0x78
	private static object HelpButtonClickedEvent; // 0x80
	private static object ResizeEndEvent; // 0x88
	private static object ResizeBeginEvent; // 0x90
	private static object RightToLeftLayoutChangedEvent; // 0x98
	private static object ShownEvent; // 0xA0
	private static object UIAMenuChangedEvent; // 0xA8
	private static object UIATopMostChangedEvent; // 0xB0
	private static object UIAWindowStateChangedEvent; // 0xB8

	// Properties
	internal bool IsLoaded { get; }
	internal bool IsActive { set; }
	public static Form ActiveForm { get; }
	[DefaultValue(null)]
	public IButtonControl AcceptButton { get; set; }
	[MWFCategory("Layout")]
	[Obsolete("This property has been deprecated in favor of AutoScaleMode.")]
	[EditorBrowsable(1)]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool AutoScale { get; set; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(1)]
	[Browsable(False)]
	[Localizable(True)]
	public virtual Size AutoScaleBaseSize { get; set; }
	[Localizable(True)]
	public override bool AutoScroll { get; }
	[DesignerSerializationVisibility(1)]
	[Browsable(True)]
	[EditorBrowsable(0)]
	public override bool AutoSize { get; set; }
	[DefaultValue(1)]
	[Browsable(True)]
	[Localizable(True)]
	public AutoSizeMode AutoSizeMode { get; }
	public override Color BackColor { get; set; }
	[DefaultValue(null)]
	public IButtonControl CancelButton { get; set; }
	[DesignerSerializationVisibility(1)]
	[Localizable(True)]
	public Size ClientSize { get; set; }
	[DefaultValue(True)]
	[MWFCategory("Window Style")]
	public bool ControlBox { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DialogResult DialogResult { get; set; }
	[DispId(-504)]
	[MWFCategory("Appearance")]
	[DefaultValue(4)]
	public FormBorderStyle FormBorderStyle { get; set; }
	[MWFCategory("Window Style")]
	[DefaultValue(False)]
	public bool HelpButton { get; }
	[AmbientValue(null)]
	[Localizable(True)]
	[MWFCategory("Window Style")]
	public Icon Icon { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public bool IsMdiChild { get; }
	[DefaultValue(False)]
	[MWFCategory("Window Style")]
	public bool IsMdiContainer { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public Form ActiveMdiChild { get; }
	[TypeConverter(typeof(ReferenceConverter))]
	[DefaultValue(null)]
	public MenuStrip MainMenuStrip { get; }
	[DefaultValue(True)]
	[MWFCategory("Window Style")]
	public bool MaximizeBox { get; set; }
	[MWFCategory("Layout")]
	[Localizable(True)]
	[RefreshProperties(2)]
	[DefaultValue(typeof(Size), "0, 0")]
	public override Size MaximumSize { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public Form[] MdiChildren { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public Form MdiParent { get; }
	internal MdiClient MdiContainer { get; }
	internal InternalWindowManager WindowManager { get; }
	[MWFCategory("Window Style")]
	[DefaultValue(null)]
	[TypeConverter(typeof(ReferenceConverter))]
	[Browsable(False)]
	public MainMenu Menu { get; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public MainMenu MergedMenu { get; }
	internal MainMenu ActiveMenu { get; }
	internal MdiWindowManager ActiveMaximizedMdiChild { get; }
	[MWFCategory("Window Style")]
	[DefaultValue(True)]
	public bool MinimizeBox { get; set; }
	[MWFCategory("Layout")]
	[Localizable(True)]
	[RefreshProperties(2)]
	public override Size MinimumSize { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public bool Modal { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public Form Owner { get; set; }
	[DefaultValue(True)]
	public bool ShowIcon { get; }
	[DefaultValue(True)]
	[MWFCategory("Window Style")]
	public bool ShowInTaskbar { get; set; }
	[DesignerSerializationVisibility(0)]
	[Localizable(False)]
	public Size Size { get; set; }
	[DefaultValue(0)]
	[MWFCategory("Window Style")]
	public SizeGripStyle SizeGripStyle { set; }
	[DefaultValue(2)]
	[MWFCategory("Layout")]
	[Localizable(True)]
	public FormStartPosition StartPosition { get; set; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public bool TopLevel { get; }
	[DefaultValue(False)]
	[MWFCategory("Window Style")]
	public bool TopMost { get; set; }
	[MWFCategory("Window Style")]
	public Color TransparencyKey { get; }
	[DefaultValue(0)]
	[MWFCategory("Layout")]
	public FormWindowState WindowState { get; set; }
	protected override CreateParams CreateParams { get; }
	protected override Size DefaultSize { get; }
	[Browsable(False)]
	[MonoTODO("Implemented for Win32, needs X11 implementation")]
	protected virtual bool ShowWithoutActivation { get; }
	internal override bool ActivateOnShow { get; }
	[SettingsBindable(True)]
	public override string Text { get; set; }
	[SettingsBindable(True)]
	public Point Location { get; set; }

	// Methods

	// RVA: 0x2331BF0 Offset: 0x23305F0 VA: 0x182331BF0
	public void .ctor() { }

	// RVA: 0x23314F0 Offset: 0x232FEF0 VA: 0x1823314F0
	private static void .cctor() { }

	// RVA: 0x2331F70 Offset: 0x2330970 VA: 0x182331F70
	public void add_Closed(EventHandler value) { }

	// RVA: 0x2333160 Offset: 0x2331B60 VA: 0x182333160
	public void remove_Closed(EventHandler value) { }

	// RVA: 0x2332000 Offset: 0x2330A00 VA: 0x182332000
	public void add_Deactivate(EventHandler value) { }

	// RVA: 0x23331F0 Offset: 0x2331BF0 VA: 0x1823331F0
	public void remove_Deactivate(EventHandler value) { }

	// RVA: 0x2332120 Offset: 0x2330B20 VA: 0x182332120
	public void add_Load(EventHandler value) { }

	// RVA: 0x2333310 Offset: 0x2331D10 VA: 0x182333310
	public void remove_Load(EventHandler value) { }

	// RVA: 0x2332090 Offset: 0x2330A90 VA: 0x182332090
	public void add_FormClosed(FormClosedEventHandler value) { }

	// RVA: 0x2333280 Offset: 0x2331C80 VA: 0x182333280
	public void remove_FormClosed(FormClosedEventHandler value) { }

	// RVA: 0x2332EE0 Offset: 0x23318E0 VA: 0x182332EE0
	internal bool get_IsLoaded() { }

	// RVA: 0x23338F0 Offset: 0x23322F0 VA: 0x1823338F0
	internal void set_IsActive(bool value) { }

	// RVA: 0x232B950 Offset: 0x232A350 VA: 0x18232B950
	internal bool FireClosingEvents(CloseReason reason, bool cancel) { }

	// RVA: 0x232B890 Offset: 0x232A290 VA: 0x18232B890
	private void FireClosedEvents(CloseReason reason) { }

	// RVA: 0x232BAF0 Offset: 0x232A4F0 VA: 0x18232BAF0 Slot: 33
	internal override Size GetPreferredSizeCore(Size proposedSize) { }

	[EditorBrowsable(2)]
	// RVA: 0x232BFE0 Offset: 0x232A9E0 VA: 0x18232BFE0 Slot: 92
	protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x232DEC0 Offset: 0x232C8C0 VA: 0x18232DEC0 Slot: 104
	protected override bool ProcessMnemonic(char charCode) { }

	[EditorBrowsable(2)]
	// RVA: 0x2232D00 Offset: 0x2231700 VA: 0x182232D00 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x232C100 Offset: 0x232AB00 VA: 0x18232C100
	internal void OnActivatedInternal() { }

	// RVA: 0x232C520 Offset: 0x232AF20 VA: 0x18232C520
	internal void OnDeactivateInternal() { }

	// RVA: 0x232F410 Offset: 0x232DE10 VA: 0x18232F410 Slot: 71
	internal override void UpdateWindowText() { }

	// RVA: 0x232E0F0 Offset: 0x232CAF0 VA: 0x18232E0F0
	internal void SelectActiveControl() { }

	// RVA: 0x232F2C0 Offset: 0x232DCC0 VA: 0x18232F2C0
	private void UpdateSizeGripVisible() { }

	// RVA: 0x232ACE0 Offset: 0x23296E0 VA: 0x18232ACE0
	internal void ChangingParent(Control new_parent) { }

	// RVA: 0x232BA40 Offset: 0x232A440 VA: 0x18232BA40 Slot: 81
	internal override bool FocusInternal(bool skip_check) { }

	// RVA: 0x23321E0 Offset: 0x2330BE0 VA: 0x1823321E0
	public static Form get_ActiveForm() { }

	// RVA: 0x879400 Offset: 0x877E00 VA: 0x180879400
	public IButtonControl get_AcceptButton() { }

	// RVA: 0x23333A0 Offset: 0x2331DA0 VA: 0x1823333A0
	public void set_AcceptButton(IButtonControl value) { }

	// RVA: 0x21E06A0 Offset: 0x21DF0A0 VA: 0x1821E06A0
	public bool get_AutoScale() { }

	// RVA: 0x2333460 Offset: 0x2331E60 VA: 0x182333460
	public void set_AutoScale(bool value) { }

	// RVA: 0x23326E0 Offset: 0x23310E0 VA: 0x1823326E0 Slot: 203
	public virtual Size get_AutoScaleBaseSize() { }

	[MonoTODO("Setting this is probably unintentional and can cause Forms to be improperly sized.  See http://www.mono-project.com/FAQ:_Winforms#My_forms_are_sized_improperly for details.")]
	// RVA: 0x2333450 Offset: 0x2331E50 VA: 0x182333450 Slot: 204
	public virtual void set_AutoScaleBaseSize(Size value) { }

	// RVA: 0x21E3640 Offset: 0x21E2040 VA: 0x1821E3640 Slot: 193
	public override bool get_AutoScroll() { }

	// RVA: 0xAADD90 Offset: 0xAAC790 VA: 0x180AADD90 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x23334A0 Offset: 0x2331EA0 VA: 0x1823334A0 Slot: 38
	public override void set_AutoSize(bool value) { }

	// RVA: 0x8D2060 Offset: 0x8D0A60 VA: 0x1808D2060
	public AutoSizeMode get_AutoSizeMode() { }

	// RVA: 0x23326F0 Offset: 0x23310F0 VA: 0x1823326F0 Slot: 42
	public override Color get_BackColor() { }

	// RVA: 0x21C7C40 Offset: 0x21C6640 VA: 0x1821C7C40 Slot: 43
	public override void set_BackColor(Color value) { }

	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20
	public IButtonControl get_CancelButton() { }

	// RVA: 0x2333510 Offset: 0x2331F10 VA: 0x182333510
	public void set_CancelButton(IButtonControl value) { }

	// RVA: 0xCE3DB0 Offset: 0xCE27B0 VA: 0x180CE3DB0
	public Size get_ClientSize() { }

	// RVA: 0x2333680 Offset: 0x2332080 VA: 0x182333680
	public void set_ClientSize(Size value) { }

	// RVA: 0x2332780 Offset: 0x2331180 VA: 0x182332780
	public bool get_ControlBox() { }

	// RVA: 0x2333690 Offset: 0x2332090 VA: 0x182333690
	public void set_ControlBox(bool value) { }

	// RVA: 0x640DA0 Offset: 0x63F7A0 VA: 0x180640DA0
	public DialogResult get_DialogResult() { }

	// RVA: 0x23336B0 Offset: 0x23320B0 VA: 0x1823336B0
	public void set_DialogResult(DialogResult value) { }

	// RVA: 0x2332EC0 Offset: 0x23318C0 VA: 0x182332EC0
	public FormBorderStyle get_FormBorderStyle() { }

	// RVA: 0x2333790 Offset: 0x2332190 VA: 0x182333790
	public void set_FormBorderStyle(FormBorderStyle value) { }

	// RVA: 0x2332ED0 Offset: 0x23318D0 VA: 0x182332ED0
	public bool get_HelpButton() { }

	// RVA: 0x67A260 Offset: 0x678C60 VA: 0x18067A260
	public Icon get_Icon() { }

	// RVA: 0x2332EF0 Offset: 0x23318F0 VA: 0x182332EF0
	public bool get_IsMdiChild() { }

	// RVA: 0x2332F00 Offset: 0x2331900 VA: 0x182332F00
	public bool get_IsMdiContainer() { }

	// RVA: 0x23323F0 Offset: 0x2330DF0 VA: 0x1823323F0
	public Form get_ActiveMdiChild() { }

	// RVA: 0xA02660 Offset: 0xA01060 VA: 0x180A02660
	public MenuStrip get_MainMenuStrip() { }

	// RVA: 0x2332F10 Offset: 0x2331910 VA: 0x182332F10
	public bool get_MaximizeBox() { }

	// RVA: 0x23339F0 Offset: 0x23323F0 VA: 0x1823339F0
	public void set_MaximizeBox(bool value) { }

	// RVA: 0x6DFA80 Offset: 0x6DE480 VA: 0x1806DFA80 Slot: 39
	public override Size get_MaximumSize() { }

	// RVA: 0x2332F20 Offset: 0x2331920 VA: 0x182332F20
	public Form[] get_MdiChildren() { }

	// RVA: 0x640F20 Offset: 0x63F920 VA: 0x180640F20
	public Form get_MdiParent() { }

	// RVA: 0x81F1D0 Offset: 0x81DBD0 VA: 0x18081F1D0
	internal MdiClient get_MdiContainer() { }

	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0
	internal InternalWindowManager get_WindowManager() { }

	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40
	public MainMenu get_Menu() { }

	// RVA: 0x2332F80 Offset: 0x2331980 VA: 0x182332F80
	public MainMenu get_MergedMenu() { }

	// RVA: 0x2332410 Offset: 0x2330E10 VA: 0x182332410
	internal MainMenu get_ActiveMenu() { }

	// RVA: 0x2332340 Offset: 0x2330D40 VA: 0x182332340
	internal MdiWindowManager get_ActiveMaximizedMdiChild() { }

	// RVA: 0x2333010 Offset: 0x2331A10 VA: 0x182333010
	public bool get_MinimizeBox() { }

	// RVA: 0x2333A10 Offset: 0x2332410 VA: 0x182333A10
	public void set_MinimizeBox(bool value) { }

	// RVA: 0x6DFA50 Offset: 0x6DE450 VA: 0x1806DFA50 Slot: 40
	public override Size get_MinimumSize() { }

	// RVA: 0x2333A30 Offset: 0x2332430 VA: 0x182333A30 Slot: 41
	public override void set_MinimumSize(Size value) { }

	// RVA: 0x2333020 Offset: 0x2331A20 VA: 0x182333020
	public bool get_Modal() { }

	// RVA: 0x640C60 Offset: 0x63F660 VA: 0x180640C60
	public Form get_Owner() { }

	// RVA: 0x2333C50 Offset: 0x2332650 VA: 0x182333C50
	public void set_Owner(Form value) { }

	// RVA: 0x2333030 Offset: 0x2331A30 VA: 0x182333030
	public bool get_ShowIcon() { }

	// RVA: 0x2333040 Offset: 0x2331A40 VA: 0x182333040
	public bool get_ShowInTaskbar() { }

	// RVA: 0x2333E00 Offset: 0x2332800 VA: 0x182333E00
	public void set_ShowInTaskbar(bool value) { }

	// RVA: 0x2333050 Offset: 0x2331A50 VA: 0x182333050
	public Size get_Size() { }

	// RVA: 0x2333FA0 Offset: 0x23329A0 VA: 0x182333FA0
	public void set_Size(Size value) { }

	// RVA: 0x2333E50 Offset: 0x2332850 VA: 0x182333E50
	public void set_SizeGripStyle(SizeGripStyle value) { }

	// RVA: 0x2333060 Offset: 0x2331A60 VA: 0x182333060
	public FormStartPosition get_StartPosition() { }

	// RVA: 0x2333FB0 Offset: 0x23329B0 VA: 0x182333FB0
	public void set_StartPosition(FormStartPosition value) { }

	// RVA: 0x22F21C0 Offset: 0x22F0BC0 VA: 0x1822F21C0
	public bool get_TopLevel() { }

	// RVA: 0x2333070 Offset: 0x2331A70 VA: 0x182333070
	public bool get_TopMost() { }

	// RVA: 0x2333FC0 Offset: 0x23329C0 VA: 0x182333FC0
	public void set_TopMost(bool value) { }

	// RVA: 0x2333080 Offset: 0x2331A80 VA: 0x182333080
	public Color get_TransparencyKey() { }

	// RVA: 0x23330A0 Offset: 0x2331AA0 VA: 0x1823330A0
	public FormWindowState get_WindowState() { }

	// RVA: 0x2334140 Offset: 0x2332B40 VA: 0x182334140
	public void set_WindowState(FormWindowState value) { }

	// RVA: 0x2332790 Offset: 0x2331190 VA: 0x182332790 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x2332E90 Offset: 0x2331890 VA: 0x182332E90 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 205
	protected virtual bool get_ShowWithoutActivation() { }

	[EditorBrowsable(1)]
	[Obsolete("This method has been deprecated.  Use AutoScaleDimensions instead")]
	// RVA: 0x232BAA0 Offset: 0x232A4A0 VA: 0x18232BAA0
	public static SizeF GetAutoScaleSize(Font font) { }

	// RVA: 0x232A5D0 Offset: 0x2328FD0 VA: 0x18232A5D0
	public void Activate() { }

	// RVA: 0x232A710 Offset: 0x2329110 VA: 0x18232A710
	public void AddOwnedForm(Form ownedForm) { }

	// RVA: 0x232AFD0 Offset: 0x23299D0 VA: 0x18232AFD0
	public void Close() { }

	// RVA: 0x232E0A0 Offset: 0x232CAA0 VA: 0x18232E0A0
	public void RemoveOwnedForm(Form ownedForm) { }

	// RVA: 0x232EB30 Offset: 0x232D530 VA: 0x18232EB30
	public DialogResult ShowDialog() { }

	// RVA: 0x232EB40 Offset: 0x232D540 VA: 0x18232EB40
	public DialogResult ShowDialog(IWin32Window owner) { }

	// RVA: 0x232F230 Offset: 0x232DC30 VA: 0x18232F230 Slot: 3
	public override string ToString() { }

	[Browsable(True)]
	[EditorBrowsable(0)]
	// RVA: 0x232F550 Offset: 0x232DF50 VA: 0x18232F550 Slot: 199
	public override bool ValidateChildren() { }

	[Browsable(True)]
	[EditorBrowsable(0)]
	// RVA: 0x232F560 Offset: 0x232DF60 VA: 0x18232F560 Slot: 200
	public override bool ValidateChildren(ValidationConstraints validationConstraints) { }

	// RVA: 0x232A530 Offset: 0x2328F30 VA: 0x18232A530
	protected void ActivateMdiChild(Form form) { }

	[EditorBrowsable(2)]
	// RVA: 0x232A780 Offset: 0x2329180 VA: 0x18232A780 Slot: 194
	protected override void AdjustFormScrollbars(bool displayScrollbars) { }

	[Obsolete("This method has been deprecated")]
	[EditorBrowsable(1)]
	// RVA: 0x232A790 Offset: 0x2329190 VA: 0x18232A790
	protected void ApplyAutoScaling() { }

	// RVA: 0x232A9F0 Offset: 0x23293F0 VA: 0x18232A9F0
	protected void CenterToParent() { }

	// RVA: 0x232AB90 Offset: 0x2329590 VA: 0x18232AB90
	protected void CenterToScreen() { }

	[EditorBrowsable(2)]
	// RVA: 0x223EB90 Offset: 0x223D590 VA: 0x18223EB90 Slot: 88
	protected override Control.ControlCollection CreateControlsInstance() { }

	[EditorBrowsable(2)]
	// RVA: 0x232B0C0 Offset: 0x2329AC0 VA: 0x18232B0C0 Slot: 89
	protected override void CreateHandle() { }

	[EditorBrowsable(2)]
	// RVA: 0x232B710 Offset: 0x232A110 VA: 0x18232B710 Slot: 90
	protected override void DefWndProc(ref Message m) { }

	// RVA: 0x232B720 Offset: 0x232A120 VA: 0x18232B720 Slot: 12
	protected override void Dispose(bool disposing) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C170 Offset: 0x232AB70 VA: 0x18232C170 Slot: 206
	protected virtual void OnActivated(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C260 Offset: 0x232AC60 VA: 0x18232C260 Slot: 207
	protected virtual void OnClosed(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C340 Offset: 0x232AD40 VA: 0x18232C340 Slot: 208
	protected virtual void OnClosing(CancelEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C420 Offset: 0x232AE20 VA: 0x18232C420 Slot: 126
	protected override void OnCreateControl() { }

	[EditorBrowsable(2)]
	// RVA: 0x232C590 Offset: 0x232AF90 VA: 0x18232C590 Slot: 209
	protected virtual void OnDeactivate(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C680 Offset: 0x232B080 VA: 0x18232C680 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C9A0 Offset: 0x232B3A0 VA: 0x18232C9A0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232CA40 Offset: 0x232B440 VA: 0x18232CA40 Slot: 141
	protected override void OnHandleDestroyed(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232CE90 Offset: 0x232B890 VA: 0x18232CE90 Slot: 210
	protected virtual void OnLoad(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232CF90 Offset: 0x232B990 VA: 0x18232CF90 Slot: 211
	protected virtual void OnMdiChildActivate(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D070 Offset: 0x232BA70 VA: 0x18232D070 Slot: 212
	protected internal virtual void OnMenuComplete(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D150 Offset: 0x232BB50 VA: 0x18232D150 Slot: 213
	protected virtual void OnMinimumSizeChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D230 Offset: 0x232BC30 VA: 0x18232D230 Slot: 165
	protected override void OnPaint(PaintEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D440 Offset: 0x232BE40 VA: 0x18232D440 Slot: 181
	protected override void OnResize(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D530 Offset: 0x232BF30 VA: 0x18232D530 Slot: 185
	protected override void OnStyleChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D540 Offset: 0x232BF40 VA: 0x18232D540 Slot: 189
	protected override void OnTextChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D780 Offset: 0x232C180 VA: 0x18232D780 Slot: 192
	protected override void OnVisibleChanged(EventArgs e) { }

	// RVA: 0x232D840 Offset: 0x232C240 VA: 0x18232D840 Slot: 98
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData) { }

	[EditorBrowsable(2)]
	// RVA: 0x232DC70 Offset: 0x232C670 VA: 0x18232DC70 Slot: 99
	protected override bool ProcessDialogChar(char charCode) { }

	// RVA: 0x232DC80 Offset: 0x232C680 VA: 0x18232DC80 Slot: 100
	protected override bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x232DE60 Offset: 0x232C860 VA: 0x18232DE60 Slot: 103
	protected override bool ProcessKeyPreview(ref Message m) { }

	// RVA: 0x232DED0 Offset: 0x232C8D0 VA: 0x18232DED0 Slot: 201
	protected override bool ProcessTabKey(bool forward) { }

	[EditorBrowsable(1)]
	// RVA: 0x2232D10 Offset: 0x2231710 VA: 0x182232D10 Slot: 106
	protected override void ScaleCore(float x, float y) { }

	// RVA: 0x232E190 Offset: 0x232CB90 VA: 0x18232E190 Slot: 107
	protected override void Select(bool directed, bool forward) { }

	[EditorBrowsable(2)]
	// RVA: 0x232E360 Offset: 0x232CD60 VA: 0x18232E360 Slot: 108
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) { }

	[EditorBrowsable(2)]
	// RVA: 0x232E550 Offset: 0x232CF50 VA: 0x18232E550 Slot: 110
	protected override void SetClientSizeCore(int x, int y) { }

	[EditorBrowsable(2)]
	// RVA: 0x232E6E0 Offset: 0x232D0E0 VA: 0x18232E6E0 Slot: 111
	protected override void SetVisibleCore(bool value) { }

	[EditorBrowsable(2)]
	// RVA: 0x2330EE0 Offset: 0x232F8E0 VA: 0x182330EE0 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x232FB40 Offset: 0x232E540 VA: 0x18232FB40
	private void WmDestroy(ref Message m) { }

	// RVA: 0x232DF50 Offset: 0x232C950 VA: 0x18232DF50
	internal bool RaiseCloseEvents(bool last_check, bool cancel) { }

	// RVA: 0x232F760 Offset: 0x232E160 VA: 0x18232F760
	private void WmClose(ref Message m) { }

	// RVA: 0x2330E10 Offset: 0x232F810 VA: 0x182330E10
	private void WmWindowPosChanged(ref Message m) { }

	// RVA: 0x2330D60 Offset: 0x232F760 VA: 0x182330D60
	private void WmSysCommand(ref Message m) { }

	// RVA: 0x232F570 Offset: 0x232DF70 VA: 0x18232F570
	private void WmActivate(ref Message m) { }

	// RVA: 0x232FE50 Offset: 0x232E850 VA: 0x18232FE50
	private void WmKillFocus(ref Message m) { }

	// RVA: 0x2330CF0 Offset: 0x232F6F0 VA: 0x182330CF0
	private void WmSetFocus(ref Message m) { }

	// RVA: 0x2330100 Offset: 0x232EB00 VA: 0x182330100
	private void WmNcHitTest(ref Message m) { }

	// RVA: 0x23302E0 Offset: 0x232ECE0 VA: 0x1823302E0
	private void WmNcLButtonDown(ref Message m) { }

	// RVA: 0x2330550 Offset: 0x232EF50 VA: 0x182330550
	private void WmNcLButtonUp(ref Message m) { }

	// RVA: 0x2330680 Offset: 0x232F080 VA: 0x182330680
	private void WmNcMouseLeave(ref Message m) { }

	// RVA: 0x23307B0 Offset: 0x232F1B0 VA: 0x1823307B0
	private void WmNcMouseMove(ref Message m) { }

	// RVA: 0x2330A80 Offset: 0x232F480 VA: 0x182330A80
	private void WmNcPaint(ref Message m) { }

	// RVA: 0x232FE60 Offset: 0x232E860 VA: 0x18232FE60
	private void WmNcCalcSize(ref Message m) { }

	// RVA: 0x232FB60 Offset: 0x232E560 VA: 0x18232FB60
	private void WmGetMinMaxInfo(ref Message m) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	internal override void FireEnter() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 28
	internal override void FireLeave() { }

	// RVA: 0x232E0D0 Offset: 0x232CAD0 VA: 0x18232E0D0
	internal void RemoveWindowManager() { }

	// RVA: 0x232AEF0 Offset: 0x23298F0 VA: 0x18232AEF0 Slot: 202
	internal override void CheckAcceptButton() { }

	// RVA: 0x23321B0 Offset: 0x2330BB0 VA: 0x1823321B0 Slot: 18
	internal override bool get_ActivateOnShow() { }

	// RVA: 0x232CC10 Offset: 0x232B610 VA: 0x18232CC10
	private void OnLoadInternal(EventArgs e) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 69
	public override string get_Text() { }

	// RVA: 0x21C8040 Offset: 0x21C6A40 VA: 0x1821C8040 Slot: 70
	public override void set_Text(string value) { }

	// RVA: 0x2233B20 Offset: 0x2232520 VA: 0x182233B20
	public Point get_Location() { }

	// RVA: 0x2233FA0 Offset: 0x22329A0 VA: 0x182233FA0
	public void set_Location(Point value) { }

	// RVA: 0x232C250 Offset: 0x232AC50 VA: 0x18232C250 Slot: 117
	protected override void OnBackgroundImageLayoutChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21C7250 Offset: 0x21C5C50 VA: 0x1821C7250 Slot: 134
	protected override void OnEnabledChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C670 Offset: 0x232B070 VA: 0x18232C670 Slot: 135
	protected override void OnEnter(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C7C0 Offset: 0x232B1C0 VA: 0x18232C7C0 Slot: 214
	protected virtual void OnFormClosed(FormClosedEventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232C8C0 Offset: 0x232B2C0 VA: 0x18232C8C0 Slot: 215
	protected virtual void OnFormClosing(FormClosingEventArgs e) { }

	// RVA: 0x232CAB0 Offset: 0x232B4B0 VA: 0x18232CAB0 Slot: 148
	protected override void OnLayout(LayoutEventArgs levent) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D280 Offset: 0x232BC80 VA: 0x18232D280 Slot: 216
	protected virtual void OnResizeBegin(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D360 Offset: 0x232BD60 VA: 0x18232D360 Slot: 217
	protected virtual void OnResizeEnd(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x232D450 Offset: 0x232BE50 VA: 0x18232D450 Slot: 218
	protected virtual void OnShown(EventArgs e) { }

	// RVA: 0x232D580 Offset: 0x232BF80 VA: 0x18232D580
	internal void OnUIATopMostChanged() { }

	// RVA: 0x232D680 Offset: 0x232C080 VA: 0x18232D680
	internal void OnUIAWindowStateChanged() { }
}
