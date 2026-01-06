public class ShowFeedbackFormInputSystem : MonoBehaviour, IToggleFormInput // TypeDefIndex: 19334
{
	// Fields
	[Tooltip("Input used to toggle the feedback form")]
	public InputActionReference Toggle; // 0x20
	[Tooltip("Input used to show the feedback form")]
	public InputActionReference Show; // 0x28
	[Tooltip("Input used to hide the feedback form")]
	public InputActionReference Hide; // 0x30
	private FeedbackForm form; // 0x38

	// Properties
	public string Descriptor { get; }

	// Methods

	// RVA: 0x44AE90 Offset: 0x449890 VA: 0x18044AE90 Slot: 4
	public string get_Descriptor() { }

	// RVA: 0x44ACD0 Offset: 0x4496D0 VA: 0x18044ACD0
	private void OnEnable() { }

	// RVA: 0x44AB80 Offset: 0x449580 VA: 0x18044AB80
	private void OnDisable() { }

	// RVA: 0x44AB30 Offset: 0x449530 VA: 0x18044AB30
	private void EnableAction(InputAction action, Action<InputAction.CallbackContext> callback) { }

	// RVA: 0x44AB00 Offset: 0x449500 VA: 0x18044AB00
	private void DisableAction(InputAction action, Action<InputAction.CallbackContext> callback) { }

	// RVA: 0x44AE70 Offset: 0x449870 VA: 0x18044AE70
	private void OnToggle(InputAction.CallbackContext ctx) { }

	// RVA: 0x44AE50 Offset: 0x449850 VA: 0x18044AE50
	private void OnOpen(InputAction.CallbackContext ctx) { }

	// RVA: 0x44AB60 Offset: 0x449560 VA: 0x18044AB60
	private void OnClose(InputAction.CallbackContext ctx) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
