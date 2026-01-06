public class TaskDialogButton : TaskDialogItem // TypeDefIndex: 17303
{
	// Fields
	private ButtonType _type; // 0x48
	private bool _elevationRequired; // 0x4C
	private bool _default; // 0x4D
	private string _commandLinkNote; // 0x50

	// Properties
	[Category("Appearance")]
	[DefaultValue(0)]
	[Description("The type of the button.")]
	public ButtonType ButtonType { get; set; }
	[Localizable(True)]
	[Category("Appearance")]
	[Description("The text of the note associated with a command link button.")]
	[DefaultValue("")]
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	public string CommandLinkNote { get; set; }
	[Category("Behavior")]
	[DefaultValue(False)]
	[Description("Indicates if the button is the default button on the dialog.")]
	public bool Default { get; set; }
	[DefaultValue(False)]
	[Description("Indicates whether the Task Dialog button or command link should have a User Account Control (UAC) shield icon (in other words, whether the action invoked by the button requires elevation).")]
	[Category("Behavior")]
	public bool ElevationRequired { get; set; }
	internal override int Id { get; set; }
	internal NativeMethods.TaskDialogCommonButtonFlags ButtonFlag { get; }
	protected override IEnumerable ItemCollection { get; }

	// Methods

	// RVA: 0x1E0CCC0 Offset: 0x1E0B6C0 VA: 0x181E0CCC0
	public void .ctor() { }

	// RVA: 0x1E0CCD0 Offset: 0x1E0B6D0 VA: 0x181E0CCD0
	public void .ctor(ButtonType type) { }

	// RVA: 0x1E0CDA0 Offset: 0x1E0B7A0 VA: 0x181E0CDA0
	public void .ctor(IContainer container) { }

	// RVA: 0x1E0CC70 Offset: 0x1E0B670 VA: 0x181E0CC70
	public void .ctor(string text) { }

	// RVA: 0x1E06CB0 Offset: 0x1E056B0 VA: 0x181E06CB0
	public ButtonType get_ButtonType() { }

	// RVA: 0x1E0CEC0 Offset: 0x1E0B8C0 VA: 0x181E0CEC0
	public void set_ButtonType(ButtonType value) { }

	// RVA: 0x1E0CE20 Offset: 0x1E0B820 VA: 0x181E0CE20
	public string get_CommandLinkNote() { }

	// RVA: 0x1E0CF30 Offset: 0x1E0B930 VA: 0x181E0CF30
	public void set_CommandLinkNote(string value) { }

	// RVA: 0x1E0CE70 Offset: 0x1E0B870 VA: 0x181E0CE70
	public bool get_Default() { }

	// RVA: 0x1E0CF70 Offset: 0x1E0B970 VA: 0x181E0CF70
	public void set_Default(bool value) { }

	// RVA: 0x1E06CC0 Offset: 0x1E056C0 VA: 0x181E06CC0
	public bool get_ElevationRequired() { }

	// RVA: 0x1E0D190 Offset: 0x1E0BB90 VA: 0x181E0D190
	public void set_ElevationRequired(bool value) { }

	// RVA: 0x1E0CE80 Offset: 0x1E0B880 VA: 0x181E0CE80 Slot: 14
	internal override int get_Id() { }

	// RVA: 0x1E0D1B0 Offset: 0x1E0BBB0 VA: 0x181E0D1B0 Slot: 15
	internal override void set_Id(int value) { }

	// RVA: 0x1E0CA40 Offset: 0x1E0B440 VA: 0x181E0CA40 Slot: 18
	internal override void AutoAssignId() { }

	// RVA: 0x1E0CC30 Offset: 0x1E0B630 VA: 0x181E0CC30 Slot: 17
	internal override void CheckDuplicate(TaskDialogItem itemToExclude) { }

	// RVA: 0x1E0CDB0 Offset: 0x1E0B7B0 VA: 0x181E0CDB0
	internal NativeMethods.TaskDialogCommonButtonFlags get_ButtonFlag() { }

	// RVA: 0x1E0CE90 Offset: 0x1E0B890 VA: 0x181E0CE90 Slot: 16
	protected override IEnumerable get_ItemCollection() { }

	// RVA: 0x1E0CA50 Offset: 0x1E0B450 VA: 0x181E0CA50
	private void CheckDuplicateButton(ButtonType type, TaskDialogItem itemToExclude) { }
}
