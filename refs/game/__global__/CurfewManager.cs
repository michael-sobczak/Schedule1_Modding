public class CurfewManager : NetworkSingleton<CurfewManager> // TypeDefIndex: 1301
{
	// Fields
	private const string NORMAL_MESSAGE = "CURFEW TONIGHT\n9PM - 5AM";
	private const string CURFEW_MESSAGE = "CURFEW ACTIVE\n UNTIL 5AM";
	private const string WARNING_MESSAGE = "CURFEW SOON\n{0} MINS";
	public const int HOUR_BEFORE_CURFEW = 2000;
	public const int WARNING_TIME = 2030;
	public const int CURFEW_START_TIME = 2100;
	public const int HARD_CURFEW_START_TIME = 2115;
	public const int CURFEW_END_TIME = 500;
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsCurrentlyActive>k__BackingField; // 0x121
	[CompilerGenerated]
	private bool <IsHardCurfewActive>k__BackingField; // 0x122
	[Header("References")]
	public VMSBoard[] VMSBoards; // 0x128
	public AudioSourceController CurfewWarningSound; // 0x130
	public AudioSourceController CurfewAlarmSound; // 0x138
	public UnityEvent onCurfewEnabled; // 0x140
	public UnityEvent onCurfewDisabled; // 0x148
	public UnityEvent onCurfewHint; // 0x150
	public UnityEvent onCurfewWarning; // 0x158
	public UnityEvent onCurfewStart; // 0x160
	public UnityEvent onCurfewHardStart; // 0x168
	public UnityEvent onCurfewEnd; // 0x170
	private bool NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted; // 0x179

	// Properties
	public bool IsEnabled { get; set; }
	public bool IsCurrentlyActive { get; set; }
	public bool IsHardCurfewActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	protected void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x60EB50 Offset: 0x60D550 VA: 0x18060EB50
	public bool get_IsCurrentlyActive() { }

	[CompilerGenerated]
	// RVA: 0x60EB70 Offset: 0x60D570 VA: 0x18060EB70
	protected void set_IsCurrentlyActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x60EB60 Offset: 0x60D560 VA: 0x18060EB60
	public bool get_IsHardCurfewActive() { }

	[CompilerGenerated]
	// RVA: 0x60EB80 Offset: 0x60D580 VA: 0x18060EB80
	protected void set_IsHardCurfewActive(bool value) { }

	// RVA: 0x60D800 Offset: 0x60C200 VA: 0x18060D800 Slot: 20
	public override void Awake() { }

	// RVA: 0x60E960 Offset: 0x60D360 VA: 0x18060E960 Slot: 19
	protected override void Start() { }

	// RVA: 0x60E420 Offset: 0x60CE20 VA: 0x18060E420 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ObserversRpc]
	[TargetRpc]
	// RVA: 0x60DA00 Offset: 0x60C400 VA: 0x18060DA00
	public void Enable(NetworkConnection conn) { }

	[ObserversRpc]
	// RVA: 0x60D8E0 Offset: 0x60C2E0 VA: 0x18060D8E0
	public void Disable() { }

	// RVA: 0x60DBF0 Offset: 0x60C5F0 VA: 0x18060DBF0
	private void MinPass() { }

	// RVA: 0x60EB10 Offset: 0x60D510 VA: 0x18060EB10
	public void .ctor() { }

	// RVA: 0x60E2F0 Offset: 0x60CCF0 VA: 0x18060E2F0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x60E2A0 Offset: 0x60CCA0 VA: 0x18060E2A0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x60E720 Offset: 0x60D120 VA: 0x18060E720
	private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn) { }

	// RVA: 0x60E520 Offset: 0x60CF20 VA: 0x18060E520
	public void RpcLogic___Enable_328543758(NetworkConnection conn) { }

	// RVA: 0x60E6B0 Offset: 0x60D0B0 VA: 0x18060E6B0
	private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x60E830 Offset: 0x60D230 VA: 0x18060E830
	private void RpcWriter___Target_Enable_328543758(NetworkConnection conn) { }

	// RVA: 0x60E6E0 Offset: 0x60D0E0 VA: 0x18060E6E0
	private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x60D8E0 Offset: 0x60C2E0 VA: 0x18060D8E0
	private void RpcWriter___Observers_Disable_2166136261() { }

	// RVA: 0x60E480 Offset: 0x60CE80 VA: 0x18060E480
	public void RpcLogic___Disable_2166136261() { }

	// RVA: 0x60E600 Offset: 0x60D000 VA: 0x18060E600
	private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x60D750 Offset: 0x60C150 VA: 0x18060D750 Slot: 25
	protected override void Awake_UserLogic_ScheduleOne.Law.CurfewManager_Assembly-CSharp.dll() { }
}
