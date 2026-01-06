public struct AnimatorStateInfo // TypeDefIndex: 18292
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public int fullPathHash { get; }
	public float normalizedTime { get; }

	// Methods

	// RVA: 0x2C774A0 Offset: 0x2C75EA0 VA: 0x182C774A0
	public bool IsName(string name) { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_fullPathHash() { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_normalizedTime() { }
}
