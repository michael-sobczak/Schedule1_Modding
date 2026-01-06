public sealed class PredictionManager : MonoBehaviour // TypeDefIndex: 12788
{
	// Fields
	[CompilerGenerated]
	private Action<NetworkBehaviour> OnPreReconcile; // 0x20
	[CompilerGenerated]
	private Action<NetworkBehaviour> OnPostReconcile; // 0x28
	[CompilerGenerated]
	private Action<uint, PhysicsScene, PhysicsScene2D> OnPreReplicateReplay; // 0x30
	[CompilerGenerated]
	private Action<uint, PhysicsScene, PhysicsScene2D> OnPostReplicateReplay; // 0x38
	[CompilerGenerated]
	private Action<NetworkBehaviour> OnPreServerReconcile; // 0x40
	[CompilerGenerated]
	private Action<NetworkBehaviour> OnPostServerReconcile; // 0x48
	[CompilerGenerated]
	private uint <LastReconcileTick>k__BackingField; // 0x50
	[CompilerGenerated]
	private uint <LastReplicateTick>k__BackingField; // 0x54
	private bool _isReplaying; // 0x58
	[Tooltip("Number of inputs to keep in queue should the server miss receiving an input update from the client. Higher values will increase the likeliness of the server always having input from the client while lower values will allow the client input to run on the server faster. This value cannot be higher than MaximumServerReplicates.")]
	[Range(1, 15)]
	[SerializeField]
	private ushort _queuedInputs; // 0x5A
	[SerializeField]
	[Tooltip("True to drop replicates from clients which are being received excessively. This can help with attacks but may cause client to temporarily desynchronize during connectivity issues. When false the server will hold at most up to 3 seconds worth of replicates, consuming multiple per tick to clear out the buffer quicker. This is good to ensure all inputs are executed but potentially could allow speed hacking.")]
	private bool _dropExcessiveReplicates; // 0x5C
	[SerializeField]
	[Tooltip("Maximum number of replicates a server can queue per object. Higher values will put more load on the server and add replicate latency for the client.")]
	private ushort _maximumServerReplicates; // 0x5E
	[SerializeField]
	[Tooltip("Maximum number of excessive replicates which can be consumed per tick. Consumption count will scale up to this value automatically.")]
	private byte _maximumConsumeCount; // 0x60
	[Tooltip("Maximum number of past inputs which may send.")]
	[SerializeField]
	[Range(2, 15)]
	private byte _redundancyCount; // 0x61
	[Tooltip("True to allow clients to use predicted spawning and despawning. While true, each NetworkObject prefab you wish to predicted spawn must be marked as to allow this feature.")]
	[SerializeField]
	private bool _allowPredictedSpawning; // 0x62
	[SerializeField]
	[Tooltip("Maximum number of Ids to reserve on clients for predicted spawning. Higher values will allow clients to send more predicted spawns per second but may reduce availability of ObjectIds with high player counts.")]
	[Range(1, 100)]
	private byte _reservedObjectIds; // 0x63
	private HashSet<Component> _rigidbodies; // 0x68
	private HashSet<Component> _componentCache; // 0x70
	private HashSet<Scene> _replayingScenes; // 0x78
	private NetworkManager _networkManager; // 0x80
	private const byte MINIMUM_PAST_INPUTS = 2;
	internal const byte MAXIMUM_PAST_INPUTS = 15;
	private const ushort MINIMUM_REPLICATE_QUEUE_SIZE = 10;
	private const ushort MAXIMUM_REPLICATE_QUEUE_SIZE = 500;

	// Properties
	public uint LastReconcileTick { get; set; }
	public uint LastReplicateTick { get; set; }
	internal bool UsingRigidbodies { get; }
	public ushort QueuedInputs { get; }
	internal bool DropExcessiveReplicates { get; }
	internal byte MaximumReplicateConsumeCount { get; }
	internal ushort MaximumClientReplicates { get; }
	internal byte RedundancyCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD80880 Offset: 0xD7F280 VA: 0x180D80880
	public void add_OnPreReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD80D40 Offset: 0xD7F740 VA: 0x180D80D40
	public void remove_OnPreReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD80670 Offset: 0xD7F070 VA: 0x180D80670
	public void add_OnPostReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD80B30 Offset: 0xD7F530 VA: 0x180D80B30
	public void remove_OnPostReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD80930 Offset: 0xD7F330 VA: 0x180D80930
	public void add_OnPreReplicateReplay(Action<uint, PhysicsScene, PhysicsScene2D> value) { }

	[CompilerGenerated]
	// RVA: 0xD80DF0 Offset: 0xD7F7F0 VA: 0x180D80DF0
	public void remove_OnPreReplicateReplay(Action<uint, PhysicsScene, PhysicsScene2D> value) { }

	[CompilerGenerated]
	// RVA: 0xD80720 Offset: 0xD7F120 VA: 0x180D80720
	public void add_OnPostReplicateReplay(Action<uint, PhysicsScene, PhysicsScene2D> value) { }

	[CompilerGenerated]
	// RVA: 0xD80BE0 Offset: 0xD7F5E0 VA: 0x180D80BE0
	public void remove_OnPostReplicateReplay(Action<uint, PhysicsScene, PhysicsScene2D> value) { }

	[CompilerGenerated]
	// RVA: 0xD809E0 Offset: 0xD7F3E0 VA: 0x180D809E0
	public void add_OnPreServerReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD80EA0 Offset: 0xD7F8A0 VA: 0x180D80EA0
	public void remove_OnPreServerReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD807D0 Offset: 0xD7F1D0 VA: 0x180D807D0
	public void add_OnPostServerReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0xD80C90 Offset: 0xD7F690 VA: 0x180D80C90
	public void remove_OnPostServerReconcile(Action<NetworkBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public uint get_LastReconcileTick() { }

	[CompilerGenerated]
	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	internal void set_LastReconcileTick(uint value) { }

	[CompilerGenerated]
	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public uint get_LastReplicateTick() { }

	[CompilerGenerated]
	// RVA: 0xD80F50 Offset: 0xD7F950 VA: 0x180D80F50
	internal void set_LastReplicateTick(uint value) { }

	// RVA: 0xD80AE0 Offset: 0xD7F4E0 VA: 0x180D80AE0
	internal bool get_UsingRigidbodies() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool IsReplaying() { }

	// RVA: 0xD80080 Offset: 0xD7EA80 VA: 0x180D80080
	public bool IsReplaying(Scene scene) { }

	// RVA: 0xD80AD0 Offset: 0xD7F4D0 VA: 0x180D80AD0
	public ushort get_QueuedInputs() { }

	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	internal bool get_DropExcessiveReplicates() { }

	// RVA: 0xD7FDE0 Offset: 0xD7E7E0 VA: 0x180D7FDE0
	public ushort GetMaximumServerReplicates() { }

	// RVA: 0xD80500 Offset: 0xD7EF00 VA: 0x180D80500
	public void SetMaximumServerReplicates(ushort value) { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	internal byte get_MaximumReplicateConsumeCount() { }

	// RVA: 0xD80A90 Offset: 0xD7F490 VA: 0x180D80A90
	internal ushort get_MaximumClientReplicates() { }

	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	internal byte get_RedundancyCount() { }

	// RVA: 0xD7FDD0 Offset: 0xD7E7D0 VA: 0x180D7FDD0
	internal bool GetAllowPredictedSpawning() { }

	// RVA: 0xD7FDF0 Offset: 0xD7E7F0 VA: 0x180D7FDF0
	internal byte GetReservedObjectIds() { }

	// RVA: 0xD80170 Offset: 0xD7EB70 VA: 0x180D80170
	private void OnEnable() { }

	// RVA: 0xD800E0 Offset: 0xD7EAE0 VA: 0x180D800E0
	private void OnDisable() { }

	// RVA: 0xD7FE00 Offset: 0xD7E800 VA: 0x180D7FE00
	internal void InitializeOnce(NetworkManager manager) { }

	// RVA: 0xD7FD70 Offset: 0xD7E770 VA: 0x180D7FD70
	private void ClientManager_OnClientConnectionState(ClientConnectionStateArgs obj) { }

	// RVA: 0xD80050 Offset: 0xD7EA50 VA: 0x180D80050
	internal void InvokeServerReconcile(NetworkBehaviour caller, bool before) { }

	[APIExclude]
	// RVA: 0xD7FD10 Offset: 0xD7E710 VA: 0x180D7FD10
	public void AddRigidbodyCount(Component c) { }

	[APIExclude]
	// RVA: 0xD80200 Offset: 0xD7EC00 VA: 0x180D80200
	public void RemoveRigidbodyCount(Component c) { }

	[APIExclude]
	[CodegenMakePublic]
	// RVA: 0xD7FF40 Offset: 0xD7E940 VA: 0x180D7FF40
	public void InvokeOnReconcile(NetworkBehaviour nb, bool before) { }

	[APIExclude]
	// RVA: 0xD7FF80 Offset: 0xD7E980 VA: 0x180D7FF80
	internal void InvokeOnReplicateReplay(Scene scene, uint tick, PhysicsScene ps, PhysicsScene2D ps2d, bool before) { }

	// RVA: 0xD804A0 Offset: 0xD7EEA0 VA: 0x180D804A0
	private void SceneManager_sceneUnloaded(Scene s) { }

	// RVA: 0xD80530 Offset: 0xD7EF30 VA: 0x180D80530
	public void .ctor() { }
}
