public class VariableDatabase : NetworkSingleton<VariableDatabase>, IBaseSaveable, ISaveable // TypeDefIndex: 618
{
	// Fields
	public List<BaseVariable> VariableList; // 0x120
	public Dictionary<string, BaseVariable> VariableDict; // 0x128
	private List<string> playerVariables; // 0x130
	public VariableCreator[] Creators; // 0x138
	public StorableItemDefinition[] ItemsToTrackAcquire; // 0x140
	private VariablesLoader loader; // 0x148
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x150
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x158
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x160
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x164
	private bool NetworkInitialize___EarlyScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted; // 0x169

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

	// RVA: 0xAB2040 Offset: 0xAB0A40 VA: 0x180AB2040 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0xAB2010 Offset: 0xAB0A10 VA: 0x180AB2010 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x71DB60 Offset: 0x71C560 VA: 0x18071DB60 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x71DBF0 Offset: 0x71C5F0 VA: 0x18071DBF0 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x71DB70 Offset: 0x71C570 VA: 0x18071DB70 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0xAAFEB0 Offset: 0xAAE8B0 VA: 0x180AAFEB0 Slot: 20
	public override void Awake() { }

	// RVA: 0xAB0740 Offset: 0xAAF140 VA: 0x180AB0740 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0xAB0180 Offset: 0xAAEB80 VA: 0x180AB0180
	private void CreateVariables() { }

	// RVA: 0xAAFF00 Offset: 0xAAE900 VA: 0x180AAFF00
	public void CreatePlayerVariables(Player owner) { }

	// RVA: 0xAB0C70 Offset: 0xAAF670 VA: 0x180AB0C70 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xAAFFE0 Offset: 0xAAE9E0 VA: 0x180AAFFE0
	public void CreateVariable(string name, VariableDatabase.EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = 1) { }

	// RVA: 0xAAFA60 Offset: 0xAAE460 VA: 0x180AAFA60
	public void AddVariable(BaseVariable variable) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xAB1BA0 Offset: 0xAB05A0 VA: 0x180AB1BA0
	public void SendValue(NetworkConnection conn, string variableName, string value) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0xAB11A0 Offset: 0xAAFBA0 VA: 0x180AB11A0
	public void ReceiveValue(NetworkConnection conn, string variableName, string value) { }

	// RVA: 0xAB1C00 Offset: 0xAB0600 VA: 0x180AB1C00
	public void SetVariableValue(string variableName, string value, bool network = True) { }

	// RVA: 0xAB05C0 Offset: 0xAAEFC0 VA: 0x180AB05C0
	public BaseVariable GetVariable(string variableName) { }

	// RVA: -1 Offset: -1
	public T GetValue<T>(string variableName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF746A0 Offset: 0xF730A0 VA: 0x180F746A0
	|-VariableDatabase.GetValue<bool>
	|
	|-RVA: 0xF74CC0 Offset: 0xF736C0 VA: 0x180F74CC0
	|-VariableDatabase.GetValue<float>
	|
	|-RVA: 0xF74970 Offset: 0xF73370 VA: 0x180F74970
	|-VariableDatabase.GetValue<__Il2CppFullySharedGenericType>
	*/

	[Button]
	// RVA: 0xAB0D80 Offset: 0xAAF780 VA: 0x180AB0D80
	public void PrintAllVariables() { }

	// RVA: 0xAB0FE0 Offset: 0xAAF9E0 VA: 0x180AB0FE0
	public void PrintVariableValue(string variableName) { }

	// RVA: 0xAB0B40 Offset: 0xAAF540 VA: 0x180AB0B40
	public void NotifyItemAcquired(string id, int quantity) { }

	// RVA: 0xAB0320 Offset: 0xAAED20 VA: 0x180AB0320 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0xAB07D0 Offset: 0xAAF1D0 VA: 0x180AB07D0
	public void LoadVariable(VariableData data) { }

	// RVA: 0xAB1E40 Offset: 0xAB0840 VA: 0x180AB1E40
	public void .ctor() { }

	// RVA: 0xAB0A00 Offset: 0xAAF400 VA: 0x180AB0A00 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0xAB09B0 Offset: 0xAAF3B0 VA: 0x180AB09B0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xAB17D0 Offset: 0xAB01D0 VA: 0x180AB17D0
	private void RpcWriter___Server_SendValue_3895153758(NetworkConnection conn, string variableName, string value) { }

	// RVA: 0xAB14A0 Offset: 0xAAFEA0 VA: 0x180AB14A0
	public void RpcLogic___SendValue_3895153758(NetworkConnection conn, string variableName, string value) { }

	// RVA: 0xAB1530 Offset: 0xAAFF30 VA: 0x180AB1530
	private void RpcReader___Server_SendValue_3895153758(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAB1660 Offset: 0xAB0060 VA: 0x180AB1660
	private void RpcWriter___Observers_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value) { }

	// RVA: 0xAB13D0 Offset: 0xAAFDD0 VA: 0x180AB13D0
	public void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value) { }

	// RVA: 0xAB14B0 Offset: 0xAAFEB0 VA: 0x180AB14B0
	private void RpcReader___Observers_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAB1A40 Offset: 0xAB0440 VA: 0x180AB1A40
	private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value) { }

	// RVA: 0xAB15E0 Offset: 0xAAFFE0 VA: 0x180AB15E0
	private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAAFC00 Offset: 0xAAE600 VA: 0x180AAFC00 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Variables.VariableDatabase_Assembly-CSharp.dll() { }
}
