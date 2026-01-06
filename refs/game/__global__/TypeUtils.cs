internal static class TypeUtils // TypeDefIndex: 15658
{
	// Fields
	private static readonly Type[] s_arrayAssignableInterfaces; // 0x0

	// Methods

	[Extension]
	// RVA: 0x2008B80 Offset: 0x2007580 VA: 0x182008B80
	public static Type GetNonNullableType(Type type) { }

	[Extension]
	// RVA: 0x2008C60 Offset: 0x2007660 VA: 0x182008C60
	public static Type GetNullableType(Type type) { }

	[Extension]
	// RVA: 0x200B5E0 Offset: 0x2009FE0 VA: 0x18200B5E0
	public static bool IsNullableType(Type type) { }

	[Extension]
	// RVA: 0x200B570 Offset: 0x2009F70 VA: 0x18200B570
	public static bool IsNullableOrReferenceType(Type type) { }

	[Extension]
	// RVA: 0x200A020 Offset: 0x2008A20 VA: 0x18200A020
	public static bool IsBool(Type type) { }

	[Extension]
	// RVA: 0x200B810 Offset: 0x200A210 VA: 0x18200B810
	public static bool IsNumeric(Type type) { }

	[Extension]
	// RVA: 0x200AF60 Offset: 0x2009960 VA: 0x18200AF60
	public static bool IsInteger(Type type) { }

	[Extension]
	// RVA: 0x2009EC0 Offset: 0x20088C0 VA: 0x182009EC0
	public static bool IsArithmetic(Type type) { }

	[Extension]
	// RVA: 0x200BA60 Offset: 0x200A460 VA: 0x18200BA60
	public static bool IsUnsignedInt(Type type) { }

	[Extension]
	// RVA: 0x200AE00 Offset: 0x2009800 VA: 0x18200AE00
	public static bool IsIntegerOrBool(Type type) { }

	[Extension]
	// RVA: 0x200B6A0 Offset: 0x200A0A0 VA: 0x18200B6A0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x200BBD0 Offset: 0x200A5D0 VA: 0x18200BBD0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Extension]
	// RVA: 0x20095E0 Offset: 0x2007FE0 VA: 0x1820095E0
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x2009BB0 Offset: 0x20085B0 VA: 0x182009BB0
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x200BF80 Offset: 0x200A980 VA: 0x18200BF80
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	// RVA: 0x2009150 Offset: 0x2007B50 VA: 0x182009150
	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	// RVA: 0x2009970 Offset: 0x2008370 VA: 0x182009970
	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	// RVA: 0x200A2C0 Offset: 0x2008CC0 VA: 0x18200A2C0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x200A130 Offset: 0x2008B30 VA: 0x18200A130
	private static bool IsContravariant(Type t) { }

	// RVA: 0x200B0C0 Offset: 0x2009AC0 VA: 0x18200B0C0
	private static bool IsInvariant(Type t) { }

	// RVA: 0x200A2F0 Offset: 0x2008CF0 VA: 0x18200A2F0
	private static bool IsDelegate(Type t) { }

	// RVA: 0x200B0F0 Offset: 0x2009AF0 VA: 0x18200B0F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Extension]
	// RVA: 0x200A160 Offset: 0x2008B60 VA: 0x18200A160
	public static bool IsConvertible(Type type) { }

	// RVA: 0x2009DD0 Offset: 0x20087D0 VA: 0x182009DD0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x2009390 Offset: 0x2007D90 VA: 0x182009390
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Extension]
	// RVA: 0x200A890 Offset: 0x2009290 VA: 0x18200A890
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x2008DC0 Offset: 0x20077C0 VA: 0x182008DC0
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x2008330 Offset: 0x2006D30 VA: 0x182008330
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x200A670 Offset: 0x2009070 VA: 0x18200A670
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x200A860 Offset: 0x2009260 VA: 0x18200A860
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x200A380 Offset: 0x2008D80 VA: 0x18200A380
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x200A4F0 Offset: 0x2008EF0 VA: 0x18200A4F0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x2008510 Offset: 0x2006F10 VA: 0x182008510
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x2008830 Offset: 0x2007230 VA: 0x182008830
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Extension]
	// RVA: 0x2008C10 Offset: 0x2007610 VA: 0x182008C10
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x2008180 Offset: 0x2006B80 VA: 0x182008180
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x2008210 Offset: 0x2006C10 VA: 0x182008210
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x200B970 Offset: 0x200A370 VA: 0x18200B970
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x200C490 Offset: 0x200AE90 VA: 0x18200C490
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x200C2C0 Offset: 0x200ACC0 VA: 0x18200C2C0
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x200C500 Offset: 0x200AF00 VA: 0x18200C500
	public static bool ValidateType(Type type, string paramName, int index) { }

	[Extension]
	// RVA: 0x2008B30 Offset: 0x2007530 VA: 0x182008B30
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	// RVA: 0x200C610 Offset: 0x200B010 VA: 0x18200C610
	private static void .cctor() { }
}
