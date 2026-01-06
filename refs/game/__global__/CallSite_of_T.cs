public class CallSite<T> : CallSite // TypeDefIndex: 15602
{
	// Fields
	public T Target; // 0x0
	internal T[] Rules; // 0x0
	private static T s_cachedUpdate; // 0x0
	private static T s_cachedNoMatch; // 0x0

	// Properties
	public T Update { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438F60 Offset: 0x1437960 VA: 0x181438F60
	|-CallSite<object>.get_Update
	*/

	// RVA: -1 Offset: -1
	private void .ctor(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438F00 Offset: 0x1437900 VA: 0x181438F00
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438F50 Offset: 0x1437950 VA: 0x181438F50
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal CallSite<T> CreateMatchMaker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14387D0 Offset: 0x14371D0 VA: 0x1814387D0
	|-CallSite<object>.CreateMatchMaker
	*/

	// RVA: -1 Offset: -1
	public static CallSite<T> Create(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438820 Offset: 0x1437220 VA: 0x181438820
	|-CallSite<object>.Create
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14389C0 Offset: 0x14373C0 VA: 0x1814389C0
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate(ref T addr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438B60 Offset: 0x1437560 VA: 0x181438B60
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436E60 Offset: 0x1435860 VA: 0x181436E60
	|-CallSite<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438E40 Offset: 0x1437840 VA: 0x181438E40
	|-CallSite<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal T MakeUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438CF0 Offset: 0x14376F0 VA: 0x181438CF0
	|-CallSite<object>.MakeUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14373D0 Offset: 0x1435DD0 VA: 0x1814373D0
	|-CallSite<object>.CreateCustomUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1437060 Offset: 0x1435A60 VA: 0x181437060
	|-CallSite<object>.CreateCustomNoMatchDelegate
	*/

	// RVA: -1 Offset: -1
	private static Expression Convert(Expression arg, Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436F90 Offset: 0x1435990 VA: 0x181436F90
	|-CallSite<object>.Convert
	*/
}
