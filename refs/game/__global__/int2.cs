public struct Int2 : IEquatable<Int2> // TypeDefIndex: 13176
{
	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Properties
	public long sqrMagnitudeLong { get; }

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(int x, int y) { }

	// RVA: 0xB1B7D0 Offset: 0xB1A1D0 VA: 0x180B1B7D0
	public long get_sqrMagnitudeLong() { }

	// RVA: 0xB1B830 Offset: 0xB1A230 VA: 0x180B1B830
	public static Int2 op_UnaryNegation(Int2 lhs) { }

	// RVA: 0xB1B7F0 Offset: 0xB1A1F0 VA: 0x180B1B7F0
	public static Int2 op_Addition(Int2 a, Int2 b) { }

	// RVA: 0xB1B810 Offset: 0xB1A210 VA: 0x180B1B810
	public static Int2 op_Subtraction(Int2 a, Int2 b) { }

	// RVA: 0x50DD70 Offset: 0x50C770 VA: 0x18050DD70
	public static bool op_Equality(Int2 a, Int2 b) { }

	// RVA: 0x60F6C0 Offset: 0x60E0C0 VA: 0x18060F6C0
	public static bool op_Inequality(Int2 a, Int2 b) { }

	// RVA: 0xB1B4B0 Offset: 0xB19EB0 VA: 0x180B1B4B0
	public static long DotLong(Int2 a, Int2 b) { }

	// RVA: 0xB1B4E0 Offset: 0xB19EE0 VA: 0x180B1B4E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x50DAD0 Offset: 0x50C4D0 VA: 0x18050DAD0 Slot: 4
	public bool Equals(Int2 other) { }

	// RVA: 0xB1B580 Offset: 0xB19F80 VA: 0x180B1B580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB1B610 Offset: 0xB1A010 VA: 0x180B1B610
	public static Int2 Min(Int2 a, Int2 b) { }

	// RVA: 0xB1B590 Offset: 0xB19F90 VA: 0x180B1B590
	public static Int2 Max(Int2 a, Int2 b) { }

	// RVA: 0xB1B560 Offset: 0xB19F60 VA: 0x180B1B560
	public static Int2 FromInt3XZ(Int3 o) { }

	// RVA: 0xB1B690 Offset: 0xB1A090 VA: 0x180B1B690
	public static Int3 ToInt3XZ(Int2 o) { }

	// RVA: 0xB1B6B0 Offset: 0xB1A0B0 VA: 0x180B1B6B0 Slot: 3
	public override string ToString() { }
}
