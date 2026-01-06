public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 8196
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x2552EF0 Offset: 0x25518F0 VA: 0x182552EF0
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x2552960 Offset: 0x2551360 VA: 0x182552960
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x25529B0 Offset: 0x25513B0 VA: 0x1825529B0
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x2557060 Offset: 0x2555A60 VA: 0x182557060
	protected XmlDocument get_Document() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	protected XmlReader get_Reader() { }

	// RVA: 0x2551ED0 Offset: 0x25508D0 VA: 0x182551ED0
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x2552090 Offset: 0x2550A90 VA: 0x182552090
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x2551FF0 Offset: 0x25509F0 VA: 0x182551FF0
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x2552130 Offset: 0x2550B30 VA: 0x182552130
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x25522A0 Offset: 0x2550CA0 VA: 0x1825522A0
	protected void AddTarget(string id, object o) { }

	// RVA: 0x2552700 Offset: 0x2551100 VA: 0x182552700
	private string CurrentTag() { }

	// RVA: 0x2552400 Offset: 0x2550E00 VA: 0x182552400
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x2552480 Offset: 0x2550E80 VA: 0x182552480
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x2552500 Offset: 0x2550F00 VA: 0x182552500
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x2552580 Offset: 0x2550F80 VA: 0x182552580
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x25528C0 Offset: 0x25512C0 VA: 0x1825528C0
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x2552B00 Offset: 0x2551500 VA: 0x182552B00
	protected bool GetNullAttr() { }

	// RVA: 0x2552BE0 Offset: 0x25515E0 VA: 0x182552BE0
	protected object GetTarget(string id) { }

	// RVA: 0x2556950 Offset: 0x2555350 VA: 0x182556950
	private bool TargetReady(string id) { }

	// RVA: 0x2552CC0 Offset: 0x25516C0 VA: 0x182552CC0
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x2553380 Offset: 0x2551D80 VA: 0x182553380
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x25539E0 Offset: 0x25523E0 VA: 0x1825539E0
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x2553BA0 Offset: 0x25525A0 VA: 0x182553BA0
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x2553CC0 Offset: 0x25526C0 VA: 0x182553CC0
	protected void ReadEndElement() { }

	// RVA: 0x25542C0 Offset: 0x2552CC0 VA: 0x1825542C0
	protected bool ReadNull() { }

	// RVA: 0x25544B0 Offset: 0x2552EB0 VA: 0x1825544B0
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x25544E0 Offset: 0x2552EE0 VA: 0x1825544E0
	protected string ReadNullableString() { }

	// RVA: 0x2554840 Offset: 0x2553240 VA: 0x182554840
	protected object ReadReferencedElement() { }

	// RVA: 0x2552A00 Offset: 0x2551400 VA: 0x182552A00
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x2554530 Offset: 0x2552F30 VA: 0x182554530
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x2553D90 Offset: 0x2552790 VA: 0x182553D90
	private bool ReadList(out object resultList) { }

	// RVA: 0x25548B0 Offset: 0x25532B0 VA: 0x1825548B0
	protected void ReadReferencedElements() { }

	// RVA: 0x2555790 Offset: 0x2554190 VA: 0x182555790
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x2555770 Offset: 0x2554170 VA: 0x182555770
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x2555820 Offset: 0x2554220 VA: 0x182555820
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x2555BD0 Offset: 0x25545D0 VA: 0x182555BD0
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x25566D0 Offset: 0x25550D0 VA: 0x1825566D0
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x2555DD0 Offset: 0x25547D0 VA: 0x182555DD0
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x2556820 Offset: 0x2555220 VA: 0x182556820
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x25566E0 Offset: 0x25550E0 VA: 0x1825566E0
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x2556890 Offset: 0x2555290 VA: 0x182556890
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x2556980 Offset: 0x2555380 VA: 0x182556980
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x2556BE0 Offset: 0x25555E0 VA: 0x182556BE0
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x2556D90 Offset: 0x2555790 VA: 0x182556D90
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x254CCC0 Offset: 0x254B6C0 VA: 0x18254CCC0
	protected void UnknownNode(object o) { }

	// RVA: 0x2556F40 Offset: 0x2555940 VA: 0x182556F40
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x2553400 Offset: 0x2551E00 VA: 0x182553400
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x2556FC0 Offset: 0x25559C0 VA: 0x182556FC0
	protected void UnreferencedObject(string id, object o) { }
}
