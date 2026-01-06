internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 4066
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DEED0 Offset: 0x14DD8D0 VA: 0x1814DEED0
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>..ctor
	|
	|-RVA: 0x14DECE0 Offset: 0x14DD6E0 VA: 0x1814DECE0
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>..ctor
	|
	|-RVA: 0x14DEDC0 Offset: 0x14DD7C0 VA: 0x1814DEDC0
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE9F0 Offset: 0x14DD3F0 VA: 0x1814DE9F0
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>.InnerInvoke
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x14DEAF0 Offset: 0x14DD4F0 VA: 0x1814DEAF0
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerInvoke
	*/
}
