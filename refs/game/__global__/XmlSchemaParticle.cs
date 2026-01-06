public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 8475
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[Xml("minOccurs")]
	public string MinOccursString { get; set; }
	[Xml("maxOccurs")]
	public string MaxOccursString { get; set; }
	[XmlIgnore]
	public Decimal MinOccurs { get; set; }
	[XmlIgnore]
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x2456250 Offset: 0x2454C50 VA: 0x182456250
	public string get_MinOccursString() { }

	// RVA: 0x24566F0 Offset: 0x24550F0 VA: 0x1824566F0
	public void set_MinOccursString(string value) { }

	// RVA: 0x2456130 Offset: 0x2454B30 VA: 0x182456130
	public string get_MaxOccursString() { }

	// RVA: 0x2456300 Offset: 0x2454D00 VA: 0x182456300
	public void set_MaxOccursString(string value) { }

	// RVA: 0x84E920 Offset: 0x84D320 VA: 0x18084E920
	public Decimal get_MinOccurs() { }

	// RVA: 0x2456860 Offset: 0x2455260 VA: 0x182456860
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x1D191B0 Offset: 0x1D17BB0 VA: 0x181D191B0
	public Decimal get_MaxOccurs() { }

	// RVA: 0x2456540 Offset: 0x2454F40 VA: 0x182456540
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x24560B0 Offset: 0x2454AB0 VA: 0x1824560B0 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x24562C0 Offset: 0x2454CC0 VA: 0x1824562C0 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x2455DA0 Offset: 0x24547A0 VA: 0x182455DA0
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x2456030 Offset: 0x2454A30 VA: 0x182456030
	protected void .ctor() { }

	// RVA: 0x2455F20 Offset: 0x2454920 VA: 0x182455F20
	private static void .cctor() { }
}
