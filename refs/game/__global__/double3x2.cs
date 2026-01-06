public struct double3x2 : IEquatable<double3x2>, IFormattable // TypeDefIndex: 10891
{
	// Fields
	public double3 c0; // 0x0
	public double3 c1; // 0x18
	public static readonly double3x2 zero; // 0x0

	// Properties
	public double3 Item { get; }

	// Methods

	// RVA: 0x290AAB0 Offset: 0x29094B0 VA: 0x18290AAB0
	public void .ctor(double3 c0, double3 c1) { }

	// RVA: 0x290A770 Offset: 0x2909170 VA: 0x18290A770
	public void .ctor(double m00, double m01, double m10, double m11, double m20, double m21) { }

	// RVA: 0x290A8A0 Offset: 0x29092A0 VA: 0x18290A8A0
	public void .ctor(double v) { }

	// RVA: 0x2881220 Offset: 0x287FC20 VA: 0x182881220
	public void .ctor(bool v) { }

	// RVA: 0x290A940 Offset: 0x2909340 VA: 0x18290A940
	public void .ctor(bool3x2 v) { }

	// RVA: 0x290A9D0 Offset: 0x29093D0 VA: 0x18290A9D0
	public void .ctor(int v) { }

	// RVA: 0x290AA20 Offset: 0x2909420 VA: 0x18290AA20
	public void .ctor(int3x2 v) { }

	// RVA: 0x290A840 Offset: 0x2909240 VA: 0x18290A840
	public void .ctor(uint v) { }

	// RVA: 0x290A7B0 Offset: 0x29091B0 VA: 0x18290A7B0
	public void .ctor(uint3x2 v) { }

	// RVA: 0x290A730 Offset: 0x2909130 VA: 0x18290A730
	public void .ctor(float v) { }

	// RVA: 0x290A8D0 Offset: 0x29092D0 VA: 0x18290A8D0
	public void .ctor(float3x2 v) { }

	// RVA: 0x2892C90 Offset: 0x2891690 VA: 0x182892C90
	public static double3x2 op_Implicit(double v) { }

	// RVA: 0x2892D70 Offset: 0x2891770 VA: 0x182892D70
	public static double3x2 op_Explicit(bool v) { }

	// RVA: 0x2892DF0 Offset: 0x28917F0 VA: 0x182892DF0
	public static double3x2 op_Explicit(bool3x2 v) { }

	// RVA: 0x2892FC0 Offset: 0x28919C0 VA: 0x182892FC0
	public static double3x2 op_Implicit(int v) { }

	// RVA: 0x2892E90 Offset: 0x2891890 VA: 0x182892E90
	public static double3x2 op_Implicit(int3x2 v) { }

	// RVA: 0x2892BB0 Offset: 0x28915B0 VA: 0x182892BB0
	public static double3x2 op_Implicit(uint v) { }

	// RVA: 0x2892CC0 Offset: 0x28916C0 VA: 0x182892CC0
	public static double3x2 op_Implicit(uint3x2 v) { }

	// RVA: 0x2892F70 Offset: 0x2891970 VA: 0x182892F70
	public static double3x2 op_Implicit(float v) { }

	// RVA: 0x2892C20 Offset: 0x2891620 VA: 0x182892C20
	public static double3x2 op_Implicit(float3x2 v) { }

	// RVA: 0x290BD70 Offset: 0x290A770 VA: 0x18290BD70
	public static double3x2 op_Multiply(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290BC90 Offset: 0x290A690 VA: 0x18290BC90
	public static double3x2 op_Multiply(double3x2 lhs, double rhs) { }

	// RVA: 0x290BD00 Offset: 0x290A700 VA: 0x18290BD00
	public static double3x2 op_Multiply(double lhs, double3x2 rhs) { }

	// RVA: 0x290AAE0 Offset: 0x29094E0 VA: 0x18290AAE0
	public static double3x2 op_Addition(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290ABE0 Offset: 0x29095E0 VA: 0x18290ABE0
	public static double3x2 op_Addition(double3x2 lhs, double rhs) { }

	// RVA: 0x290AB70 Offset: 0x2909570 VA: 0x18290AB70
	public static double3x2 op_Addition(double lhs, double3x2 rhs) { }

	// RVA: 0x290BEF0 Offset: 0x290A8F0 VA: 0x18290BEF0
	public static double3x2 op_Subtraction(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290BE00 Offset: 0x290A800 VA: 0x18290BE00
	public static double3x2 op_Subtraction(double3x2 lhs, double rhs) { }

	// RVA: 0x290BE70 Offset: 0x290A870 VA: 0x18290BE70
	public static double3x2 op_Subtraction(double lhs, double3x2 rhs) { }

	// RVA: 0x290ACD0 Offset: 0x29096D0 VA: 0x18290ACD0
	public static double3x2 op_Division(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290ADE0 Offset: 0x29097E0 VA: 0x18290ADE0
	public static double3x2 op_Division(double3x2 lhs, double rhs) { }

	// RVA: 0x290AD60 Offset: 0x2909760 VA: 0x18290AD60
	public static double3x2 op_Division(double lhs, double3x2 rhs) { }

	// RVA: 0x290B950 Offset: 0x290A350 VA: 0x18290B950
	public static double3x2 op_Modulus(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290BA80 Offset: 0x290A480 VA: 0x18290BA80
	public static double3x2 op_Modulus(double3x2 lhs, double rhs) { }

	// RVA: 0x290BB80 Offset: 0x290A580 VA: 0x18290BB80
	public static double3x2 op_Modulus(double lhs, double3x2 rhs) { }

	// RVA: 0x290B3A0 Offset: 0x2909DA0 VA: 0x18290B3A0
	public static double3x2 op_Increment(double3x2 val) { }

	// RVA: 0x290AC50 Offset: 0x2909650 VA: 0x18290AC50
	public static double3x2 op_Decrement(double3x2 val) { }

	// RVA: 0x290B850 Offset: 0x290A250 VA: 0x18290B850
	public static bool3x2 op_LessThan(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290B8E0 Offset: 0x290A2E0 VA: 0x18290B8E0
	public static bool3x2 op_LessThan(double3x2 lhs, double rhs) { }

	// RVA: 0x290B7D0 Offset: 0x290A1D0 VA: 0x18290B7D0
	public static bool3x2 op_LessThan(double lhs, double3x2 rhs) { }

	// RVA: 0x290B6C0 Offset: 0x290A0C0 VA: 0x18290B6C0
	public static bool3x2 op_LessThanOrEqual(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290B650 Offset: 0x290A050 VA: 0x18290B650
	public static bool3x2 op_LessThanOrEqual(double3x2 lhs, double rhs) { }

	// RVA: 0x290B750 Offset: 0x290A150 VA: 0x18290B750
	public static bool3x2 op_LessThanOrEqual(double lhs, double3x2 rhs) { }

	// RVA: 0x290B290 Offset: 0x2909C90 VA: 0x18290B290
	public static bool3x2 op_GreaterThan(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290B320 Offset: 0x2909D20 VA: 0x18290B320
	public static bool3x2 op_GreaterThan(double3x2 lhs, double rhs) { }

	// RVA: 0x290B210 Offset: 0x2909C10 VA: 0x18290B210
	public static bool3x2 op_GreaterThan(double lhs, double3x2 rhs) { }

	// RVA: 0x290B100 Offset: 0x2909B00 VA: 0x18290B100
	public static bool3x2 op_GreaterThanOrEqual(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290B080 Offset: 0x2909A80 VA: 0x18290B080
	public static bool3x2 op_GreaterThanOrEqual(double3x2 lhs, double rhs) { }

	// RVA: 0x290B190 Offset: 0x2909B90 VA: 0x18290B190
	public static bool3x2 op_GreaterThanOrEqual(double lhs, double3x2 rhs) { }

	// RVA: 0x290BF80 Offset: 0x290A980 VA: 0x18290BF80
	public static double3x2 op_UnaryNegation(double3x2 val) { }

	// RVA: 0x290BFF0 Offset: 0x290A9F0 VA: 0x18290BFF0
	public static double3x2 op_UnaryPlus(double3x2 val) { }

	// RVA: 0x290AFB0 Offset: 0x29099B0 VA: 0x18290AFB0
	public static bool3x2 op_Equality(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290AE50 Offset: 0x2909850 VA: 0x18290AE50
	public static bool3x2 op_Equality(double3x2 lhs, double rhs) { }

	// RVA: 0x290AF00 Offset: 0x2909900 VA: 0x18290AF00
	public static bool3x2 op_Equality(double lhs, double3x2 rhs) { }

	// RVA: 0x290B4D0 Offset: 0x2909ED0 VA: 0x18290B4D0
	public static bool3x2 op_Inequality(double3x2 lhs, double3x2 rhs) { }

	// RVA: 0x290B5A0 Offset: 0x2909FA0 VA: 0x18290B5A0
	public static bool3x2 op_Inequality(double3x2 lhs, double rhs) { }

	// RVA: 0x290B420 Offset: 0x2909E20 VA: 0x18290B420
	public static bool3x2 op_Inequality(double lhs, double3x2 rhs) { }

	// RVA: 0xF6D020 Offset: 0xF6BA20 VA: 0x180F6D020
	public ref double3 get_Item(int index) { }

	// RVA: 0x290A020 Offset: 0x2908A20 VA: 0x18290A020 Slot: 4
	public bool Equals(double3x2 rhs) { }

	// RVA: 0x2909F30 Offset: 0x2908930 VA: 0x182909F30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x290A0A0 Offset: 0x2908AA0 VA: 0x18290A0A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x290A440 Offset: 0x2908E40 VA: 0x18290A440 Slot: 3
	public override string ToString() { }

	// RVA: 0x290A170 Offset: 0x2908B70 VA: 0x18290A170 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
