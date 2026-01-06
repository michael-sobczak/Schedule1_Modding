public class Property : NetworkBehaviour, ISaveable // TypeDefIndex: 749
{
	// Fields
	public static List<Property> Properties; // 0x0
	public static List<Property> UnownedProperties; // 0x8
	public static List<Property> OwnedProperties; // 0x10
	public static Property.PropertyChange onPropertyAcquired; // 0x18
	public UnityEvent onThisPropertyAcquired; // 0x118
	[CompilerGenerated]
	private bool <IsOwned>k__BackingField; // 0x120
	[CompilerGenerated]
	private List<Employee> <Employees>k__BackingField; // 0x128
	[CompilerGenerated]
	private RectTransform <WorldspaceUIContainer>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <IsContentCulled>k__BackingField; // 0x138
	[SerializeField]
	[Header("Settings")]
	protected string propertyName; // 0x140
	public bool AvailableInDemo; // 0x148
	[SerializeField]
	protected string propertyCode; // 0x150
	public float Price; // 0x158
	public float DefaultRotation; // 0x15C
	public int EmployeeCapacity; // 0x160
	public bool OwnedByDefault; // 0x164
	public string IsOwnedVariable; // 0x168
	[SerializeField]
	[CompilerGenerated]
	private float <AmbientTemperature>k__BackingField; // 0x170
	[Header("Culling Settings")]
	public bool ContentCullingEnabled; // 0x174
	public float MinimumCullingDistance; // 0x178
	public GameObject[] ObjectsToCull; // 0x180
	[Header("References")]
	public PropertyContentsContainer Container; // 0x188
	public Transform EmployeeContainer; // 0x190
	public Transform SpawnPoint; // 0x198
	public Transform InteriorSpawnPoint; // 0x1A0
	public GameObject ForSaleSign; // 0x1A8
	public GameObject BoundingBox; // 0x1B0
	public POI PoI; // 0x1B8
	public Transform ListingPoster; // 0x1C0
	public Transform NPCSpawnPoint; // 0x1C8
	public Transform[] EmployeeIdlePoints; // 0x1D0
	public List<ModularSwitch> Switches; // 0x1D8
	public List<InteractableToggleable> Toggleables; // 0x1E0
	public PropertyDisposalArea DisposalArea; // 0x1E8
	public LoadingDock[] LoadingDocks; // 0x1F0
	[HideInInspector]
	public List<BuildableItem> BuildableItems; // 0x1F8
	public List<IConfigurable> Configurables; // 0x200
	public readonly List<Grid> Grids; // 0x208
	private BoxCollider[] propertyBoundsColliders; // 0x210
	private PropertyLoader loader; // 0x218
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x220
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x228
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x230
	private List<string> savedObjectPaths; // 0x238
	private List<string> savedEmployeePaths; // 0x240
	private bool NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted; // 0x248
	private bool NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted; // 0x249

	// Properties
	public bool IsOwned { get; set; }
	public List<Employee> Employees { get; set; }
	public RectTransform WorldspaceUIContainer { get; set; }
	public bool IsContentCulled { get; set; }
	public string PropertyName { get; }
	public string PropertyCode { get; }
	public float AmbientTemperature { get; set; }
	public int LoadingDockCount { get; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_IsOwned() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	protected void set_IsOwned(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public List<Employee> get_Employees() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	protected void set_Employees(List<Employee> value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public RectTransform get_WorldspaceUIContainer() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	protected void set_WorldspaceUIContainer(RectTransform value) { }

	[CompilerGenerated]
	// RVA: 0x512C90 Offset: 0x511690 VA: 0x180512C90
	public bool get_IsContentCulled() { }

	[CompilerGenerated]
	// RVA: 0x6BFF00 Offset: 0x6BE900 VA: 0x1806BFF00
	public void set_IsContentCulled(bool value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public string get_PropertyName() { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	public string get_PropertyCode() { }

	[CompilerGenerated]
	// RVA: 0x6F64F0 Offset: 0x6F4EF0 VA: 0x1806F64F0
	public float get_AmbientTemperature() { }

	[CompilerGenerated]
	// RVA: 0x6F6540 Offset: 0x6F4F40 VA: 0x1806F6540
	private void set_AmbientTemperature(float value) { }

	// RVA: 0xAD7820 Offset: 0xAD6220 VA: 0x180AD7820
	public int get_LoadingDockCount() { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 19
	public string get_SaveFolderName() { }

	// RVA: 0xAD7840 Offset: 0xAD6240 VA: 0x180AD7840 Slot: 20
	public string get_SaveFileName() { }

	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70 Slot: 21
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 22
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0 Slot: 23
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00 Slot: 24
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0 Slot: 25
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0 Slot: 26
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0xAD7810 Offset: 0xAD6210 VA: 0x180AD7810 Slot: 27
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0xAD7850 Offset: 0xAD6250 VA: 0x180AD7850 Slot: 28
	public void set_HasChanged(bool value) { }

	// RVA: 0xAD42D0 Offset: 0xAD2CD0 VA: 0x180AD42D0 Slot: 42
	public override void Awake() { }

	// RVA: 0xAD4C70 Offset: 0xAD3670 VA: 0x180AD4C70 Slot: 43
	public virtual void InitializeSaveable() { }

	// RVA: 0xAD6CA0 Offset: 0xAD56A0 VA: 0x180AD6CA0 Slot: 44
	protected virtual void Start() { }

	// RVA: 0xAD4470 Offset: 0xAD2E70 VA: 0x180AD4470 Slot: 45
	protected virtual void FixedUpdate() { }

	// RVA: 0xAD3600 Offset: 0xAD2000 VA: 0x180AD3600
	public void AddConfigurable(IConfigurable configurable) { }

	// RVA: 0xAD5C30 Offset: 0xAD4630 VA: 0x180AD5C30
	public void RemoveConfigurable(IConfigurable configurable) { }

	// RVA: 0xAD7040 Offset: 0xAD5A40 VA: 0x180AD7040
	private void UpdateCulling() { }

	// RVA: 0xAD5450 Offset: 0xAD3E50 VA: 0x180AD5450 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xAD5230 Offset: 0xAD3C30 VA: 0x180AD5230 Slot: 46
	protected virtual void OnDestroy() { }

	// RVA: 0xAD4600 Offset: 0xAD3000 VA: 0x180AD4600 Slot: 47
	protected virtual void GetNetworth(MoneyManager.FloatContainer container) { }

	// RVA: 0xAD5560 Offset: 0xAD3F60 VA: 0x180AD5560 Slot: 6
	public override void OnStartServer() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xAD68E0 Offset: 0xAD52E0 VA: 0x180AD68E0
	protected void SetOwned_Server() { }

	[ObserversRpc(RunLocally = True, BufferLast = True)]
	// RVA: 0xAD5620 Offset: 0xAD4020 VA: 0x180AD5620
	private void ReceiveOwned_Networked() { }

	// RVA: 0xAD5750 Offset: 0xAD4150 VA: 0x180AD5750 Slot: 48
	protected virtual void RecieveOwned() { }

	// RVA: 0xAD6C50 Offset: 0xAD5650 VA: 0x180AD6C50 Slot: 49
	public virtual bool ShouldSave() { }

	// RVA: 0xAD69F0 Offset: 0xAD53F0 VA: 0x180AD69F0
	public void SetOwned() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetBoundsVisible(bool vis) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 50
	public virtual bool CanBePurchased() { }

	// RVA: 0xAD66C0 Offset: 0xAD50C0 VA: 0x180AD66C0 Slot: 51
	public virtual void SetContentCulled(bool culled) { }

	// RVA: 0xAD5B60 Offset: 0xAD4560 VA: 0x180AD5B60
	public int RegisterEmployee(Employee emp) { }

	// RVA: 0xAD4320 Offset: 0xAD2D20 VA: 0x180AD4320
	public void DeregisterEmployee(Employee emp) { }

	// RVA: 0xAD6E00 Offset: 0xAD5800 VA: 0x180AD6E00
	private void ToggleableActioned(InteractableToggleable toggleable) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0xAD62D0 Offset: 0xAD4CD0 VA: 0x180AD62D0
	public void SendToggleableState(int index, bool state) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0xAD6A00 Offset: 0xAD5400 VA: 0x180AD6A00
	public void SetToggleableState(NetworkConnection conn, int index, bool state) { }

	// RVA: 0xAD47C0 Offset: 0xAD31C0 VA: 0x180AD47C0 Slot: 52
	public virtual string GetSaveString() { }

	// RVA: 0xAD4480 Offset: 0xAD2E80 VA: 0x180AD4480
	protected List<DynamicSaveData> GetEmployeeSaveDatas() { }

	// RVA: 0xAD4640 Offset: 0xAD3040 VA: 0x180AD4640
	protected List<DynamicSaveData> GetObjectSaveDatas() { }

	// RVA: 0xAD72D0 Offset: 0xAD5CD0 VA: 0x180AD72D0 Slot: 53
	public virtual List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 54
	public virtual void DeleteUnapprovedFiles(string parentFolderPath) { }

	// RVA: 0xAD4ED0 Offset: 0xAD38D0 VA: 0x180AD4ED0 Slot: 55
	public virtual void Load(PropertyData propertyData, string dataString) { }

	// RVA: 0xAD4380 Offset: 0xAD2D80 VA: 0x180AD4380
	public bool DoBoundsContainPoint(Vector3 point) { }

	// RVA: 0xAD4D00 Offset: 0xAD3700 VA: 0x180AD4D00
	private bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box) { }

	// RVA: 0xAD4B10 Offset: 0xAD3510 VA: 0x180AD4B10
	public List<Bed> GetUnassignedBeds() { }

	// RVA: -1 Offset: -1
	public List<T> GetBuildablesOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28BE0 Offset: 0xF275E0 VA: 0x180F28BE0
	|-Property.GetBuildablesOfType<object>
	*/

	// RVA: 0xAD74C0 Offset: 0xAD5EC0 VA: 0x180AD74C0
	public void .ctor() { }

	// RVA: 0xAD73A0 Offset: 0xAD5DA0 VA: 0x180AD73A0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xAD6FA0 Offset: 0xAD59A0 VA: 0x180AD6FA0
	private void <Awake>b__84_0(bool <p0>) { }

	[IteratorStateMachine(typeof(Property.<<RecieveOwned>g__Wait|97_0>d))]
	[CompilerGenerated]
	// RVA: 0xAD6FD0 Offset: 0xAD59D0 VA: 0x180AD6FD0
	private IEnumerator <RecieveOwned>g__Wait|97_0() { }

	[CompilerGenerated]
	// RVA: 0xAD6FB0 Offset: 0xAD59B0 VA: 0x180AD6FB0
	private bool <RecieveOwned>b__97_1() { }

	// RVA: 0xAD5080 Offset: 0xAD3A80 VA: 0x180AD5080 Slot: 56
	public override void NetworkInitialize___Early() { }

	// RVA: 0xAD5060 Offset: 0xAD3A60 VA: 0x180AD5060 Slot: 57
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5945C0 Offset: 0x592FC0 VA: 0x1805945C0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xAD6440 Offset: 0xAD4E40 VA: 0x180AD6440
	private void RpcWriter___Server_SetOwned_Server_2166136261() { }

	// RVA: 0xAD5620 Offset: 0xAD4020 VA: 0x180AD5620
	protected void RpcLogic___SetOwned_Server_2166136261() { }

	// RVA: 0xAD5F30 Offset: 0xAD4930 VA: 0x180AD5F30
	private void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAD6030 Offset: 0xAD4A30 VA: 0x180AD6030
	private void RpcWriter___Observers_ReceiveOwned_Networked_2166136261() { }

	// RVA: 0xAD5CC0 Offset: 0xAD46C0 VA: 0x180AD5CC0
	private void RpcLogic___ReceiveOwned_Networked_2166136261() { }

	// RVA: 0xAD5D80 Offset: 0xAD4780 VA: 0x180AD5D80
	private void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD62D0 Offset: 0xAD4CD0 VA: 0x180AD62D0
	private void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state) { }

	// RVA: 0xAD5CE0 Offset: 0xAD46E0 VA: 0x180AD5CE0
	public void RpcLogic___SendToggleableState_3658436649(int index, bool state) { }

	// RVA: 0xAD5E80 Offset: 0xAD4880 VA: 0x180AD5E80
	private void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAD6150 Offset: 0xAD4B50 VA: 0x180AD6150
	private void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state) { }

	// RVA: 0xAD5D00 Offset: 0xAD4700 VA: 0x180AD5D00
	public void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state) { }

	// RVA: 0xAD5DD0 Offset: 0xAD47D0 VA: 0x180AD5DD0
	private void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD6550 Offset: 0xAD4F50 VA: 0x180AD6550
	private void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state) { }

	// RVA: 0xAD5F80 Offset: 0xAD4980 VA: 0x180AD5F80
	private void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD36E0 Offset: 0xAD20E0 VA: 0x180AD36E0 Slot: 58
	protected virtual void Awake_UserLogic_ScheduleOne.Property.Property_Assembly-CSharp.dll() { }
}
