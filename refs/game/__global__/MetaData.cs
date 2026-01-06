public class MetaData : SaveData // TypeDefIndex: 1053
{
	// Fields
	public DateTimeData CreationDate; // 0x28
	public DateTimeData LastPlayedDate; // 0x30
	public string CreationVersion; // 0x38
	public string LastSaveVersion; // 0x40
	public bool PlayTutorial; // 0x48

	// Methods

	// RVA: 0x5E4F70 Offset: 0x5E3970 VA: 0x1805E4F70
	public void .ctor(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial) { }
}
