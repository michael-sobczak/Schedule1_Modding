public sealed class VistaFolderBrowserDialog : CommonDialog // TypeDefIndex: 17314
{
	// Fields
	private FolderBrowserDialog _downlevelDialog; // 0x30
	private string _description; // 0x38
	private bool _useDescriptionForTitle; // 0x40
	private string _selectedPath; // 0x48
	private Environment.SpecialFolder _rootFolder; // 0x50
	private bool _showNewFolderButton; // 0x54

	// Properties
	[Browsable(False)]
	public static bool IsVistaFolderDialogSupported { get; }
	[Category("Folder Browsing")]
	[DefaultValue("")]
	[Browsable(True)]
	[Description("The descriptive text displayed above the tree view control in the dialog box, or below the list view control in the Vista style dialog.")]
	[Localizable(True)]
	public string Description { get; set; }
	[DefaultValue(typeof(Environment.SpecialFolder), "Desktop")]
	[Browsable(True)]
	[Category("Folder Browsing")]
	[Description("The root folder where the browsing starts from. This property has no effect if the Vista style dialog is used.")]
	[Localizable(False)]
	public Environment.SpecialFolder RootFolder { get; set; }
	[Description("The path selected by the user.")]
	[Category("Folder Browsing")]
	[Editor("System.Windows.Forms.Design.SelectedPathEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Browsable(True)]
	[Localizable(True)]
	[DefaultValue("")]
	public string SelectedPath { get; set; }
	[Localizable(False)]
	[Browsable(True)]
	[DefaultValue(True)]
	[Category("Folder Browsing")]
	[Description("A value indicating whether the New Folder button appears in the folder browser dialog box. This property has no effect if the Vista style dialog is used; in that case, the New Folder button is always shown.")]
	public bool ShowNewFolderButton { get; set; }
	[Category("Folder Browsing")]
	[DefaultValue(False)]
	[Description("A value that indicates whether to use the value of the Description property as the dialog title for Vista style dialogs. This property has no effect on old style dialogs.")]
	public bool UseDescriptionForTitle { get; set; }

	// Methods

	// RVA: 0x1E16260 Offset: 0x1E14C60 VA: 0x181E16260
	public void add_HelpRequest(EventHandler value) { }

	// RVA: 0x1E16310 Offset: 0x1E14D10 VA: 0x181E16310
	public void remove_HelpRequest(EventHandler value) { }

	// RVA: 0x1E16190 Offset: 0x1E14B90 VA: 0x181E16190
	public void .ctor() { }

	// RVA: 0x1E04C50 Offset: 0x1E03650 VA: 0x181E04C50
	public static bool get_IsVistaFolderDialogSupported() { }

	// RVA: 0x1E16270 Offset: 0x1E14C70 VA: 0x181E16270
	public string get_Description() { }

	// RVA: 0x1E16320 Offset: 0x1E14D20 VA: 0x181E16320
	public void set_Description(string value) { }

	// RVA: 0x1E162A0 Offset: 0x1E14CA0 VA: 0x181E162A0
	public Environment.SpecialFolder get_RootFolder() { }

	// RVA: 0x1E163B0 Offset: 0x1E14DB0 VA: 0x181E163B0
	public void set_RootFolder(Environment.SpecialFolder value) { }

	// RVA: 0x1E162C0 Offset: 0x1E14CC0 VA: 0x181E162C0
	public string get_SelectedPath() { }

	// RVA: 0x1E163E0 Offset: 0x1E14DE0 VA: 0x181E163E0
	public void set_SelectedPath(string value) { }

	// RVA: 0x1E162E0 Offset: 0x1E14CE0 VA: 0x181E162E0
	public bool get_ShowNewFolderButton() { }

	// RVA: 0x1E16470 Offset: 0x1E14E70 VA: 0x181E16470
	public void set_ShowNewFolderButton(bool value) { }

	// RVA: 0x1E16300 Offset: 0x1E14D00 VA: 0x181E16300
	public bool get_UseDescriptionForTitle() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_UseDescriptionForTitle(bool value) { }

	// RVA: 0x1E15C10 Offset: 0x1E14610 VA: 0x181E15C10 Slot: 14
	public override void Reset() { }

	// RVA: 0x1E15C90 Offset: 0x1E14690 VA: 0x181E15C90 Slot: 16
	protected override bool RunDialog(IntPtr hwndOwner) { }

	// RVA: 0x1E13E80 Offset: 0x1E12880 VA: 0x181E13E80 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E15FD0 Offset: 0x1E149D0 VA: 0x181E15FD0
	private void SetDialogProperties(IFileDialog dialog) { }

	// RVA: 0x1E15B00 Offset: 0x1E14500 VA: 0x181E15B00
	private void GetResult(IFileDialog dialog) { }
}
