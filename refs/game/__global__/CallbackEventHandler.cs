public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 6540
{
	// Fields
	internal bool isIMGUIContainer; // 0x10
	private EventCallbackRegistry m_CallbackRegistry; // 0x18
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction";
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget";

	// Methods

	// RVA: -1 Offset: -1
	public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5DD60 Offset: 0xE5C760 VA: 0x180E5DD60
	|-CallbackEventHandler.RegisterCallback<object>
	*/

	// RVA: -1 Offset: -1
	private void AddEventCategories<TEventType>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5D940 Offset: 0xE5C340 VA: 0x180E5D940
	|-CallbackEventHandler.AddEventCategories<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5DBB0 Offset: 0xE5C5B0 VA: 0x180E5DBB0
	|-CallbackEventHandler.RegisterCallback<object, object>
	|
	|-RVA: 0xE5DA30 Offset: 0xE5C430 VA: 0x180E5DA30
	|-CallbackEventHandler.RegisterCallback<object, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5DC90 Offset: 0xE5C690 VA: 0x180E5DC90
	|-CallbackEventHandler.RegisterCallback<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5DE30 Offset: 0xE5C830 VA: 0x180E5DE30
	|-CallbackEventHandler.UnregisterCallback<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendEvent(EventBase e);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);

	// RVA: 0x2E88210 Offset: 0x2E86C10 VA: 0x182E88210
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0x2E88160 Offset: 0x2E86B60 VA: 0x182E88160
	internal void HandleEventAtTargetAndDefaultPhase(EventBase evt) { }

	// RVA: 0x79ED10 Offset: 0x79D710 VA: 0x18079ED10
	internal void HandleEventAtCurrentTargetAndPhase(EventBase evt) { }

	// RVA: 0x79ED10 Offset: 0x79D710 VA: 0x18079ED10 Slot: 5
	private void UnityEngine.UIElements.IEventHandler.HandleEvent(EventBase evt) { }

	[Obsolete("The virtual method CallbackEventHandler.HandleEvent is deprecated and will be removed in a future release. Please override ExecuteDefaultAction instead.")]
	// RVA: 0x2E88290 Offset: 0x2E86C90 VA: 0x182E88290 Slot: 8
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0x2E885C0 Offset: 0x2E86FC0 VA: 0x182E885C0 Slot: 9
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x2E88590 Offset: 0x2E86F90 VA: 0x182E88590 Slot: 10
	public bool HasBubbleUpHandlers() { }

	[EventInterest(0)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	[EventInterest(0)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[EventInterest(0)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	[EventInterest(0)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	internal virtual void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x2E885F0 Offset: 0x2E86FF0 VA: 0x182E885F0
	protected void .ctor() { }
}
