public class NPCEvent : NPCAction // TypeDefIndex: 1881
{
	// Fields
	public int Duration; // 0x148
	public int EndTime; // 0x14C
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted; // 0x150
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted; // 0x151

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x781990 Offset: 0x780390 VA: 0x180781990
	public string get_ActionName() { }

	[Button]
	// RVA: 0x77F400 Offset: 0x77DE00 VA: 0x18077F400
	public void ApplyDuration() { }

	[Button]
	// RVA: 0x77F4B0 Offset: 0x77DEB0 VA: 0x18077F4B0
	public void ApplyEndTime() { }

	// RVA: 0x784740 Offset: 0x783140 VA: 0x180784740 Slot: 32
	public override void OnActiveMinPass() { }

	// RVA: 0x77E8E0 Offset: 0x77D2E0 VA: 0x18077E8E0 Slot: 33
	public override void PendingMinPassed() { }

	// RVA: 0x781990 Offset: 0x780390 VA: 0x180781990 Slot: 36
	public override string GetName() { }

	// RVA: 0x7819C0 Offset: 0x7803C0 VA: 0x1807819C0 Slot: 37
	public override string GetTimeDescription() { }

	// RVA: 0x781970 Offset: 0x780370 VA: 0x180781970 Slot: 38
	public override int GetEndTime() { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	// RVA: 0x784710 Offset: 0x783110 VA: 0x180784710 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7846E0 Offset: 0x7830E0 VA: 0x1807846E0 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x77F5D0 Offset: 0x77DFD0 VA: 0x18077F5D0 Slot: 20
	public override void Awake() { }
}
