public abstract class Menu : Component // TypeDefIndex: 5487
{
	// Fields
	internal Menu.MenuItemCollection menu_items; // 0x28
	internal IntPtr menu_handle; // 0x30
	internal Menu parent_menu; // 0x38
	private Rectangle rect; // 0x40
	internal Control Wnd; // 0x50
	internal MenuTracker tracker; // 0x58
	private string control_name; // 0x60
	private object control_tag; // 0x68
	private static object MenuChangedEvent; // 0x0

	// Properties
	[MergableProperty(False)]
	[Browsable(False)]
	[DesignerSerializationVisibility(2)]
	public Menu.MenuItemCollection MenuItems { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public string Name { get; set; }
	[MWFCategory("Data")]
	[DefaultValue(null)]
	[TypeConverter(typeof(StringConverter))]
	[Bindable(True)]
	[Localizable(False)]
	public object Tag { get; set; }
	internal Rectangle Rect { get; }
	internal MenuItem SelectedItem { get; }
	internal int Height { get; set; }
	internal int Width { get; set; }
	internal int X { set; }
	internal int Y { set; }
	internal MenuTracker Tracker { get; }

	// Methods

	// RVA: 0x2390D30 Offset: 0x238F730 VA: 0x182390D30
	protected void .ctor(MenuItem[] items) { }

	// RVA: 0x2390CB0 Offset: 0x238F6B0 VA: 0x182390CB0
	private static void .cctor() { }

	// RVA: 0x2390E00 Offset: 0x238F800 VA: 0x182390E00
	internal void add_MenuChanged(EventHandler value) { }

	// RVA: 0x23910A0 Offset: 0x238FAA0 VA: 0x1823910A0
	internal void remove_MenuChanged(EventHandler value) { }

	// RVA: 0x2390B10 Offset: 0x238F510 VA: 0x182390B10 Slot: 14
	internal virtual void OnMenuChanged(EventArgs e) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Menu.MenuItemCollection get_MenuItems() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Name() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Name(string value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public object get_Tag() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_Tag(object value) { }

	// RVA: 0xAB8F60 Offset: 0xAB7960 VA: 0x180AB8F60
	internal Rectangle get_Rect() { }

	// RVA: 0x2390E90 Offset: 0x238F890 VA: 0x182390E90
	internal MenuItem get_SelectedItem() { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	internal int get_Height() { }

	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	internal void set_Height(int value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	internal int get_Width() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	internal void set_Width(int value) { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	internal void set_X(int value) { }

	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	internal void set_Y(int value) { }

	// RVA: 0x2391060 Offset: 0x238FA60 VA: 0x182391060
	internal MenuTracker get_Tracker() { }

	// RVA: 0x23904F0 Offset: 0x238EEF0 VA: 0x1823904F0
	protected void CloneMenu(Menu menuSrc) { }

	// RVA: 0x2390640 Offset: 0x238F040 VA: 0x182390640 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2390670 Offset: 0x238F070 VA: 0x182390670
	protected int FindMergePosition(int mergeOrder) { }

	// RVA: 0x2390730 Offset: 0x238F130 VA: 0x182390730
	public MainMenu GetMainMenu() { }

	// RVA: 0x23907D0 Offset: 0x238F1D0 VA: 0x1823907D0 Slot: 15
	internal virtual void InvalidateItem(MenuItem item) { }

	// RVA: 0x2390810 Offset: 0x238F210 VA: 0x182390810 Slot: 16
	public virtual void MergeMenu(Menu menuSrc) { }

	// RVA: 0x2390BE0 Offset: 0x238F5E0 VA: 0x182390BE0 Slot: 17
	protected internal virtual bool ProcessCmdKey(ref Message msg, Keys keyData) { }

	// RVA: 0x2390C00 Offset: 0x238F600 VA: 0x182390C00 Slot: 3
	public override string ToString() { }
}
