public class NearestSplinePoint : DTVersionedMonoBehaviour // TypeDefIndex: 10512
{
	// Fields
	[Tooltip("The spline on which the nearest position is searched for")]
	public CurvySpline Spline; // 0x30
	[Tooltip("A transform which position will be used as the input position for the lookup")]
	public Transform SourcePosition; // 0x38
	[Tooltip("A transform which position will be updated with the nearest point on Spline to Source Position")]
	public Transform TargetPosition; // 0x40
	[Tooltip("When to run the lookup")]
	public CurvyUpdateMethod UpdateIn; // 0x48
	[Tooltip("At each update, this event is called with the result of the lookup")]
	public UnityEventEx<Vector3> OnUpdated; // 0x50

	// Methods

	// RVA: 0x4B9DF0 Offset: 0x4B87F0 VA: 0x1804B9DF0
	private void Process() { }

	[UsedImplicitly]
	// RVA: 0x4B9FE0 Offset: 0x4B89E0 VA: 0x1804B9FE0
	private void Update() { }

	[UsedImplicitly]
	// RVA: 0x4B9D80 Offset: 0x4B8780 VA: 0x1804B9D80
	private void LateUpdate() { }

	[UsedImplicitly]
	// RVA: 0x4B9D70 Offset: 0x4B8770 VA: 0x1804B9D70
	private void FixedUpdate() { }

	// RVA: 0x4B9FF0 Offset: 0x4B89F0 VA: 0x1804B9FF0
	public void .ctor() { }
}
