public struct FloatRegion : IEquatable<FloatRegion> // TypeDefIndex: 10412
{
	// Fields
	public float From; // 0x0
	public float To; // 0x4
	public bool SimpleValue; // 0x8

	// Properties
	public static FloatRegion ZeroOne { get; }
	public bool Positive { get; }
	public float Low { get; set; }
	public float High { get; set; }
	public float Random { get; }
	public float Next { get; }
	public float Length { get; }
	public float LengthPositive { get; }

	// Methods

	// RVA: 0x493AF0 Offset: 0x4924F0 VA: 0x180493AF0
	public void .ctor(float value) { }

	// RVA: 0x493B00 Offset: 0x492500 VA: 0x180493B00
	public void .ctor(float A, float B) { }

	// RVA: 0x493BD0 Offset: 0x4925D0 VA: 0x180493BD0
	public static FloatRegion get_ZeroOne() { }

	// RVA: 0x493A40 Offset: 0x492440 VA: 0x180493A40
	public void MakePositive() { }

	// RVA: 0x493880 Offset: 0x492280 VA: 0x180493880
	public void Clamp(float low, float high) { }

	// RVA: 0x493BA0 Offset: 0x4925A0 VA: 0x180493BA0
	public bool get_Positive() { }

	// RVA: 0x493B60 Offset: 0x492560 VA: 0x180493B60
	public float get_Low() { }

	// RVA: 0x493DF0 Offset: 0x4927F0 VA: 0x180493DF0
	public void set_Low(float value) { }

	// RVA: 0x493B10 Offset: 0x492510 VA: 0x180493B10
	public float get_High() { }

	// RVA: 0x493DD0 Offset: 0x4927D0 VA: 0x180493DD0
	public void set_High(float value) { }

	// RVA: 0x493BB0 Offset: 0x4925B0 VA: 0x180493BB0
	public float get_Random() { }

	// RVA: 0x493B80 Offset: 0x492580 VA: 0x180493B80
	public float get_Next() { }

	// RVA: 0x493B50 Offset: 0x492550 VA: 0x180493B50
	public float get_Length() { }

	// RVA: 0x493B30 Offset: 0x492530 VA: 0x180493B30
	public float get_LengthPositive() { }

	// RVA: 0x493A60 Offset: 0x492460 VA: 0x180493A60 Slot: 3
	public override string ToString() { }

	// RVA: 0x493A00 Offset: 0x492400 VA: 0x180493A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4939B0 Offset: 0x4923B0 VA: 0x1804939B0 Slot: 4
	public bool Equals(FloatRegion other) { }

	// RVA: 0x493900 Offset: 0x492300 VA: 0x180493900 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x493BF0 Offset: 0x4925F0 VA: 0x180493BF0
	public static FloatRegion op_Addition(FloatRegion a, FloatRegion b) { }

	// RVA: 0x493D70 Offset: 0x492770 VA: 0x180493D70
	public static FloatRegion op_Subtraction(FloatRegion a, FloatRegion b) { }

	// RVA: 0x493DA0 Offset: 0x4927A0 VA: 0x180493DA0
	public static FloatRegion op_UnaryNegation(FloatRegion a) { }

	// RVA: 0x493D40 Offset: 0x492740 VA: 0x180493D40
	public static FloatRegion op_Multiply(FloatRegion a, float v) { }

	// RVA: 0x493D10 Offset: 0x492710 VA: 0x180493D10
	public static FloatRegion op_Multiply(float v, FloatRegion a) { }

	// RVA: 0x493C20 Offset: 0x492620 VA: 0x180493C20
	public static FloatRegion op_Division(FloatRegion a, float v) { }

	// RVA: 0x493C50 Offset: 0x492650 VA: 0x180493C50
	public static bool op_Equality(FloatRegion lhs, FloatRegion rhs) { }

	// RVA: 0x493CB0 Offset: 0x4926B0 VA: 0x180493CB0
	public static bool op_Inequality(FloatRegion lhs, FloatRegion rhs) { }
}
