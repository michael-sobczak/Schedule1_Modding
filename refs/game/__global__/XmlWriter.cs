public abstract class XmlWriter : IDisposable // TypeDefIndex: 8012
{
	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x24F93A0 Offset: 0x24F7DA0 VA: 0x1824F93A0
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: 0x24F9370 Offset: 0x24F7D70 VA: 0x1824F9370
	public void WriteStartElement(string localName) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x24F88E0 Offset: 0x24F72E0 VA: 0x1824F88E0
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x24F8950 Offset: 0x24F7350 VA: 0x1824F8950
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x24F89C0 Offset: 0x24F73C0 VA: 0x1824F89C0
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x24F8D30 Offset: 0x24F7730 VA: 0x1824F8D30 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x24F93D0 Offset: 0x24F7DD0 VA: 0x1824F93D0 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x24F8A20 Offset: 0x24F7420 VA: 0x1824F8A20 Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x24F8DE0 Offset: 0x24F77E0 VA: 0x1824F8DE0 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x24F8D60 Offset: 0x24F7760 VA: 0x1824F8D60
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x24F88C0 Offset: 0x24F72C0 VA: 0x1824F88C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x24F8880 Offset: 0x24F7280 VA: 0x1824F8880 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x24F87A0 Offset: 0x24F71A0 VA: 0x1824F87A0
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x24F8810 Offset: 0x24F7210 VA: 0x1824F8810
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
