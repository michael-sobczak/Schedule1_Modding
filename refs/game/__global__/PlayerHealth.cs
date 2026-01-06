public class PlayerHealth : NetworkBehaviour // TypeDefIndex: 1360
{
	// Fields
	public const float MAX_HEALTH = 100;
	public const float HEALTH_RECOVERY_PER_MINUTE = 0.5;
	[CompilerGenerated]
	private bool <IsAlive>k__BackingField; // 0x118
	[CompilerGenerated]
	private float <CurrentHealth>k__BackingField; // 0x11C
	[CompilerGenerated]
	private float <TimeSinceLastDamage>k__BackingField; // 0x120
	[Header("References")]
	public Player Player; // 0x128
	public UnityEvent<float> onHealthChanged; // 0x130
	public UnityEvent onDie; // 0x138
	public UnityEvent onRevive; // 0x140
	private bool AfflictedWithLethalEffect; // 0x148
	private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted; // 0x149
	private bool NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted; // 0x14A

	// Properties
	public bool IsAlive { get; set; }
	public float CurrentHealth { get; set; }
	public float TimeSinceLastDamage { get; set; }
	public bool CanTakeDamage { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsAlive() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	protected void set_IsAlive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float get_CurrentHealth() { }

	[CompilerGenerated]
	// RVA: 0x5933E0 Offset: 0x591DE0 VA: 0x1805933E0
	protected void set_CurrentHealth(float value) { }

	[CompilerGenerated]
	// RVA: 0x5AB790 Offset: 0x5AA190 VA: 0x1805AB790
	public float get_TimeSinceLastDamage() { }

	[CompilerGenerated]
	// RVA: 0x5AB7A0 Offset: 0x5AA1A0 VA: 0x1805AB7A0
	protected void set_TimeSinceLastDamage(float value) { }

	// RVA: 0x664850 Offset: 0x663250 VA: 0x180664850
	public bool get_CanTakeDamage() { }

	// RVA: 0x6624F0 Offset: 0x660EF0 VA: 0x1806624F0 Slot: 19
	public override void Awake() { }

	// RVA: 0x664460 Offset: 0x662E60 VA: 0x180664460
	private void Start() { }

	[ObserversRpc]
	// RVA: 0x663CD0 Offset: 0x6626D0 VA: 0x180663CD0
	public void TakeDamage(float damage, bool flinch = True, bool playBloodMist = True) { }

	// RVA: 0x664680 Offset: 0x663080 VA: 0x180664680
	private void Update() { }

	// RVA: 0x662720 Offset: 0x661120 VA: 0x180662720
	private void MinPass() { }

	// RVA: 0x6643B0 Offset: 0x662DB0 VA: 0x1806643B0
	public void SetAfflictedWithLethalEffect(bool value) { }

	// RVA: 0x662BA0 Offset: 0x6615A0 VA: 0x180662BA0
	public void RecoverHealth(float recovery) { }

	// RVA: 0x6643C0 Offset: 0x662DC0 VA: 0x1806643C0
	public void SetHealth(float health) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x6641F0 Offset: 0x662BF0 VA: 0x1806641F0
	public void SendDie() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x662600 Offset: 0x661000 VA: 0x180662600
	public void Die() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x664300 Offset: 0x662D00 VA: 0x180664300
	public void SendRevive(Vector3 position, Quaternion rotation) { }

	[ObserversRpc(RunLocally = True, ExcludeOwner = True)]
	// RVA: 0x662C80 Offset: 0x661680 VA: 0x180662C80
	public void Revive(Vector3 position, Quaternion rotation) { }

	[ObserversRpc]
	// RVA: 0x662A80 Offset: 0x661480 VA: 0x180662A80
	public void PlayBloodMist() { }

	// RVA: 0x664830 Offset: 0x663230 VA: 0x180664830
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x664600 Offset: 0x663000 VA: 0x180664600
	private void <Awake>b__21_0() { }

	// RVA: 0x662890 Offset: 0x661290 VA: 0x180662890 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x662870 Offset: 0x661270 VA: 0x180662870 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x663CD0 Offset: 0x6626D0 VA: 0x180663CD0
	private void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = True, bool playBloodMist = True) { }

	// RVA: 0x663110 Offset: 0x661B10 VA: 0x180663110
	public void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = True, bool playBloodMist = True) { }

	// RVA: 0x663660 Offset: 0x662060 VA: 0x180663660
	private void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x663E40 Offset: 0x662840 VA: 0x180663E40
	private void RpcWriter___Server_SendDie_2166136261() { }

	// RVA: 0x662600 Offset: 0x661000 VA: 0x180662600
	public void RpcLogic___SendDie_2166136261() { }

	// RVA: 0x663740 Offset: 0x662140 VA: 0x180663740
	private void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x6638F0 Offset: 0x6622F0 VA: 0x1806638F0
	private void RpcWriter___Observers_Die_2166136261() { }

	// RVA: 0x662D10 Offset: 0x661710 VA: 0x180662D10
	public void RpcLogic___Die_2166136261() { }

	// RVA: 0x663430 Offset: 0x661E30 VA: 0x180663430
	private void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x663F50 Offset: 0x662950 VA: 0x180663F50
	private void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation) { }

	// RVA: 0x662C80 Offset: 0x661680 VA: 0x180662C80
	public void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation) { }

	// RVA: 0x663790 Offset: 0x662190 VA: 0x180663790
	private void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x663A10 Offset: 0x662410 VA: 0x180663A10
	private void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation) { }

	// RVA: 0x662ED0 Offset: 0x6618D0 VA: 0x180662ED0
	public void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation) { }

	// RVA: 0x663540 Offset: 0x661F40 VA: 0x180663540
	private void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x662A80 Offset: 0x661480 VA: 0x180662A80
	private void RpcWriter___Observers_PlayBloodMist_2166136261() { }

	// RVA: 0x662E20 Offset: 0x661820 VA: 0x180662E20
	public void RpcLogic___PlayBloodMist_2166136261() { }

	// RVA: 0x663470 Offset: 0x661E70 VA: 0x180663470
	private void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x662400 Offset: 0x660E00 VA: 0x180662400
	private void Awake_UserLogic_ScheduleOne.PlayerScripts.Health.PlayerHealth_Assembly-CSharp.dll() { }
}
