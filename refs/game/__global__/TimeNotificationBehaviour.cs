public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 17439
{
	// Fields
	private readonly List<TimeNotificationBehaviour.NotificationEntry> m_Notifications; // 0x10
	private double m_PreviousTime; // 0x18
	private bool m_NeedSortNotifications; // 0x20
	private Playable m_TimeSource; // 0x28

	// Properties
	public Playable timeSource { set; }

	// Methods

	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	public void set_timeSource(Playable value) { }

	// RVA: 0x2C5B850 Offset: 0x2C5A250 VA: 0x182C5B850
	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) { }

	// RVA: 0x2C5B660 Offset: 0x2C5A060 VA: 0x182C5B660
	public void AddNotification(double time, INotification payload, NotificationFlags flags = 2) { }

	// RVA: 0x2C5BBA0 Offset: 0x2C5A5A0 VA: 0x182C5BBA0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x2C5B970 Offset: 0x2C5A370 VA: 0x182C5B970 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2C5BD60 Offset: 0x2C5A760 VA: 0x182C5BD60 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x2C5C250 Offset: 0x2C5AC50 VA: 0x182C5C250
	private void SortNotifications() { }

	// RVA: 0x2C5B7D0 Offset: 0x2C5A1D0 VA: 0x182C5B7D0
	private static bool CanRestoreNotification(TimeNotificationBehaviour.NotificationEntry e, FrameData info, double currentTime, double previousTime) { }

	// RVA: 0x2C5C480 Offset: 0x2C5AE80 VA: 0x182C5C480
	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) { }

	// RVA: 0x2C5C390 Offset: 0x2C5AD90 VA: 0x182C5C390
	private void SyncDurationWithExternalSource(Playable playable) { }

	// RVA: 0x2C5C770 Offset: 0x2C5B170 VA: 0x182C5C770
	private static void Trigger_internal(Playable playable, PlayableOutput output, ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x50C870 Offset: 0x50B270 VA: 0x18050C870
	private static void Restore_internal(ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x2C5C7F0 Offset: 0x2C5B1F0 VA: 0x182C5C7F0
	public void .ctor() { }
}
