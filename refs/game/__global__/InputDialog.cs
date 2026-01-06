public class InputDialog : Component, IBindableComponent, IComponent, IDisposable // TypeDefIndex: 17252
{
	// Fields
	private string _mainInstruction; // 0x28
	private string _content; // 0x30
	private string _windowTitle; // 0x38
	private string _input; // 0x40
	private int _maxLength; // 0x48
	private bool _usePasswordMasking; // 0x4C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventHandler InputChanged; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventHandler<OkButtonClickedEventArgs> OkButtonClicked; // 0x58
	private BindingContext _context; // 0x60
	private ControlBindingsCollection _bindings; // 0x68
	private IContainer components; // 0x70

	// Properties
	[Localizable(True)]
	[Category("Appearance")]
	[Description("The dialog's main instruction.")]
	[DefaultValue("")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	public string MainInstruction { get; set; }
	[Category("Appearance")]
	[Localizable(True)]
	[Description("The dialog's primary content.")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	[DefaultValue("")]
	public string Content { get; set; }
	[Localizable(True)]
	[Category("Appearance")]
	[DefaultValue("")]
	[Description("The window title of the task dialog.")]
	public string WindowTitle { get; set; }
	[DefaultValue("")]
	[Description("The text specified by the user.")]
	[Category("Appearance")]
	[Localizable(True)]
	public string Input { get; set; }
	[Description("The maximum number of characters that can be entered into the input field of the dialog.")]
	[Category("Behavior")]
	[Localizable(True)]
	[DefaultValue(32767)]
	public int MaxLength { get; set; }
	[DefaultValue(False)]
	[Description("Indicates whether the input will be masked using the system password character.")]
	[Category("Behavior")]
	public bool UsePasswordMasking { get; set; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public BindingContext BindingContext { get; set; }
	[RefreshProperties(1)]
	[Category("Data")]
	[DesignerSerializationVisibility(2)]
	[ParenthesizePropertyName(True)]
	public ControlBindingsCollection DataBindings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E06990 Offset: 0x1E05390 VA: 0x181E06990
	public void add_InputChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E06D20 Offset: 0x1E05720 VA: 0x181E06D20
	public void remove_InputChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E06A30 Offset: 0x1E05430 VA: 0x181E06A30
	public void add_OkButtonClicked(EventHandler<OkButtonClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E06DC0 Offset: 0x1E057C0 VA: 0x181E06DC0
	public void remove_OkButtonClicked(EventHandler<OkButtonClickedEventArgs> value) { }

	// RVA: 0x1E068D0 Offset: 0x1E052D0 VA: 0x181E068D0
	public void .ctor() { }

	// RVA: 0x1E067F0 Offset: 0x1E051F0 VA: 0x181E067F0
	public void .ctor(IContainer container) { }

	// RVA: 0x1E06C60 Offset: 0x1E05660 VA: 0x181E06C60
	public string get_MainInstruction() { }

	// RVA: 0x1E06F60 Offset: 0x1E05960 VA: 0x181E06F60
	public void set_MainInstruction(string value) { }

	// RVA: 0x1E06B50 Offset: 0x1E05550 VA: 0x181E06B50
	public string get_Content() { }

	// RVA: 0x1E06E70 Offset: 0x1E05870 VA: 0x181E06E70
	public void set_Content(string value) { }

	// RVA: 0x1E06CD0 Offset: 0x1E056D0 VA: 0x181E06CD0
	public string get_WindowTitle() { }

	// RVA: 0x1E06FB0 Offset: 0x1E059B0 VA: 0x181E06FB0
	public void set_WindowTitle(string value) { }

	// RVA: 0x1E06C10 Offset: 0x1E05610 VA: 0x181E06C10
	public string get_Input() { }

	// RVA: 0x1E06EC0 Offset: 0x1E058C0 VA: 0x181E06EC0
	public void set_Input(string value) { }

	// RVA: 0x1E06CB0 Offset: 0x1E056B0 VA: 0x181E06CB0
	public int get_MaxLength() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_MaxLength(int value) { }

	// RVA: 0x1E06CC0 Offset: 0x1E056C0 VA: 0x181E06CC0
	public bool get_UsePasswordMasking() { }

	// RVA: 0xAEE590 Offset: 0xAECF90 VA: 0x180AEE590
	public void set_UsePasswordMasking(bool value) { }

	// RVA: 0x1E06220 Offset: 0x1E04C20 VA: 0x181E06220 Slot: 15
	protected virtual void OnInputChanged(EventArgs e) { }

	// RVA: 0x1E06250 Offset: 0x1E04C50 VA: 0x181E06250 Slot: 16
	protected virtual void OnOkButtonClicked(OkButtonClickedEventArgs e) { }

	// RVA: 0x1E067E0 Offset: 0x1E051E0 VA: 0x181E067E0
	public DialogResult ShowDialog() { }

	// RVA: 0x1E06280 Offset: 0x1E04C80 VA: 0x181E06280
	public DialogResult ShowDialog(IWin32Window owner) { }

	// RVA: 0x1E06200 Offset: 0x1E04C00 VA: 0x181E06200
	private void InputBoxForm_OkButtonClicked(object sender, OkButtonClickedEventArgs e) { }

	// RVA: 0x1E06AE0 Offset: 0x1E054E0 VA: 0x181E06AE0 Slot: 14
	public BindingContext get_BindingContext() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0 Slot: 17
	public void set_BindingContext(BindingContext value) { }

	// RVA: 0x1E06BA0 Offset: 0x1E055A0 VA: 0x181E06BA0 Slot: 18
	public ControlBindingsCollection get_DataBindings() { }

	// RVA: 0x1E060E0 Offset: 0x1E04AE0 VA: 0x181E060E0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E061A0 Offset: 0x1E04BA0 VA: 0x181E061A0
	private void InitializeComponent() { }
}
