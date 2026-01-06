public class Manor : Property // TypeDefIndex: 742
{
	// Fields
	public const int REBUILD_AFTER_DAYS = 2;
	public const int REBUILD_DURATION_DAYS = 3;
	[CompilerGenerated]
	private Manor.EManorState <ManorState>k__BackingField; // 0x250
	[CompilerGenerated]
	private int <DaysSinceStateChange>k__BackingField; // 0x254
	[CompilerGenerated]
	private bool <TunnelDug>k__BackingField; // 0x258
	[Header("References")]
	public GameObject OriginalContainer; // 0x260
	public GameObject DestroyedContainer; // 0x268
	public GameObject RebuiltContainer; // 0x270
	public GameObject DestructionFXContainer; // 0x278
	public GameObject TunnelBlocker; // 0x280
	public GameObject TunnelCollapse; // 0x288
	public GameObject ConstructionContainer; // 0x290
	public AudioSourceController[] ExplosionSounds; // 0x298
	public GameObject[] DisableOnRebuild; // 0x2A0
	public Action onRebuildComplete; // 0x2A8
	private bool NetworkInitialize___EarlyScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted; // 0x2B0
	private bool NetworkInitialize__LateScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted; // 0x2B1

	// Properties
	public Manor.EManorState ManorState { get; set; }
	public int DaysSinceStateChange { get; set; }
	public bool TunnelDug { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAB3760 Offset: 0xAB2160 VA: 0x180AB3760
	public Manor.EManorState get_ManorState() { }

	[CompilerGenerated]
	// RVA: 0xAD2ED0 Offset: 0xAD18D0 VA: 0x180AD2ED0
	private void set_ManorState(Manor.EManorState value) { }

	[CompilerGenerated]
	// RVA: 0xAD2EB0 Offset: 0xAD18B0 VA: 0x180AD2EB0
	public int get_DaysSinceStateChange() { }

	[CompilerGenerated]
	// RVA: 0xAD2EC0 Offset: 0xAD18C0 VA: 0x180AD2EC0
	private void set_DaysSinceStateChange(int value) { }

	[CompilerGenerated]
	// RVA: 0x81F1F0 Offset: 0x81DBF0 VA: 0x18081F1F0
	public bool get_TunnelDug() { }

	[CompilerGenerated]
	// RVA: 0x81F980 Offset: 0x81E380 VA: 0x18081F980
	public void set_TunnelDug(bool value) { }

	// RVA: 0xAD11F0 Offset: 0xACFBF0 VA: 0x180AD11F0 Slot: 42
	public override void Awake() { }

	// RVA: 0xAD1CB0 Offset: 0xAD06B0 VA: 0x180AD1CB0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xAD2CF0 Offset: 0xAD16F0 VA: 0x180AD2CF0 Slot: 44
	protected override void Start() { }

	// RVA: 0xAD1D70 Offset: 0xAD0770 VA: 0x180AD1D70 Slot: 48
	protected override void RecieveOwned() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xAD27E0 Offset: 0xAD11E0 VA: 0x180AD27E0
	private void SetManorState(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer) { }

	[Button]
	// RVA: 0xAD12F0 Offset: 0xACFCF0 VA: 0x180AD12F0
	public void Explode() { }

	[Button]
	// RVA: 0xAD1D20 Offset: 0xAD0720 VA: 0x180AD1D20
	public void Rebuild() { }

	// RVA: 0xAD27B0 Offset: 0xAD11B0 VA: 0x180AD27B0
	public void SetDestroyedIfOriginal() { }

	// RVA: 0xAD12E0 Offset: 0xACFCE0 VA: 0x180AD12E0
	public void DigTunnel() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0xAD2A80 Offset: 0xAD1480 VA: 0x180AD2A80
	public void SetTunnelDug(NetworkConnection conn, bool dug) { }

	// RVA: 0xAD12D0 Offset: 0xACFCD0 VA: 0x180AD12D0 Slot: 50
	public override bool CanBePurchased() { }

	// RVA: 0xAD1BD0 Offset: 0xAD05D0 VA: 0x180AD1BD0
	private void OnSleepEnd() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 49
	public override bool ShouldSave() { }

	// RVA: 0xAD1570 Offset: 0xACFF70 VA: 0x180AD1570 Slot: 52
	public override string GetSaveString() { }

	// RVA: 0xAD1920 Offset: 0xAD0320 VA: 0x180AD1920 Slot: 55
	public override void Load(PropertyData propertyData, string dataString) { }

	// RVA: 0xAD2E50 Offset: 0xAD1850 VA: 0x180AD2E50
	public void .ctor() { }

	// RVA: 0xAD1A70 Offset: 0xAD0470 VA: 0x180AD1A70 Slot: 56
	public override void NetworkInitialize___Early() { }

	// RVA: 0xAD1A40 Offset: 0xAD0440 VA: 0x180AD1A40 Slot: 57
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5945C0 Offset: 0x592FC0 VA: 0x1805945C0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xAD2240 Offset: 0xAD0C40 VA: 0x180AD2240
	private void RpcWriter___Observers_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer) { }

	// RVA: 0xAD1DC0 Offset: 0xAD07C0 VA: 0x180AD1DC0
	private void RpcLogic___SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer) { }

	// RVA: 0xAD1FE0 Offset: 0xAD09E0 VA: 0x180AD1FE0
	private void RpcReader___Observers_SetManorState_365422978(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD24F0 Offset: 0xAD0EF0 VA: 0x180AD24F0
	private void RpcWriter___Target_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer) { }

	// RVA: 0xAD2110 Offset: 0xAD0B10 VA: 0x180AD2110
	private void RpcReader___Target_SetManorState_365422978(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD23B0 Offset: 0xAD0DB0 VA: 0x180AD23B0
	private void RpcWriter___Observers_SetTunnelDug_214505783(NetworkConnection conn, bool dug) { }

	// RVA: 0xAD1FA0 Offset: 0xAD09A0 VA: 0x180AD1FA0
	public void RpcLogic___SetTunnelDug_214505783(NetworkConnection conn, bool dug) { }

	// RVA: 0xAD2080 Offset: 0xAD0A80 VA: 0x180AD2080
	private void RpcReader___Observers_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD2650 Offset: 0xAD1050 VA: 0x180AD2650
	private void RpcWriter___Target_SetTunnelDug_214505783(NetworkConnection conn, bool dug) { }

	// RVA: 0xAD21B0 Offset: 0xAD0BB0 VA: 0x180AD21B0
	private void RpcReader___Target_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xAD1130 Offset: 0xACFB30 VA: 0x180AD1130 Slot: 59
	protected override void Awake_UserLogic_ScheduleOne.Property.Manor_Assembly-CSharp.dll() { }
}
