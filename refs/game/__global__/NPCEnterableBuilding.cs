public class NPCEnterableBuilding : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 3347
{
	// Fields
	public const float DOOR_SOUND_DISTANCE_LIMIT = 15;
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x20
	[Header("Settings")]
	public string BuildingName; // 0x30
	[SerializeField]
	protected string BakedGUID; // 0x38
	[Header("References")]
	public StaticDoor[] Doors; // 0x40
	[SerializeField]
	[Header("Readonly")]
	private List<NPC> Occupants; // 0x48

	// Properties
	public Guid GUID { get; set; }
	public int OccupantCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	protected void set_GUID(Guid value) { }

	// RVA: 0xA51440 Offset: 0xA4FE40 VA: 0x180A51440
	public int get_OccupantCount() { }

	// RVA: 0xA50650 Offset: 0xA4F050 VA: 0x180A50650 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0xA51330 Offset: 0xA4FD30 VA: 0x180A51330 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0xA50C00 Offset: 0xA4F600 VA: 0x180A50C00 Slot: 8
	public virtual void NPCEnteredBuilding(NPC npc) { }

	// RVA: 0xA50FF0 Offset: 0xA4F9F0 VA: 0x180A50FF0 Slot: 9
	public virtual void NPCExitedBuilding(NPC npc) { }

	[Button]
	// RVA: 0xA50A80 Offset: 0xA4F480 VA: 0x180A50A80
	public void GetDoors() { }

	// RVA: 0xA50AD0 Offset: 0xA4F4D0 VA: 0x180A50AD0
	public List<NPC> GetSummonableNPCs() { }

	// RVA: 0xA50920 Offset: 0xA4F320 VA: 0x180A50920
	public StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly) { }

	// RVA: 0xA51390 Offset: 0xA4FD90 VA: 0x180A51390
	public void .ctor() { }
}
