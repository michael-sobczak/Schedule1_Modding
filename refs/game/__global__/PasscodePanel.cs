public class PasscodePanel : NetworkBehaviour // TypeDefIndex: 2314
{
	// Fields
	public const int PasscodeLength = 4;
	[Header("Settings")]
	public string CorrectPasscode; // 0x118
	[Header("References")]
	public InteractableObject[] Buttons; // 0x120
	public TextMeshPro CodeLabel; // 0x128
	public UnityEvent onButtonPressed; // 0x130
	public UnityEvent onCorrect; // 0x138
	public UnityEvent onIncorrect; // 0x140
	private string enteredPasscode; // 0x148
	private bool NetworkInitialize___EarlyScheduleOne.Tools.PasscodePanelAssembly-CSharp.dll_Excuted; // 0x150
	private bool NetworkInitialize__LateScheduleOne.Tools.PasscodePanelAssembly-CSharp.dll_Excuted; // 0x151

	// Methods

	// RVA: 0x845870 Offset: 0x844270 VA: 0x180845870 Slot: 19
	public override void Awake() { }

	// RVA: 0x845D20 Offset: 0x844720 VA: 0x180845D20 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x845B60 Offset: 0x844560 VA: 0x180845B60
	private void OnButtonPressed(int number) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x845A20 Offset: 0x844420 VA: 0x180845A20
	private void OnButtonPressed_Server(int number) { }

	[ObserversRpc]
	// RVA: 0x845DB0 Offset: 0x8447B0 VA: 0x180845DB0
	private void RegisterButtonPress(int number) { }

	// RVA: 0x846940 Offset: 0x845340 VA: 0x180846940
	public void SetIsUsable(bool isUsable) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0x846740 Offset: 0x845140 VA: 0x180846740
	private void SetEnteredPasscode(NetworkConnection conn, string passcode) { }

	// RVA: 0x846A30 Offset: 0x845430 VA: 0x180846A30
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(PasscodePanel.<<RegisterButtonPress>g__Evaluate|12_0>d))]
	// RVA: 0x8469C0 Offset: 0x8453C0 VA: 0x1808469C0
	private IEnumerator <RegisterButtonPress>g__Evaluate|12_0() { }

	// RVA: 0x8458C0 Offset: 0x8442C0 VA: 0x1808458C0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x8081D0 Offset: 0x806BD0 VA: 0x1808081D0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x845A20 Offset: 0x844420 VA: 0x180845A20
	private void RpcWriter___Server_OnButtonPressed_Server_3316948804(int number) { }

	// RVA: 0x845DB0 Offset: 0x8447B0 VA: 0x180845DB0
	private void RpcLogic___OnButtonPressed_Server_3316948804(int number) { }

	// RVA: 0x846280 Offset: 0x844C80 VA: 0x180846280
	private void RpcReader___Server_OnButtonPressed_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x845DB0 Offset: 0x8447B0 VA: 0x180845DB0
	private void RpcWriter___Observers_RegisterButtonPress_3316948804(int number) { }

	// RVA: 0x845F00 Offset: 0x844900 VA: 0x180845F00
	private void RpcLogic___RegisterButtonPress_3316948804(int number) { }

	// RVA: 0x846090 Offset: 0x844A90 VA: 0x180846090
	private void RpcReader___Observers_RegisterButtonPress_3316948804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8464A0 Offset: 0x844EA0 VA: 0x1808464A0
	private void RpcWriter___Observers_SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode) { }

	// RVA: 0x846030 Offset: 0x844A30 VA: 0x180846030
	private void RpcLogic___SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode) { }

	// RVA: 0x846200 Offset: 0x844C00 VA: 0x180846200
	private void RpcReader___Observers_SetEnteredPasscode_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8465E0 Offset: 0x844FE0 VA: 0x1808465E0
	private void RpcWriter___Target_SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode) { }

	// RVA: 0x846410 Offset: 0x844E10 VA: 0x180846410
	private void RpcReader___Target_SetEnteredPasscode_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x845620 Offset: 0x844020 VA: 0x180845620
	private void Awake_UserLogic_ScheduleOne.Tools.PasscodePanel_Assembly-CSharp.dll() { }
}
