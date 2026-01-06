public class SpillController : MonoBehaviour // TypeDefIndex: 371
{
	// Fields
	public GameObject spill; // 0x20
	private LiquidVolume lv; // 0x28
	private GameObject[] dropTemplates; // 0x30
	private const int DROP_TEMPLATES_COUNT = 10;

	// Methods

	// RVA: 0x7B6CC0 Offset: 0x7B56C0 VA: 0x1807B6CC0
	private void Start() { }

	// RVA: 0x7B6FF0 Offset: 0x7B59F0 VA: 0x1807B6FF0
	private void Update() { }

	// RVA: 0x7B6930 Offset: 0x7B5330 VA: 0x1807B6930
	private void FixedUpdate() { }

	[IteratorStateMachine(typeof(SpillController.<DestroySpill>d__7))]
	// RVA: 0x7B68C0 Offset: 0x7B52C0 VA: 0x1807B68C0
	private IEnumerator DestroySpill(GameObject spill) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
