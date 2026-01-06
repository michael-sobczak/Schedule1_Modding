public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 3607
{
	// Fields
	private readonly bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0x1BBCBD0 Offset: 0x1BBB5D0 VA: 0x181BBCBD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BBD3E0 Offset: 0x1BBBDE0 VA: 0x181BBD3E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BBD430 Offset: 0x1BBBE30 VA: 0x181BBD430 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1BBCB30 Offset: 0x1BBB530 VA: 0x181BBCB30 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x1BBCBC0 Offset: 0x1BBB5C0 VA: 0x181BBCBC0 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x1BBCA30 Offset: 0x1BBB430 VA: 0x181BBCA30 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1BBCA10 Offset: 0x1BBB410 VA: 0x181BBCA10 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x1BBCCA0 Offset: 0x1BBB6A0 VA: 0x181BBCCA0
	public static bool Parse(string value) { }

	// RVA: 0x1BBCBE0 Offset: 0x1BBB5E0 VA: 0x181BBCBE0
	public static bool Parse(ReadOnlySpan<char> value) { }

	// RVA: 0x1BBDAE0 Offset: 0x1BBC4E0 VA: 0x181BBDAE0
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x1BBD640 Offset: 0x1BBC040 VA: 0x181BBD640
	public static bool TryParse(ReadOnlySpan<char> value, out bool result) { }

	// RVA: 0x1BBD4B0 Offset: 0x1BBBEB0 VA: 0x181BBD4B0
	private static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1BBCE20 Offset: 0x1BBB820 VA: 0x181BBCE20 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1BBCE80 Offset: 0x1BBB880 VA: 0x181BBCE80 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1BBD1A0 Offset: 0x1BBBBA0 VA: 0x181BBD1A0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1BBCE30 Offset: 0x1BBB830 VA: 0x181BBCE30 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1BBD0B0 Offset: 0x1BBBAB0 VA: 0x181BBD0B0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1BBD2F0 Offset: 0x1BBBCF0 VA: 0x181BBD2F0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1BBD100 Offset: 0x1BBBB00 VA: 0x181BBD100 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1BBD340 Offset: 0x1BBBD40 VA: 0x181BBD340 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1BBD150 Offset: 0x1BBBB50 VA: 0x181BBD150 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1BBD390 Offset: 0x1BBBD90 VA: 0x181BBD390 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1BBD1F0 Offset: 0x1BBBBF0 VA: 0x181BBD1F0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1BBD050 Offset: 0x1BBBA50 VA: 0x181BBD050 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1BBCFA0 Offset: 0x1BBB9A0 VA: 0x181BBCFA0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1BBCF10 Offset: 0x1BBB910 VA: 0x181BBCF10 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1BBD250 Offset: 0x1BBBC50 VA: 0x181BBD250 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1BBDBA0 Offset: 0x1BBC5A0 VA: 0x181BBDBA0
	private static void .cctor() { }
}
