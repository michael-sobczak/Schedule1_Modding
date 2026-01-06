internal class BooleanQueryExpression : QueryExpression // TypeDefIndex: 11379
{
	// Fields
	public readonly object Left; // 0x18
	[Nullable(2)]
	public readonly object Right; // 0x20

	// Methods

	// RVA: 0x165BA70 Offset: 0x165A470 VA: 0x18165BA70
	public void .ctor(QueryOperator operator, object left, object right) { }

	// RVA: 0x1DD1EB0 Offset: 0x1DD08B0 VA: 0x181DD1EB0
	private IEnumerable<JToken> GetResult(JToken root, JToken t, object o) { }

	// RVA: 0x1DD20A0 Offset: 0x1DD0AA0 VA: 0x181DD20A0 Slot: 4
	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x1DD2550 Offset: 0x1DD0F50 VA: 0x181DD2550
	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings) { }

	// RVA: 0x1DD27C0 Offset: 0x1DD11C0 VA: 0x181DD27C0
	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings) { }

	// RVA: 0x1DD1960 Offset: 0x1DD0360 VA: 0x181DD1960
	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue) { }

	// RVA: 0x1DD1800 Offset: 0x1DD0200 VA: 0x181DD1800
	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue) { }
}
