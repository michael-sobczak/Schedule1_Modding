internal class EventCallbackFunctor<TEventType, TCallbackArgs> : EventCallbackFunctorBase // TypeDefIndex: 6528
{
	// Fields
	private readonly EventCallback<TEventType, TCallbackArgs> m_Callback; // 0x0
	private readonly long m_EventTypeId; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TCallbackArgs <userArgs>k__BackingField; // 0x0

	// Properties
	internal TCallbackArgs userArgs { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal TCallbackArgs get_userArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	|-EventCallbackFunctor<object, object>.get_userArgs
	|
	|-RVA: 0x17AD270 Offset: 0x17ABC70 VA: 0x1817AD270
	|-EventCallbackFunctor<object, __Il2CppFullySharedGenericType>.get_userArgs
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_userArgs(TCallbackArgs value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	|-EventCallbackFunctor<object, object>.set_userArgs
	|
	|-RVA: 0x17AD320 Offset: 0x17ABD20 VA: 0x1817AD320
	|-EventCallbackFunctor<object, __Il2CppFullySharedGenericType>.set_userArgs
	*/

	// RVA: -1 Offset: -1
	public void .ctor(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACFF0 Offset: 0x17AB9F0 VA: 0x1817ACFF0
	|-EventCallbackFunctor<object, object>..ctor
	|
	|-RVA: 0x17AD0A0 Offset: 0x17ABAA0 VA: 0x1817AD0A0
	|-EventCallbackFunctor<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(EventBase evt, PropagationPhase propagationPhase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACD90 Offset: 0x17AB790 VA: 0x1817ACD90
	|-EventCallbackFunctor<object, object>.Invoke
	|
	|-RVA: 0x17ACAE0 Offset: 0x17AB4E0 VA: 0x1817ACAE0
	|-EventCallbackFunctor<object, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACA00 Offset: 0x17AB400 VA: 0x1817ACA00
	|-EventCallbackFunctor<object, object>.IsEquivalentTo
	|
	|-RVA: 0x17ACF40 Offset: 0x17AB940 VA: 0x1817ACF40
	|-EventCallbackFunctor<object, __Il2CppFullySharedGenericType>.IsEquivalentTo
	*/
}
