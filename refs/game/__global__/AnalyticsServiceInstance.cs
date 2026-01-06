internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IServiceDebug // TypeDefIndex: 17899
{
	// Fields
	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion";
	private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup";
	private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged";
	internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked";
	private readonly TimeSpan k_BackgroundSessionRefreshPeriod; // 0x10
	private readonly TransactionCurrencyConverter converter; // 0x18
	private readonly IIdentityManager m_UserIdentity; // 0x20
	private readonly ISessionManager m_Session; // 0x28
	private readonly IDataGenerator m_DataGenerator; // 0x30
	private readonly ICoreStatsHelper m_CoreStatsHelper; // 0x38
	private readonly IDispatcher m_DataDispatcher; // 0x40
	private readonly IAnalyticsForgetter m_AnalyticsForgetter; // 0x48
	private readonly IAnalyticsServiceSystemCalls m_SystemCalls; // 0x50
	private readonly IAnalyticsContainer m_Container; // 0x58
	internal IBuffer m_DataBuffer; // 0x60
	private int m_BufferLengthAtLastGameRunning; // 0x68
	private DateTime m_ApplicationPauseTime; // 0x70
	private bool m_IsActive; // 0x78
	private bool m_StartUpEventsRecorded; // 0x79

	// Properties
	public string PrivacyUrl { get; }
	public string SessionID { get; }
	internal bool Active { get; set; }
	public bool IsActive { get; }
	public IIdentityManager UserIdentity { get; }
	internal int AutoflushPeriodMultiplier { get; }

	// Methods

	// RVA: 0x2B86B40 Offset: 0x2B85540 VA: 0x182B86B40 Slot: 4
	public string get_PrivacyUrl() { }

	// RVA: 0x2B86B70 Offset: 0x2B85570 VA: 0x182B86B70 Slot: 7
	public string get_SessionID() { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	internal bool get_Active() { }

	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	internal void set_Active(bool value) { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0 Slot: 15
	public bool get_IsActive() { }

	// RVA: 0x2B86070 Offset: 0x2B84A70 VA: 0x182B86070 Slot: 6
	public string GetAnalyticsUserID() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 16
	public IIdentityManager get_UserIdentity() { }

	// RVA: 0x2B86800 Offset: 0x2B85200 VA: 0x182B86800
	internal void .ctor(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session) { }

	// RVA: 0x2B86580 Offset: 0x2B84F80 VA: 0x182B86580
	internal void ResumeDataDeletionIfNecessary() { }

	// RVA: 0x2B865E0 Offset: 0x2B84FE0 VA: 0x182B865E0 Slot: 5
	public void StartDataCollection() { }

	// RVA: 0x2B85150 Offset: 0x2B83B50 VA: 0x182B85150
	private void Activate() { }

	// RVA: 0x2B867A0 Offset: 0x2B851A0 VA: 0x182B867A0 Slot: 12
	public void StopDataCollection() { }

	// RVA: 0x2B85C20 Offset: 0x2B84620 VA: 0x182B85C20
	internal void DeactivateWithDataDeletionRequest() { }

	// RVA: 0x2B85BC0 Offset: 0x2B845C0 VA: 0x182B85BC0
	private void DataDeletionCompleted() { }

	// RVA: 0x2B85F30 Offset: 0x2B84930 VA: 0x182B85F30
	private void Deactivate() { }

	// RVA: 0x2B86480 Offset: 0x2B84E80 VA: 0x182B86480
	private void RecordStartupEvents(string callingId) { }

	// RVA: 0x2B860C0 Offset: 0x2B84AC0 VA: 0x182B860C0
	private void PlayerChanged() { }

	// RVA: 0x2B852A0 Offset: 0x2B83CA0 VA: 0x182B852A0
	internal void ApplicationPaused(bool paused) { }

	// RVA: 0x2B86AD0 Offset: 0x2B854D0 VA: 0x182B86AD0
	internal int get_AutoflushPeriodMultiplier() { }

	// RVA: 0x2B85FE0 Offset: 0x2B849E0 VA: 0x182B85FE0 Slot: 11
	public void Flush() { }

	// RVA: 0x2B86570 Offset: 0x2B84F70 VA: 0x182B86570 Slot: 13
	public void RequestDataDeletion() { }

	// RVA: 0x2B853A0 Offset: 0x2B83DA0 VA: 0x182B853A0
	internal void ApplicationQuit() { }

	// RVA: 0x2B863B0 Offset: 0x2B84DB0 VA: 0x182B863B0
	internal void RecordGameRunningIfNecessary() { }

	// RVA: 0x2B855D0 Offset: 0x2B83FD0 VA: 0x182B855D0 Slot: 8
	public long ConvertCurrencyToMinorUnits(string currencyCode, double value) { }

	// RVA: 0x2B85AE0 Offset: 0x2B844E0 VA: 0x182B85AE0
	public void CustomData(string eventName) { }

	// RVA: 0x2B85B50 Offset: 0x2B84550 VA: 0x182B85B50
	public void CustomData(string eventName, IDictionary<string, object> eventParams) { }

	// RVA: 0x2B85770 Offset: 0x2B84170 VA: 0x182B85770 Slot: 14
	public void CustomData(string eventName, IDictionary<string, object> eventParams, Nullable<int> eventVersion, bool isStandardEvent, string callingMethodIdentifier) { }

	// RVA: 0x2B86350 Offset: 0x2B84D50 VA: 0x182B86350 Slot: 10
	public void RecordEvent(string name) { }

	// RVA: 0x2B86250 Offset: 0x2B84C50 VA: 0x182B86250 Slot: 9
	public void RecordEvent(Event e) { }

	// RVA: 0x2B86170 Offset: 0x2B84B70 VA: 0x182B86170
	internal void RecordEvent(Event e, string callingMethodIdentifier) { }
}
