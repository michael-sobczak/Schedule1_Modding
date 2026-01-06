internal static class NotificationUtilities // TypeDefIndex: 17462
{
	// Methods

	// RVA: 0x2C5A140 Offset: 0x2C58B40 VA: 0x182C5A140
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, PlayableDirector director) { }

	// RVA: 0x2C5A100 Offset: 0x2C58B00 VA: 0x182C5A100
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, TimelineAsset timelineAsset) { }

	// RVA: 0x2C59AB0 Offset: 0x2C584B0 VA: 0x182C59AB0
	private static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, IPlayableAsset asset, PlayableDirector director) { }

	// RVA: 0x2C5A180 Offset: 0x2C58B80 VA: 0x182C5A180
	public static bool TrackTypeSupportsNotifications(Type type) { }
}
