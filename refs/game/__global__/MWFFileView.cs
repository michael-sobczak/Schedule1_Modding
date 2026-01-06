internal class MWFFileView : ListView // TypeDefIndex: 5337
{
	// Fields
	private ArrayList filterArrayList; // 0x330
	private bool showHiddenFiles; // 0x338
	private string selectedFilesString; // 0x340
	private int filterIndex; // 0x348
	private ToolTip toolTip; // 0x350
	private int oldItemIndexForToolTip; // 0x358
	private ContextMenu contextMenu; // 0x360
	private MenuItem menuItemView; // 0x368
	private MenuItem menuItemNew; // 0x370
	private MenuItem smallIconMenutItem; // 0x378
	private MenuItem tilesMenutItem; // 0x380
	private MenuItem largeIconMenutItem; // 0x388
	private MenuItem listMenutItem; // 0x390
	private MenuItem detailsMenutItem; // 0x398
	private MenuItem newFolderMenuItem; // 0x3A0
	private MenuItem showHiddenFilesMenuItem; // 0x3A8
	private int previousCheckedMenuItemIndex; // 0x3B0
	private ArrayList viewMenuItemClones; // 0x3B8
	private FSEntry currentFSEntry; // 0x3C0
	private string currentFolder; // 0x3C8
	private string currentRealFolder; // 0x3D0
	private FSEntry currentFolderFSEntry; // 0x3D8
	private Stack directoryStack; // 0x3E0
	private ArrayList dirStackControlsOrComponents; // 0x3E8
	private ToolBarButton folderUpToolBarButton; // 0x3F0
	private ArrayList registered_senders; // 0x3F8
	private bool should_push; // 0x400
	private MWFVFS vfs; // 0x408
	private View old_view; // 0x410
	private int old_menuitem_index; // 0x414
	private bool do_update_view; // 0x418
	private ColumnHeader[] columns; // 0x420
	private static object MSelectedFileChangedEvent; // 0x0
	private static object MSelectedFilesChangedEvent; // 0x8
	private static object MDirectoryChangedEvent; // 0x10
	private static object MForceDialogEndEvent; // 0x18

	// Properties
	public string CurrentFolder { get; set; }
	public string CurrentRealFolder { get; }
	public FSEntry CurrentFSEntry { get; }
	public MenuItem[] ViewMenuItems { get; }
	public ArrayList FilterArrayList { get; set; }
	public bool ShowHiddenFiles { get; }
	public int FilterIndex { set; }
	public string SelectedFilesString { get; }

	// Methods

	// RVA: 0x2338EE0 Offset: 0x23378E0 VA: 0x182338EE0
	public void .ctor(MWFVFS vfs) { }

	// RVA: 0x2338D90 Offset: 0x2337790 VA: 0x182338D90
	private static void .cctor() { }

	// RVA: 0x2339D60 Offset: 0x2338760 VA: 0x182339D60
	public void add_SelectedFileChanged(EventHandler value) { }

	// RVA: 0x233A1D0 Offset: 0x2338BD0 VA: 0x18233A1D0
	public void remove_SelectedFileChanged(EventHandler value) { }

	// RVA: 0x2339DF0 Offset: 0x23387F0 VA: 0x182339DF0
	public void add_SelectedFilesChanged(EventHandler value) { }

	// RVA: 0x233A260 Offset: 0x2338C60 VA: 0x18233A260
	public void remove_SelectedFilesChanged(EventHandler value) { }

	// RVA: 0x2339CD0 Offset: 0x23386D0 VA: 0x182339CD0
	public void add_ForceDialogEnd(EventHandler value) { }

	// RVA: 0x233A140 Offset: 0x2338B40 VA: 0x18233A140
	public void remove_ForceDialogEnd(EventHandler value) { }

	// RVA: 0x2335CF0 Offset: 0x23346F0 VA: 0x182335CF0
	private ColumnHeader CreateColumnHeader(string text, int width, HorizontalAlignment alignment) { }

	// RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	public string get_CurrentFolder() { }

	// RVA: 0x681E50 Offset: 0x680850 VA: 0x180681E50
	public void set_CurrentFolder(string value) { }

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240
	public string get_CurrentRealFolder() { }

	// RVA: 0x681E40 Offset: 0x680840 VA: 0x180681E40
	public FSEntry get_CurrentFSEntry() { }

	// RVA: 0x2339E90 Offset: 0x2338890 VA: 0x182339E90
	public MenuItem[] get_ViewMenuItems() { }

	// RVA: 0xA0AE90 Offset: 0xA09890 VA: 0x180A0AE90
	public void set_FilterArrayList(ArrayList value) { }

	// RVA: 0xA0AD80 Offset: 0xA09780 VA: 0x180A0AD80
	public ArrayList get_FilterArrayList() { }

	// RVA: 0x2339E80 Offset: 0x2338880 VA: 0x182339E80
	public bool get_ShowHiddenFiles() { }

	// RVA: 0x233A2F0 Offset: 0x2338CF0 VA: 0x18233A2F0
	public void set_FilterIndex(int value) { }

	// RVA: 0xA02690 Offset: 0xA01090 VA: 0x180A02690
	public string get_SelectedFilesString() { }

	// RVA: 0x2337E60 Offset: 0x2336860 VA: 0x182337E60
	public void PushDir() { }

	// RVA: 0x2337D90 Offset: 0x2336790 VA: 0x182337D90
	public void PopDir() { }

	// RVA: 0x2337CC0 Offset: 0x23366C0 VA: 0x182337CC0
	public void PopDir(string filter) { }

	// RVA: 0x2338860 Offset: 0x2337260 VA: 0x182338860
	public void RegisterSender(IUpdateFolder iud) { }

	// RVA: 0x2335D90 Offset: 0x2334790 VA: 0x182335D90
	public void CreateNewFolder() { }

	// RVA: 0x2337BB0 Offset: 0x23365B0 VA: 0x182337BB0
	public void OneDirUp() { }

	// RVA: 0x2337C30 Offset: 0x2336630 VA: 0x182337C30
	public void OneDirUp(string filter) { }

	// RVA: 0x2335550 Offset: 0x2333F50 VA: 0x182335550
	public void ChangeDirectory(object sender, string folder) { }

	// RVA: 0x2335570 Offset: 0x2333F70 VA: 0x182335570
	public void ChangeDirectory(object sender, string folder, string filter) { }

	// RVA: 0x2338A10 Offset: 0x2337410 VA: 0x182338A10
	public void UpdateFileView() { }

	// RVA: 0x23388B0 Offset: 0x23372B0 VA: 0x1823388B0
	public void UpdateFileView(string custom_filter) { }

	// RVA: 0x2337EB0 Offset: 0x23368B0 VA: 0x182337EB0
	public void RealFileViewUpdate(ArrayList directoriesArrayList, ArrayList fileArrayList) { }

	// RVA: 0x2335520 Offset: 0x2333F20 VA: 0x182335520
	public void AddControlToEnableDisableByDirStack(object control) { }

	// RVA: 0x2338890 Offset: 0x2337290 VA: 0x182338890
	public void SetFolderUpToolBarButton(ToolBarButton tb) { }

	// RVA: 0x2338D50 Offset: 0x2337750 VA: 0x182338D50
	public void WriteRecentlyUsed(string fullfilename) { }

	// RVA: 0x2336550 Offset: 0x2334F50 VA: 0x182336550
	private void EnableOrDisableDirstackObjects() { }

	// RVA: 0x2336480 Offset: 0x2334E80 VA: 0x182336480
	private void DoOneFSEntry(FSEntry fsEntry) { }

	// RVA: 0x2336880 Offset: 0x2335280 VA: 0x182336880
	private void MWF_KeyDown(object sender, KeyEventArgs e) { }

	// RVA: 0x2337030 Offset: 0x2335A30 VA: 0x182337030 Slot: 121
	protected override void OnClick(EventArgs e) { }

	// RVA: 0x2337200 Offset: 0x2335C00 VA: 0x182337200 Slot: 129
	protected override void OnDoubleClick(EventArgs e) { }

	// RVA: 0x2337710 Offset: 0x2336110 VA: 0x182337710 Slot: 205
	protected override void OnSelectedIndexChanged(EventArgs e) { }

	// RVA: 0x2337540 Offset: 0x2335F40 VA: 0x182337540 Slot: 159
	protected override void OnMouseMove(MouseEventArgs e) { }

	// RVA: 0x2336DF0 Offset: 0x23357F0 VA: 0x182336DF0
	private void OnClickContextMenu(object sender, EventArgs e) { }

	// RVA: 0x2336ED0 Offset: 0x23358D0 VA: 0x182336ED0
	private void OnClickViewMenuSubItem(object sender, EventArgs e) { }

	// RVA: 0x2336D30 Offset: 0x2335730 VA: 0x182336D30 Slot: 194
	protected override void OnBeforeLabelEdit(LabelEditEventArgs e) { }

	// RVA: 0x2336AD0 Offset: 0x23354D0 VA: 0x182336AD0 Slot: 193
	protected override void OnAfterLabelEdit(LabelEditEventArgs e) { }

	// RVA: 0x2338A20 Offset: 0x2337420 VA: 0x182338A20
	private void UpdateMenuItems(MenuItem senderMenuItem) { }

	// RVA: 0x2336EC0 Offset: 0x23358C0 VA: 0x182336EC0
	private void OnClickNewFolderMenuItem(object sender, EventArgs e) { }
}
