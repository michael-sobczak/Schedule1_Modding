internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 8271
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x25938E0 Offset: 0x25922E0 VA: 0x1825938E0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x2593630 Offset: 0x2592030 VA: 0x182593630 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2593720 Offset: 0x2592120 VA: 0x182593720 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2593250 Offset: 0x2591C50 VA: 0x182593250 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x25932A0 Offset: 0x2591CA0 VA: 0x1825932A0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x25934B0 Offset: 0x2591EB0 VA: 0x1825934B0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
