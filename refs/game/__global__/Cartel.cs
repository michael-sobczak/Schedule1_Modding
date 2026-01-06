public class Cartel : NetworkSingleton<Cartel>, IBaseSaveable, ISaveable // TypeDefIndex: 2074
{
	// Fields
	[CompilerGenerated]
	private ECartelStatus <Status>k__BackingField; // 0x120
	[CompilerGenerated]
	private int <HoursSinceStatusChange>k__BackingField; // 0x124
	public bool TEST_MODE; // 0x128
	[Header("References")]
	public CartelActivities Activities; // 0x130
	public CartelInfluence Influence; // 0x138
	public GoonPool GoonPool; // 0x140
	public CartelDealManager DealManager; // 0x148
	public Action<ECartelStatus, ECartelStatus> OnStatusChange; // 0x150
	private CartelLoader loader; // 0x158
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x160
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x170
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x174
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted; // 0x179

	// Properties
	public ECartelStatus Status { get; set; }
	public int HoursSinceStatusChange { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public ECartelStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	private void set_Status(ECartelStatus value) { }

	[CompilerGenerated]
	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	public int get_HoursSinceStatusChange() { }

	[CompilerGenerated]
	// RVA: 0x7049D0 Offset: 0x7033D0 VA: 0x1807049D0
	private void set_HoursSinceStatusChange(int value) { }

	// RVA: 0x7E2300 Offset: 0x7E0D00 VA: 0x1807E2300 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x7E22D0 Offset: 0x7E0CD0 VA: 0x1807E22D0 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x618140 Offset: 0x616B40 VA: 0x180618140 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E22C0 Offset: 0x7E0CC0 VA: 0x1807E22C0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x7E1FB0 Offset: 0x7E09B0 VA: 0x1807E1FB0 Slot: 19
	protected override void Start() { }

	// RVA: 0x7E1560 Offset: 0x7DFF60 VA: 0x1807E1560 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x704140 Offset: 0x702B40 VA: 0x180704140
	private void HourPass() { }

	// RVA: 0x7E0E80 Offset: 0x7DF880 VA: 0x1807E0E80 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x7E0B20 Offset: 0x7DF520 VA: 0x1807E0B20 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x7E0F10 Offset: 0x7DF910 VA: 0x1807E0F10
	public void Load(CartelData data) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x7E1A50 Offset: 0x7E0450 VA: 0x1807E1A50
	public void SetStatus_Server(ECartelStatus status, bool resetStatusChangedTimer) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7E1D10 Offset: 0x7E0710 VA: 0x1807E1D10
	public void SetStatus(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer) { }

	// RVA: 0x7E21A0 Offset: 0x7E0BA0 VA: 0x1807E21A0
	public void .ctor() { }

	// RVA: 0x7E1420 Offset: 0x7DFE20 VA: 0x1807E1420 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7E13D0 Offset: 0x7DFDD0 VA: 0x1807E13D0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7E1A50 Offset: 0x7E0450 VA: 0x1807E1A50
	private void RpcWriter___Server_SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer) { }

	// RVA: 0x7E16E0 Offset: 0x7E00E0 VA: 0x1807E16E0
	public void RpcLogic___SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer) { }

	// RVA: 0x7E17A0 Offset: 0x7E01A0 VA: 0x1807E17A0
	private void RpcReader___Server_SetStatus_Server_2366206100(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7E18E0 Offset: 0x7E02E0 VA: 0x1807E18E0
	private void RpcWriter___Observers_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer) { }

	// RVA: 0x7E15C0 Offset: 0x7DFFC0 VA: 0x1807E15C0
	public void RpcLogic___SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer) { }

	// RVA: 0x7E1700 Offset: 0x7E0100 VA: 0x1807E1700
	private void RpcReader___Observers_SetStatus_3666943613(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7E1BB0 Offset: 0x7E05B0 VA: 0x1807E1BB0
	private void RpcWriter___Target_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer) { }

	// RVA: 0x7E1840 Offset: 0x7E0240 VA: 0x1807E1840
	private void RpcReader___Target_SetStatus_3666943613(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7E0AB0 Offset: 0x7DF4B0 VA: 0x1807E0AB0 Slot: 20
	public override void Awake() { }
}
