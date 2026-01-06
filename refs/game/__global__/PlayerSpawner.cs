public class PlayerSpawner : MonoBehaviour // TypeDefIndex: 12673
{
	// Fields
	[CompilerGenerated]
	private Action<NetworkObject> OnSpawned; // 0x20
	[Tooltip("Prefab to spawn for the player.")]
	[SerializeField]
	private NetworkObject _playerPrefab; // 0x28
	[Tooltip("True to add player to the active scene when no global scenes are specified through the SceneManager.")]
	[SerializeField]
	private bool _addToDefaultScene; // 0x30
	[FormerlySerializedAs("_spawns")]
	[Tooltip("Areas in which players may spawn.")]
	public Transform[] Spawns; // 0x38
	private NetworkManager _networkManager; // 0x40
	private int _nextSpawn; // 0x48

	// Methods

	[CompilerGenerated]
	// RVA: 0xD4BF30 Offset: 0xD4A930 VA: 0x180D4BF30
	public void add_OnSpawned(Action<NetworkObject> value) { }

	[CompilerGenerated]
	// RVA: 0xD4BFE0 Offset: 0xD4A9E0 VA: 0x180D4BFE0
	public void remove_OnSpawned(Action<NetworkObject> value) { }

	// RVA: 0xD4B740 Offset: 0xD4A140 VA: 0x180D4B740
	private void Start() { }

	// RVA: 0xD4B8B0 Offset: 0xD4A2B0 VA: 0x180D4B8B0
	private void OnDestroy() { }

	// RVA: 0xD4B740 Offset: 0xD4A140 VA: 0x180D4B740
	private void InitializeOnce() { }

	// RVA: 0xD4B980 Offset: 0xD4A380 VA: 0x180D4B980
	private void SceneManager_OnClientLoadedStartScenes(NetworkConnection conn, bool asServer) { }

	// RVA: 0xD4BD50 Offset: 0xD4A750 VA: 0x180D4BD50
	private void SetSpawn(Transform prefab, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0xD4BCE0 Offset: 0xD4A6E0 VA: 0x180D4BCE0
	private void SetSpawnUsingPrefab(Transform prefab, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0xD4BED0 Offset: 0xD4A8D0 VA: 0x180D4BED0
	public void .ctor() { }
}
