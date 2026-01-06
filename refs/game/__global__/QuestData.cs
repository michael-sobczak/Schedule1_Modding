public class QuestData : SaveData // TypeDefIndex: 1103
{
	// Fields
	public string GUID; // 0x28
	public EQuestState State; // 0x30
	public bool IsTracked; // 0x34
	public string Title; // 0x38
	public string Description; // 0x40
	public bool Expires; // 0x48
	public GameDateTimeData ExpiryDate; // 0x50
	public QuestEntryData[] Entries; // 0x58

	// Methods

	// RVA: 0x5EA160 Offset: 0x5E8B60 VA: 0x1805EA160
	public void .ctor(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, QuestEntryData[] entries) { }
}
