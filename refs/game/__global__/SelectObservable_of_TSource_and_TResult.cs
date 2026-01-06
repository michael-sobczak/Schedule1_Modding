internal class SelectObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 7721
{
	// Fields
	private readonly IObservable<TSource> m_Source; // 0x0
	private readonly Func<TSource, TResult> m_Filter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, TResult> filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-SelectObservable<InputEventPtr, object>..ctor
	|-SelectObservable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B77F0 Offset: 0x11B61F0 VA: 0x1811B77F0
	|-SelectObservable<InputEventPtr, object>.Subscribe
	|
	|-RVA: 0x11B7720 Offset: 0x11B6120 VA: 0x1811B7720
	|-SelectObservable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Subscribe
	*/
}
