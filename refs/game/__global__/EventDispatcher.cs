public sealed class EventDispatcher // TypeDefIndex: 6496
{
	// Fields
	internal ClickDetector m_ClickDetector; // 0x10
	private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
	private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool; // 0x0
	private Queue<EventDispatcher.EventRecord> m_Queue; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x28
	private uint m_GateCount; // 0x30
	private uint m_GateDepth; // 0x34
	internal const int k_MaxGateDepth = 500;
	internal const int k_NumberOfEventsWithStackInfo = 10;
	internal const int k_NumberOfEventsWithEventInfo = 100;
	private int m_DispatchStackFrame; // 0x38
	private EventBase m_CurrentEvent; // 0x40
	private Stack<EventDispatcher.DispatchContext> m_DispatchContexts; // 0x48
	private static readonly IEventDispatchingStrategy[] s_EditorStrategies; // 0x8
	private bool m_Immediate; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <processingEvents>k__BackingField; // 0x51

	// Properties
	internal PointerDispatchState pointerState { get; }
	private bool dispatchImmediately { get; }
	private bool processingEvents { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0x2E8FE60 Offset: 0x2E8E860 VA: 0x182E8FE60
	internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies) { }

	[Obsolete("Please use EventDispatcher.CreateDefault().")]
	// RVA: 0x2E91440 Offset: 0x2E8FE40 VA: 0x182E91440
	internal void .ctor() { }

	// RVA: 0x2E914A0 Offset: 0x2E8FEA0 VA: 0x182E914A0
	private void .ctor(IList<IEventDispatchingStrategy> strategies) { }

	// RVA: 0x2E91670 Offset: 0x2E90070 VA: 0x182E91670
	private bool get_dispatchImmediately() { }

	[CompilerGenerated]
	// RVA: 0x605240 Offset: 0x603C40 VA: 0x180605240
	private void set_processingEvents(bool value) { }

	// RVA: 0x2E8FEC0 Offset: 0x2E8E8C0 VA: 0x182E8FEC0
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0x2E900C0 Offset: 0x2E8EAC0 VA: 0x182E900C0
	private bool HandleRecursiveState(EventBase evt) { }

	// RVA: 0x2E8FE50 Offset: 0x2E8E850 VA: 0x182E8FE50
	internal void CloseGate() { }

	// RVA: 0x2E904D0 Offset: 0x2E8EED0 VA: 0x182E904D0
	internal void OpenGate() { }

	// RVA: 0x2E905A0 Offset: 0x2E8EFA0 VA: 0x182E905A0
	private void ProcessEventQueue() { }

	// RVA: 0x2E90840 Offset: 0x2E8F240 VA: 0x182E90840
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x2E8FBC0 Offset: 0x2E8E5C0 VA: 0x182E8FBC0
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0x2E90F00 Offset: 0x2E8F900 VA: 0x182E90F00
	private static void .cctor() { }
}
