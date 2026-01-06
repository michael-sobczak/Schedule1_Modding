public sealed class ListViewInsertionMark // TypeDefIndex: 5465
{
	// Fields
	private ListView listview_owner; // 0x10
	private Rectangle bounds; // 0x18
	private Nullable<Color> color; // 0x28
	private int index; // 0x48

	// Properties
	public Rectangle Bounds { get; }
	public Color Color { get; }
	public int Index { get; }
	internal PointF[] TopTriangle { get; }
	internal PointF[] BottomTriangle { get; }
	internal Rectangle Line { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(ListView listview) { }

	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Rectangle get_Bounds() { }

	// RVA: 0x236DD20 Offset: 0x236C720 VA: 0x18236DD20
	public Color get_Color() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Index() { }

	// RVA: 0x236DE30 Offset: 0x236C830 VA: 0x18236DE30
	internal PointF[] get_TopTriangle() { }

	// RVA: 0x236DB90 Offset: 0x236C590 VA: 0x18236DB90
	internal PointF[] get_BottomTriangle() { }

	// RVA: 0x236DDE0 Offset: 0x236C7E0 VA: 0x18236DDE0
	internal Rectangle get_Line() { }
}
