public struct Point : IEquatable<Point> // TypeDefIndex: 17109
{
	// Fields
	public static readonly Point Empty; // 0x0
	private int x; // 0x0
	private int y; // 0x4

	// Properties
	public int X { get; set; }
	public int Y { get; set; }

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(int x, int y) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_X() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_X(int value) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_Y() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_Y(int value) { }

	// RVA: 0x214C690 Offset: 0x214B090 VA: 0x18214C690
	public static PointF op_Implicit(Point p) { }

	// RVA: 0x214C670 Offset: 0x214B070 VA: 0x18214C670
	public static Point op_Addition(Point pt, Size sz) { }

	// RVA: 0x50DD70 Offset: 0x50C770 VA: 0x18050DD70
	public static bool op_Equality(Point left, Point right) { }

	// RVA: 0x50DD90 Offset: 0x50C790 VA: 0x18050DD90
	public static bool op_Inequality(Point left, Point right) { }

	// RVA: 0xB1B7F0 Offset: 0xB1A1F0 VA: 0x180B1B7F0
	public static Point Add(Point pt, Size sz) { }

	// RVA: 0x214C430 Offset: 0x214AE30 VA: 0x18214C430 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214C410 Offset: 0x214AE10 VA: 0x18214C410 Slot: 4
	public bool Equals(Point other) { }

	// RVA: 0x214C4C0 Offset: 0x214AEC0 VA: 0x18214C4C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214C520 Offset: 0x214AF20 VA: 0x18214C520
	public void Offset(int dx, int dy) { }

	// RVA: 0x214C530 Offset: 0x214AF30 VA: 0x18214C530 Slot: 3
	public override string ToString() { }
}
