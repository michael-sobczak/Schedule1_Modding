public struct ContactFilter2D // TypeDefIndex: 18830
{
	// Fields
	[NativeName("m_UseTriggers")]
	public bool useTriggers; // 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; // 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; // 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; // 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; // 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; // 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; // 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; // 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; // 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; // 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; // 0x18
	public const float NormalAngleUpperLimit = 359.9999;

	// Methods

	// RVA: 0x2D2E0B0 Offset: 0x2D2CAB0 VA: 0x182D2E0B0
	private void CheckConsistency() { }

	// RVA: 0x2D2E250 Offset: 0x2D2CC50 VA: 0x182D2E250
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x2D2E200 Offset: 0x2D2CC00 VA: 0x182D2E200
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x2D2E0F0 Offset: 0x2D2CAF0 VA: 0x182D2E0F0
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x2D2E0B0 Offset: 0x2D2CAB0 VA: 0x182D2E0B0
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }
}
