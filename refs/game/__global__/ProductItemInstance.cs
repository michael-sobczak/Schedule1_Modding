public class ProductItemInstance : QualityItemInstance // TypeDefIndex: 2473
{
	// Fields
	public string PackagingID; // 0x40
	[CodegenExclude]
	private PackagingDefinition packaging; // 0x48

	// Properties
	[CodegenExclude]
	public PackagingDefinition AppliedPackaging { get; }
	[CodegenExclude]
	public int Amount { get; }
	public override string Name { get; }
	[CodegenExclude]
	public override Equippable Equippable { get; }
	[CodegenExclude]
	public override StoredItem StoredItem { get; }
	[CodegenExclude]
	public override Sprite Icon { get; }

	// Methods

	// RVA: 0x895A90 Offset: 0x894490 VA: 0x180895A90
	public PackagingDefinition get_AppliedPackaging() { }

	// RVA: 0x8959F0 Offset: 0x8943F0 VA: 0x1808959F0
	public int get_Amount() { }

	// RVA: 0x895D80 Offset: 0x894780 VA: 0x180895D80 Slot: 4
	public override string get_Name() { }

	// RVA: 0x895030 Offset: 0x893A30 VA: 0x180895030 Slot: 10
	public override Equippable get_Equippable() { }

	// RVA: 0x895770 Offset: 0x894170 VA: 0x180895770 Slot: 16
	public override StoredItem get_StoredItem() { }

	// RVA: 0x895C60 Offset: 0x894660 VA: 0x180895C60 Slot: 6
	public override Sprite get_Icon() { }

	// RVA: 0x88DD80 Offset: 0x88C780 VA: 0x18088DD80
	public void .ctor() { }

	// RVA: 0x8958E0 Offset: 0x8942E0 VA: 0x1808958E0
	public void .ctor(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging) { }

	// RVA: 0x894720 Offset: 0x893120 VA: 0x180894720 Slot: 11
	public override bool CanStackWith(ItemInstance other, bool checkQuantities = True) { }

	// RVA: 0x894F80 Offset: 0x893980 VA: 0x180894F80 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x895810 Offset: 0x894210 VA: 0x180895810 Slot: 17
	public virtual void SetPackaging(PackagingDefinition def) { }

	// RVA: 0x895030 Offset: 0x893A30 VA: 0x180895030
	private Equippable GetEquippable() { }

	// RVA: 0x895770 Offset: 0x894170 VA: 0x180895770
	private StoredItem GetStoredItem() { }

	// RVA: 0x8950D0 Offset: 0x893AD0 VA: 0x1808950D0
	private Sprite GetIcon() { }

	// RVA: 0x8951E0 Offset: 0x893BE0 VA: 0x1808951E0 Slot: 14
	public override ItemData GetItemData() { }

	// RVA: 0x894E30 Offset: 0x893830 VA: 0x180894E30 Slot: 18
	public virtual float GetAddictiveness() { }

	// RVA: 0x895470 Offset: 0x893E70 VA: 0x180895470
	public float GetSimilarity(ProductDefinition other, EQuality quality) { }

	// RVA: 0x894220 Offset: 0x892C20 VA: 0x180894220 Slot: 19
	public virtual void ApplyEffectsToNPC(NPC npc) { }

	// RVA: 0x894930 Offset: 0x893330 VA: 0x180894930 Slot: 20
	public virtual void ClearEffectsFromNPC(NPC npc) { }

	// RVA: 0x8944A0 Offset: 0x892EA0 VA: 0x1808944A0 Slot: 21
	public virtual void ApplyEffectsToPlayer(Player player) { }

	// RVA: 0x894BB0 Offset: 0x8935B0 VA: 0x180894BB0 Slot: 22
	public virtual void ClearEffectsFromPlayer(Player Player) { }

	// RVA: 0x8952B0 Offset: 0x893CB0 VA: 0x1808952B0 Slot: 15
	public override float GetMonetaryValue() { }
}
