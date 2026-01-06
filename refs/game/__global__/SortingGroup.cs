public sealed class SortingGroup : Behaviour // TypeDefIndex: 12287
{
	// Properties
	[StaticAccessor("SortingGroup", 2)]
	internal static int invalidSortingGroupID { get; }
	public int sortingLayerID { get; }
	public int sortingOrder { get; }

	// Methods

	// RVA: 0x2CFD960 Offset: 0x2CFC360 VA: 0x182CFD960
	internal static int get_invalidSortingGroupID() { }

	[StaticAccessor("SortingGroup", 2)]
	// RVA: 0x2CFD920 Offset: 0x2CFC320 VA: 0x182CFD920
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	// RVA: 0x2CFD990 Offset: 0x2CFC390 VA: 0x182CFD990
	public int get_sortingLayerID() { }

	// RVA: 0x2CFD9D0 Offset: 0x2CFC3D0 VA: 0x182CFD9D0
	public int get_sortingOrder() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
