internal class DirComboBox : ComboBox, IUpdateFolder // TypeDefIndex: 5334
{
	// Fields
	private ImageList imageList; // 0x2D0
	private string currentPath; // 0x2D8
	private Stack folderStack; // 0x2E0
	private static readonly int indent; // 0x0
	private DirComboBox.DirComboBoxItem recentlyUsedDirComboboxItem; // 0x2E8
	private DirComboBox.DirComboBoxItem desktopDirComboboxItem; // 0x2F0
	private DirComboBox.DirComboBoxItem personalDirComboboxItem; // 0x2F8
	private DirComboBox.DirComboBoxItem myComputerDirComboboxItem; // 0x300
	private DirComboBox.DirComboBoxItem networkDirComboboxItem; // 0x308
	private ArrayList myComputerItems; // 0x310
	private DirComboBox.DirComboBoxItem mainParentDirComboBoxItem; // 0x318
	private DirComboBox.DirComboBoxItem real_parent; // 0x320
	private MWFVFS vfs; // 0x328
	private static object CDirectoryChangedEvent; // 0x8

	// Properties
	public string CurrentFolder { get; set; }

	// Methods

	// RVA: 0x23224A0 Offset: 0x2320EA0 VA: 0x1823224A0
	public void .ctor(MWFVFS vfs) { }

	// RVA: 0x2322410 Offset: 0x2320E10 VA: 0x182322410
	private static void .cctor() { }

	// RVA: 0x2323110 Offset: 0x2321B10 VA: 0x182323110
	public void add_DirectoryChanged(EventHandler value) { }

	// RVA: 0x23231A0 Offset: 0x2321BA0 VA: 0x1823231A0
	public void remove_DirectoryChanged(EventHandler value) { }

	// RVA: 0x2323230 Offset: 0x2321C30 VA: 0x182323230 Slot: 209
	public void set_CurrentFolder(string value) { }

	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0 Slot: 210
	public string get_CurrentFolder() { }

	// RVA: 0x2321180 Offset: 0x231FB80 VA: 0x182321180
	private void CreateComboList() { }

	// RVA: 0x23216E0 Offset: 0x23200E0 VA: 0x1823216E0
	private DirComboBox.DirComboBoxItem CreateFolderStack() { }

	// RVA: 0x2320F50 Offset: 0x231F950 VA: 0x182320F50
	private DirComboBox.DirComboBoxItem AppendToParent(int nr_indents, DirComboBox.DirComboBoxItem parentDirComboBoxItem) { }

	// RVA: 0x2321B20 Offset: 0x2320520 VA: 0x182321B20 Slot: 201
	protected override void OnDrawItem(DrawItemEventArgs e) { }

	// RVA: 0x2322230 Offset: 0x2320C30 VA: 0x182322230 Slot: 197
	protected override void OnSelectedIndexChanged(EventArgs e) { }

	// RVA: 0x2322310 Offset: 0x2320D10 VA: 0x182322310 Slot: 207
	protected override void OnSelectionChangeCommitted(EventArgs e) { }
}
