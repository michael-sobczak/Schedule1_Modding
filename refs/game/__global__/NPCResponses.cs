public class NPCResponses : MonoBehaviour // TypeDefIndex: 1668
{
	// Fields
	public const float ASSAULT_RELATIONSHIPCHANGE = -0.25;
	public const float DEADLYASSAULT_RELATIONSHIPCHANGE = -1;
	public const float AIMED_AT_RELATIONSHIPCHANGE = -0.5;
	public const float PICKPOCKET_RELATIONSHIPCHANGE = -0.25;
	[CompilerGenerated]
	private NPC <npc>k__BackingField; // 0x20
	private const float INITIALIZED_TIME_OFFSET = 100;
	private const float TIME_THRESHOLD = 20;
	protected float timeSinceLastImpact; // 0x28
	protected float timeSinceAimedAt; // 0x2C

	// Properties
	protected NPC npc { get; set; }
	protected NPCActions actions { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	protected NPC get_npc() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_npc(NPC value) { }

	// RVA: 0x729670 Offset: 0x728070 VA: 0x180729670
	protected NPCActions get_actions() { }

	// RVA: 0x7273B0 Offset: 0x725DB0 VA: 0x1807273B0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void GunshotHeard(NoiseEvent gunshotSound) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void ExplosionHeard(NoiseEvent explosionSound) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void NoticedPettyCrime(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void NoticedVandalism(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void SawPickpocketing(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void NoticePlayerBrandishingWeapon(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void NoticePlayerDischargingWeapon(Player player) { }

	// RVA: 0x729450 Offset: 0x727E50 VA: 0x180729450 Slot: 12
	public virtual void PlayerFailedPickpocket(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void NoticedDrugDeal(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public virtual void NoticedViolatingCurfew(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	public virtual void NoticedWantedPlayer(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public virtual void NoticedSuspiciousPlayer(Player player) { }

	// RVA: 0x729040 Offset: 0x727A40 VA: 0x180729040 Slot: 17
	public virtual void HitByCar(LandVehicle vehicle) { }

	// RVA: 0x7292E0 Offset: 0x727CE0 VA: 0x1807292E0 Slot: 18
	public virtual void ImpactReceived(Impact impact) { }

	// RVA: 0x729520 Offset: 0x727F20 VA: 0x180729520 Slot: 19
	protected virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x729600 Offset: 0x728000 VA: 0x180729600 Slot: 20
	protected virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x729590 Offset: 0x727F90 VA: 0x180729590 Slot: 21
	protected virtual void RespondToLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	protected virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact) { }

	// RVA: 0x7294B0 Offset: 0x727EB0 VA: 0x1807294B0 Slot: 23
	public virtual void RespondToAimedAt(Player player) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
