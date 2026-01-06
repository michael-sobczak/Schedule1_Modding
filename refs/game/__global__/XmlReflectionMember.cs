public class XmlReflectionMember // TypeDefIndex: 8185
{
	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x254B7B0 Offset: 0x254A1B0 VA: 0x18254B7B0
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IsReturnValue() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_MemberName() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Type get_MemberType() { }

	// RVA: 0x254B820 Offset: 0x254A220 VA: 0x18254B820
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal Type get_DeclaringType() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_DeclaringType(Type value) { }
}
