public class ExpressionEvaluator // TypeDefIndex: 11622
{
	// Fields
	private static ExpressionEvaluator.PcgRandom s_Random; // 0x0
	private static Dictionary<string, ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: -1 Offset: -1
	internal static bool Evaluate<T>(string expression, out T value, out ExpressionEvaluator.Expression delayed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9C320 Offset: 0xE9AD20 VA: 0x180E9C320
	|-ExpressionEvaluator.Evaluate<double>
	|-ExpressionEvaluator.Evaluate<long>
	|-ExpressionEvaluator.Evaluate<ulong>
	|
	|-RVA: 0xE9C450 Offset: 0xE9AE50 VA: 0x180E9C450
	|-ExpressionEvaluator.Evaluate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9B980 Offset: 0xE9A380 VA: 0x180E9B980
	|-ExpressionEvaluator.EvaluateTokens<double>
	|-ExpressionEvaluator.EvaluateTokens<long>
	|-ExpressionEvaluator.EvaluateTokens<ulong>
	|
	|-RVA: 0xE9BE10 Offset: 0xE9A810 VA: 0x180E9BE10
	|-ExpressionEvaluator.EvaluateTokens<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C87D50 Offset: 0x2C86750 VA: 0x182C87D50
	private static bool EvaluateDouble(string[] tokens, ref double value, int index, int count) { }

	// RVA: 0x2C88C00 Offset: 0x2C87600 VA: 0x182C88C00
	private static string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x2C89290 Offset: 0x2C87C90 VA: 0x182C89290
	private static bool NeedToPop(Stack<string> operatorStack, ExpressionEvaluator.Operator newOperator) { }

	// RVA: 0x2C88680 Offset: 0x2C87080 VA: 0x182C88680
	private static string[] ExpressionToTokens(string expression, out bool hasVariables) { }

	// RVA: 0x2C890C0 Offset: 0x2C87AC0 VA: 0x182C890C0
	private static bool IsCommand(string token) { }

	// RVA: 0x2C89230 Offset: 0x2C87C30 VA: 0x182C89230
	private static bool IsVariable(string token) { }

	// RVA: 0x2C89140 Offset: 0x2C87B40 VA: 0x182C89140
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x2C891B0 Offset: 0x2C87BB0 VA: 0x182C891B0
	private static bool IsOperator(string token) { }

	// RVA: 0x2C89530 Offset: 0x2C87F30 VA: 0x182C89530
	private static ExpressionEvaluator.Operator TokenToOperator(string token) { }

	// RVA: 0x2C89370 Offset: 0x2C87D70 VA: 0x182C89370
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x2C88A80 Offset: 0x2C87480 VA: 0x182C88A80
	private static string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x2C88250 Offset: 0x2C86C50 VA: 0x182C88250
	private static double EvaluateOp(double[] values, ExpressionEvaluator.Op op, int index, int count) { }

	// RVA: -1 Offset: -1
	private static bool TryParse<T>(string expression, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9C5B0 Offset: 0xE9AFB0 VA: 0x180E9C5B0
	|-ExpressionEvaluator.TryParse<double>
	|-ExpressionEvaluator.TryParse<long>
	|-ExpressionEvaluator.TryParse<ulong>
	|
	|-RVA: 0xE9CE10 Offset: 0xE9B810 VA: 0x180E9CE10
	|-ExpressionEvaluator.TryParse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C895D0 Offset: 0x2C87FD0 VA: 0x182C895D0
	private static void .cctor() { }
}
