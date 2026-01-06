public class SewerData : SaveData // TypeDefIndex: 1108
{
	// Fields
	public bool IsSewerUnlocked; // 0x28
	public bool IsRandomWorldKeyCollected; // 0x29
	public int RandomSewerKeyLocationIndex; // 0x2C
	public bool HasSewerKingBeenDefeated; // 0x30
	public int HoursSinceLastSewerGoblinAppearance; // 0x34
	public int RandomKeyPossessorIndex; // 0x38
	public bool RandomKeyPossessorSet; // 0x3C
	public List<int> ActiveMushroomLocationIndices; // 0x40

	// Methods

	// RVA: 0x5EB6A0 Offset: 0x5EA0A0 VA: 0x1805EB6A0
	public void .ctor(bool isSewerUnlocked, bool isRandomWorldKeyCollected, int randomSewerKeyLocationIndex, bool hasSewerKingBeenDefeated, int hoursSinceLastSewerGoblinAppearance, int randomKeyPossessorIndex, List<int> activeMushroomLocationIndices) { }
}
