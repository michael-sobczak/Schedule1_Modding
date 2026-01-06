public struct Byte : IComparable, IConvertible, IFormattable, IComparable<byte>, IEquatable<byte>, ISpanFormattable // TypeDefIndex: 3608
{
	// Fields
	private readonly byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x1BBDC60 Offset: 0x1BBC660 VA: 0x181BBDC60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1BBDC50 Offset: 0x1BBC650 VA: 0x181BBDC50 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x1BBDD40 Offset: 0x1BBC740 VA: 0x181BBDD40 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x1BBCBC0 Offset: 0x1BBB5C0 VA: 0x181BBCBC0 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x4C5450 Offset: 0x4C3E50 VA: 0x1804C5450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BBDFC0 Offset: 0x1BBC9C0 VA: 0x181BBDFC0
	public static byte Parse(string s) { }

	// RVA: 0x1BBE110 Offset: 0x1BBCB10 VA: 0x181BBE110
	public static byte Parse(string s, NumberStyles style) { }

	// RVA: 0x1BBE060 Offset: 0x1BBCA60 VA: 0x181BBE060
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1BBDF00 Offset: 0x1BBC900 VA: 0x181BBDF00
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1BBDDD0 Offset: 0x1BBC7D0 VA: 0x181BBDDD0
	private static byte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1BBEB30 Offset: 0x1BBD530 VA: 0x181BBEB30
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x1BBEA80 Offset: 0x1BBD480 VA: 0x181BBEA80
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x1BBE950 Offset: 0x1BBD350 VA: 0x181BBE950 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BBE890 Offset: 0x1BBD290 VA: 0x181BBE890
	public string ToString(string format) { }

	// RVA: 0x1BBE730 Offset: 0x1BBD130 VA: 0x181BBE730 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1BBE7C0 Offset: 0x1BBD1C0 VA: 0x181BBE7C0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BBE9D0 Offset: 0x1BBD3D0 VA: 0x181BBE9D0 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1BBE1C0 Offset: 0x1BBCBC0 VA: 0x181BBE1C0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1BBE210 Offset: 0x1BBCC10 VA: 0x181BBE210 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1BBE4D0 Offset: 0x1BBCED0 VA: 0x181BBE4D0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x4C5450 Offset: 0x4C3E50 VA: 0x1804C5450 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1BBE3E0 Offset: 0x1BBCDE0 VA: 0x181BBE3E0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1BBE640 Offset: 0x1BBD040 VA: 0x181BBE640 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1BBE430 Offset: 0x1BBCE30 VA: 0x181BBE430 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1BBE690 Offset: 0x1BBD090 VA: 0x181BBE690 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1BBE480 Offset: 0x1BBCE80 VA: 0x181BBE480 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1BBE6E0 Offset: 0x1BBD0E0 VA: 0x181BBE6E0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1BBE550 Offset: 0x1BBCF50 VA: 0x181BBE550 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1BBE390 Offset: 0x1BBCD90 VA: 0x181BBE390 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1BBE2F0 Offset: 0x1BBCCF0 VA: 0x181BBE2F0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1BBE260 Offset: 0x1BBCC60 VA: 0x181BBE260 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1BBE5A0 Offset: 0x1BBCFA0 VA: 0x181BBE5A0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
