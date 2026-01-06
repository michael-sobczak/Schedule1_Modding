internal interface IServiceRegistry // TypeDefIndex: 17866
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RegisterService<T>(T service);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IServiceRegistry.RegisterService<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T GetService<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IServiceRegistry.GetService<__Il2CppFullySharedGenericType>
	*/
}
