public struct BoundsInt : IEquatable<BoundsInt>, IFormattable // TypeDefIndex: 11624
{
	// Fields
	private Vector3Int m_Position; // 0x0
	private Vector3Int m_Size; // 0xC

	// Properties
	public Vector3Int position { get; set; }
	public Vector3Int size { get; set; }

	// Methods

	// RVA: 0x2C63CF0 Offset: 0x2C626F0 VA: 0x182C63CF0
	public Vector3Int get_position() { }

	// RVA: 0x281FE90 Offset: 0x281E890 VA: 0x18281FE90
	public void set_position(Vector3Int value) { }

	// RVA: 0x2C80B20 Offset: 0x2C7F520 VA: 0x182C80B20
	public Vector3Int get_size() { }

	// RVA: 0x2C63D20 Offset: 0x2C62720 VA: 0x182C63D20
	public void set_size(Vector3Int value) { }

	// RVA: 0x1435880 Offset: 0x1434280 VA: 0x181435880
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x2C80B10 Offset: 0x2C7F510 VA: 0x182C80B10 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C80970 Offset: 0x2C7F370 VA: 0x182C80970 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2C807F0 Offset: 0x2C7F1F0 VA: 0x182C807F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2C80750 Offset: 0x2C7F150 VA: 0x182C80750 Slot: 4
	public bool Equals(BoundsInt other) { }

	// RVA: 0x2C80930 Offset: 0x2C7F330 VA: 0x182C80930 Slot: 2
	public override int GetHashCode() { }
}
