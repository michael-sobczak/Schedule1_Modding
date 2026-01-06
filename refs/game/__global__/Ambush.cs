public class Ambush : CartelActivity // TypeDefIndex: 2066
{
	// Fields
	public const float MIN_DISTANCE_TO_POLICE_OFFICER = 15;
	public const int CANCEL_AMBUSH_AFTER_MINS = 360;
	public const float AMBUSH_DEFEATED_INFLUENCE_CHANGE = -0.1;
	public static FullRank MIN_RANK_FOR_RANGED_WEAPONS; // 0x0
	private CartelRegionActivities _regionActivities; // 0x40
	[Header("Settings")]
	public AvatarWeapon[] RangedWeapons; // 0x48
	public AvatarWeapon[] MeleeWeapons; // 0x50
	[Header("Debugging & Development")]
	public EMapRegion region; // 0x58

	// Methods

	// RVA: 0x7DA510 Offset: 0x7D8F10 VA: 0x1807DA510 Slot: 4
	public override void Activate(EMapRegion region) { }

	// RVA: 0x7DAD20 Offset: 0x7D9720 VA: 0x1807DAD20 Slot: 7
	protected override void Deactivate() { }

	// RVA: 0x7DAE90 Offset: 0x7D9890 VA: 0x1807DAE90 Slot: 5
	protected override void MinPassed() { }

	// RVA: 0x7DA720 Offset: 0x7D9120 VA: 0x1807DA720
	private bool CanPlayerBeAmbushed(Player player) { }

	// RVA: 0x7DA7C0 Offset: 0x7D91C0 VA: 0x1807DA7C0
	private void ContractReceiptRecorded(ContractReceipt receipt) { }

	// RVA: 0x7DB480 Offset: 0x7D9E80 VA: 0x1807DB480
	private void SpawnAmbush(Player target, Vector3[] potentialSpawnPoints) { }

	[Button]
	// RVA: 0x7DBC20 Offset: 0x7DA620 VA: 0x1807DBC20
	public void TriggerAmbushForPlayer() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x7DC0F0 Offset: 0x7DAAF0 VA: 0x1807DC0F0
	private static void .cctor() { }
}
