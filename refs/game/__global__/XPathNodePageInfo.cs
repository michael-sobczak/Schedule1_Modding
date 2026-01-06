internal sealed class XPathNodePageInfo // TypeDefIndex: 8615
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_PageNumber() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_NodeCount() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public XPathNode[] get_NextPage() { }
}
