public class DeaddropQuest : Quest // TypeDefIndex: 699
{
	// Fields
	public static List<DeaddropQuest> DeaddropQuests; // 0x0
	[CompilerGenerated]
	private DeadDrop <Drop>k__BackingField; // 0x138

	// Properties
	public DeadDrop Drop { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public DeadDrop get_Drop() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	private void set_Drop(DeadDrop value) { }

	// RVA: 0xAD07B0 Offset: 0xACF1B0 VA: 0x180AD07B0 Slot: 34
	public override void Begin(bool network = True) { }

	// RVA: 0xAD0E30 Offset: 0xACF830 VA: 0x180AD0E30
	public void SetDrop(DeadDrop drop) { }

	// RVA: 0xAD0CA0 Offset: 0xACF6A0 VA: 0x180AD0CA0 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAD0D60 Offset: 0xACF760 VA: 0x180AD0D60
	private void OnDestroy() { }

	// RVA: 0xAD08F0 Offset: 0xACF2F0 VA: 0x180AD08F0 Slot: 39
	public override void End() { }

	// RVA: 0xAD0EF0 Offset: 0xACF8F0 VA: 0x180AD0EF0 Slot: 40
	public override void SetQuestState(EQuestState state, bool network = True) { }

	// RVA: 0xABCB70 Offset: 0xABB570 VA: 0x180ABCB70 Slot: 53
	public override bool ShouldSave() { }

	// RVA: 0xAD0980 Offset: 0xACF380 VA: 0x180AD0980 Slot: 54
	public override SaveData GetSaveData() { }

	// RVA: 0xAD1080 Offset: 0xACFA80 VA: 0x180AD1080
	public void .ctor() { }

	// RVA: 0xAD0FF0 Offset: 0xACF9F0 VA: 0x180AD0FF0
	private static void .cctor() { }
}
