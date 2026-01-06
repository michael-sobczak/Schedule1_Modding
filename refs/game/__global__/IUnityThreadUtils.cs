public interface IUnityThreadUtils : IServiceComponent // TypeDefIndex: 17791
{
	// Properties
	public abstract bool IsRunningOnUnityThread { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsRunningOnUnityThread();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task PostAsync(Action action);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task PostAsync(Action<object> action, object state);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Task<T> PostAsync<T>(Func<T> action);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUnityThreadUtils.PostAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Task<T> PostAsync<T>(Func<object, T> action, object state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUnityThreadUtils.PostAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Send(Action action);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Send(Action<object> action, object state);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract T Send<T>(Func<T> action);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUnityThreadUtils.Send<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract T Send<T>(Func<object, T> action, object state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUnityThreadUtils.Send<__Il2CppFullySharedGenericType>
	*/
}
