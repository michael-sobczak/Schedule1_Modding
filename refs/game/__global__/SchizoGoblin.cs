public class SchizoGoblin : NPC // TypeDefIndex: 1753
{
	// Fields
	private Player targetPlayer; // 0x2F0
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted; // 0x2F8
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted; // 0x2F9

	// Methods

	[ObserversRpc]
	// RVA: 0x742D60 Offset: 0x741760 VA: 0x180742D60
	public void SetTargetPlayer(NetworkObject player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Activate() { }

	// RVA: 0x701620 Offset: 0x700020 VA: 0x180701620
	public void .ctor() { }

	// RVA: 0x742AE0 Offset: 0x7414E0 VA: 0x180742AE0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7414E0 Offset: 0x73FEE0 VA: 0x1807414E0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x742D60 Offset: 0x741760 VA: 0x180742D60
	private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x742B80 Offset: 0x741580 VA: 0x180742B80
	public void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x742C50 Offset: 0x741650 VA: 0x180742C50
	private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }
}
