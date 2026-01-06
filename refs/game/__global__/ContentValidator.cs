internal class ContentValidator // TypeDefIndex: 8268
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x2562FC0 Offset: 0x25619C0 VA: 0x182562FC0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x2562FF0 Offset: 0x25619F0 VA: 0x182562FF0
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x2563060 Offset: 0x2561A60 VA: 0x182563060
	public bool get_PreserveWhitespace() { }

	// RVA: 0x1BBB9B0 Offset: 0x1BBA3B0 VA: 0x181BBB9B0 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x2563040 Offset: 0x2561A40 VA: 0x182563040
	public bool get_IsOpen() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	public void set_IsOpen(bool value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x2562E20 Offset: 0x2561820 VA: 0x182562E20 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x2562DA0 Offset: 0x25617A0 VA: 0x182562DA0
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x2562B00 Offset: 0x2561500 VA: 0x182562B00
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x2562E50 Offset: 0x2561850 VA: 0x182562E50
	private static void .cctor() { }
}
