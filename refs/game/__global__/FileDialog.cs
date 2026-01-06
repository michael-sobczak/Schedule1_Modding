public abstract class FileDialog : CommonDialog // TypeDefIndex: 5329
{
	// Fields
	protected static readonly object EventFileOk; // 0x0
	private static int MaxFileNameItems; // 0x8
	private bool addExtension; // 0x30
	private bool checkFileExists; // 0x31
	private bool checkPathExists; // 0x32
	private string defaultExt; // 0x38
	private bool dereferenceLinks; // 0x40
	private string[] fileNames; // 0x48
	private string filter; // 0x50
	private int filterIndex; // 0x58
	private string initialDirectory; // 0x60
	private bool restoreDirectory; // 0x68
	private bool showHelp; // 0x69
	private string title; // 0x70
	private bool validateNames; // 0x78
	private bool auto_upgrade_enable; // 0x79
	private FileDialogCustomPlacesCollection custom_places; // 0x80
	private bool supportMultiDottedExtensions; // 0x88
	private bool checkForIllegalChars; // 0x89
	private Button cancelButton; // 0x90
	private ToolBarButton upToolBarButton; // 0x98
	private PopupButtonPanel popupButtonPanel; // 0xA0
	private Button openSaveButton; // 0xA8
	private Button helpButton; // 0xB0
	private Label fileTypeLabel; // 0xB8
	private ToolBarButton menueToolBarButton; // 0xC0
	private ContextMenu menueToolBarButtonContextMenu; // 0xC8
	private ToolBar smallButtonToolBar; // 0xD0
	private DirComboBox dirComboBox; // 0xD8
	private ComboBox fileNameComboBox; // 0xE0
	private Label fileNameLabel; // 0xE8
	private MWFFileView mwfFileView; // 0xF0
	private MwfFileViewItemComparer file_view_comparer; // 0xF8
	private Label searchSaveLabel; // 0x100
	private ToolBarButton newdirToolBarButton; // 0x108
	private ToolBarButton backToolBarButton; // 0x110
	private ComboBox fileTypeComboBox; // 0x118
	private ImageList imageListTopToolbar; // 0x120
	private CheckBox readonlyCheckBox; // 0x128
	private bool multiSelect; // 0x130
	private string restoreDirectoryString; // 0x138
	internal FileDialog.FileDialogType fileDialogType; // 0x140
	private bool do_not_call_OnSelectedIndexChangedFileTypeComboBox; // 0x144
	private bool showReadOnly; // 0x145
	private bool readOnlyChecked; // 0x146
	internal bool createPrompt; // 0x147
	internal bool overwritePrompt; // 0x148
	private FileFilter fileFilter; // 0x150
	private string[] configFileNames; // 0x158
	private string lastFolder; // 0x160
	private MWFVFS vfs; // 0x168
	private readonly char[] wildcard_chars; // 0x170
	private bool disable_form_closed_event; // 0x178

	// Properties
	[DefaultValue(True)]
	public bool AddExtension { get; set; }
	[DefaultValue(False)]
	public virtual bool CheckFileExists { get; set; }
	[DefaultValue(True)]
	public bool CheckPathExists { get; set; }
	[DefaultValue("")]
	public string DefaultExt { get; set; }
	[DefaultValue(True)]
	public bool DereferenceLinks { get; set; }
	[DefaultValue("")]
	public string FileName { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public string[] FileNames { get; }
	[Localizable(True)]
	[DefaultValue("")]
	public string Filter { get; set; }
	[DefaultValue(1)]
	public int FilterIndex { get; set; }
	[DefaultValue("")]
	public string InitialDirectory { get; set; }
	[DefaultValue(False)]
	public bool RestoreDirectory { get; set; }
	[DefaultValue(False)]
	public bool ShowHelp { get; set; }
	[DefaultValue(False)]
	public bool SupportMultiDottedExtensions { get; set; }
	[DefaultValue("")]
	[Localizable(True)]
	public string Title { get; set; }
	[DefaultValue(True)]
	public bool ValidateNames { get; set; }
	internal virtual string DialogTitle { get; }
	internal virtual bool ShowReadOnly { get; set; }
	internal virtual bool ReadOnlyChecked { get; set; }
	internal bool BMultiSelect { get; set; }
	internal string OpenSaveButtonText { set; }
	internal string SearchSaveLabel { set; }
	internal string FileTypeLabel { set; }
	internal string CustomFilter { get; }

	// Methods

	// RVA: 0x2319CD0 Offset: 0x23186D0 VA: 0x182319CD0
	internal void .ctor() { }

	// RVA: 0x2319C40 Offset: 0x2318640 VA: 0x182319C40
	private static void .cctor() { }

	// RVA: 0x231C240 Offset: 0x231AC40 VA: 0x18231C240
	public void add_FileOk(CancelEventHandler value) { }

	// RVA: 0x231C6B0 Offset: 0x231B0B0 VA: 0x18231C6B0
	public void remove_FileOk(CancelEventHandler value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_AddExtension() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_AddExtension(bool value) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0 Slot: 17
	public virtual bool get_CheckFileExists() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0 Slot: 18
	public virtual void set_CheckFileExists(bool value) { }

	// RVA: 0x231C2D0 Offset: 0x231ACD0 VA: 0x18231C2D0
	public bool get_CheckPathExists() { }

	// RVA: 0x231C770 Offset: 0x231B170 VA: 0x18231C770
	public void set_CheckPathExists(bool value) { }

	// RVA: 0x231C350 Offset: 0x231AD50 VA: 0x18231C350
	public string get_DefaultExt() { }

	// RVA: 0x231C780 Offset: 0x231B180 VA: 0x18231C780
	public void set_DefaultExt(string value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_DereferenceLinks() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_DereferenceLinks(bool value) { }

	// RVA: 0x231C3F0 Offset: 0x231ADF0 VA: 0x18231C3F0
	public string get_FileName() { }

	// RVA: 0x231C7E0 Offset: 0x231B1E0 VA: 0x18231C7E0
	public void set_FileName(string value) { }

	// RVA: 0x231C4D0 Offset: 0x231AED0 VA: 0x18231C4D0
	public string[] get_FileNames() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Filter() { }

	// RVA: 0x231C8C0 Offset: 0x231B2C0 VA: 0x18231C8C0
	public void set_Filter(string value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get_FilterIndex() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_FilterIndex(int value) { }

	// RVA: 0x231C5F0 Offset: 0x231AFF0 VA: 0x18231C5F0
	public string get_InitialDirectory() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_InitialDirectory(string value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_RestoreDirectory() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_RestoreDirectory(bool value) { }

	// RVA: 0xCE3D90 Offset: 0xCE2790 VA: 0x180CE3D90
	public bool get_ShowHelp() { }

	// RVA: 0x231CAA0 Offset: 0x231B4A0 VA: 0x18231CAA0
	public void set_ShowHelp(bool value) { }

	// RVA: 0xDA2600 Offset: 0xDA1000 VA: 0x180DA2600
	public bool get_SupportMultiDottedExtensions() { }

	// RVA: 0xDA2C80 Offset: 0xDA1680 VA: 0x180DA2C80
	public void set_SupportMultiDottedExtensions(bool value) { }

	// RVA: 0x231C660 Offset: 0x231B060 VA: 0x18231C660
	public string get_Title() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_Title(string value) { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_ValidateNames() { }

	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	public void set_ValidateNames(bool value) { }

	// RVA: 0x2318910 Offset: 0x2317310 VA: 0x182318910 Slot: 14
	public override void Reset() { }

	// RVA: 0x23193D0 Offset: 0x2317DD0 VA: 0x1823193D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x231C3A0 Offset: 0x231ADA0 VA: 0x18231C3A0 Slot: 19
	internal virtual string get_DialogTitle() { }

	// RVA: 0x23183F0 Offset: 0x2316DF0 VA: 0x1823183F0
	protected void OnFileOk(CancelEventArgs e) { }

	// RVA: 0x2316B30 Offset: 0x2315530 VA: 0x182316B30
	private void CleanupOnClose() { }

	// RVA: 0x2318EC0 Offset: 0x23178C0 VA: 0x182318EC0 Slot: 16
	protected override bool RunDialog(IntPtr hWndOwner) { }

	// RVA: 0x231CAB0 Offset: 0x231B4B0 VA: 0x18231CAB0 Slot: 20
	internal virtual void set_ShowReadOnly(bool value) { }

	// RVA: 0x231C650 Offset: 0x231B050 VA: 0x18231C650 Slot: 21
	internal virtual bool get_ShowReadOnly() { }

	// RVA: 0x231CA40 Offset: 0x231B440 VA: 0x18231CA40 Slot: 22
	internal virtual void set_ReadOnlyChecked(bool value) { }

	// RVA: 0x231C640 Offset: 0x231B040 VA: 0x18231C640 Slot: 23
	internal virtual bool get_ReadOnlyChecked() { }

	// RVA: 0x231C740 Offset: 0x231B140 VA: 0x18231C740
	internal void set_BMultiSelect(bool value) { }

	// RVA: 0xABD6C0 Offset: 0xABC0C0 VA: 0x180ABD6C0
	internal bool get_BMultiSelect() { }

	// RVA: 0x231CA10 Offset: 0x231B410 VA: 0x18231CA10
	internal void set_OpenSaveButtonText(string value) { }

	// RVA: 0x231CA70 Offset: 0x231B470 VA: 0x18231CA70
	internal void set_SearchSaveLabel(string value) { }

	// RVA: 0x231C890 Offset: 0x231B290 VA: 0x18231C890
	internal void set_FileTypeLabel(string value) { }

	// RVA: 0x231C2E0 Offset: 0x231ACE0 VA: 0x18231C2E0
	internal string get_CustomFilter() { }

	// RVA: 0x23190C0 Offset: 0x2317AC0 VA: 0x1823190C0
	private void SelectFilter() { }

	// RVA: 0x23191D0 Offset: 0x2317BD0 VA: 0x1823191D0
	private void SetFileAndDirectory(string fname) { }

	// RVA: 0x2317010 Offset: 0x2315A10 VA: 0x182317010
	private void OnClickOpenSaveButton(object sender, EventArgs e) { }

	// RVA: 0x2316A40 Offset: 0x2315440 VA: 0x182316A40
	private bool AddFilterExtension(string fileName) { }

	// RVA: 0x2316B90 Offset: 0x2315590 VA: 0x182316B90
	private string GetExtension(string fileName) { }

	// RVA: 0x2316F70 Offset: 0x2315970 VA: 0x182316F70
	private void OnClickCancelButton(object sender, EventArgs e) { }

	// RVA: 0x1E14050 Offset: 0x1E12A50 VA: 0x181E14050
	private void OnClickHelpButton(object sender, EventArgs e) { }

	// RVA: 0x2318060 Offset: 0x2316A60 VA: 0x182318060
	private void OnClickSmallButtonToolBar(object sender, ToolBarButtonClickEventArgs e) { }

	// RVA: 0x23185E0 Offset: 0x2316FE0 VA: 0x1823185E0
	private void OnSelectedIndexChangedFileTypeComboBox(object sender, EventArgs e) { }

	// RVA: 0x2318530 Offset: 0x2316F30 VA: 0x182318530
	private void OnSelectedFileChangedFileView(object sender, EventArgs e) { }

	// RVA: 0x2318580 Offset: 0x2316F80 VA: 0x182318580
	private void OnSelectedFilesChangedFileView(object sender, EventArgs e) { }

	// RVA: 0x23184C0 Offset: 0x2316EC0 VA: 0x1823184C0
	private void OnForceDialogEndFileView(object sender, EventArgs e) { }

	// RVA: 0x2318270 Offset: 0x2316C70 VA: 0x182318270
	private void OnDirectoryChangedDirComboBox(object sender, EventArgs e) { }

	// RVA: 0x2318330 Offset: 0x2316D30 VA: 0x182318330
	private void OnDirectoryChangedPopupButtonPanel(object sender, EventArgs e) { }

	// RVA: 0x2316F20 Offset: 0x2315920 VA: 0x182316F20
	private void OnCheckCheckChanged(object sender, EventArgs e) { }

	// RVA: 0x2316E30 Offset: 0x2315830 VA: 0x182316E30
	private void OnFileDialogFormClosed(object sender, FormClosedEventArgs e) { }

	// RVA: 0x2318170 Offset: 0x2316B70 VA: 0x182318170
	private void OnColumnClickFileView(object sender, ColumnClickEventArgs e) { }

	// RVA: 0x2316E30 Offset: 0x2315830 VA: 0x182316E30
	private void HandleFormClosedEvent(object sender) { }

	// RVA: 0x2319540 Offset: 0x2317F40 VA: 0x182319540
	private void UpdateFilters() { }

	// RVA: 0x2319870 Offset: 0x2318270 VA: 0x182319870
	private void UpdateRecentFiles() { }

	// RVA: 0x2318B50 Offset: 0x2317550 VA: 0x182318B50
	private void ResizeAndRelocateForHelpOrReadOnly() { }

	// RVA: 0x23199E0 Offset: 0x23183E0 VA: 0x1823199E0
	private void WriteConfigValues() { }

	// RVA: 0x2318660 Offset: 0x2317060 VA: 0x182318660
	private void ReadConfigValues() { }
}
