public class PropertyDoorController : DoorController // TypeDefIndex: 2125
{
	// Fields
	public const float WANTED_PLAYER_CLOSE_DISTANCE = 20;
	public Property Property; // 0x190
	private bool IsUnlocked; // 0x198
	private bool NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted; // 0x199
	private bool NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted; // 0x19A

	// Methods

	// RVA: 0x80B390 Offset: 0x809D90 VA: 0x18080B390 Slot: 19
	public override void Awake() { }

	// RVA: 0x80BC90 Offset: 0x80A690 VA: 0x18080BC90
	public void Unlock() { }

	// RVA: 0x80B7E0 Offset: 0x80A1E0 VA: 0x18080B7E0
	private void CheckClose() { }

	// RVA: 0x80B4E0 Offset: 0x809EE0 VA: 0x18080B4E0 Slot: 26
	protected override bool CanPlayerAccess(EDoorSide side, out string reason) { }

	// RVA: 0x80B940 Offset: 0x80A340 VA: 0x18080B940
	private Player GetNearestWantedPlayer() { }

	// RVA: 0x80BCB0 Offset: 0x80A6B0 VA: 0x18080BCB0
	public void .ctor() { }

	// RVA: 0x80BC70 Offset: 0x80A670 VA: 0x18080BC70 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x80BC50 Offset: 0x80A650 VA: 0x18080BC50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x80B270 Offset: 0x809C70 VA: 0x18080B270 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.Building.Doors.PropertyDoorController_Assembly-CSharp.dll() { }
}
