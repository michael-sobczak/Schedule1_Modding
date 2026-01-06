public class CurvyShape : DTVersionedMonoBehaviour // TypeDefIndex: 10513
{
	// Fields
	[SerializeField]
	[Label("Plane", "")]
	private CurvyPlane m_Plane; // 0x30
	private static Dictionary<CurvyShapeInfo, Type> mShapeDefs; // 0x0
	private CurvySpline mSpline; // 0x38
	public bool Dirty; // 0x40

	// Properties
	public CurvyPlane Plane { get; set; }
	public CurvySpline Spline { get; }
	[Obsolete("Method will be removed in the next major release. If you need it, please copy its implementation")]
	[UsedImplicitly]
	public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions { get; }

	// Methods

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public CurvyPlane get_Plane() { }

	// RVA: 0x4A7F50 Offset: 0x4A6950 VA: 0x1804A7F50
	public void set_Plane(CurvyPlane value) { }

	// RVA: 0x4A7EF0 Offset: 0x4A68F0 VA: 0x1804A7EF0
	public CurvySpline get_Spline() { }

	[UsedImplicitly]
	// RVA: 0x4A6A60 Offset: 0x4A5460 VA: 0x1804A6A60
	private void Update() { }

	// RVA: 0x4A6080 Offset: 0x4A4A80 VA: 0x1804A6080 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4A6C80 Offset: 0x4A5680 VA: 0x1804A6C80 Slot: 8
	protected override void Reset() { }

	// RVA: 0x4A5810 Offset: 0x4A4210 VA: 0x1804A5810
	public void Delete() { }

	// RVA: 0x4A6A60 Offset: 0x4A5460 VA: 0x1804A6A60
	public void Refresh() { }

	[Obsolete("This method will become an Editor only method")]
	[UsedImplicitly]
	// RVA: 0x4A6B60 Offset: 0x4A5560 VA: 0x1804A6B60
	public CurvyShape Replace(string menuName) { }

	// RVA: 0x4A67C0 Offset: 0x4A51C0 VA: 0x1804A67C0
	protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = 1, int cachedensity = 50, bool closed = True) { }

	// RVA: 0x4A7500 Offset: 0x4A5F00 VA: 0x1804A7500
	protected void SetPosition(int no, Vector3 position) { }

	// RVA: 0x4A7630 Offset: 0x4A6030 VA: 0x1804A7630
	protected void SetRotation(int no, Quaternion rotation) { }

	// RVA: 0x4A7060 Offset: 0x4A5A60 VA: 0x1804A7060
	protected void SetBezierHandles(int no, float distanceFrag) { }

	// RVA: 0x4A6C90 Offset: 0x4A5690 VA: 0x1804A6C90
	protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag) { }

	// RVA: 0x4A7080 Offset: 0x4A5A80 VA: 0x1804A7080
	protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = 0) { }

	// RVA: 0x4A6FB0 Offset: 0x4A59B0 VA: 0x1804A6FB0
	public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, CurvySplineSegment[] controlPoints) { }

	// RVA: 0x4A7270 Offset: 0x4A5C70 VA: 0x1804A7270
	protected void SetCGHardEdges(int[] controlPoints) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void ApplyShape() { }

	// RVA: 0x4A60A0 Offset: 0x4A4AA0 VA: 0x1804A60A0
	protected void PrepareControlPoints(int count) { }

	// RVA: 0x4A7DA0 Offset: 0x4A67A0 VA: 0x1804A7DA0
	public static Dictionary<CurvyShapeInfo, Type> get_ShapeDefinitions() { }

	[Obsolete("Method will be removed in the next major release. If you need it, please copy its implementation")]
	[UsedImplicitly]
	// RVA: 0x4A5EA0 Offset: 0x4A48A0 VA: 0x1804A5EA0
	public static List<string> GetShapesMenuNames(bool only2D = False) { }

	[UsedImplicitly]
	[Obsolete("This method will become an Editor only method")]
	// RVA: 0x4A5BD0 Offset: 0x4A45D0 VA: 0x1804A5BD0
	public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = False) { }

	[UsedImplicitly]
	[Obsolete("Method will be removed in the next major release. If you need it, please copy its implementation")]
	// RVA: 0x4A5820 Offset: 0x4A4220 VA: 0x1804A5820
	public static string GetShapeName(Type shapeType) { }

	[UsedImplicitly]
	[Obsolete("This method will become an Editor only method")]
	// RVA: 0x4A59F0 Offset: 0x4A43F0 VA: 0x1804A59F0
	public static Type GetShapeType(string menuName) { }

	// RVA: 0x4A5680 Offset: 0x4A4080 VA: 0x1804A5680
	private void ApplyPlane() { }

	// RVA: 0x4A77E0 Offset: 0x4A61E0 VA: 0x1804A77E0
	private void applyRotation(Quaternion q) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }

	// RVA: 0x4A7750 Offset: 0x4A6150 VA: 0x1804A7750
	private static void .cctor() { }
}
