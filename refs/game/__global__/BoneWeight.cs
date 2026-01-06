public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 11722
{
	// Fields
	[SerializeField]
	private float m_Weight0; // 0x0
	[SerializeField]
	private float m_Weight1; // 0x4
	[SerializeField]
	private float m_Weight2; // 0x8
	[SerializeField]
	private float m_Weight3; // 0xC
	[SerializeField]
	private int m_BoneIndex0; // 0x10
	[SerializeField]
	private int m_BoneIndex1; // 0x14
	[SerializeField]
	private int m_BoneIndex2; // 0x18
	[SerializeField]
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; }
	public float weight1 { get; }
	public float weight2 { get; }
	public float weight3 { get; }
	public int boneIndex0 { get; }
	public int boneIndex1 { get; }
	public int boneIndex2 { get; }
	public int boneIndex3 { get; }

	// Methods

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_weight0() { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_weight1() { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_weight2() { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_weight3() { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public int get_boneIndex0() { }

	// RVA: 0x1667070 Offset: 0x1665A70 VA: 0x181667070
	public int get_boneIndex1() { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	public int get_boneIndex2() { }

	// RVA: 0x180D280 Offset: 0x180BC80 VA: 0x18180D280
	public int get_boneIndex3() { }

	// RVA: 0x2C804F0 Offset: 0x2C7EEF0 VA: 0x182C804F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2C80450 Offset: 0x2C7EE50 VA: 0x182C80450 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2C80380 Offset: 0x2C7ED80 VA: 0x182C80380 Slot: 4
	public bool Equals(BoneWeight other) { }
}
