internal class TakeNObservable<TValue> : IObservable<TValue> // TypeDefIndex: 7835
{
	// Fields
	private IObservable<TValue> m_Source; // 0x0
	private int m_Count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TValue> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBBA0 Offset: 0x5BA5A0 VA: 0x1805BBBA0
	|-TakeNObservable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<TValue> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210690 Offset: 0x120F090 VA: 0x181210690
	|-TakeNObservable<__Il2CppFullySharedGenericType>.Subscribe
	*/
}
