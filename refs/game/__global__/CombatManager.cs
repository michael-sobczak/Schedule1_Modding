public class CombatManager : NetworkSingleton<CombatManager> // TypeDefIndex: 1981
{
	// Fields
	public LayerMask MeleeLayerMask; // 0x120
	public LayerMask ExplosionLayerMask; // 0x124
	public LayerMask RangedWeaponLayerMask; // 0x128
	public Explosion ExplosionPrefab; // 0x130
	private List<int> explosionIDs; // 0x138
	private bool NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted; // 0x141

	// Methods

	[Button]
	// RVA: 0x796760 Offset: 0x795160 VA: 0x180796760
	public void CreateTestExplosion() { }

	// RVA: 0x7964D0 Offset: 0x794ED0 VA: 0x1807964D0
	public void CreateExplosion(Vector3 origin, ExplosionData data) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x796550 Offset: 0x794F50 VA: 0x180796550
	private void CreateExplosion(Vector3 origin, ExplosionData data, int id) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x796A60 Offset: 0x795460 VA: 0x180796A60
	private void Explosion(Vector3 origin, ExplosionData data, int id) { }

	// RVA: 0x7975C0 Offset: 0x795FC0 VA: 0x1807975C0
	public void .ctor() { }

	// RVA: 0x796CE0 Offset: 0x7956E0 VA: 0x180796CE0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x796C90 Offset: 0x795690 VA: 0x180796C90 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x797400 Offset: 0x795E00 VA: 0x180797400
	private void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id) { }

	// RVA: 0x796DE0 Offset: 0x7957E0 VA: 0x180796DE0
	private void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id) { }

	// RVA: 0x797100 Offset: 0x795B00 VA: 0x180797100
	private void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x797220 Offset: 0x795C20 VA: 0x180797220
	private void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id) { }

	// RVA: 0x796E30 Offset: 0x795830 VA: 0x180796E30
	private void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id) { }

	// RVA: 0x796FC0 Offset: 0x7959C0 VA: 0x180796FC0
	private void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x796460 Offset: 0x794E60 VA: 0x180796460 Slot: 20
	public override void Awake() { }
}
