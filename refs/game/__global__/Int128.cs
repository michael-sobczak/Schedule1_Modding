internal struct Int128 // TypeDefIndex: 18127
{
	// Fields
	private long hi; // 0x0
	private ulong lo; // 0x8

	// Methods

	// RVA: 0xC40D10 Offset: 0xC3F710 VA: 0x180C40D10
	public void .ctor(long _lo) { }

	// RVA: 0xC40D00 Offset: 0xC3F700 VA: 0x180C40D00
	public void .ctor(long _hi, ulong _lo) { }

	// RVA: 0xC3F6C0 Offset: 0xC3E0C0 VA: 0x180C3F6C0
	public void .ctor(Int128 val) { }

	// RVA: 0xC40CF0 Offset: 0xC3F6F0 VA: 0x180C40CF0
	public bool IsNegative() { }

	// RVA: 0x1E2C460 Offset: 0x1E2AE60 VA: 0x181E2C460 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xC40C00 Offset: 0xC3F600 VA: 0x180C40C00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E2C510 Offset: 0x1E2AF10 VA: 0x181E2C510
	public static Int128 Int128Mul(long lhs, long rhs) { }

	// RVA: 0x1E2C5D0 Offset: 0x1E2AFD0 VA: 0x181E2C5D0
	public double ToDouble() { }

	// RVA: 0x1E2CA60 Offset: 0x1E2B460 VA: 0x181E2CA60
	public static bool op_Equality(Int128 val1, Int128 val2) { }

	// RVA: 0x1E2CB20 Offset: 0x1E2B520 VA: 0x181E2CB20
	public static bool op_Inequality(Int128 val1, Int128 val2) { }

	// RVA: 0xC40EC0 Offset: 0xC3F8C0 VA: 0x180C40EC0
	public static bool op_GreaterThan(Int128 val1, Int128 val2) { }

	// RVA: 0xC40FA0 Offset: 0xC3F9A0 VA: 0x180C40FA0
	public static bool op_LessThan(Int128 val1, Int128 val2) { }

	// RVA: 0x1E2C690 Offset: 0x1E2B090 VA: 0x181E2C690
	public static Int128 op_Addition(Int128 lhs, Int128 rhs) { }

	// RVA: 0x1E2CC00 Offset: 0x1E2B600 VA: 0x181E2CC00
	public static Int128 op_Subtraction(Int128 lhs, Int128 rhs) { }

	// RVA: 0xC41030 Offset: 0xC3FA30 VA: 0x180C41030
	public static Int128 op_UnaryNegation(Int128 val) { }

	// RVA: 0x1E2C6C0 Offset: 0x1E2B0C0 VA: 0x181E2C6C0
	public static Int128 op_Division(Int128 lhs, Int128 rhs) { }
}
