public abstract class XNode : XObject // TypeDefIndex: 18636
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x23CA8B0 Offset: 0x23C92B0 VA: 0x1823CA8B0
	public void Remove() { }

	// RVA: 0x23CA920 Offset: 0x23C9320 VA: 0x1823CA920 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x23CA5C0 Offset: 0x23C8FC0 VA: 0x1823CA5C0
	private string GetXmlString(SaveOptions o) { }
}
