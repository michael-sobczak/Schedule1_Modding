public class LabelledSurfaceItem : SurfaceItem // TypeDefIndex: 1399
{
	// Fields
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x208
	public int MaxCharacters; // 0x210
	[Header("References")]
	public TextMeshPro Label; // 0x218
	private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted; // 0x220
	private bool NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted; // 0x221

	// Properties
	public string Message { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6410C0 Offset: 0x63FAC0 VA: 0x1806410C0
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x6864B0 Offset: 0x684EB0 VA: 0x1806864B0
	private void set_Message(string value) { }

	// RVA: 0x685B60 Offset: 0x684560 VA: 0x180685B60 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6858C0 Offset: 0x6842C0 VA: 0x1806858C0
	public void SendMessageToServer(string message) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6861C0 Offset: 0x684BC0 VA: 0x1806861C0
	public void SetMessage(NetworkConnection conn, string message) { }

	// RVA: 0x6857B0 Offset: 0x6841B0 VA: 0x1806857B0
	public void Interacted() { }

	// RVA: 0x6858C0 Offset: 0x6842C0 VA: 0x1806858C0
	private void MessageSubmitted(string message) { }

	// RVA: 0x685640 Offset: 0x684040 VA: 0x180685640 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x686450 Offset: 0x684E50 VA: 0x180686450
	public void .ctor() { }

	// RVA: 0x685A30 Offset: 0x684430 VA: 0x180685A30 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x6859F0 Offset: 0x6843F0 VA: 0x1806859F0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x685F30 Offset: 0x684930 VA: 0x180685F30
	private void RpcWriter___Server_SendMessageToServer_3615296227(string message) { }

	// RVA: 0x685BE0 Offset: 0x6845E0 VA: 0x180685BE0
	public void RpcLogic___SendMessageToServer_3615296227(string message) { }

	// RVA: 0x685CE0 Offset: 0x6846E0 VA: 0x180685CE0
	private void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x685DF0 Offset: 0x6847F0 VA: 0x180685DF0
	private void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message) { }

	// RVA: 0x685BF0 Offset: 0x6845F0 VA: 0x180685BF0
	public void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message) { }

	// RVA: 0x685C50 Offset: 0x684650 VA: 0x180685C50
	private void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x686060 Offset: 0x684A60 VA: 0x180686060
	private void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message) { }

	// RVA: 0x685D60 Offset: 0x684760 VA: 0x180685D60
	private void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6855D0 Offset: 0x683FD0 VA: 0x1806855D0 Slot: 47
	public override void Awake() { }
}
