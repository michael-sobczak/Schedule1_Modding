private class SelectObservable.Select<TSource, TResult> : IObserver<TSource> // TypeDefIndex: 7720
{
	// Fields
	private SelectObservable<TSource, TResult> m_Observable; // 0x0
	private readonly IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-SelectObservable.Select<InputEventPtr, object>..ctor
	|-SelectObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-SelectObservable.Select<InputEventPtr, object>.OnCompleted
	|-SelectObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B7960 Offset: 0x11B6360 VA: 0x1811B7960
	|-SelectObservable.Select<InputEventPtr, object>.OnError
	|
	|-RVA: 0x11B7910 Offset: 0x11B6310 VA: 0x1811B7910
	|-SelectObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TSource evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B79B0 Offset: 0x11B63B0 VA: 0x1811B79B0
	|-SelectObservable.Select<InputEventPtr, object>.OnNext
	|
	|-RVA: 0x11B7AA0 Offset: 0x11B64A0 VA: 0x1811B7AA0
	|-SelectObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnNext
	*/
}
