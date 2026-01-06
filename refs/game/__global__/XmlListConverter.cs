internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 8511
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x2471090 Offset: 0x246FA90 VA: 0x182471090
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x2476C90 Offset: 0x2475690 VA: 0x182476C90
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x2476D10 Offset: 0x2475710 VA: 0x182476D10
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x24760B0 Offset: 0x2474AB0 VA: 0x1824760B0
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x2475C60 Offset: 0x2474660 VA: 0x182475C60 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2474BE0 Offset: 0x24735E0 VA: 0x182474BE0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2476280 Offset: 0x2474C80 VA: 0x182476280
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7E310 Offset: 0xF7CD10 VA: 0x180F7E310
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0xF7E8B0 Offset: 0xF7D2B0 VA: 0x180F7E8B0
	|-XmlListConverter.ToArray<byte>
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0xF7F3F0 Offset: 0xF7DDF0 VA: 0x180F7F3F0
	|-XmlListConverter.ToArray<DateTime>
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0xF7EE50 Offset: 0xF7D850 VA: 0x180F7EE50
	|-XmlListConverter.ToArray<DateTimeOffset>
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0xF7F990 Offset: 0xF7E390 VA: 0x180F7F990
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0xF80500 Offset: 0xF7EF00 VA: 0x180F80500
	|-XmlListConverter.ToArray<short>
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0xF80AA0 Offset: 0xF7F4A0 VA: 0x180F80AA0
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0xF81040 Offset: 0xF7FA40 VA: 0x180F81040
	|-XmlListConverter.ToArray<long>
	|-XmlListConverter.ToArray<ulong>
	|
	|-RVA: 0xF815E0 Offset: 0xF7FFE0 VA: 0x180F815E0
	|-XmlListConverter.ToArray<object>
	|
	|-RVA: 0xF81B80 Offset: 0xF80580 VA: 0x180F81B80
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0xF82120 Offset: 0xF80B20 VA: 0x180F82120
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0xF7FF30 Offset: 0xF7E930 VA: 0x180F7FF30
	|-XmlListConverter.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2476770 Offset: 0x2475170 VA: 0x182476770
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24766D0 Offset: 0x24750D0 VA: 0x1824766D0
	private List<string> StringAsList(string value) { }

	// RVA: 0x2476430 Offset: 0x2474E30 VA: 0x182476430
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2475DA0 Offset: 0x24747A0 VA: 0x182475DA0
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }
}
