public struct UInt32 : IComparable, IConvertible, IFormattable, IComparable<uint>, IEquatable<uint>, ISpanFormattable // TypeDefIndex: 3749
{
	// Fields
	private readonly uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x1C926D0 Offset: 0x1C910D0 VA: 0x181C926D0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C927C0 Offset: 0x1C911C0 VA: 0x181C927C0 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x1C927E0 Offset: 0x1C911E0 VA: 0x181C927E0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C932C0 Offset: 0x1C91CC0 VA: 0x181C932C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C93170 Offset: 0x1C91B70 VA: 0x181C93170 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C93200 Offset: 0x1C91C00 VA: 0x181C93200
	public string ToString(string format) { }

	// RVA: 0x1C930A0 Offset: 0x1C91AA0 VA: 0x181C930A0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C93340 Offset: 0x1C91D40 VA: 0x181C93340 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C92860 Offset: 0x1C91260 VA: 0x181C92860
	public static uint Parse(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1C92920 Offset: 0x1C91320 VA: 0x181C92920
	public static uint Parse(string s, NumberStyles style) { }

	[CLSCompliant(False)]
	// RVA: 0x1C929F0 Offset: 0x1C913F0 VA: 0x181C929F0
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C92AC0 Offset: 0x1C914C0 VA: 0x181C92AC0
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C934D0 Offset: 0x1C91ED0 VA: 0x181C934D0
	public static bool TryParse(string s, out uint result) { }

	[CLSCompliant(False)]
	// RVA: 0x1C933E0 Offset: 0x1C91DE0 VA: 0x181C933E0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C92BA0 Offset: 0x1C915A0 VA: 0x181C92BA0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C92C40 Offset: 0x1C91640 VA: 0x181C92C40 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C92ED0 Offset: 0x1C918D0 VA: 0x181C92ED0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C92BF0 Offset: 0x1C915F0 VA: 0x181C92BF0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C92DE0 Offset: 0x1C917E0 VA: 0x181C92DE0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C93000 Offset: 0x1C91A00 VA: 0x181C93000 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C92E30 Offset: 0x1C91830 VA: 0x181C92E30 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C92E80 Offset: 0x1C91880 VA: 0x181C92E80 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C93050 Offset: 0x1C91A50 VA: 0x181C93050 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C92F20 Offset: 0x1C91920 VA: 0x181C92F20 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C92D90 Offset: 0x1C91790 VA: 0x181C92D90 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C92D20 Offset: 0x1C91720 VA: 0x181C92D20 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C92C90 Offset: 0x1C91690 VA: 0x181C92C90 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C92F70 Offset: 0x1C91970 VA: 0x181C92F70 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
