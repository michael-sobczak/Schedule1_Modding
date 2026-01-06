public class CartelInfluence : NetworkBehaviour // TypeDefIndex: 2089
{
	// Fields
	public const float INFLUENCE_TO_UNLOCK_NEXT_REGION = 0.3;
	public const float WESTVILLE_MAX_INFLUENCE = 0.5;
	[Header("Settings")]
	public CartelInfluence.RegionInfluenceData[] DefaultRegionInfluence; // 0x118
	private List<CartelInfluence.RegionInfluenceData> regionInfluence; // 0x120
	public Action<EMapRegion, float, float> OnInfluenceChanged; // 0x128
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted; // 0x130
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted; // 0x131

	// Methods

	// RVA: 0x806200 Offset: 0x804C00 VA: 0x180806200
	public CartelInfluence.RegionInfluenceData[] GetAllRegionInfluence() { }

	// RVA: 0x805DE0 Offset: 0x8047E0 VA: 0x180805DE0 Slot: 19
	public override void Awake() { }

	// RVA: 0x8064B0 Offset: 0x804EB0 VA: 0x1808064B0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x806610 Offset: 0x805010 VA: 0x180806610 Slot: 16
	protected override void OnValidate() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x8060A0 Offset: 0x804AA0 VA: 0x1808060A0
	public void ChangeInfluence(EMapRegion region, float amount) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x807550 Offset: 0x805F50 VA: 0x180807550
	public void SetInfluence(NetworkConnection conn, EMapRegion region, float influence) { }

	// RVA: 0x806250 Offset: 0x804C50 VA: 0x180806250
	public float GetInfluence(EMapRegion region) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x805F00 Offset: 0x804900 VA: 0x180805F00
	private void ChangeInfluence(EMapRegion region, float oldInfluence, float newInfluence) { }

	// RVA: 0x806280 Offset: 0x804C80 VA: 0x180806280
	private CartelInfluence.RegionInfluenceData GetRegionData(EMapRegion region) { }

	// RVA: 0x807800 Offset: 0x806200 VA: 0x180807800
	public void .ctor() { }

	// RVA: 0x806350 Offset: 0x804D50 VA: 0x180806350 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x702660 Offset: 0x701060 VA: 0x180702660 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x8060A0 Offset: 0x804AA0 VA: 0x1808060A0
	private void RpcWriter___Server_ChangeInfluence_2792544924(EMapRegion region, float amount) { }

	// RVA: 0x806C10 Offset: 0x805610 VA: 0x180806C10
	public void RpcLogic___ChangeInfluence_2792544924(EMapRegion region, float amount) { }

	// RVA: 0x807010 Offset: 0x805A10 VA: 0x180807010
	private void RpcReader___Server_ChangeInfluence_2792544924(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x807280 Offset: 0x805C80 VA: 0x180807280
	private void RpcWriter___Observers_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence) { }

	// RVA: 0x806DE0 Offset: 0x8057E0 VA: 0x180806DE0
	public void RpcLogic___SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence) { }

	// RVA: 0x806F80 Offset: 0x805980 VA: 0x180806F80
	private void RpcReader___Observers_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8073F0 Offset: 0x805DF0 VA: 0x1808073F0
	private void RpcWriter___Target_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence) { }

	// RVA: 0x807080 Offset: 0x805A80 VA: 0x180807080
	private void RpcReader___Target_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x807100 Offset: 0x805B00 VA: 0x180807100
	private void RpcWriter___Observers_ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence) { }

	// RVA: 0x8069F0 Offset: 0x8053F0 VA: 0x1808069F0
	private void RpcLogic___ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence) { }

	// RVA: 0x806EE0 Offset: 0x8058E0 VA: 0x180806EE0
	private void RpcReader___Observers_ChangeInfluence_1267088319(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x805CF0 Offset: 0x8046F0 VA: 0x180805CF0
	private void Awake_UserLogic_ScheduleOne.Cartel.CartelInfluence_Assembly-CSharp.dll() { }
}
