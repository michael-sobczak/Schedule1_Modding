public class ShroomInstance : ProductItemInstance // TypeDefIndex: 2504
{
	// Fields
	private static Coroutine _psychedelicEffectCoroutine; // 0x0

	// Properties
	public override string Name { get; }
	private ShroomDefinition _shroomDefinition { get; }

	// Methods

	// RVA: 0x8BCED0 Offset: 0x8BB8D0 VA: 0x1808BCED0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x8BCF50 Offset: 0x8BB950 VA: 0x1808BCF50
	private ShroomDefinition get__shroomDefinition() { }

	// RVA: 0x8BCEC0 Offset: 0x8BB8C0 VA: 0x1808BCEC0
	public void .ctor() { }

	// RVA: 0x88DD70 Offset: 0x88C770 VA: 0x18088DD70
	public void .ctor(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging) { }

	// RVA: 0x8BCD30 Offset: 0x8BB730 VA: 0x1808BCD30 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x8BCDE0 Offset: 0x8BB7E0 VA: 0x1808BCDE0 Slot: 14
	public override ItemData GetItemData() { }

	// RVA: 0x8BC1C0 Offset: 0x8BABC0 VA: 0x1808BC1C0 Slot: 19
	public override void ApplyEffectsToNPC(NPC npc) { }

	// RVA: 0x8BC720 Offset: 0x8BB120 VA: 0x1808BC720 Slot: 20
	public override void ClearEffectsFromNPC(NPC npc) { }

	// RVA: 0x8BC210 Offset: 0x8BAC10 VA: 0x1808BC210 Slot: 21
	public override void ApplyEffectsToPlayer(Player player) { }

	// RVA: 0x8BC7E0 Offset: 0x8BB1E0 VA: 0x1808BC7E0 Slot: 22
	public override void ClearEffectsFromPlayer(Player player) { }

	// RVA: 0x8BC070 Offset: 0x8BAA70 VA: 0x1808BC070
	private void ApplyEffectsToAvatar(Avatar avatar) { }

	// RVA: 0x8BC6A0 Offset: 0x8BB0A0 VA: 0x1808BC6A0
	private void ClearEffectsFromAvatar(Avatar avatar) { }

	[IteratorStateMachine(typeof(ShroomInstance.<DoPsychedlicEffectBlend>d__15))]
	// RVA: 0x8BCCA0 Offset: 0x8BB6A0 VA: 0x1808BCCA0
	private IEnumerator DoPsychedlicEffectBlend(PsychedelicFullScreenFeature.MaterialProperties targetMaterialProperties, float targetValuePercentage, float duration) { }
}
