public class ToggleableItem : GridItem // TypeDefIndex: 1407
{
	// Fields
	[CompilerGenerated]
	private bool <IsOn>k__BackingField; // 0x210
	[Header("Settings")]
	public ToggleableItem.EStartupAction StartupAction; // 0x214
	public UnityEvent onTurnedOn; // 0x218
	public UnityEvent onTurnedOff; // 0x220
	public UnityEvent onTurnOnOrOff; // 0x228
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted; // 0x230
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted; // 0x231

	// Properties
	public bool IsOn { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x68F9C0 Offset: 0x68E3C0 VA: 0x18068F9C0
	public bool get_IsOn() { }

	[CompilerGenerated]
	// RVA: 0x68F9D0 Offset: 0x68E3D0 VA: 0x18068F9D0
	private void set_IsOn(bool value) { }

	// RVA: 0x68E890 Offset: 0x68D290 VA: 0x18068E890 Slot: 47
	public override void Awake() { }

	// RVA: 0x68ED80 Offset: 0x68D780 VA: 0x18068ED80 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x68F880 Offset: 0x68E280 VA: 0x18068F880
	public void Toggle() { }

	// RVA: 0x68F950 Offset: 0x68E350 VA: 0x18068F950
	public void TurnOn(bool network = True) { }

	// RVA: 0x68F8D0 Offset: 0x68E2D0 VA: 0x18068F8D0
	public void TurnOff(bool network = True) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x68F490 Offset: 0x68DE90 VA: 0x18068F490
	private void SendIsOn(bool on) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x68F5D0 Offset: 0x68DFD0 VA: 0x18068F5D0
	private void SetIsOn(NetworkConnection conn, bool on) { }

	// RVA: 0x68EA10 Offset: 0x68D410 VA: 0x18068EA10 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x6851D0 Offset: 0x683BD0 VA: 0x1806851D0
	public void .ctor() { }

	// RVA: 0x68EB50 Offset: 0x68D550 VA: 0x18068EB50 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x68EB10 Offset: 0x68D510 VA: 0x18068EB10 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x68F200 Offset: 0x68DC00 VA: 0x18068F200
	private void RpcWriter___Server_SendIsOn_1140765316(bool on) { }

	// RVA: 0x68EE00 Offset: 0x68D800 VA: 0x18068EE00
	private void RpcLogic___SendIsOn_1140765316(bool on) { }

	// RVA: 0x68EF60 Offset: 0x68D960 VA: 0x18068EF60
	private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x68F0C0 Offset: 0x68DAC0 VA: 0x18068F0C0
	private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on) { }

	// RVA: 0x68EE20 Offset: 0x68D820 VA: 0x18068EE20
	private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on) { }

	// RVA: 0x68EE90 Offset: 0x68D890 VA: 0x18068EE90
	private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x68F330 Offset: 0x68DD30 VA: 0x18068F330
	private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on) { }

	// RVA: 0x68EFF0 Offset: 0x68D9F0 VA: 0x18068EFF0
	private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x68E720 Offset: 0x68D120 VA: 0x18068E720 Slot: 71
	protected override void Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableItem_Assembly-CSharp.dll() { }
}
