public class ConversationLocation : MonoBehaviour // TypeDefIndex: 1870
{
	// Fields
	public Transform[] StandPoints; // 0x20
	[HideInInspector]
	public List<NPC> NPCs; // 0x28
	private Dictionary<NPC, bool> npcReady; // 0x30

	// Properties
	public bool NPCsReady { get; }

	// Methods

	// RVA: 0x77AB20 Offset: 0x779520 VA: 0x18077AB20
	public bool get_NPCsReady() { }

	// RVA: 0x77A570 Offset: 0x778F70 VA: 0x18077A570
	public void Awake() { }

	// RVA: 0x77A870 Offset: 0x779270 VA: 0x18077A870
	public Transform GetStandPoint(NPC npc) { }

	// RVA: 0x77A980 Offset: 0x779380 VA: 0x18077A980
	public void SetNPCReady(NPC npc, bool ready) { }

	// RVA: 0x77A700 Offset: 0x779100 VA: 0x18077A700
	public NPC GetOtherNPC(NPC npc) { }

	// RVA: 0x77AA60 Offset: 0x779460 VA: 0x18077AA60
	public void .ctor() { }
}
