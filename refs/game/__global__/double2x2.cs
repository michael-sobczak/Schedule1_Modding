public struct double2x2 : IEquatable<double2x2>, IFormattable // TypeDefIndex: 10886
{
	// Fields
	public double2 c0; // 0x0
	public double2 c1; // 0x10
	public static readonly double2x2 identity; // 0x0
	public static readonly double2x2 zero; // 0x20

	// Properties
	public double2 Item { get; }

	// Methods

	// RVA: 0x1330B70 Offset: 0x132F570 VA: 0x181330B70
	public void .ctor(double2 c0, double2 c1) { }

	// RVA: 0x2903000 Offset: 0x2901A00 VA: 0x182903000
	public void .ctor(double m00, double m01, double m10, double m11) { }

	// RVA: 0x2902FF0 Offset: 0x29019F0 VA: 0x182902FF0
	public void .ctor(double v) { }

	// RVA: 0x2902FC0 Offset: 0x29019C0 VA: 0x182902FC0
	public void .ctor(bool v) { }

	// RVA: 0x2902F30 Offset: 0x2901930 VA: 0x182902F30
	public void .ctor(bool2x2 v) { }

	// RVA: 0x2902F90 Offset: 0x2901990 VA: 0x182902F90
	public void .ctor(int v) { }

	// RVA: 0x2903120 Offset: 0x2901B20 VA: 0x182903120
	public void .ctor(int2x2 v) { }

	// RVA: 0x2903020 Offset: 0x2901A20 VA: 0x182903020
	public void .ctor(uint v) { }

	// RVA: 0x29030A0 Offset: 0x2901AA0 VA: 0x1829030A0
	public void .ctor(uint2x2 v) { }

	// RVA: 0x29030F0 Offset: 0x2901AF0 VA: 0x1829030F0
	public void .ctor(float v) { }

	// RVA: 0x2903060 Offset: 0x2901A60 VA: 0x182903060
	public void .ctor(float2x2 v) { }

	// RVA: 0x2891A30 Offset: 0x2890430 VA: 0x182891A30
	public static double2x2 op_Implicit(double v) { }

	// RVA: 0x2891C60 Offset: 0x2890660 VA: 0x182891C60
	public static double2x2 op_Explicit(bool v) { }

	// RVA: 0x2891A40 Offset: 0x2890440 VA: 0x182891A40
	public static double2x2 op_Explicit(bool2x2 v) { }

	// RVA: 0x2891B50 Offset: 0x2890550 VA: 0x182891B50
	public static double2x2 op_Implicit(int v) { }

	// RVA: 0x2891B90 Offset: 0x2890590 VA: 0x182891B90
	public static double2x2 op_Implicit(int2x2 v) { }

	// RVA: 0x2891AA0 Offset: 0x28904A0 VA: 0x182891AA0
	public static double2x2 op_Implicit(uint v) { }

	// RVA: 0x2891BF0 Offset: 0x28905F0 VA: 0x182891BF0
	public static double2x2 op_Implicit(uint2x2 v) { }

	// RVA: 0x28919D0 Offset: 0x28903D0 VA: 0x1828919D0
	public static double2x2 op_Implicit(float v) { }

	// RVA: 0x2891B00 Offset: 0x2890500 VA: 0x182891B00
	public static double2x2 op_Implicit(float2x2 v) { }

	// RVA: 0x2903EC0 Offset: 0x29028C0 VA: 0x182903EC0
	public static double2x2 op_Multiply(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903E50 Offset: 0x2902850 VA: 0x182903E50
	public static double2x2 op_Multiply(double2x2 lhs, double rhs) { }

	// RVA: 0x2903E80 Offset: 0x2902880 VA: 0x182903E80
	public static double2x2 op_Multiply(double lhs, double2x2 rhs) { }

	// RVA: 0x2903170 Offset: 0x2901B70 VA: 0x182903170
	public static double2x2 op_Addition(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x29031C0 Offset: 0x2901BC0 VA: 0x1829031C0
	public static double2x2 op_Addition(double2x2 lhs, double rhs) { }

	// RVA: 0x29031F0 Offset: 0x2901BF0 VA: 0x1829031F0
	public static double2x2 op_Addition(double lhs, double2x2 rhs) { }

	// RVA: 0x2903F80 Offset: 0x2902980 VA: 0x182903F80
	public static double2x2 op_Subtraction(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903F50 Offset: 0x2902950 VA: 0x182903F50
	public static double2x2 op_Subtraction(double2x2 lhs, double rhs) { }

	// RVA: 0x2903F10 Offset: 0x2902910 VA: 0x182903F10
	public static double2x2 op_Subtraction(double lhs, double2x2 rhs) { }

	// RVA: 0x29032A0 Offset: 0x2901CA0 VA: 0x1829032A0
	public static double2x2 op_Division(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903270 Offset: 0x2901C70 VA: 0x182903270
	public static double2x2 op_Division(double2x2 lhs, double rhs) { }

	// RVA: 0x29032F0 Offset: 0x2901CF0 VA: 0x1829032F0
	public static double2x2 op_Division(double lhs, double2x2 rhs) { }

	// RVA: 0x2903CB0 Offset: 0x29026B0 VA: 0x182903CB0
	public static double2x2 op_Modulus(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903DD0 Offset: 0x29027D0 VA: 0x182903DD0
	public static double2x2 op_Modulus(double2x2 lhs, double rhs) { }

	// RVA: 0x2903D50 Offset: 0x2902750 VA: 0x182903D50
	public static double2x2 op_Modulus(double lhs, double2x2 rhs) { }

	// RVA: 0x29037D0 Offset: 0x29021D0 VA: 0x1829037D0
	public static double2x2 op_Increment(double2x2 val) { }

	// RVA: 0x2903230 Offset: 0x2901C30 VA: 0x182903230
	public static double2x2 op_Decrement(double2x2 val) { }

	// RVA: 0x2903C30 Offset: 0x2902630 VA: 0x182903C30
	public static bool2x2 op_LessThan(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903BC0 Offset: 0x29025C0 VA: 0x182903BC0
	public static bool2x2 op_LessThan(double2x2 lhs, double rhs) { }

	// RVA: 0x2903B50 Offset: 0x2902550 VA: 0x182903B50
	public static bool2x2 op_LessThan(double lhs, double2x2 rhs) { }

	// RVA: 0x2903A60 Offset: 0x2902460 VA: 0x182903A60
	public static bool2x2 op_LessThanOrEqual(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x29039F0 Offset: 0x29023F0 VA: 0x1829039F0
	public static bool2x2 op_LessThanOrEqual(double2x2 lhs, double rhs) { }

	// RVA: 0x2903AE0 Offset: 0x29024E0 VA: 0x182903AE0
	public static bool2x2 op_LessThanOrEqual(double lhs, double2x2 rhs) { }

	// RVA: 0x2903670 Offset: 0x2902070 VA: 0x182903670
	public static bool2x2 op_GreaterThan(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x29036F0 Offset: 0x29020F0 VA: 0x1829036F0
	public static bool2x2 op_GreaterThan(double2x2 lhs, double rhs) { }

	// RVA: 0x2903760 Offset: 0x2902160 VA: 0x182903760
	public static bool2x2 op_GreaterThan(double lhs, double2x2 rhs) { }

	// RVA: 0x2903580 Offset: 0x2901F80 VA: 0x182903580
	public static bool2x2 op_GreaterThanOrEqual(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903600 Offset: 0x2902000 VA: 0x182903600
	public static bool2x2 op_GreaterThanOrEqual(double2x2 lhs, double rhs) { }

	// RVA: 0x2903510 Offset: 0x2901F10 VA: 0x182903510
	public static bool2x2 op_GreaterThanOrEqual(double lhs, double2x2 rhs) { }

	// RVA: 0x2903FD0 Offset: 0x29029D0 VA: 0x182903FD0
	public static double2x2 op_UnaryNegation(double2x2 val) { }

	// RVA: 0x2904000 Offset: 0x2902A00 VA: 0x182904000
	public static double2x2 op_UnaryPlus(double2x2 val) { }

	// RVA: 0x2903330 Offset: 0x2901D30 VA: 0x182903330
	public static bool2x2 op_Equality(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x29033E0 Offset: 0x2901DE0 VA: 0x1829033E0
	public static bool2x2 op_Equality(double2x2 lhs, double rhs) { }

	// RVA: 0x2903480 Offset: 0x2901E80 VA: 0x182903480
	public static bool2x2 op_Equality(double lhs, double2x2 rhs) { }

	// RVA: 0x2903810 Offset: 0x2902210 VA: 0x182903810
	public static bool2x2 op_Inequality(double2x2 lhs, double2x2 rhs) { }

	// RVA: 0x2903950 Offset: 0x2902350 VA: 0x182903950
	public static bool2x2 op_Inequality(double2x2 lhs, double rhs) { }

	// RVA: 0x29038C0 Offset: 0x29022C0 VA: 0x1829038C0
	public static bool2x2 op_Inequality(double lhs, double2x2 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref double2 get_Item(int index) { }

	// RVA: 0x2902960 Offset: 0x2901360 VA: 0x182902960 Slot: 4
	public bool Equals(double2x2 rhs) { }

	// RVA: 0x29029C0 Offset: 0x29013C0 VA: 0x1829029C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2902A80 Offset: 0x2901480 VA: 0x182902A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2902AB0 Offset: 0x29014B0 VA: 0x182902AB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2902CD0 Offset: 0x29016D0 VA: 0x182902CD0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2902EE0 Offset: 0x29018E0 VA: 0x182902EE0
	private static void .cctor() { }
}
