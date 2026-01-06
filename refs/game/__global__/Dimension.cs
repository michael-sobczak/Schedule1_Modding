internal struct Dimension : IEquatable<Dimension> // TypeDefIndex: 7165
{
	// Fields
	public Dimension.Unit unit; // 0x0
	public float value; // 0x4

	// Methods

	// RVA: 0x2E2ECB0 Offset: 0x2E2D6B0 VA: 0x182E2ECB0
	public void .ctor(float value, Dimension.Unit unit) { }

	// RVA: 0x2E2EAB0 Offset: 0x2E2D4B0 VA: 0x182E2EAB0
	public Length ToLength() { }

	// RVA: 0x2E2EC80 Offset: 0x2E2D680 VA: 0x182E2EC80
	public TimeValue ToTime() { }

	// RVA: 0x2E2EA20 Offset: 0x2E2D420 VA: 0x182E2EA20
	public Angle ToAngle() { }

	// RVA: 0x2E2ECC0 Offset: 0x2E2D6C0 VA: 0x182E2ECC0
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	// RVA: 0x2E2E9B0 Offset: 0x2E2D3B0 VA: 0x182E2E9B0 Slot: 4
	public bool Equals(Dimension other) { }

	// RVA: 0x2E2E8F0 Offset: 0x2E2D2F0 VA: 0x182E2E8F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E2E9E0 Offset: 0x2E2D3E0 VA: 0x182E2E9E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E2EAE0 Offset: 0x2E2D4E0 VA: 0x182E2EAE0 Slot: 3
	public override string ToString() { }
}
