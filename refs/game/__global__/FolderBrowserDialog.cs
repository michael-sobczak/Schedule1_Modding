public sealed class FolderBrowserDialog : CommonDialog // TypeDefIndex: 5371
{
	// Fields
	private Environment.SpecialFolder rootFolder; // 0x30
	private string selectedPath; // 0x38
	private bool showNewFolderButton; // 0x40
	private Label descriptionLabel; // 0x48
	private Button cancelButton; // 0x50
	private Button okButton; // 0x58
	private FolderBrowserDialog.FolderBrowserTreeView folderBrowserTreeView; // 0x60
	private Button newFolderButton; // 0x68
	private ContextMenu folderBrowserTreeViewContextMenu; // 0x70
	private MenuItem newFolderMenuItem; // 0x78
	private string old_selectedPath; // 0x80
	private readonly string folderbrowserdialog_string; // 0x88
	private readonly string width_string; // 0x90
	private readonly string height_string; // 0x98
	private readonly string x_string; // 0xA0
	private readonly string y_string; // 0xA8

	// Properties
	[Browsable(True)]
	[DefaultValue("")]
	[Localizable(True)]
	public string Description { get; set; }
	[Localizable(False)]
	[TypeConverter(typeof(SpecialFolderEnumConverter))]
	[Browsable(True)]
	[DefaultValue(0)]
	public Environment.SpecialFolder RootFolder { get; set; }
	[Browsable(True)]
	[Editor("System.Windows.Forms.Design.SelectedPathEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(True)]
	[DefaultValue("")]
	public string SelectedPath { get; set; }
	[Localizable(False)]
	[DefaultValue(True)]
	[Browsable(True)]
	public bool ShowNewFolderButton { get; set; }

	// Methods

	// RVA: 0x23267A0 Offset: 0x23251A0 VA: 0x1823267A0
	public void .ctor() { }

	// RVA: 0x2327940 Offset: 0x2326340 VA: 0x182327940
	public void set_Description(string value) { }

	// RVA: 0x2327910 Offset: 0x2326310 VA: 0x182327910
	public string get_Description() { }

	// RVA: 0x2327970 Offset: 0x2326370 VA: 0x182327970
	public void set_RootFolder(Environment.SpecialFolder value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public Environment.SpecialFolder get_RootFolder() { }

	// RVA: 0x2327AA0 Offset: 0x23264A0 VA: 0x182327AA0
	public void set_SelectedPath(string value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_SelectedPath() { }

	// RVA: 0x2327B20 Offset: 0x2326520 VA: 0x182327B20
	public void set_ShowNewFolderButton(bool value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_ShowNewFolderButton() { }

	// RVA: 0x2326510 Offset: 0x2324F10 VA: 0x182326510 Slot: 14
	public override void Reset() { }

	// RVA: 0x23265C0 Offset: 0x2324FC0 VA: 0x1823265C0 Slot: 16
	protected override bool RunDialog(IntPtr hWndOwner) { }

	// RVA: 0x2326470 Offset: 0x2324E70 VA: 0x182326470
	private void OnClickOKButton(object sender, EventArgs e) { }

	// RVA: 0x23263F0 Offset: 0x2324DF0 VA: 0x1823263F0
	private void OnClickCancelButton(object sender, EventArgs e) { }

	// RVA: 0x2326450 Offset: 0x2324E50 VA: 0x182326450
	private void OnClickNewFolderButton(object sender, EventArgs e) { }

	// RVA: 0x23264B0 Offset: 0x2324EB0 VA: 0x1823264B0
	private void OnFormVisibleChanged(object sender, EventArgs e) { }

	// RVA: 0x2326620 Offset: 0x2325020 VA: 0x182326620
	private void WriteConfigValues() { }
}
