public struct EasingFunction : IEquatable<EasingFunction> // TypeDefIndex: 6777
{
	// Fields
	private EasingMode m_Mode; // 0x0

	// Properties
	public EasingMode mode { get; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public EasingMode get_mode() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(EasingMode mode) { }

	// RVA: 0x2CBEE40 Offset: 0x2CBD840 VA: 0x182CBEE40
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	// RVA: 0x2CC3F40 Offset: 0x2CC2940 VA: 0x182CC3F40
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	// RVA: 0x2ED7B10 Offset: 0x2ED6510 VA: 0x182ED7B10 Slot: 4
	public bool Equals(EasingFunction other) { }

	// RVA: 0x2ED7A80 Offset: 0x2ED6480 VA: 0x182ED7A80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED7B20 Offset: 0x2ED6520 VA: 0x182ED7B20 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }
}
