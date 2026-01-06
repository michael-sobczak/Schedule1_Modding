public class RouteListField : ConfigField // TypeDefIndex: 1220
{
	// Fields
	public List<AdvancedTransitRoute> Routes; // 0x18
	public int MaxRoutes; // 0x20
	public UnityEvent<List<AdvancedTransitRoute>> onListChanged; // 0x28

	// Methods

	// RVA: 0x621F10 Offset: 0x620910 VA: 0x180621F10
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x621DF0 Offset: 0x6207F0 VA: 0x180621DF0
	public void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = False) { }

	// RVA: 0x621D70 Offset: 0x620770 VA: 0x180621D70
	public void Replicate() { }

	// RVA: 0x6212F0 Offset: 0x61FCF0 VA: 0x1806212F0
	public void AddItem(AdvancedTransitRoute item) { }

	// RVA: 0x621C80 Offset: 0x620680 VA: 0x180621C80
	public void RemoveItem(AdvancedTransitRoute item) { }

	// RVA: 0x621630 Offset: 0x620030 VA: 0x180621630 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x6214A0 Offset: 0x61FEA0 VA: 0x1806214A0
	public RouteListData GetData() { }

	// RVA: 0x621680 Offset: 0x620080 VA: 0x180621680
	public void Load(RouteListData data) { }
}
