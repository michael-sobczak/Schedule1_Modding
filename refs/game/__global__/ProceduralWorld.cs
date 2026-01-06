public class ProceduralWorld : MonoBehaviour // TypeDefIndex: 13450
{
	// Fields
	public Transform target; // 0x20
	public ProceduralWorld.ProceduralPrefab[] prefabs; // 0x28
	public int range; // 0x30
	public int disableAsyncLoadWithinRange; // 0x34
	public float tileSize; // 0x38
	public int subTiles; // 0x3C
	public bool staticBatching; // 0x40
	private Queue<IEnumerator> tileGenerationQueue; // 0x48
	private Dictionary<Int2, ProceduralWorld.ProceduralTile> tiles; // 0x50

	// Methods

	// RVA: 0xBD23F0 Offset: 0xBD0DF0 VA: 0x180BD23F0
	private void Start() { }

	// RVA: 0xBD24D0 Offset: 0xBD0ED0 VA: 0x180BD24D0
	private void Update() { }

	[IteratorStateMachine(typeof(ProceduralWorld.<GenerateTiles>d__13))]
	// RVA: 0xBD2380 Offset: 0xBD0D80 VA: 0x180BD2380
	private IEnumerator GenerateTiles() { }

	// RVA: 0xBD2A40 Offset: 0xBD1440 VA: 0x180BD2A40
	public void .ctor() { }
}
