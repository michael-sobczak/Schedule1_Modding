internal class Asttree // TypeDefIndex: 8238
{
	// Fields
	private ArrayList _fAxisArray; // 0x10
	private string _xpathexpr; // 0x18
	private bool _isField; // 0x20
	private XmlNamespaceManager _nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x255B900 Offset: 0x255A300 VA: 0x18255B900
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x255B770 Offset: 0x255A170 VA: 0x18255B770
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x255B710 Offset: 0x255A110 VA: 0x18255B710
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x255B740 Offset: 0x255A140 VA: 0x18255B740
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x255B7A0 Offset: 0x255A1A0 VA: 0x18255B7A0
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x255AE50 Offset: 0x2559850 VA: 0x18255AE50
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x255B7D0 Offset: 0x255A1D0 VA: 0x18255B7D0
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }
}
