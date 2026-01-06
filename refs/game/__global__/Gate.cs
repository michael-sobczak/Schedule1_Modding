public class Gate : NetworkBehaviour // TypeDefIndex: 3336
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x118
	public Transform Gate1; // 0x120
	public Vector3 Gate1Open; // 0x128
	public Vector3 Gate1Closed; // 0x134
	public Transform Gate2; // 0x140
	public Vector3 Gate2Open; // 0x148
	public Vector3 Gate2Closed; // 0x154
	public float OpenSpeed; // 0x160
	public float Acceleration; // 0x164
	[Header("Sound")]
	public AudioSourceController[] StartSounds; // 0x168
	public AudioSourceController[] LoopSounds; // 0x170
	public AudioSourceController[] StopSounds; // 0x178
	private float Momentum; // 0x180
	private float openDelta; // 0x184
	private bool NetworkInitialize___EarlyScheduleOne.Map.GateAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.Map.GateAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	protected void set_IsOpen(bool value) { }

	// RVA: 0xA4C2B0 Offset: 0xA4ACB0 VA: 0x180A4C2B0
	private void Update() { }

	[ObserversRpc(RunLocally = True)]
	[Button]
	// RVA: 0xA4BDC0 Offset: 0xA4A7C0 VA: 0x180A4BDC0
	public void Open() { }

	[Button]
	[ObserversRpc]
	// RVA: 0xA4BBD0 Offset: 0xA4A5D0 VA: 0x180A4BBD0
	public void Close() { }

	// RVA: 0xA4C760 Offset: 0xA4B160 VA: 0x180A4C760
	public void .ctor() { }

	// RVA: 0xA4BCF0 Offset: 0xA4A6F0 VA: 0x180A4BCF0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x66D210 Offset: 0x66BC10 VA: 0x18066D210 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA4C1A0 Offset: 0xA4ABA0 VA: 0x180A4C1A0
	private void RpcWriter___Observers_Open_2166136261() { }

	// RVA: 0xA4BFB0 Offset: 0xA4A9B0 VA: 0x180A4BFB0
	public void RpcLogic___Open_2166136261() { }

	// RVA: 0xA4C160 Offset: 0xA4AB60 VA: 0x180A4C160
	private void RpcReader___Observers_Open_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA4BBD0 Offset: 0xA4A5D0 VA: 0x180A4BBD0
	private void RpcWriter___Observers_Close_2166136261() { }

	// RVA: 0xA4BEE0 Offset: 0xA4A8E0 VA: 0x180A4BEE0
	public void RpcLogic___Close_2166136261() { }

	// RVA: 0xA4C080 Offset: 0xA4AA80 VA: 0x180A4C080
	private void RpcReader___Observers_Close_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
