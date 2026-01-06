public struct SHCoefficients : IEquatable<SHCoefficients> // TypeDefIndex: 13835
{
	// Fields
	public Vector4 SHAr; // 0x0
	public Vector4 SHAg; // 0x10
	public Vector4 SHAb; // 0x20
	public Vector4 SHBr; // 0x30
	public Vector4 SHBg; // 0x40
	public Vector4 SHBb; // 0x50
	public Vector4 SHC; // 0x60
	public Vector4 ProbesOcclusion; // 0x70

	// Methods

	// RVA: 0x2A41650 Offset: 0x2A40050 VA: 0x182A41650
	public void .ctor(SphericalHarmonicsL2 sh) { }

	// RVA: 0x2A415D0 Offset: 0x2A3FFD0 VA: 0x182A415D0
	public void .ctor(SphericalHarmonicsL2 sh, Vector4 probesOcclusion) { }

	// RVA: 0x2A413A0 Offset: 0x2A3FDA0 VA: 0x182A413A0
	private static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i) { }

	// RVA: 0x2A41480 Offset: 0x2A3FE80 VA: 0x182A41480
	private static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i) { }

	// RVA: 0x2A41540 Offset: 0x2A3FF40 VA: 0x182A41540
	private static Vector4 GetSHC(SphericalHarmonicsL2 sh) { }

	// RVA: 0x2A40E10 Offset: 0x2A3F810 VA: 0x182A40E10 Slot: 4
	public bool Equals(SHCoefficients other) { }

	// RVA: 0x2A41130 Offset: 0x2A3FB30 VA: 0x182A41130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A41230 Offset: 0x2A3FC30 VA: 0x182A41230 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A41CC0 Offset: 0x2A406C0 VA: 0x182A41CC0
	public static bool op_Equality(SHCoefficients left, SHCoefficients right) { }

	// RVA: 0x2A41D20 Offset: 0x2A40720 VA: 0x182A41D20
	public static bool op_Inequality(SHCoefficients left, SHCoefficients right) { }
}
