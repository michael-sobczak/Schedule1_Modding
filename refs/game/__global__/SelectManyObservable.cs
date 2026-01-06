private class SelectManyObservable.Select<TSource, TResult> : IObserver<TSource> // TypeDefIndex: 7832
{
	// Fields
	private SelectManyObservable<TSource, TResult> m_Observable; // 0x0
	private readonly IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable<TSource, TResult> observable, IObserver<TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-SelectManyObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-SelectManyObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B78C0 Offset: 0x11B62C0 VA: 0x1811B78C0
	|-SelectManyObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TSource evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B7CA0 Offset: 0x11B66A0 VA: 0x1811B7CA0
	|-SelectManyObservable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnNext
	*/
}
