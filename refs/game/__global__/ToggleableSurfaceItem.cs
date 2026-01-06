public class ToggleableSurfaceItem : SurfaceItem // TypeDefIndex: 1409
{
	// Fields
	[CompilerGenerated]
	private bool <IsOn>k__BackingField; // 0x208
	[Header("Settings")]
	public ToggleableSurfaceItem.EStartupAction StartupAction; // 0x20C
	public UnityEvent onTurnedOn; // 0x210
	public UnityEvent onTurnedOff; // 0x218
	public UnityEvent onTurnOnOrOff; // 0x220
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted; // 0x228
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted; // 0x229

	// Properties
	public bool IsOn { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x690A80 Offset: 0x68F480 VA: 0x180690A80
	public bool get_IsOn() { }

	[CompilerGenerated]
	// RVA: 0x690A90 Offset: 0x68F490 VA: 0x180690A90
	private void set_IsOn(bool value) { }

	// RVA: 0x68FA90 Offset: 0x68E490 VA: 0x18068FA90 Slot: 47
	public override void Awake() { }

	// RVA: 0x68FE30 Offset: 0x68E830 VA: 0x18068FE30 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x690930 Offset: 0x68F330 VA: 0x180690930
	public void Toggle() { }

	// RVA: 0x690A00 Offset: 0x68F400 VA: 0x180690A00
	public void TurnOn(bool network = True) { }

	// RVA: 0x690980 Offset: 0x68F380 VA: 0x180690980
	public void TurnOff(bool network = True) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x690540 Offset: 0x68EF40 VA: 0x180690540
	private void SendIsOn(bool on) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x690680 Offset: 0x68F080 VA: 0x180690680
	private void SetIsOn(NetworkConnection conn, bool on) { }

	// RVA: 0x68FB50 Offset: 0x68E550 VA: 0x18068FB50 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x690A70 Offset: 0x68F470 VA: 0x180690A70
	public void .ctor() { }

	// RVA: 0x68FD00 Offset: 0x68E700 VA: 0x18068FD00 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x68FCC0 Offset: 0x68E6C0 VA: 0x18068FCC0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6902B0 Offset: 0x68ECB0 VA: 0x1806902B0
	private void RpcWriter___Server_SendIsOn_1140765316(bool on) { }

	// RVA: 0x68FEB0 Offset: 0x68E8B0 VA: 0x18068FEB0
	private void RpcLogic___SendIsOn_1140765316(bool on) { }

	// RVA: 0x690010 Offset: 0x68EA10 VA: 0x180690010
	private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x690170 Offset: 0x68EB70 VA: 0x180690170
	private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on) { }

	// RVA: 0x68FED0 Offset: 0x68E8D0 VA: 0x18068FED0
	private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on) { }

	// RVA: 0x68FF40 Offset: 0x68E940 VA: 0x18068FF40
	private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6903E0 Offset: 0x68EDE0 VA: 0x1806903E0
	private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on) { }

	// RVA: 0x6900A0 Offset: 0x68EAA0 VA: 0x1806900A0
	private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x68F9E0 Offset: 0x68E3E0 VA: 0x18068F9E0 Slot: 68
	protected override void Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableSurfaceItem_Assembly-CSharp.dll() { }
}
