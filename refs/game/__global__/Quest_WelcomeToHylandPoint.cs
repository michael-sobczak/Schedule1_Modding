public class Quest_WelcomeToHylandPoint : Quest // TypeDefIndex: 727
{
	// Fields
	public QuestEntry ReturnToRVQuest; // 0x138
	public QuestEntry ReadMessagesQuest; // 0x140
	public RV RV; // 0x148
	public UncleNelson Nelson; // 0x150
	[Header("Settings")]
	public float ExplosionMaxDist; // 0x158
	public float ExplosionMinDist; // 0x15C
	public UnityEvent onExplode; // 0x160
	private bool exploded; // 0x168
	private float cameraLookTime; // 0x16C

	// Methods

	// RVA: 0xAE5DB0 Offset: 0xAE47B0 VA: 0x180AE5DB0 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAE6020 Offset: 0xAE4A20 VA: 0x180AE6020
	private void Update() { }

	[Button]
	// RVA: 0xAE5CE0 Offset: 0xAE46E0 VA: 0x180AE5CE0
	public void Explode() { }

	// RVA: 0xAE5E30 Offset: 0xAE4830 VA: 0x180AE5E30 Slot: 40
	public override void SetQuestState(EQuestState state, bool network = True) { }

	// RVA: 0xAE6290 Offset: 0xAE4C90 VA: 0x180AE6290
	public void .ctor() { }

	[IteratorStateMachine(typeof(Quest_WelcomeToHylandPoint.<<Explode>g__Shake|11_0>d))]
	[CompilerGenerated]
	// RVA: 0xAE5FD0 Offset: 0xAE49D0 VA: 0x180AE5FD0
	internal static IEnumerator <Explode>g__Shake|11_0() { }
}
