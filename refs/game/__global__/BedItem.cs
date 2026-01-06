public class BedItem : PlaceableStorageEntity // TypeDefIndex: 3220
{
	// Fields
	public Bed Bed; // 0x290
	public StorageEntity Storage; // 0x298
	public GameObject Briefcase; // 0x2A0
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted; // 0x2A8
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted; // 0x2A9

	// Methods

	// RVA: 0x9C29A0 Offset: 0x9C13A0 VA: 0x1809C29A0 Slot: 48
	protected override void Start() { }

	// RVA: 0x9C25D0 Offset: 0x9C0FD0 VA: 0x1809C25D0
	public static bool IsBedValid(BuildableItem obj, out string reason) { }

	// RVA: 0x9C2A60 Offset: 0x9C1460 VA: 0x1809C2A60
	private void UpdateBriefcase() { }

	// RVA: 0x9C2400 Offset: 0x9C0E00 VA: 0x1809C2400
	public float GetCashSum() { }

	// RVA: 0x9C2780 Offset: 0x9C1180 VA: 0x1809C2780
	public void RemoveCash(float amount) { }

	// RVA: 0x9C2E60 Offset: 0x9C1860 VA: 0x1809C2E60
	public void .ctor() { }

	// RVA: 0x9C2760 Offset: 0x9C1160 VA: 0x1809C2760 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9C2740 Offset: 0x9C1140 VA: 0x1809C2740 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9C23B0 Offset: 0x9C0DB0 VA: 0x1809C23B0 Slot: 47
	public override void Awake() { }
}
