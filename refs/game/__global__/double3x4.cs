public struct double3x4 : IEquatable<double3x4>, IFormattable // TypeDefIndex: 10893
{
	// Fields
	public double3 c0; // 0x0
	public double3 c1; // 0x18
	public double3 c2; // 0x30
	public double3 c3; // 0x48
	public static readonly double3x4 zero; // 0x0

	// Properties
	public double3 Item { get; }

	// Methods

	// RVA: 0x2912DB0 Offset: 0x29117B0 VA: 0x182912DB0
	public void .ctor(double3 c0, double3 c1, double3 c2, double3 c3) { }

	// RVA: 0x2912E00 Offset: 0x2911800 VA: 0x182912E00
	public void .ctor(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) { }

	// RVA: 0x2912F00 Offset: 0x2911900 VA: 0x182912F00
	public void .ctor(double v) { }

	// RVA: 0x2912F50 Offset: 0x2911950 VA: 0x182912F50
	public void .ctor(bool v) { }

	// RVA: 0x2881370 Offset: 0x287FD70 VA: 0x182881370
	public void .ctor(bool3x4 v) { }

	// RVA: 0x2912E80 Offset: 0x2911880 VA: 0x182912E80
	public void .ctor(int v) { }

	// RVA: 0x2881680 Offset: 0x2880080 VA: 0x182881680
	public void .ctor(int3x4 v) { }

	// RVA: 0x2881490 Offset: 0x287FE90 VA: 0x182881490
	public void .ctor(uint v) { }

	// RVA: 0x2881550 Offset: 0x287FF50 VA: 0x182881550
	public void .ctor(uint3x4 v) { }

	// RVA: 0x29130C0 Offset: 0x2911AC0 VA: 0x1829130C0
	public void .ctor(float v) { }

	// RVA: 0x2912FF0 Offset: 0x29119F0 VA: 0x182912FF0
	public void .ctor(float3x4 v) { }

	// RVA: 0x2893640 Offset: 0x2892040 VA: 0x182893640
	public static double3x4 op_Implicit(double v) { }

	// RVA: 0x2893C50 Offset: 0x2892650 VA: 0x182893C50
	public static double3x4 op_Explicit(bool v) { }

	// RVA: 0x2913EC0 Offset: 0x29128C0 VA: 0x182913EC0
	public static double3x4 op_Explicit(bool3x4 v) { }

	// RVA: 0x2893720 Offset: 0x2892120 VA: 0x182893720
	public static double3x4 op_Implicit(int v) { }

	// RVA: 0x2914590 Offset: 0x2912F90 VA: 0x182914590
	public static double3x4 op_Implicit(int3x4 v) { }

	// RVA: 0x29145F0 Offset: 0x2912FF0 VA: 0x1829145F0
	public static double3x4 op_Implicit(uint v) { }

	// RVA: 0x2914630 Offset: 0x2913030 VA: 0x182914630
	public static double3x4 op_Implicit(uint3x4 v) { }

	// RVA: 0x28939E0 Offset: 0x28923E0 VA: 0x1828939E0
	public static double3x4 op_Implicit(float v) { }

	// RVA: 0x28937B0 Offset: 0x28921B0 VA: 0x1828937B0
	public static double3x4 op_Implicit(float3x4 v) { }

	// RVA: 0x2915B10 Offset: 0x2914510 VA: 0x182915B10
	public static double3x4 op_Multiply(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x29159F0 Offset: 0x29143F0 VA: 0x1829159F0
	public static double3x4 op_Multiply(double3x4 lhs, double rhs) { }

	// RVA: 0x29158D0 Offset: 0x29142D0 VA: 0x1829158D0
	public static double3x4 op_Multiply(double lhs, double3x4 rhs) { }

	// RVA: 0x2913380 Offset: 0x2911D80 VA: 0x182913380
	public static double3x4 op_Addition(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2913140 Offset: 0x2911B40 VA: 0x182913140
	public static double3x4 op_Addition(double3x4 lhs, double rhs) { }

	// RVA: 0x2913260 Offset: 0x2911C60 VA: 0x182913260
	public static double3x4 op_Addition(double lhs, double3x4 rhs) { }

	// RVA: 0x2915C90 Offset: 0x2914690 VA: 0x182915C90
	public static double3x4 op_Subtraction(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2915F50 Offset: 0x2914950 VA: 0x182915F50
	public static double3x4 op_Subtraction(double3x4 lhs, double rhs) { }

	// RVA: 0x2915E10 Offset: 0x2914810 VA: 0x182915E10
	public static double3x4 op_Subtraction(double lhs, double3x4 rhs) { }

	// RVA: 0x29138B0 Offset: 0x29122B0 VA: 0x1829138B0
	public static double3x4 op_Division(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2913650 Offset: 0x2912050 VA: 0x182913650
	public static double3x4 op_Division(double3x4 lhs, double rhs) { }

	// RVA: 0x2913770 Offset: 0x2912170 VA: 0x182913770
	public static double3x4 op_Division(double lhs, double3x4 rhs) { }

	// RVA: 0x29156B0 Offset: 0x29140B0 VA: 0x1829156B0
	public static double3x4 op_Modulus(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x29152D0 Offset: 0x2913CD0 VA: 0x1829152D0
	public static double3x4 op_Modulus(double3x4 lhs, double rhs) { }

	// RVA: 0x29154C0 Offset: 0x2913EC0 VA: 0x1829154C0
	public static double3x4 op_Modulus(double lhs, double3x4 rhs) { }

	// RVA: 0x2914690 Offset: 0x2913090 VA: 0x182914690
	public static double3x4 op_Increment(double3x4 val) { }

	// RVA: 0x2913500 Offset: 0x2911F00 VA: 0x182913500
	public static double3x4 op_Decrement(double3x4 val) { }

	// RVA: 0x2915170 Offset: 0x2913B70 VA: 0x182915170
	public static bool3x4 op_LessThan(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2915090 Offset: 0x2913A90 VA: 0x182915090
	public static bool3x4 op_LessThan(double3x4 lhs, double rhs) { }

	// RVA: 0x2914FA0 Offset: 0x29139A0 VA: 0x182914FA0
	public static bool3x4 op_LessThan(double lhs, double3x4 rhs) { }

	// RVA: 0x2914C70 Offset: 0x2913670 VA: 0x182914C70
	public static bool3x4 op_LessThanOrEqual(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2914DD0 Offset: 0x29137D0 VA: 0x182914DD0
	public static bool3x4 op_LessThanOrEqual(double3x4 lhs, double rhs) { }

	// RVA: 0x2914EB0 Offset: 0x29138B0 VA: 0x182914EB0
	public static bool3x4 op_LessThanOrEqual(double lhs, double3x4 rhs) { }

	// RVA: 0x2914430 Offset: 0x2912E30 VA: 0x182914430
	public static bool3x4 op_GreaterThan(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2914340 Offset: 0x2912D40 VA: 0x182914340
	public static bool3x4 op_GreaterThan(double3x4 lhs, double rhs) { }

	// RVA: 0x2914250 Offset: 0x2912C50 VA: 0x182914250
	public static bool3x4 op_GreaterThan(double lhs, double3x4 rhs) { }

	// RVA: 0x2914000 Offset: 0x2912A00 VA: 0x182914000
	public static bool3x4 op_GreaterThanOrEqual(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2913F10 Offset: 0x2912910 VA: 0x182913F10
	public static bool3x4 op_GreaterThanOrEqual(double3x4 lhs, double rhs) { }

	// RVA: 0x2914160 Offset: 0x2912B60 VA: 0x182914160
	public static bool3x4 op_GreaterThanOrEqual(double lhs, double3x4 rhs) { }

	// RVA: 0x2916070 Offset: 0x2914A70 VA: 0x182916070
	public static double3x4 op_UnaryNegation(double3x4 val) { }

	// RVA: 0x2916180 Offset: 0x2914B80 VA: 0x182916180
	public static double3x4 op_UnaryPlus(double3x4 val) { }

	// RVA: 0x2913A30 Offset: 0x2912430 VA: 0x182913A30
	public static bool3x4 op_Equality(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x2913D50 Offset: 0x2912750 VA: 0x182913D50
	public static bool3x4 op_Equality(double3x4 lhs, double rhs) { }

	// RVA: 0x2913BE0 Offset: 0x29125E0 VA: 0x182913BE0
	public static bool3x4 op_Equality(double lhs, double3x4 rhs) { }

	// RVA: 0x2914AC0 Offset: 0x29134C0 VA: 0x182914AC0
	public static bool3x4 op_Inequality(double3x4 lhs, double3x4 rhs) { }

	// RVA: 0x29147E0 Offset: 0x29131E0 VA: 0x1829147E0
	public static bool3x4 op_Inequality(double3x4 lhs, double rhs) { }

	// RVA: 0x2914950 Offset: 0x2913350 VA: 0x182914950
	public static bool3x4 op_Inequality(double lhs, double3x4 rhs) { }

	// RVA: 0xF6D020 Offset: 0xF6BA20 VA: 0x180F6D020
	public ref double3 get_Item(int index) { }

	// RVA: 0x290F140 Offset: 0x290DB40 VA: 0x18290F140 Slot: 4
	public bool Equals(double3x4 rhs) { }

	// RVA: 0x2912250 Offset: 0x2910C50 VA: 0x182912250 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2912330 Offset: 0x2910D30 VA: 0x182912330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2912870 Offset: 0x2911270 VA: 0x182912870 Slot: 3
	public override string ToString() { }

	// RVA: 0x2912380 Offset: 0x2910D80 VA: 0x182912380 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
