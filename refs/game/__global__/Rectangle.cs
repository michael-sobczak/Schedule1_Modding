public struct Rectangle : IEquatable<Rectangle> // TypeDefIndex: 17111
{
	// Fields
	public static readonly Rectangle Empty; // 0x0
	private int x; // 0x0
	private int y; // 0x4
	private int width; // 0x8
	private int height; // 0xC

	// Properties
	[Browsable(False)]
	public Point Location { get; set; }
	[Browsable(False)]
	public Size Size { get; set; }
	public int X { get; set; }
	public int Y { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }
	[Browsable(False)]
	public int Left { get; }
	[Browsable(False)]
	public int Top { get; }
	[Browsable(False)]
	public int Right { get; }
	[Browsable(False)]
	public int Bottom { get; }
	[Browsable(False)]
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1E0BAA0 Offset: 0x1E0A4A0 VA: 0x181E0BAA0
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x214D480 Offset: 0x214BE80 VA: 0x18214D480
	public void .ctor(Point location, Size size) { }

	// RVA: 0x214CE30 Offset: 0x214B830 VA: 0x18214CE30
	public static Rectangle FromLTRB(int left, int top, int right, int bottom) { }

	// RVA: 0xA97F50 Offset: 0xA96950 VA: 0x180A97F50
	public Point get_Location() { }

	// RVA: 0x214D550 Offset: 0x214BF50 VA: 0x18214D550
	public void set_Location(Point value) { }

	// RVA: 0x214D4E0 Offset: 0x214BEE0 VA: 0x18214D4E0
	public Size get_Size() { }

	// RVA: 0x214D560 Offset: 0x214BF60 VA: 0x18214D560
	public void set_Size(Size value) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_X() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_X(int value) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_Y() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_Y(int value) { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_Width() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_Width(int value) { }

	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_Height() { }

	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_Height(int value) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Left() { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_Top() { }

	// RVA: 0x214D4D0 Offset: 0x214BED0 VA: 0x18214D4D0
	public int get_Right() { }

	// RVA: 0x214D4A0 Offset: 0x214BEA0 VA: 0x18214D4A0
	public int get_Bottom() { }

	// RVA: 0x214D4B0 Offset: 0x214BEB0 VA: 0x18214D4B0
	public bool get_IsEmpty() { }

	// RVA: 0x214CD20 Offset: 0x214B720 VA: 0x18214CD20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214CDE0 Offset: 0x214B7E0 VA: 0x18214CDE0 Slot: 4
	public bool Equals(Rectangle other) { }

	// RVA: 0x1C63A10 Offset: 0x1C62410 VA: 0x181C63A10
	public static bool op_Equality(Rectangle left, Rectangle right) { }

	// RVA: 0x214D500 Offset: 0x214BF00 VA: 0x18214D500
	public static bool op_Inequality(Rectangle left, Rectangle right) { }

	// RVA: 0x214CCB0 Offset: 0x214B6B0 VA: 0x18214CCB0
	public bool Contains(int x, int y) { }

	// RVA: 0x214CC80 Offset: 0x214B680 VA: 0x18214CC80
	public bool Contains(Point pt) { }

	// RVA: 0x214CCE0 Offset: 0x214B6E0 VA: 0x18214CCE0
	public bool Contains(Rectangle rect) { }

	// RVA: 0x214CE50 Offset: 0x214B850 VA: 0x18214CE50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214CEE0 Offset: 0x214B8E0 VA: 0x18214CEE0
	public void Inflate(int width, int height) { }

	// RVA: 0x214CF00 Offset: 0x214B900 VA: 0x18214CF00
	public static Rectangle Inflate(Rectangle rect, int x, int y) { }

	// RVA: 0x214D030 Offset: 0x214BA30 VA: 0x18214D030
	public void Intersect(Rectangle rect) { }

	// RVA: 0x214CF30 Offset: 0x214B930 VA: 0x18214CF30
	public static Rectangle Intersect(Rectangle a, Rectangle b) { }

	// RVA: 0x214D1A0 Offset: 0x214BBA0 VA: 0x18214D1A0
	public bool IntersectsWith(Rectangle rect) { }

	// RVA: 0x214D3B0 Offset: 0x214BDB0 VA: 0x18214D3B0
	public static Rectangle Union(Rectangle a, Rectangle b) { }

	// RVA: 0x214C520 Offset: 0x214AF20 VA: 0x18214C520
	public void Offset(int x, int y) { }

	// RVA: 0x214D1D0 Offset: 0x214BBD0 VA: 0x18214D1D0 Slot: 3
	public override string ToString() { }
}
