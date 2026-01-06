public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible // TypeDefIndex: 7841
{
	// Fields
	private TypeCode m_Type; // 0x0
	private bool m_BoolValue; // 0x4
	private char m_CharValue; // 0x4
	private byte m_ByteValue; // 0x4
	private sbyte m_SByteValue; // 0x4
	private short m_ShortValue; // 0x4
	private ushort m_UShortValue; // 0x4
	private int m_IntValue; // 0x4
	private uint m_UIntValue; // 0x4
	private long m_LongValue; // 0x4
	private ulong m_ULongValue; // 0x4
	private float m_FloatValue; // 0x4
	private double m_DoubleValue; // 0x4

	// Properties
	internal byte* valuePtr { get; }
	public TypeCode type { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x2792CB0 Offset: 0x27916B0 VA: 0x182792CB0
	internal byte* get_valuePtr() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public TypeCode get_type() { }

	// RVA: 0xD92CF0 Offset: 0xD916F0 VA: 0x180D92CF0
	public bool get_isEmpty() { }

	// RVA: 0x2792C10 Offset: 0x2791610 VA: 0x182792C10
	public void .ctor(bool value) { }

	// RVA: 0x2792B70 Offset: 0x2791570 VA: 0x182792B70
	public void .ctor(char value) { }

	// RVA: 0x2792C40 Offset: 0x2791640 VA: 0x182792C40
	public void .ctor(byte value) { }

	// RVA: 0x2792B60 Offset: 0x2791560 VA: 0x182792B60
	public void .ctor(sbyte value) { }

	// RVA: 0x2792BF0 Offset: 0x27915F0 VA: 0x182792BF0
	public void .ctor(short value) { }

	// RVA: 0x2792C90 Offset: 0x2791690 VA: 0x182792C90
	public void .ctor(ushort value) { }

	// RVA: 0x2792C70 Offset: 0x2791670 VA: 0x182792C70
	public void .ctor(int value) { }

	// RVA: 0x2792C50 Offset: 0x2791650 VA: 0x182792C50
	public void .ctor(uint value) { }

	// RVA: 0x2792BD0 Offset: 0x27915D0 VA: 0x182792BD0
	public void .ctor(long value) { }

	// RVA: 0x2792BB0 Offset: 0x27915B0 VA: 0x182792BB0
	public void .ctor(ulong value) { }

	// RVA: 0x2792B90 Offset: 0x2791590 VA: 0x182792B90
	public void .ctor(float value) { }

	// RVA: 0x2792C20 Offset: 0x2791620 VA: 0x182792C20
	public void .ctor(double value) { }

	// RVA: 0x2790C20 Offset: 0x278F620 VA: 0x182790C20
	public PrimitiveValue ConvertTo(TypeCode type) { }

	// RVA: 0x2790EC0 Offset: 0x278F8C0 VA: 0x182790EC0 Slot: 4
	public bool Equals(PrimitiveValue other) { }

	// RVA: 0x2790F00 Offset: 0x278F900 VA: 0x182790F00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2792CC0 Offset: 0x27916C0 VA: 0x182792CC0
	public static bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x2792D00 Offset: 0x2791700 VA: 0x182792D00
	public static bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x2791DC0 Offset: 0x27907C0 VA: 0x182791DC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27925B0 Offset: 0x2790FB0 VA: 0x1827925B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2791A20 Offset: 0x2790420 VA: 0x182791A20
	public static PrimitiveValue FromString(string value) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x2791E20 Offset: 0x2790820 VA: 0x182791E20 Slot: 6
	public bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2791FF0 Offset: 0x27909F0 VA: 0x182791FF0 Slot: 9
	public byte ToByte(IFormatProvider provider) { }

	// RVA: 0x2792000 Offset: 0x2790A00 VA: 0x182792000 Slot: 7
	public char ToChar(IFormatProvider provider) { }

	// RVA: 0x27920B0 Offset: 0x2790AB0 VA: 0x1827920B0 Slot: 19
	public DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2792100 Offset: 0x2790B00 VA: 0x182792100 Slot: 18
	public Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2792140 Offset: 0x2790B40 VA: 0x182792140 Slot: 17
	public double ToDouble(IFormatProvider provider) { }

	// RVA: 0x2791FF0 Offset: 0x27909F0 VA: 0x182791FF0 Slot: 10
	public short ToInt16(IFormatProvider provider) { }

	// RVA: 0x2791FF0 Offset: 0x27909F0 VA: 0x182791FF0 Slot: 12
	public int ToInt32(IFormatProvider provider) { }

	// RVA: 0x2792240 Offset: 0x2790C40 VA: 0x182792240 Slot: 14
	public long ToInt64(IFormatProvider provider) { }

	// RVA: 0x2791FF0 Offset: 0x27909F0 VA: 0x182791FF0 Slot: 8
	public sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x2792590 Offset: 0x2790F90 VA: 0x182792590 Slot: 16
	public float ToSingle(IFormatProvider provider) { }

	// RVA: 0x27929F0 Offset: 0x27913F0 VA: 0x1827929F0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2792A00 Offset: 0x2791400 VA: 0x182792A00 Slot: 21
	public object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x2792A40 Offset: 0x2791440 VA: 0x182792A40 Slot: 11
	public ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2792A40 Offset: 0x2791440 VA: 0x182792A40 Slot: 13
	public uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2792A50 Offset: 0x2791450 VA: 0x182792A50 Slot: 15
	public ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x27922D0 Offset: 0x2790CD0 VA: 0x1827922D0
	public object ToObject() { }

	// RVA: -1 Offset: -1
	public static PrimitiveValue From<TValue>(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26BC0 Offset: 0xF255C0 VA: 0x180F26BC0
	|-PrimitiveValue.From<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2791250 Offset: 0x278FC50 VA: 0x182791250
	public static PrimitiveValue FromObject(object value) { }

	// RVA: 0x2791170 Offset: 0x278FB70 VA: 0x182791170
	public static PrimitiveValue op_Implicit(bool value) { }

	// RVA: 0x27911B0 Offset: 0x278FBB0 VA: 0x1827911B0
	public static PrimitiveValue op_Implicit(char value) { }

	// RVA: 0x2791190 Offset: 0x278FB90 VA: 0x182791190
	public static PrimitiveValue op_Implicit(byte value) { }

	// RVA: 0x27919E0 Offset: 0x27903E0 VA: 0x1827919E0
	public static PrimitiveValue op_Implicit(sbyte value) { }

	// RVA: 0x27911F0 Offset: 0x278FBF0 VA: 0x1827911F0
	public static PrimitiveValue op_Implicit(short value) { }

	// RVA: 0x2791D60 Offset: 0x2790760 VA: 0x182791D60
	public static PrimitiveValue op_Implicit(ushort value) { }

	// RVA: 0x2791210 Offset: 0x278FC10 VA: 0x182791210
	public static PrimitiveValue op_Implicit(int value) { }

	// RVA: 0x2791D80 Offset: 0x2790780 VA: 0x182791D80
	public static PrimitiveValue op_Implicit(uint value) { }

	// RVA: 0x2791230 Offset: 0x278FC30 VA: 0x182791230
	public static PrimitiveValue op_Implicit(long value) { }

	// RVA: 0x2791DA0 Offset: 0x27907A0 VA: 0x182791DA0
	public static PrimitiveValue op_Implicit(ulong value) { }

	// RVA: 0x2791A00 Offset: 0x2790400 VA: 0x182791A00
	public static PrimitiveValue op_Implicit(float value) { }

	// RVA: 0x27911D0 Offset: 0x278FBD0 VA: 0x1827911D0
	public static PrimitiveValue op_Implicit(double value) { }

	// RVA: 0x2791170 Offset: 0x278FB70 VA: 0x182791170
	public static PrimitiveValue FromBoolean(bool value) { }

	// RVA: 0x27911B0 Offset: 0x278FBB0 VA: 0x1827911B0
	public static PrimitiveValue FromChar(char value) { }

	// RVA: 0x2791190 Offset: 0x278FB90 VA: 0x182791190
	public static PrimitiveValue FromByte(byte value) { }

	// RVA: 0x27919E0 Offset: 0x27903E0 VA: 0x1827919E0
	public static PrimitiveValue FromSByte(sbyte value) { }

	// RVA: 0x27911F0 Offset: 0x278FBF0 VA: 0x1827911F0
	public static PrimitiveValue FromInt16(short value) { }

	// RVA: 0x2791D60 Offset: 0x2790760 VA: 0x182791D60
	public static PrimitiveValue FromUInt16(ushort value) { }

	// RVA: 0x2791210 Offset: 0x278FC10 VA: 0x182791210
	public static PrimitiveValue FromInt32(int value) { }

	// RVA: 0x2791D80 Offset: 0x2790780 VA: 0x182791D80
	public static PrimitiveValue FromUInt32(uint value) { }

	// RVA: 0x2791230 Offset: 0x278FC30 VA: 0x182791230
	public static PrimitiveValue FromInt64(long value) { }

	// RVA: 0x2791DA0 Offset: 0x27907A0 VA: 0x182791DA0
	public static PrimitiveValue FromUInt64(ulong value) { }

	// RVA: 0x2791A00 Offset: 0x2790400 VA: 0x182791A00
	public static PrimitiveValue FromSingle(float value) { }

	// RVA: 0x27911D0 Offset: 0x278FBD0 VA: 0x1827911D0
	public static PrimitiveValue FromDouble(double value) { }
}
