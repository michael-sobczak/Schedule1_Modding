public class DialogueCanvas : Singleton<DialogueCanvas> // TypeDefIndex: 2594
{
	// Fields
	public const float TIME_PER_CHAR = 0.015;
	public bool SkipNextRollout; // 0x28
	[Header("References")]
	[SerializeField]
	protected Canvas canvas; // 0x30
	public RectTransform Container; // 0x38
	[SerializeField]
	protected TextMeshProUGUI dialogueText; // 0x40
	[SerializeField]
	protected GameObject continuePopup; // 0x48
	[SerializeField]
	protected List<DialogueChoiceEntry> dialogueChoices; // 0x50
	private DialogueHandler currentHandler; // 0x58
	private DialogueNodeData currentNode; // 0x60
	private bool spaceDownThisFrame; // 0x68
	private bool leftClickThisFrame; // 0x69
	private string overrideText; // 0x70
	private Coroutine dialogueRollout; // 0x78
	private Coroutine choiceSelectionResidualCoroutine; // 0x80
	private bool hasChoiceBeenSelected; // 0x88

	// Properties
	public bool isActive { get; }

	// Methods

	// RVA: 0x8E29F0 Offset: 0x8E13F0 VA: 0x1808E29F0
	public bool get_isActive() { }

	// RVA: 0x8E13C0 Offset: 0x8DFDC0 VA: 0x1808E13C0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8E17C0 Offset: 0x8E01C0 VA: 0x1808E17C0
	public void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<DialogueChoiceData> choices) { }

	// RVA: 0x8E1F40 Offset: 0x8E0940 VA: 0x1808E1F40
	public void OverrideText(string text) { }

	// RVA: 0x8E2820 Offset: 0x8E1220 VA: 0x1808E2820
	public void StopTextOverride() { }

	// RVA: 0x8E2880 Offset: 0x8E1280 VA: 0x1808E2880
	private void Update() { }

	// RVA: 0x8E1D60 Offset: 0x8E0760 VA: 0x1808E1D60
	private void Exit(ExitAction action) { }

	[IteratorStateMachine(typeof(DialogueCanvas.<RolloutDialogue>d__21))]
	// RVA: 0x8E1FD0 Offset: 0x8E09D0 VA: 0x1808E1FD0
	protected IEnumerator RolloutDialogue(string text, List<DialogueChoiceData> choices) { }

	[IteratorStateMachine(typeof(DialogueCanvas.<ChoiceSelectionResidual>d__23))]
	// RVA: 0x8E1720 Offset: 0x8E0120 VA: 0x1808E1720
	private IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime) { }

	// RVA: 0x8E2080 Offset: 0x8E0A80 VA: 0x1808E2080
	private void StartDialogue(DialogueHandler handler) { }

	// RVA: 0x8E1910 Offset: 0x8E0310 VA: 0x1808E1910
	public void EndDialogue() { }

	// RVA: 0x8E14B0 Offset: 0x8DFEB0 VA: 0x1808E14B0
	public void ChoiceSelected(int choiceIndex) { }

	// RVA: 0x8E1E50 Offset: 0x8E0850 VA: 0x1808E1E50
	private bool IsChoiceValid(int choiceIndex, out string reason) { }

	// RVA: 0x8E2930 Offset: 0x8E1330 VA: 0x1808E2930
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8E2870 Offset: 0x8E1270 VA: 0x1808E2870
	private bool <RolloutDialogue>b__21_0() { }
}
