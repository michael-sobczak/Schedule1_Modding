public class NPCAwareness : MonoBehaviour // TypeDefIndex: 1637
{
	// Fields
	public const float PLAYER_AIM_DETECTION_RANGE = 15;
	public bool AwarenessActiveByDefault; // 0x20
	[Header("References")]
	public VisionCone VisionCone; // 0x28
	public Listener Listener; // 0x30
	public NPCResponses Responses; // 0x38
	public UnityEvent<Player> onNoticedGeneralCrime; // 0x40
	public UnityEvent<Player> onNoticedPettyCrime; // 0x48
	public UnityEvent<Player> onNoticedDrugDealing; // 0x50
	public UnityEvent<Player> onNoticedPlayerViolatingCurfew; // 0x58
	public UnityEvent<Player> onNoticedSuspiciousPlayer; // 0x60
	public UnityEvent<NoiseEvent> onGunshotHeard; // 0x68
	public UnityEvent<NoiseEvent> onExplosionHeard; // 0x70
	public UnityEvent<LandVehicle> onHitByCar; // 0x78
	private NPC npc; // 0x80

	// Methods

	// RVA: 0x702B80 Offset: 0x701580 VA: 0x180702B80 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x703040 Offset: 0x701A40 VA: 0x180703040
	public void SetAwarenessActive(bool active) { }

	// RVA: 0x7030A0 Offset: 0x701AA0 VA: 0x1807030A0
	public void VisionEvent(VisionEventReceipt vEvent) { }

	// RVA: 0x702EF0 Offset: 0x7018F0 VA: 0x180702EF0
	public void NoiseEvent(NoiseEvent nEvent) { }

	// RVA: 0x702E30 Offset: 0x701830 VA: 0x180702E30
	public void HitByCar(LandVehicle vehicle) { }

	// RVA: 0x567D00 Offset: 0x566700 VA: 0x180567D00
	public void .ctor() { }
}
