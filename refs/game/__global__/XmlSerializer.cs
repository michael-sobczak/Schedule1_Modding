public class XmlSerializer // TypeDefIndex: 8206
{
	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0x2572CB0 Offset: 0x25716B0 VA: 0x182572CB0
	private static void .cctor() { }

	// RVA: 0x2572DB0 Offset: 0x25717B0 VA: 0x182572DB0
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal XmlMapping get_Mapping() { }

	// RVA: 0x230E5E0 Offset: 0x230CFE0 VA: 0x18230E5E0 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x2572700 Offset: 0x2571100 VA: 0x182572700 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x2572730 Offset: 0x2571130 VA: 0x182572730 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x21C7040 Offset: 0x21C5A40 VA: 0x1821C7040 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x2571F70 Offset: 0x2570970 VA: 0x182571F70 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x2572260 Offset: 0x2570C60 VA: 0x182572260 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x2572360 Offset: 0x2570D60 VA: 0x182572360
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x25722A0 Offset: 0x2570CA0 VA: 0x1825722A0
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x2572490 Offset: 0x2570E90 VA: 0x182572490 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x2572800 Offset: 0x2571200 VA: 0x182572800 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x2572760 Offset: 0x2571160 VA: 0x182572760
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x2572C90 Offset: 0x2571690 VA: 0x182572C90
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x25729F0 Offset: 0x25713F0 VA: 0x1825729F0
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x2571FB0 Offset: 0x25709B0 VA: 0x182571FB0
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x2571F10 Offset: 0x2570910 VA: 0x182571F10
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }
}
