public class SingleNodeBlocker : VersionedMonoBehaviour // TypeDefIndex: 13331
{
	// Fields
	[CompilerGenerated]
	private GraphNode <lastBlocked>k__BackingField; // 0x28
	public BlockManager manager; // 0x30

	// Properties
	public GraphNode lastBlocked { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public GraphNode get_lastBlocked() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_lastBlocked(GraphNode value) { }

	// RVA: 0xB8E340 Offset: 0xB8CD40 VA: 0x180B8E340
	public void BlockAtCurrentPosition() { }

	// RVA: 0xB8E3A0 Offset: 0xB8CDA0 VA: 0x180B8E3A0
	public void BlockAt(Vector3 position) { }

	// RVA: 0xB8E760 Offset: 0xB8D160 VA: 0x180B8E760
	public void Block(GraphNode node) { }

	// RVA: 0xB8E950 Offset: 0xB8D350 VA: 0x180B8E950
	public void Unblock() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
