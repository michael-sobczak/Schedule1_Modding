public class ProceduralGridMover : VersionedMonoBehaviour // TypeDefIndex: 13344
{
	// Fields
	public float updateDistance; // 0x28
	public Transform target; // 0x30
	private GridNodeBase[] buffer; // 0x38
	[CompilerGenerated]
	private bool <updatingGraph>k__BackingField; // 0x40
	public GridGraph graph; // 0x48
	[HideInInspector]
	public int graphIndex; // 0x50

	// Properties
	public bool updatingGraph { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_updatingGraph() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	private void set_updatingGraph(bool value) { }

	// RVA: 0xB8C3E0 Offset: 0xB8ADE0 VA: 0x180B8C3E0
	private void Start() { }

	// RVA: 0xB8CA80 Offset: 0xB8B480 VA: 0x180B8CA80
	private void Update() { }

	// RVA: 0xB8C380 Offset: 0xB8AD80 VA: 0x180B8C380
	private Vector3 PointToGraphSpace(Vector3 p) { }

	// RVA: 0xB8C8E0 Offset: 0xB8B2E0 VA: 0x180B8C8E0
	public void UpdateGraph() { }

	[IteratorStateMachine(typeof(ProceduralGridMover.<UpdateGraphCoroutine>d__13))]
	// RVA: 0xB8C870 Offset: 0xB8B270 VA: 0x180B8C870
	private IEnumerator UpdateGraphCoroutine() { }

	// RVA: 0xB8CBA0 Offset: 0xB8B5A0 VA: 0x180B8CBA0
	public void .ctor() { }
}
