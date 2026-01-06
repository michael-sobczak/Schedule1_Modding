public abstract class CallSiteBinder // TypeDefIndex: 15604
{
	// Fields
	internal Dictionary<Type, object> Cache; // 0x10
	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; // 0x0

	// Properties
	public static LabelTarget UpdateLabel { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1FE4470 Offset: 0x1FE2E70 VA: 0x181FE4470
	public static LabelTarget get_UpdateLabel() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T BindDelegate<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	|-CallSiteBinder.BindDelegate<object>
	*/

	// RVA: -1 Offset: -1
	internal T BindCore<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CE20 Offset: 0xE5B820 VA: 0x180E5CE20
	|-CallSiteBinder.BindCore<object>
	*/

	// RVA: -1 Offset: -1
	protected void CacheTarget<T>(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CFA0 Offset: 0xE5B9A0 VA: 0x180E5CFA0
	|-CallSiteBinder.CacheTarget<object>
	*/

	// RVA: -1 Offset: -1
	private static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5D280 Offset: 0xE5BC80 VA: 0x180E5D280
	|-CallSiteBinder.Stitch<object>
	*/

	// RVA: -1 Offset: -1
	internal RuleCache<T> GetRuleCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5D010 Offset: 0xE5BA10 VA: 0x180E5D010
	|-CallSiteBinder.GetRuleCache<object>
	*/

	// RVA: 0x1FE43E0 Offset: 0x1FE2DE0 VA: 0x181FE43E0
	private static void .cctor() { }
}
