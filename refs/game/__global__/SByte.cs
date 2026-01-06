public struct SByte : IComparable, IConvertible, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, ISpanFormattable // TypeDefIndex: 3718
{
	// Fields
	private readonly sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x1C84A60 Offset: 0x1C83460 VA: 0x181C84A60 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1C84A50 Offset: 0x1C83450 VA: 0x181C84A50 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x1C84B40 Offset: 0x1C83540 VA: 0x181C84B40 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x1BBCBC0 Offset: 0x1BBB5C0 VA: 0x181BBCBC0 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x1C84BD0 Offset: 0x1C835D0 VA: 0x181C84BD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C855B0 Offset: 0x1C83FB0 VA: 0x181C855B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C85520 Offset: 0x1C83F20 VA: 0x181C85520 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1C85390 Offset: 0x1C83D90 VA: 0x181C85390 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1C85630 Offset: 0x1C84030 VA: 0x181C85630 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C84BE0 Offset: 0x1C835E0 VA: 0x181C84BE0
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1C84E10 Offset: 0x1C83810 VA: 0x181C84E10
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1C84C80 Offset: 0x1C83680 VA: 0x181C84C80
	private static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliant(False)]
	// RVA: 0x1C85830 Offset: 0x1C84230 VA: 0x181C85830
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x1C85760 Offset: 0x1C84160 VA: 0x181C85760
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1C84EC0 Offset: 0x1C838C0 VA: 0x181C84EC0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1C84F60 Offset: 0x1C83960 VA: 0x181C84F60 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x4C5450 Offset: 0x4C3E50 VA: 0x1804C5450 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1C84F10 Offset: 0x1C83910 VA: 0x181C84F10 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1C85100 Offset: 0x1C83B00 VA: 0x181C85100 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1C852A0 Offset: 0x1C83CA0 VA: 0x181C852A0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1C85150 Offset: 0x1C83B50 VA: 0x181C85150 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1C852F0 Offset: 0x1C83CF0 VA: 0x181C852F0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1C85160 Offset: 0x1C83B60 VA: 0x181C85160 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1C85340 Offset: 0x1C83D40 VA: 0x181C85340 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1C851B0 Offset: 0x1C83BB0 VA: 0x181C851B0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1C850B0 Offset: 0x1C83AB0 VA: 0x181C850B0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1C85040 Offset: 0x1C83A40 VA: 0x181C85040 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1C84FB0 Offset: 0x1C839B0 VA: 0x181C84FB0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1C85200 Offset: 0x1C83C00 VA: 0x181C85200 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}
