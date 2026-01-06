public class CheckpointManager : NetworkSingleton<CheckpointManager> // TypeDefIndex: 1281
{
	// Fields
	[Header("References")]
	public RoadCheckpoint WesternCheckpoint; // 0x120
	public RoadCheckpoint DocksCheckpoint; // 0x128
	public RoadCheckpoint NorthResidentialCheckpoint; // 0x130
	public RoadCheckpoint WestResidentialCheckpoint; // 0x138
	private bool NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted; // 0x141

	// Methods

	// RVA: 0x60CAF0 Offset: 0x60B4F0 VA: 0x18060CAF0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x60CBB0 Offset: 0x60B5B0 VA: 0x18060CBB0
	public void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers) { }

	// RVA: 0x60CA10 Offset: 0x60B410 VA: 0x18060CA10
	public RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc) { }

	// RVA: 0x60CD80 Offset: 0x60B780 VA: 0x18060CD80
	public void .ctor() { }

	// RVA: 0x60CAA0 Offset: 0x60B4A0 VA: 0x18060CAA0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x60CA50 Offset: 0x60B450 VA: 0x18060CA50 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x60C9A0 Offset: 0x60B3A0 VA: 0x18060C9A0 Slot: 20
	public override void Awake() { }
}
