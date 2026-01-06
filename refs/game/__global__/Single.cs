public struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable // TypeDefIndex: 3720
{
	// Fields
	private readonly float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;
	internal const float NegativeZero = -0;

	// Methods

	[NonVersionable]
	// RVA: 0x1C85BC0 Offset: 0x1C845C0 VA: 0x181C85BC0
	public static bool IsFinite(float f) { }

	[NonVersionable]
	// RVA: 0x1C85BE0 Offset: 0x1C845E0 VA: 0x181C85BE0
	public static bool IsInfinity(float f) { }

	[NonVersionable]
	// RVA: 0x1C85C00 Offset: 0x1C84600 VA: 0x181C85C00
	public static bool IsNaN(float f) { }

	[NonVersionable]
	// RVA: 0x1C85C20 Offset: 0x1C84620 VA: 0x181C85C20
	public static bool IsNegativeInfinity(float f) { }

	[NonVersionable]
	// RVA: 0x1C85C40 Offset: 0x1C84640 VA: 0x181C85C40
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x1C859A0 Offset: 0x1C843A0 VA: 0x181C859A0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C85960 Offset: 0x1C84360 VA: 0x181C85960 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x1C85AF0 Offset: 0x1C844F0 VA: 0x181C85AF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C85AC0 Offset: 0x1C844C0 VA: 0x181C85AC0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x1C85BA0 Offset: 0x1C845A0 VA: 0x181C85BA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C86510 Offset: 0x1C84F10 VA: 0x181C86510 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C86490 Offset: 0x1C84E90 VA: 0x181C86490 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C86410 Offset: 0x1C84E10 VA: 0x181C86410
	public string ToString(string format) { }

	// RVA: 0x1C86580 Offset: 0x1C84F80 VA: 0x181C86580 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C86610 Offset: 0x1C85010 VA: 0x181C86610 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C85D40 Offset: 0x1C84740 VA: 0x181C85D40
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1C85C60 Offset: 0x1C84660 VA: 0x181C85C60
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C86900 Offset: 0x1C85300 VA: 0x181C86900
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x1C869A0 Offset: 0x1C853A0 VA: 0x181C869A0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x1C866D0 Offset: 0x1C850D0 VA: 0x181C866D0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x572F50 Offset: 0x571950 VA: 0x180572F50 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C85E10 Offset: 0x1C84810 VA: 0x181C85E10 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C85ED0 Offset: 0x1C848D0 VA: 0x181C85ED0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C861F0 Offset: 0x1C84BF0 VA: 0x181C861F0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C85E70 Offset: 0x1C84870 VA: 0x181C85E70 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C860D0 Offset: 0x1C84AD0 VA: 0x181C860D0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C862F0 Offset: 0x1C84CF0 VA: 0x181C862F0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C86130 Offset: 0x1C84B30 VA: 0x181C86130 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C86350 Offset: 0x1C84D50 VA: 0x181C86350 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C86190 Offset: 0x1C84B90 VA: 0x181C86190 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C863B0 Offset: 0x1C84DB0 VA: 0x181C863B0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C86070 Offset: 0x1C84A70 VA: 0x181C86070 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C85FF0 Offset: 0x1C849F0 VA: 0x181C85FF0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C85F60 Offset: 0x1C84960 VA: 0x181C85F60 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C86250 Offset: 0x1C84C50 VA: 0x181C86250 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
