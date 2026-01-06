internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 8274
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0x25764E0 Offset: 0x2574EE0 VA: 0x1825764E0
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x25759D0 Offset: 0x25743D0 VA: 0x1825759D0
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x2576600 Offset: 0x2575000 VA: 0x182576600 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0x25762F0 Offset: 0x2574CF0 VA: 0x1825762F0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2576390 Offset: 0x2574D90 VA: 0x182576390 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2575B40 Offset: 0x2574540 VA: 0x182575B40 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x2575B90 Offset: 0x2574590 VA: 0x182575B90 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x2575EF0 Offset: 0x25748F0 VA: 0x182575EF0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
