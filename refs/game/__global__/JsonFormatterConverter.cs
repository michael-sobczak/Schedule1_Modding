internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 11248
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x1D84950 Offset: 0x1D83350 VA: 0x181D84950
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6300 Offset: 0xEE4D00 VA: 0x180EE6300
	|-JsonFormatterConverter.GetTokenValue<bool>
	|-JsonFormatterConverter.GetTokenValue<byte>
	|-JsonFormatterConverter.GetTokenValue<sbyte>
	|
	|-RVA: 0xEE64A0 Offset: 0xEE4EA0 VA: 0x180EE64A0
	|-JsonFormatterConverter.GetTokenValue<char>
	|-JsonFormatterConverter.GetTokenValue<short>
	|-JsonFormatterConverter.GetTokenValue<ushort>
	|
	|-RVA: 0xEE6640 Offset: 0xEE5040 VA: 0x180EE6640
	|-JsonFormatterConverter.GetTokenValue<DateTime>
	|-JsonFormatterConverter.GetTokenValue<long>
	|-JsonFormatterConverter.GetTokenValue<ulong>
	|
	|-RVA: 0xEE67E0 Offset: 0xEE51E0 VA: 0x180EE67E0
	|-JsonFormatterConverter.GetTokenValue<Decimal>
	|
	|-RVA: 0xEE6990 Offset: 0xEE5390 VA: 0x180EE6990
	|-JsonFormatterConverter.GetTokenValue<double>
	|
	|-RVA: 0xEE6D00 Offset: 0xEE5700 VA: 0x180EE6D00
	|-JsonFormatterConverter.GetTokenValue<int>
	|-JsonFormatterConverter.GetTokenValue<uint>
	|
	|-RVA: 0xEE6EA0 Offset: 0xEE58A0 VA: 0x180EE6EA0
	|-JsonFormatterConverter.GetTokenValue<object>
	|
	|-RVA: 0xEE7040 Offset: 0xEE5A40 VA: 0x180EE7040
	|-JsonFormatterConverter.GetTokenValue<float>
	|
	|-RVA: 0xEE6B30 Offset: 0xEE5530 VA: 0x180EE6B30
	|-JsonFormatterConverter.GetTokenValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D84310 Offset: 0x1D82D10 VA: 0x181D84310 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x1D841E0 Offset: 0x1D82BE0 VA: 0x181D841E0 Slot: 10
	public object Convert(object value, TypeCode typeCode) { }

	// RVA: 0x1D84480 Offset: 0x1D82E80 VA: 0x181D84480 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x1D844D0 Offset: 0x1D82ED0 VA: 0x181D844D0 Slot: 11
	public byte ToByte(object value) { }

	// RVA: 0x1D84520 Offset: 0x1D82F20 VA: 0x181D84520 Slot: 12
	public char ToChar(object value) { }

	// RVA: 0x1D84570 Offset: 0x1D82F70 VA: 0x181D84570 Slot: 13
	public DateTime ToDateTime(object value) { }

	// RVA: 0x1D845C0 Offset: 0x1D82FC0 VA: 0x181D845C0 Slot: 14
	public Decimal ToDecimal(object value) { }

	// RVA: 0x1D84630 Offset: 0x1D83030 VA: 0x181D84630 Slot: 15
	public double ToDouble(object value) { }

	// RVA: 0x1D84680 Offset: 0x1D83080 VA: 0x181D84680 Slot: 16
	public short ToInt16(object value) { }

	// RVA: 0x1D846D0 Offset: 0x1D830D0 VA: 0x181D846D0 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x1D84720 Offset: 0x1D83120 VA: 0x181D84720 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x1D84770 Offset: 0x1D83170 VA: 0x181D84770 Slot: 17
	public sbyte ToSByte(object value) { }

	// RVA: 0x1D847C0 Offset: 0x1D831C0 VA: 0x181D847C0 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x1D84810 Offset: 0x1D83210 VA: 0x181D84810 Slot: 9
	public string ToString(object value) { }

	// RVA: 0x1D84860 Offset: 0x1D83260 VA: 0x181D84860 Slot: 18
	public ushort ToUInt16(object value) { }

	// RVA: 0x1D848B0 Offset: 0x1D832B0 VA: 0x181D848B0 Slot: 19
	public uint ToUInt32(object value) { }

	// RVA: 0x1D84900 Offset: 0x1D83300 VA: 0x181D84900 Slot: 20
	public ulong ToUInt64(object value) { }
}
