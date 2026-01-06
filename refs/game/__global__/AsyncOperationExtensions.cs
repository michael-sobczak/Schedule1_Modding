internal static class AsyncOperationExtensions // TypeDefIndex: 17826
{
	// Methods

	[Extension]
	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public static AsyncOperationAwaiter GetAwaiter(IAsyncOperation self) { }

	[Extension]
	// RVA: 0x2B9AB70 Offset: 0x2B99570 VA: 0x182B9AB70
	public static Task AsTask(IAsyncOperation self) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static AsyncOperationAwaiter<T> GetAwaiter<T>(IAsyncOperation<T> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4F9C0 Offset: 0xE4E3C0 VA: 0x180E4F9C0
	|-AsyncOperationExtensions.GetAwaiter<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Task<T> AsTask<T>(IAsyncOperation<T> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4F760 Offset: 0xE4E160 VA: 0x180E4F760
	|-AsyncOperationExtensions.AsTask<__Il2CppFullySharedGenericType>
	*/
}
