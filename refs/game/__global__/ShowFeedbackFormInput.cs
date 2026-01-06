public class ShowFeedbackFormInput : MonoBehaviour, IToggleFormInput // TypeDefIndex: 18024
{
	// Fields
	[Tooltip("Key used to toggle the feedback form")]
	public KeyCode ToggleKey; // 0x20
	[Tooltip("Key used to hide the feedback form")]
	public KeyCode ShowKey; // 0x24
	[Tooltip("Key used to hide the feedback form")]
	public KeyCode HideKey; // 0x28
	private FeedbackForm form; // 0x30

	// Properties
	public string Descriptor { get; }

	// Methods

	// RVA: 0x442450 Offset: 0x440E50 VA: 0x180442450 Slot: 4
	public string get_Descriptor() { }

	// RVA: 0x442330 Offset: 0x440D30 VA: 0x180442330
	private void Start() { }

	// RVA: 0x442380 Offset: 0x440D80 VA: 0x180442380
	private void Update() { }

	// RVA: 0x442430 Offset: 0x440E30 VA: 0x180442430
	public void .ctor() { }
}
