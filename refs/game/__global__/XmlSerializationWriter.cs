public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 8202
{
	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x255A750 Offset: 0x2559150 VA: 0x18255A750
	protected void .ctor() { }

	// RVA: 0x2557960 Offset: 0x2556360 VA: 0x182557960
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	protected XmlWriter get_Writer() { }

	// RVA: 0x2557100 Offset: 0x2555B00 VA: 0x182557100
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x25572F0 Offset: 0x2555CF0 VA: 0x1825572F0
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x2557370 Offset: 0x2555D70 VA: 0x182557370
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x2557410 Offset: 0x2555E10 VA: 0x182557410
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x2557490 Offset: 0x2555E90 VA: 0x182557490
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x2557550 Offset: 0x2555F50 VA: 0x182557550
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x2557230 Offset: 0x2555C30 VA: 0x182557230
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x2557670 Offset: 0x2556070 VA: 0x182557670
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x25577A0 Offset: 0x25561A0 VA: 0x1825577A0
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x2557BA0 Offset: 0x25565A0 VA: 0x182557BA0
	protected void TopLevelElement() { }

	// RVA: 0x2557EF0 Offset: 0x25568F0 VA: 0x182557EF0
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x2557EB0 Offset: 0x25568B0 VA: 0x182557EB0
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x255A590 Offset: 0x2558F90 VA: 0x18255A590
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x2557F30 Offset: 0x2556930 VA: 0x182557F30
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x2558020 Offset: 0x2556A20 VA: 0x182558020
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x2558310 Offset: 0x2556D10 VA: 0x182558310
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x2558110 Offset: 0x2556B10 VA: 0x182558110
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x2558330 Offset: 0x2556D30 VA: 0x182558330
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x2558350 Offset: 0x2556D50 VA: 0x182558350
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1E30840 Offset: 0x1E2F240 VA: 0x181E30840
	protected void WriteEndElement() { }

	// RVA: 0x25584F0 Offset: 0x2556EF0 VA: 0x1825584F0
	protected void WriteEndElement(object o) { }

	// RVA: 0x2558550 Offset: 0x2556F50 VA: 0x182558550
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x2558AA0 Offset: 0x25574A0 VA: 0x182558AA0
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x2558B50 Offset: 0x2557550 VA: 0x182558B50
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x2558BF0 Offset: 0x25575F0 VA: 0x182558BF0
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x2558C10 Offset: 0x2557610 VA: 0x182558C10
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x25588F0 Offset: 0x25572F0 VA: 0x1825588F0
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x25589C0 Offset: 0x25573C0 VA: 0x1825589C0
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x2558C40 Offset: 0x2557640 VA: 0x182558C40
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x25590F0 Offset: 0x2557AF0 VA: 0x1825590F0
	protected void WriteReferencedElements() { }

	// RVA: 0x2557AA0 Offset: 0x25564A0 VA: 0x182557AA0
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x2557BB0 Offset: 0x25565B0 VA: 0x182557BB0
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x2559360 Offset: 0x2557D60 VA: 0x182559360
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x2557270 Offset: 0x2555C70 VA: 0x182557270
	private void CheckReferenceQueue() { }

	// RVA: 0x2559620 Offset: 0x2558020 VA: 0x182559620
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x25594D0 Offset: 0x2557ED0 VA: 0x1825594D0
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x2559760 Offset: 0x2558160 VA: 0x182559760
	protected void WriteStartDocument() { }

	// RVA: 0x25597F0 Offset: 0x25581F0 VA: 0x1825597F0
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x25597C0 Offset: 0x25581C0 VA: 0x1825597C0
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x2559EB0 Offset: 0x25588B0 VA: 0x182559EB0
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x2559E80 Offset: 0x2558880 VA: 0x182559E80
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x2559820 Offset: 0x2558220 VA: 0x182559820
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x2559EE0 Offset: 0x25588E0 VA: 0x182559EE0
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x255A260 Offset: 0x2558C60 VA: 0x18255A260
	protected void WriteValue(string value) { }

	// RVA: 0x255A2A0 Offset: 0x2558CA0 VA: 0x18255A2A0
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x255A660 Offset: 0x2559060 VA: 0x18255A660
	protected void WriteXsiType(string name, string ns) { }
}
