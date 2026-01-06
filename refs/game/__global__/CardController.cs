public class CardController : NetworkBehaviour // TypeDefIndex: 2023
{
	// Fields
	private List<PlayingCard> cards; // 0x118
	private Dictionary<string, PlayingCard> cardDictionary; // 0x120
	private bool NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted; // 0x128
	private bool NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted; // 0x129

	// Methods

	// RVA: 0x7C78C0 Offset: 0x7C62C0 VA: 0x1807C78C0 Slot: 19
	public override void Awake() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7C94E0 Offset: 0x7C7EE0 VA: 0x1807C94E0
	public void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C7D90 Offset: 0x7C6790 VA: 0x1807C7D90
	private void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7C9290 Offset: 0x7C7C90 VA: 0x1807C9290
	public void SendCardFaceUp(string cardId, bool faceUp) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C7B60 Offset: 0x7C6560 VA: 0x1807C7B60
	private void SetCardFaceUp(string cardId, bool faceUp) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7C93E0 Offset: 0x7C7DE0 VA: 0x1807C93E0
	public void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7C7CC0 Offset: 0x7C66C0 VA: 0x1807C7CC0
	private void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime) { }

	// RVA: 0x7C7910 Offset: 0x7C6310 VA: 0x1807C7910
	private PlayingCard GetCard(string cardId) { }

	// RVA: 0x7C9650 Offset: 0x7C8050 VA: 0x1807C9650
	public void .ctor() { }

	// RVA: 0x7C7970 Offset: 0x7C6370 VA: 0x1807C7970 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7A0BE0 Offset: 0x79F5E0 VA: 0x1807A0BE0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7C9130 Offset: 0x7C7B30 VA: 0x1807C9130
	private void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value) { }

	// RVA: 0x7C7D90 Offset: 0x7C6790 VA: 0x1807C7D90
	public void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value) { }

	// RVA: 0x7C86D0 Offset: 0x7C70D0 VA: 0x1807C86D0
	private void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7C8BB0 Offset: 0x7C75B0 VA: 0x1807C8BB0
	private void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value) { }

	// RVA: 0x7C8100 Offset: 0x7C6B00 VA: 0x1807C8100
	private void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value) { }

	// RVA: 0x7C83D0 Offset: 0x7C6DD0 VA: 0x1807C83D0
	private void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C8D20 Offset: 0x7C7720 VA: 0x1807C8D20
	private void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp) { }

	// RVA: 0x7C7B60 Offset: 0x7C6560 VA: 0x1807C7B60
	public void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp) { }

	// RVA: 0x7C8470 Offset: 0x7C6E70 VA: 0x1807C8470
	private void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7C8780 Offset: 0x7C7180 VA: 0x1807C8780
	private void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp) { }

	// RVA: 0x7C7F20 Offset: 0x7C6920 VA: 0x1807C7F20
	private void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp) { }

	// RVA: 0x7C81E0 Offset: 0x7C6BE0 VA: 0x1807C81E0
	private void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C8E80 Offset: 0x7C7880 VA: 0x1807C8E80
	private void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime) { }

	// RVA: 0x7C7CC0 Offset: 0x7C66C0 VA: 0x1807C7CC0
	public void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime) { }

	// RVA: 0x7C8520 Offset: 0x7C6F20 VA: 0x1807C8520
	private void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7C88F0 Offset: 0x7C72F0 VA: 0x1807C88F0
	private void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime) { }

	// RVA: 0x7C7FF0 Offset: 0x7C69F0 VA: 0x1807C7FF0
	private void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime) { }

	// RVA: 0x7C8280 Offset: 0x7C6C80 VA: 0x1807C8280
	private void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7C7650 Offset: 0x7C6050 VA: 0x1807C7650
	private void Awake_UserLogic_ScheduleOne.Casino.CardController_Assembly-CSharp.dll() { }
}
