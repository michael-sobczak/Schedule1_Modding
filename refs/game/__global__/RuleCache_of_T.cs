public class RuleCache<T> // TypeDefIndex: 15609
{
	// Fields
	private T[] _rules; // 0x0
	private readonly object _cacheLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B1100 Offset: 0x11AFB00 VA: 0x1811B1100
	|-RuleCache<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] GetRules() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-RuleCache<object>.GetRules
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B0E70 Offset: 0x11AF870 VA: 0x1811B0E70
	|-RuleCache<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B0C80 Offset: 0x11AF680 VA: 0x1811B0C80
	|-RuleCache<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	private static T[] AddOrInsert(T[] rules, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B0B30 Offset: 0x11AF530 VA: 0x1811B0B30
	|-RuleCache<object>.AddOrInsert
	*/
}
