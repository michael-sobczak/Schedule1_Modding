internal class BaseValidator // TypeDefIndex: 8241
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x255F380 Offset: 0x255DD80 VA: 0x18255F380
	public void .ctor(BaseValidator other) { }

	// RVA: 0x255F280 Offset: 0x255DC80 VA: 0x18255F280
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x255F4D0 Offset: 0x255DED0 VA: 0x18255F4D0
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Uri get_BaseUri() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_BaseUri(Uri value) { }

	// RVA: 0x255F450 Offset: 0x255DE50 VA: 0x18255F450
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x255F580 Offset: 0x255DF80 VA: 0x18255F580
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0x255EDA0 Offset: 0x255D7A0 VA: 0x18255EDA0
	public void ValidateText() { }

	// RVA: 0x255F120 Offset: 0x255DB20 VA: 0x18255F120
	public void ValidateWhitespace() { }

	// RVA: 0x255E740 Offset: 0x255D140 VA: 0x18255E740
	private void SaveTextValue(string value) { }

	// RVA: 0x255E8E0 Offset: 0x255D2E0 VA: 0x18255E8E0
	protected void SendValidationEvent(string code) { }

	// RVA: 0x255EC90 Offset: 0x255D690 VA: 0x18255EC90
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x255EAF0 Offset: 0x255D4F0 VA: 0x18255EAF0
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x255EA60 Offset: 0x255D460 VA: 0x18255EA60
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x255E940 Offset: 0x255D340 VA: 0x18255E940
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x255E7C0 Offset: 0x255D1C0 VA: 0x18255E7C0
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x255EC00 Offset: 0x255D600 VA: 0x18255EC00
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x255E3C0 Offset: 0x255CDC0 VA: 0x18255E3C0
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x255E590 Offset: 0x255CF90 VA: 0x18255E590
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x255E1E0 Offset: 0x255CBE0 VA: 0x18255E1E0
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }
}
