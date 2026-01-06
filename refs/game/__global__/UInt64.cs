public struct UInt64 : IComparable, IConvertible, IFormattable, IComparable<ulong>, IEquatable<ulong>, ISpanFormattable // TypeDefIndex: 3750
{
	// Fields
	private readonly ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x1C935D0 Offset: 0x1C91FD0 VA: 0x181C935D0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C935B0 Offset: 0x1C91FB0 VA: 0x181C935B0 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x1C936C0 Offset: 0x1C920C0 VA: 0x181C936C0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x1C93750 Offset: 0x1C92150 VA: 0x181C93750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C94100 Offset: 0x1C92B00 VA: 0x181C94100 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C94070 Offset: 0x1C92A70 VA: 0x181C94070 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C93EE0 Offset: 0x1C928E0 VA: 0x181C93EE0
	public string ToString(string format) { }

	// RVA: 0x1C93FA0 Offset: 0x1C929A0 VA: 0x181C93FA0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C94180 Offset: 0x1C92B80 VA: 0x181C94180 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C93830 Offset: 0x1C92230 VA: 0x181C93830
	public static ulong Parse(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1C93760 Offset: 0x1C92160 VA: 0x181C93760
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C938F0 Offset: 0x1C922F0 VA: 0x181C938F0
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C94330 Offset: 0x1C92D30 VA: 0x181C94330
	public static bool TryParse(string s, out ulong result) { }

	[CLSCompliant(False)]
	// RVA: 0x1C94230 Offset: 0x1C92C30 VA: 0x181C94230
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C939D0 Offset: 0x1C923D0 VA: 0x181C939D0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C93A70 Offset: 0x1C92470 VA: 0x181C93A70 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C93D00 Offset: 0x1C92700 VA: 0x181C93D00 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C93A20 Offset: 0x1C92420 VA: 0x181C93A20 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C93C10 Offset: 0x1C92610 VA: 0x181C93C10 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C93E40 Offset: 0x1C92840 VA: 0x181C93E40 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C93C60 Offset: 0x1C92660 VA: 0x181C93C60 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C93E90 Offset: 0x1C92890 VA: 0x181C93E90 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C93CB0 Offset: 0x1C926B0 VA: 0x181C93CB0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C93D50 Offset: 0x1C92750 VA: 0x181C93D50 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C93BC0 Offset: 0x1C925C0 VA: 0x181C93BC0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C93B50 Offset: 0x1C92550 VA: 0x181C93B50 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C93AC0 Offset: 0x1C924C0 VA: 0x181C93AC0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C93DA0 Offset: 0x1C927A0 VA: 0x181C93DA0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
