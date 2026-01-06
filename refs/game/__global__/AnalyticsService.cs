public static class AnalyticsService // TypeDefIndex: 17895
{
	// Fields
	private const string k_CollectUrlPattern = "https://collect.analytics.unity3d.com/api/analytics/collect/v2/projects/{0}/environments/{1}";
	private static AnalyticsServiceInstance m_Instance; // 0x0
	private static IDispatcherDebug m_DispatcherDebug; // 0x8
	private static IBufferDebug m_BufferDebug; // 0x10
	private static Action<string, string, DateTime, byte[]> m_EventRecordedCallback; // 0x18
	private static Action<HashSet<string>> m_EventsClearingCallback; // 0x20
	private static Action<byte[]> m_FlushStartedCallback; // 0x28
	private static Action<int, bool, bool, bool, bool, byte[]> m_FlushCompletedCallback; // 0x30

	// Properties
	internal static bool IsInitialized { get; }
	internal static IServiceDebug ServiceDebug { get; }
	internal static IDispatcherDebug DispatcherDebug { get; }
	public static IAnalyticsService Instance { get; }

	// Methods

	// RVA: 0x2B87D40 Offset: 0x2B86740 VA: 0x182B87D40
	internal static bool get_IsInitialized() { }

	// RVA: 0x2B87D80 Offset: 0x2B86780 VA: 0x182B87D80
	internal static IServiceDebug get_ServiceDebug() { }

	// RVA: 0x2B87C70 Offset: 0x2B86670 VA: 0x182B87C70
	internal static IDispatcherDebug get_DispatcherDebug() { }

	// RVA: 0x2B86C00 Offset: 0x2B85600 VA: 0x182B86C00
	internal static void Initialize(CoreRegistry registry) { }

	// RVA: 0x2B87790 Offset: 0x2B86190 VA: 0x182B87790
	internal static void SubscribeDebugEvents(Action<string, string, DateTime, byte[]> eventRecordedCallback, Action<HashSet<string>> eventsUploadingCallback, Action<byte[]> flushStarted, Action<int, bool, bool, bool, bool, byte[]> flushCompleted) { }

	// RVA: 0x2B87B10 Offset: 0x2B86510 VA: 0x182B87B10
	internal static void UnsubscribeDebugEvents() { }

	// RVA: 0x2B87970 Offset: 0x2B86370 VA: 0x182B87970
	internal static void TearDown() { }

	// RVA: 0x2B87CB0 Offset: 0x2B866B0 VA: 0x182B87CB0
	public static IAnalyticsService get_Instance() { }
}
