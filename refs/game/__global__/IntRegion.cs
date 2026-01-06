public struct IntRegion : IEquatable<IntRegion> // TypeDefIndex: 10413
{
	// Fields
	public int From; // 0x0
	public int To; // 0x4
	public bool SimpleValue; // 0x8

	// Properties
	public static IntRegion ZeroOne { get; }
	public bool Positive { get; }
	public int Low { get; set; }
	public int High { get; set; }
	public int Random { get; }
	public int Length { get; }
	public int LengthPositive { get; }

	// Methods

	// RVA: 0x4949D0 Offset: 0x4933D0 VA: 0x1804949D0
	public void .ctor(int value) { }

	// RVA: 0x4949E0 Offset: 0x4933E0 VA: 0x1804949E0
	public void .ctor(int A, int B) { }

	// RVA: 0x494A50 Offset: 0x493450 VA: 0x180494A50
	public static IntRegion get_ZeroOne() { }

	// RVA: 0x494920 Offset: 0x493320 VA: 0x180494920
	public void MakePositive() { }

	// RVA: 0x494760 Offset: 0x493160 VA: 0x180494760
	public void Clamp(int low, int high) { }

	// RVA: 0x494A30 Offset: 0x493430 VA: 0x180494A30
	public bool get_Positive() { }

	// RVA: 0x494A20 Offset: 0x493420 VA: 0x180494A20
	public int get_Low() { }

	// RVA: 0x494B90 Offset: 0x493590 VA: 0x180494B90
	public void set_Low(int value) { }

	// RVA: 0x4949F0 Offset: 0x4933F0 VA: 0x1804949F0
	public int get_High() { }

	// RVA: 0x494B80 Offset: 0x493580 VA: 0x180494B80
	public void set_High(int value) { }

	// RVA: 0x494A40 Offset: 0x493440 VA: 0x180494A40
	public int get_Random() { }

	// RVA: 0x494A10 Offset: 0x493410 VA: 0x180494A10
	public int get_Length() { }

	// RVA: 0x494A00 Offset: 0x493400 VA: 0x180494A00
	public int get_LengthPositive() { }

	// RVA: 0x494940 Offset: 0x493340 VA: 0x180494940 Slot: 3
	public override string ToString() { }

	// RVA: 0x4948E0 Offset: 0x4932E0 VA: 0x1804948E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4947E0 Offset: 0x4931E0 VA: 0x1804947E0 Slot: 4
	public bool Equals(IntRegion other) { }

	// RVA: 0x494830 Offset: 0x493230 VA: 0x180494830 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x494A70 Offset: 0x493470 VA: 0x180494A70
	public static IntRegion op_Addition(IntRegion a, IntRegion b) { }

	// RVA: 0x494B40 Offset: 0x493540 VA: 0x180494B40
	public static IntRegion op_Subtraction(IntRegion a, IntRegion b) { }

	// RVA: 0x494B60 Offset: 0x493560 VA: 0x180494B60
	public static IntRegion op_UnaryNegation(IntRegion a) { }

	// RVA: 0x494B00 Offset: 0x493500 VA: 0x180494B00
	public static IntRegion op_Multiply(IntRegion a, int v) { }

	// RVA: 0x494B20 Offset: 0x493520 VA: 0x180494B20
	public static IntRegion op_Multiply(int v, IntRegion a) { }

	// RVA: 0x494A90 Offset: 0x493490 VA: 0x180494A90
	public static IntRegion op_Division(IntRegion a, int v) { }

	// RVA: 0x494AC0 Offset: 0x4934C0 VA: 0x180494AC0
	public static bool op_Equality(IntRegion lhs, IntRegion rhs) { }

	// RVA: 0x494AE0 Offset: 0x4934E0 VA: 0x180494AE0
	public static bool op_Inequality(IntRegion lhs, IntRegion rhs) { }
}
