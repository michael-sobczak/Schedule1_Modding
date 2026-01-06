public class XmlQualifiedName // TypeDefIndex: 8122
{
	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x253D110 Offset: 0x253BB10 VA: 0x18253D110
	public void .ctor() { }

	// RVA: 0x253CF90 Offset: 0x253B990 VA: 0x18253CF90
	public void .ctor(string name) { }

	// RVA: 0x253D060 Offset: 0x253BA60 VA: 0x18253D060
	public void .ctor(string name, string ns) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Namespace() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x253C940 Offset: 0x253B340 VA: 0x18253C940 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x253D1E0 Offset: 0x253BBE0 VA: 0x18253D1E0
	public bool get_IsEmpty() { }

	// RVA: 0x253CCC0 Offset: 0x253B6C0 VA: 0x18253CCC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x253C610 Offset: 0x253B010 VA: 0x18253C610 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x253D220 Offset: 0x253BC20 VA: 0x18253D220
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x253D290 Offset: 0x253BC90 VA: 0x18253D290
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x253CD20 Offset: 0x253B720 VA: 0x18253CD20
	public static string ToString(string name, string ns) { }

	// RVA: 0x253C730 Offset: 0x253B130 VA: 0x18253C730
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x1273600 Offset: 0x1272000 VA: 0x181273600
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0x253CA40 Offset: 0x253B440 VA: 0x18253CA40
	internal void Init(string name, string ns) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void SetNamespace(string ns) { }

	// RVA: 0x253CD90 Offset: 0x253B790 VA: 0x18253CD90
	internal void Verify() { }

	// RVA: 0x253C510 Offset: 0x253AF10 VA: 0x18253C510
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x253CA80 Offset: 0x253B480 VA: 0x18253CA80
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x253C590 Offset: 0x253AF90 VA: 0x18253C590
	internal XmlQualifiedName Clone() { }

	// RVA: 0x253CE20 Offset: 0x253B820 VA: 0x18253CE20
	private static void .cctor() { }
}
