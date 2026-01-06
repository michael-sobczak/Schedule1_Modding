public struct RasterState : IEquatable<RasterState> // TypeDefIndex: 12252
{
	// Fields
	public static readonly RasterState defaultValue; // 0x0
	private CullMode m_CullingMode; // 0x0
	private int m_OffsetUnits; // 0x4
	private float m_OffsetFactor; // 0x8
	private byte m_DepthClip; // 0xC
	private byte m_Conservative; // 0xD
	private byte m_Padding1; // 0xE
	private byte m_Padding2; // 0xF

	// Methods

	// RVA: 0x2CE63A0 Offset: 0x2CE4DA0 VA: 0x182CE63A0
	public void .ctor(CullMode cullingMode = 2, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = True) { }

	// RVA: 0x2CE6120 Offset: 0x2CE4B20 VA: 0x182CE6120 Slot: 4
	public bool Equals(RasterState other) { }

	// RVA: 0x2CE6180 Offset: 0x2CE4B80 VA: 0x182CE6180 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CE6290 Offset: 0x2CE4C90 VA: 0x182CE6290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CE6300 Offset: 0x2CE4D00 VA: 0x182CE6300
	private static void .cctor() { }
}
