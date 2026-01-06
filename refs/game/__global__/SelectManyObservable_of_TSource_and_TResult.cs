internal class SelectManyObservable<TSource, TResult> : IObservable<TResult> // TypeDefIndex: 7833
{
	// Fields
	private readonly IObservable<TSource> m_Source; // 0x0
	private readonly Func<TSource, IEnumerable<TResult>> m_Filter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-SelectManyObservable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B7720 Offset: 0x11B6120 VA: 0x1811B7720
	|-SelectManyObservable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Subscribe
	*/
}
