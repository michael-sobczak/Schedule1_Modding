public class Thomas : NPC // TypeDefIndex: 1760
{
	// Fields
	public Sprite MessagingIcon; // 0x2F0
	public UnityEvent onMeetingEnded; // 0x2F8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted; // 0x300
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted; // 0x301

	// Methods

	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40 Slot: 70
	public override Sprite GetMessagingIcon() { }

	// RVA: 0x745610 Offset: 0x744010 VA: 0x180745610
	public void SendIntroMessage() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x744EF0 Offset: 0x7438F0 VA: 0x180744EF0
	public void MeetingEnded_Server() { }

	[ObserversRpc]
	// RVA: 0x745000 Offset: 0x743A00 VA: 0x180745000
	private void MeetingEnded() { }

	// RVA: 0x744D70 Offset: 0x743770 VA: 0x180744D70 Slot: 68
	protected override void CreateMessageConversation() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x744C60 Offset: 0x743660 VA: 0x180744C60
	private void CancelAgreement_Server() { }

	// RVA: 0x701620 Offset: 0x700020 VA: 0x180701620
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7459D0 Offset: 0x7443D0 VA: 0x1807459D0
	internal static bool <CreateMessageConversation>g__ShowCancelAgreement|6_0(SendableMessage msg) { }

	[CompilerGenerated]
	// RVA: 0x7458A0 Offset: 0x7442A0 VA: 0x1807458A0
	private void <CreateMessageConversation>g__ConfirmCancelAgreement|6_1() { }

	[CompilerGenerated]
	// RVA: 0x7456F0 Offset: 0x7440F0 VA: 0x1807456F0
	private void <CreateMessageConversation>g__CancelAgreementCallback|6_2(ConfirmationPopup.EResponse response) { }

	// RVA: 0x745120 Offset: 0x743B20 VA: 0x180745120 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x71A970 Offset: 0x719370 VA: 0x18071A970 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x744EF0 Offset: 0x7438F0 VA: 0x180744EF0
	private void RpcWriter___Server_MeetingEnded_Server_2166136261() { }

	// RVA: 0x745000 Offset: 0x743A00 VA: 0x180745000
	public void RpcLogic___MeetingEnded_Server_2166136261() { }

	// RVA: 0x7454E0 Offset: 0x743EE0 VA: 0x1807454E0
	private void RpcReader___Server_MeetingEnded_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x745000 Offset: 0x743A00 VA: 0x180745000
	private void RpcWriter___Observers_MeetingEnded_2166136261() { }

	// RVA: 0x745360 Offset: 0x743D60 VA: 0x180745360
	private void RpcLogic___MeetingEnded_2166136261() { }

	// RVA: 0x745380 Offset: 0x743D80 VA: 0x180745380
	private void RpcReader___Observers_MeetingEnded_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x744C60 Offset: 0x743660 VA: 0x180744C60
	private void RpcWriter___Server_CancelAgreement_Server_2166136261() { }

	// RVA: 0x745250 Offset: 0x743C50 VA: 0x180745250
	private void RpcLogic___CancelAgreement_Server_2166136261() { }

	// RVA: 0x7453C0 Offset: 0x743DC0 VA: 0x1807453C0
	private void RpcReader___Server_CancelAgreement_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }
}
