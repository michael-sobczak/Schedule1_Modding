public class AdvancedTransitRouteData // TypeDefIndex: 1027
{
	// Fields
	public string SourceGUID; // 0x10
	public string DestinationGUID; // 0x18
	public ManagementItemFilter.EMode FilterMode; // 0x20
	public List<string> FilterItemIDs; // 0x28

	// Methods

	// RVA: 0x5D4760 Offset: 0x5D3160 VA: 0x1805D4760
	public void .ctor(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
