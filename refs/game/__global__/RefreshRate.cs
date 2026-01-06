public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate> // TypeDefIndex: 11643
{
	// Fields
	public uint numerator; // 0x0
	public uint denominator; // 0x4

	// Properties
	public double value { get; }

	// Methods

	// RVA: 0x2C9D7E0 Offset: 0x2C9C1E0 VA: 0x182C9D7E0
	public double get_value() { }

	// RVA: 0x2C9D700 Offset: 0x2C9C100 VA: 0x182C9D700 Slot: 4
	public bool Equals(RefreshRate other) { }

	// RVA: 0x2C9D6A0 Offset: 0x2C9C0A0 VA: 0x182C9D6A0 Slot: 5
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x2C9D740 Offset: 0x2C9C140 VA: 0x182C9D740 Slot: 3
	public override string ToString() { }
}
