public class RankData : SaveData // TypeDefIndex: 1278
{
	// Fields
	public int Rank; // 0x28
	public int Tier; // 0x2C
	public int XP; // 0x30
	public int TotalXP; // 0x34
	public List<EMapRegion> UnlockedRegions; // 0x38

	// Methods

	// RVA: 0x620C10 Offset: 0x61F610 VA: 0x180620C10
	public void .ctor(int rank, int tier, int xp, int totalXP, List<EMapRegion> unlockedRegions) { }
}
