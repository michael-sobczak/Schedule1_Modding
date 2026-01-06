public class ModularSwitch : NetworkBehaviour // TypeDefIndex: 3316
{
	// Fields
	public bool isOn; // 0x118
	[Header("References")]
	[SerializeField]
	protected InteractableObject intObj; // 0x120
	[SerializeField]
	protected Transform button; // 0x128
	public AudioSourceController OnAudio; // 0x130
	public AudioSourceController OffAudio; // 0x138
	public ToggleableLight[] LightsToControl; // 0x140
	[SerializeField]
	[Header("Settings")]
	protected List<ModularSwitch> SwitchesToSyncWith; // 0x148
	public ModularSwitch.ButtonChange onToggled; // 0x150
	public UnityEvent switchedOn; // 0x158
	public UnityEvent switchedOff; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted; // 0x169

	// Methods

	// RVA: 0xA4F7C0 Offset: 0xA4E1C0 VA: 0x180A4F7C0 Slot: 19
	public override void Awake() { }

	// RVA: 0xA4F9E0 Offset: 0xA4E3E0 VA: 0x180A4F9E0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA4F810 Offset: 0xA4E210 VA: 0x180A4F810
	public void Hovered() { }

	// RVA: 0xA4F8A0 Offset: 0xA4E2A0 VA: 0x180A4F8A0
	public void Interacted() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0xA4FFB0 Offset: 0xA4E9B0 VA: 0x180A4FFB0
	private void SendIsOn(bool isOn) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xA500E0 Offset: 0xA4EAE0 VA: 0x180A500E0
	private void SetIsOn(NetworkConnection conn, bool isOn) { }

	// RVA: 0xA50490 Offset: 0xA4EE90 VA: 0x180A50490
	public void SwitchOn() { }

	// RVA: 0xA50350 Offset: 0xA4ED50 VA: 0x180A50350
	public void SwitchOff() { }

	// RVA: 0xA505D0 Offset: 0xA4EFD0 VA: 0x180A505D0
	public void .ctor() { }

	// RVA: 0xA4F8C0 Offset: 0xA4E2C0 VA: 0x180A4F8C0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x881D60 Offset: 0x880760 VA: 0x180881D60 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA4FD20 Offset: 0xA4E720 VA: 0x180A4FD20
	private void RpcWriter___Server_SendIsOn_1140765316(bool isOn) { }

	// RVA: 0xA4FA20 Offset: 0xA4E420 VA: 0x180A4FA20
	private void RpcLogic___SendIsOn_1140765316(bool isOn) { }

	// RVA: 0xA4FAD0 Offset: 0xA4E4D0 VA: 0x180A4FAD0
	private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA4FBE0 Offset: 0xA4E5E0 VA: 0x180A4FBE0
	private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn) { }

	// RVA: 0xA4FA30 Offset: 0xA4E430 VA: 0x180A4FA30
	private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn) { }

	// RVA: 0xA4FA50 Offset: 0xA4E450 VA: 0x180A4FA50
	private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA4FE50 Offset: 0xA4E850 VA: 0x180A4FE50
	private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn) { }

	// RVA: 0xA4FB60 Offset: 0xA4E560 VA: 0x180A4FB60
	private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA4F560 Offset: 0xA4DF60 VA: 0x180A4F560 Slot: 22
	protected virtual void Awake_UserLogic_ScheduleOne.Misc.ModularSwitch_Assembly-CSharp.dll() { }
}
