public interface IAnalyticsService // TypeDefIndex: 17917
{
	// Properties
	public abstract string PrivacyUrl { get; }
	public abstract string SessionID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_PrivacyUrl();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartDataCollection();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetAnalyticsUserID();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_SessionID();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long ConvertCurrencyToMinorUnits(string currencyCode, double value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RecordEvent(Event e);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void RecordEvent(string eventName);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void StopDataCollection();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void RequestDataDeletion();
}
