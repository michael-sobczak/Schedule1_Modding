public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 12182
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VertexAttribute <attribute>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VertexAttributeFormat <format>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <dimension>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <stream>k__BackingField; // 0xC

	// Properties
	public VertexAttribute attribute { get; set; }
	public VertexAttributeFormat format { get; set; }
	public int dimension { get; set; }
	public int stream { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public VertexAttribute get_attribute() { }

	[CompilerGenerated]
	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_attribute(VertexAttribute value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public VertexAttributeFormat get_format() { }

	[CompilerGenerated]
	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_format(VertexAttributeFormat value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_dimension() { }

	[CompilerGenerated]
	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_dimension(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_stream() { }

	[CompilerGenerated]
	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_stream(int value) { }

	// RVA: 0x1E0BAA0 Offset: 0x1E0A4A0 VA: 0x181E0BAA0
	public void .ctor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	// RVA: 0x2CEE0B0 Offset: 0x2CECAB0 VA: 0x182CEE0B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CEE090 Offset: 0x2CECA90 VA: 0x182CEE090 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CEDFD0 Offset: 0x2CEC9D0 VA: 0x182CEDFD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2C9B8C0 Offset: 0x2C9A2C0 VA: 0x182C9B8C0 Slot: 4
	public bool Equals(VertexAttributeDescriptor other) { }
}
