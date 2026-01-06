public class MapRegionData // TypeDefIndex: 3334
{
	// Fields
	public EMapRegion Region; // 0x10
	public string Name; // 0x18
	public bool UnlockedByDefault; // 0x20
	public FullRank RankRequirement; // 0x24
	public NPC[] StartingNPCs; // 0x30
	public Sprite RegionSprite; // 0x38
	public DeliveryLocation[] RegionDeliveryLocations; // 0x40
	public MapRegionData.RegionContainer[] AdjacentRegions; // 0x48
	public Zone RegionBounds; // 0x50
	[CompilerGenerated]
	private bool <IsUnlocked>k__BackingField; // 0x58

	// Properties
	public bool IsUnlocked { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_IsUnlocked() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	private void set_IsUnlocked(bool value) { }

	// RVA: 0xA4E6C0 Offset: 0xA4D0C0 VA: 0x180A4E6C0
	public DeliveryLocation GetRandomUnscheduledDeliveryLocation() { }

	// RVA: 0xA4E8D0 Offset: 0xA4D2D0 VA: 0x180A4E8D0
	public void SetUnlocked() { }

	// RVA: 0xA4E5A0 Offset: 0xA4CFA0 VA: 0x180A4E5A0
	public List<EMapRegion> GetAdjacentRegions() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
