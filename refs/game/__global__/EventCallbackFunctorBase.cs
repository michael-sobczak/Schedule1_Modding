internal abstract class EventCallbackFunctorBase // TypeDefIndex: 6526
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly CallbackPhase <phase>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly InvokePolicy <invokePolicy>k__BackingField; // 0x14

	// Properties
	public CallbackPhase phase { get; }
	public InvokePolicy invokePolicy { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public CallbackPhase get_phase() { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public InvokePolicy get_invokePolicy() { }

	// RVA: 0x797650 Offset: 0x796050 VA: 0x180797650
	protected void .ctor(CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);

	// RVA: 0x2E8D800 Offset: 0x2E8C200 VA: 0x182E8D800
	protected bool PhaseMatches(PropagationPhase propagationPhase) { }
}
