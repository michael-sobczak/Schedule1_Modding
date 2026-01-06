public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible // TypeDefIndex: 3813
{
	// Fields
	private static readonly char[] enumSeperatorCharArray; // 0x0
	private const string enumSeperator = ", ";

	// Methods

	// RVA: 0x1CA2730 Offset: 0x1CA1130 VA: 0x181CA2730
	private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	// RVA: 0x1CA35B0 Offset: 0x1CA1FB0 VA: 0x181CA35B0
	private static string InternalFormattedHexString(object value) { }

	// RVA: 0x1CA33F0 Offset: 0x1CA1DF0 VA: 0x181CA33F0
	private static string InternalFormat(RuntimeType eT, object value) { }

	// RVA: 0x1CA31E0 Offset: 0x1CA1BE0 VA: 0x181CA31E0
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	// RVA: 0x1CA6670 Offset: 0x1CA5070 VA: 0x181CA6670
	internal static ulong ToUInt64(object value) { }

	// RVA: 0x1CA31D0 Offset: 0x1CA1BD0 VA: 0x181CA31D0
	private static int InternalCompareTo(object o1, object o2) { }

	// RVA: 0x1CA3B10 Offset: 0x1CA2510 VA: 0x181CA3B10
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	// RVA: 0x1CA28B0 Offset: 0x1CA12B0 VA: 0x181CA28B0
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	// RVA: 0x1CA31C0 Offset: 0x1CA1BC0 VA: 0x181CA31C0
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84860 Offset: 0xE83260 VA: 0x180E84860
	|-Enum.TryParse<Int32Enum>
	|
	|-RVA: 0xE84600 Offset: 0xE83000 VA: 0x180E84600
	|-Enum.TryParse<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE849E0 Offset: 0xE833E0 VA: 0x180E849E0
	|-Enum.TryParse<Int32Enum>
	|
	|-RVA: 0xE84680 Offset: 0xE83080 VA: 0x180E84680
	|-Enum.TryParse<__Il2CppFullySharedGenericStructType>
	*/

	[ComVisible(True)]
	// RVA: 0x1CA3D80 Offset: 0x1CA2780 VA: 0x181CA3D80
	public static object Parse(Type enumType, string value) { }

	[ComVisible(True)]
	// RVA: 0x1CA3C60 Offset: 0x1CA2660 VA: 0x181CA3C60
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	// RVA: 0x1CA6800 Offset: 0x1CA5200 VA: 0x181CA6800
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult) { }

	[ComVisible(True)]
	// RVA: 0x1CA2E90 Offset: 0x1CA1890 VA: 0x181CA2E90
	public static Type GetUnderlyingType(Type enumType) { }

	[ComVisible(True)]
	// RVA: 0x1CA2F60 Offset: 0x1CA1960 VA: 0x181CA2F60
	public static Array GetValues(Type enumType) { }

	// RVA: 0x1CA3B20 Offset: 0x1CA2520 VA: 0x181CA3B20
	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	[ComVisible(True)]
	// RVA: 0x1CA28D0 Offset: 0x1CA12D0 VA: 0x181CA28D0
	public static string GetName(Type enumType, object value) { }

	[ComVisible(True)]
	// RVA: 0x1CA29A0 Offset: 0x1CA13A0 VA: 0x181CA29A0
	public static string[] GetNames(Type enumType) { }

	// RVA: 0x1CA3AB0 Offset: 0x1CA24B0 VA: 0x181CA3AB0
	internal static string[] InternalGetNames(RuntimeType enumType) { }

	[ComVisible(True)]
	// RVA: 0x1CA5990 Offset: 0x1CA4390 VA: 0x181CA5990
	public static object ToObject(Type enumType, object value) { }

	[ComVisible(True)]
	// RVA: 0x1CA3B90 Offset: 0x1CA2590 VA: 0x181CA3B90
	public static bool IsDefined(Type enumType, object value) { }

	[ComVisible(True)]
	// RVA: 0x1CA2000 Offset: 0x1CA0A00 VA: 0x181CA2000
	public static string Format(Type enumType, object value, string format) { }

	// RVA: 0x1CA2F50 Offset: 0x1CA1950 VA: 0x181CA2F50
	private object get_value() { }

	// RVA: 0x1CA2F50 Offset: 0x1CA1950 VA: 0x181CA2F50
	internal object GetValue() { }

	// RVA: 0x1CA3B80 Offset: 0x1CA2580 VA: 0x181CA3B80
	private bool InternalHasFlag(Enum flags) { }

	// RVA: 0x1CA28C0 Offset: 0x1CA12C0 VA: 0x181CA28C0
	private int get_hashcode() { }

	// RVA: 0x1CA1FF0 Offset: 0x1CA09F0 VA: 0x181CA1FF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1CA28C0 Offset: 0x1CA12C0 VA: 0x181CA28C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CA6330 Offset: 0x1CA4D30 VA: 0x181CA6330 Slot: 3
	public override string ToString() { }

	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	// RVA: 0x1CA6320 Offset: 0x1CA4D20 VA: 0x181CA6320 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1CA1DE0 Offset: 0x1CA07E0 VA: 0x181CA1DE0 Slot: 4
	public int CompareTo(object target) { }

	// RVA: 0x1CA63F0 Offset: 0x1CA4DF0 VA: 0x181CA63F0
	public string ToString(string format) { }

	[Obsolete("The provider argument is not used. Please use ToString().")]
	// RVA: 0x1C05F80 Offset: 0x1C04980 VA: 0x181C05F80 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1CA3020 Offset: 0x1CA1A20 VA: 0x181CA3020
	public bool HasFlag(Enum flag) { }

	// RVA: 0x1CA2A60 Offset: 0x1CA1460 VA: 0x181CA2A60 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1CA3EB0 Offset: 0x1CA28B0 VA: 0x181CA3EB0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1CA3FD0 Offset: 0x1CA29D0 VA: 0x181CA3FD0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1CA4450 Offset: 0x1CA2E50 VA: 0x181CA4450 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1CA3F40 Offset: 0x1CA2940 VA: 0x181CA3F40 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1CA42A0 Offset: 0x1CA2CA0 VA: 0x181CA42A0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1CA45E0 Offset: 0x1CA2FE0 VA: 0x181CA45E0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1CA4330 Offset: 0x1CA2D30 VA: 0x181CA4330 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1CA4670 Offset: 0x1CA3070 VA: 0x181CA4670 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1CA43C0 Offset: 0x1CA2DC0 VA: 0x181CA43C0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1CA4700 Offset: 0x1CA3100 VA: 0x181CA4700 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1CA44E0 Offset: 0x1CA2EE0 VA: 0x181CA44E0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1CA4210 Offset: 0x1CA2C10 VA: 0x181CA4210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1CA4160 Offset: 0x1CA2B60 VA: 0x181CA4160 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1CA4060 Offset: 0x1CA2A60 VA: 0x181CA4060 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1CA4570 Offset: 0x1CA2F70 VA: 0x181CA4570 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	// RVA: 0x1CA60E0 Offset: 0x1CA4AE0 VA: 0x181CA60E0
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisible(True)]
	// RVA: 0x1CA4790 Offset: 0x1CA3190 VA: 0x181CA4790
	public static object ToObject(Type enumType, short value) { }

	[ComVisible(True)]
	// RVA: 0x1CA4C10 Offset: 0x1CA3610 VA: 0x181CA4C10
	public static object ToObject(Type enumType, int value) { }

	[ComVisible(True)]
	// RVA: 0x1CA52D0 Offset: 0x1CA3CD0 VA: 0x181CA52D0
	public static object ToObject(Type enumType, byte value) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	// RVA: 0x1CA5510 Offset: 0x1CA3F10 VA: 0x181CA5510
	public static object ToObject(Type enumType, ushort value) { }

	[ComVisible(True)]
	[CLSCompliant(False)]
	// RVA: 0x1CA5750 Offset: 0x1CA4150 VA: 0x181CA5750
	public static object ToObject(Type enumType, uint value) { }

	[ComVisible(True)]
	// RVA: 0x1CA4E50 Offset: 0x1CA3850 VA: 0x181CA4E50
	public static object ToObject(Type enumType, long value) { }

	[ComVisible(True)]
	[CLSCompliant(False)]
	// RVA: 0x1CA5EA0 Offset: 0x1CA48A0 VA: 0x181CA5EA0
	public static object ToObject(Type enumType, ulong value) { }

	// RVA: 0x1CA5090 Offset: 0x1CA3A90 VA: 0x181CA5090
	private static object ToObject(Type enumType, char value) { }

	// RVA: 0x1CA49D0 Offset: 0x1CA33D0 VA: 0x181CA49D0
	private static object ToObject(Type enumType, bool value) { }

	// RVA: -1 Offset: -1
	public static TEnum Parse<TEnum>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84330 Offset: 0xE82D30 VA: 0x180E84330
	|-Enum.Parse<Int32Enum>
	|
	|-RVA: 0xE84240 Offset: 0xE82C40 VA: 0x180E84240
	|-Enum.Parse<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static TEnum Parse<TEnum>(string value, bool ignoreCase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE844B0 Offset: 0xE82EB0 VA: 0x180E844B0
	|-Enum.Parse<Int32Enum>
	|
	|-RVA: 0xE840D0 Offset: 0xE82AD0 VA: 0x180E840D0
	|-Enum.Parse<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x1CA6F80 Offset: 0x1CA5980 VA: 0x181CA6F80
	public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result) { }

	// RVA: 0x1CA6E80 Offset: 0x1CA5880 VA: 0x181CA6E80
	public static bool TryParse(Type enumType, string value, out object result) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }

	// RVA: 0x1CA7050 Offset: 0x1CA5A50 VA: 0x181CA7050
	private static void .cctor() { }
}
