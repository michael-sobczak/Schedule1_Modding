public sealed class ProbeReferenceVolumeProfile : ScriptableObject // TypeDefIndex: 13745
{
	// Fields
	[SerializeField]
	private ProbeReferenceVolumeProfile.Version version; // 0x18
	[SerializeField]
	internal bool freezePlacement; // 0x1C
	[Range(2, 5)]
	public int simplificationLevels; // 0x20
	[Min(0.1)]
	public float minDistanceBetweenProbes; // 0x24
	public LayerMask renderersLayerMask; // 0x28
	[Min(0)]
	public float minRendererVolumeSize; // 0x2C

	// Properties
	public int cellSizeInBricks { get; }
	public int maxSubdivision { get; }
	public float minBrickSize { get; }
	public float cellSizeInMeters { get; }

	// Methods

	// RVA: 0x2A21170 Offset: 0x2A1FB70 VA: 0x182A21170
	public int get_cellSizeInBricks() { }

	// RVA: 0x2A211F0 Offset: 0x2A1FBF0 VA: 0x182A211F0
	public int get_maxSubdivision() { }

	// RVA: 0x2A21200 Offset: 0x2A1FC00 VA: 0x182A21200
	public float get_minBrickSize() { }

	// RVA: 0x2A211A0 Offset: 0x2A1FBA0 VA: 0x182A211A0
	public float get_cellSizeInMeters() { }

	// RVA: 0x2A21080 Offset: 0x2A1FA80 VA: 0x182A21080
	private void OnEnable() { }

	// RVA: 0x2A20F70 Offset: 0x2A1F970 VA: 0x182A20F70
	public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile) { }

	// RVA: 0x2A210E0 Offset: 0x2A1FAE0 VA: 0x182A210E0
	public void .ctor() { }
}
