internal class XmlReaderIterator // TypeDefIndex: 10284
{
	// Fields
	private XmlReader reader; // 0x10
	private bool currentElementVisited; // 0x18

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XmlReader reader) { }

	// RVA: 0x46FF70 Offset: 0x46E970 VA: 0x18046FF70
	public bool GoToRoot(string tagName) { }

	// RVA: 0x470160 Offset: 0x46EB60 VA: 0x180470160
	public XmlReaderIterator.Node VisitCurrent() { }

	// RVA: 0x46FFD0 Offset: 0x46E9D0 VA: 0x18046FFD0
	public bool IsEmptyElement() { }

	// RVA: 0x46FE40 Offset: 0x46E840 VA: 0x18046FE40
	public bool GoToNextChild(XmlReaderIterator.Node node) { }

	// RVA: 0x470100 Offset: 0x46EB00 VA: 0x180470100
	public void SkipCurrentChildTree(XmlReaderIterator.Node node) { }

	// RVA: 0x470000 Offset: 0x46EA00 VA: 0x180470000
	public string ReadTextWithinElement() { }
}
