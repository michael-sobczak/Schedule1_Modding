public struct DepthState : IEquatable<DepthState> // TypeDefIndex: 12244
{
	// Fields
	private byte m_WriteEnabled; // 0x0
	private sbyte m_CompareFunction; // 0x1

	// Properties
	public static DepthState defaultValue { get; }
	public CompareFunction compareFunction { get; }

	// Methods

	// RVA: 0x2CDEF80 Offset: 0x2CDD980 VA: 0x182CDEF80
	public static DepthState get_defaultValue() { }

	// RVA: 0x2CDEF00 Offset: 0x2CDD900 VA: 0x182CDEF00
	public void .ctor(bool writeEnabled = True, CompareFunction compareFunction = 2) { }

	// RVA: 0x2CDEF70 Offset: 0x2CDD970 VA: 0x182CDEF70
	public CompareFunction get_compareFunction() { }

	// RVA: 0x2CDEEA0 Offset: 0x2CDD8A0 VA: 0x182CDEEA0 Slot: 4
	public bool Equals(DepthState other) { }

	// RVA: 0x2CDEDF0 Offset: 0x2CDD7F0 VA: 0x182CDEDF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CDEEC0 Offset: 0x2CDD8C0 VA: 0x182CDEEC0 Slot: 2
	public override int GetHashCode() { }
}
