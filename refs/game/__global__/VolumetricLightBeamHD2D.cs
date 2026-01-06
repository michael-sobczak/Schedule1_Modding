public class VolumetricLightBeamHD2D : VolumetricLightBeamHD // TypeDefIndex: 279
{
	// Fields
	[SerializeField]
	private int m_SortingLayerID; // 0xC8
	[SerializeField]
	private int m_SortingOrder; // 0xCC

	// Properties
	public int sortingLayerID { get; set; }
	public string sortingLayerName { get; set; }
	public int sortingOrder { get; set; }

	// Methods

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public int get_sortingLayerID() { }

	// RVA: 0x6A3920 Offset: 0x6A2320 VA: 0x1806A3920
	public void set_sortingLayerID(int value) { }

	// RVA: 0x6A3910 Offset: 0x6A2310 VA: 0x1806A3910
	public string get_sortingLayerName() { }

	// RVA: 0x6A39B0 Offset: 0x6A23B0 VA: 0x1806A39B0
	public void set_sortingLayerName(string value) { }

	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	public int get_sortingOrder() { }

	// RVA: 0x6A3A50 Offset: 0x6A2450 VA: 0x1806A3A50
	public void set_sortingOrder(int value) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 8
	public override Dimensions GetDimensions() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public override bool DoesSupportSorting2D() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350 Slot: 10
	public override int GetSortingLayerID() { }

	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0 Slot: 11
	public override int GetSortingOrder() { }

	// RVA: 0x6A37C0 Offset: 0x6A21C0 VA: 0x1806A37C0
	public void .ctor() { }
}
