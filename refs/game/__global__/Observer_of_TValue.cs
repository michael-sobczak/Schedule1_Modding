internal class Observer<TValue> : IObserver<TValue> // TypeDefIndex: 7831
{
	// Fields
	private Action<TValue> m_OnNext; // 0x0
	private Action m_OnCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<TValue> onNext, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-Observer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EDAF0 Offset: 0x10EC4F0 VA: 0x1810EDAF0
	|-Observer<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EDB10 Offset: 0x10EC510 VA: 0x1810EDB10
	|-Observer<__Il2CppFullySharedGenericType>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TValue evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EDB60 Offset: 0x10EC560 VA: 0x1810EDB60
	|-Observer<__Il2CppFullySharedGenericType>.OnNext
	*/
}
