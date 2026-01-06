public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 14174
{
	// Fields
	[Range(0, 180)]
	public float twistLimit; // 0x40
	[Range(0, 3)]
	public int smoothIterations; // 0x44
	[HideInInspector]
	public RotationLimitPolygonal.LimitPoint[] points; // 0x48
	[HideInInspector]
	public Vector3[] P; // 0x50
	[HideInInspector]
	public RotationLimitPolygonal.ReachCone[] reachCones; // 0x58

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F2C9A0 Offset: 0x1F2B3A0 VA: 0x181F2C9A0
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F2C940 Offset: 0x1F2B340 VA: 0x181F2C940
	private void OpenScriptReference() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F2DD60 Offset: 0x1F2C760 VA: 0x181F2DD60
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F2B870 Offset: 0x1F2A270 VA: 0x181F2B870
	private void ASThread() { }

	// RVA: 0x1F2D3E0 Offset: 0x1F2BDE0 VA: 0x181F2D3E0
	public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points) { }

	// RVA: 0x1F2C3B0 Offset: 0x1F2ADB0 VA: 0x181F2C3B0 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x1F2DB00 Offset: 0x1F2C500 VA: 0x181F2DB00
	private void Start() { }

	// RVA: 0x1F2CAE0 Offset: 0x1F2B4E0 VA: 0x181F2CAE0
	public void ResetToDefault() { }

	// RVA: 0x1F2B8D0 Offset: 0x1F2A2D0 VA: 0x181F2B8D0
	public void BuildReachCones() { }

	// RVA: 0x1F2D470 Offset: 0x1F2BE70 VA: 0x181F2D470
	private Vector3[] SmoothPoints() { }

	// RVA: 0x1F2C360 Offset: 0x1F2AD60 VA: 0x181F2C360
	private float GetScalar(int k) { }

	// RVA: 0x1F2CA00 Offset: 0x1F2B400 VA: 0x181F2CA00
	private Vector3 PointToTangentPlane(Vector3 p, float r) { }

	// RVA: 0x1F2DDC0 Offset: 0x1F2C7C0 VA: 0x181F2DDC0
	private Vector3 TangentPointToSphere(Vector3 q, float r) { }

	// RVA: 0x1F2C490 Offset: 0x1F2AE90 VA: 0x181F2C490
	private Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x1F2C220 Offset: 0x1F2AC20 VA: 0x181F2C220
	private int GetReachCone(Vector3 L) { }

	// RVA: 0x1F2DEE0 Offset: 0x1F2C8E0 VA: 0x181F2DEE0
	public void .ctor() { }
}
