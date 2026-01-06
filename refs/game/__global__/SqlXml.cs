public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 13030
{
	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0x20FFA30 Offset: 0x20FE430 VA: 0x1820FFA30
	public void .ctor() { }

	// RVA: 0x20FEFF0 Offset: 0x20FD9F0 VA: 0x1820FEFF0
	public XmlReader CreateReader() { }

	// RVA: 0x20FF2B0 Offset: 0x20FDCB0 VA: 0x1820FF2B0
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0x20FF1C0 Offset: 0x20FDBC0 VA: 0x1820FF1C0
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x20FFA70 Offset: 0x20FE470 VA: 0x1820FFA70
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x20FD430 Offset: 0x20FBE30 VA: 0x1820FD430 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20FF4A0 Offset: 0x20FDEA0 VA: 0x1820FF4A0
	private void SetNull() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20FF4D0 Offset: 0x20FDED0 VA: 0x1820FF4D0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x20FF6D0 Offset: 0x20FE0D0 VA: 0x1820FF6D0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20FF430 Offset: 0x20FDE30 VA: 0x1820FF430
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20FF820 Offset: 0x20FE220 VA: 0x1820FF820
	private static void .cctor() { }
}
