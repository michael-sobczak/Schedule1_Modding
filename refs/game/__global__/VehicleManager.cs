public class VehicleManager : NetworkSingleton<VehicleManager>, IBaseSaveable, ISaveable // TypeDefIndex: 2186
{
	// Fields
	public List<LandVehicle> AllVehicles; // 0x120
	[Header("Vehicles")]
	public List<LandVehicle> VehiclePrefabs; // 0x128
	public List<LandVehicle> PlayerOwnedVehicles; // 0x130
	private VehiclesLoader loader; // 0x138
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x140
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x148
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x150
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x154
	private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted; // 0x158
	private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted; // 0x159

	// Properties
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	// RVA: 0x83AC10 Offset: 0x839610 VA: 0x18083AC10 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x83ABE0 Offset: 0x8395E0 VA: 0x18083ABE0 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x79A930 Offset: 0x799330 VA: 0x18079A930 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x79A8A0 Offset: 0x7992A0 VA: 0x18079A8A0 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x79A920 Offset: 0x799320 VA: 0x18079A920 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x83ABD0 Offset: 0x8395D0 VA: 0x18083ABD0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x839420 Offset: 0x837E20 VA: 0x180839420 Slot: 20
	public override void Awake() { }

	// RVA: 0x8398B0 Offset: 0x8382B0 VA: 0x1808398B0 Slot: 49
	public virtual void InitializeSaveable() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x83A9C0 Offset: 0x8393C0 VA: 0x18083A9C0
	public void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned) { }

	// RVA: 0x83A420 Offset: 0x838E20 VA: 0x18083A420
	public LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned) { }

	// RVA: 0x8397D0 Offset: 0x8381D0 VA: 0x1808397D0
	public LandVehicle GetVehiclePrefab(string vehicleCode) { }

	// RVA: 0x83A380 Offset: 0x838D80 VA: 0x18083A380
	public LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned) { }

	// RVA: 0x839940 Offset: 0x838340 VA: 0x180839940
	public void LoadVehicle(VehicleData data, string path) { }

	// RVA: 0x8395E0 Offset: 0x837FE0 VA: 0x1808395E0 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x83A7B0 Offset: 0x8391B0 VA: 0x18083A7B0
	public void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8394A0 Offset: 0x837EA0 VA: 0x1808394A0
	private void EnableLoanSharkVisuals(NetworkObject veh) { }

	// RVA: 0x83AA10 Offset: 0x839410 VA: 0x18083AA10
	public void .ctor() { }

	// RVA: 0x839B00 Offset: 0x838500 VA: 0x180839B00 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x839AB0 Offset: 0x8384B0 VA: 0x180839AB0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x83A010 Offset: 0x838A10 VA: 0x18083A010
	private void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned) { }

	// RVA: 0x839CD0 Offset: 0x8386D0 VA: 0x180839CD0
	public void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned) { }

	// RVA: 0x839D90 Offset: 0x838790 VA: 0x180839D90
	private void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x839ED0 Offset: 0x8388D0 VA: 0x180839ED0
	private void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh) { }

	// RVA: 0x839C00 Offset: 0x838600 VA: 0x180839C00
	private void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh) { }

	// RVA: 0x839D20 Offset: 0x838720 VA: 0x180839D20
	private void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8393D0 Offset: 0x837DD0 VA: 0x1808393D0 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Vehicles.VehicleManager_Assembly-CSharp.dll() { }
}
