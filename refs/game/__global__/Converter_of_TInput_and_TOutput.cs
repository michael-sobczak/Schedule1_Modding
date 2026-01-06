public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 3588
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBD60 Offset: 0x10BA760 VA: 0x1810BBD60
	|-Converter<object, object>..ctor
	|
	|-RVA: 0x14DFFB0 Offset: 0x14DE9B0 VA: 0x1814DFFB0
	|-Converter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-Converter<object, object>.Invoke
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-Converter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
