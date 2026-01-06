public abstract class VistaFileDialog : CommonDialog // TypeDefIndex: 17312
{
	// Fields
	internal const int HelpButtonId = 16385;
	private FileDialog _downlevelDialog; // 0x30
	private NativeMethods.FOS _options; // 0x38
	private string _filter; // 0x40
	private int _filterIndex; // 0x48
	private string[] _fileNames; // 0x50
	private string _defaultExt; // 0x58
	private bool _addExtension; // 0x60
	private string _initialDirectory; // 0x68
	private bool _showHelp; // 0x70
	private string _title; // 0x78
	private bool _supportMultiDottedExtensions; // 0x80
	private IntPtr _hwndOwner; // 0x88
	private static readonly object EventFileOk; // 0x0

	// Properties
	[Browsable(False)]
	public static bool IsVistaFileDialogSupported { get; }
	[Description("A value indicating whether the dialog box automatically adds an extension to a file name if the user omits the extension.")]
	[Category("Behavior")]
	[DefaultValue(True)]
	public bool AddExtension { get; set; }
	[Description("A value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.")]
	[DefaultValue(False)]
	[Category("Behavior")]
	public virtual bool CheckFileExists { get; set; }
	[DefaultValue(True)]
	[Category("Behavior")]
	[Description("A value indicating whether the dialog box displays a warning if the user specifies a path that does not exist.")]
	public bool CheckPathExists { get; set; }
	[DefaultValue("")]
	[Description("The default file name extension.")]
	[Category("Behavior")]
	public string DefaultExt { get; set; }
	[Description("A value indicating whether the dialog box returns the location of the file referenced by the shortcut or whether it returns the location of the shortcut (.lnk).")]
	[DefaultValue(True)]
	[Category("Behavior")]
	public bool DereferenceLinks { get; set; }
	[Description("A string containing the file name selected in the file dialog box.")]
	[Category("Data")]
	[DefaultValue("")]
	public string FileName { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[Description("The file names of all selected files in the dialog box.")]
	public string[] FileNames { get; }
	[DefaultValue("")]
	[Localizable(True)]
	[Category("Behavior")]
	[Description("The current file name filter string, which determines the choices that appear in the "Save as file type" or "Files of type" box in the dialog box.")]
	public string Filter { get; set; }
	[Category("Behavior")]
	[DefaultValue(1)]
	[Description("The index of the filter currently selected in the file dialog box.")]
	public int FilterIndex { get; set; }
	[Category("Data")]
	[Description("The initial directory displayed by the file dialog box.")]
	[DefaultValue("")]
	public string InitialDirectory { get; set; }
	[Category("Behavior")]
	[Description("A value indicating whether the dialog box restores the current directory before closing.")]
	[DefaultValue(False)]
	public bool RestoreDirectory { get; set; }
	[Category("Behavior")]
	[DefaultValue(False)]
	[Description("A value indicating whether the Help button is displayed in the file dialog box.")]
	public bool ShowHelp { get; set; }
	[Category("Appearance")]
	[Description("The file dialog box title.")]
	[Localizable(True)]
	[DefaultValue("")]
	public string Title { get; set; }
	[Description("Indicates whether the dialog box supports displaying and saving files that have multiple file name extensions.")]
	[Category("Behavior")]
	[DefaultValue(False)]
	public bool SupportMultiDottedExtensions { get; set; }
	[Category("Behavior")]
	[Description("A value indicating whether the dialog box accepts only valid Win32 file names.")]
	[DefaultValue(True)]
	public bool ValidateNames { get; set; }
	[Browsable(False)]
	protected FileDialog DownlevelDialog { get; set; }
	private string[] FileNamesInternal { get; set; }

	// Methods

	// RVA: 0x1E14EA0 Offset: 0x1E138A0 VA: 0x181E14EA0
	public void add_FileOk(CancelEventHandler value) { }

	// RVA: 0x1E15430 Offset: 0x1E13E30 VA: 0x181E15430
	public void remove_FileOk(CancelEventHandler value) { }

	// RVA: 0x1E14E40 Offset: 0x1E13840 VA: 0x181E14E40
	protected void .ctor() { }

	// RVA: 0x1E152F0 Offset: 0x1E13CF0 VA: 0x181E152F0
	public static bool get_IsVistaFileDialogSupported() { }

	// RVA: 0x1E14F30 Offset: 0x1E13930 VA: 0x181E14F30
	public bool get_AddExtension() { }

	// RVA: 0x1E154C0 Offset: 0x1E13EC0 VA: 0x181E154C0
	public void set_AddExtension(bool value) { }

	// RVA: 0x1E14F50 Offset: 0x1E13950 VA: 0x181E14F50 Slot: 17
	public virtual bool get_CheckFileExists() { }

	// RVA: 0x1E154F0 Offset: 0x1E13EF0 VA: 0x181E154F0 Slot: 18
	public virtual void set_CheckFileExists(bool value) { }

	// RVA: 0x1E14F90 Offset: 0x1E13990 VA: 0x181E14F90
	public bool get_CheckPathExists() { }

	// RVA: 0x1E15550 Offset: 0x1E13F50 VA: 0x181E15550
	public void set_CheckPathExists(bool value) { }

	// RVA: 0x1E14FB0 Offset: 0x1E139B0 VA: 0x181E14FB0
	public string get_DefaultExt() { }

	// RVA: 0x1E155A0 Offset: 0x1E13FA0 VA: 0x181E155A0
	public void set_DefaultExt(string value) { }

	// RVA: 0x1E15020 Offset: 0x1E13A20 VA: 0x181E15020
	public bool get_DereferenceLinks() { }

	// RVA: 0x1E15650 Offset: 0x1E14050 VA: 0x181E15650
	public void set_DereferenceLinks(bool value) { }

	// RVA: 0x1E15040 Offset: 0x1E13A40 VA: 0x181E15040
	public string get_FileName() { }

	// RVA: 0x1E15780 Offset: 0x1E14180 VA: 0x181E15780
	public void set_FileName(string value) { }

	// RVA: 0x1E15180 Offset: 0x1E13B80 VA: 0x181E15180
	public string[] get_FileNames() { }

	// RVA: 0x1E15260 Offset: 0x1E13C60 VA: 0x181E15260
	public string get_Filter() { }

	// RVA: 0x1E15850 Offset: 0x1E14250 VA: 0x181E15850
	public void set_Filter(string value) { }

	// RVA: 0x1E15240 Offset: 0x1E13C40 VA: 0x181E15240
	public int get_FilterIndex() { }

	// RVA: 0x1E15820 Offset: 0x1E14220 VA: 0x181E15820
	public void set_FilterIndex(int value) { }

	// RVA: 0x1E15280 Offset: 0x1E13C80 VA: 0x181E15280
	public string get_InitialDirectory() { }

	// RVA: 0x1E15990 Offset: 0x1E14390 VA: 0x181E15990
	public void set_InitialDirectory(string value) { }

	// RVA: 0x1E15340 Offset: 0x1E13D40 VA: 0x181E15340
	public bool get_RestoreDirectory() { }

	// RVA: 0x1E159D0 Offset: 0x1E143D0 VA: 0x181E159D0
	public void set_RestoreDirectory(bool value) { }

	// RVA: 0x1E15360 Offset: 0x1E13D60 VA: 0x181E15360
	public bool get_ShowHelp() { }

	// RVA: 0x1E15A10 Offset: 0x1E14410 VA: 0x181E15A10
	public void set_ShowHelp(bool value) { }

	// RVA: 0x1E153A0 Offset: 0x1E13DA0 VA: 0x181E153A0
	public string get_Title() { }

	// RVA: 0x1E15A70 Offset: 0x1E14470 VA: 0x181E15A70
	public void set_Title(string value) { }

	// RVA: 0x1E15380 Offset: 0x1E13D80 VA: 0x181E15380
	public bool get_SupportMultiDottedExtensions() { }

	// RVA: 0x1E15A40 Offset: 0x1E14440 VA: 0x181E15A40
	public void set_SupportMultiDottedExtensions(bool value) { }

	// RVA: 0x1E15410 Offset: 0x1E13E10 VA: 0x181E15410
	public bool get_ValidateNames() { }

	// RVA: 0x1E15AB0 Offset: 0x1E144B0 VA: 0x181E15AB0
	public void set_ValidateNames(bool value) { }

	// RVA: 0x1E019C0 Offset: 0x1E003C0 VA: 0x181E019C0
	protected FileDialog get_DownlevelDialog() { }

	// RVA: 0x1E156A0 Offset: 0x1E140A0 VA: 0x181E156A0
	protected void set_DownlevelDialog(FileDialog value) { }

	// RVA: 0x1E150F0 Offset: 0x1E13AF0 VA: 0x181E150F0
	private string[] get_FileNamesInternal() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	internal void set_FileNamesInternal(string[] value) { }

	// RVA: 0x1E14470 Offset: 0x1E12E70 VA: 0x181E14470 Slot: 14
	public override void Reset() { }

	// RVA: 0x1E14540 Offset: 0x1E12F40 VA: 0x181E14540 Slot: 16
	protected override bool RunDialog(IntPtr hwndOwner) { }

	// RVA: 0x1E14DA0 Offset: 0x1E137A0 VA: 0x181E14DA0
	internal void SetOption(NativeMethods.FOS option, bool value) { }

	// RVA: 0x1E14070 Offset: 0x1E12A70 VA: 0x181E14070
	internal bool GetOption(NativeMethods.FOS option) { }

	// RVA: 0x1E14080 Offset: 0x1E12A80 VA: 0x181E14080 Slot: 19
	internal virtual void GetResult(IFileDialog dialog) { }

	// RVA: 0x1E141E0 Offset: 0x1E12BE0 VA: 0x181E141E0 Slot: 20
	protected virtual void OnFileOk(CancelEventArgs e) { }

	// RVA: 0x1E13E80 Offset: 0x1E12880 VA: 0x181E13E80 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E142B0 Offset: 0x1E12CB0 VA: 0x181E142B0
	internal bool PromptUser(string text, MessageBoxButtons buttons, MessageBoxIcon icon) { }

	// RVA: 0x1E14780 Offset: 0x1E13180 VA: 0x181E14780 Slot: 21
	internal virtual void SetDialogProperties(IFileDialog dialog) { }

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract IFileDialog CreateFileDialog();

	// RVA: 0x1E13FB0 Offset: 0x1E129B0 VA: 0x181E13FB0
	internal void DoHelpRequest() { }

	// RVA: 0x1E13F10 Offset: 0x1E12910 VA: 0x181E13F10
	internal bool DoFileOk(IFileDialog dialog) { }

	// RVA: 0x1E14600 Offset: 0x1E13000 VA: 0x181E14600
	private bool RunFileDialog(IntPtr hwndOwner) { }

	// RVA: 0x1E14050 Offset: 0x1E12A50 VA: 0x181E14050
	private void DownlevelDialog_HelpRequest(object sender, EventArgs e) { }

	// RVA: 0x1E14030 Offset: 0x1E12A30 VA: 0x181E14030
	private void DownlevelDialog_FileOk(object sender, CancelEventArgs e) { }

	// RVA: 0x1E14DC0 Offset: 0x1E137C0 VA: 0x181E14DC0
	private static void .cctor() { }
}
