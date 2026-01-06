internal struct ElementWriter // TypeDefIndex: 18628
{
	// Fields
	private XmlWriter _writer; // 0x0
	private NamespaceResolver _resolver; // 0x8

	// Methods

	// RVA: 0x23C26E0 Offset: 0x23C10E0 VA: 0x1823C26E0
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x23C2140 Offset: 0x23C0B40 VA: 0x1823C2140
	public void WriteElement(XElement e) { }

	// RVA: 0x23C1C80 Offset: 0x23C0680 VA: 0x1823C1C80
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x23C1D70 Offset: 0x23C0770 VA: 0x1823C1D70
	private void PushAncestors(XElement e) { }

	// RVA: 0x23C1F90 Offset: 0x23C0990 VA: 0x1823C1F90
	private void PushElement(XElement e) { }

	// RVA: 0x23C2350 Offset: 0x23C0D50 VA: 0x1823C2350
	private void WriteEndElement() { }

	// RVA: 0x23C2390 Offset: 0x23C0D90 VA: 0x1823C2390
	private void WriteFullEndElement() { }

	// RVA: 0x23C23D0 Offset: 0x23C0DD0 VA: 0x1823C23D0
	private void WriteStartElement(XElement e) { }
}
