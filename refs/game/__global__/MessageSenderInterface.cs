public class MessageSenderInterface : MonoBehaviour // TypeDefIndex: 2845
{
	// Fields
	public MessageSenderInterface.EVisibility Visibility; // 0x20
	[Header("Settings")]
	public float DockedMenuYPos; // 0x24
	public float ExpandedMenuYPos; // 0x28
	[Header("References")]
	public RectTransform Menu; // 0x30
	public RectTransform SendablesContainer; // 0x38
	public RectTransform[] DockedUIElements; // 0x40
	public RectTransform[] ExpandedUIElements; // 0x48
	public Button ComposeButton; // 0x50
	public Button[] CancelButtons; // 0x58
	private List<MessageBubble> sendableBubbles; // 0x60
	private Dictionary<MessageBubble, SendableMessage> sendableMap; // 0x68

	// Methods

	// RVA: 0x94D130 Offset: 0x94BB30 VA: 0x18094D130
	public void Awake() { }

	// RVA: 0x94D540 Offset: 0x94BF40 VA: 0x18094D540
	public void Start() { }

	// RVA: 0x94D280 Offset: 0x94BC80 VA: 0x18094D280
	private void Exit(ExitAction exit) { }

	// RVA: 0x94D320 Offset: 0x94BD20 VA: 0x18094D320
	public void SetVisibility(MessageSenderInterface.EVisibility visibility) { }

	// RVA: 0x94D600 Offset: 0x94C000 VA: 0x18094D600
	public void UpdateSendables() { }

	// RVA: 0x94CE80 Offset: 0x94B880 VA: 0x18094CE80
	public void AddSendable(SendableMessage sendable) { }

	// RVA: 0x94D2D0 Offset: 0x94BCD0 VA: 0x18094D2D0 Slot: 4
	protected virtual void SendableSelected(SendableMessage sendable) { }

	// RVA: 0x94D7E0 Offset: 0x94C1E0 VA: 0x18094D7E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x94D5E0 Offset: 0x94BFE0 VA: 0x18094D5E0
	private void <Awake>b__12_0() { }

	[CompilerGenerated]
	// RVA: 0x94D5F0 Offset: 0x94BFF0 VA: 0x18094D5F0
	private void <Awake>b__12_1() { }
}
