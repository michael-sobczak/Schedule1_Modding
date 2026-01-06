public class NPCPresenceAccessZone : AccessZone // TypeDefIndex: 3349
{
	// Fields
	public const float CooldownTime = 0.5;
	public Collider DetectionZone; // 0x48
	public NPC TargetNPC; // 0x50
	private float timeSinceNPCSensed; // 0x58

	// Methods

	// RVA: 0xA486C0 Offset: 0xA470C0 VA: 0x180A486C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xA51850 Offset: 0xA50250 VA: 0x180A51850 Slot: 6
	protected virtual void Start() { }

	// RVA: 0xA51740 Offset: 0xA50140 VA: 0x180A51740 Slot: 7
	protected virtual void MinPass() { }

	// RVA: 0xA51950 Offset: 0xA50350 VA: 0x180A51950
	public void .ctor() { }
}
