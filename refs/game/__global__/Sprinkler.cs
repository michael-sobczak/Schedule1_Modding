public class Sprinkler : GridItem // TypeDefIndex: 3280
{
	// Fields
	[CompilerGenerated]
	private bool <IsSprinkling>k__BackingField; // 0x210
	[Header("References")]
	public InteractableObject IntObj; // 0x218
	public ParticleSystem[] WaterParticles; // 0x220
	public AudioSourceController ClickSound; // 0x228
	public AudioSourceController WaterSound; // 0x230
	[Header("Settings")]
	public float ApplyWaterDelay; // 0x238
	public float ParticleStopDelay; // 0x23C
	public UnityEvent onSprinklerStart; // 0x240
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted; // 0x248
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted; // 0x249

	// Properties
	public bool IsSprinkling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x68F9C0 Offset: 0x68E3C0 VA: 0x18068F9C0
	public bool get_IsSprinkling() { }

	[CompilerGenerated]
	// RVA: 0x68F9D0 Offset: 0x68E3D0 VA: 0x18068F9D0
	private void set_IsSprinkling(bool value) { }

	// RVA: 0xA45B90 Offset: 0xA44590 VA: 0x180A45B90
	public void Hovered() { }

	// RVA: 0xA45C20 Offset: 0xA44620 VA: 0x180A45C20
	public void Interacted() { }

	// RVA: 0xA45760 Offset: 0xA44160 VA: 0x180A45760
	private bool CanWater() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA462F0 Offset: 0xA44CF0 VA: 0x180A462F0
	private void SendWater() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA45E60 Offset: 0xA44860 VA: 0x180A45E60
	private void Water() { }

	// RVA: 0xA45650 Offset: 0xA44050 VA: 0x180A45650
	public void AddWater(float normalizedAmount) { }

	// RVA: 0xA45770 Offset: 0xA44170 VA: 0x180A45770 Slot: 71
	protected virtual List<Pot> GetPots() { }

	// RVA: 0xA46470 Offset: 0xA44E70 VA: 0x180A46470
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Sprinkler.<<Water>g__Routine|15_0>d))]
	// RVA: 0xA46400 Offset: 0xA44E00 VA: 0x180A46400
	private IEnumerator <Water>g__Routine|15_0() { }

	// RVA: 0xA45D70 Offset: 0xA44770 VA: 0x180A45D70 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA45D50 Offset: 0xA44750 VA: 0x180A45D50 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA461E0 Offset: 0xA44BE0 VA: 0x180A461E0
	private void RpcWriter___Server_SendWater_2166136261() { }

	// RVA: 0xA45E60 Offset: 0xA44860 VA: 0x180A45E60
	private void RpcLogic___SendWater_2166136261() { }

	// RVA: 0xA46070 Offset: 0xA44A70 VA: 0x180A46070
	private void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA460C0 Offset: 0xA44AC0 VA: 0x180A460C0
	private void RpcWriter___Observers_Water_2166136261() { }

	// RVA: 0xA45F80 Offset: 0xA44980 VA: 0x180A45F80
	private void RpcLogic___Water_2166136261() { }

	// RVA: 0xA46030 Offset: 0xA44A30 VA: 0x180A46030
	private void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }
}
