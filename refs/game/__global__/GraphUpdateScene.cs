public class GraphUpdateScene : GraphModifier // TypeDefIndex: 13153
{
	// Fields
	public Vector3[] points; // 0x40
	private Vector3[] convexPoints; // 0x48
	public bool convex; // 0x50
	public float minBoundsHeight; // 0x54
	public int penaltyDelta; // 0x58
	public bool modifyWalkability; // 0x5C
	public bool setWalkability; // 0x5D
	public bool applyOnStart; // 0x5E
	public bool applyOnScan; // 0x5F
	public bool updatePhysics; // 0x60
	public bool resetPenaltyOnPhysics; // 0x61
	public bool updateErosion; // 0x62
	public bool modifyTag; // 0x63
	public int setTag; // 0x64
	[HideInInspector]
	public bool legacyMode; // 0x68
	private int setTagInvert; // 0x6C
	private bool firstApplied; // 0x70
	[SerializeField]
	private int serializedVersion; // 0x74
	[FormerlySerializedAs("useWorldSpace")]
	[SerializeField]
	private bool legacyUseWorldSpace; // 0x78

	// Methods

	// RVA: 0xB0D7A0 Offset: 0xB0C1A0 VA: 0x180B0D7A0
	public void Start() { }

	// RVA: 0xB0D710 Offset: 0xB0C110 VA: 0x180B0D710 Slot: 13
	public override void OnPostScan() { }

	// RVA: 0xB0CCA0 Offset: 0xB0B6A0 VA: 0x180B0CCA0 Slot: 19
	public virtual void InvertSettings() { }

	// RVA: 0xB0D720 Offset: 0xB0C120 VA: 0x180B0D720
	public void RecalcConvex() { }

	[Obsolete("World space can no longer be used as it does not work well with rotated graphs. Use transform.InverseTransformPoint to transform points to local space.", True)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ToggleUseWorldSpace() { }

	[Obsolete("The Y coordinate is no longer important. Use the position of the object instead", True)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void LockToY() { }

	// RVA: 0xB0C8A0 Offset: 0xB0B2A0 VA: 0x180B0C8A0
	public Bounds GetBounds() { }

	// RVA: 0xB0BD10 Offset: 0xB0A710 VA: 0x180B0BD10
	public void Apply() { }

	// RVA: 0xB0CCF0 Offset: 0xB0B6F0 VA: 0x180B0CCF0
	private void OnDrawGizmos() { }

	// RVA: 0xB0CCE0 Offset: 0xB0B6E0 VA: 0x180B0CCE0
	private void OnDrawGizmosSelected() { }

	// RVA: 0xB0CD00 Offset: 0xB0B700 VA: 0x180B0CD00
	private void OnDrawGizmos(bool selected) { }

	// RVA: 0xB0C730 Offset: 0xB0B130 VA: 0x180B0C730
	public void DisableLegacyMode() { }

	// RVA: 0xB0C700 Offset: 0xB0B100 VA: 0x180B0C700 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB0D810 Offset: 0xB0C210 VA: 0x180B0D810
	public void .ctor() { }
}
