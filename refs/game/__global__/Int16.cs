public struct Int16 : IComparable, IConvertible, IFormattable, IComparable<short>, IEquatable<short>, ISpanFormattable // TypeDefIndex: 3672
{
	// Fields
	private readonly short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x1C64350 Offset: 0x1C62D50 VA: 0x181C64350 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1C64430 Offset: 0x1C62E30 VA: 0x181C64430 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x1C64440 Offset: 0x1C62E40 VA: 0x181C64440 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0xC81950 Offset: 0xC80350 VA: 0x180C81950 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x1C644D0 Offset: 0x1C62ED0 VA: 0x181C644D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C64F10 Offset: 0x1C63910 VA: 0x181C64F10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C64E80 Offset: 0x1C63880 VA: 0x181C64E80 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C64CF0 Offset: 0x1C636F0 VA: 0x181C64CF0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C64F90 Offset: 0x1C63990 VA: 0x181C64F90 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C644E0 Offset: 0x1C62EE0 VA: 0x181C644E0
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1C64590 Offset: 0x1C62F90 VA: 0x181C64590
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C64650 Offset: 0x1C63050 VA: 0x181C64650
	private static short Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1C65190 Offset: 0x1C63B90 VA: 0x181C65190
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x1C650C0 Offset: 0x1C63AC0 VA: 0x181C650C0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C647E0 Offset: 0x1C631E0 VA: 0x181C647E0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C64880 Offset: 0x1C63280 VA: 0x181C64880 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1C64AC0 Offset: 0x1C634C0 VA: 0x181C64AC0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C64830 Offset: 0x1C63230 VA: 0x181C64830 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C64C00 Offset: 0x1C63600 VA: 0x181C64C00 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C64A20 Offset: 0x1C63420 VA: 0x181C64A20 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C64C50 Offset: 0x1C63650 VA: 0x181C64C50 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C64A70 Offset: 0x1C63470 VA: 0x181C64A70 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C64CA0 Offset: 0x1C636A0 VA: 0x181C64CA0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C64B10 Offset: 0x1C63510 VA: 0x181C64B10 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C649D0 Offset: 0x1C633D0 VA: 0x181C649D0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C64960 Offset: 0x1C63360 VA: 0x181C64960 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C648D0 Offset: 0x1C632D0 VA: 0x181C648D0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C64B60 Offset: 0x1C63560 VA: 0x181C64B60 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
