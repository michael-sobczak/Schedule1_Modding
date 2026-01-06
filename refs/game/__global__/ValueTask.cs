private sealed class ValueTask.ValueTaskSourceAsTask<TResult> : Task<TResult> // TypeDefIndex: 4016
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource<TResult> _source; // 0x0
	private readonly short _token; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1318D90 Offset: 0x1317790 VA: 0x181318D90
	|-ValueTask.ValueTaskSourceAsTask<int>..ctor
	|
	|-RVA: 0x1318C00 Offset: 0x1317600 VA: 0x181318C00
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1318900 Offset: 0x1317300 VA: 0x181318900
	|-ValueTask.ValueTaskSourceAsTask<int>..cctor
	|
	|-RVA: 0x1318A80 Offset: 0x1317480 VA: 0x181318A80
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..cctor
	*/
}
