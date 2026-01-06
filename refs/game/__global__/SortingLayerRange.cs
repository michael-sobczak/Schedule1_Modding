public struct SortingLayerRange : IEquatable<SortingLayerRange> // TypeDefIndex: 12272
{
	// Fields
	private short m_LowerBound; // 0x0
	private short m_UpperBound; // 0x2

	// Properties
	public short lowerBound { get; }
	public short upperBound { get; }
	public static SortingLayerRange all { get; }

	// Methods

	// RVA: 0x691550 Offset: 0x68FF50 VA: 0x180691550
	public void .ctor(short lowerBound, short upperBound) { }

	// RVA: 0x2CFDB00 Offset: 0x2CFC500 VA: 0x182CFDB00
	public short get_lowerBound() { }

	// RVA: 0x2CFDB10 Offset: 0x2CFC510 VA: 0x182CFDB10
	public short get_upperBound() { }

	// RVA: 0x2CFDAF0 Offset: 0x2CFC4F0 VA: 0x182CFDAF0
	public static SortingLayerRange get_all() { }

	// RVA: 0x2CFDA10 Offset: 0x2CFC410 VA: 0x182CFDA10 Slot: 4
	public bool Equals(SortingLayerRange other) { }

	// RVA: 0x2CFDA30 Offset: 0x2CFC430 VA: 0x182CFDA30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CFDAE0 Offset: 0x2CFC4E0 VA: 0x182CFDAE0 Slot: 2
	public override int GetHashCode() { }
}
