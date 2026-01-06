public struct WheelHit // TypeDefIndex: 19201
{
	// Fields
	[NativeName("point")]
	private Vector3 m_Point; // 0x0
	[NativeName("normal")]
	private Vector3 m_Normal; // 0xC
	[NativeName("forwardDir")]
	private Vector3 m_ForwardDir; // 0x18
	[NativeName("sidewaysDir")]
	private Vector3 m_SidewaysDir; // 0x24
	[NativeName("force")]
	private float m_Force; // 0x30
	[NativeName("forwardSlip")]
	private float m_ForwardSlip; // 0x34
	[NativeName("sidewaysSlip")]
	private float m_SidewaysSlip; // 0x38
	[NativeName("collider")]
	private Collider m_Collider; // 0x40

	// Properties
	public float forwardSlip { get; }
	public float sidewaysSlip { get; }

	// Methods

	// RVA: 0x2D2B1F0 Offset: 0x2D29BF0 VA: 0x182D2B1F0
	public float get_forwardSlip() { }

	// RVA: 0x2BC3240 Offset: 0x2BC1C40 VA: 0x182BC3240
	public float get_sidewaysSlip() { }
}
