public struct OffMeshLinkData // TypeDefIndex: 18862
{
	// Fields
	internal int m_Valid; // 0x0
	internal int m_Activated; // 0x4
	internal int m_InstanceID; // 0x8
	internal OffMeshLinkType m_LinkType; // 0xC
	internal Vector3 m_StartPos; // 0x10
	internal Vector3 m_EndPos; // 0x1C

	// Properties
	public OffMeshLink offMeshLink { get; }

	// Methods

	// RVA: 0x2C65130 Offset: 0x2C63B30 VA: 0x182C65130
	public OffMeshLink get_offMeshLink() { }

	[FreeFunction("OffMeshLinkScriptBindings::GetOffMeshLinkInternal")]
	// RVA: 0x2C650F0 Offset: 0x2C63AF0 VA: 0x182C650F0
	internal static OffMeshLink GetOffMeshLinkInternal(int instanceID) { }
}
