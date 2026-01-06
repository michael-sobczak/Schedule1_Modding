public class CashPickup : NetworkedItemPickup // TypeDefIndex: 3050
{
	// Fields
	[SyncVar(OnChange = "ValueChanged")]
	public float Value; // 0x150
	public bool PlayCashPickupSound; // 0x154
	[Header("References")]
	public CashStackVisuals CashStackVisuals; // 0x158
	public SyncVar<float> syncVar___Value; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted; // 0x168
	private bool NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted; // 0x169

	// Properties
	public float SyncAccessor_Value { get; set; }

	// Methods

	// RVA: 0x994C00 Offset: 0x993600 VA: 0x180994C00
	private void Start() { }

	// RVA: 0x9946A0 Offset: 0x9930A0 VA: 0x1809946A0 Slot: 20
	protected override void Hovered() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 21
	protected override bool CanPickup() { }

	// RVA: 0x9949C0 Offset: 0x9933C0 VA: 0x1809949C0 Slot: 22
	protected override void Pickup() { }

	// RVA: 0x994C00 Offset: 0x993600 VA: 0x180994C00
	private void ValueChanged(float oldValue, float newValue, bool asServer) { }

	// RVA: 0x994C10 Offset: 0x993610 VA: 0x180994C10
	private void UpdateCashStackVisuals() { }

	// RVA: 0x994CA0 Offset: 0x9936A0 VA: 0x180994CA0
	public void .ctor() { }

	// RVA: 0x994790 Offset: 0x993190 VA: 0x180994790 Slot: 23
	public override void NetworkInitialize___Early() { }

	// RVA: 0x994730 Offset: 0x993130 VA: 0x180994730 Slot: 24
	public override void NetworkInitialize__Late() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x513120 Offset: 0x511B20 VA: 0x180513120
	public float sync___get_value_Value() { }

	// RVA: 0x994CC0 Offset: 0x9936C0 VA: 0x180994CC0
	public void sync___set_value_Value(float value, bool asServer) { }

	// RVA: 0x994AC0 Offset: 0x9934C0 VA: 0x180994AC0 Slot: 26
	public override bool ReadSyncVar___ScheduleOne.ItemFramework.CashPickup(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x9944D0 Offset: 0x992ED0 VA: 0x1809944D0 Slot: 19
	public override void Awake() { }
}
