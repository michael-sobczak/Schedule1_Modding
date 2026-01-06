public class RVOQuadtree // TypeDefIndex: 13425
{
	// Fields
	private const int LeafSize = 15;
	private float maxRadius; // 0x10
	private RVOQuadtree.Node[] nodes; // 0x18
	private int filledNodes; // 0x20
	private Rect bounds; // 0x24

	// Methods

	// RVA: 0xBC6670 Offset: 0xBC5070 VA: 0x180BC6670
	public void Clear() { }

	// RVA: 0x8735A0 Offset: 0x871FA0 VA: 0x1808735A0
	public void SetBounds(Rect r) { }

	// RVA: 0xBC6CA0 Offset: 0xBC56A0 VA: 0x180BC6CA0
	private int GetNodeIndex() { }

	// RVA: 0xBC6F10 Offset: 0xBC5910 VA: 0x180BC6F10
	public void Insert(Agent agent) { }

	// RVA: 0xBC6630 Offset: 0xBC5030 VA: 0x180BC6630
	public void CalculateSpeeds() { }

	// RVA: 0xBC73E0 Offset: 0xBC5DE0 VA: 0x180BC73E0
	public void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, Agent agent) { }

	// RVA: 0xBC6C70 Offset: 0xBC5670 VA: 0x180BC6C70
	public void DebugDraw() { }

	// RVA: 0xBC66B0 Offset: 0xBC50B0 VA: 0x180BC66B0
	private void DebugDrawRec(int i, Rect r) { }

	// RVA: 0xBC7470 Offset: 0xBC5E70 VA: 0x180BC7470
	public void .ctor() { }
}
