internal abstract class XPathNodeHelper // TypeDefIndex: 8614
{
	// Methods

	// RVA: 0x24BAF10 Offset: 0x24B9910 VA: 0x1824BAF10
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x24BADD0 Offset: 0x24B97D0 VA: 0x1824BADD0
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x24BAD50 Offset: 0x24B9750 VA: 0x1824BAD50
	public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x24BAFE0 Offset: 0x24B99E0 VA: 0x1824BAFE0
	public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x24BA2B0 Offset: 0x24B8CB0 VA: 0x1824BA2B0
	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x24BA680 Offset: 0x24B9080 VA: 0x1824BA680
	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x24BB1A0 Offset: 0x24B9BA0 VA: 0x1824BB1A0
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x24BAFA0 Offset: 0x24B99A0 VA: 0x1824BAFA0
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x24BA740 Offset: 0x24B9140 VA: 0x1824BA740
	public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x24BAC10 Offset: 0x24B9610 VA: 0x1824BAC10
	public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x24BA130 Offset: 0x24B8B30 VA: 0x1824BA130
	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	// RVA: 0x24BA540 Offset: 0x24B8F40 VA: 0x1824BA540
	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	// RVA: 0x24B9F30 Offset: 0x24B8930 VA: 0x1824B9F30
	public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x24BA8B0 Offset: 0x24B92B0 VA: 0x1824BA8B0
	public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x24BA3E0 Offset: 0x24B8DE0 VA: 0x1824BA3E0
	public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x24BB240 Offset: 0x24B9C40 VA: 0x1824BB240
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x24BB0A0 Offset: 0x24B9AA0 VA: 0x1824BB0A0
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x24BA0D0 Offset: 0x24B8AD0 VA: 0x1824BA0D0
	private static void GetChild(ref XPathNode[] pageNode, ref int idxNode) { }
}
