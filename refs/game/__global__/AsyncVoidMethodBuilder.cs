public struct AsyncVoidMethodBuilder // TypeDefIndex: 4626
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	internal Task Task { get; }

	// Methods

	// RVA: 0x1B5F850 Offset: 0x1B5E250 VA: 0x181B5F850
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC4EC0 Offset: 0xDC38C0 VA: 0x180DC4EC0
	|-AsyncVoidMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE57F60 Offset: 0xE56960 VA: 0x180E57F60
	|-AsyncVoidMethodBuilder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0xE58020 Offset: 0xE56A20 VA: 0x180E58020
	|-AsyncVoidMethodBuilder.Start<UnityServicesInitializer.<EnableServicesInitializationAsync>d__1>
	|
	|-RVA: 0xE580E0 Offset: 0xE56AE0 VA: 0x180E580E0
	|-AsyncVoidMethodBuilder.Start<WebOperation.<Run>d__58>
	*/

	// RVA: 0x1B5FA90 Offset: 0x1B5E490 VA: 0x181B5FA90
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE57400 Offset: 0xE55E00 VA: 0x180E57400
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<Run>d__58>
	|
	|-RVA: 0xE57D70 Offset: 0xE56770 VA: 0x180E57D70
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInitializer.<EnableServicesInitializationAsync>d__1>
	|
	|-RVA: 0xE57AA0 Offset: 0xE564A0 VA: 0x180E57AA0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE57640 Offset: 0xE56040 VA: 0x180E57640
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0xE57860 Offset: 0xE56260 VA: 0x180E57860
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebOperation.<Run>d__58>
	*/

	// RVA: 0x1B5FA30 Offset: 0x1B5E430 VA: 0x181B5FA30
	public void SetResult() { }

	// RVA: 0x1B5F910 Offset: 0x1B5E310 VA: 0x181B5F910
	public void SetException(Exception exception) { }

	// RVA: 0x1B5F8C0 Offset: 0x1B5E2C0 VA: 0x181B5F8C0
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x1B5FB60 Offset: 0x1B5E560 VA: 0x181B5FB60
	internal Task get_Task() { }
}
