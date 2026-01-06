internal static class ADP // TypeDefIndex: 13035
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x2100830 Offset: 0x20FF230 VA: 0x182100830
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x2100690 Offset: 0x20FF090 VA: 0x182100690
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x2100760 Offset: 0x20FF160 VA: 0x182100760
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x20FFD60 Offset: 0x20FE760 VA: 0x1820FFD60
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x20FFC50 Offset: 0x20FE650 VA: 0x1820FFC50
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x20FFCD0 Offset: 0x20FE6D0 VA: 0x1820FFCD0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x2100020 Offset: 0x20FEA20 VA: 0x182100020
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x2100610 Offset: 0x20FF010 VA: 0x182100610
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x21001A0 Offset: 0x20FEBA0 VA: 0x1821001A0
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x2100400 Offset: 0x20FEE00 VA: 0x182100400
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x20FFE80 Offset: 0x20FE880 VA: 0x1820FFE80
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x2100140 Offset: 0x20FEB40 VA: 0x182100140
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x20FFDE0 Offset: 0x20FE7E0 VA: 0x1820FFDE0
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x20FFF80 Offset: 0x20FE980 VA: 0x1820FFF80
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x21000A0 Offset: 0x20FEAA0 VA: 0x1821000A0
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x21008C0 Offset: 0x20FF2C0 VA: 0x1821008C0
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x21009E0 Offset: 0x20FF3E0 VA: 0x1821009E0
	private static void .cctor() { }
}
