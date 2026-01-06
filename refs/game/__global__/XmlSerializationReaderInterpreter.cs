internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 8199
{
	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x2551E80 Offset: 0x2550880 VA: 0x182551E80
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x254C8C0 Offset: 0x254B2C0 VA: 0x18254C8C0 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x2551290 Offset: 0x254FC90 VA: 0x182551290
	public object ReadRoot() { }

	// RVA: 0x254D620 Offset: 0x254C020 VA: 0x18254D620
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x25505A0 Offset: 0x254EFA0 VA: 0x1825505A0 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x2551180 Offset: 0x254FB80 VA: 0x182551180
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x2550CE0 Offset: 0x254F6E0 VA: 0x182550CE0 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x254D310 Offset: 0x254BD10 VA: 0x18254D310 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x254D260 Offset: 0x254BC60 VA: 0x18254D260 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x254CD30 Offset: 0x254B730 VA: 0x18254CD30
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x254DFB0 Offset: 0x254C9B0 VA: 0x18254DFB0
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x2551930 Offset: 0x2550330 VA: 0x182551930
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x254C230 Offset: 0x254AC30 VA: 0x18254C230
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x254CCC0 Offset: 0x254B6C0 VA: 0x18254CCC0 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x254CCC0 Offset: 0x254B6C0 VA: 0x18254CCC0 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x254CC40 Offset: 0x254B640 VA: 0x18254CC40
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x2551BE0 Offset: 0x25505E0 VA: 0x182551BE0
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x2551AE0 Offset: 0x25504E0 VA: 0x182551AE0
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x254C6C0 Offset: 0x254B0C0 VA: 0x18254C6C0
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x2550B00 Offset: 0x254F500 VA: 0x182550B00
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x2550FF0 Offset: 0x254F9F0 VA: 0x182550FF0
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x254C790 Offset: 0x254B190 VA: 0x18254C790
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x254D810 Offset: 0x254C210 VA: 0x18254D810
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x254DD30 Offset: 0x254C730 VA: 0x18254DD30
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x254BA40 Offset: 0x254A440 VA: 0x18254BA40
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x254C100 Offset: 0x254AB00 VA: 0x18254C100
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x254C110 Offset: 0x254AB10 VA: 0x18254C110
	private object CreateInstance(Type type) { }

	// RVA: 0x254C170 Offset: 0x254AB70 VA: 0x18254C170
	private object CreateList(Type listType) { }

	// RVA: 0x254CBC0 Offset: 0x254B5C0 VA: 0x18254CBC0
	private object InitializeList(TypeData listType) { }

	// RVA: 0x254C210 Offset: 0x254AC10 VA: 0x18254C210
	private void FillList(object list, object items) { }

	// RVA: 0x254BDC0 Offset: 0x254A7C0 VA: 0x18254BDC0
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x2551540 Offset: 0x254FF40 VA: 0x182551540
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x2551570 Offset: 0x254FF70 VA: 0x182551570
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x2550F20 Offset: 0x254F920 VA: 0x182550F20
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x254D790 Offset: 0x254C190 VA: 0x18254D790
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x254C540 Offset: 0x254AF40 VA: 0x18254C540
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x2551730 Offset: 0x2550130 VA: 0x182551730
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x2551DA0 Offset: 0x25507A0 VA: 0x182551DA0
	private static void .cctor() { }
}
