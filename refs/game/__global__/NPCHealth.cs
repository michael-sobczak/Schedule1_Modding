public class NPCHealth : NetworkBehaviour // TypeDefIndex: 1639
{
	// Fields
	public const int REVIVE_DAYS = 3;
	[SyncVar(WritePermissions = 1, Channel = 1)]
	[CompilerGenerated]
	public float <Health>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0x11C
	[CompilerGenerated]
	private bool <IsKnockedOut>k__BackingField; // 0x11D
	[CompilerGenerated]
	private int <DaysPassedSinceDeath>k__BackingField; // 0x120
	[CompilerGenerated]
	private int <HoursSinceAttackedByPlayer>k__BackingField; // 0x124
	[Header("Settings")]
	public bool Invincible; // 0x128
	public float MaxHealth; // 0x12C
	public bool CanRevive; // 0x130
	private NPC npc; // 0x138
	public UnityEvent onDie; // 0x140
	public UnityEvent onKnockedOut; // 0x148
	public UnityEvent onDieOrKnockedOut; // 0x150
	public UnityEvent onRevive; // 0x158
	public Action<float> onTakeDamage; // 0x160
	private bool AfflictedWithLethalEffect; // 0x168
	public SyncVar<float> syncVar___<Health>k__BackingField; // 0x170
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted; // 0x179

	// Properties
	public float Health { get; set; }
	public float NormalizedHealth { get; }
	public bool IsDead { get; set; }
	public bool IsKnockedOut { get; set; }
	public int DaysPassedSinceDeath { get; set; }
	public int HoursSinceAttackedByPlayer { get; set; }
	public float SyncAccessor_<Health>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5933D0 Offset: 0x591DD0 VA: 0x1805933D0
	public float get_Health() { }

	[CompilerGenerated]
	// RVA: 0x704940 Offset: 0x703340 VA: 0x180704940
	private void set_Health(float value) { }

	// RVA: 0x704920 Offset: 0x703320 VA: 0x180704920
	public float get_NormalizedHealth() { }

	[CompilerGenerated]
	// RVA: 0x5232C0 Offset: 0x521CC0 VA: 0x1805232C0
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x7049E0 Offset: 0x7033E0 VA: 0x1807049E0
	private void set_IsDead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x523380 Offset: 0x521D80 VA: 0x180523380
	public bool get_IsKnockedOut() { }

	[CompilerGenerated]
	// RVA: 0x7049F0 Offset: 0x7033F0 VA: 0x1807049F0
	private void set_IsKnockedOut(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public int get_DaysPassedSinceDeath() { }

	[CompilerGenerated]
	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	private void set_DaysPassedSinceDeath(int value) { }

	[CompilerGenerated]
	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	public int get_HoursSinceAttackedByPlayer() { }

	[CompilerGenerated]
	// RVA: 0x7049D0 Offset: 0x7033D0 VA: 0x1807049D0
	private void set_HoursSinceAttackedByPlayer(int value) { }

	// RVA: 0x703A30 Offset: 0x702430 VA: 0x180703A30 Slot: 19
	public override void Awake() { }

	// RVA: 0x704570 Offset: 0x702F70 VA: 0x180704570
	private void Start() { }

	// RVA: 0x703FD0 Offset: 0x7029D0 VA: 0x180703FD0
	private void OnDestroy() { }

	// RVA: 0x704150 Offset: 0x702B50 VA: 0x180704150 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x703D20 Offset: 0x702720 VA: 0x180703D20
	public void Load(NPCHealthData healthData) { }

	[IteratorStateMachine(typeof(NPCHealth.<AfflictWithLethalEffect>d__38))]
	// RVA: 0x703650 Offset: 0x702050 VA: 0x180703650
	private IEnumerator AfflictWithLethalEffect() { }

	// RVA: 0x704140 Offset: 0x702B40 VA: 0x180704140 Slot: 20
	protected virtual void OnHourPass() { }

	// RVA: 0x704430 Offset: 0x702E30 VA: 0x180704430
	public void SetAfflictedWithLethalEffect(bool value) { }

	// RVA: 0x7044B0 Offset: 0x702EB0 VA: 0x1807044B0
	public void SleepStart() { }

	// RVA: 0x703FC0 Offset: 0x7029C0 VA: 0x180703FC0 Slot: 21
	public virtual void NotifyAttackedByPlayer(Player player) { }

	// RVA: 0x7047C0 Offset: 0x7031C0 VA: 0x1807047C0
	public void TakeDamage(float damage, bool isLethal = True) { }

	// RVA: 0x703A80 Offset: 0x702480 VA: 0x180703A80 Slot: 22
	public virtual void Die() { }

	// RVA: 0x703BD0 Offset: 0x7025D0 VA: 0x180703BD0 Slot: 23
	public virtual void KnockOut() { }

	// RVA: 0x7042D0 Offset: 0x702CD0 VA: 0x1807042D0 Slot: 24
	public virtual void Revive() { }

	// RVA: 0x7042C0 Offset: 0x702CC0 VA: 0x1807042C0
	public void RestoreHealth() { }

	// RVA: 0x7048E0 Offset: 0x7032E0 VA: 0x1807048E0
	public void .ctor() { }

	// RVA: 0x703E60 Offset: 0x702860 VA: 0x180703E60 Slot: 25
	public override void NetworkInitialize___Early() { }

	// RVA: 0x703E10 Offset: 0x702810 VA: 0x180703E10 Slot: 26
	public override void NetworkInitialize__Late() { }

	// RVA: 0x703DD0 Offset: 0x7027D0 VA: 0x180703DD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5933D0 Offset: 0x591DD0 VA: 0x1805933D0
	public float sync___get_value_<Health>k__BackingField() { }

	// RVA: 0x704A00 Offset: 0x703400 VA: 0x180704A00
	public void sync___set_value_<Health>k__BackingField(float value, bool asServer) { }

	// RVA: 0x704180 Offset: 0x702B80 VA: 0x180704180 Slot: 27
	public override bool ReadSyncVar___ScheduleOne.NPCs.NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x7036C0 Offset: 0x7020C0 VA: 0x1807036C0 Slot: 28
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCHealth_Assembly-CSharp.dll() { }
}
