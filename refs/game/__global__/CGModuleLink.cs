public class CGModuleLink // TypeDefIndex: 10643
{
	// Fields
	[SerializeField]
	private int m_ModuleID; // 0x10
	[SerializeField]
	private string m_SlotName; // 0x18
	[SerializeField]
	private int m_TargetModuleID; // 0x20
	[SerializeField]
	private string m_TargetSlotName; // 0x28

	// Properties
	public int ModuleID { get; }
	public string SlotName { get; }
	public int TargetModuleID { get; }
	public string TargetSlotName { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_ModuleID() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_SlotName() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_TargetModuleID() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_TargetSlotName() { }

	// RVA: 0x4F3C50 Offset: 0x4F2650 VA: 0x1804F3C50
	public void .ctor(int sourceID, string sourceSlotName, int targetID, string targetSlotName) { }

	// RVA: 0x4F3B30 Offset: 0x4F2530 VA: 0x1804F3B30
	public void .ctor(CGModuleSlot source, CGModuleSlot target) { }

	// RVA: 0x4F3680 Offset: 0x4F2080 VA: 0x1804F3680
	public bool IsSame(CGModuleLink o) { }

	// RVA: 0x4F36F0 Offset: 0x4F20F0 VA: 0x1804F36F0
	public bool IsSame(CGModuleSlot source, CGModuleSlot target) { }

	// RVA: 0x4F3800 Offset: 0x4F2200 VA: 0x1804F3800
	public bool IsTo(CGModuleSlot s) { }

	// RVA: 0x4F35E0 Offset: 0x4F1FE0 VA: 0x1804F35E0
	public bool IsFrom(CGModuleSlot s) { }

	// RVA: 0x4F38A0 Offset: 0x4F22A0 VA: 0x1804F38A0
	public bool IsUsing(CGModule module) { }

	// RVA: 0x4F34A0 Offset: 0x4F1EA0 VA: 0x1804F34A0
	public bool IsBetween(CGModuleSlot one, CGModuleSlot another) { }

	// RVA: 0x4F3910 Offset: 0x4F2310 VA: 0x1804F3910
	public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID) { }

	// RVA: 0x4D76B0 Offset: 0x4D60B0 VA: 0x1804D76B0
	public static bool op_Implicit(CGModuleLink a) { }

	// RVA: 0x4F3920 Offset: 0x4F2320 VA: 0x1804F3920 Slot: 3
	public override string ToString() { }
}
