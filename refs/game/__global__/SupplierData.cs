public class SupplierData : NPCData // TypeDefIndex: 1066
{
	// Fields
	public int timeSinceMeetingStart; // 0x30
	public int timeSinceLastMeetingEnd; // 0x34
	public float debt; // 0x38
	public int minsUntilDeadDropReady; // 0x3C
	public StringIntPair[] deaddropItems; // 0x40
	public bool debtReminderSent; // 0x48

	// Methods

	// RVA: 0x5ECEF0 Offset: 0x5EB8F0 VA: 0x1805ECEF0
	public void .ctor(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, StringIntPair[] _deaddropItems, bool _debtReminderSent) { }
}
