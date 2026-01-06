internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 7952
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x24C4800 Offset: 0x24C3200 VA: 0x1824C4800
	public void .ctor(XmlReader reader) { }

	// RVA: 0x24C47B0 Offset: 0x24C31B0 VA: 0x1824C47B0 Slot: 57
	public virtual bool HasLineInfo() { }

	// RVA: 0x24C48B0 Offset: 0x24C32B0 VA: 0x1824C48B0 Slot: 58
	public virtual int get_LineNumber() { }

	// RVA: 0x24C4900 Offset: 0x24C3300 VA: 0x1824C4900 Slot: 59
	public virtual int get_LinePosition() { }
}
