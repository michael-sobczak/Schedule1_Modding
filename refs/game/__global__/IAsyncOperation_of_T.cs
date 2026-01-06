internal interface IAsyncOperation<T> : IEnumerator // TypeDefIndex: 17829
{
	// Properties
	public abstract bool IsDone { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception Exception { get; }
	public abstract T Result { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperation<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationStatus get_Status();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperation<__Il2CppFullySharedGenericType>.get_Status
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_Completed(Action<IAsyncOperation<T>> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperation<__Il2CppFullySharedGenericType>.add_Completed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_Completed(Action<IAsyncOperation<T>> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperation<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Exception get_Exception();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperation<__Il2CppFullySharedGenericType>.get_Exception
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract T get_Result();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperation<__Il2CppFullySharedGenericType>.get_Result
	*/
}
