public class PathTypesDemo : MonoBehaviour // TypeDefIndex: 13466
{
	// Fields
	public PathTypesDemo.DemoMode activeDemo; // 0x20
	public Transform start; // 0x28
	public Transform end; // 0x30
	public Vector3 pathOffset; // 0x38
	public Material lineMat; // 0x48
	public Material squareMat; // 0x50
	public float lineWidth; // 0x58
	public int searchLength; // 0x5C
	public int spread; // 0x60
	public float aimStrength; // 0x64
	private Path lastPath; // 0x68
	private FloodPath lastFloodPath; // 0x70
	private List<GameObject> lastRender; // 0x78
	private List<Vector3> multipoints; // 0x80

	// Methods

	// RVA: 0xBD1860 Offset: 0xBD0260 VA: 0x180BD1860
	private void Update() { }

	// RVA: 0xBD0F50 Offset: 0xBCF950 VA: 0x180BD0F50
	public void OnGUI() { }

	// RVA: 0xBD1560 Offset: 0xBCFF60 VA: 0x180BD1560
	public void OnPathComplete(Path p) { }

	// RVA: 0xBD08C0 Offset: 0xBCF2C0 VA: 0x180BD08C0
	private void ClearPrevious() { }

	// RVA: 0xBD0F20 Offset: 0xBCF920 VA: 0x180BD0F20
	private void OnDestroy() { }

	// RVA: 0xBD0A90 Offset: 0xBCF490 VA: 0x180BD0A90
	private void DemoPath() { }

	[IteratorStateMachine(typeof(PathTypesDemo.<DemoMultiTargetPath>d__21))]
	// RVA: 0xBD0A20 Offset: 0xBCF420 VA: 0x180BD0A20
	private IEnumerator DemoMultiTargetPath() { }

	[IteratorStateMachine(typeof(PathTypesDemo.<DemoConstantPath>d__22))]
	// RVA: 0xBD09B0 Offset: 0xBCF3B0 VA: 0x180BD09B0
	public IEnumerator DemoConstantPath() { }

	// RVA: 0xBD1AE0 Offset: 0xBD04E0 VA: 0x180BD1AE0
	public void .ctor() { }
}
