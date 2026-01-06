public class Beaker : StationItem // TypeDefIndex: 3237
{
	// Fields
	public float ClampAngle_MaxLiquid; // 0x38
	public float ClampAngle_MinLiquid; // 0x3C
	public float AngleToPour_MaxLiquid; // 0x40
	public float AngleToPour_MinLiquid; // 0x44
	[Header("References")]
	public Draggable Draggable; // 0x48
	public DraggableConstraint Constraint; // 0x50
	public Collider ConcaveCollider; // 0x58
	public Collider ConvexCollider; // 0x60
	public Transform CenterOfMass; // 0x68
	public ConfigurableJoint Joint; // 0x70
	public Rigidbody Anchor; // 0x78
	public LiquidContainer Container; // 0x80
	public Fillable Fillable; // 0x88
	public PourableModule Pourable; // 0x90
	public GameObject FilterPaper; // 0x98

	// Methods

	// RVA: 0x9F8800 Offset: 0x9F7200 VA: 0x1809F8800
	private void Start() { }

	// RVA: 0x9F88D0 Offset: 0x9F72D0 VA: 0x1809F88D0
	private void Update() { }

	// RVA: 0x9F8780 Offset: 0x9F7180 VA: 0x1809F8780
	public void SetStatic(bool stat) { }

	// RVA: 0x9F8A00 Offset: 0x9F7400 VA: 0x1809F8A00
	public void .ctor() { }
}
