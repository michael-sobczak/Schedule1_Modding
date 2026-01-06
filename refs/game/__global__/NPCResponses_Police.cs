public class NPCResponses_Police : NPCResponses // TypeDefIndex: 2057
{
	// Fields
	private PoliceOfficer officer; // 0x30

	// Methods

	// RVA: 0x7E31E0 Offset: 0x7E1BE0 VA: 0x1807E31E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7E3420 Offset: 0x7E1E20 VA: 0x1807E3420 Slot: 17
	public override void HitByCar(LandVehicle vehicle) { }

	// RVA: 0x7E3A10 Offset: 0x7E2410 VA: 0x1807E3A10 Slot: 13
	public override void NoticedDrugDeal(Player player) { }

	// RVA: 0x7E3BD0 Offset: 0x7E25D0 VA: 0x1807E3BD0 Slot: 7
	public override void NoticedPettyCrime(Player player) { }

	// RVA: 0x7E3E70 Offset: 0x7E2870 VA: 0x1807E3E70 Slot: 8
	public override void NoticedVandalism(Player player) { }

	// RVA: 0x7E4EC0 Offset: 0x7E38C0 VA: 0x1807E4EC0 Slot: 9
	public override void SawPickpocketing(Player player) { }

	// RVA: 0x7E4640 Offset: 0x7E3040 VA: 0x1807E4640 Slot: 12
	public override void PlayerFailedPickpocket(Player player) { }

	// RVA: 0x7E3690 Offset: 0x7E2090 VA: 0x1807E3690 Slot: 10
	public override void NoticePlayerBrandishingWeapon(Player player) { }

	// RVA: 0x7E3850 Offset: 0x7E2250 VA: 0x1807E3850 Slot: 11
	public override void NoticePlayerDischargingWeapon(Player player) { }

	// RVA: 0x7E4360 Offset: 0x7E2D60 VA: 0x1807E4360 Slot: 15
	public override void NoticedWantedPlayer(Player player) { }

	// RVA: 0x7E3D40 Offset: 0x7E2740 VA: 0x1807E3D40 Slot: 16
	public override void NoticedSuspiciousPlayer(Player player) { }

	// RVA: 0x7E4030 Offset: 0x7E2A30 VA: 0x1807E4030 Slot: 14
	public override void NoticedViolatingCurfew(Player player) { }

	// RVA: 0x7E4A90 Offset: 0x7E3490 VA: 0x1807E4A90 Slot: 19
	protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x7E4BF0 Offset: 0x7E35F0 VA: 0x1807E4BF0 Slot: 21
	protected override void RespondToLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x7E4D40 Offset: 0x7E3740 VA: 0x1807E4D40 Slot: 20
	protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x7E48D0 Offset: 0x7E32D0 VA: 0x1807E48D0 Slot: 22
	protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact) { }

	// RVA: 0x7E4800 Offset: 0x7E3200 VA: 0x1807E4800 Slot: 23
	public override void RespondToAimedAt(Player player) { }

	// RVA: 0x7E3630 Offset: 0x7E2030 VA: 0x1807E3630 Slot: 18
	public override void ImpactReceived(Impact impact) { }

	// RVA: 0x7E32C0 Offset: 0x7E1CC0 VA: 0x1807E32C0 Slot: 5
	public override void GunshotHeard(NoiseEvent gunshotSound) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
