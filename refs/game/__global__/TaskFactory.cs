public class TaskFactory // TypeDefIndex: 4076
{
	// Fields
	private readonly CancellationToken m_defaultCancellationToken; // 0x10
	private readonly TaskScheduler m_defaultScheduler; // 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; // 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x1CF7CA0 Offset: 0x1CF66A0 VA: 0x181CF7CA0
	public void .ctor() { }

	// RVA: 0x1CF7CF0 Offset: 0x1CF66F0 VA: 0x181CF7CF0
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1CF73E0 Offset: 0x1CF5DE0 VA: 0x181CF73E0
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x1CF7AE0 Offset: 0x1CF64E0 VA: 0x181CF7AE0
	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1CF7910 Offset: 0x1CF6310 VA: 0x181CF7910
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5CCE0 Offset: 0xF5B6E0 VA: 0x180F5CCE0
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0xF5CB70 Offset: 0xF5B570 VA: 0x180F5CB70
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5CAB0 Offset: 0xF5B4B0 VA: 0x180F5CAB0
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0xF5CD90 Offset: 0xF5B790 VA: 0x180F5CD90
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0xF5CC20 Offset: 0xF5B620 VA: 0x180F5CC20
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5CA10 Offset: 0xF5B410 VA: 0x180F5CA10
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0xF5C650 Offset: 0xF5B050 VA: 0x180F5C650
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C9A0 Offset: 0xF5B3A0 VA: 0x180F5C9A0
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0xF5C770 Offset: 0xF5B170 VA: 0x180F5C770
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C8F0 Offset: 0xF5B2F0 VA: 0x180F5C8F0
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0xF5C4C0 Offset: 0xF5AEC0 VA: 0x180F5C4C0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C880 Offset: 0xF5B280 VA: 0x180F5C880
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0xF5C320 Offset: 0xF5AD20 VA: 0x180F5C320
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CF7450 Offset: 0x1CF5E50 VA: 0x181CF7450
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x1CF76C0 Offset: 0x1CF60C0 VA: 0x181CF76C0
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x1CF7580 Offset: 0x1CF5F80 VA: 0x181CF7580
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}
