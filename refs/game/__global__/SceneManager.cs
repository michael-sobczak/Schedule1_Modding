public sealed class SceneManager : MonoBehaviour // TypeDefIndex: 12785
{
	// Fields
	[CompilerGenerated]
	private Action<bool> OnActiveSceneSet; // 0x20
	[CompilerGenerated]
	private Action<NetworkConnection, bool> OnClientLoadedStartScenes; // 0x28
	[CompilerGenerated]
	private Action OnQueueStart; // 0x30
	[CompilerGenerated]
	private Action OnQueueEnd; // 0x38
	[CompilerGenerated]
	private Action<SceneLoadStartEventArgs> OnLoadStart; // 0x40
	[CompilerGenerated]
	private Action<SceneLoadPercentEventArgs> OnLoadPercentChange; // 0x48
	[CompilerGenerated]
	private Action<SceneLoadEndEventArgs> OnLoadEnd; // 0x50
	[CompilerGenerated]
	private Action<SceneUnloadStartEventArgs> OnUnloadStart; // 0x58
	[CompilerGenerated]
	private Action<SceneUnloadEndEventArgs> OnUnloadEnd; // 0x60
	[CompilerGenerated]
	private Action<ClientPresenceChangeEventArgs> OnClientPresenceChangeStart; // 0x68
	[CompilerGenerated]
	private Action<ClientPresenceChangeEventArgs> OnClientPresenceChangeEnd; // 0x70
	[CompilerGenerated]
	private Dictionary<Scene, HashSet<NetworkConnection>> <SceneConnections>k__BackingField; // 0x78
	[SerializeField]
	[Tooltip("Script to handle addressables loading and unloading. This field may be blank if addressables are not being used.")]
	private SceneProcessorBase _sceneProcessor; // 0x80
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x88
	[CompilerGenerated]
	private Action OnActiveSceneSetInternal; // 0x90
	[CompilerGenerated]
	private bool <IteratingQueue>k__BackingField; // 0x98
	[CompilerGenerated]
	private float <QueueCompleteTime>k__BackingField; // 0x9C
	[SerializeField]
	[Tooltip("How to update light probes after loading or unloading scenes.")]
	private SceneManager.LightProbeUpdateType _lightProbeUpdating; // 0xA0
	[SerializeField]
	[Tooltip("True to move objects visible to clientHost that are within an unloading scene. This ensures the objects are despawned on the client side rather than when the scene is destroyed.")]
	private bool _moveClientHostObjects; // 0xA4
	[Tooltip("True to automatically set active scenes when loading and unloading scenes.")]
	[SerializeField]
	private bool _setActiveScene; // 0xA5
	private string[] _globalScenes; // 0xA8
	private SceneLoadData _globalSceneLoadData; // 0xB0
	private List<object> _queuedOperations; // 0xB8
	private HashSet<Scene> _manualUnloadScenes; // 0xC0
	private Scene _movedObjectsScene; // 0xC8
	private Scene _delayedDestroyScene; // 0xCC
	private Scene _fallbackActiveScene; // 0xD0
	private bool _sceneQueueStartInvoked; // 0xD4
	private List<GameObject> _movingObjects; // 0xD8
	private Dictionary<NetworkConnection, int> _pendingClientSceneChanges; // 0xE0
	private HashSet<string> _serverGlobalScenesLoading; // 0xE8
	private const string INVALID_SCENELOADDATA = "One or more datas in SceneLoadData are invalid.This generally occurs when calling this method without specifying any scenes or when data fields are null.";
	private const string INVALID_SCENEUNLOADDATA = "One or more datas in SceneLoadData are invalid.This generally occurs when calling this method without specifying any scenes or when data fields are null.";

	// Properties
	public Dictionary<Scene, HashSet<NetworkConnection>> SceneConnections { get; set; }
	public NetworkManager NetworkManager { get; set; }
	internal bool IteratingQueue { get; set; }
	internal float QueueCompleteTime { get; set; }
	private ServerManager _serverManager { get; }
	private ClientManager _clientManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD893F0 Offset: 0xD87DF0 VA: 0x180D893F0
	public void add_OnActiveSceneSet(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD89C50 Offset: 0xD88650 VA: 0x180D89C50
	public void remove_OnActiveSceneSet(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD894A0 Offset: 0xD87EA0 VA: 0x180D894A0
	public void add_OnClientLoadedStartScenes(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD89D00 Offset: 0xD88700 VA: 0x180D89D00
	public void remove_OnClientLoadedStartScenes(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD89960 Offset: 0xD88360 VA: 0x180D89960
	public void add_OnQueueStart(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD8A1C0 Offset: 0xD88BC0 VA: 0x180D8A1C0
	public void remove_OnQueueStart(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD898C0 Offset: 0xD882C0 VA: 0x180D898C0
	public void add_OnQueueEnd(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD8A120 Offset: 0xD88B20 VA: 0x180D8A120
	public void remove_OnQueueEnd(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD89810 Offset: 0xD88210 VA: 0x180D89810
	public void add_OnLoadStart(Action<SceneLoadStartEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD8A070 Offset: 0xD88A70 VA: 0x180D8A070
	public void remove_OnLoadStart(Action<SceneLoadStartEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89760 Offset: 0xD88160 VA: 0x180D89760
	public void add_OnLoadPercentChange(Action<SceneLoadPercentEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89FC0 Offset: 0xD889C0 VA: 0x180D89FC0
	public void remove_OnLoadPercentChange(Action<SceneLoadPercentEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD896B0 Offset: 0xD880B0 VA: 0x180D896B0
	public void add_OnLoadEnd(Action<SceneLoadEndEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89F10 Offset: 0xD88910 VA: 0x180D89F10
	public void remove_OnLoadEnd(Action<SceneLoadEndEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89AB0 Offset: 0xD884B0 VA: 0x180D89AB0
	public void add_OnUnloadStart(Action<SceneUnloadStartEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD8A310 Offset: 0xD88D10 VA: 0x180D8A310
	public void remove_OnUnloadStart(Action<SceneUnloadStartEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89A00 Offset: 0xD88400 VA: 0x180D89A00
	public void add_OnUnloadEnd(Action<SceneUnloadEndEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD8A260 Offset: 0xD88C60 VA: 0x180D8A260
	public void remove_OnUnloadEnd(Action<SceneUnloadEndEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89600 Offset: 0xD88000 VA: 0x180D89600
	public void add_OnClientPresenceChangeStart(Action<ClientPresenceChangeEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89E60 Offset: 0xD88860 VA: 0x180D89E60
	public void remove_OnClientPresenceChangeStart(Action<ClientPresenceChangeEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89550 Offset: 0xD87F50 VA: 0x180D89550
	public void add_OnClientPresenceChangeEnd(Action<ClientPresenceChangeEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD89DB0 Offset: 0xD887B0 VA: 0x180D89DB0
	public void remove_OnClientPresenceChangeEnd(Action<ClientPresenceChangeEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Dictionary<Scene, HashSet<NetworkConnection>> get_SceneConnections() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	private void set_SceneConnections(Dictionary<Scene, HashSet<NetworkConnection>> value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public SceneProcessorBase GetSceneProcessor() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void SetSceneProcessor(SceneProcessorBase value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	private void set_NetworkManager(NetworkManager value) { }

	[CompilerGenerated]
	// RVA: 0xD89340 Offset: 0xD87D40 VA: 0x180D89340
	internal void add_OnActiveSceneSetInternal(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD89BA0 Offset: 0xD885A0 VA: 0x180D89BA0
	internal void remove_OnActiveSceneSetInternal(Action value) { }

	[CompilerGenerated]
	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460
	internal bool get_IteratingQueue() { }

	[CompilerGenerated]
	// RVA: 0x614500 Offset: 0x612F00 VA: 0x180614500
	private void set_IteratingQueue(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A5280 Offset: 0x6A3C80 VA: 0x1806A5280
	internal float get_QueueCompleteTime() { }

	[CompilerGenerated]
	// RVA: 0x8B34F0 Offset: 0x8B1EF0 VA: 0x1808B34F0
	private void set_QueueCompleteTime(float value) { }

	// RVA: 0xD89B80 Offset: 0xD88580 VA: 0x180D89B80
	private ServerManager get__serverManager() { }

	// RVA: 0xD89B60 Offset: 0xD88560 VA: 0x180D89B60
	private ClientManager get__clientManager() { }

	// RVA: 0xD83CA0 Offset: 0xD826A0 VA: 0x180D83CA0
	private void Awake() { }

	// RVA: 0xD88310 Offset: 0xD86D10 VA: 0x180D88310
	private void Start() { }

	// RVA: 0xD86500 Offset: 0xD84F00 VA: 0x180D86500
	private void OnDestroy() { }

	// RVA: 0xD87FE0 Offset: 0xD869E0 VA: 0x180D87FE0
	private void ServerManager_OnServerConnectionState(ServerConnectionStateArgs obj) { }

	// RVA: 0xD87BB0 Offset: 0xD865B0 VA: 0x180D87BB0
	private void ResetValues() { }

	// RVA: 0xD87FD0 Offset: 0xD869D0 VA: 0x180D87FD0
	private void ServerManager_OnRemoteConnectionState(NetworkConnection arg1, RemoteConnectionStateArgs arg2) { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	// RVA: 0xD87E50 Offset: 0xD86850 VA: 0x180D87E50
	private void SceneManager_SceneUnloaded(Scene scene) { }

	// RVA: 0xD88670 Offset: 0xD87070 VA: 0x180D88670
	private void TryInvokeLoadedStartScenes(NetworkConnection connection, bool asServer) { }

	// RVA: 0xD85F80 Offset: 0xD84980 VA: 0x180D85F80
	internal void OnClientAuthenticated(NetworkConnection connection) { }

	// RVA: 0xD86220 Offset: 0xD84C20 VA: 0x180D86220
	private void OnClientEmptyStartScenes(EmptyStartScenesBroadcast msg) { }

	// RVA: 0xD86690 Offset: 0xD85090 VA: 0x180D86690
	private void OnServerEmptyStartScenes(NetworkConnection conn, EmptyStartScenesBroadcast msg) { }

	// RVA: 0xD84340 Offset: 0xD82D40 VA: 0x180D84340
	private void ClientDisconnected(NetworkConnection conn) { }

	// RVA: 0xD862E0 Offset: 0xD84CE0 VA: 0x180D862E0
	private void OnClientLoadedScenes(NetworkConnection conn, ClientScenesLoadedBroadcast msg) { }

	// RVA: 0xD88740 Offset: 0xD87140 VA: 0x180D88740
	private void TryInvokeOnQueueStart() { }

	// RVA: 0xD886E0 Offset: 0xD870E0 VA: 0x180D886E0
	private void TryInvokeOnQueueEnd() { }

	// RVA: 0xD85370 Offset: 0xD83D70 VA: 0x180D85370
	private void InvokeOnSceneLoadStart(LoadQueueData qd) { }

	// RVA: 0xD851D0 Offset: 0xD83BD0 VA: 0x180D851D0
	private void InvokeOnSceneLoadEnd(LoadQueueData qd, List<string> requestedLoadScenes, List<Scene> loadedScenes, string[] unloadedSceneNames) { }

	// RVA: 0xD854E0 Offset: 0xD83EE0 VA: 0x180D854E0
	private void InvokeOnSceneUnloadStart(UnloadQueueData sqd) { }

	// RVA: 0xD85460 Offset: 0xD83E60 VA: 0x180D85460
	private void InvokeOnSceneUnloadEnd(UnloadQueueData sqd, List<Scene> unloadedScenes, List<UnloadedScene> newUnloadedScenes) { }

	// RVA: 0xD853F0 Offset: 0xD83DF0 VA: 0x180D853F0
	private void InvokeOnScenePercentChange(LoadQueueData qd, float value) { }

	// RVA: 0xD867F0 Offset: 0xD851F0 VA: 0x180D867F0
	private void QueueOperation(object data) { }

	[IteratorStateMachine(typeof(SceneManager.<__ProcessSceneQueue>d__98))]
	// RVA: 0xD88FF0 Offset: 0xD879F0 VA: 0x180D88FF0
	private IEnumerator __ProcessSceneQueue() { }

	// RVA: 0xD84D60 Offset: 0xD83760 VA: 0x180D84D60
	private string[] GlobalScenesExcludingLoading() { }

	// RVA: 0xD85B00 Offset: 0xD84500 VA: 0x180D85B00
	public void LoadGlobalScenes(SceneLoadData sceneLoadData) { }

	// RVA: 0xD85960 Offset: 0xD84360 VA: 0x180D85960
	private void LoadGlobalScenes_Internal(SceneLoadData sceneLoadData, string[] globalScenes, bool asServer) { }

	// RVA: 0xD85850 Offset: 0xD84250 VA: 0x180D85850
	public void LoadConnectionScenes(NetworkConnection conn, SceneLoadData sceneLoadData) { }

	// RVA: 0xD85930 Offset: 0xD84330 VA: 0x180D85930
	public void LoadConnectionScenes(NetworkConnection[] conns, SceneLoadData sceneLoadData) { }

	// RVA: 0xD857E0 Offset: 0xD841E0 VA: 0x180D857E0
	public void LoadConnectionScenes(SceneLoadData sceneLoadData) { }

	// RVA: 0xD856B0 Offset: 0xD840B0 VA: 0x180D856B0
	private void LoadConnectionScenes_Internal(NetworkConnection[] conns, SceneLoadData sceneLoadData, string[] globalScenes, bool asServer) { }

	// RVA: 0xD83F20 Offset: 0xD82920 VA: 0x180D83F20
	private bool CanMoveNetworkObject(NetworkObject nob, bool warn) { }

	[IteratorStateMachine(typeof(SceneManager.<__LoadScenes>d__107))]
	// RVA: 0xD88F80 Offset: 0xD87980 VA: 0x180D88F80
	private IEnumerator __LoadScenes() { }

	// RVA: 0xD86590 Offset: 0xD84F90 VA: 0x180D86590
	private void OnLoadScenes(LoadScenesBroadcast msg) { }

	// RVA: 0xD88F30 Offset: 0xD87930 VA: 0x180D88F30
	public void UnloadGlobalScenes(SceneUnloadData sceneUnloadData) { }

	// RVA: 0xD88E70 Offset: 0xD87870 VA: 0x180D88E70
	private void UnloadGlobalScenes_Internal(SceneUnloadData sceneUnloadData, string[] globalScenes, bool asServer) { }

	// RVA: 0xD88D20 Offset: 0xD87720 VA: 0x180D88D20
	public void UnloadConnectionScenes(NetworkConnection connection, SceneUnloadData sceneUnloadData) { }

	// RVA: 0xD88CF0 Offset: 0xD876F0 VA: 0x180D88CF0
	public void UnloadConnectionScenes(NetworkConnection[] connections, SceneUnloadData sceneUnloadData) { }

	// RVA: 0xD88E00 Offset: 0xD87800 VA: 0x180D88E00
	public void UnloadConnectionScenes(SceneUnloadData sceneUnloadData) { }

	// RVA: 0xD88BC0 Offset: 0xD875C0 VA: 0x180D88BC0
	private void UnloadConnectionScenes_Internal(NetworkConnection[] connections, SceneUnloadData sceneUnloadData, string[] globalScenes, bool asServer) { }

	[IteratorStateMachine(typeof(SceneManager.<__UnloadScenes>d__115))]
	// RVA: 0xD89060 Offset: 0xD87A60 VA: 0x180D89060
	private IEnumerator __UnloadScenes() { }

	// RVA: 0xD86750 Offset: 0xD85150 VA: 0x180D86750
	private void OnUnloadScenes(UnloadScenesBroadcast msg) { }

	// RVA: 0xD85B30 Offset: 0xD84530 VA: 0x180D85B30
	private void MoveClientHostObjects(Scene scene, bool asServer) { }

	// RVA: 0xD84F80 Offset: 0xD83980 VA: 0x180D84F80
	internal bool InSceneConnections(NetworkConnection conn, Scene scene) { }

	// RVA: 0xD839A0 Offset: 0xD823A0 VA: 0x180D839A0
	public void AddOwnerToDefaultScene(NetworkObject nob) { }

	// RVA: 0xD83770 Offset: 0xD82170 VA: 0x180D83770
	public void AddConnectionToScene(NetworkConnection conn, Scene scene) { }

	// RVA: 0xD87020 Offset: 0xD85A20 VA: 0x180D87020
	public void RemoveConnectionsFromNonGlobalScenes(NetworkConnection[] conns) { }

	// RVA: 0xD87530 Offset: 0xD85F30 VA: 0x180D87530
	public void RemoveConnectionsFromScene(NetworkConnection[] conns, Scene scene) { }

	// RVA: 0xD86D90 Offset: 0xD85790 VA: 0x180D86D90
	public void RemoveAllConnectionsFromScene(Scene scene) { }

	// RVA: 0xD83E90 Offset: 0xD82890 VA: 0x180D83E90
	private bool CanLoadScene(LoadQueueData qd, SceneLookupData sld) { }

	// RVA: 0xD86920 Offset: 0xD85320 VA: 0x180D86920
	private void RebuildObservers(IList<NetworkObject> networkObjects) { }

	// RVA: 0xD86CF0 Offset: 0xD856F0 VA: 0x180D86CF0
	internal void RebuildObservers(NetworkConnection connection) { }

	// RVA: 0xD86AC0 Offset: 0xD854C0 VA: 0x180D86AC0
	internal void RebuildObservers(IList<NetworkConnection> connections) { }

	// RVA: 0xD85030 Offset: 0xD83A30 VA: 0x180D85030
	private void InvokeClientPresenceChange(Scene scene, IList<NetworkConnection> conns, bool added, bool start) { }

	// RVA: 0xD84BE0 Offset: 0xD835E0 VA: 0x180D84BE0
	private Scene[] GetScenes(SceneLookupData[] datas) { }

	// RVA: 0xD84A10 Offset: 0xD83410 VA: 0x180D84A10
	public static Scene GetScene(string sceneName, NetworkManager nm, bool warnIfDuplicates = True) { }

	// RVA: 0xD84950 Offset: 0xD83350 VA: 0x180D84950
	public static Scene GetScene(int sceneHandle) { }

	// RVA: 0xD85560 Offset: 0xD83F60 VA: 0x180D85560
	private bool IsGlobalScene(Scene scene) { }

	// RVA: 0xD841E0 Offset: 0xD82BE0 VA: 0x180D841E0
	private void CheckForDuplicateGlobalSceneNames() { }

	// RVA: 0xD878C0 Offset: 0xD862C0 VA: 0x180D878C0
	private void RemoveFromGlobalScenes(Scene scene) { }

	// RVA: 0xD877B0 Offset: 0xD861B0 VA: 0x180D877B0
	private void RemoveFromGlobalScenes(SceneLookupData[] datas) { }

	// RVA: 0xD879C0 Offset: 0xD863C0 VA: 0x180D879C0
	private void RemoveGlobalScenes(List<Scene> scenes) { }

	// RVA: 0xD87AE0 Offset: 0xD864E0 VA: 0x180D87AE0
	private void RemoveOccupiedScenes(List<Scene> scenes) { }

	// RVA: 0xD83AC0 Offset: 0xD824C0 VA: 0x180D83AC0
	private void AddPendingLoad(NetworkConnection conn) { }

	// RVA: 0xD83B80 Offset: 0xD82580 VA: 0x180D83B80
	private void AddPendingLoad(NetworkConnection[] conns) { }

	// RVA: 0xD88170 Offset: 0xD86B70 VA: 0x180D88170
	private void SetActiveScene(Scene preferredScene, bool byUser = False) { }

	// RVA: 0xD848F0 Offset: 0xD832F0 VA: 0x180D848F0
	private Scene GetFallbackActiveScene() { }

	// RVA: 0xD84920 Offset: 0xD83320 VA: 0x180D84920
	private Scene GetMovedObjectsScene() { }

	// RVA: 0xD848C0 Offset: 0xD832C0 VA: 0x180D848C0
	private Scene GetDelayedDestroyScene() { }

	// RVA: 0xD84D00 Offset: 0xD83700 VA: 0x180D84D00
	private Scene GetUserPreferredActiveScene(SceneLookupData sld, out bool byUser) { }

	// RVA: 0xD85660 Offset: 0xD84060 VA: 0x180D85660
	internal bool IsIteratingQueue(float completionTimeRequirement = 0) { }

	// RVA: 0xD87D10 Offset: 0xD86710 VA: 0x180D87D10
	private bool SceneDataInvalid(SceneLoadData data, bool error) { }

	// RVA: 0xD87DB0 Offset: 0xD867B0 VA: 0x180D87DB0
	private bool SceneDataInvalid(SceneUnloadData data, bool error) { }

	// RVA: 0xD84890 Offset: 0xD83290 VA: 0x180D84890
	private bool ConnectionActive(bool asServer) { }

	// RVA: 0xD83DD0 Offset: 0xD827D0 VA: 0x180D83DD0
	private bool CanExecute(bool asServer, bool warn) { }

	// RVA: 0xD890D0 Offset: 0xD87AD0 VA: 0x180D890D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD88770 Offset: 0xD87170 VA: 0x180D88770
	private bool <CanMoveNetworkObject>g__WarnAndReturnFalse|106_0(string msg, ref SceneManager.<>c__DisplayClass106_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD88900 Offset: 0xD87300 VA: 0x180D88900
	private void <__LoadScenes>g__InvokePercentageChange|107_1(int index, float maximumWorth, float currentScenePercent, ref SceneManager.<>c__DisplayClass107_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD88890 Offset: 0xD87290 VA: 0x180D88890
	internal static Scene <__LoadScenes>g__GetFirstLoadedScene|107_2(ref SceneManager.<>c__DisplayClass107_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD889A0 Offset: 0xD873A0 VA: 0x180D889A0
	private void <__LoadScenes>g__SetActiveScene_Local|107_0(ref SceneManager.<>c__DisplayClass107_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD88A90 Offset: 0xD87490 VA: 0x180D88A90
	private void <__LoadScenes>g__SetInFirstNullIndex|107_3(Scene scene, ref SceneManager.<>c__DisplayClass107_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD887A0 Offset: 0xD871A0 VA: 0x180D887A0
	private void <SetActiveScene>g__CompleteSetActive|140_0(Scene scene, ref SceneManager.<>c__DisplayClass140_0 ) { }
}
