public class TaskDialog : Component, IWin32Window // TypeDefIndex: 17302
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler Created; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler Destroyed; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler<TaskDialogItemClickedEventArgs> ButtonClicked; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler<TaskDialogItemClickedEventArgs> RadioButtonClicked; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler<HyperlinkClickedEventArgs> HyperlinkClicked; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler VerificationClicked; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler<TimerEventArgs> Timer; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventHandler<ExpandButtonClickedEventArgs> ExpandButtonClicked; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventHandler HelpRequested; // 0x68
	private TaskDialogItemCollection<TaskDialogButton> _buttons; // 0x70
	private TaskDialogItemCollection<TaskDialogRadioButton> _radioButtons; // 0x78
	private NativeMethods.TASKDIALOGCONFIG _config; // 0x80
	private TaskDialogIcon _mainIcon; // 0x130
	private Icon _customMainIcon; // 0x138
	private Icon _customFooterIcon; // 0x140
	private TaskDialogIcon _footerIcon; // 0x148
	private Dictionary<int, TaskDialogButton> _buttonsById; // 0x150
	private Dictionary<int, TaskDialogRadioButton> _radioButtonsById; // 0x158
	private IntPtr _handle; // 0x160
	private int _progressBarMarqueeAnimationSpeed; // 0x168
	private int _progressBarMinimimum; // 0x16C
	private int _progressBarMaximum; // 0x170
	private int _progressBarValue; // 0x174
	private ProgressBarState _progressBarState; // 0x178
	private int _inEventHandler; // 0x17C
	private bool _updatePending; // 0x180
	private object _tag; // 0x188
	private Icon _windowIcon; // 0x190
	private IContainer components; // 0x198

	// Properties
	public static bool OSSupportsTaskDialogs { get; }
	[Localizable(True)]
	[Category("Appearance")]
	[Description("A list of the buttons on the Task Dialog.")]
	[DesignerSerializationVisibility(2)]
	public TaskDialogItemCollection<TaskDialogButton> Buttons { get; }
	[Localizable(True)]
	[DesignerSerializationVisibility(2)]
	[Category("Appearance")]
	[Description("A list of the radio buttons on the Task Dialog.")]
	public TaskDialogItemCollection<TaskDialogRadioButton> RadioButtons { get; }
	[DefaultValue("")]
	[Description("The window title of the task dialog.")]
	[Localizable(True)]
	[Category("Appearance")]
	public string WindowTitle { get; set; }
	[Localizable(True)]
	[Category("Appearance")]
	[Description("The dialog's main instruction.")]
	[DefaultValue("")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	public string MainInstruction { get; set; }
	[DefaultValue("")]
	[Localizable(True)]
	[Category("Appearance")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	[Description("The dialog's primary content.")]
	public string Content { get; set; }
	[Category("Appearance")]
	[Description("The icon to be used in the title bar of the dialog. Used only when the dialog is shown as a modeless dialog.")]
	[DefaultValue(null)]
	[Localizable(True)]
	public Icon WindowIcon { get; set; }
	[Localizable(True)]
	[Category("Appearance")]
	[Description("The icon to display in the task dialog.")]
	[DefaultValue(0)]
	public TaskDialogIcon MainIcon { get; set; }
	[DefaultValue(null)]
	[Description("A custom icon to display in the dialog.")]
	[Localizable(True)]
	[Category("Appearance")]
	public Icon CustomMainIcon { get; set; }
	[DefaultValue(0)]
	[Description("The icon to display in the footer area of the task dialog.")]
	[Category("Appearance")]
	[Localizable(True)]
	public TaskDialogIcon FooterIcon { get; set; }
	[Localizable(True)]
	[Description("A custom icon to display in the footer area of the task dialog.")]
	[DefaultValue(null)]
	[Category("Appearance")]
	public Icon CustomFooterIcon { get; set; }
	[Category("Behavior")]
	[Description("Indicates whether custom buttons should be displayed as normal buttons or command links.")]
	[DefaultValue(0)]
	public TaskDialogButtonStyle ButtonStyle { get; set; }
	[Localizable(True)]
	[Category("Appearance")]
	[Description("The label for the verification checkbox.")]
	[DefaultValue("")]
	public string VerificationText { get; set; }
	[Category("Behavior")]
	[Description("Indicates whether the verification checkbox is checked ot not.")]
	[DefaultValue(False)]
	public bool IsVerificationChecked { get; set; }
	[Category("Appearance")]
	[Localizable(True)]
	[Description("Additional information to be displayed on the dialog.")]
	[DefaultValue("")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	public string ExpandedInformation { get; set; }
	[Category("Appearance")]
	[Description("The text to use for the control for collapsing the expandable information.")]
	[DefaultValue("")]
	[Localizable(True)]
	public string ExpandedControlText { get; set; }
	[Localizable(True)]
	[Category("Appearance")]
	[Description("The text to use for the control for expanding the expandable information.")]
	[DefaultValue("")]
	public string CollapsedControlText { get; set; }
	[Localizable(True)]
	[DefaultValue("")]
	[Description("The text to be used in the footer area of the task dialog.")]
	[Category("Appearance")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	public string Footer { get; set; }
	[DefaultValue(0)]
	[Description("the width of the task dialog's client area in DLU's. If 0, task dialog will calculate the ideal width.")]
	[Category("Appearance")]
	[Localizable(True)]
	public int Width { get; set; }
	[Description("Indicates whether hyperlinks are allowed for the Content, ExpandedInformation and Footer properties.")]
	[Category("Behavior")]
	[DefaultValue(False)]
	public bool EnableHyperlinks { get; set; }
	[Category("Behavior")]
	[Description("Indicates that the dialog should be able to be closed using Alt-F4, Escape and the title bar's close button even if no cancel button is specified.")]
	[DefaultValue(False)]
	public bool AllowDialogCancellation { get; set; }
	[Description("Indicates that the string specified by the ExpandedInformation property should be displayed at the bottom of the dialog's footer area instead of immediately after the dialog's content.")]
	[DefaultValue(False)]
	[Category("Behavior")]
	public bool ExpandFooterArea { get; set; }
	[Category("Behavior")]
	[Description("Indicates that the string specified by the ExpandedInformation property should be displayed by default.")]
	[DefaultValue(False)]
	public bool ExpandedByDefault { get; set; }
	[Category("Behavior")]
	[Description("Indicates whether the Timer event is raised periodically while the dialog is visible.")]
	[DefaultValue(False)]
	public bool RaiseTimerEvent { get; set; }
	[Description("Indicates whether the dialog is centered in the parent window instead of the screen.")]
	[DefaultValue(False)]
	[Category("Layout")]
	public bool CenterParent { get; set; }
	[Localizable(True)]
	[Description("Indicates whether text is displayed right to left.")]
	[DefaultValue(False)]
	[Category("Appearance")]
	public bool RightToLeft { get; set; }
	[Description("Indicates whether the dialog has a minimize box on its caption bar.")]
	[DefaultValue(False)]
	[Category("Window Style")]
	public bool MinimizeBox { get; set; }
	[Description("The type of progress bar displayed on the dialog.")]
	[DefaultValue(0)]
	[Category("Behavior")]
	public ProgressBarStyle ProgressBarStyle { get; set; }
	[Category("Behavior")]
	[Description("The marquee animation speed of the progress bar in milliseconds.")]
	[DefaultValue(100)]
	public int ProgressBarMarqueeAnimationSpeed { get; set; }
	[Category("Behavior")]
	[Description("The lower bound of the range of the task dialog's progress bar.")]
	[DefaultValue(0)]
	public int ProgressBarMinimum { get; set; }
	[Category("Behavior")]
	[DefaultValue(100)]
	[Description("The upper bound of the range of the task dialog's progress bar.")]
	public int ProgressBarMaximum { get; set; }
	[DefaultValue(0)]
	[Description("The current value of the task dialog's progress bar.")]
	[Category("Behavior")]
	public int ProgressBarValue { get; set; }
	[DefaultValue(0)]
	[Category("Behavior")]
	[Description("The state of the task dialog's progress bar.")]
	public ProgressBarState ProgressBarState { get; set; }
	[Description("User-defined data about the component.")]
	[Category("Data")]
	[DefaultValue(null)]
	public object Tag { get; set; }
	private bool IsDialogRunning { get; }
	[Browsable(False)]
	public IntPtr Handle { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E11CC0 Offset: 0x1E106C0 VA: 0x181E11CC0
	public void add_Created(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E12B10 Offset: 0x1E11510 VA: 0x181E12B10
	public void remove_Created(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E11D60 Offset: 0x1E10760 VA: 0x181E11D60
	public void add_Destroyed(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E12BB0 Offset: 0x1E115B0 VA: 0x181E12BB0
	public void remove_Destroyed(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E11C10 Offset: 0x1E10610 VA: 0x181E11C10
	public void add_ButtonClicked(EventHandler<TaskDialogItemClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12A60 Offset: 0x1E11460 VA: 0x181E12A60
	public void remove_ButtonClicked(EventHandler<TaskDialogItemClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12000 Offset: 0x1E10A00 VA: 0x181E12000
	public void add_RadioButtonClicked(EventHandler<TaskDialogItemClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12E50 Offset: 0x1E11850 VA: 0x181E12E50
	public void remove_RadioButtonClicked(EventHandler<TaskDialogItemClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E11F50 Offset: 0x1E10950 VA: 0x181E11F50
	public void add_HyperlinkClicked(EventHandler<HyperlinkClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12DA0 Offset: 0x1E117A0 VA: 0x181E12DA0
	public void remove_HyperlinkClicked(EventHandler<HyperlinkClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12160 Offset: 0x1E10B60 VA: 0x181E12160
	public void add_VerificationClicked(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E12FB0 Offset: 0x1E119B0 VA: 0x181E12FB0
	public void remove_VerificationClicked(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E120B0 Offset: 0x1E10AB0 VA: 0x181E120B0
	public void add_Timer(EventHandler<TimerEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12F00 Offset: 0x1E11900 VA: 0x181E12F00
	public void remove_Timer(EventHandler<TimerEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E11E00 Offset: 0x1E10800 VA: 0x181E11E00
	public void add_ExpandButtonClicked(EventHandler<ExpandButtonClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E12C50 Offset: 0x1E11650 VA: 0x181E12C50
	public void remove_ExpandButtonClicked(EventHandler<ExpandButtonClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E11EB0 Offset: 0x1E108B0 VA: 0x181E11EB0
	public void add_HelpRequested(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E12D00 Offset: 0x1E11700 VA: 0x181E12D00
	public void remove_HelpRequested(EventHandler value) { }

	// RVA: 0x1E119A0 Offset: 0x1E103A0 VA: 0x181E119A0
	public void .ctor() { }

	// RVA: 0x1E11710 Offset: 0x1E10110 VA: 0x181E11710
	public void .ctor(IContainer container) { }

	// RVA: 0x1E04C50 Offset: 0x1E03650 VA: 0x181E04C50
	public static bool get_OSSupportsTaskDialogs() { }

	// RVA: 0x1E12240 Offset: 0x1E10C40 VA: 0x181E12240
	public TaskDialogItemCollection<TaskDialogButton> get_Buttons() { }

	// RVA: 0x1E127E0 Offset: 0x1E111E0 VA: 0x181E127E0
	public TaskDialogItemCollection<TaskDialogRadioButton> get_RadioButtons() { }

	// RVA: 0x1E12A10 Offset: 0x1E11410 VA: 0x181E12A10
	public string get_WindowTitle() { }

	// RVA: 0x1E13A70 Offset: 0x1E12470 VA: 0x181E13A70
	public void set_WindowTitle(string value) { }

	// RVA: 0x1E12660 Offset: 0x1E11060 VA: 0x181E12660
	public string get_MainInstruction() { }

	// RVA: 0x1E136A0 Offset: 0x1E120A0 VA: 0x181E136A0
	public void set_MainInstruction(string value) { }

	// RVA: 0x1E12320 Offset: 0x1E10D20 VA: 0x181E12320
	public string get_Content() { }

	// RVA: 0x1E131B0 Offset: 0x1E11BB0 VA: 0x181E131B0
	public void set_Content(string value) { }

	// RVA: 0x1E12990 Offset: 0x1E11390 VA: 0x181E12990
	public Icon get_WindowIcon() { }

	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	public void set_WindowIcon(Icon value) { }

	// RVA: 0x1E12650 Offset: 0x1E11050 VA: 0x181E12650
	public TaskDialogIcon get_MainIcon() { }

	// RVA: 0x1E13680 Offset: 0x1E12080 VA: 0x181E13680
	public void set_MainIcon(TaskDialogIcon value) { }

	// RVA: 0x1E12380 Offset: 0x1E10D80 VA: 0x181E12380
	public Icon get_CustomMainIcon() { }

	// RVA: 0x1E13280 Offset: 0x1E11C80 VA: 0x181E13280
	public void set_CustomMainIcon(Icon value) { }

	// RVA: 0x1E12460 Offset: 0x1E10E60 VA: 0x181E12460
	public TaskDialogIcon get_FooterIcon() { }

	// RVA: 0x1E134A0 Offset: 0x1E11EA0 VA: 0x181E134A0
	public void set_FooterIcon(TaskDialogIcon value) { }

	// RVA: 0x1E12370 Offset: 0x1E10D70 VA: 0x181E12370
	public Icon get_CustomFooterIcon() { }

	// RVA: 0x1E13240 Offset: 0x1E11C40 VA: 0x181E13240
	public void set_CustomFooterIcon(Icon value) { }

	// RVA: 0x1E12210 Offset: 0x1E10C10 VA: 0x181E12210
	public TaskDialogButtonStyle get_ButtonStyle() { }

	// RVA: 0x1E130A0 Offset: 0x1E11AA0 VA: 0x181E130A0
	public void set_ButtonStyle(TaskDialogButtonStyle value) { }

	// RVA: 0x1E12930 Offset: 0x1E11330 VA: 0x181E12930
	public string get_VerificationText() { }

	// RVA: 0x1E139E0 Offset: 0x1E123E0 VA: 0x181E139E0
	public void set_VerificationText(string value) { }

	// RVA: 0x1E12640 Offset: 0x1E11040 VA: 0x181E12640
	public bool get_IsVerificationChecked() { }

	// RVA: 0x1E13550 Offset: 0x1E11F50 VA: 0x181E13550
	public void set_IsVerificationChecked(bool value) { }

	// RVA: 0x1E12410 Offset: 0x1E10E10 VA: 0x181E12410
	public string get_ExpandedInformation() { }

	// RVA: 0x1E13410 Offset: 0x1E11E10 VA: 0x181E13410
	public void set_ExpandedInformation(string value) { }

	// RVA: 0x1E123C0 Offset: 0x1E10DC0 VA: 0x181E123C0
	public string get_ExpandedControlText() { }

	// RVA: 0x1E133A0 Offset: 0x1E11DA0 VA: 0x181E133A0
	public void set_ExpandedControlText(string value) { }

	// RVA: 0x1E122D0 Offset: 0x1E10CD0 VA: 0x181E122D0
	public string get_CollapsedControlText() { }

	// RVA: 0x1E13130 Offset: 0x1E11B30 VA: 0x181E13130
	public void set_CollapsedControlText(string value) { }

	// RVA: 0x1E12470 Offset: 0x1E10E70 VA: 0x181E12470
	public string get_Footer() { }

	// RVA: 0x1E134C0 Offset: 0x1E11EC0 VA: 0x181E134C0
	public void set_Footer(string value) { }

	// RVA: 0x1E12980 Offset: 0x1E11380 VA: 0x181E12980
	public int get_Width() { }

	// RVA: 0x1E13A50 Offset: 0x1E12450 VA: 0x181E13A50
	public void set_Width(int value) { }

	// RVA: 0x1E12390 Offset: 0x1E10D90 VA: 0x181E12390
	public bool get_EnableHyperlinks() { }

	// RVA: 0x1E132C0 Offset: 0x1E11CC0 VA: 0x181E132C0
	public void set_EnableHyperlinks(bool value) { }

	// RVA: 0x1E12200 Offset: 0x1E10C00 VA: 0x181E12200
	public bool get_AllowDialogCancellation() { }

	// RVA: 0x1E13050 Offset: 0x1E11A50 VA: 0x181E13050
	public void set_AllowDialogCancellation(bool value) { }

	// RVA: 0x1E123A0 Offset: 0x1E10DA0 VA: 0x181E123A0
	public bool get_ExpandFooterArea() { }

	// RVA: 0x1E13300 Offset: 0x1E11D00 VA: 0x181E13300
	public void set_ExpandFooterArea(bool value) { }

	// RVA: 0x1E123B0 Offset: 0x1E10DB0 VA: 0x181E123B0
	public bool get_ExpandedByDefault() { }

	// RVA: 0x1E13350 Offset: 0x1E11D50 VA: 0x181E13350
	public void set_ExpandedByDefault(bool value) { }

	// RVA: 0x1E12860 Offset: 0x1E11260 VA: 0x181E12860
	public bool get_RaiseTimerEvent() { }

	// RVA: 0x1E13940 Offset: 0x1E12340 VA: 0x181E13940
	public void set_RaiseTimerEvent(bool value) { }

	// RVA: 0x1E122C0 Offset: 0x1E10CC0 VA: 0x181E122C0
	public bool get_CenterParent() { }

	// RVA: 0x1E130E0 Offset: 0x1E11AE0 VA: 0x181E130E0
	public void set_CenterParent(bool value) { }

	// RVA: 0x1E12870 Offset: 0x1E11270 VA: 0x181E12870
	public bool get_RightToLeft() { }

	// RVA: 0x1E13990 Offset: 0x1E12390 VA: 0x181E13990
	public void set_RightToLeft(bool value) { }

	// RVA: 0x1E126B0 Offset: 0x1E110B0 VA: 0x181E126B0
	public bool get_MinimizeBox() { }

	// RVA: 0x1E13730 Offset: 0x1E12130 VA: 0x181E13730
	public void set_MinimizeBox(bool value) { }

	// RVA: 0x1E127A0 Offset: 0x1E111A0 VA: 0x181E127A0
	public ProgressBarStyle get_ProgressBarStyle() { }

	// RVA: 0x1E13880 Offset: 0x1E12280 VA: 0x181E13880
	public void set_ProgressBarStyle(ProgressBarStyle value) { }

	// RVA: 0x1E12760 Offset: 0x1E11160 VA: 0x181E12760
	public int get_ProgressBarMarqueeAnimationSpeed() { }

	// RVA: 0x1E13780 Offset: 0x1E12180 VA: 0x181E13780
	public void set_ProgressBarMarqueeAnimationSpeed(int value) { }

	// RVA: 0x1E12780 Offset: 0x1E11180 VA: 0x181E12780
	public int get_ProgressBarMinimum() { }

	// RVA: 0x1E13800 Offset: 0x1E12200 VA: 0x181E13800
	public void set_ProgressBarMinimum(int value) { }

	// RVA: 0x1E12770 Offset: 0x1E11170 VA: 0x181E12770
	public int get_ProgressBarMaximum() { }

	// RVA: 0x1E13790 Offset: 0x1E12190 VA: 0x181E13790
	public void set_ProgressBarMaximum(int value) { }

	// RVA: 0x1E127D0 Offset: 0x1E111D0 VA: 0x181E127D0
	public int get_ProgressBarValue() { }

	// RVA: 0x1E138C0 Offset: 0x1E122C0 VA: 0x181E138C0
	public void set_ProgressBarValue(int value) { }

	// RVA: 0x1E12790 Offset: 0x1E11190 VA: 0x181E12790
	public ProgressBarState get_ProgressBarState() { }

	// RVA: 0x1E13870 Offset: 0x1E12270 VA: 0x181E13870
	public void set_ProgressBarState(ProgressBarState value) { }

	// RVA: 0x1E12920 Offset: 0x1E11320 VA: 0x181E12920
	public object get_Tag() { }

	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	public void set_Tag(object value) { }

	// RVA: 0x1E109A0 Offset: 0x1E0F3A0 VA: 0x181E109A0
	public TaskDialogButton Show() { }

	// RVA: 0x1E10100 Offset: 0x1E0EB00 VA: 0x181E10100
	public TaskDialogButton ShowDialog() { }

	// RVA: 0x1E10930 Offset: 0x1E0F330 VA: 0x181E10930
	public TaskDialogButton ShowDialog(IWin32Window owner) { }

	// RVA: 0x1E0E860 Offset: 0x1E0D260 VA: 0x181E0E860
	public void ClickVerification(bool checkState, bool setFocus) { }

	// RVA: 0x1E0F3D0 Offset: 0x1E0DDD0 VA: 0x181E0F3D0 Slot: 15
	protected virtual void OnHyperlinkClicked(HyperlinkClickedEventArgs e) { }

	// RVA: 0x1E0F340 Offset: 0x1E0DD40 VA: 0x181E0F340 Slot: 16
	protected virtual void OnButtonClicked(TaskDialogItemClickedEventArgs e) { }

	// RVA: 0x1E0F400 Offset: 0x1E0DE00 VA: 0x181E0F400 Slot: 17
	protected virtual void OnRadioButtonClicked(TaskDialogItemClickedEventArgs e) { }

	// RVA: 0x1E06220 Offset: 0x1E04C20 VA: 0x181E06220 Slot: 18
	protected virtual void OnVerificationClicked(EventArgs e) { }

	// RVA: 0x1E0F370 Offset: 0x1E0DD70 VA: 0x181E0F370 Slot: 19
	protected virtual void OnCreated(EventArgs e) { }

	// RVA: 0x1E06250 Offset: 0x1E04C50 VA: 0x181E06250 Slot: 20
	protected virtual void OnTimer(TimerEventArgs e) { }

	// RVA: 0x1E0F3A0 Offset: 0x1E0DDA0 VA: 0x181E0F3A0 Slot: 21
	protected virtual void OnDestroyed(EventArgs e) { }

	// RVA: 0x1DFF790 Offset: 0x1DFE190 VA: 0x181DFF790 Slot: 22
	protected virtual void OnExpandButtonClicked(ExpandButtonClickedEventArgs e) { }

	// RVA: 0x1DFF760 Offset: 0x1DFE160 VA: 0x181DFF760 Slot: 23
	protected virtual void OnHelpRequested(EventArgs e) { }

	// RVA: 0x1E0F620 Offset: 0x1E0E020 VA: 0x181E0F620
	internal void SetItemEnabled(TaskDialogItem item) { }

	// RVA: 0x1E0F430 Offset: 0x1E0DE30 VA: 0x181E0F430
	internal void SetButtonElevationRequired(TaskDialogButton button) { }

	// RVA: 0x1E0E710 Offset: 0x1E0D110 VA: 0x181E0E710
	internal void ClickItem(TaskDialogItem item) { }

	// RVA: 0x1E10140 Offset: 0x1E0EB40 VA: 0x181E10140
	private TaskDialogButton ShowDialog(IntPtr owner) { }

	// RVA: 0x1E11060 Offset: 0x1E0FA60 VA: 0x181E11060
	internal void UpdateDialog() { }

	// RVA: 0x1E12620 Offset: 0x1E11020 VA: 0x181E12620
	private bool get_IsDialogRunning() { }

	// RVA: 0x1E0F4F0 Offset: 0x1E0DEF0 VA: 0x181E0F4F0
	private void SetElementText(NativeMethods.TaskDialogElements element, string text) { }

	// RVA: 0x1E0FC20 Offset: 0x1E0E620 VA: 0x181E0FC20
	private void SetupIcon() { }

	// RVA: 0x1E0FB80 Offset: 0x1E0E580 VA: 0x181E0FB80
	private void SetupIcon(TaskDialogIcon icon, Icon customIcon, NativeMethods.TaskDialogFlags flag) { }

	// RVA: 0x1E0E560 Offset: 0x1E0CF60 VA: 0x181E0E560
	private static void CleanUpButtons(ref IntPtr buttons, ref uint count) { }

	// RVA: 0x1E0F170 Offset: 0x1E0DB70 VA: 0x181E0F170
	private static void MarshalButtons(List<NativeMethods.TASKDIALOG_BUTTON> buttons, out IntPtr buttonsPtr, out uint count) { }

	// RVA: 0x1E0F740 Offset: 0x1E0E140 VA: 0x181E0F740
	private List<NativeMethods.TASKDIALOG_BUTTON> SetupButtons() { }

	// RVA: 0x1E0FCE0 Offset: 0x1E0E6E0 VA: 0x181E0FCE0
	private List<NativeMethods.TASKDIALOG_BUTTON> SetupRadioButtons() { }

	// RVA: 0x1E0F600 Offset: 0x1E0E000 VA: 0x181E0F600
	private void SetFlag(NativeMethods.TaskDialogFlags flag, bool value) { }

	// RVA: 0x1E0F0F0 Offset: 0x1E0DAF0 VA: 0x181E0F0F0
	private bool GetFlag(NativeMethods.TaskDialogFlags flag) { }

	// RVA: 0x1E109B0 Offset: 0x1E0F3B0 VA: 0x181E109B0
	private uint TaskDialogCallback(IntPtr hwnd, uint uNotification, IntPtr wParam, IntPtr lParam, IntPtr dwRefData) { }

	// RVA: 0x1E0E950 Offset: 0x1E0D350 VA: 0x181E0E950
	private void DialogCreated() { }

	// RVA: 0x1E115F0 Offset: 0x1E0FFF0 VA: 0x181E115F0
	private void UpdateProgressBarStyle() { }

	// RVA: 0x1E11370 Offset: 0x1E0FD70 VA: 0x181E11370
	private void UpdateProgressBarMarqueeSpeed() { }

	// RVA: 0x1E11410 Offset: 0x1E0FE10 VA: 0x181E11410
	private void UpdateProgressBarRange() { }

	// RVA: 0x1E11690 Offset: 0x1E10090 VA: 0x181E11690
	private void UpdateProgressBarValue() { }

	// RVA: 0x1E11570 Offset: 0x1E0FF70 VA: 0x181E11570
	private void UpdateProgressBarState() { }

	// RVA: 0x1E0E410 Offset: 0x1E0CE10 VA: 0x181E0E410
	private void CheckCrossThreadCall() { }

	// RVA: 0x1E124C0 Offset: 0x1E10EC0 VA: 0x181E124C0 Slot: 14
	public IntPtr get_Handle() { }

	// RVA: 0x1E0ECA0 Offset: 0x1E0D6A0 VA: 0x181E0ECA0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E0F100 Offset: 0x1E0DB00 VA: 0x181E0F100
	private void InitializeComponent() { }
}
