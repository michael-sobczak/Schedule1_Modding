public struct PropertyName : IEquatable<PropertyName> // TypeDefIndex: 11784
{
	// Fields
	internal int id; // 0x0

	// Methods

	// RVA: 0x2CC3EE0 Offset: 0x2CC28E0 VA: 0x182CC3EE0
	public void .ctor(string name) { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(PropertyName other) { }

	// RVA: 0x2CC3E70 Offset: 0x2CC2870 VA: 0x182CC3E70
	public static bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x2CC3F40 Offset: 0x2CC2940 VA: 0x182CC3F40
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CC3DE0 Offset: 0x2CC27E0 VA: 0x182CC3DE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CC3DD0 Offset: 0x2CC27D0 VA: 0x182CC3DD0 Slot: 4
	public bool Equals(PropertyName other) { }

	// RVA: 0x2CC3D80 Offset: 0x2CC2780 VA: 0x182CC3D80
	public static PropertyName op_Implicit(string name) { }

	// RVA: 0x2CC3E80 Offset: 0x2CC2880 VA: 0x182CC3E80 Slot: 3
	public override string ToString() { }
}
