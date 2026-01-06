public class BlockManager : VersionedMonoBehaviour // TypeDefIndex: 13330
{
	// Fields
	private Dictionary<GraphNode, List<SingleNodeBlocker>> blocked; // 0x28

	// Methods

	// RVA: 0xB7D620 Offset: 0xB7C020 VA: 0x180B7D620
	private void Start() { }

	// RVA: 0xB7D510 Offset: 0xB7BF10 VA: 0x180B7D510
	public bool NodeContainsAnyOf(GraphNode node, List<SingleNodeBlocker> selector) { }

	// RVA: 0xB7D400 Offset: 0xB7BE00 VA: 0x180B7D400
	public bool NodeContainsAnyExcept(GraphNode node, List<SingleNodeBlocker> selector) { }

	// RVA: 0xB7D120 Offset: 0xB7BB20 VA: 0x180B7D120
	public void InternalBlock(GraphNode node, SingleNodeBlocker blocker) { }

	// RVA: 0xB7D290 Offset: 0xB7BC90 VA: 0x180B7D290
	public void InternalUnblock(GraphNode node, SingleNodeBlocker blocker) { }

	// RVA: 0xB7D6F0 Offset: 0xB7C0F0 VA: 0x180B7D6F0
	public void .ctor() { }
}
