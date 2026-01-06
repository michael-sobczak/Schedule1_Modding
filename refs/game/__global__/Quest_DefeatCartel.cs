public class Quest_DefeatCartel : Quest // TypeDefIndex: 706
{
	// Fields
	public const float DIG_TUNNEL_COST = 10000;
	[Header("References")]
	public Sam Sam; // 0x138
	public Manor Manor; // 0x140
	public QuestEntry DigTunnelEntry; // 0x148
	public QuestEntry WaitForTunnelEntry; // 0x150
	public QuestEntry EnquireAboutRDXEntry; // 0x158
	public QuestEntry ObtainRDXEntry; // 0x160
	public QuestEntry EnquireAboutBombEntry; // 0x168
	public QuestEntry KillBanditEntry; // 0x170
	public NPC Bandit; // 0x178
	public GameObject BanditScheduleContainer; // 0x180

	// Methods

	// RVA: 0xAE1E20 Offset: 0xAE0820 VA: 0x180AE1E20 Slot: 31
	protected override void Start() { }

	// RVA: 0xAE1A30 Offset: 0xAE0430 VA: 0x180AE1A30
	private void OnSleepEnd() { }

	// RVA: 0xAE1970 Offset: 0xAE0370 VA: 0x180AE1970 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAE1C00 Offset: 0xAE0600 VA: 0x180AE1C00 Slot: 42
	public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = True) { }

	// RVA: 0xAE1B70 Offset: 0xAE0570 VA: 0x180AE1B70
	public void PlayCountdownMusic() { }

	// RVA: 0xAE18E0 Offset: 0xAE02E0 VA: 0x180AE18E0
	private void Defeat() { }

	// RVA: 0xAE1CF0 Offset: 0xAE06F0 VA: 0x180AE1CF0 Slot: 40
	public override void SetQuestState(EQuestState state, bool network = True) { }

	// RVA: 0xAE1FE0 Offset: 0xAE09E0 VA: 0x180AE1FE0
	public void .ctor() { }
}
