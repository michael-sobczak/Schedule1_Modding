internal class UnityThreadUtilsInternal : IUnityThreadUtils, IServiceComponent // TypeDefIndex: 19398
{
	// Properties
	private bool Unity.Services.Core.Threading.Internal.IUnityThreadUtils.IsRunningOnUnityThread { get; }

	// Methods

	// RVA: 0x2BA7DE0 Offset: 0x2BA67E0 VA: 0x182BA7DE0
	public static Task PostAsync(Action action) { }

	// RVA: 0x2BA7F00 Offset: 0x2BA6900 VA: 0x182BA7F00
	public static Task PostAsync(Action<object> action, object state) { }

	// RVA: -1 Offset: -1
	public static Task<T> PostAsync<T>(Func<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66670 Offset: 0xF65070 VA: 0x180F66670
	|-UnityThreadUtilsInternal.PostAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<T> PostAsync<T>(Func<object, T> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66750 Offset: 0xF65150 VA: 0x180F66750
	|-UnityThreadUtilsInternal.PostAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2BA80A0 Offset: 0x2BA6AA0 VA: 0x182BA80A0
	public static void Send(Action action) { }

	// RVA: 0x2BA8030 Offset: 0x2BA6A30 VA: 0x182BA8030
	public static void Send(Action<object> action, object state) { }

	// RVA: -1 Offset: -1
	public static T Send<T>(Func<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66970 Offset: 0xF65370 VA: 0x180F66970
	|-UnityThreadUtilsInternal.Send<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Send<T>(Func<object, T> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66850 Offset: 0xF65250 VA: 0x180F66850
	|-UnityThreadUtilsInternal.Send<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2BA8200 Offset: 0x2BA6C00 VA: 0x182BA8200 Slot: 4
	private bool Unity.Services.Core.Threading.Internal.IUnityThreadUtils.get_IsRunningOnUnityThread() { }

	// RVA: 0x2BA8120 Offset: 0x2BA6B20 VA: 0x182BA8120 Slot: 5
	private Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(Action action) { }

	// RVA: 0x2BA8100 Offset: 0x2BA6B00 VA: 0x182BA8100 Slot: 6
	private Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(Action<object> action, object state) { }

	// RVA: -1 Offset: -1 Slot: 7
	private Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<T>(Func<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66A80 Offset: 0xF65480 VA: 0x180F66A80
	|-UnityThreadUtilsInternal.Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<T>(Func<object, T> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66AC0 Offset: 0xF654C0 VA: 0x180F66AC0
	|-UnityThreadUtilsInternal.Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2BA8130 Offset: 0x2BA6B30 VA: 0x182BA8130 Slot: 9
	private void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(Action action) { }

	// RVA: 0x2BA8190 Offset: 0x2BA6B90 VA: 0x182BA8190 Slot: 10
	private void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(Action<object> action, object state) { }

	// RVA: -1 Offset: -1 Slot: 11
	private T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<T>(Func<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66B10 Offset: 0xF65510 VA: 0x180F66B10
	|-UnityThreadUtilsInternal.Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<T>(Func<object, T> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF66BC0 Offset: 0xF655C0 VA: 0x180F66BC0
	|-UnityThreadUtilsInternal.Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
