public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 18634
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x23C9A50 Offset: 0x23C8450 VA: 0x1823C9A50
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_LocalName() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public XNamespace get_Namespace() { }

	// RVA: 0x13C7AA0 Offset: 0x13C64A0 VA: 0x1813C7AA0
	public string get_NamespaceName() { }

	// RVA: 0x23C99C0 Offset: 0x23C83C0 VA: 0x1823C99C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23C96C0 Offset: 0x23C80C0 VA: 0x1823C96C0
	public static XName Get(string expandedName) { }

	// RVA: 0x23C9890 Offset: 0x23C8290 VA: 0x1823C9890
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x23C9B60 Offset: 0x23C8560 VA: 0x1823C9B60
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x23C9980 Offset: 0x23C8380 VA: 0x1823C9980 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x23C9B30 Offset: 0x23C8530 VA: 0x1823C9B30
	internal void .ctor() { }
}
