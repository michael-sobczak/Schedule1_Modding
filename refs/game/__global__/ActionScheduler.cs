internal class ActionScheduler : IActionScheduler, IServiceComponent // TypeDefIndex: 19237
{
	// Fields
	internal readonly PlayerLoopSystem SchedulerLoopSystem; // 0x10
	private readonly ITimeProvider m_TimeProvider; // 0x38
	private readonly object m_Lock; // 0x40
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions; // 0x48
	private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap; // 0x50
	private readonly List<ScheduledInvocation> m_ExpiredActions; // 0x58
	private long m_NextId; // 0x60

	// Methods

	// RVA: 0x2BA7920 Offset: 0x2BA6320 VA: 0x182BA7920
	public void .ctor() { }

	// RVA: 0x2BA76A0 Offset: 0x2BA60A0 VA: 0x182BA76A0
	public void .ctor(ITimeProvider timeProvider) { }

	// RVA: 0x2BA7350 Offset: 0x2BA5D50 VA: 0x182BA7350 Slot: 4
	public long ScheduleAction(Action action, double delaySeconds = 0) { }

	// RVA: 0x2BA6AA0 Offset: 0x2BA54A0 VA: 0x182BA6AA0 Slot: 5
	public void CancelAction(long actionId) { }

	// RVA: 0x2BA6C00 Offset: 0x2BA5600 VA: 0x182BA6C00
	internal void ExecuteExpiredActions() { }

	// RVA: 0x2BA7610 Offset: 0x2BA6010 VA: 0x182BA7610
	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

	// RVA: 0x2BA70F0 Offset: 0x2BA5AF0 VA: 0x182BA70F0
	public void JoinPlayerLoopSystem() { }
}
