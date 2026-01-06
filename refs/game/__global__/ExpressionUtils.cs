internal static class ExpressionUtils // TypeDefIndex: 15654
{
	// Methods

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9DE20 Offset: 0xE9C820 VA: 0x180E9DE20
	|-ExpressionUtils.ReturnReadOnly<object>
	|
	|-RVA: 0xE9DD10 Offset: 0xE9C710 VA: 0x180E9DD10
	|-ExpressionUtils.ReturnReadOnly<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9DBA0 Offset: 0xE9C5A0 VA: 0x180E9DBA0
	|-ExpressionUtils.ReturnObject<object>
	*/

	// RVA: 0x2002110 Offset: 0x2000B10 VA: 0x182002110
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x2002030 Offset: 0x2000A30 VA: 0x182002030
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x2002570 Offset: 0x2000F70 VA: 0x182002570
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x2001B80 Offset: 0x2000580 VA: 0x182001B80
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x2001B90 Offset: 0x2000590 VA: 0x182001B90
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x2001DE0 Offset: 0x20007E0 VA: 0x182001DE0
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x2001B00 Offset: 0x2000500 VA: 0x182001B00
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9E140 Offset: 0xE9CB40 VA: 0x180E9E140
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9DF20 Offset: 0xE9C920 VA: 0x180E9DF20
	|-ExpressionUtils.SameElementsInCollection<object>
	*/

	[Extension]
	// RVA: 0x2001FB0 Offset: 0x20009B0 VA: 0x182001FB0
	public static void ValidateArgumentCount(LambdaExpression lambda) { }
}
