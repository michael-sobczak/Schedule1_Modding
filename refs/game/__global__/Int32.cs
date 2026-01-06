public struct Int32 : IComparable, IConvertible, IFormattable, IComparable<int>, IEquatable<int>, ISpanFormattable // TypeDefIndex: 3673
{
	// Fields
	private readonly int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x1C652B0 Offset: 0x1C63CB0 VA: 0x181C652B0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C653A0 Offset: 0x1C63DA0 VA: 0x181C653A0 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x1C653C0 Offset: 0x1C63DC0 VA: 0x181C653C0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C65D50 Offset: 0x1C64750 VA: 0x181C65D50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C65E60 Offset: 0x1C64860 VA: 0x181C65E60
	public string ToString(string format) { }

	// RVA: 0x1C65DD0 Offset: 0x1C647D0 VA: 0x181C65DD0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C65F20 Offset: 0x1C64920 VA: 0x181C65F20 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C65FF0 Offset: 0x1C649F0 VA: 0x181C65FF0 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C65440 Offset: 0x1C63E40 VA: 0x181C65440
	public static int Parse(string s) { }

	// RVA: 0x1C65770 Offset: 0x1C64170 VA: 0x181C65770
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x1C65690 Offset: 0x1C64090 VA: 0x181C65690
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1C65510 Offset: 0x1C63F10 VA: 0x181C65510
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C65600 Offset: 0x1C64000 VA: 0x181C65600
	public static int Parse(ReadOnlySpan<char> s, NumberStyles style = 7, IFormatProvider provider) { }

	// RVA: 0x1C66220 Offset: 0x1C64C20 VA: 0x181C66220
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x1C66130 Offset: 0x1C64B30 VA: 0x181C66130
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x1C66090 Offset: 0x1C64A90 VA: 0x181C66090
	public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C65850 Offset: 0x1C64250 VA: 0x181C65850 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C658F0 Offset: 0x1C642F0 VA: 0x181C658F0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C65B30 Offset: 0x1C64530 VA: 0x181C65B30 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C658A0 Offset: 0x1C642A0 VA: 0x181C658A0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C65A90 Offset: 0x1C64490 VA: 0x181C65A90 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C65C60 Offset: 0x1C64660 VA: 0x181C65C60 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C65CB0 Offset: 0x1C646B0 VA: 0x181C65CB0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C65AE0 Offset: 0x1C644E0 VA: 0x181C65AE0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C65D00 Offset: 0x1C64700 VA: 0x181C65D00 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C65B80 Offset: 0x1C64580 VA: 0x181C65B80 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C65A40 Offset: 0x1C64440 VA: 0x181C65A40 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C659D0 Offset: 0x1C643D0 VA: 0x181C659D0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C65940 Offset: 0x1C64340 VA: 0x181C65940 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C65BD0 Offset: 0x1C645D0 VA: 0x181C65BD0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
