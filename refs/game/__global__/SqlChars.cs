public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 13013
{
	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0x20E2F40 Offset: 0x20E1940 VA: 0x1820E2F40
	public void .ctor() { }

	// RVA: 0x20E3010 Offset: 0x20E1A10 VA: 0x1820E3010
	public void .ctor(char[] buffer) { }

	// RVA: 0x20E3A70 Offset: 0x20E2470 VA: 0x1820E3A70
	public void .ctor(SqlString value) { }

	// RVA: 0x11012A0 Offset: 0x10FFCA0 VA: 0x1811012A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20E3B10 Offset: 0x20E2510 VA: 0x1820E3B10
	public char[] get_Buffer() { }

	// RVA: 0x20E3CA0 Offset: 0x20E26A0 VA: 0x1820E3CA0
	public long get_Length() { }

	// RVA: 0x20E3D80 Offset: 0x20E2780 VA: 0x1820E3D80
	public char[] get_Value() { }

	// RVA: 0x20E2B70 Offset: 0x20E1570 VA: 0x1820E2B70
	public void SetNull() { }

	// RVA: 0x20E2A90 Offset: 0x20E1490 VA: 0x1820E2A90
	internal bool FStream() { }

	// RVA: 0x20E3550 Offset: 0x20E1F50 VA: 0x1820E3550
	private void CopyStreamToBuffer() { }

	// RVA: 0x20E2B10 Offset: 0x20E1510 VA: 0x1820E2B10
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20E3790 Offset: 0x20E2190 VA: 0x1820E3790 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x20E3900 Offset: 0x20E2300 VA: 0x1820E3900 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20E36E0 Offset: 0x20E20E0 VA: 0x1820E36E0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20E3750 Offset: 0x20E2150 VA: 0x1820E3750 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20E3D30 Offset: 0x20E2730 VA: 0x1820E3D30
	public static SqlChars get_Null() { }
}
