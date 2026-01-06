public struct Int64 : IComparable, IConvertible, IFormattable, IComparable<long>, IEquatable<long>, ISpanFormattable // TypeDefIndex: 3674
{
	// Fields
	private readonly long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x1C66390 Offset: 0x1C64D90 VA: 0x181C66390 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C66480 Offset: 0x1C64E80 VA: 0x181C66480 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x1C664A0 Offset: 0x1C64EA0 VA: 0x181C664A0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x1C66530 Offset: 0x1C64F30 VA: 0x181C66530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C66CF0 Offset: 0x1C656F0 VA: 0x181C66CF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C66D70 Offset: 0x1C65770 VA: 0x181C66D70 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C66ED0 Offset: 0x1C658D0 VA: 0x181C66ED0
	public string ToString(string format) { }

	// RVA: 0x1C66E00 Offset: 0x1C65800 VA: 0x181C66E00 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C66F90 Offset: 0x1C65990 VA: 0x181C66F90 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C66630 Offset: 0x1C65030 VA: 0x181C66630
	public static long Parse(string s) { }

	// RVA: 0x1C66700 Offset: 0x1C65100 VA: 0x181C66700
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1C66540 Offset: 0x1C64F40 VA: 0x181C66540
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C67040 Offset: 0x1C65A40 VA: 0x181C67040
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x1C671B0 Offset: 0x1C65BB0 VA: 0x181C671B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xA141A0 Offset: 0xA12BA0 VA: 0x180A141A0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C667E0 Offset: 0x1C651E0 VA: 0x181C667E0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C66880 Offset: 0x1C65280 VA: 0x181C66880 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C66AC0 Offset: 0x1C654C0 VA: 0x181C66AC0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C66830 Offset: 0x1C65230 VA: 0x181C66830 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C66A20 Offset: 0x1C65420 VA: 0x181C66A20 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C66C00 Offset: 0x1C65600 VA: 0x181C66C00 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C66A70 Offset: 0x1C65470 VA: 0x181C66A70 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C66C50 Offset: 0x1C65650 VA: 0x181C66C50 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C66CA0 Offset: 0x1C656A0 VA: 0x181C66CA0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C66B10 Offset: 0x1C65510 VA: 0x181C66B10 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C669D0 Offset: 0x1C653D0 VA: 0x181C669D0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C66960 Offset: 0x1C65360 VA: 0x181C66960 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C668D0 Offset: 0x1C652D0 VA: 0x181C668D0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C66B60 Offset: 0x1C65560 VA: 0x181C66B60 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
