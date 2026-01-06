public class DarkMarket : NetworkSingleton<DarkMarket> // TypeDefIndex: 3326
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <Unlocked>k__BackingField; // 0x121
	public DarkMarketAccessZone AccessZone; // 0x128
	public DarkMarketMainDoor MainDoor; // 0x130
	public Oscar Oscar; // 0x138
	public FullRank UnlockRank; // 0x140
	private bool NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted; // 0x148
	private bool NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted; // 0x149

	// Properties
	public bool IsOpen { get; set; }
	public bool Unlocked { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x60EB50 Offset: 0x60D550 VA: 0x18060EB50
	public bool get_Unlocked() { }

	[CompilerGenerated]
	// RVA: 0x60EB70 Offset: 0x60D570 VA: 0x18060EB70
	protected void set_Unlocked(bool value) { }

	// RVA: 0xA4A2C0 Offset: 0xA48CC0 VA: 0x180A4A2C0 Slot: 19
	protected override void Start() { }

	// RVA: 0xA49780 Offset: 0xA48180 VA: 0x180A49780 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA4A3C0 Offset: 0xA48DC0 VA: 0x180A4A3C0
	private void Update() { }

	// RVA: 0xA4A150 Offset: 0xA48B50 VA: 0x180A4A150
	private bool ShouldBeOpen() { }

	// RVA: 0xA495C0 Offset: 0xA47FC0 VA: 0x180A495C0
	private void OnLoad() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA49DF0 Offset: 0xA487F0 VA: 0x180A49DF0
	public void SendUnlocked() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA49F00 Offset: 0xA48900 VA: 0x180A49F00
	private void SetUnlocked(NetworkConnection conn) { }

	// RVA: 0xA4A550 Offset: 0xA48F50 VA: 0x180A4A550
	public void .ctor() { }

	// RVA: 0xA49480 Offset: 0xA47E80 VA: 0x180A49480 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA49430 Offset: 0xA47E30 VA: 0x180A49430 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA49BB0 Offset: 0xA485B0 VA: 0x180A49BB0
	private void RpcWriter___Server_SendUnlocked_2166136261() { }

	// RVA: 0xA497C0 Offset: 0xA481C0 VA: 0x180A497C0
	public void RpcLogic___SendUnlocked_2166136261() { }

	// RVA: 0xA49A00 Offset: 0xA48400 VA: 0x180A49A00
	private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA49A90 Offset: 0xA48490 VA: 0x180A49A90
	private void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn) { }

	// RVA: 0xA497D0 Offset: 0xA481D0 VA: 0x180A497D0
	private void RpcLogic___SetUnlocked_328543758(NetworkConnection conn) { }

	// RVA: 0xA499C0 Offset: 0xA483C0 VA: 0x180A499C0
	private void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA49CC0 Offset: 0xA486C0 VA: 0x180A49CC0
	private void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn) { }

	// RVA: 0xA49A50 Offset: 0xA48450 VA: 0x180A49A50
	private void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA493C0 Offset: 0xA47DC0 VA: 0x180A493C0 Slot: 20
	public override void Awake() { }
}
