internal sealed class SimpleType : ISerializable // TypeDefIndex: 12983
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0x20A5FB0 Offset: 0x20A49B0 VA: 0x1820A5FB0
	internal void .ctor(string baseType) { }

	// RVA: 0x20A6100 Offset: 0x20A4B00 VA: 0x1820A6100
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0x20A59F0 Offset: 0x20A43F0 VA: 0x1820A59F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20A5120 Offset: 0x20A3B20 VA: 0x1820A5120
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0x20A5010 Offset: 0x20A3A10 VA: 0x1820A5010
	internal bool IsPlainString() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal string get_BaseType() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal string get_Name() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal string get_Namespace() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	internal int get_Length() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal int get_MaxLength() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	internal void set_MaxLength(int value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0x20A62F0 Offset: 0x20A4CF0 VA: 0x1820A62F0
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0x20A5980 Offset: 0x20A4380 VA: 0x1820A5980
	internal string QualifiedName(string name) { }

	// RVA: 0x20A5A30 Offset: 0x20A4430 VA: 0x1820A5A30
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0x20A4D10 Offset: 0x20A3710 VA: 0x1820A4D10
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0x20A4CB0 Offset: 0x20A36B0 VA: 0x1820A4CB0
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0x20A4D90 Offset: 0x20A3790 VA: 0x1820A4D90
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0x20A4E10 Offset: 0x20A3810 VA: 0x1820A4E10
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0x20A4EF0 Offset: 0x20A38F0 VA: 0x1820A4EF0
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0x20A4B70 Offset: 0x20A3570 VA: 0x1820A4B70
	internal bool CanHaveMaxLength() { }

	// RVA: 0x20A4BE0 Offset: 0x20A35E0 VA: 0x1820A4BE0
	internal void ConvertToAnnonymousSimpleType() { }
}
