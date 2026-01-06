public class Athletic : Effect // TypeDefIndex: 1433
{
	// Fields
	public const float SPEED_MULTIPLIER = 1.3;
	public const float NPC_SPEED_MULTIPLIER = 1.8;
	[SerializeField]
	[ColorUsage(True, True)]
	public Color TintColor; // 0x78

	// Methods

	// RVA: 0x6A7610 Offset: 0x6A6010 VA: 0x1806A7610 Slot: 4
	public override void ApplyToNPC(NPC npc) { }

	// RVA: 0x6A76B0 Offset: 0x6A60B0 VA: 0x1806A76B0 Slot: 6
	public override void ApplyToPlayer(Player player) { }

	// RVA: 0x6A7A30 Offset: 0x6A6430 VA: 0x1806A7A30 Slot: 5
	public override void ClearFromNPC(NPC npc) { }

	// RVA: 0x6A7AB0 Offset: 0x6A64B0 VA: 0x1806A7AB0 Slot: 7
	public override void ClearFromPlayer(Player player) { }

	// RVA: 0x6A7DC0 Offset: 0x6A67C0 VA: 0x1806A7DC0
	public void .ctor() { }
}
