internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 8345
{
	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x258D5E0 Offset: 0x258BFE0 VA: 0x18258D5E0
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x258B7E0 Offset: 0x258A1E0 VA: 0x18258B7E0
	private void Init() { }

	// RVA: 0x258D1E0 Offset: 0x258BBE0 VA: 0x18258D1E0 Slot: 5
	public override void Validate() { }

	// RVA: 0x258B950 Offset: 0x258A350 VA: 0x18258B950
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x258CCD0 Offset: 0x258B6D0 VA: 0x18258CCD0
	private void ValidatePIComment() { }

	// RVA: 0x258C4F0 Offset: 0x258AEF0 VA: 0x18258C4F0
	private void ValidateElement() { }

	// RVA: 0x258C320 Offset: 0x258AD20 VA: 0x18258C320
	private void ValidateChildElement() { }

	// RVA: 0x258CD80 Offset: 0x258B780 VA: 0x18258CD80
	private void ValidateStartElement() { }

	// RVA: 0x258CB10 Offset: 0x258B510 VA: 0x18258CB10
	private void ValidateEndStartElement() { }

	// RVA: 0x258BAC0 Offset: 0x258A4C0 VA: 0x18258BAC0
	private void ProcessElement() { }

	// RVA: 0x258B390 Offset: 0x2589D90 VA: 0x18258B390 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x258C900 Offset: 0x258B300 VA: 0x18258C900
	private void ValidateEndElement() { }

	// RVA: 0x2443320 Offset: 0x2441D20 VA: 0x182443320 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x258BC20 Offset: 0x258A620 VA: 0x18258BC20
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x258AEA0 Offset: 0x25898A0 VA: 0x18258AEA0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x258A950 Offset: 0x2589350 VA: 0x18258A950
	internal void AddID(string name, object node) { }

	// RVA: 0x258B510 Offset: 0x2589F10 VA: 0x18258B510 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x258B540 Offset: 0x2589F40 VA: 0x18258B540
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x258B730 Offset: 0x258A130 VA: 0x18258B730
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x258AD50 Offset: 0x2589750 VA: 0x18258AD50
	private void CheckForwardRefs() { }

	// RVA: 0x258BEF0 Offset: 0x258A8F0 VA: 0x18258BEF0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x258B9E0 Offset: 0x258A3E0 VA: 0x18258B9E0
	private bool Pop() { }

	// RVA: 0x258C060 Offset: 0x258AA60 VA: 0x18258C060
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x258AA10 Offset: 0x2589410 VA: 0x18258AA10
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x258D560 Offset: 0x258BF60 VA: 0x18258D560
	private static void .cctor() { }
}
