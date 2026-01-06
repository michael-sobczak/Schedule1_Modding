public class SoilPourer : GridItem // TypeDefIndex: 3283
{
	// Fields
	[CompilerGenerated]
	private string <SoilID>k__BackingField; // 0x210
	public float AnimationDuration; // 0x218
	[Header("References")]
	public InteractableObject HandleIntObj; // 0x220
	public InteractableObject FillIntObj; // 0x228
	public MeshRenderer DirtPlane; // 0x230
	public Transform Dirt_Min; // 0x238
	public Transform Dirt_Max; // 0x240
	public ParticleSystem PourParticles; // 0x248
	public Animation PourAnimation; // 0x250
	public AudioSourceController FillSound; // 0x258
	public AudioSourceController ActivateSound; // 0x260
	public AudioSourceController DirtPourSound; // 0x268
	private bool isDispensing; // 0x270
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted; // 0x271
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted; // 0x272

	// Properties
	public string SoilID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public string get_SoilID() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_SoilID(string value) { }

	// RVA: 0xA44440 Offset: 0xA42E40 VA: 0x180A44440 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xA44090 Offset: 0xA42A90 VA: 0x180A44090
	public void HandleHovered() { }

	// RVA: 0xA44130 Offset: 0xA42B30 VA: 0x180A44130
	public void HandleInteracted() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA44F70 Offset: 0xA43970 VA: 0x180A44F70
	private void SendPourSoil() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA44510 Offset: 0xA42F10 VA: 0x180A44510
	private void PourSoil() { }

	// RVA: 0xA43650 Offset: 0xA42050 VA: 0x180A43650
	public void FillHovered() { }

	// RVA: 0xA43830 Offset: 0xA42230 VA: 0x180A43830
	public void FillInteracted() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xA45080 Offset: 0xA43A80 VA: 0x180A45080
	public void SendSoil(string ID) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0xA45310 Offset: 0xA43D10 VA: 0x180A45310
	protected void SetSoil(NetworkConnection conn, string ID) { }

	// RVA: 0xA451B0 Offset: 0xA43BB0 VA: 0x180A451B0
	public void SetSoilLevel(float level) { }

	// RVA: 0xA43C70 Offset: 0xA42670 VA: 0x180A43C70 Slot: 71
	protected virtual List<Pot> GetPots() { }

	// RVA: 0xA43B70 Offset: 0xA42570 VA: 0x180A43B70 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0xA455E0 Offset: 0xA43FE0 VA: 0x180A455E0
	public void .ctor() { }

	[IteratorStateMachine(typeof(SoilPourer.<<PourSoil>g__PourRoutine|20_0>d))]
	[CompilerGenerated]
	// RVA: 0xA45570 Offset: 0xA43F70 VA: 0x180A45570
	private IEnumerator <PourSoil>g__PourRoutine|20_0() { }

	// RVA: 0xA44290 Offset: 0xA42C90 VA: 0x180A44290 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA44270 Offset: 0xA42C70 VA: 0x180A44270 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA44BD0 Offset: 0xA435D0 VA: 0x180A44BD0
	private void RpcWriter___Server_SendPourSoil_2166136261() { }

	// RVA: 0xA44510 Offset: 0xA42F10 VA: 0x180A44510
	private void RpcLogic___SendPourSoil_2166136261() { }

	// RVA: 0xA44840 Offset: 0xA43240 VA: 0x180A44840
	private void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA44970 Offset: 0xA43370 VA: 0x180A44970
	private void RpcWriter___Observers_PourSoil_2166136261() { }

	// RVA: 0xA44630 Offset: 0xA43030 VA: 0x180A44630
	private void RpcLogic___PourSoil_2166136261() { }

	// RVA: 0xA447A0 Offset: 0xA431A0 VA: 0x180A447A0
	private void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA44CE0 Offset: 0xA436E0 VA: 0x180A44CE0
	private void RpcWriter___Server_SendSoil_3615296227(string ID) { }

	// RVA: 0xA446C0 Offset: 0xA430C0 VA: 0x180A446C0
	public void RpcLogic___SendSoil_3615296227(string ID) { }

	// RVA: 0xA44890 Offset: 0xA43290 VA: 0x180A44890
	private void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA44A90 Offset: 0xA43490 VA: 0x180A44A90
	private void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID) { }

	// RVA: 0xA446D0 Offset: 0xA430D0 VA: 0x180A446D0
	protected void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID) { }

	// RVA: 0xA447E0 Offset: 0xA431E0 VA: 0x180A447E0
	private void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xA44E10 Offset: 0xA43810 VA: 0x180A44E10
	private void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID) { }

	// RVA: 0xA44910 Offset: 0xA43310 VA: 0x180A44910
	private void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }
}
