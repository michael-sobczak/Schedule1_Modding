internal class EnumMap : ObjectMap // TypeDefIndex: 8227
{
	// Fields
	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	// Properties
	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }

	// Methods

	// RVA: 0x25640C0 Offset: 0x2562AC0 VA: 0x1825640C0
	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_IsFlags() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string[] get_EnumNames() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string[] get_XmlNames() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public long[] get_Values() { }

	// RVA: 0x2563D10 Offset: 0x2562710 VA: 0x182563D10
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x2563A10 Offset: 0x2562410 VA: 0x182563A10
	public string GetEnumName(string typeName, string xmlName) { }
}
