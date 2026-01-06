public class ObjectPool : MonoBehaviour // TypeDefIndex: 18186
{
	// Fields
	[Tooltip("Time to wait before destroying object pools with no activity as well pool entries which haven't been used recently. Use -1f to disable this feature.")]
	[SerializeField]
	private float _dataExpirationDelay; // 0x20
	private static ObjectPool _instance; // 0x0
	private Transform _collector; // 0x28
	private List<PoolData> _pools; // 0x30
	private Dictionary<string, Transform> _categoryChildren; // 0x38
	private Dictionary<GameObject, PoolData> _poolPrefabs; // 0x40
	private Dictionary<GameObject, PoolData> _activeObjects; // 0x48
	private Dictionary<GameObject, ObjectPool.DelayedStoreData> _delayedStoreObjects; // 0x50

	// Methods

	// RVA: 0xDA6D00 Offset: 0xDA5700 VA: 0x180DA6D00
	private void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Update() { }

	// RVA: 0xDA8270 Offset: 0xDA6C70 VA: 0x180DA8270
	private void Start() { }

	[IteratorStateMachine(typeof(ObjectPool.<__CleanupChecks>d__12))]
	// RVA: 0xDA8750 Offset: 0xDA7150 VA: 0x180DA8750
	private IEnumerator __CleanupChecks() { }

	[IteratorStateMachine(typeof(ObjectPool.<__Reset>d__13))]
	// RVA: 0xDA87C0 Offset: 0xDA71C0 VA: 0x180DA87C0
	public IEnumerator __Reset(bool destroyActive) { }

	// RVA: 0xDA70B0 Offset: 0xDA5AB0 VA: 0x180DA70B0
	private void DestroyPool(PoolData poolData, bool removeFromList) { }

	// RVA: 0xDA7FE0 Offset: 0xDA69E0 VA: 0x180DA7FE0
	private PoolData ReturnPoolData(GameObject prefab) { }

	// RVA: 0xDA81E0 Offset: 0xDA6BE0 VA: 0x180DA81E0
	private void SetGameObjectPositionRotation(GameObject result, Vector3 position, Quaternion rotation) { }

	// RVA: 0xDA7DB0 Offset: 0xDA67B0 VA: 0x180DA7DB0
	public static GameObject Retrieve(GameObject poolObject) { }

	// RVA: 0xDA7760 Offset: 0xDA6160 VA: 0x180DA7760
	private GameObject RetrieveInternal(GameObject poolObject) { }

	// RVA: 0xDA7B90 Offset: 0xDA6590 VA: 0x180DA7B90
	public static GameObject Retrieve(GameObject poolObject, Transform parent, bool instantiateInWorldSpace = True) { }

	// RVA: 0xDA7970 Offset: 0xDA6370 VA: 0x180DA7970
	public GameObject RetrieveInternal(GameObject poolObject, Transform parent, bool instantiateInWorldSpace = True) { }

	// RVA: 0xDA7E10 Offset: 0xDA6810 VA: 0x180DA7E10
	public static GameObject Retrieve(GameObject poolObject, Vector3 position, Quaternion rotation) { }

	// RVA: 0xDA75D0 Offset: 0xDA5FD0 VA: 0x180DA75D0
	private GameObject RetrieveInternal(GameObject poolObject, Vector3 position, Quaternion rotation) { }

	// RVA: 0xDA7C10 Offset: 0xDA6610 VA: 0x180DA7C10
	public GameObject Retrieve(GameObject poolObject, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1 Offset: -1
	public static T Retrieve<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19470 Offset: 0xF17E70 VA: 0x180F19470
	|-ObjectPool.Retrieve<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T RetrieveInternal<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF18F20 Offset: 0xF17920 VA: 0x180F18F20
	|-ObjectPool.RetrieveInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Retrieve<T>(GameObject prefab, Transform parent, bool instantiateInWorldSpace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19670 Offset: 0xF18070 VA: 0x180F19670
	|-ObjectPool.Retrieve<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T RetrieveInternal<T>(GameObject prefab, Transform parent, bool instantiateInWorldSpace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19120 Offset: 0xF17B20 VA: 0x180F19120
	|-ObjectPool.RetrieveInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Retrieve<T>(GameObject prefab, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19550 Offset: 0xF17F50 VA: 0x180F19550
	|-ObjectPool.Retrieve<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T RetrieveInternal<T>(GameObject prefab, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF18D90 Offset: 0xF17790 VA: 0x180F18D90
	|-ObjectPool.RetrieveInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Retrieve<T>(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19330 Offset: 0xF17D30 VA: 0x180F19330
	|-ObjectPool.Retrieve<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T RetrieveInternal<T>(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF18BF0 Offset: 0xF175F0 VA: 0x180F18BF0
	|-ObjectPool.RetrieveInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xDA7220 Offset: 0xDA5C20 VA: 0x180DA7220
	private GameObject FinalizeRetrieve(GameObject result, PoolData pool) { }

	// RVA: 0xDA8680 Offset: 0xDA7080 VA: 0x180DA8680
	public static void Store(GameObject instantiatedObject, float delay, bool parentPooler = True) { }

	// RVA: 0xDA8450 Offset: 0xDA6E50 VA: 0x180DA8450
	private void StoreInternal(GameObject instantiatedObject, float delay, bool parentPooler = True) { }

	// RVA: 0xDA84F0 Offset: 0xDA6EF0 VA: 0x180DA84F0
	public static void Store(GameObject instantiatedObject, bool parentPooler = True) { }

	// RVA: 0xDA82F0 Offset: 0xDA6CF0 VA: 0x180DA82F0
	private void StoreInternal(GameObject instantiatedObject, bool parentPooler = True) { }

	// RVA: 0xDA72B0 Offset: 0xDA5CB0 VA: 0x180DA72B0
	private void MakeCollector() { }

	// RVA: 0xDA8060 Offset: 0xDA6A60 VA: 0x180DA8060
	private GameObject ReturnPooledObject(GameObject prefab, out PoolData pool) { }

	// RVA: 0xDA6E60 Offset: 0xDA5860 VA: 0x180DA6E60
	private PoolData CreatePool(GameObject prefab) { }

	// RVA: 0xDA6BC0 Offset: 0xDA55C0 VA: 0x180DA6BC0
	private void AddToPool(GameObject instantiatedObject, PoolData pool, bool parentPooler = True) { }

	// RVA: 0xDA73A0 Offset: 0xDA5DA0 VA: 0x180DA73A0
	private void ParentPooler(GameObject poolObject, bool worldPositionStays) { }

	// RVA: 0xDA8840 Offset: 0xDA7240 VA: 0x180DA8840
	public void .ctor() { }
}
