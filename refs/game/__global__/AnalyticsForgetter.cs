internal class AnalyticsForgetter : IAnalyticsForgetter // TypeDefIndex: 17937
{
	// Fields
	private const string k_ForgottenStatusKey = "unity.services.analytics.data_deletion_status";
	private readonly string m_CollectUrl; // 0x10
	private readonly IPersistence m_Persistence; // 0x18
	private readonly IWebRequestHelper m_WebRequestHelper; // 0x20
	private Action m_Callback; // 0x28
	private AnalyticsForgetter.DataDeletionStatus m_DeletionStatus; // 0x30
	private IWebRequest m_Request; // 0x38

	// Properties
	public bool DeletionInProgress { get; }

	// Methods

	// RVA: 0x24F8540 Offset: 0x24F6F40 VA: 0x1824F8540 Slot: 4
	public bool get_DeletionInProgress() { }

	// RVA: 0x2B85020 Offset: 0x2B83A20 VA: 0x182B85020
	internal void .ctor(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper) { }

	// RVA: 0x2B84E10 Offset: 0x2B83810 VA: 0x182B84E10 Slot: 5
	public void ResetDataDeletionStatus() { }

	// RVA: 0x2B84E80 Offset: 0x2B83880 VA: 0x182B84E80
	private void SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus state) { }

	// RVA: 0x2B848C0 Offset: 0x2B832C0 VA: 0x182B848C0 Slot: 6
	public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback) { }

	// RVA: 0x2B84EF0 Offset: 0x2B838F0 VA: 0x182B84EF0
	private void UploadComplete(long code) { }
}
