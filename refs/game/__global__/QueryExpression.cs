internal abstract class QueryExpression // TypeDefIndex: 11377
{
	// Fields
	internal QueryOperator Operator; // 0x10

	// Methods

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	public void .ctor(QueryOperator operator) { }

	// RVA: 0x1DE5840 Offset: 0x1DE4240 VA: 0x181DE5840
	public bool IsMatch(JToken root, JToken t) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings settings);
}
