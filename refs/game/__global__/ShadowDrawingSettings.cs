public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings> // TypeDefIndex: 12268
{
	// Fields
	private CullingResults m_CullingResults; // 0x0
	private int m_LightIndex; // 0x10
	private int m_UseRenderingLayerMaskTest; // 0x14
	private ShadowSplitData m_SplitData; // 0x18
	private ShadowObjectsFilter m_ObjectsFilter; // 0x114
	private BatchCullingProjectionType m_ProjectionType; // 0x118

	// Properties
	public bool useRenderingLayerMaskTest { set; }
	public ShadowSplitData splitData { set; }

	// Methods

	// RVA: 0x2C62B90 Offset: 0x2C61590 VA: 0x182C62B90
	public void set_useRenderingLayerMaskTest(bool value) { }

	// RVA: 0x2CFD0E0 Offset: 0x2CFBAE0 VA: 0x182CFD0E0
	public void set_splitData(ShadowSplitData value) { }

	// RVA: 0x2CFD030 Offset: 0x2CFBA30 VA: 0x182CFD030
	public void .ctor(CullingResults cullingResults, int lightIndex, BatchCullingProjectionType projectionType) { }

	// RVA: 0x2CFCA80 Offset: 0x2CFB480 VA: 0x182CFCA80 Slot: 4
	public bool Equals(ShadowDrawingSettings other) { }

	// RVA: 0x2CFCE80 Offset: 0x2CFB880 VA: 0x182CFCE80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CFCFA0 Offset: 0x2CFB9A0 VA: 0x182CFCFA0 Slot: 2
	public override int GetHashCode() { }
}
