public struct UInt16 : IComparable, IConvertible, IFormattable, IComparable<ushort>, IEquatable<ushort>, ISpanFormattable // TypeDefIndex: 3748
{
	// Fields
	private readonly ushort m_value; // 0x0
	public const ushort MaxValue = 65535;
	public const ushort MinValue = 0;

	// Methods

	// RVA: 0x1C91990 Offset: 0x1C90390 VA: 0x181C91990 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1BBF4B0 Offset: 0x1BBDEB0 VA: 0x181BBF4B0 Slot: 23
	public int CompareTo(ushort value) { }

	// RVA: 0x1C91A70 Offset: 0x1C90470 VA: 0x181C91A70 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC81950 Offset: 0xC80350 VA: 0x180C81950 Slot: 24
	public bool Equals(ushort obj) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C92290 Offset: 0x1C90C90 VA: 0x181C92290 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C923E0 Offset: 0x1C90DE0 VA: 0x181C923E0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C92310 Offset: 0x1C90D10 VA: 0x181C92310 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C92470 Offset: 0x1C90E70 VA: 0x181C92470 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C91B00 Offset: 0x1C90500 VA: 0x181C91B00
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C91BA0 Offset: 0x1C905A0 VA: 0x181C91BA0
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C91C50 Offset: 0x1C90650 VA: 0x181C91C50
	private static ushort Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliant(False)]
	// RVA: 0x1C92520 Offset: 0x1C90F20 VA: 0x181C92520
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	// RVA: 0x1C92620 Offset: 0x1C91020 VA: 0x181C92620
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C91D80 Offset: 0x1C90780 VA: 0x181C91D80 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C91E20 Offset: 0x1C90820 VA: 0x181C91E20 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C920B0 Offset: 0x1C90AB0 VA: 0x181C920B0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C91DD0 Offset: 0x1C907D0 VA: 0x181C91DD0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C91FC0 Offset: 0x1C909C0 VA: 0x181C91FC0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C92010 Offset: 0x1C90A10 VA: 0x181C92010 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C921F0 Offset: 0x1C90BF0 VA: 0x181C921F0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C92060 Offset: 0x1C90A60 VA: 0x181C92060 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C92240 Offset: 0x1C90C40 VA: 0x181C92240 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C92100 Offset: 0x1C90B00 VA: 0x181C92100 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C91F70 Offset: 0x1C90970 VA: 0x181C91F70 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C91F00 Offset: 0x1C90900 VA: 0x181C91F00 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C91E70 Offset: 0x1C90870 VA: 0x181C91E70 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C92150 Offset: 0x1C90B50 VA: 0x181C92150 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
