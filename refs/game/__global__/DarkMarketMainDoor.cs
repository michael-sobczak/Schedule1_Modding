public class DarkMarketMainDoor : MonoBehaviour // TypeDefIndex: 3329
{
	// Fields
	[CompilerGenerated]
	private bool <KnockingEnabled>k__BackingField; // 0x20
	public AudioSource KnockSound; // 0x28
	public InteractableObject InteractableObject; // 0x30
	public Peephole Peephole; // 0x38
	public Igor Igor; // 0x40
	public DialogueContainer FailDialogue; // 0x48
	public DialogueContainer SuccessDialogue; // 0x50
	public DialogueContainer SuccessDialogueNotOpen; // 0x58
	private Coroutine knockRoutine; // 0x60

	// Properties
	public bool KnockingEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_KnockingEnabled() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_KnockingEnabled(bool value) { }

	// RVA: 0x8E72B0 Offset: 0x8E5CB0 VA: 0x1808E72B0
	private void Start() { }

	// RVA: 0xA492D0 Offset: 0xA47CD0 VA: 0x180A492D0
	public void SetKnockingEnabled(bool enabled) { }

	// RVA: 0xA49160 Offset: 0xA47B60 VA: 0x180A49160
	public void Hovered() { }

	// RVA: 0xA49240 Offset: 0xA47C40 VA: 0x180A49240
	public void Interacted() { }

	// RVA: 0xA49240 Offset: 0xA47C40 VA: 0x180A49240
	private void Knocked() { }

	// RVA: 0x567D00 Offset: 0x566700 VA: 0x180567D00
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(DarkMarketMainDoor.<<Knocked>g__Knock|16_0>d))]
	// RVA: 0xA49350 Offset: 0xA47D50 VA: 0x180A49350
	private IEnumerator <Knocked>g__Knock|16_0() { }

	[CompilerGenerated]
	// RVA: 0xA49320 Offset: 0xA47D20 VA: 0x180A49320
	private bool <Knocked>b__16_1() { }
}
