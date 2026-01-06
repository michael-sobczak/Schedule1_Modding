public class ListViewItem : ISerializable, ICloneable // TypeDefIndex: 5469
{
	// Fields
	private int image_index; // 0x10
	private bool is_checked; // 0x14
	private int state_image_index; // 0x18
	private ListViewItem.ListViewSubItemCollection sub_items; // 0x20
	private object tag; // 0x28
	private bool use_item_style; // 0x30
	private int display_index; // 0x34
	private ListViewGroup group; // 0x38
	private string name; // 0x40
	private string image_key; // 0x48
	private string tooltip_text; // 0x50
	private int indent_count; // 0x58
	private Point position; // 0x5C
	private Rectangle bounds; // 0x64
	private Rectangle checkbox_rect; // 0x74
	private Rectangle icon_rect; // 0x84
	private Rectangle item_rect; // 0x94
	private Rectangle label_rect; // 0xA4
	private ListView owner; // 0xB8
	private Font font; // 0xC0
	private Font hot_font; // 0xC8
	private bool selected; // 0xD0
	private Rectangle text_bounds; // 0xD4
	private EventHandler UIATextChanged; // 0xE8
	private LabelEditEventHandler UIASubItemTextChanged; // 0xF0
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$map4; // 0x0

	// Properties
	[DesignerSerializationVisibility(0)]
	public Color BackColor { get; set; }
	[Browsable(False)]
	public Rectangle Bounds { get; }
	[DefaultValue(False)]
	[RefreshProperties(2)]
	public bool Checked { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool Focused { get; set; }
	[Localizable(True)]
	[DesignerSerializationVisibility(0)]
	public Font Font { get; }
	[DesignerSerializationVisibility(0)]
	public Color ForeColor { get; set; }
	[Localizable(True)]
	[RefreshProperties(2)]
	[TypeConverter(typeof(NoneExcludedImageIndexConverter))]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[DesignerSerializationVisibility(0)]
	public int ImageIndex { get; set; }
	[TypeConverter(typeof(ImageKeyConverter))]
	[RefreshProperties(2)]
	[DesignerSerializationVisibility(0)]
	[DefaultValue("")]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(True)]
	public string ImageKey { get; }
	[DefaultValue(0)]
	public int IndentCount { get; }
	[Browsable(False)]
	public int Index { get; }
	[Browsable(False)]
	public ListView ListView { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool Selected { get; set; }
	[Editor("System.Windows.Forms.Design.ListViewSubItemCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DesignerSerializationVisibility(0)]
	public ListViewItem.ListViewSubItemCollection SubItems { get; }
	[DesignerSerializationVisibility(0)]
	[Localizable(True)]
	public string Text { get; set; }
	[DefaultValue(True)]
	public bool UseItemStyleForSubItems { get; }
	[Localizable(True)]
	[DefaultValue(null)]
	public ListViewGroup Group { get; }
	[DefaultValue("")]
	public string ToolTipText { get; }
	internal Rectangle CheckRectReal { get; }
	internal Rectangle TextBounds { get; }
	internal int DisplayIndex { get; set; }
	internal bool Hot { get; }
	internal Font HotFont { get; }
	internal ListView Owner { set; }

	// Methods

	// RVA: 0x23739A0 Offset: 0x23723A0 VA: 0x1823739A0
	public void .ctor() { }

	// RVA: 0x23737E0 Offset: 0x23721E0 VA: 0x1823737E0
	public void .ctor(string text) { }

	// RVA: 0x23739F0 Offset: 0x23723F0 VA: 0x1823739F0
	public void .ctor(string text, int imageIndex) { }

	// RVA: 0x2373BB0 Offset: 0x23725B0 VA: 0x182373BB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2373720 Offset: 0x2372120 VA: 0x182373720 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2373050 Offset: 0x2371A50 VA: 0x182373050
	internal void OnUIATextChanged() { }

	// RVA: 0x2372FF0 Offset: 0x23719F0 VA: 0x182372FF0
	internal void OnUIASubItemTextChanged(LabelEditEventArgs args) { }

	// RVA: 0x2373CE0 Offset: 0x23726E0 VA: 0x182373CE0
	public Color get_BackColor() { }

	// RVA: 0x2374770 Offset: 0x2373170 VA: 0x182374770
	public void set_BackColor(Color value) { }

	// RVA: 0x2373E40 Offset: 0x2372840 VA: 0x182373E40
	public Rectangle get_Bounds() { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_Checked() { }

	// RVA: 0x2374800 Offset: 0x2373200 VA: 0x182374800
	public void set_Checked(bool value) { }

	// RVA: 0x2374030 Offset: 0x2372A30 VA: 0x182374030
	public bool get_Focused() { }

	// RVA: 0x2374960 Offset: 0x2373360 VA: 0x182374960
	public void set_Focused(bool value) { }

	// RVA: 0x23740E0 Offset: 0x2372AE0 VA: 0x1823740E0
	public Font get_Font() { }

	// RVA: 0x23741D0 Offset: 0x2372BD0 VA: 0x1823741D0
	public Color get_ForeColor() { }

	// RVA: 0x2374A60 Offset: 0x2373460 VA: 0x182374A60
	public void set_ForeColor(Color value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_ImageIndex() { }

	// RVA: 0x2374AF0 Offset: 0x23734F0 VA: 0x182374AF0
	public void set_ImageIndex(int value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_ImageKey() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get_IndentCount() { }

	// RVA: 0x2374470 Offset: 0x2372E70 VA: 0x182374470
	public int get_Index() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public ListView get_ListView() { }

	// RVA: 0x23744E0 Offset: 0x2372EE0 VA: 0x1823744E0
	public bool get_Selected() { }

	// RVA: 0x2374BE0 Offset: 0x23735E0 VA: 0x182374BE0
	public void set_Selected(bool value) { }

	// RVA: 0x2374550 Offset: 0x2372F50 VA: 0x182374550
	public ListViewItem.ListViewSubItemCollection get_SubItems() { }

	// RVA: 0x23746E0 Offset: 0x23730E0 VA: 0x1823746E0
	public string get_Text() { }

	// RVA: 0x2375000 Offset: 0x2373A00 VA: 0x182375000
	public void set_Text(string value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_UseItemStyleForSubItems() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public ListViewGroup get_Group() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_ToolTipText() { }

	// RVA: 0x2370C40 Offset: 0x236F640 VA: 0x182370C40 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x2371C50 Offset: 0x2370650 VA: 0x182371C50 Slot: 7
	public virtual void EnsureVisible() { }

	// RVA: 0x2371CB0 Offset: 0x23706B0 VA: 0x182371CB0
	public Rectangle GetBounds(ItemBoundsPortion portion) { }

	// RVA: 0x2373750 Offset: 0x2372150 VA: 0x182373750 Slot: 3
	public override string ToString() { }

	// RVA: 0x2371120 Offset: 0x236FB20 VA: 0x182371120 Slot: 8
	protected virtual void Deserialize(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x23730E0 Offset: 0x2371AE0 VA: 0x1823730E0 Slot: 9
	protected virtual void Serialize(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2373F60 Offset: 0x2372960 VA: 0x182373F60
	internal Rectangle get_CheckRectReal() { }

	// RVA: 0x23745D0 Offset: 0x2372FD0 VA: 0x1823745D0
	internal Rectangle get_TextBounds() { }

	// RVA: 0x2373FE0 Offset: 0x23729E0 VA: 0x182373FE0
	internal int get_DisplayIndex() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	internal void set_DisplayIndex(int value) { }

	// RVA: 0x23743F0 Offset: 0x2372DF0 VA: 0x1823743F0
	internal bool get_Hot() { }

	// RVA: 0x2374330 Offset: 0x2372D30 VA: 0x182374330
	internal Font get_HotFont() { }

	// RVA: 0x2374BC0 Offset: 0x23735C0 VA: 0x182374BC0
	internal void set_Owner(ListView value) { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void SetGroup(ListViewGroup group) { }

	// RVA: 0x1A7B080 Offset: 0x1A79A80 VA: 0x181A7B080
	internal void SetPosition(Point position) { }

	// RVA: 0x23737A0 Offset: 0x23721A0 VA: 0x1823737A0
	private void UpdateFocusedState() { }

	// RVA: 0x2371E60 Offset: 0x2370860 VA: 0x182371E60
	internal void Invalidate() { }

	// RVA: 0x2371F00 Offset: 0x2370900 VA: 0x182371F00
	internal void Layout() { }
}
