internal class QueryFilter : PathFilter // TypeDefIndex: 11381
{
	// Fields
	internal QueryExpression Expression; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(QueryExpression expression) { }

	[IteratorStateMachine(typeof(QueryFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1DE5870 Offset: 0x1DE4270 VA: 0x181DE5870 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}
