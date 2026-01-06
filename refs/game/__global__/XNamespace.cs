public sealed class XNamespace // TypeDefIndex: 18635
{
	// Fields
	private static XHashtable<WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private XHashtable<XName> _names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x23CA380 Offset: 0x23C8D80 VA: 0x1823CA380
	internal void .ctor(string namespaceName) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_NamespaceName() { }

	// RVA: 0x23C9EA0 Offset: 0x23C88A0 VA: 0x1823C9EA0
	public XName GetName(string localName) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23CA480 Offset: 0x23C8E80 VA: 0x1823CA480
	public static XNamespace get_None() { }

	// RVA: 0x23CA4E0 Offset: 0x23C8EE0 VA: 0x1823CA4E0
	public static XNamespace get_Xml() { }

	// RVA: 0x23CA540 Offset: 0x23C8F40 VA: 0x1823CA540
	public static XNamespace get_Xmlns() { }

	// RVA: 0x23CA310 Offset: 0x23C8D10 VA: 0x1823CA310
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x23CA5A0 Offset: 0x23C8FA0 VA: 0x1823CA5A0
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x23C9D00 Offset: 0x23C8700 VA: 0x1823C9D00
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x23C9F20 Offset: 0x23C8920 VA: 0x1823C9F20
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x10F4950 Offset: 0x10F3350 VA: 0x1810F4950
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x23C9C80 Offset: 0x23C8680 VA: 0x1823C9C80
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x23C9B70 Offset: 0x23C8570 VA: 0x1823C9B70
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }
}
