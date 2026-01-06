public abstract class BuildableItem : NetworkBehaviour, IGUIDRegisterable, ISaveable // TypeDefIndex: 1393
{
	// Fields
	[CompilerGenerated]
	private ItemInstance <ItemInstance>k__BackingField; // 0x118
	[CompilerGenerated]
	private Property <ParentProperty>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsDestroyed>k__BackingField; // 0x128
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x129
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x12C
	[CompilerGenerated]
	private bool <IsCulled>k__BackingField; // 0x13C
	[HideInInspector]
	public bool isGhost; // 0x13D
	[SerializeField]
	[Header("Build Settings")]
	protected GameObject buildHandler; // 0x140
	public float HoldDistance; // 0x148
	public Transform BuildPoint; // 0x150
	public Transform MidAirCenterPoint; // 0x158
	public BoxCollider BoundingCollider; // 0x160
	[SerializeField]
	[Header("Outline settings")]
	protected List<GameObject> OutlineRenderers; // 0x168
	[SerializeField]
	protected bool IncludeOutlineRendererChildren; // 0x170
	protected Outlinable OutlineEffect; // 0x178
	[Header("Culling Settings")]
	public GameObject[] GameObjectsToCull; // 0x180
	public List<MeshRenderer> MeshesToCull; // 0x188
	[Header("Buildable Events")]
	public UnityEvent onGhostModel; // 0x190
	public UnityEvent onInitialized; // 0x198
	public UnityEvent onDestroyed; // 0x1A0
	public Action<BuildableItem> onDestroyedWithParameter; // 0x1A8
	[CompilerGenerated]
	private bool <_locallyBuilt>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x1C8
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted; // 0x1C9
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted; // 0x1CA

	// Properties
	public ItemInstance ItemInstance { get; set; }
	public Property ParentProperty { get; set; }
	public bool IsDestroyed { get; set; }
	public bool Initialized { get; set; }
	public Guid GUID { get; set; }
	public bool IsCulled { get; set; }
	public GameObject BuildHandler { get; }
	protected bool _locallyBuilt { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public ItemInstance get_ItemInstance() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	protected void set_ItemInstance(ItemInstance value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0 Slot: 45
	public Property get_ParentProperty() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	protected void set_ParentProperty(Property value) { }

	[CompilerGenerated]
	// RVA: 0x67E960 Offset: 0x67D360 VA: 0x18067E960 Slot: 46
	public bool get_IsDestroyed() { }

	[CompilerGenerated]
	// RVA: 0x67EAB0 Offset: 0x67D4B0 VA: 0x18067EAB0
	protected void set_IsDestroyed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x67E940 Offset: 0x67D340 VA: 0x18067E940
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x67EA90 Offset: 0x67D490 VA: 0x18067EA90
	protected void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x67E920 Offset: 0x67D320 VA: 0x18067E920 Slot: 19
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x67EA70 Offset: 0x67D470 VA: 0x18067EA70
	protected void set_GUID(Guid value) { }

	[CompilerGenerated]
	// RVA: 0x67E950 Offset: 0x67D350 VA: 0x18067E950
	public bool get_IsCulled() { }

	[CompilerGenerated]
	// RVA: 0x67EAA0 Offset: 0x67D4A0 VA: 0x18067EAA0
	protected void set_IsCulled(bool value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public GameObject get_BuildHandler() { }

	[CompilerGenerated]
	// RVA: 0x67EA60 Offset: 0x67D460 VA: 0x18067EA60
	protected bool get__locallyBuilt() { }

	[CompilerGenerated]
	// RVA: 0x67EB00 Offset: 0x67D500 VA: 0x18067EB00
	protected void set__locallyBuilt(bool value) { }

	// RVA: 0x67DF50 Offset: 0x67C950 VA: 0x18067DF50
	public void SetLocallyBuilt() { }

	// RVA: 0x67E9C0 Offset: 0x67D3C0 VA: 0x18067E9C0 Slot: 22
	public string get_SaveFolderName() { }

	// RVA: 0x67E990 Offset: 0x67D390 VA: 0x18067E990 Slot: 23
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 24
	public Loader get_Loader() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 25
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970 Slot: 26
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0 Slot: 27
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980 Slot: 28
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0 Slot: 29
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x67E930 Offset: 0x67D330 VA: 0x18067E930 Slot: 30
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x67EA80 Offset: 0x67D480 VA: 0x18067EA80 Slot: 31
	public void set_HasChanged(bool value) { }

	// RVA: 0x67A420 Offset: 0x678E20 VA: 0x18067A420 Slot: 47
	public override void Awake() { }

	// RVA: 0x67E5B0 Offset: 0x67CFB0 VA: 0x18067E5B0 Slot: 48
	protected virtual void Start() { }

	// RVA: 0x67C6F0 Offset: 0x67B0F0 VA: 0x18067C6F0 Slot: 49
	protected virtual Property GetProperty(Transform searchTransform) { }

	// RVA: 0x67AAA0 Offset: 0x6794A0 VA: 0x18067AAA0 Slot: 50
	public virtual string GetManagementName() { }

	// RVA: 0x67AA40 Offset: 0x679440 VA: 0x18067AA40 Slot: 51
	public virtual string GetDefaultManagementName() { }

	// RVA: 0x67D2D0 Offset: 0x67BCD0 VA: 0x18067D2D0 Slot: 52
	public virtual void InitializeSaveable() { }

	// RVA: 0x67D4A0 Offset: 0x67BEA0 VA: 0x18067D4A0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x67D500 Offset: 0x67BF00 VA: 0x18067D500 Slot: 11
	public override void OnStartClient() { }

	// RVA: -1 Offset: -1 Slot: 53
	protected abstract void SendInitializationToClient(NetworkConnection conn);

	// RVA: -1 Offset: -1 Slot: 54
	protected abstract void SendInitializationToServer();

	// RVA: 0x67CD70 Offset: 0x67B770 VA: 0x18067CD70
	protected void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode) { }

	// RVA: 0x67A520 Offset: 0x678F20 VA: 0x18067A520
	public bool CanBePickedUp(out string reason) { }

	// RVA: 0x67A4D0 Offset: 0x678ED0 VA: 0x18067A4D0 Slot: 55
	public virtual bool CanBeDestroyed(out string reason) { }

	// RVA: 0x67D590 Offset: 0x67BF90 VA: 0x18067D590
	public void PickupItem() { }

	// RVA: 0x67A850 Offset: 0x679250 VA: 0x18067A850 Slot: 56
	protected virtual void Destroy() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x67A740 Offset: 0x679140 VA: 0x18067A740
	private void Destroy_Server() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x67A610 Offset: 0x679010 VA: 0x18067A610
	private void Destroy_Client() { }

	// RVA: 0x67DEE0 Offset: 0x67C8E0 VA: 0x18067DEE0 Slot: 21
	public void SetGUID(Guid guid) { }

	// RVA: 0x67A9E0 Offset: 0x6793E0 VA: 0x18067A9E0
	private static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col) { }

	// RVA: 0x67E040 Offset: 0x67CA40 VA: 0x18067E040 Slot: 57
	public virtual void ShowOutline(Color color) { }

	// RVA: 0x67DF60 Offset: 0x67C960 VA: 0x18067DF60
	public void ShowOutline(BuildableItem.EOutlineColor color) { }

	// RVA: 0x67CCB0 Offset: 0x67B6B0 VA: 0x18067CCB0 Slot: 58
	public virtual void HideOutline() { }

	// RVA: 0x67AAC0 Offset: 0x6794C0 VA: 0x18067AAC0
	public bool GetPenetration(out float x, out float z, out float y) { }

	// RVA: 0x67C890 Offset: 0x67B290 VA: 0x18067C890
	private bool HasLoS_IgnoreBuildables(Vector3 point) { }

	// RVA: 0x67DCE0 Offset: 0x67C6E0 VA: 0x18067DCE0 Slot: 59
	public virtual void SetCulled(bool culled) { }

	// RVA: 0x67C7E0 Offset: 0x67B1E0 VA: 0x18067C7E0 Slot: 60
	public virtual DynamicSaveData GetSaveData() { }

	// RVA: 0x67A960 Offset: 0x679360 VA: 0x18067A960 Slot: 61
	public virtual BuildableItemData GetBaseData() { }

	// RVA: 0x67C850 Offset: 0x67B250 VA: 0x18067C850 Slot: 33
	public string GetSaveString() { }

	// RVA: 0x67E7A0 Offset: 0x67D1A0 VA: 0x18067E7A0 Slot: 62
	public virtual List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x67E800 Offset: 0x67D200 VA: 0x18067E800
	protected void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(BuildableItem.<<OnStartClient>g__WaitForDataSend|74_0>d))]
	// RVA: 0x67E730 Offset: 0x67D130 VA: 0x18067E730
	private IEnumerator <OnStartClient>g__WaitForDataSend|74_0() { }

	[CompilerGenerated]
	// RVA: 0x67E710 Offset: 0x67D110 VA: 0x18067E710
	private bool <OnStartClient>b__74_1() { }

	// RVA: 0x67D3C0 Offset: 0x67BDC0 VA: 0x18067D3C0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x67D3A0 Offset: 0x67BDA0 VA: 0x18067D3A0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x67DBD0 Offset: 0x67C5D0 VA: 0x18067DBD0
	private void RpcWriter___Server_Destroy_Server_2166136261() { }

	// RVA: 0x67D890 Offset: 0x67C290 VA: 0x18067D890
	private void RpcLogic___Destroy_Server_2166136261() { }

	// RVA: 0x67DA60 Offset: 0x67C460 VA: 0x18067DA60
	private void RpcReader___Server_Destroy_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x67DAB0 Offset: 0x67C4B0 VA: 0x18067DAB0
	private void RpcWriter___Observers_Destroy_Client_2166136261() { }

	// RVA: 0x67D870 Offset: 0x67C270 VA: 0x18067D870
	private void RpcLogic___Destroy_Client_2166136261() { }

	// RVA: 0x67DA10 Offset: 0x67C410 VA: 0x18067DA10
	private void RpcReader___Observers_Destroy_Client_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x67A3A0 Offset: 0x678DA0 VA: 0x18067A3A0 Slot: 65
	protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.BuildableItem_Assembly-CSharp.dll() { }
}
