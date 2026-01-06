public struct half : IEquatable<half>, IFormattable // TypeDefIndex: 10914
{
	// Fields
	public ushort value; // 0x0
	public static readonly half zero; // 0x0

	// Properties
	public static float MaxValue { get; }
	public static float MinValue { get; }
	public static half MaxValueAsHalf { get; }
	public static half MinValueAsHalf { get; }

	// Methods

	// RVA: 0x2953150 Offset: 0x2951B50 VA: 0x182953150
	public static float get_MaxValue() { }

	// RVA: 0x2953170 Offset: 0x2951B70 VA: 0x182953170
	public static float get_MinValue() { }

	// RVA: 0x2953140 Offset: 0x2951B40 VA: 0x182953140
	public static half get_MaxValueAsHalf() { }

	// RVA: 0x2953160 Offset: 0x2951B60 VA: 0x182953160
	public static half get_MinValueAsHalf() { }

	// RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	public void .ctor(half x) { }

	// RVA: 0x2953120 Offset: 0x2951B20 VA: 0x182953120
	public void .ctor(float v) { }

	// RVA: 0x2953100 Offset: 0x2951B00 VA: 0x182953100
	public void .ctor(double v) { }

	// RVA: 0x289EE50 Offset: 0x289D850 VA: 0x18289EE50
	public static half op_Explicit(float v) { }

	// RVA: 0x289EE40 Offset: 0x289D840 VA: 0x18289EE40
	public static half op_Explicit(double v) { }

	// RVA: 0x29531F0 Offset: 0x2951BF0 VA: 0x1829531F0
	public static float op_Implicit(half d) { }

	// RVA: 0x2953180 Offset: 0x2951B80 VA: 0x182953180
	public static double op_Implicit(half d) { }

	// RVA: 0xC81A70 Offset: 0xC80470 VA: 0x180C81A70
	public static bool op_Equality(half lhs, half rhs) { }

	// RVA: 0x2953250 Offset: 0x2951C50 VA: 0x182953250
	public static bool op_Inequality(half lhs, half rhs) { }

	// RVA: 0xC81950 Offset: 0xC80350 VA: 0x180C81950 Slot: 4
	public bool Equals(half rhs) { }

	// RVA: 0x2952FF0 Offset: 0x29519F0 VA: 0x182952FF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2953080 Offset: 0x2951A80 VA: 0x182953080 Slot: 3
	public override string ToString() { }

	// RVA: 0x294CFE0 Offset: 0x294B9E0 VA: 0x18294CFE0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void .cctor() { }
}
