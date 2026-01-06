internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 8270
{
	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x2563730 Offset: 0x2562130 VA: 0x182563730
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x25634C0 Offset: 0x2561EC0 VA: 0x1825634C0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2563520 Offset: 0x2561F20 VA: 0x182563520 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2563140 Offset: 0x2561B40 VA: 0x182563140 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x2563160 Offset: 0x2561B60 VA: 0x182563160 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x2563340 Offset: 0x2561D40 VA: 0x182563340 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
