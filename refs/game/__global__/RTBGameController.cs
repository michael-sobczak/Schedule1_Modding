public class RTBGameController : CasinoGameController // TypeDefIndex: 2042
{
	// Fields
	public const int BET_MINIMUM = 10;
	public const int BET_MAXIMUM = 500;
	public const float ANSWER_MAX_TIME = 6;
	[Header("References")]
	public Transform PlayCameraTransform; // 0x148
	public Transform FocusedCameraTransform; // 0x150
	public PlayingCard[] Cards; // 0x158
	public Transform[] CardDefaultPositions; // 0x160
	public Transform ActiveCardPosition; // 0x168
	public Transform[] DockedCardPositions; // 0x170
	[CompilerGenerated]
	private RTBGameController.EStage <CurrentStage>k__BackingField; // 0x178
	public Action<RTBGameController.EStage> onStageChange; // 0x180
	public Action<string, string[]> onQuestionReady; // 0x188
	public Action onQuestionDone; // 0x190
	public Action onLocalPlayerCorrect; // 0x198
	public Action onLocalPlayerIncorrect; // 0x1A0
	public Action onLocalPlayerBetChange; // 0x1A8
	public Action onLocalPlayerExitRound; // 0x1B0
	[CompilerGenerated]
	private bool <IsQuestionActive>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private float <LocalPlayerBet>k__BackingField; // 0x1BC
	[CompilerGenerated]
	private float <LocalPlayerBetMultiplier>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private float <RemainingAnswerTime>k__BackingField; // 0x1C4
	private List<Player> playersInCurrentRound; // 0x1C8
	private List<PlayingCard.CardData> cardsInDeck; // 0x1D0
	private List<PlayingCard.CardData> drawnCards; // 0x1D8
	private bool NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted; // 0x1E0
	private bool NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted; // 0x1E1

	// Properties
	public RTBGameController.EStage CurrentStage { get; set; }
	public bool IsQuestionActive { get; set; }
	public float LocalPlayerBet { get; set; }
	public float LocalPlayerBetMultiplier { get; set; }
	public float MultipliedLocalPlayerBet { get; }
	public float RemainingAnswerTime { get; set; }
	public bool IsLocalPlayerInCurrentRound { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D55E0 Offset: 0x7D3FE0 VA: 0x1807D55E0
	public RTBGameController.EStage get_CurrentStage() { }

	[CompilerGenerated]
	// RVA: 0x7D56E0 Offset: 0x7D40E0 VA: 0x1807D56E0
	private void set_CurrentStage(RTBGameController.EStage value) { }

	[CompilerGenerated]
	// RVA: 0x7D5680 Offset: 0x7D4080 VA: 0x1807D5680
	public bool get_IsQuestionActive() { }

	[CompilerGenerated]
	// RVA: 0x7D56F0 Offset: 0x7D40F0 VA: 0x1807D56F0
	private void set_IsQuestionActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D56A0 Offset: 0x7D40A0 VA: 0x1807D56A0
	public float get_LocalPlayerBet() { }

	[CompilerGenerated]
	// RVA: 0x7D5700 Offset: 0x7D4100 VA: 0x1807D5700
	private void set_LocalPlayerBet(float value) { }

	[CompilerGenerated]
	// RVA: 0x7D5690 Offset: 0x7D4090 VA: 0x1807D5690
	public float get_LocalPlayerBetMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x7D3FC0 Offset: 0x7D29C0 VA: 0x1807D3FC0
	private void set_LocalPlayerBetMultiplier(float value) { }

	// RVA: 0x7D56B0 Offset: 0x7D40B0 VA: 0x1807D56B0
	public float get_MultipliedLocalPlayerBet() { }

	[CompilerGenerated]
	// RVA: 0x7D56D0 Offset: 0x7D40D0 VA: 0x1807D56D0
	public float get_RemainingAnswerTime() { }

	[CompilerGenerated]
	// RVA: 0x7D5710 Offset: 0x7D4110 VA: 0x1807D5710
	private void set_RemainingAnswerTime(float value) { }

	// RVA: 0x7D55F0 Offset: 0x7D3FF0 VA: 0x1807D55F0
	public bool get_IsLocalPlayerInCurrentRound() { }

	// RVA: 0x7D1B50 Offset: 0x7D0550 VA: 0x1807D1B50 Slot: 19
	public override void Awake() { }

	// RVA: 0x7D2FA0 Offset: 0x7D19A0 VA: 0x1807D2FA0 Slot: 23
	protected override void Open() { }

	// RVA: 0x7D1BA0 Offset: 0x7D05A0 VA: 0x1807D1BA0 Slot: 24
	protected override void Close() { }

	// RVA: 0x7D1DA0 Offset: 0x7D07A0 VA: 0x1807D1DA0 Slot: 21
	protected override void Exit(ExitAction action) { }

	// RVA: 0x7D1E40 Offset: 0x7D0840 VA: 0x1807D1E40 Slot: 22
	protected override void FixedUpdate() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D5230 Offset: 0x7D3C30 VA: 0x1807D5230
	private void SetStage(RTBGameController.EStage stage) { }

	// RVA: 0x7D4EA0 Offset: 0x7D38A0 VA: 0x1807D4EA0
	private void RunRound(RTBGameController.EStage stage) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D4FD0 Offset: 0x7D39D0 VA: 0x1807D4FD0
	private void SetBetMultiplier(float multiplier) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D1C50 Offset: 0x7D0650 VA: 0x1807D1C50
	private void EndGame() { }

	// RVA: 0x7D3270 Offset: 0x7D1C70 VA: 0x1807D3270
	public void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0) { }

	// RVA: 0x7D2B60 Offset: 0x7D1560 VA: 0x1807D2B60
	private bool IsCurrentRoundEmpty() { }

	// RVA: 0x7D21D0 Offset: 0x7D0BD0 VA: 0x1807D21D0
	private float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D2E60 Offset: 0x7D1860 VA: 0x1807D2E60
	private void NotifyAnswer(float answerIndex) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D3150 Offset: 0x7D1B50 VA: 0x1807D3150
	private void QuestionDone() { }

	// RVA: 0x7D2830 Offset: 0x7D1230 VA: 0x1807D2830
	private void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out string[] answers) { }

	// RVA: 0x7D37B0 Offset: 0x7D21B0 VA: 0x1807D37B0
	private void ResetCards() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D1860 Offset: 0x7D0260 VA: 0x1807D1860
	private void AddPlayerToCurrentRound(NetworkObject player) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7D3680 Offset: 0x7D2080 VA: 0x1807D3680
	private void RequestRemovePlayerFromCurrentRound(NetworkObject player) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7D3540 Offset: 0x7D1F40 VA: 0x1807D3540
	private void RemovePlayerFromCurrentRound(NetworkObject player) { }

	// RVA: 0x7D3030 Offset: 0x7D1A30 VA: 0x1807D3030
	private PlayingCard.CardData PullCardFromDeck() { }

	// RVA: 0x7D51F0 Offset: 0x7D3BF0 VA: 0x1807D51F0
	public void SetLocalPlayerBet(float bet) { }

	// RVA: 0x7D19A0 Offset: 0x7D03A0 VA: 0x1807D19A0
	public bool AreAllPlayersReady() { }

	// RVA: 0x7D26D0 Offset: 0x7D10D0 VA: 0x1807D26D0
	public int GetPlayersReadyCount() { }

	// RVA: 0x7D5110 Offset: 0x7D3B10 VA: 0x1807D5110
	public void SetLocalPlayerAnswer(float answer) { }

	// RVA: 0x7D24B0 Offset: 0x7D0EB0 VA: 0x1807D24B0
	public int GetAnsweredPlayersCount() { }

	// RVA: 0x7D5360 Offset: 0x7D3D60 VA: 0x1807D5360
	public void ToggleLocalPlayerReady() { }

	// RVA: 0x7D2660 Offset: 0x7D1060 VA: 0x1807D2660
	private int GetCardNumberValue(PlayingCard.CardData card) { }

	// RVA: 0x7D2680 Offset: 0x7D1080 VA: 0x1807D2680
	public static float GetNetBetMultiplier(RTBGameController.EStage stage) { }

	// RVA: 0x7D54C0 Offset: 0x7D3EC0 VA: 0x1807D54C0
	public void .ctor() { }

	// RVA: 0x7D2BE0 Offset: 0x7D15E0 VA: 0x1807D2BE0 Slot: 25
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7D2BB0 Offset: 0x7D15B0 VA: 0x1807D2BB0 Slot: 26
	public override void NetworkInitialize__Late() { }

	// RVA: 0x703DD0 Offset: 0x7027D0 VA: 0x180703DD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7D4C30 Offset: 0x7D3630 VA: 0x1807D4C30
	private void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage) { }

	// RVA: 0x7D3FD0 Offset: 0x7D29D0 VA: 0x1807D3FD0
	private void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage) { }

	// RVA: 0x7D4400 Offset: 0x7D2E00 VA: 0x1807D4400
	private void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D4AE0 Offset: 0x7D34E0 VA: 0x1807D4AE0
	private void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier) { }

	// RVA: 0x7D3FC0 Offset: 0x7D29C0 VA: 0x1807D3FC0
	private void RpcLogic___SetBetMultiplier_431000436(float multiplier) { }

	// RVA: 0x7D43A0 Offset: 0x7D2DA0 VA: 0x1807D43A0
	private void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D4610 Offset: 0x7D3010 VA: 0x1807D4610
	private void RpcWriter___Observers_EndGame_2166136261() { }

	// RVA: 0x7D3B30 Offset: 0x7D2530 VA: 0x1807D3B30
	private void RpcLogic___EndGame_2166136261() { }

	// RVA: 0x7D4210 Offset: 0x7D2C10 VA: 0x1807D4210
	private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D4730 Offset: 0x7D3130 VA: 0x1807D4730
	private void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex) { }

	// RVA: 0x7D3B70 Offset: 0x7D2570 VA: 0x1807D3B70
	private void RpcLogic___NotifyAnswer_431000436(float answerIndex) { }

	// RVA: 0x7D4280 Offset: 0x7D2C80 VA: 0x1807D4280
	private void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D4880 Offset: 0x7D3280 VA: 0x1807D4880
	private void RpcWriter___Observers_QuestionDone_2166136261() { }

	// RVA: 0x7D3D40 Offset: 0x7D2740 VA: 0x1807D3D40
	private void RpcLogic___QuestionDone_2166136261() { }

	// RVA: 0x7D42F0 Offset: 0x7D2CF0 VA: 0x1807D42F0
	private void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D44D0 Offset: 0x7D2ED0 VA: 0x1807D44D0
	private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7D3A50 Offset: 0x7D2450 VA: 0x1807D3A50
	private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7D41A0 Offset: 0x7D2BA0 VA: 0x1807D41A0
	private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D4D70 Offset: 0x7D3770 VA: 0x1807D4D70
	private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7D3540 Offset: 0x7D1F40 VA: 0x1807D3540
	private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7D4450 Offset: 0x7D2E50 VA: 0x1807D4450
	private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7D49A0 Offset: 0x7D33A0 VA: 0x1807D49A0
	private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7D3EC0 Offset: 0x7D28C0 VA: 0x1807D3EC0
	private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7D4330 Offset: 0x7D2D30 VA: 0x1807D4330
	private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7D1B30 Offset: 0x7D0530 VA: 0x1807D1B30 Slot: 28
	protected override void Awake_UserLogic_ScheduleOne.Casino.RTBGameController_Assembly-CSharp.dll() { }
}
