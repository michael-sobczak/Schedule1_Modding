public class UISpawner : MonoBehaviour // TypeDefIndex: 2716
{
	// Fields
	public RectTransform SpawnArea; // 0x20
	public GameObject[] Prefabs; // 0x28
	public float MinInterval; // 0x30
	public float MaxInterval; // 0x34
	public float SpawnRateMultiplier; // 0x38
	public Vector2 MinScale; // 0x3C
	public Vector2 MaxScale; // 0x44
	public bool UniformScale; // 0x4C
	private float nextSpawnTime; // 0x50
	public UnityEvent<GameObject> OnSpawn; // 0x58

	// Methods

	// RVA: 0x91EDA0 Offset: 0x91D7A0 VA: 0x18091EDA0
	private void Start() { }

	// RVA: 0x91EDE0 Offset: 0x91D7E0 VA: 0x18091EDE0
	private void Update() { }

	// RVA: 0x91F110 Offset: 0x91DB10 VA: 0x18091F110
	public void .ctor() { }
}
