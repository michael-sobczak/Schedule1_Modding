internal sealed class Converter // TypeDefIndex: 4491
{
	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x1B47C10 Offset: 0x1B46610 VA: 0x181B47C10
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x1B47AD0 Offset: 0x1B464D0 VA: 0x181B47AD0
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B483E0 Offset: 0x1B46DE0 VA: 0x181B483E0
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B47B40 Offset: 0x1B46540 VA: 0x181B47B40
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B46C80 Offset: 0x1B45680 VA: 0x181B46C80
	private static void InitTypeA() { }

	// RVA: 0x1B46450 Offset: 0x1B44E50 VA: 0x181B46450
	private static void InitArrayTypeA() { }

	// RVA: 0x1B48310 Offset: 0x1B46D10 VA: 0x181B48310
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B461A0 Offset: 0x1B44BA0 VA: 0x181B461A0
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x1B477E0 Offset: 0x1B461E0 VA: 0x181B477E0
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x1B47480 Offset: 0x1B45E80 VA: 0x181B47480
	private static void InitValueA() { }

	// RVA: 0x1B47D40 Offset: 0x1B46740 VA: 0x181B47D40
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B472D0 Offset: 0x1B45CD0 VA: 0x181B472D0
	private static void InitTypeCodeA() { }

	// RVA: 0x1B480A0 Offset: 0x1B46AA0 VA: 0x181B480A0
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x1B46AB0 Offset: 0x1B454B0 VA: 0x181B46AB0
	private static void InitCodeA() { }

	// RVA: 0x1B47E10 Offset: 0x1B46810 VA: 0x181B47E10
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x1B46380 Offset: 0x1B44D80 VA: 0x181B46380
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x1B48470 Offset: 0x1B46E70 VA: 0x181B48470
	private static void .cctor() { }
}
