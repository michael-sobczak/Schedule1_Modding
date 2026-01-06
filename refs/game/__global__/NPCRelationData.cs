public class NPCRelationData // TypeDefIndex: 1679
{
	// Fields
	public const float MinDelta = 0;
	public const float MaxDelta = 5;
	public const float DEFAULT_RELATION_DELTA = 2;
	[CompilerGenerated]
	private float <RelationDelta>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Unlocked>k__BackingField; // 0x14
	[CompilerGenerated]
	private NPCRelationData.EUnlockType <UnlockType>k__BackingField; // 0x18
	[CompilerGenerated]
	private NPC <NPC>k__BackingField; // 0x20
	[SerializeField]
	protected List<NPC> FullGameConnections; // 0x28
	[SerializeField]
	protected List<NPC> DemoConnections; // 0x30
	public Action<float> onRelationshipChange; // 0x38
	public Action<NPCRelationData.EUnlockType, bool> onUnlocked; // 0x40

	// Properties
	public float RelationDelta { get; set; }
	public float NormalizedRelationDelta { get; }
	public bool Unlocked { get; set; }
	public NPCRelationData.EUnlockType UnlockType { get; set; }
	public NPC NPC { get; set; }
	public List<NPC> Connections { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_RelationDelta() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	protected void set_RelationDelta(float value) { }

	// RVA: 0x7273A0 Offset: 0x725DA0 VA: 0x1807273A0
	public float get_NormalizedRelationDelta() { }

	[CompilerGenerated]
	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_Unlocked() { }

	[CompilerGenerated]
	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	protected void set_Unlocked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public NPCRelationData.EUnlockType get_UnlockType() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	protected void set_UnlockType(NPCRelationData.EUnlockType value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public NPC get_NPC() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_NPC(NPC value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<NPC> get_Connections() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void SetNPC(NPC npc) { }

	// RVA: 0x726D90 Offset: 0x725790 VA: 0x180726D90
	public void Init(NPC npc) { }

	// RVA: 0x7268A0 Offset: 0x7252A0 VA: 0x1807268A0 Slot: 4
	public virtual void ChangeRelationship(float deltaChange, bool network = True) { }

	// RVA: 0x727170 Offset: 0x725B70 VA: 0x180727170 Slot: 5
	public virtual void SetRelationship(float newDelta) { }

	// RVA: 0x7272C0 Offset: 0x725CC0 VA: 0x1807272C0 Slot: 6
	public virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = True) { }

	// RVA: 0x7271D0 Offset: 0x725BD0 VA: 0x1807271D0 Slot: 7
	public virtual void UnlockConnections() { }

	// RVA: 0x726D00 Offset: 0x725700 VA: 0x180726D00
	public RelationshipData GetSaveData() { }

	// RVA: 0x726940 Offset: 0x725340 VA: 0x180726940
	public float GetAverageMutualRelationship() { }

	// RVA: 0x726F40 Offset: 0x725940 VA: 0x180726F40
	public bool IsKnown() { }

	// RVA: 0x727060 Offset: 0x725A60 VA: 0x180727060
	public bool IsMutuallyKnown() { }

	// RVA: 0x726A40 Offset: 0x725440 VA: 0x180726A40
	public List<NPC> GetLockedConnections(bool excludeCustomers = False) { }

	// RVA: 0x726B10 Offset: 0x725510 VA: 0x180726B10
	public List<NPC> GetLockedDealers(bool excludeRecommended) { }

	// RVA: 0x726BE0 Offset: 0x7255E0 VA: 0x180726BE0
	public List<NPC> GetLockedSuppliers() { }

	// RVA: 0x7272F0 Offset: 0x725CF0 VA: 0x1807272F0
	public void .ctor() { }
}
