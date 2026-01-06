public class ComponentSyncStateBehaviour : NetworkBehaviour // TypeDefIndex: 18104
{
	// Fields
	[SyncObject]
	private readonly ComponentStateSync<AMonoScript> _syncScript; // 0x118
	private bool NetworkInitialize___EarlyFishNet.Example.ComponentStateSync.ComponentSyncStateBehaviourFishNet.Demos.dll_Excuted; // 0x120
	private bool NetworkInitialize__LateFishNet.Example.ComponentStateSync.ComponentSyncStateBehaviourFishNet.Demos.dll_Excuted; // 0x121

	// Methods

	// RVA: 0xCE4E40 Offset: 0xCE3840 VA: 0x180CE4E40 Slot: 19
	public override void Awake() { }

	// RVA: 0xCE5140 Offset: 0xCE3B40 VA: 0x180CE5140
	private void _syncScript_OnChange(AMonoScript component, bool prevState, bool nextState, bool asServer) { }

	// RVA: 0xCE5010 Offset: 0xCE3A10 VA: 0x180CE5010
	private void Update() { }

	// RVA: 0xCE50C0 Offset: 0xCE3AC0 VA: 0x180CE50C0
	public void .ctor() { }

	// RVA: 0xCE4FA0 Offset: 0xCE39A0 VA: 0x180CE4FA0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCE4F50 Offset: 0xCE3950 VA: 0x180CE4F50 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xCE4D60 Offset: 0xCE3760 VA: 0x180CE4D60
	private void Awake_UserLogic_FishNet.Example.ComponentStateSync.ComponentSyncStateBehaviour_FishNet.Demos.dll() { }
}
