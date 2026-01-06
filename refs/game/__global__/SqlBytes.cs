public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 13012
{
	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0x20E2F40 Offset: 0x20E1940 VA: 0x1820E2F40
	public void .ctor() { }

	// RVA: 0x20E3010 Offset: 0x20E1A10 VA: 0x1820E3010
	public void .ctor(byte[] buffer) { }

	// RVA: 0x20E2F80 Offset: 0x20E1980 VA: 0x1820E2F80
	public void .ctor(SqlBinary value) { }

	// RVA: 0x11012A0 Offset: 0x10FFCA0 VA: 0x1811012A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20E30A0 Offset: 0x20E1AA0 VA: 0x1820E30A0
	public byte[] get_Buffer() { }

	// RVA: 0x20E3230 Offset: 0x20E1C30 VA: 0x1820E3230
	public long get_Length() { }

	// RVA: 0x20E3310 Offset: 0x20E1D10 VA: 0x1820E3310
	public byte[] get_Value() { }

	// RVA: 0x20E2B70 Offset: 0x20E1570 VA: 0x1820E2B70
	public void SetNull() { }

	// RVA: 0x20E2900 Offset: 0x20E1300 VA: 0x1820E2900
	private void CopyStreamToBuffer() { }

	// RVA: 0x20E2A90 Offset: 0x20E1490 VA: 0x1820E2A90
	internal bool FStream() { }

	// RVA: 0x20E2B10 Offset: 0x20E1510 VA: 0x1820E2B10
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20E2BF0 Offset: 0x20E15F0 VA: 0x1820E2BF0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x20E2DB0 Offset: 0x20E17B0 VA: 0x1820E2DB0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20E2AA0 Offset: 0x20E14A0 VA: 0x1820E2AA0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20E2BB0 Offset: 0x20E15B0 VA: 0x1820E2BB0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20E32C0 Offset: 0x20E1CC0 VA: 0x1820E32C0
	public static SqlBytes get_Null() { }
}
