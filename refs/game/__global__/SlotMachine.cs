public class SlotMachine : NetworkBehaviour // TypeDefIndex: 2047
{
	// Fields
	public static int[] BetAmounts; // 0x0
	[CompilerGenerated]
	private bool <IsSpinning>k__BackingField; // 0x118
	[Header("References")]
	public InteractableObject DownButton; // 0x120
	public InteractableObject UpButton; // 0x128
	public InteractableObject HandleIntObj; // 0x130
	public TextMeshPro BetAmountLabel; // 0x138
	public SlotReel[] Reels; // 0x140
	public AudioSourceController SpinLoop; // 0x148
	public Animation ScreenAnimation; // 0x150
	public ParticleSystem[] JackpotParticles; // 0x158
	[Header("Win Animations")]
	public TextMeshProUGUI[] WinAmountLabels; // 0x160
	public AnimationClip MiniWinAnimation; // 0x168
	public AnimationClip SmallWinAnimation; // 0x170
	public AnimationClip BigWinAnimation; // 0x178
	public AnimationClip JackpotAnimation; // 0x180
	public AudioSourceController MiniWinSound; // 0x188
	public AudioSourceController SmallWinSound; // 0x190
	public AudioSourceController BigWinSound; // 0x198
	public AudioSourceController JackpotSound; // 0x1A0
	public UnityEvent onDownPressed; // 0x1A8
	public UnityEvent onUpPressed; // 0x1B0
	public UnityEvent onHandlePulled; // 0x1B8
	private int currentBetIndex; // 0x1C0
	private bool NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted; // 0x1C4
	private bool NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted; // 0x1C5

	// Properties
	public bool IsSpinning { get; set; }
	private int currentBetAmount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsSpinning() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	private void set_IsSpinning(bool value) { }

	// RVA: 0x7F0870 Offset: 0x7EF270 VA: 0x1807F0870
	private int get_currentBetAmount() { }

	// RVA: 0x7EE1F0 Offset: 0x7ECBF0 VA: 0x1807EE1F0 Slot: 19
	public override void Awake() { }

	// RVA: 0x7EEDE0 Offset: 0x7ED7E0 VA: 0x1807EEDE0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x7EE460 Offset: 0x7ECE60 VA: 0x1807EE460
	private void DownHovered() { }

	// RVA: 0x7EE4E0 Offset: 0x7ECEE0 VA: 0x1807EE4E0
	private void DownInteracted() { }

	// RVA: 0x7F0700 Offset: 0x7EF100 VA: 0x1807F0700
	private void UpHovered() { }

	// RVA: 0x7F0780 Offset: 0x7EF180 VA: 0x1807F0780
	private void UpInteracted() { }

	// RVA: 0x7EE730 Offset: 0x7ED130 VA: 0x1807EE730
	private void HandleHovered() { }

	[Button]
	// RVA: 0x7EE870 Offset: 0x7ED270 VA: 0x1807EE870
	public void HandleInteracted() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7EFC80 Offset: 0x7EE680 VA: 0x1807EFC80
	private void SendBetIndex(int index) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x7EFF20 Offset: 0x7EE920 VA: 0x1807EFF20
	public void SetBetIndex(NetworkConnection conn, int index) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7EFDC0 Offset: 0x7EE7C0 VA: 0x1807EFDC0
	public void SendStartSpin(NetworkConnection spinner, int betAmount) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7F0560 Offset: 0x7EEF60 VA: 0x1807F0560
	public void StartSpin(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount) { }

	// RVA: 0x7EE520 Offset: 0x7ECF20 VA: 0x1807EE520
	private SlotMachine.EOutcome EvaluateOutcome(SlotMachine.ESymbol[] outcome) { }

	// RVA: 0x7EE700 Offset: 0x7ED100 VA: 0x1807EE700
	private int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount) { }

	// RVA: 0x7EE240 Offset: 0x7ECC40 VA: 0x1807EE240
	private void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount) { }

	// RVA: 0x7EE610 Offset: 0x7ED010 VA: 0x1807EE610
	public static SlotMachine.ESymbol GetRandomSymbol() { }

	// RVA: 0x7EEBA0 Offset: 0x7ED5A0 VA: 0x1807EEBA0
	private bool IsFruit(SlotMachine.ESymbol symbol) { }

	// RVA: 0x7EEB40 Offset: 0x7ED540 VA: 0x1807EEB40
	private bool IsAllFruit(SlotMachine.ESymbol[] symbols) { }

	// RVA: 0x7EEBB0 Offset: 0x7ED5B0 VA: 0x1807EEBB0
	private bool IsUniform(SlotMachine.ESymbol[] symbols) { }

	[Button]
	// RVA: 0x7F01A0 Offset: 0x7EEBA0 VA: 0x1807F01A0
	public void SimulateMany() { }

	// RVA: 0x7F0850 Offset: 0x7EF250 VA: 0x1807F0850
	public void .ctor() { }

	// RVA: 0x7F07C0 Offset: 0x7EF1C0 VA: 0x1807F07C0
	private static void .cctor() { }

	// RVA: 0x7EEC30 Offset: 0x7ED630 VA: 0x1807EEC30 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7EEC10 Offset: 0x7ED610 VA: 0x1807EEC10 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7EF860 Offset: 0x7EE260 VA: 0x1807EF860
	private void RpcWriter___Server_SendBetIndex_3316948804(int index) { }

	// RVA: 0x7EEE30 Offset: 0x7ED830 VA: 0x1807EEE30
	private void RpcLogic___SendBetIndex_3316948804(int index) { }

	// RVA: 0x7EF400 Offset: 0x7EDE00 VA: 0x1807EF400
	private void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7EF590 Offset: 0x7EDF90 VA: 0x1807EF590
	private void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index) { }

	// RVA: 0x7EF090 Offset: 0x7EDA90 VA: 0x1807EF090
	public void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index) { }

	// RVA: 0x7EF2E0 Offset: 0x7EDCE0 VA: 0x1807EF2E0
	private void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7EFB10 Offset: 0x7EE510 VA: 0x1807EFB10
	private void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index) { }

	// RVA: 0x7EF520 Offset: 0x7EDF20 VA: 0x1807EF520
	private void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7EF9A0 Offset: 0x7EE3A0 VA: 0x1807EF9A0
	private void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount) { }

	// RVA: 0x7EEE40 Offset: 0x7ED840 VA: 0x1807EEE40
	public void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount) { }

	// RVA: 0x7EF480 Offset: 0x7EDE80 VA: 0x1807EF480
	private void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7EF6E0 Offset: 0x7EE0E0 VA: 0x1807EF6E0
	private void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount) { }

	// RVA: 0x7EF160 Offset: 0x7EDB60 VA: 0x1807EF160
	public void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount) { }

	// RVA: 0x7EF350 Offset: 0x7EDD50 VA: 0x1807EF350
	private void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7EDF80 Offset: 0x7EC980 VA: 0x1807EDF80
	private void Awake_UserLogic_ScheduleOne.Casino.SlotMachine_Assembly-CSharp.dll() { }
}
