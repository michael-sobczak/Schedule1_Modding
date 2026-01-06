public class Coordinate // TypeDefIndex: 651
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14

	// Methods

	// RVA: 0xAB6FD0 Offset: 0xAB59D0 VA: 0x180AB6FD0
	public static Vector2 op_Implicit(Coordinate c) { }

	// RVA: 0xAB6EE0 Offset: 0xAB58E0 VA: 0x180AB6EE0
	public void .ctor() { }

	// RVA: 0x797650 Offset: 0x796050 VA: 0x180797650
	public void .ctor(int _x, int _y) { }

	// RVA: 0xAB6F00 Offset: 0xAB5900 VA: 0x180AB6F00
	public void .ctor(Vector2 vector) { }

	// RVA: 0xAB6A60 Offset: 0xAB5460 VA: 0x180AB6A60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAB69D0 Offset: 0xAB53D0 VA: 0x180AB69D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xAB6F30 Offset: 0xAB5930 VA: 0x180AB6F30
	public static Coordinate op_Addition(Coordinate a, Coordinate b) { }

	// RVA: 0xAB7000 Offset: 0xAB5A00 VA: 0x180AB7000
	public static Coordinate op_Subtraction(Coordinate a, Coordinate b) { }

	// RVA: 0xAB6990 Offset: 0xAB5390 VA: 0x180AB6990
	private int CantorPair(int x, int y) { }

	// RVA: 0xAB6D20 Offset: 0xAB5720 VA: 0x180AB6D20
	private int SignedCantorPair(int x, int y) { }

	// RVA: 0xAB6DC0 Offset: 0xAB57C0 VA: 0x180AB6DC0 Slot: 3
	public override string ToString() { }

	// RVA: 0xAB6680 Offset: 0xAB5080 VA: 0x180AB6680
	public static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot) { }

	// RVA: 0xAB6B70 Offset: 0xAB5570 VA: 0x180AB6B70
	public static Coordinate RotateCoordinates(Coordinate coord, float angle) { }

	// RVA: 0xAB6B10 Offset: 0xAB5510 VA: 0x180AB6B10
	private static int MathMod(int a, int b) { }
}
