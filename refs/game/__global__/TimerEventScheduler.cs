internal class TimerEventScheduler : IScheduler // TypeDefIndex: 6764
{
	// Fields
	private readonly List<ScheduledItem> m_ScheduledItems; // 0x10
	private bool m_TransactionMode; // 0x18
	private readonly List<ScheduledItem> m_ScheduleTransactions; // 0x20
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; // 0x28
	internal bool disableThrottling; // 0x30
	private int m_LastUpdatedIndex; // 0x34

	// Methods

	// RVA: 0x2EE2850 Offset: 0x2EE1250 VA: 0x182EE2850 Slot: 5
	public void Schedule(ScheduledItem item) { }

	// RVA: 0x2EE27E0 Offset: 0x2EE11E0 VA: 0x182EE27E0
	private bool RemovedScheduledItemAt(int index) { }

	// RVA: 0x2EE2A30 Offset: 0x2EE1430 VA: 0x182EE2A30 Slot: 4
	public void Unschedule(ScheduledItem item) { }

	// RVA: 0x2EE2700 Offset: 0x2EE1100 VA: 0x182EE2700
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	// RVA: 0x2EE2CA0 Offset: 0x2EE16A0 VA: 0x182EE2CA0 Slot: 6
	public void UpdateScheduledEvents() { }

	// RVA: 0x2EE3280 Offset: 0x2EE1C80 VA: 0x182EE3280
	public void .ctor() { }
}
