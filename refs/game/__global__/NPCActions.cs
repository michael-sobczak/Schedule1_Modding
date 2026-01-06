public class NPCActions : NetworkBehaviour // TypeDefIndex: 1685
{
	// Fields
	private NPC npc; // 0x118
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted; // 0x120
	private bool NetworkInitialize__LateScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted; // 0x121

	// Properties
	protected NPCBehaviour behaviour { get; }

	// Methods

	// RVA: 0x71CA20 Offset: 0x71B420 VA: 0x18071CA20
	protected NPCBehaviour get_behaviour() { }

	// RVA: 0x71C210 Offset: 0x71AC10 VA: 0x18071C210 Slot: 19
	public override void Awake() { }

	// RVA: 0x71C3C0 Offset: 0x71ADC0 VA: 0x18071C3C0
	public void Cower() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x71C290 Offset: 0x71AC90 VA: 0x18071C290
	public void CallPolice_Networked(NetworkObject playerObj) { }

	// RVA: 0x71C960 Offset: 0x71B360 VA: 0x18071C960
	public void SetCallPoliceBehaviourCrime(Crime crime) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void FacePlayer(Player player) { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(NPCActions.<<Cower>g__Wait|4_0>d))]
	// RVA: 0x71C9B0 Offset: 0x71B3B0 VA: 0x18071C9B0
	private IEnumerator <Cower>g__Wait|4_0() { }

	// RVA: 0x71C4A0 Offset: 0x71AEA0 VA: 0x18071C4A0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5F97A0 Offset: 0x5F81A0 VA: 0x1805F97A0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x71C830 Offset: 0x71B230 VA: 0x18071C830
	private void RpcWriter___Server_CallPolice_Networked_3323014238(NetworkObject playerObj) { }

	// RVA: 0x71C530 Offset: 0x71AF30 VA: 0x18071C530
	public void RpcLogic___CallPolice_Networked_3323014238(NetworkObject playerObj) { }

	// RVA: 0x71C7B0 Offset: 0x71B1B0 VA: 0x18071C7B0
	private void RpcReader___Server_CallPolice_Networked_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x71C1C0 Offset: 0x71ABC0 VA: 0x18071C1C0 Slot: 22
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Actions.NPCActions_Assembly-CSharp.dll() { }
}
