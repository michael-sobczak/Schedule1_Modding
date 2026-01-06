internal interface IAnalyticsForgetter // TypeDefIndex: 17935
{
	// Properties
	public abstract bool DeletionInProgress { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DeletionInProgress();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ResetDataDeletionStatus();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback);
}
