public struct Double : IComparable, IConvertible, IFormattable, IComparable<double>, IEquatable<double>, ISpanFormattable // TypeDefIndex: 3622
{
	// Fields
	private readonly double m_value; // 0x0
	public const double MinValue = -1.7976931348623157E+308;
	public const double MaxValue = 1.7976931348623157E+308;
	public const double Epsilon = 5E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = NaN;
	internal const double NegativeZero = -0;

	// Methods

	[NonVersionable]
	// RVA: 0x1C5E010 Offset: 0x1C5CA10 VA: 0x181C5E010
	public static bool IsFinite(double d) { }

	[NonVersionable]
	// RVA: 0x1C5E040 Offset: 0x1C5CA40 VA: 0x181C5E040
	public static bool IsInfinity(double d) { }

	[NonVersionable]
	// RVA: 0x1C5E070 Offset: 0x1C5CA70 VA: 0x181C5E070
	public static bool IsNaN(double d) { }

	[NonVersionable]
	// RVA: 0x1C5E0C0 Offset: 0x1C5CAC0 VA: 0x181C5E0C0
	public static bool IsNegative(double d) { }

	[NonVersionable]
	// RVA: 0x1C5E0A0 Offset: 0x1C5CAA0 VA: 0x181C5E0A0
	public static bool IsNegativeInfinity(double d) { }

	[NonVersionable]
	// RVA: 0x1C5E0D0 Offset: 0x1C5CAD0 VA: 0x181C5E0D0
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x1C5DD50 Offset: 0x1C5C750 VA: 0x181C5DD50 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C5DE80 Offset: 0x1C5C880 VA: 0x181C5DE80 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x1C5DEE0 Offset: 0x1C5C8E0 VA: 0x181C5DEE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C5DFA0 Offset: 0x1C5C9A0 VA: 0x181C5DFA0 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x1C5DFE0 Offset: 0x1C5C9E0 VA: 0x181C5DFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C5EAA0 Offset: 0x1C5D4A0 VA: 0x181C5EAA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C5EA20 Offset: 0x1C5D420 VA: 0x181C5EA20
	public string ToString(string format) { }

	// RVA: 0x1C5E9A0 Offset: 0x1C5D3A0 VA: 0x181C5E9A0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C5EB10 Offset: 0x1C5D510 VA: 0x181C5EB10 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C5EBA0 Offset: 0x1C5D5A0 VA: 0x181C5EBA0 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C5E2C0 Offset: 0x1C5CCC0 VA: 0x181C5E2C0
	public static double Parse(string s) { }

	// RVA: 0x1C5E0F0 Offset: 0x1C5CAF0 VA: 0x181C5E0F0
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1C5E1D0 Offset: 0x1C5CBD0 VA: 0x181C5E1D0
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C5ED20 Offset: 0x1C5D720 VA: 0x181C5ED20
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x1C5EC60 Offset: 0x1C5D660 VA: 0x181C5EC60
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x1C5EDC0 Offset: 0x1C5D7C0 VA: 0x181C5EDC0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0xA3E8F0 Offset: 0xA3D2F0 VA: 0x180A3E8F0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C5E390 Offset: 0x1C5CD90 VA: 0x181C5E390 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C5E450 Offset: 0x1C5CE50 VA: 0x181C5E450 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C5E720 Offset: 0x1C5D120 VA: 0x181C5E720 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C5E3F0 Offset: 0x1C5CDF0 VA: 0x181C5E3F0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C5E600 Offset: 0x1C5D000 VA: 0x181C5E600 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C5E880 Offset: 0x1C5D280 VA: 0x181C5E880 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C5E660 Offset: 0x1C5D060 VA: 0x181C5E660 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C5E8E0 Offset: 0x1C5D2E0 VA: 0x181C5E8E0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C5E6C0 Offset: 0x1C5D0C0 VA: 0x181C5E6C0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C5E940 Offset: 0x1C5D340 VA: 0x181C5E940 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C5E780 Offset: 0x1C5D180 VA: 0x181C5E780 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C5E5F0 Offset: 0x1C5CFF0 VA: 0x181C5E5F0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C5E570 Offset: 0x1C5CF70 VA: 0x181C5E570 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C5E4E0 Offset: 0x1C5CEE0 VA: 0x181C5E4E0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C5E7E0 Offset: 0x1C5D1E0 VA: 0x181C5E7E0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
