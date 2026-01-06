public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 3913
{
	// Fields
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-AsyncLocal<object>..ctor
	|-AsyncLocal<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129E370 Offset: 0x129CD70 VA: 0x18129E370
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	|
	|-RVA: 0x129DF80 Offset: 0x129C980 VA: 0x18129DF80
	|-AsyncLocal<__Il2CppFullySharedGenericType>.System.Threading.IAsyncLocal.OnValueChanged
	*/
}
