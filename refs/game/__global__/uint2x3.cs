public struct uint2x3 : IEquatable<uint2x3>, IFormattable // TypeDefIndex: 10945
{
	// Fields
	public uint2 c0; // 0x0
	public uint2 c1; // 0x8
	public uint2 c2; // 0x10
	public static readonly uint2x3 zero; // 0x0

	// Properties
	public uint2 Item { get; }

	// Methods

	// RVA: 0x1BA9540 Offset: 0x1BA7F40 VA: 0x181BA9540
	public void .ctor(uint2 c0, uint2 c1, uint2 c2) { }

	// RVA: 0x2955FE0 Offset: 0x29549E0 VA: 0x182955FE0
	public void .ctor(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) { }

	// RVA: 0x2955F50 Offset: 0x2954950 VA: 0x182955F50
	public void .ctor(uint v) { }

	// RVA: 0x28843C0 Offset: 0x2882DC0 VA: 0x1828843C0
	public void .ctor(bool v) { }

	// RVA: 0x28842D0 Offset: 0x2882CD0 VA: 0x1828842D0
	public void .ctor(bool2x3 v) { }

	// RVA: 0x2955F50 Offset: 0x2954950 VA: 0x182955F50
	public void .ctor(int v) { }

	// RVA: 0x2955F90 Offset: 0x2954990 VA: 0x182955F90
	public void .ctor(int2x3 v) { }

	// RVA: 0x2887890 Offset: 0x2886290 VA: 0x182887890
	public void .ctor(float v) { }

	// RVA: 0x2887720 Offset: 0x2886120 VA: 0x182887720
	public void .ctor(float2x3 v) { }

	// RVA: 0x28877F0 Offset: 0x28861F0 VA: 0x1828877F0
	public void .ctor(double v) { }

	// RVA: 0x2887930 Offset: 0x2886330 VA: 0x182887930
	public void .ctor(double2x3 v) { }

	// RVA: 0x28A78D0 Offset: 0x28A62D0 VA: 0x1828A78D0
	public static uint2x3 op_Implicit(uint v) { }

	// RVA: 0x29569A0 Offset: 0x29553A0 VA: 0x1829569A0
	public static uint2x3 op_Explicit(bool v) { }

	// RVA: 0x29569D0 Offset: 0x29553D0 VA: 0x1829569D0
	public static uint2x3 op_Explicit(bool2x3 v) { }

	// RVA: 0x28A78D0 Offset: 0x28A62D0 VA: 0x1828A78D0
	public static uint2x3 op_Explicit(int v) { }

	// RVA: 0x28A7840 Offset: 0x28A6240 VA: 0x1828A7840
	public static uint2x3 op_Explicit(int2x3 v) { }

	// RVA: 0x298DD90 Offset: 0x298C790 VA: 0x18298DD90
	public static uint2x3 op_Explicit(float v) { }

	// RVA: 0x298DE40 Offset: 0x298C840 VA: 0x18298DE40
	public static uint2x3 op_Explicit(float2x3 v) { }

	// RVA: 0x298DDC0 Offset: 0x298C7C0 VA: 0x18298DDC0
	public static uint2x3 op_Explicit(double v) { }

	// RVA: 0x298DDF0 Offset: 0x298C7F0 VA: 0x18298DDF0
	public static uint2x3 op_Explicit(double2x3 v) { }

	// RVA: 0x2957450 Offset: 0x2955E50 VA: 0x182957450
	public static uint2x3 op_Multiply(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2957350 Offset: 0x2955D50 VA: 0x182957350
	public static uint2x3 op_Multiply(uint2x3 lhs, uint rhs) { }

	// RVA: 0x29573D0 Offset: 0x2955DD0 VA: 0x1829573D0
	public static uint2x3 op_Multiply(uint lhs, uint2x3 rhs) { }

	// RVA: 0x29560A0 Offset: 0x2954AA0 VA: 0x1829560A0
	public static uint2x3 op_Addition(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2956130 Offset: 0x2954B30 VA: 0x182956130
	public static uint2x3 op_Addition(uint2x3 lhs, uint rhs) { }

	// RVA: 0x2956030 Offset: 0x2954A30 VA: 0x182956030
	public static uint2x3 op_Addition(uint lhs, uint2x3 rhs) { }

	// RVA: 0x2957660 Offset: 0x2956060 VA: 0x182957660
	public static uint2x3 op_Subtraction(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x29576F0 Offset: 0x29560F0 VA: 0x1829576F0
	public static uint2x3 op_Subtraction(uint2x3 lhs, uint rhs) { }

	// RVA: 0x29575E0 Offset: 0x2955FE0 VA: 0x1829575E0
	public static uint2x3 op_Subtraction(uint lhs, uint2x3 rhs) { }

	// RVA: 0x298DBC0 Offset: 0x298C5C0 VA: 0x18298DBC0
	public static uint2x3 op_Division(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x298DD00 Offset: 0x298C700 VA: 0x18298DD00
	public static uint2x3 op_Division(uint2x3 lhs, uint rhs) { }

	// RVA: 0x298DC70 Offset: 0x298C670 VA: 0x18298DC70
	public static uint2x3 op_Division(uint lhs, uint2x3 rhs) { }

	// RVA: 0x298E450 Offset: 0x298CE50 VA: 0x18298E450
	public static uint2x3 op_Modulus(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x298E3C0 Offset: 0x298CDC0 VA: 0x18298E3C0
	public static uint2x3 op_Modulus(uint2x3 lhs, uint rhs) { }

	// RVA: 0x298E500 Offset: 0x298CF00 VA: 0x18298E500
	public static uint2x3 op_Modulus(uint lhs, uint2x3 rhs) { }

	// RVA: 0x2956CB0 Offset: 0x29556B0 VA: 0x182956CB0
	public static uint2x3 op_Increment(uint2x3 val) { }

	// RVA: 0x29564A0 Offset: 0x2954EA0 VA: 0x1829564A0
	public static uint2x3 op_Decrement(uint2x3 val) { }

	// RVA: 0x298E340 Offset: 0x298CD40 VA: 0x18298E340
	public static bool2x3 op_LessThan(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x298E270 Offset: 0x298CC70 VA: 0x18298E270
	public static bool2x3 op_LessThan(uint2x3 lhs, uint rhs) { }

	// RVA: 0x298E2E0 Offset: 0x298CCE0 VA: 0x18298E2E0
	public static bool2x3 op_LessThan(uint lhs, uint2x3 rhs) { }

	// RVA: 0x298E120 Offset: 0x298CB20 VA: 0x18298E120
	public static bool2x3 op_LessThanOrEqual(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x298E1A0 Offset: 0x298CBA0 VA: 0x18298E1A0
	public static bool2x3 op_LessThanOrEqual(uint2x3 lhs, uint rhs) { }

	// RVA: 0x298E210 Offset: 0x298CC10 VA: 0x18298E210
	public static bool2x3 op_LessThanOrEqual(uint lhs, uint2x3 rhs) { }

	// RVA: 0x298DFD0 Offset: 0x298C9D0 VA: 0x18298DFD0
	public static bool2x3 op_GreaterThan(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x298E050 Offset: 0x298CA50 VA: 0x18298E050
	public static bool2x3 op_GreaterThan(uint2x3 lhs, uint rhs) { }

	// RVA: 0x298E0C0 Offset: 0x298CAC0 VA: 0x18298E0C0
	public static bool2x3 op_GreaterThan(uint lhs, uint2x3 rhs) { }

	// RVA: 0x298DF50 Offset: 0x298C950 VA: 0x18298DF50
	public static bool2x3 op_GreaterThanOrEqual(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x298DEE0 Offset: 0x298C8E0 VA: 0x18298DEE0
	public static bool2x3 op_GreaterThanOrEqual(uint2x3 lhs, uint rhs) { }

	// RVA: 0x298DE80 Offset: 0x298C880 VA: 0x18298DE80
	public static bool2x3 op_GreaterThanOrEqual(uint lhs, uint2x3 rhs) { }

	// RVA: 0x2957770 Offset: 0x2956170 VA: 0x182957770
	public static uint2x3 op_UnaryNegation(uint2x3 val) { }

	// RVA: 0x29577E0 Offset: 0x29561E0 VA: 0x1829577E0
	public static uint2x3 op_UnaryPlus(uint2x3 val) { }

	// RVA: 0x2956E70 Offset: 0x2955870 VA: 0x182956E70
	public static uint2x3 op_LeftShift(uint2x3 x, int n) { }

	// RVA: 0x298E590 Offset: 0x298CF90 VA: 0x18298E590
	public static uint2x3 op_RightShift(uint2x3 x, int n) { }

	// RVA: 0x29566D0 Offset: 0x29550D0 VA: 0x1829566D0
	public static bool2x3 op_Equality(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2956750 Offset: 0x2955150 VA: 0x182956750
	public static bool2x3 op_Equality(uint2x3 lhs, uint rhs) { }

	// RVA: 0x29567C0 Offset: 0x29551C0 VA: 0x1829567C0
	public static bool2x3 op_Equality(uint lhs, uint2x3 rhs) { }

	// RVA: 0x2956D20 Offset: 0x2955720 VA: 0x182956D20
	public static bool2x3 op_Inequality(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2956DA0 Offset: 0x29557A0 VA: 0x182956DA0
	public static bool2x3 op_Inequality(uint2x3 lhs, uint rhs) { }

	// RVA: 0x2956E10 Offset: 0x2955810 VA: 0x182956E10
	public static bool2x3 op_Inequality(uint lhs, uint2x3 rhs) { }

	// RVA: 0x29574F0 Offset: 0x2955EF0 VA: 0x1829574F0
	public static uint2x3 op_OnesComplement(uint2x3 val) { }

	// RVA: 0x29561A0 Offset: 0x2954BA0 VA: 0x1829561A0
	public static uint2x3 op_BitwiseAnd(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2956230 Offset: 0x2954C30 VA: 0x182956230
	public static uint2x3 op_BitwiseAnd(uint2x3 lhs, uint rhs) { }

	// RVA: 0x29562B0 Offset: 0x2954CB0 VA: 0x1829562B0
	public static uint2x3 op_BitwiseAnd(uint lhs, uint2x3 rhs) { }

	// RVA: 0x2956390 Offset: 0x2954D90 VA: 0x182956390
	public static uint2x3 op_BitwiseOr(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2956420 Offset: 0x2954E20 VA: 0x182956420
	public static uint2x3 op_BitwiseOr(uint2x3 lhs, uint rhs) { }

	// RVA: 0x2956320 Offset: 0x2954D20 VA: 0x182956320
	public static uint2x3 op_BitwiseOr(uint lhs, uint2x3 rhs) { }

	// RVA: 0x2956910 Offset: 0x2955310 VA: 0x182956910
	public static uint2x3 op_ExclusiveOr(uint2x3 lhs, uint2x3 rhs) { }

	// RVA: 0x2956890 Offset: 0x2955290 VA: 0x182956890
	public static uint2x3 op_ExclusiveOr(uint2x3 lhs, uint rhs) { }

	// RVA: 0x2956820 Offset: 0x2955220 VA: 0x182956820
	public static uint2x3 op_ExclusiveOr(uint lhs, uint2x3 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref uint2 get_Item(int index) { }

	// RVA: 0x29556B0 Offset: 0x29540B0 VA: 0x1829556B0 Slot: 4
	public bool Equals(uint2x3 rhs) { }

	// RVA: 0x298D4F0 Offset: 0x298BEF0 VA: 0x18298D4F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x298D5F0 Offset: 0x298BFF0 VA: 0x18298D5F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x298D620 Offset: 0x298C020 VA: 0x18298D620 Slot: 3
	public override string ToString() { }

	// RVA: 0x298D8F0 Offset: 0x298C2F0 VA: 0x18298D8F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
