public struct Connection // TypeDefIndex: 13194
{
	// Fields
	public GraphNode node; // 0x0
	public uint cost; // 0x8
	public byte shapeEdge; // 0xC
	public const byte NoSharedEdge = 255;

	// Methods

	// RVA: 0xB16090 Offset: 0xB14A90 VA: 0x180B16090
	public void .ctor(GraphNode node, uint cost, byte shapeEdge = 255) { }

	// RVA: 0xB16050 Offset: 0xB14A50 VA: 0x180B16050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB15FB0 Offset: 0xB149B0 VA: 0x180B15FB0 Slot: 0
	public override bool Equals(object obj) { }
}
