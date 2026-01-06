public class ConditionalAttribute : ActionAttribute // TypeDefIndex: 10386
{
	// Fields
	public ConditionalAttribute.Condition[] Conditions; // 0x38

	// Methods

	// RVA: 0x48BBA0 Offset: 0x48A5A0 VA: 0x18048BBA0
	protected void .ctor(string fieldOrProperty, object compareTo, bool compareFalse = False) { }

	// RVA: 0x48BE60 Offset: 0x48A860 VA: 0x18048BE60
	protected void .ctor(string fieldOrProperty, object compareTo, bool compareFalse, ConditionalAttribute.OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2) { }

	// RVA: 0x48B900 Offset: 0x48A300 VA: 0x18048B900
	protected void .ctor(string fieldOrProperty, object compareTo, bool compareFalse, ConditionalAttribute.OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3) { }

	// RVA: 0x48BD00 Offset: 0x48A700 VA: 0x18048BD00
	protected void .ctor(string methodToQuery) { }

	// RVA: 0x48B830 Offset: 0x48A230 VA: 0x18048B830 Slot: 9
	public virtual bool ConditionMet(object classInstance) { }

	// RVA: 0x48C060 Offset: 0x48AA60 VA: 0x18048C060
	private bool evaluate(ConditionalAttribute.Condition cond, object classInstance) { }
}
