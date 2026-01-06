public struct XRNodeState // TypeDefIndex: 18902
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0xCC6430 Offset: 0xCC4E30 VA: 0x180CC6430
	public void set_uniqueID(ulong value) { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_nodeType(XRNode value) { }

	// RVA: 0x2F61580 Offset: 0x2F5FF80 VA: 0x182F61580
	public void set_tracked(bool value) { }
}
