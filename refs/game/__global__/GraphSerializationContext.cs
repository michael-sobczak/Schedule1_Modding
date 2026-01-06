public class GraphSerializationContext // TypeDefIndex: 13366
{
	// Fields
	private readonly GraphNode[] id2NodeMapping; // 0x10
	public readonly BinaryReader reader; // 0x18
	public readonly BinaryWriter writer; // 0x20
	public readonly uint graphIndex; // 0x28
	public readonly GraphMeta meta; // 0x30

	// Methods

	// RVA: 0xBA33F0 Offset: 0xBA1DF0 VA: 0x180BA33F0
	public void .ctor(BinaryReader reader, GraphNode[] id2NodeMapping, uint graphIndex, GraphMeta meta) { }

	// RVA: 0xBA33B0 Offset: 0xBA1DB0 VA: 0x180BA33B0
	public void .ctor(BinaryWriter writer) { }

	// RVA: 0xBA32D0 Offset: 0xBA1CD0 VA: 0x180BA32D0
	public void SerializeNodeReference(GraphNode node) { }

	// RVA: 0xBA2CC0 Offset: 0xBA16C0 VA: 0x180BA2CC0
	public GraphNode DeserializeNodeReference() { }

	// RVA: 0xBA3320 Offset: 0xBA1D20 VA: 0x180BA3320
	public void SerializeVector3(Vector3 v) { }

	// RVA: 0xBA31B0 Offset: 0xBA1BB0 VA: 0x180BA31B0
	public Vector3 DeserializeVector3() { }

	// RVA: 0xBA3250 Offset: 0xBA1C50 VA: 0x180BA3250
	public void SerializeInt3(Int3 v) { }

	// RVA: 0xBA2B20 Offset: 0xBA1520 VA: 0x180BA2B20
	public Int3 DeserializeInt3() { }

	// RVA: 0xBA2BE0 Offset: 0xBA15E0 VA: 0x180BA2BE0
	public int DeserializeInt(int defaultValue) { }

	// RVA: 0xBA2A40 Offset: 0xBA1440 VA: 0x180BA2A40
	public float DeserializeFloat(float defaultValue) { }

	// RVA: 0xBA2E00 Offset: 0xBA1800 VA: 0x180BA2E00
	public Object DeserializeUnityObject() { }
}
