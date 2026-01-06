public class RV : Property // TypeDefIndex: 756
{
	// Fields
	public Transform ModelContainer; // 0x250
	public Transform FXContainer; // 0x258
	public UnityEvent onSetExploded; // 0x260
	[CompilerGenerated]
	private bool <_isExploded>k__BackingField; // 0x268
	private bool NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted; // 0x269
	private bool NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted; // 0x26A

	// Properties
	public bool _isExploded { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x595640 Offset: 0x594040 VA: 0x180595640
	public bool get__isExploded() { }

	[CompilerGenerated]
	// RVA: 0x595650 Offset: 0x594050 VA: 0x180595650
	private void set__isExploded(bool value) { }

	// RVA: 0x594DD0 Offset: 0x5937D0 VA: 0x180594DD0 Slot: 44
	protected override void Start() { }

	// RVA: 0x594750 Offset: 0x593150 VA: 0x180594750 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x594F60 Offset: 0x593960 VA: 0x180594F60
	private void UpdateVariables() { }

	// RVA: 0x5948C0 Offset: 0x5932C0 VA: 0x1805948C0
	public void Ransack() { }

	// RVA: 0x594DB0 Offset: 0x5937B0 VA: 0x180594DB0 Slot: 49
	public override bool ShouldSave() { }

	[TargetRpc]
	// RVA: 0x594C80 Offset: 0x593680 VA: 0x180594C80
	public void SetExploded(NetworkConnection conn) { }

	// RVA: 0x594C10 Offset: 0x593610 VA: 0x180594C10
	public void SetExploded() { }

	// RVA: 0x5946C0 Offset: 0x5930C0 VA: 0x1805946C0
	private void OnSleep() { }

	// RVA: 0x5955F0 Offset: 0x593FF0 VA: 0x1805955F0
	public void .ctor() { }

	// RVA: 0x594620 Offset: 0x593020 VA: 0x180594620 Slot: 56
	public override void NetworkInitialize___Early() { }

	// RVA: 0x594600 Offset: 0x593000 VA: 0x180594600 Slot: 57
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5945C0 Offset: 0x592FC0 VA: 0x1805945C0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x594C80 Offset: 0x593680 VA: 0x180594C80
	private void RpcWriter___Target_SetExploded_328543758(NetworkConnection conn) { }

	// RVA: 0x594C10 Offset: 0x593610 VA: 0x180594C10
	public void RpcLogic___SetExploded_328543758(NetworkConnection conn) { }

	// RVA: 0x594C30 Offset: 0x593630 VA: 0x180594C30
	private void RpcReader___Target_SetExploded_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x594570 Offset: 0x592F70 VA: 0x180594570 Slot: 42
	public override void Awake() { }
}
