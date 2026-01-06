internal class WhereObservable<TValue> : IObservable<TValue> // TypeDefIndex: 7837
{
	// Fields
	private readonly IObservable<TValue> m_Source; // 0x0
	private readonly Func<TValue, bool> m_Predicate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TValue> source, Func<TValue, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-WhereObservable<object>..ctor
	|-WhereObservable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<TValue> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B77F0 Offset: 0x11B61F0 VA: 0x1811B77F0
	|-WhereObservable<object>.Subscribe
	|
	|-RVA: 0x11B7720 Offset: 0x11B6120 VA: 0x1811B7720
	|-WhereObservable<__Il2CppFullySharedGenericType>.Subscribe
	*/
}
