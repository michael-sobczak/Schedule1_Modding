public class RVOExampleAgent : MonoBehaviour // TypeDefIndex: 13443
{
	// Fields
	public float repathRate; // 0x20
	private float nextRepath; // 0x24
	private Vector3 target; // 0x28
	private bool canSearchAgain; // 0x34
	private RVOController controller; // 0x38
	public float maxSpeed; // 0x40
	private Path path; // 0x48
	private List<Vector3> vectorPath; // 0x50
	private int wp; // 0x58
	public float moveNextDist; // 0x5C
	public float slowdownDistance; // 0x60
	public LayerMask groundMask; // 0x64
	private Seeker seeker; // 0x68
	private MeshRenderer[] rends; // 0x70

	// Methods

	// RVA: 0xBD2BB0 Offset: 0xBD15B0 VA: 0x180BD2BB0
	public void Awake() { }

	// RVA: 0xBD3520 Offset: 0xBD1F20 VA: 0x180BD3520
	public void SetTarget(Vector3 target) { }

	// RVA: 0xBD3160 Offset: 0xBD1B60 VA: 0x180BD3160
	public void SetColor(Color color) { }

	// RVA: 0xBD3010 Offset: 0xBD1A10 VA: 0x180BD3010
	public void RecalculatePath() { }

	// RVA: 0xBD2C30 Offset: 0xBD1630 VA: 0x180BD2C30
	public void OnPathComplete(Path _p) { }

	// RVA: 0xBD3540 Offset: 0xBD1F40 VA: 0x180BD3540
	public void Update() { }

	// RVA: 0xBD4320 Offset: 0xBD2D20 VA: 0x180BD4320
	public void .ctor() { }
}
