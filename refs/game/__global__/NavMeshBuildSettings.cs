public struct NavMeshBuildSettings // TypeDefIndex: 18878
{
	// Fields
	private int m_AgentTypeID; // 0x0
	private float m_AgentRadius; // 0x4
	private float m_AgentHeight; // 0x8
	private float m_AgentSlope; // 0xC
	private float m_AgentClimb; // 0x10
	private float m_LedgeDropHeight; // 0x14
	private float m_MaxJumpAcrossDistance; // 0x18
	private float m_MinRegionArea; // 0x1C
	private int m_OverrideVoxelSize; // 0x20
	private float m_VoxelSize; // 0x24
	private int m_OverrideTileSize; // 0x28
	private int m_TileSize; // 0x2C
	private int m_BuildHeightMesh; // 0x30
	private uint m_MaxJobWorkers; // 0x34
	private int m_PreserveTilesOutsideBounds; // 0x38
	private NavMeshBuildDebugSettings m_Debug; // 0x3C

	// Properties
	public int agentTypeID { get; set; }
	public float agentRadius { get; }
	public float minRegionArea { set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }
	public bool buildHeightMesh { set; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_agentTypeID() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_agentTypeID(int value) { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_agentRadius() { }

	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	public void set_minRegionArea(float value) { }

	// RVA: 0x2C62C80 Offset: 0x2C61680 VA: 0x182C62C80
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void set_voxelSize(float value) { }

	// RVA: 0x2C62C70 Offset: 0x2C61670 VA: 0x182C62C70
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_tileSize(int value) { }

	// RVA: 0x2C62C60 Offset: 0x2C61660 VA: 0x182C62C60
	public void set_buildHeightMesh(bool value) { }
}
