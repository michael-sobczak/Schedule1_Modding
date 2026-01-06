private class TakeNObservable.Take<TValue> : IObserver<TValue> // TypeDefIndex: 7834
{
	// Fields
	private IObserver<TValue> m_Observer; // 0x0
	private int m_Remaining; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeNObservable<TValue> observable, IObserver<TValue> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210970 Offset: 0x120F370 VA: 0x181210970
	|-TakeNObservable.Take<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-TakeNObservable.Take<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12107C0 Offset: 0x120F1C0 VA: 0x1812107C0
	|-TakeNObservable.Take<__Il2CppFullySharedGenericType>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TValue evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210810 Offset: 0x120F210 VA: 0x181210810
	|-TakeNObservable.Take<__Il2CppFullySharedGenericType>.OnNext
	*/
}
