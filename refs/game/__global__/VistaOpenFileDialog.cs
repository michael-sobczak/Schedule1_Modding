public class VistaOpenFileDialog : VistaFileDialog // TypeDefIndex: 17315
{
	// Fields
	private bool _showReadOnly; // 0x90
	private bool _readOnlyChecked; // 0x91
	private const int _openDropDownId = 16386;
	private const int _openItemId = 16387;
	private const int _readOnlyItemId = 16388;

	// Properties
	[DefaultValue(True)]
	[Description("A value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.")]
	public override bool CheckFileExists { get; set; }
	[Description("A value indicating whether the dialog box allows multiple files to be selected.")]
	[Category("Behavior")]
	[DefaultValue(False)]
	public bool Multiselect { get; set; }
	[DefaultValue(False)]
	[Category("Behavior")]
	[Description("A value indicating whether the dialog box contains a read-only check box.")]
	public bool ShowReadOnly { get; set; }
	[Description("A value indicating whether the read-only check box is selected.")]
	[Category("Behavior")]
	[DefaultValue(False)]
	public bool ReadOnlyChecked { get; set; }

	// Methods

	// RVA: 0x1E17100 Offset: 0x1E15B00 VA: 0x181E17100
	public void .ctor() { }

	// RVA: 0x1E16F00 Offset: 0x1E15900 VA: 0x181E16F00
	public void .ctor(bool forceDownlevel) { }

	// RVA: 0x1E14F50 Offset: 0x1E13950 VA: 0x181E14F50 Slot: 17
	public override bool get_CheckFileExists() { }

	// RVA: 0x1E154F0 Offset: 0x1E13EF0 VA: 0x181E154F0 Slot: 18
	public override void set_CheckFileExists(bool value) { }

	// RVA: 0x1E17110 Offset: 0x1E15B10 VA: 0x181E17110
	public bool get_Multiselect() { }

	// RVA: 0x1E17290 Offset: 0x1E15C90 VA: 0x181E17290
	public void set_Multiselect(bool value) { }

	// RVA: 0x1E17210 Offset: 0x1E15C10 VA: 0x181E17210
	public bool get_ShowReadOnly() { }

	// RVA: 0x1E173D0 Offset: 0x1E15DD0 VA: 0x181E173D0
	public void set_ShowReadOnly(bool value) { }

	// RVA: 0x1E17190 Offset: 0x1E15B90 VA: 0x181E17190
	public bool get_ReadOnlyChecked() { }

	// RVA: 0x1E17330 Offset: 0x1E15D30 VA: 0x181E17330
	public void set_ReadOnlyChecked(bool value) { }

	// RVA: 0x1E16D20 Offset: 0x1E15720 VA: 0x181E16D20 Slot: 14
	public override void Reset() { }

	// RVA: 0x1E16BF0 Offset: 0x1E155F0 VA: 0x181E16BF0
	public Stream OpenFile() { }

	// RVA: 0x1E164A0 Offset: 0x1E14EA0 VA: 0x181E164A0 Slot: 22
	internal override IFileDialog CreateFileDialog() { }

	// RVA: 0x1E16D60 Offset: 0x1E15760 VA: 0x181E16D60 Slot: 21
	internal override void SetDialogProperties(IFileDialog dialog) { }

	// RVA: 0x1E16520 Offset: 0x1E14F20 VA: 0x181E16520 Slot: 19
	internal override void GetResult(IFileDialog dialog) { }
}
