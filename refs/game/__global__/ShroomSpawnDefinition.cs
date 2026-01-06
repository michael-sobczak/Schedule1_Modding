public class ShroomSpawnDefinition : StorableItemDefinition // TypeDefIndex: 3086
{
	// Fields
	[SerializeField]
	[CompilerGenerated]
	private ShroomColony <ColonyPrefab>k__BackingField; // 0xC0
	[CompilerGenerated]
	[SerializeField]
	private ShroomDefinition <Shroom>k__BackingField; // 0xC8
	[CompilerGenerated]
	[SerializeField]
	private SpawnChunk <ChunkPrefab>k__BackingField; // 0xD0
	[CompilerGenerated]
	[SerializeField]
	private DecalProjector <MixTaskProjectorPrefab>k__BackingField; // 0xD8

	// Properties
	public ShroomColony ColonyPrefab { get; set; }
	public ShroomDefinition Shroom { get; set; }
	public SpawnChunk ChunkPrefab { get; set; }
	public DecalProjector MixTaskProjectorPrefab { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public ShroomColony get_ColonyPrefab() { }

	[CompilerGenerated]
	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	private void set_ColonyPrefab(ShroomColony value) { }

	[CompilerGenerated]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public ShroomDefinition get_Shroom() { }

	[CompilerGenerated]
	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	private void set_Shroom(ShroomDefinition value) { }

	[CompilerGenerated]
	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public SpawnChunk get_ChunkPrefab() { }

	[CompilerGenerated]
	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	private void set_ChunkPrefab(SpawnChunk value) { }

	[CompilerGenerated]
	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	public DecalProjector get_MixTaskProjectorPrefab() { }

	[CompilerGenerated]
	// RVA: 0x4E8E20 Offset: 0x4E7820 VA: 0x1804E8E20
	private void set_MixTaskProjectorPrefab(DecalProjector value) { }

	// RVA: 0x8BC060 Offset: 0x8BAA60 VA: 0x1808BC060 Slot: 5
	public override void ValidateDefinition() { }

	// RVA: 0x8681A0 Offset: 0x866BA0 VA: 0x1808681A0
	public void .ctor() { }
}
