public class VODatabase : ScriptableObject // TypeDefIndex: 602
{
	// Fields
	[Range(0, 2)]
	public float VolumeMultiplier; // 0x18
	public List<VODatabaseEntry> Entries; // 0x20

	// Methods

	// RVA: 0xAAF2A0 Offset: 0xAADCA0 VA: 0x180AAF2A0
	public VODatabaseEntry GetEntry(EVOLineType lineType) { }

	// RVA: 0xAAF3E0 Offset: 0xAADDE0 VA: 0x180AAF3E0
	public AudioClip GetRandomClip(EVOLineType lineType) { }

	// RVA: 0xAAF500 Offset: 0xAADF00 VA: 0x180AAF500
	public void .ctor() { }
}
