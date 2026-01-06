public class NPCResponses_CartelGoon : NPCResponses // TypeDefIndex: 2055
{
	// Fields
	[Header("References")]
	public CartelGoon Goon; // 0x30

	// Methods

	// RVA: 0x7E2CC0 Offset: 0x7E16C0 VA: 0x1807E2CC0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7E2CD0 Offset: 0x7E16D0 VA: 0x1807E2CD0 Slot: 6
	public override void ExplosionHeard(NoiseEvent explosionSound) { }

	// RVA: 0x7E2CD0 Offset: 0x7E16D0 VA: 0x1807E2CD0 Slot: 5
	public override void GunshotHeard(NoiseEvent gunshotSound) { }

	// RVA: 0x7E2F10 Offset: 0x7E1910 VA: 0x1807E2F10 Slot: 11
	public override void NoticePlayerDischargingWeapon(Player player) { }

	// RVA: 0x7E2FA0 Offset: 0x7E19A0 VA: 0x1807E2FA0 Slot: 12
	public override void PlayerFailedPickpocket(Player player) { }

	// RVA: 0x7E2D70 Offset: 0x7E1770 VA: 0x1807E2D70 Slot: 17
	public override void HitByCar(LandVehicle vehicle) { }

	// RVA: 0x7E2DB0 Offset: 0x7E17B0 VA: 0x1807E2DB0 Slot: 18
	public override void ImpactReceived(Impact impact) { }

	// RVA: 0x7E2FE0 Offset: 0x7E19E0 VA: 0x1807E2FE0 Slot: 23
	public override void RespondToAimedAt(Player player) { }

	// RVA: 0x7E3020 Offset: 0x7E1A20 VA: 0x1807E3020 Slot: 22
	protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
