public struct FilteringSettings : IEquatable<FilteringSettings> // TypeDefIndex: 12248
{
	// Fields
	private RenderQueueRange m_RenderQueueRange; // 0x0
	private int m_LayerMask; // 0x8
	private uint m_RenderingLayerMask; // 0xC
	private int m_ExcludeMotionVectorObjects; // 0x10
	private SortingLayerRange m_SortingLayerRange; // 0x14

	// Properties
	public RenderQueueRange renderQueueRange { get; set; }
	public int layerMask { get; set; }
	public uint renderingLayerMask { set; }
	public bool excludeMotionVectorObjects { set; }
	public SortingLayerRange sortingLayerRange { set; }

	// Methods

	// RVA: 0x2CDFEB0 Offset: 0x2CDE8B0 VA: 0x182CDFEB0
	public void .ctor(Nullable<RenderQueueRange> renderQueueRange, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0) { }

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public RenderQueueRange get_renderQueueRange() { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void set_renderQueueRange(RenderQueueRange value) { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_layerMask() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_layerMask(int value) { }

	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_renderingLayerMask(uint value) { }

	// RVA: 0x2C62BB0 Offset: 0x2C615B0 VA: 0x182C62BB0
	public void set_excludeMotionVectorObjects(bool value) { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_sortingLayerRange(SortingLayerRange value) { }

	// RVA: 0x2CDFCE0 Offset: 0x2CDE6E0 VA: 0x182CDFCE0 Slot: 4
	public bool Equals(FilteringSettings other) { }

	// RVA: 0x2CDFDA0 Offset: 0x2CDE7A0 VA: 0x182CDFDA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CDFE40 Offset: 0x2CDE840 VA: 0x182CDFE40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CDFF80 Offset: 0x2CDE980 VA: 0x182CDFF80
	public static bool op_Equality(FilteringSettings left, FilteringSettings right) { }
}
