public class PollPanel : MonoBehaviour // TypeDefIndex: 2782
{
	// Fields
	public const float BUTTON_PRESS_TIME = 0.8;
	public const string ResponseSubmittedMessage = "Your vote has been recorded.\n Thank you!";
	public GameObject ButtonPrefab; // 0x20
	public Color TextColor_Green; // 0x28
	public Color TextColor_Red; // 0x38
	[Header("References")]
	public PollManager PollManager; // 0x48
	public GameObject Container; // 0x50
	public GameObject ActivePill; // 0x58
	public GameObject ClosedPill; // 0x60
	public TextMeshProUGUI QuestionLabel; // 0x68
	public RectTransform ButtonContainer; // 0x70
	public TextMeshProUGUI InstructionLabel; // 0x78
	public TextMeshProUGUI ConfirmationMessageLabel; // 0x80
	public AudioSourceController SubmissionStartSound; // 0x88
	public AudioSourceController SubmissionSuccessSound; // 0x90
	public AudioSourceController SubmissionFailSound; // 0x98
	private List<Button> buttons; // 0xA0
	private List<Image> buttonFills; // 0xA8
	private int heldButton; // 0xB0
	private int selectedButton; // 0xB4
	private int lastHeldButton; // 0xB8
	private float buttonPressTime; // 0xBC

	// Methods

	// RVA: 0x9347B0 Offset: 0x9331B0 VA: 0x1809347B0
	private void Awake() { }

	// RVA: 0x935FC0 Offset: 0x9349C0 VA: 0x180935FC0
	private void Update() { }

	// RVA: 0x934EB0 Offset: 0x9338B0 VA: 0x180934EB0
	public void DisplayActivePoll(PollData poll) { }

	// RVA: 0x935250 Offset: 0x933C50 VA: 0x180935250
	public void DisplayConfirmedPoll(PollData poll) { }

	// RVA: 0x935720 Offset: 0x934120 VA: 0x180935720
	private void DisplaySubmittedAnswer(int buttonIndex) { }

	// RVA: 0x935DC0 Offset: 0x9347C0 VA: 0x180935DC0
	private void Rebuild() { }

	// RVA: 0x934B30 Offset: 0x933530 VA: 0x180934B30
	private List<Button> CreateButtons(PollData data) { }

	// RVA: 0x9349A0 Offset: 0x9333A0 VA: 0x1809349A0
	private void ButtonPressed(int buttonIndex) { }

	// RVA: 0x935AF0 Offset: 0x9344F0 VA: 0x180935AF0
	private void FinalizeButtonPress(int buttonIndex) { }

	// RVA: 0x9361C0 Offset: 0x934BC0 VA: 0x1809361C0
	public void .ctor() { }
}
