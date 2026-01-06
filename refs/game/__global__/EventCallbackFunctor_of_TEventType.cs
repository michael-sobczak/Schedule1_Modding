internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase // TypeDefIndex: 6527
{
	// Fields
	private readonly EventCallback<TEventType> m_Callback; // 0x0
	private readonly long m_EventTypeId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACA50 Offset: 0x17AB450 VA: 0x1817ACA50
	|-EventCallbackFunctor<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(EventBase evt, PropagationPhase propagationPhase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC860 Offset: 0x17AB260 VA: 0x1817AC860
	|-EventCallbackFunctor<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACA00 Offset: 0x17AB400 VA: 0x1817ACA00
	|-EventCallbackFunctor<object>.IsEquivalentTo
	*/
}
