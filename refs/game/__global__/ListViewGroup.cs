public sealed class ListViewGroup : ISerializable // TypeDefIndex: 5462
{
	// Fields
	internal string header; // 0x10
	private string name; // 0x18
	private HorizontalAlignment header_alignment; // 0x20
	private ListView list_view_owner; // 0x28
	private ListView.ListViewItemCollection items; // 0x30
	private object tag; // 0x38
	private Rectangle header_bounds; // 0x40
	internal int starting_row; // 0x50
	internal int starting_item; // 0x54
	internal int rows; // 0x58
	internal int current_item; // 0x5C
	internal Point items_area_location; // 0x60
	private bool is_default_group; // 0x68
	private int item_count; // 0x6C

	// Properties
	public string Header { get; }
	[DefaultValue(0)]
	public HorizontalAlignment HeaderAlignment { get; }
	[Browsable(False)]
	public ListView.ListViewItemCollection Items { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public ListView ListView { get; }
	internal ListView ListViewOwner { set; }
	internal Rectangle HeaderBounds { get; set; }
	internal bool IsDefault { set; }
	internal int ItemCount { get; set; }

	// Methods

	// RVA: 0x236D5B0 Offset: 0x236BFB0 VA: 0x18236D5B0
	public void .ctor() { }

	// RVA: 0x236D4B0 Offset: 0x236BEB0 VA: 0x18236D4B0
	public void .ctor(string header) { }

	// RVA: 0x236D4C0 Offset: 0x236BEC0 VA: 0x18236D4C0
	public void .ctor(string header, HorizontalAlignment headerAlignment) { }

	// RVA: 0x236D5F0 Offset: 0x236BFF0 VA: 0x18236D5F0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x236D130 Offset: 0x236BB30 VA: 0x18236D130 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Header() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public HorizontalAlignment get_HeaderAlignment() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ListView.ListViewItemCollection get_Items() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ListView get_ListView() { }

	// RVA: 0x236DB40 Offset: 0x236C540 VA: 0x18236DB40
	internal void set_ListViewOwner(ListView value) { }

	// RVA: 0x236D920 Offset: 0x236C320 VA: 0x18236D920
	internal Rectangle get_HeaderBounds() { }

	// RVA: 0x236D9E0 Offset: 0x236C3E0 VA: 0x18236D9E0
	internal void set_HeaderBounds(Rectangle value) { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	internal void set_IsDefault(bool value) { }

	// RVA: 0x236D970 Offset: 0x236C370 VA: 0x18236D970
	internal int get_ItemCount() { }

	// RVA: 0x236DAD0 Offset: 0x236C4D0 VA: 0x18236DAD0
	internal void set_ItemCount(int value) { }

	// RVA: 0x236D050 Offset: 0x236BA50 VA: 0x18236D050
	internal int GetActualItemCount() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 3
	public override string ToString() { }
}
