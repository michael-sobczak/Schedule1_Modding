public class XmlNodeConverter : JsonConverter // TypeDefIndex: 11429
{
	// Fields
	internal static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = "#text";
	private const string CommentName = "#comment";
	private const string CDataName = "#cdata-section";
	private const string WhitespaceName = "#whitespace";
	private const string SignificantWhitespaceName = "#significant-whitespace";
	private const string DeclarationName = "?xml";
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	[Nullable(2)]
	[CompilerGenerated]
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Properties
	[Nullable(2)]
	public string DeserializeRootElementName { get; set; }
	public bool WriteArrayAttribute { get; set; }
	public bool OmitRootObject { get; set; }
	public bool EncodeSpecialCharacters { get; set; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_DeserializeRootElementName() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_DeserializeRootElementName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_WriteArrayAttribute() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void set_WriteArrayAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0xCD85E0 Offset: 0xCD6FE0 VA: 0x180CD85E0
	public bool get_OmitRootObject() { }

	[CompilerGenerated]
	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	public void set_OmitRootObject(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1DFCED0 Offset: 0x1DFB8D0 VA: 0x181DFCED0
	public bool get_EncodeSpecialCharacters() { }

	[CompilerGenerated]
	// RVA: 0x1DFCEE0 Offset: 0x1DFB8E0 VA: 0x181DFCEE0
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0x1DFCC00 Offset: 0x1DFB600 VA: 0x181DFCC00 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DFC890 Offset: 0x1DFB290 VA: 0x181DFC890
	private IXmlNode WrapXml(object value) { }

	// RVA: 0x1DF9580 Offset: 0x1DF7F80 VA: 0x181DF9580
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1DFAF50 Offset: 0x1DF9950 VA: 0x181DFAF50
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1DF8DE0 Offset: 0x1DF77E0 VA: 0x181DF8DE0
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1DF9170 Offset: 0x1DF7B70 VA: 0x181DF9170
	private bool IsArray(IXmlNode node) { }

	// RVA: 0x1DFB100 Offset: 0x1DF9B00 VA: 0x181DFB100
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x1DFC9A0 Offset: 0x1DFB3A0 VA: 0x181DFC9A0
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0x1DFCB10 Offset: 0x1DFB510 VA: 0x181DFCB10
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0x1DFB800 Offset: 0x1DFA200 VA: 0x181DFB800
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x1DF6AB0 Offset: 0x1DF54B0 VA: 0x181DF6AB0
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0x1DFA7C0 Offset: 0x1DF91C0 VA: 0x181DFA7C0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DF8AD0 Offset: 0x1DF74D0 VA: 0x181DF8AD0
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0x1DFA3C0 Offset: 0x1DF8DC0 VA: 0x181DFA3C0
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0x1DF77C0 Offset: 0x1DF61C0 VA: 0x181DF77C0
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0x1DF6680 Offset: 0x1DF5080 VA: 0x181DF6680
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0x1DF6CF0 Offset: 0x1DF56F0 VA: 0x181DF6CF0
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0x1DF9A40 Offset: 0x1DF8440 VA: 0x181DF9A40
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0x1DF68B0 Offset: 0x1DF52B0 VA: 0x181DF68B0
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0x1DFC630 Offset: 0x1DFB030 VA: 0x181DFC630
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0x1DF9D10 Offset: 0x1DF8710 VA: 0x181DF9D10
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0x1DF7E10 Offset: 0x1DF6810 VA: 0x181DF7E10
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0x1DF73F0 Offset: 0x1DF5DF0 VA: 0x181DF73F0
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0x1DF7CD0 Offset: 0x1DF66D0 VA: 0x181DF7CD0
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0x1DF81B0 Offset: 0x1DF6BB0 VA: 0x181DF81B0
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0x1DF9370 Offset: 0x1DF7D70 VA: 0x181DF9370
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0x1DFC6C0 Offset: 0x1DFB0C0 VA: 0x181DFC6C0
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0x1DF6C40 Offset: 0x1DF5640 VA: 0x181DF6C40 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x1DF9460 Offset: 0x1DF7E60 VA: 0x181DF9460
	private bool IsXObject(Type valueType) { }

	// RVA: 0x1DF94F0 Offset: 0x1DF7EF0 VA: 0x181DF94F0
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x1DFCE40 Offset: 0x1DFB840 VA: 0x181DFCE40
	private static void .cctor() { }
}
