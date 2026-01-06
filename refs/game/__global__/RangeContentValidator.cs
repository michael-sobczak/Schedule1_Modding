internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 8273
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x2596050 Offset: 0x2594A50 VA: 0x182596050
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x2595560 Offset: 0x2593F60 VA: 0x182595560 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2595740 Offset: 0x2594140 VA: 0x182595740 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2595070 Offset: 0x2593A70 VA: 0x182595070 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x2595090 Offset: 0x2593A90 VA: 0x182595090 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x2595340 Offset: 0x2593D40 VA: 0x182595340 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
