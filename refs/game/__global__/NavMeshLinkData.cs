public struct NavMeshLinkData // TypeDefIndex: 18867
{
	// Fields
	private Vector3 m_StartPosition; // 0x0
	private Vector3 m_EndPosition; // 0xC
	private float m_CostModifier; // 0x18
	private int m_Bidirectional; // 0x1C
	private float m_Width; // 0x20
	private int m_Area; // 0x24
	private int m_AgentTypeID; // 0x28

	// Properties
	public Vector3 startPosition { set; }
	public Vector3 endPosition { set; }
	public float costModifier { set; }
	public bool bidirectional { set; }
	public float width { set; }
	public int area { set; }
	public int agentTypeID { set; }

	// Methods

	// RVA: 0x281FE90 Offset: 0x281E890 VA: 0x18281FE90
	public void set_startPosition(Vector3 value) { }

	// RVA: 0x2C63D20 Offset: 0x2C62720 VA: 0x182C63D20
	public void set_endPosition(Vector3 value) { }

	// RVA: 0x61B4E0 Offset: 0x619EE0 VA: 0x18061B4E0
	public void set_costModifier(float value) { }

	// RVA: 0x2C63D10 Offset: 0x2C62710 VA: 0x182C63D10
	public void set_bidirectional(bool value) { }

	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	public void set_width(float value) { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_area(int value) { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_agentTypeID(int value) { }
}
