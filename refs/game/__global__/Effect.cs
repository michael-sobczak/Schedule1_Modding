public abstract class Effect : ScriptableObject // TypeDefIndex: 1471
{
	// Fields
	public string Name; // 0x18
	public string Description; // 0x20
	public string ID; // 0x28
	[Range(1, 5)]
	public int Tier; // 0x30
	[Range(0, 1)]
	public float Addictiveness; // 0x34
	public Color ProductColor; // 0x38
	public Color LabelColor; // 0x48
	public bool ImplementedPriorMixingRework; // 0x58
	[Header("Value")]
	[Range(-100, 100)]
	public int ValueChange; // 0x5C
	[Range(0, 2)]
	public float ValueMultiplier; // 0x60
	[Range(-1, 1)]
	public float AddBaseValueMultiple; // 0x64
	public Vector2 MixDirection; // 0x68
	public float MixMagnitude; // 0x70

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ApplyToNPC(NPC npc);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ClearFromNPC(NPC npc);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ApplyToPlayer(Player player);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ClearFromPlayer(Player player);

	// RVA: 0x6C0E80 Offset: 0x6BF880 VA: 0x1806C0E80
	public void OnValidate() { }

	// RVA: 0x6C0F40 Offset: 0x6BF940 VA: 0x1806C0F40
	protected void .ctor() { }
}
