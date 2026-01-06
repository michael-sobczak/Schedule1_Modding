internal class EventCallbackRegistry // TypeDefIndex: 6534
{
	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20

	// Methods

	// RVA: 0x2E8E370 Offset: 0x2E8CD70 VA: 0x182E8E370
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0x2E8E7C0 Offset: 0x2E8D1C0 VA: 0x182E8E7C0
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0x2E8EB90 Offset: 0x2E8D590 VA: 0x182E8EB90
	public void .ctor() { }

	// RVA: 0x2E8E290 Offset: 0x2E8CC90 VA: 0x182E8E290
	private EventCallbackList GetCallbackListForWriting() { }

	// RVA: 0x2E8E270 Offset: 0x2E8CC70 VA: 0x182E8E270
	private EventCallbackList GetCallbackListForReading() { }

	// RVA: 0x2E8E8C0 Offset: 0x2E8D2C0 VA: 0x182E8E8C0
	private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown) { }

	// RVA: -1 Offset: -1
	public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE99B60 Offset: 0xE98560 VA: 0x180E99B60
	|-EventCallbackRegistry.RegisterCallback<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterCallback<TEventType, TCallbackArgs>(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE99980 Offset: 0xE98380 VA: 0x180E99980
	|-EventCallbackRegistry.RegisterCallback<object, object>
	|
	|-RVA: 0xE99690 Offset: 0xE98090 VA: 0x180E99690
	|-EventCallbackRegistry.RegisterCallback<object, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE99CE0 Offset: 0xE986E0 VA: 0x180E99CE0
	|-EventCallbackRegistry.UnregisterCallback<object>
	*/

	// RVA: 0x2E8E590 Offset: 0x2E8CF90 VA: 0x182E8E590
	public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: 0x2E8E570 Offset: 0x2E8CF70 VA: 0x182E8E570
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x2E8E550 Offset: 0x2E8CF50 VA: 0x182E8E550
	public bool HasBubbleHandlers() { }

	// RVA: 0x2E8EAB0 Offset: 0x2E8D4B0 VA: 0x182E8EAB0
	private static void .cctor() { }
}
