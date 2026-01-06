public class NPCResponses_Civilian : NPCResponses // TypeDefIndex: 1672
{
	// Fields
	public bool CanCallPolice; // 0x30
	private NPCResponses_Civilian.EAttackResponse currentThreatResponse; // 0x34
	private float lastThreatTime; // 0x38
	private Coroutine resetCoroutine; // 0x40

	// Methods

	// RVA: 0x727430 Offset: 0x725E30 VA: 0x180727430 Slot: 4
	protected override void Awake() { }

	// RVA: 0x728F80 Offset: 0x727980 VA: 0x180728F80
	private void ScheduleResetCoroutine() { }

	[IteratorStateMachine(typeof(NPCResponses_Civilian.<ResetAttackResponse>d__8))]
	// RVA: 0x7284B0 Offset: 0x726EB0 VA: 0x1807284B0
	private IEnumerator ResetAttackResponse() { }

	// RVA: 0x727F20 Offset: 0x726920 VA: 0x180727F20 Slot: 5
	public override void GunshotHeard(NoiseEvent gunshotSound) { }

	// RVA: 0x7279B0 Offset: 0x7263B0 VA: 0x1807279B0 Slot: 6
	public override void ExplosionHeard(NoiseEvent explosionSound) { }

	// RVA: 0x728070 Offset: 0x726A70 VA: 0x180728070 Slot: 12
	public override void PlayerFailedPickpocket(Player player) { }

	// RVA: 0x728940 Offset: 0x727340 VA: 0x180728940 Slot: 19
	protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x7286D0 Offset: 0x7270D0 VA: 0x1807286D0 Slot: 22
	protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact) { }

	// RVA: 0x728BC0 Offset: 0x7275C0 VA: 0x180728BC0 Slot: 21
	protected override void RespondToLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x728EF0 Offset: 0x7278F0 VA: 0x180728EF0 Slot: 20
	protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x728C50 Offset: 0x727650 VA: 0x180728C50
	private void RespondToLethalOrRepeatedAttack(Player perpetrator, Impact impact) { }

	// RVA: 0x728520 Offset: 0x726F20 VA: 0x180728520 Slot: 23
	public override void RespondToAimedAt(Player player) { }

	// RVA: 0x7274B0 Offset: 0x725EB0 VA: 0x1807274B0
	private void ExecuteThreatResponse(NPCResponses_Civilian.EAttackResponse response, Player target, Vector3 threatOrigin, Crime crime) { }

	// RVA: 0x727BD0 Offset: 0x7265D0 VA: 0x180727BD0
	private NPCResponses_Civilian.EAttackResponse GetThreatResponse(NPCResponses_Civilian.EThreatType type, Player threatSource) { }

	// RVA: 0x729030 Offset: 0x727A30 VA: 0x180729030
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x729010 Offset: 0x727A10 VA: 0x180729010
	private float <ResetAttackResponse>g__elapsedTime|8_0() { }
}
