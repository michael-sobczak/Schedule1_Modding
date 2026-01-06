public class NPCHealthData : SaveData // TypeDefIndex: 1058
{
	// Fields
	public float Health; // 0x28
	public bool IsDead; // 0x2C
	public int DaysPassedSinceDeath; // 0x30
	public int HoursSinceAttackedByPlayer; // 0x34

	// Methods

	// RVA: 0x5E6C00 Offset: 0x5E5600 VA: 0x1805E6C00
	public void .ctor(float health, bool isDead, int daysPassedSinceDeath, int hoursSinceAttackedByPlayer) { }
}
