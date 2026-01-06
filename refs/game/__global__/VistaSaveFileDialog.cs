public class VistaSaveFileDialog : VistaFileDialog // TypeDefIndex: 17316
{
	// Properties
	[DefaultValue(False)]
	[Category("Behavior")]
	[Description("A value indicating whether the dialog box prompts the user for permission to create a file if the user specifies a file that does not exist.")]
	public bool CreatePrompt { get; set; }
	[Category("Behavior")]
	[DefaultValue(True)]
	[Description("A value indicating whether the Save As dialog box displays a warning if the user specifies a file name that already exists.")]
	public bool OverwritePrompt { get; set; }

	// Methods

	// RVA: 0x1E17C00 Offset: 0x1E16600 VA: 0x181E17C00
	public void .ctor() { }

	// RVA: 0x1E17A00 Offset: 0x1E16400 VA: 0x181E17A00
	public void .ctor(bool forceDownlevel) { }

	// RVA: 0x1E17C10 Offset: 0x1E16610 VA: 0x181E17C10
	public bool get_CreatePrompt() { }

	// RVA: 0x1E17D10 Offset: 0x1E16710 VA: 0x181E17D10
	public void set_CreatePrompt(bool value) { }

	// RVA: 0x1E17C90 Offset: 0x1E16690 VA: 0x181E17C90
	public bool get_OverwritePrompt() { }

	// RVA: 0x1E17DB0 Offset: 0x1E167B0 VA: 0x181E17DB0
	public void set_OverwritePrompt(bool value) { }

	// RVA: 0x1E17970 Offset: 0x1E16370 VA: 0x181E17970 Slot: 14
	public override void Reset() { }

	// RVA: 0x1E17840 Offset: 0x1E16240 VA: 0x181E17840
	public Stream OpenFile() { }

	// RVA: 0x1E174F0 Offset: 0x1E15EF0 VA: 0x181E174F0 Slot: 20
	protected override void OnFileOk(CancelEventArgs e) { }

	// RVA: 0x1E17470 Offset: 0x1E15E70 VA: 0x181E17470 Slot: 22
	internal override IFileDialog CreateFileDialog() { }
}
