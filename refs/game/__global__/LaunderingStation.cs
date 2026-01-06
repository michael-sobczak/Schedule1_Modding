public class LaunderingStation : GridItem // TypeDefIndex: 3262
{
	// Fields
	[Header("References")]
	public LaunderingInterface Interface; // 0x210
	[SerializeField]
	protected CashCounter CashCounter; // 0x218
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted; // 0x220
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted; // 0x221

	// Methods

	// RVA: 0xA20E80 Offset: 0xA1F880 VA: 0x180A20E80 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xA20FC0 Offset: 0xA1F9C0 VA: 0x180A20FC0
	private void Update() { }

	// RVA: 0xA20E30 Offset: 0xA1F830 VA: 0x180A20E30 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0x9CC3C0 Offset: 0x9CADC0 VA: 0x1809CC3C0
	public void .ctor() { }

	// RVA: 0xA20FA0 Offset: 0xA1F9A0 VA: 0x180A20FA0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA20F80 Offset: 0xA1F980 VA: 0x180A20F80 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }
}
