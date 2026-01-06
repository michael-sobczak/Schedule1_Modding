public class ColumnHeader : Component, ICloneable // TypeDefIndex: 5266
{
	// Fields
	private StringFormat format; // 0x28
	private string text; // 0x30
	private HorizontalAlignment text_alignment; // 0x38
	private int width; // 0x3C
	private int image_index; // 0x40
	private string image_key; // 0x48
	private string name; // 0x50
	private int display_index; // 0x58
	private Rectangle column_rect; // 0x5C
	private bool pressed; // 0x6C
	private ListView owner; // 0x70
	private static object UIATextChangedEvent; // 0x0

	// Properties
	internal bool Pressed { get; set; }
	internal int X { get; set; }
	internal int Y { set; }
	internal int Wd { get; }
	internal int Ht { get; }
	internal Rectangle Rect { get; set; }
	internal StringFormat Format { get; }
	internal int InternalDisplayIndex { get; set; }
	[RefreshProperties(2)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(-1)]
	[DesignerSerializationVisibility(0)]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int ImageIndex { get; set; }
	[RefreshProperties(2)]
	[DefaultValue("")]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[TypeConverter(typeof(ImageKeyConverter))]
	[DesignerSerializationVisibility(0)]
	public string ImageKey { get; set; }
	[Browsable(False)]
	public int Index { get; }
	[Localizable(True)]
	public string Text { get; set; }
	[Localizable(True)]
	[DefaultValue(0)]
	public HorizontalAlignment TextAlign { get; set; }
	[Localizable(True)]
	[DefaultValue(60)]
	public int Width { get; set; }

	// Methods

	// RVA: 0x21CBA10 Offset: 0x21CA410 VA: 0x1821CBA10
	public void .ctor() { }

	// RVA: 0x21CB570 Offset: 0x21C9F70 VA: 0x1821CB570
	public void .ctor(int imageIndex) { }

	// RVA: 0x21CB7E0 Offset: 0x21CA1E0 VA: 0x1821CB7E0
	public void .ctor(string imageKey) { }

	// RVA: 0x21CB4F0 Offset: 0x21C9EF0 VA: 0x1821CB4F0
	private static void .cctor() { }

	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490
	internal bool get_Pressed() { }

	// RVA: 0x614530 Offset: 0x612F30 VA: 0x180614530
	internal void set_Pressed(bool value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	internal int get_X() { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	internal void set_X(int value) { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	internal void set_Y(int value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	internal int get_Wd() { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	internal int get_Ht() { }

	// RVA: 0x8D2040 Offset: 0x8D0A40 VA: 0x1808D2040
	internal Rectangle get_Rect() { }

	// RVA: 0x21CBD90 Offset: 0x21CA790 VA: 0x1821CBD90
	internal void set_Rect(Rectangle value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal StringFormat get_Format() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	internal int get_InternalDisplayIndex() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	internal void set_InternalDisplayIndex(int value) { }

	// RVA: 0x21CAE40 Offset: 0x21C9840 VA: 0x1821CAE40
	internal void CalcColumnHeader() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void SetListView(ListView list_view) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_ImageIndex() { }

	// RVA: 0x21CBC30 Offset: 0x21CA630 VA: 0x1821CBC30
	public void set_ImageIndex(int value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_ImageKey() { }

	// RVA: 0x21CBD00 Offset: 0x21CA700 VA: 0x1821CBD00
	public void set_ImageKey(string value) { }

	// RVA: 0x21CBBC0 Offset: 0x21CA5C0 VA: 0x1821CBBC0
	public int get_Index() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Text() { }

	// RVA: 0x21CBDC0 Offset: 0x21CA7C0 VA: 0x1821CBDC0
	public void set_Text(string value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public HorizontalAlignment get_TextAlign() { }

	// RVA: 0x21CBDA0 Offset: 0x21CA7A0 VA: 0x1821CBDA0
	public void set_TextAlign(HorizontalAlignment value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public int get_Width() { }

	// RVA: 0x21CBF00 Offset: 0x21CA900 VA: 0x1821CBF00
	public void set_Width(int value) { }

	// RVA: 0x21CB0F0 Offset: 0x21C9AF0 VA: 0x1821CB0F0 Slot: 14
	public object Clone() { }

	// RVA: 0x21CB4B0 Offset: 0x21C9EB0 VA: 0x1821CB4B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21CB3A0 Offset: 0x21C9DA0 VA: 0x1821CB3A0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21CB3B0 Offset: 0x21C9DB0 VA: 0x1821CB3B0
	private void OnUIATextChanged() { }
}
