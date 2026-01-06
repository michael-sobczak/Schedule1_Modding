public class AchievementManager : PersistentSingleton<AchievementManager> // TypeDefIndex: 595
{
	// Fields
	private AchievementManager.EAchievement[] achievements; // 0x28
	private Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked; // 0x30

	// Methods

	// RVA: 0xA94850 Offset: 0xA93250 VA: 0x180A94850 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA94C30 Offset: 0xA93630 VA: 0x180A94C30 Slot: 4
	protected override void Start() { }

	// RVA: 0xA94AE0 Offset: 0xA934E0 VA: 0x180A94AE0
	private void PullAchievements() { }

	// RVA: 0xA94EA0 Offset: 0xA938A0 VA: 0x180A94EA0
	public void UnlockAchievement(AchievementManager.EAchievement achievement) { }

	// RVA: 0xA95010 Offset: 0xA93A10 VA: 0x180A95010
	public void .ctor() { }
}
