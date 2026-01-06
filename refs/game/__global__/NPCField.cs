public class NPCField : ConfigField // TypeDefIndex: 1215
{
	// Fields
	[CompilerGenerated]
	private NPC <SelectedNPC>k__BackingField; // 0x18
	public Type TypeRequirement; // 0x20
	public UnityEvent<NPC> onNPCChanged; // 0x28

	// Properties
	public NPC SelectedNPC { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public NPC get_SelectedNPC() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_SelectedNPC(NPC value) { }

	// RVA: 0x61B220 Offset: 0x619C20 VA: 0x18061B220
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x61B140 Offset: 0x619B40 VA: 0x18061B140
	public void SetNPC(NPC npc, bool network) { }

	// RVA: 0x61ADC0 Offset: 0x6197C0 VA: 0x18061ADC0
	public bool DoesNPCMatchRequirement(NPC npc) { }

	// RVA: 0x61AF60 Offset: 0x619960 VA: 0x18061AF60 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x61AE80 Offset: 0x619880 VA: 0x18061AE80
	public NPCFieldData GetData() { }

	// RVA: 0x61AFB0 Offset: 0x6199B0 VA: 0x18061AFB0
	public void Load(NPCFieldData data) { }
}
