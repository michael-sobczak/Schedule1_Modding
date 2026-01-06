public class PhysicsManager : NetworkSingleton<PhysicsManager> // TypeDefIndex: 839
{
	// Fields
	public const bool AUTO_SYNC_TRANSFORMS = True;
	[CompilerGenerated]
	private float <GravityMultiplier>k__BackingField; // 0x120
	private bool NetworkInitialize___EarlyScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted; // 0x124
	private bool NetworkInitialize__LateScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted; // 0x125

	// Properties
	public float GravityMultiplier { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5AB790 Offset: 0x5AA190 VA: 0x1805AB790
	public float get_GravityMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x5AB7A0 Offset: 0x5AA1A0 VA: 0x1805AB7A0
	private void set_GravityMultiplier(float value) { }

	// RVA: 0x5AADA0 Offset: 0x5A97A0 VA: 0x1805AADA0 Slot: 20
	public override void Awake() { }

	// RVA: 0x5AB000 Offset: 0x5A9A00 VA: 0x1805AB000 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x5AB4D0 Offset: 0x5A9ED0 VA: 0x1805AB4D0
	public void SetGravityMultiplier(NetworkConnection conn, float gravity) { }

	// RVA: 0x5AB740 Offset: 0x5AA140 VA: 0x1805AB740
	public void .ctor() { }

	// RVA: 0x5AAF10 Offset: 0x5A9910 VA: 0x1805AAF10 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5AAEC0 Offset: 0x5A98C0 VA: 0x1805AAEC0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5AB230 Offset: 0x5A9C30 VA: 0x1805AB230
	private void RpcWriter___Observers_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity) { }

	// RVA: 0x5AB060 Offset: 0x5A9A60 VA: 0x1805AB060
	public void RpcLogic___SetGravityMultiplier_530160725(NetworkConnection conn, float gravity) { }

	// RVA: 0x5AB160 Offset: 0x5A9B60 VA: 0x1805AB160
	private void RpcReader___Observers_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5AB370 Offset: 0x5A9D70 VA: 0x1805AB370
	private void RpcWriter___Target_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity) { }

	// RVA: 0x5AB1D0 Offset: 0x5A9BD0 VA: 0x1805AB1D0
	private void RpcReader___Target_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5AACB0 Offset: 0x5A96B0 VA: 0x1805AACB0 Slot: 25
	protected override void Awake_UserLogic_ScheduleOne.GamePhysics.PhysicsManager_Assembly-CSharp.dll() { }
}
