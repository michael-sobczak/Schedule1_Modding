public class BlackjackGameController : CasinoGameController // TypeDefIndex: 2022
{
	// Fields
	public const int BET_MINIMUM = 10;
	public const int BET_MAXIMUM = 1000;
	public const float PAYOUT_RATIO = 1;
	public const float BLACKJACK_PAYOUT_RATIO = 1.5;
	[CompilerGenerated]
	private BlackjackGameController.EStage <CurrentStage>k__BackingField; // 0x148
	[CompilerGenerated]
	private Player <PlayerTurn>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <LocalPlayerBet>k__BackingField; // 0x158
	[CompilerGenerated]
	private int <DealerScore>k__BackingField; // 0x15C
	[CompilerGenerated]
	private int <LocalPlayerScore>k__BackingField; // 0x160
	[CompilerGenerated]
	private bool <IsLocalPlayerBlackjack>k__BackingField; // 0x164
	[CompilerGenerated]
	private bool <IsLocalPlayerBust>k__BackingField; // 0x165
	[Header("References")]
	public PlayingCard[] Cards; // 0x168
	public Transform[] DefaultCardPositions; // 0x170
	public Transform[] FocusedCameraTransforms; // 0x178
	public Transform[] FinalCameraTransforms; // 0x180
	public Transform[] Player1CardPositions; // 0x188
	public Transform[] Player2CardPositions; // 0x190
	public Transform[] Player3CardPositions; // 0x198
	public Transform[] Player4CardPositions; // 0x1A0
	public Transform[] DealerCardPositions; // 0x1A8
	private List<Player> playersInCurrentRound; // 0x1B0
	private List<PlayingCard> playStack; // 0x1B8
	private List<PlayingCard> player1Hand; // 0x1C0
	private List<PlayingCard> player2Hand; // 0x1C8
	private List<PlayingCard> player3Hand; // 0x1D0
	private List<PlayingCard> player4Hand; // 0x1D8
	private List<PlayingCard> dealerHand; // 0x1E0
	private List<PlayingCard.CardData> cardValuesInDeck; // 0x1E8
	private List<PlayingCard.CardData> drawnCardsValues; // 0x1F0
	protected Transform localFocusCameraTransform; // 0x1F8
	protected Transform localFinalCameraTransform; // 0x200
	public Action onLocalPlayerBetChange; // 0x208
	public Action onLocalPlayerExitRound; // 0x210
	public Action onInitialCardsDealt; // 0x218
	public Action onLocalPlayerReadyForInput; // 0x220
	public Action onLocalPlayerBust; // 0x228
	public Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted; // 0x230
	private bool roundEnded; // 0x238
	private Coroutine gameRoutine; // 0x240
	private bool NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted; // 0x248
	private bool NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted; // 0x249

	// Properties
	public BlackjackGameController.EStage CurrentStage { get; set; }
	public Player PlayerTurn { get; set; }
	public float LocalPlayerBet { get; set; }
	public int DealerScore { get; set; }
	public int LocalPlayerScore { get; set; }
	public bool IsLocalPlayerBlackjack { get; set; }
	public bool IsLocalPlayerBust { get; set; }
	public bool IsLocalPlayerInCurrentRound { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BFD70 Offset: 0x6BE770 VA: 0x1806BFD70
	public BlackjackGameController.EStage get_CurrentStage() { }

	[CompilerGenerated]
	// RVA: 0x6BFF70 Offset: 0x6BE970 VA: 0x1806BFF70
	private void set_CurrentStage(BlackjackGameController.EStage value) { }

	[CompilerGenerated]
	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	public Player get_PlayerTurn() { }

	[CompilerGenerated]
	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00
	private void set_PlayerTurn(Player value) { }

	[CompilerGenerated]
	// RVA: 0x7C75F0 Offset: 0x7C5FF0 VA: 0x1807C75F0
	public float get_LocalPlayerBet() { }

	[CompilerGenerated]
	// RVA: 0x7C7630 Offset: 0x7C6030 VA: 0x1807C7630
	private void set_LocalPlayerBet(float value) { }

	[CompilerGenerated]
	// RVA: 0x7C7530 Offset: 0x7C5F30 VA: 0x1807C7530
	public int get_DealerScore() { }

	[CompilerGenerated]
	// RVA: 0x7C7600 Offset: 0x7C6000 VA: 0x1807C7600
	private void set_DealerScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x79A8B0 Offset: 0x7992B0 VA: 0x18079A8B0
	public int get_LocalPlayerScore() { }

	[CompilerGenerated]
	// RVA: 0x7C7640 Offset: 0x7C6040 VA: 0x1807C7640
	private void set_LocalPlayerScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x7C7540 Offset: 0x7C5F40 VA: 0x1807C7540
	public bool get_IsLocalPlayerBlackjack() { }

	[CompilerGenerated]
	// RVA: 0x7C7610 Offset: 0x7C6010 VA: 0x1807C7610
	private void set_IsLocalPlayerBlackjack(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7C7550 Offset: 0x7C5F50 VA: 0x1807C7550
	public bool get_IsLocalPlayerBust() { }

	[CompilerGenerated]
	// RVA: 0x7C7620 Offset: 0x7C6020 VA: 0x1807C7620
	private void set_IsLocalPlayerBust(bool value) { }

	// RVA: 0x7C7560 Offset: 0x7C5F60 VA: 0x1807C7560
	public bool get_IsLocalPlayerInCurrentRound() { }

	// RVA: 0x7C33E0 Offset: 0x7C1DE0 VA: 0x1807C33E0 Slot: 19
	public override void Awake() { }

	// RVA: 0x7C48E0 Offset: 0x7C32E0 VA: 0x1807C48E0 Slot: 23
	protected override void Open() { }

	// RVA: 0x7C3430 Offset: 0x7C1E30 VA: 0x1807C3430 Slot: 24
	protected override void Close() { }

	// RVA: 0x7C37C0 Offset: 0x7C21C0 VA: 0x1807C37C0 Slot: 21
	protected override void Exit(ExitAction action) { }

	// RVA: 0x7C3860 Offset: 0x7C2260 VA: 0x1807C3860 Slot: 22
	protected override void FixedUpdate() { }

	// RVA: 0x7C3D40 Offset: 0x7C2740 VA: 0x1807C3D40
	private List<Player> GetClockwisePlayers() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C7050 Offset: 0x7C5A50 VA: 0x1807C7050
	private void StartGame() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C4740 Offset: 0x7C3140 VA: 0x1807C4740
	private void NotifyPlayerScore(NetworkObject player, int score, bool blackjack) { }

	// RVA: 0x7C4210 Offset: 0x7C2C10 VA: 0x1807C4210
	private Transform[] GetPlayerCardPositions(int playerIndex) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C6F10 Offset: 0x7C5910 VA: 0x1807C6F10
	private void SetRoundEnded(bool ended) { }

	// RVA: 0x7C2E10 Offset: 0x7C1810 VA: 0x1807C2E10
	private void AddCardToPlayerHand(int playerIndex, PlayingCard card) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C2F80 Offset: 0x7C1980 VA: 0x1807C2F80
	private void AddCardToPlayerHand(int playerindex, string cardID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C2CD0 Offset: 0x7C16D0 VA: 0x1807C2CD0
	private void AddCardToDealerHand(string cardID) { }

	// RVA: 0x7C4250 Offset: 0x7C2C50 VA: 0x1807C4250
	private List<PlayingCard> GetPlayerCards(int playerIndex) { }

	// RVA: 0x7C3F70 Offset: 0x7C2970 VA: 0x1807C3F70
	private int GetHandScore(List<PlayingCard> cards, bool countFaceDown = True) { }

	// RVA: 0x7C3CF0 Offset: 0x7C26F0 VA: 0x1807C3CF0
	private int GetCardValue(PlayingCard card, bool aceAsEleven = True) { }

	// RVA: 0x7C34E0 Offset: 0x7C1EE0 VA: 0x1807C34E0
	private PlayingCard DrawCard() { }

	// RVA: 0x7C5080 Offset: 0x7C3A80 VA: 0x1807C5080
	private void ResetCards() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C3680 Offset: 0x7C2080 VA: 0x1807C3680
	private void EndGame() { }

	// RVA: 0x7C4AC0 Offset: 0x7C34C0 VA: 0x1807C4AC0
	public void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0) { }

	// RVA: 0x7C41E0 Offset: 0x7C2BE0 VA: 0x1807C41E0
	public float GetPayout(float bet, BlackjackGameController.EPayoutType payout) { }

	// RVA: 0x7C43F0 Offset: 0x7C2DF0 VA: 0x1807C43F0
	private bool IsCurrentRoundEmpty() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C30F0 Offset: 0x7C1AF0 VA: 0x1807C30F0
	private void AddPlayerToCurrentRound(NetworkObject player) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7C4F50 Offset: 0x7C3950 VA: 0x1807C4F50
	private void RequestRemovePlayerFromCurrentRound(NetworkObject player) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C4E10 Offset: 0x7C3810 VA: 0x1807C4E10
	private void RemovePlayerFromCurrentRound(NetworkObject player) { }

	// RVA: 0x7C6ED0 Offset: 0x7C58D0 VA: 0x1807C6ED0
	public void SetLocalPlayerBet(float bet) { }

	// RVA: 0x7C3230 Offset: 0x7C1C30 VA: 0x1807C3230
	public bool AreAllPlayersReady() { }

	// RVA: 0x7C4290 Offset: 0x7C2C90 VA: 0x1807C4290
	public int GetPlayersReadyCount() { }

	// RVA: 0x7C7170 Offset: 0x7C5B70 VA: 0x1807C7170
	public void ToggleLocalPlayerReady() { }

	// RVA: 0x7C72D0 Offset: 0x7C5CD0 VA: 0x1807C72D0
	public void .ctor() { }

	// RVA: 0x7C4470 Offset: 0x7C2E70 VA: 0x1807C4470 Slot: 25
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7C4440 Offset: 0x7C2E40 VA: 0x1807C4440 Slot: 26
	public override void NetworkInitialize__Late() { }

	// RVA: 0x703DD0 Offset: 0x7027D0 VA: 0x180703DD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7C6C90 Offset: 0x7C5690 VA: 0x1807C6C90
	private void RpcWriter___Observers_StartGame_2166136261() { }

	// RVA: 0x7C5BF0 Offset: 0x7C45F0 VA: 0x1807C5BF0
	private void RpcLogic___StartGame_2166136261() { }

	// RVA: 0x7C62B0 Offset: 0x7C4CB0 VA: 0x1807C62B0
	private void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C6890 Offset: 0x7C5290 VA: 0x1807C6890
	private void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack) { }

	// RVA: 0x7C59C0 Offset: 0x7C43C0 VA: 0x1807C59C0
	private void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack) { }

	// RVA: 0x7C6100 Offset: 0x7C4B00 VA: 0x1807C6100
	private void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C6B50 Offset: 0x7C5550 VA: 0x1807C6B50
	private void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended) { }

	// RVA: 0x7C5BE0 Offset: 0x7C45E0 VA: 0x1807C5BE0
	private void RpcLogic___SetRoundEnded_1140765316(bool ended) { }

	// RVA: 0x7C6240 Offset: 0x7C4C40 VA: 0x1807C6240
	private void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C64B0 Offset: 0x7C4EB0 VA: 0x1807C64B0
	private void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID) { }

	// RVA: 0x7C5610 Offset: 0x7C4010 VA: 0x1807C5610
	private void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID) { }

	// RVA: 0x7C5FA0 Offset: 0x7C49A0 VA: 0x1807C5FA0
	private void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C6370 Offset: 0x7C4D70 VA: 0x1807C6370
	private void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID) { }

	// RVA: 0x7C54A0 Offset: 0x7C3EA0 VA: 0x1807C54A0
	private void RpcLogic___AddCardToDealerHand_3615296227(string cardID) { }

	// RVA: 0x7C5F40 Offset: 0x7C4940 VA: 0x1807C5F40
	private void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C6770 Offset: 0x7C5170 VA: 0x1807C6770
	private void RpcWriter___Observers_EndGame_2166136261() { }

	// RVA: 0x7C5980 Offset: 0x7C4380 VA: 0x1807C5980
	private void RpcLogic___EndGame_2166136261() { }

	// RVA: 0x7C60A0 Offset: 0x7C4AA0 VA: 0x1807C60A0
	private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C6630 Offset: 0x7C5030 VA: 0x1807C6630
	private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7C5830 Offset: 0x7C4230 VA: 0x1807C5830
	private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7C6030 Offset: 0x7C4A30 VA: 0x1807C6030
	private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C6DA0 Offset: 0x7C57A0 VA: 0x1807C6DA0
	private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7C4E10 Offset: 0x7C3810 VA: 0x1807C4E10
	private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7C62F0 Offset: 0x7C4CF0 VA: 0x1807C62F0
	private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7C6A10 Offset: 0x7C5410 VA: 0x1807C6A10
	private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7C5A90 Offset: 0x7C4490 VA: 0x1807C5A90
	private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player) { }

	// RVA: 0x7C61D0 Offset: 0x7C4BD0 VA: 0x1807C61D0
	private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C33C0 Offset: 0x7C1DC0 VA: 0x1807C33C0 Slot: 28
	protected override void Awake_UserLogic_ScheduleOne.Casino.BlackjackGameController_Assembly-CSharp.dll() { }
}
