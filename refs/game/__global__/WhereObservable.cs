private class WhereObservable.Where<TValue> : IObserver<TValue> // TypeDefIndex: 7836
{
	// Fields
	private WhereObservable<TValue> m_Observable; // 0x0
	private readonly IObserver<TValue> m_Observer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhereObservable<TValue> observable, IObserver<TValue> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-WhereObservable.Where<object>..ctor
	|-WhereObservable.Where<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-WhereObservable.Where<object>.OnCompleted
	|-WhereObservable.Where<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13F6E50 Offset: 0x13F5850 VA: 0x1813F6E50
	|-WhereObservable.Where<object>.OnError
	|
	|-RVA: 0x13F6E00 Offset: 0x13F5800 VA: 0x1813F6E00
	|-WhereObservable.Where<__Il2CppFullySharedGenericType>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TValue evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13F6EA0 Offset: 0x13F58A0 VA: 0x1813F6EA0
	|-WhereObservable.Where<object>.OnNext
	|
	|-RVA: 0x13F6F90 Offset: 0x13F5990 VA: 0x1813F6F90
	|-WhereObservable.Where<__Il2CppFullySharedGenericType>.OnNext
	*/
}
