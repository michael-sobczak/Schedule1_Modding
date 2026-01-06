public class TurnBasedManager : MonoBehaviour // TypeDefIndex: 13460
{
	// Fields
	private TurnBasedAI selected; // 0x20
	public float movementSpeed; // 0x28
	public GameObject nodePrefab; // 0x30
	public LayerMask layerMask; // 0x38
	private List<GameObject> possibleMoves; // 0x40
	private EventSystem eventSystem; // 0x48
	public TurnBasedManager.State state; // 0x50

	// Methods

	// RVA: 0xBD4880 Offset: 0xBD3280 VA: 0x180BD4880
	private void Awake() { }

	// RVA: 0xBD5060 Offset: 0xBD3A60 VA: 0x180BD5060
	private void Update() { }

	// RVA: 0xBD4DA0 Offset: 0xBD37A0 VA: 0x180BD4DA0
	private void HandleButtonUnderRay(Ray ray) { }

	// RVA: -1 Offset: -1
	private T GetByRay<T>(Ray ray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF62440 Offset: 0xF60E40 VA: 0x180F62440
	|-TurnBasedManager.GetByRay<object>
	*/

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void Select(TurnBasedAI unit) { }

	[IteratorStateMachine(typeof(TurnBasedManager.<MoveToNode>d__13))]
	// RVA: 0xBD4FB0 Offset: 0xBD39B0 VA: 0x180BD4FB0
	private IEnumerator MoveToNode(TurnBasedAI unit, GraphNode node) { }

	[IteratorStateMachine(typeof(TurnBasedManager.<MoveAlongPath>d__14))]
	// RVA: 0xBD4F10 Offset: 0xBD3910 VA: 0x180BD4F10
	private static IEnumerator MoveAlongPath(TurnBasedAI unit, ABPath path, float speed) { }

	// RVA: 0xBD48F0 Offset: 0xBD32F0 VA: 0x180BD48F0
	private void DestroyPossibleMoves() { }

	// RVA: 0xBD4A70 Offset: 0xBD3470 VA: 0x180BD4A70
	private void GeneratePossibleMoves(TurnBasedAI unit) { }

	// RVA: 0xBD5330 Offset: 0xBD3D30 VA: 0x180BD5330
	public void .ctor() { }
}
