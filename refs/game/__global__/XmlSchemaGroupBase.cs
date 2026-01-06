public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 8453
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x244B860 Offset: 0x244A260 VA: 0x18244B860
	protected void .ctor() { }
}
