internal class JPath // TypeDefIndex: 11374
{
	// Fields
	private static readonly char[] FloatCharacters; // 0x0
	private readonly string _expression; // 0x10
	[CompilerGenerated]
	private readonly List<PathFilter> <Filters>k__BackingField; // 0x18
	private int _currentIndex; // 0x20

	// Properties
	public List<PathFilter> Filters { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<PathFilter> get_Filters() { }

	// RVA: 0x1DDB470 Offset: 0x1DD9E70 VA: 0x181DDB470
	public void .ctor(string expression) { }

	// RVA: 0x1DD92E0 Offset: 0x1DD7CE0 VA: 0x181DD92E0
	private void ParseMain() { }

	// RVA: 0x1DD9A80 Offset: 0x1DD8480 VA: 0x181DD9A80
	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query) { }

	// RVA: 0x1DD7F30 Offset: 0x1DD6930 VA: 0x181DD7F30
	private static PathFilter CreatePathFilter(string member, bool scan) { }

	// RVA: 0x1DD9170 Offset: 0x1DD7B70 VA: 0x181DD9170
	private PathFilter ParseIndexer(char indexerOpenChar, bool scan) { }

	// RVA: 0x1DD8460 Offset: 0x1DD6E60 VA: 0x181DD8460
	private PathFilter ParseArrayIndexer(char indexerCloseChar) { }

	// RVA: 0x1DD8080 Offset: 0x1DD6A80 VA: 0x181DD8080
	private void EatWhitespace() { }

	// RVA: 0x1DD9FA0 Offset: 0x1DD89A0 VA: 0x181DD9FA0
	private PathFilter ParseQuery(char indexerCloseChar, bool scan) { }

	// RVA: 0x1DDAE70 Offset: 0x1DD9870 VA: 0x181DDAE70
	private bool TryParseExpression(out List<PathFilter> expressionPath) { }

	// RVA: 0x1DD7FB0 Offset: 0x1DD69B0 VA: 0x181DD7FB0
	private JsonException CreateUnexpectedCharacterException() { }

	// RVA: 0x1DDA630 Offset: 0x1DD9030 VA: 0x181DDA630
	private object ParseSide() { }

	// RVA: 0x1DD8DB0 Offset: 0x1DD77B0 VA: 0x181DD8DB0
	private QueryExpression ParseExpression() { }

	[NullableContext(2)]
	// RVA: 0x1DDB040 Offset: 0x1DD9A40 VA: 0x181DDB040
	private bool TryParseValue(out object value) { }

	// RVA: 0x1DDAA20 Offset: 0x1DD9420 VA: 0x181DDAA20
	private string ReadQuotedString() { }

	// RVA: 0x1DDACE0 Offset: 0x1DD96E0 VA: 0x181DDACE0
	private string ReadRegexString() { }

	// RVA: 0x1DD83C0 Offset: 0x1DD6DC0 VA: 0x181DD83C0
	private bool Match(string s) { }

	// RVA: 0x1DD94D0 Offset: 0x1DD7ED0 VA: 0x181DD94D0
	private QueryOperator ParseOperator() { }

	// RVA: 0x1DDA2A0 Offset: 0x1DD8CA0 VA: 0x181DDA2A0
	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan) { }

	// RVA: 0x1DD80E0 Offset: 0x1DD6AE0 VA: 0x181DD80E0
	private void EnsureLength(string message) { }

	// RVA: 0x1DD8330 Offset: 0x1DD6D30 VA: 0x181DD8330
	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x1DD8150 Offset: 0x1DD6B50 VA: 0x181DD8150
	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x1DDB3E0 Offset: 0x1DD9DE0 VA: 0x181DDB3E0
	private static void .cctor() { }
}
