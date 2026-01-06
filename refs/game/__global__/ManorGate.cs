public class ManorGate : Gate // TypeDefIndex: 3339
{
	// Fields
	[Header("References")]
	public InteractableObject IntercomInt; // 0x190
	public Light IntercomLight; // 0x198
	public VehicleDetector ExteriorVehicleDetector; // 0x1A0
	public PlayerDetector ExteriorPlayerDetector; // 0x1A8
	public VehicleDetector InteriorVehicleDetector; // 0x1B0
	public PlayerDetector InteriorPlayerDetector; // 0x1B8
	private bool intercomActive; // 0x1C0
	private bool NetworkInitialize___EarlyScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted; // 0x1C1
	private bool NetworkInitialize__LateScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted; // 0x1C2

	// Methods

	// RVA: 0xA4DD50 Offset: 0xA4C750 VA: 0x180A4DD50 Slot: 22
	protected virtual void Start() { }

	// RVA: 0xA4DE60 Offset: 0xA4C860 VA: 0x180A4DE60
	private void UpdateDetection() { }

	// RVA: 0xA4DAF0 Offset: 0xA4C4F0 VA: 0x180A4DAF0
	public void IntercomBuzzed() { }

	// RVA: 0xA4DC50 Offset: 0xA4C650 VA: 0x180A4DC50
	public void SetEnterable(bool enterable) { }

	[Button]
	// RVA: 0xA4DA30 Offset: 0xA4C430 VA: 0x180A4DA30
	public void ActivateIntercom() { }

	// RVA: 0xA4DD00 Offset: 0xA4C700 VA: 0x180A4DD00
	public void SetIntercomActive(bool active) { }

	// RVA: 0xA4E190 Offset: 0xA4CB90 VA: 0x180A4E190
	private void UpdateIntercom() { }

	// RVA: 0xA4C760 Offset: 0xA4B160 VA: 0x180A4C760
	public void .ctor() { }

	// RVA: 0xA4DB70 Offset: 0xA4C570 VA: 0x180A4DB70 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA4DB40 Offset: 0xA4C540 VA: 0x180A4DB40 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA4DA80 Offset: 0xA4C480 VA: 0x180A4DA80 Slot: 21
	public override void Awake() { }
}
