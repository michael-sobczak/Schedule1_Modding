public static class Observable // TypeDefIndex: 7830
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IObservable<TValue> Where<TValue>(IObservable<TValue> source, Func<TValue, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A9F0 Offset: 0xF193F0 VA: 0x180F1A9F0
	|-Observable.Where<object>
	|
	|-RVA: 0xF1A8E0 Offset: 0xF192E0 VA: 0x180F1A8E0
	|-Observable.Where<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IObservable<TResult> Select<TSource, TResult>(IObservable<TSource> source, Func<TSource, TResult> filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A6C0 Offset: 0xF190C0 VA: 0x180F1A6C0
	|-Observable.Select<InputEventPtr, object>
	|
	|-RVA: 0xF1A5B0 Offset: 0xF18FB0 VA: 0x180F1A5B0
	|-Observable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TResult>(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A5B0 Offset: 0xF18FB0 VA: 0x180F1A5B0
	|-Observable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IObservable<TValue> Take<TValue>(IObservable<TValue> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A7D0 Offset: 0xF191D0 VA: 0x180F1A7D0
	|-Observable.Take<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x278FD00 Offset: 0x278E700 VA: 0x18278FD00
	public static IObservable<InputEventPtr> ForDevice(IObservable<InputEventPtr> source, InputDevice device) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IObservable<InputEventPtr> ForDevice<TDevice>(IObservable<InputEventPtr> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A4C0 Offset: 0xF18EC0 VA: 0x180F1A4C0
	|-Observable.ForDevice<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IDisposable CallOnce<TValue>(IObservable<TValue> source, Action<TValue> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A190 Offset: 0xF18B90 VA: 0x180F1A190
	|-Observable.CallOnce<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IDisposable Call<TValue>(IObservable<TValue> source, Action<TValue> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1A390 Offset: 0xF18D90 VA: 0x180F1A390
	|-Observable.Call<__Il2CppFullySharedGenericType>
	*/
}
