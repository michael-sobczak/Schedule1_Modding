internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 8204
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x25719E0 Offset: 0x25703E0 VA: 0x1825719E0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x256DF60 Offset: 0x256C960 VA: 0x18256DF60 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x2571750 Offset: 0x2570150 VA: 0x182571750
	public void WriteRoot(object ob) { }

	// RVA: 0x2570A40 Offset: 0x256F440 VA: 0x182570A40 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x2570590 Offset: 0x256EF90 VA: 0x182570590 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x25708F0 Offset: 0x256F2F0 VA: 0x1825708F0 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x2570790 Offset: 0x256F190 VA: 0x182570790 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x2570840 Offset: 0x256F240 VA: 0x182570840 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x2570530 Offset: 0x256EF30 VA: 0x182570530
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x256E9B0 Offset: 0x256D3B0 VA: 0x18256E9B0
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x256EEA0 Offset: 0x256D8A0 VA: 0x18256EEA0
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x256D800 Offset: 0x256C200 VA: 0x18256D800
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x256E280 Offset: 0x256CC80 VA: 0x18256E280
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x256FF60 Offset: 0x256E960 VA: 0x18256FF60
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x256DBD0 Offset: 0x256C5D0 VA: 0x18256DBD0
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x25714F0 Offset: 0x256FEF0 VA: 0x1825714F0
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x2571260 Offset: 0x256FC60 VA: 0x182571260
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x256FC30 Offset: 0x256E630 VA: 0x18256FC30 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x256F510 Offset: 0x256DF10 VA: 0x18256F510
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x256D6C0 Offset: 0x256C0C0 VA: 0x18256D6C0
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x256E4D0 Offset: 0x256CED0 VA: 0x18256E4D0
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x2571210 Offset: 0x256FC10 VA: 0x182571210 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x256F430 Offset: 0x256DE30 VA: 0x18256F430 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x256D8D0 Offset: 0x256C2D0 VA: 0x18256D8D0
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x256D610 Offset: 0x256C010 VA: 0x18256D610
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }
}
