public class ConfirmationPopup : MonoBehaviour // TypeDefIndex: 2833
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("References")]
	public GameObject Container; // 0x28
	public Text TitleLabel; // 0x30
	public Text MessageLabel; // 0x38
	public Button ConfirmButton; // 0x40
	public Button CancelButton; // 0x48
	private MSGConversation conversation; // 0x50
	private Action<ConfirmationPopup.EResponse> responseCallback; // 0x58

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x9403F0 Offset: 0x93EDF0 VA: 0x1809403F0
	private void Start() { }

	// RVA: 0x9401F0 Offset: 0x93EBF0 VA: 0x1809401F0
	public void Exit(ExitAction action) { }

	// RVA: 0x940240 Offset: 0x93EC40 VA: 0x180940240
	public void Open(string title, string message, MSGConversation conv, Action<ConfirmationPopup.EResponse> callback) { }

	// RVA: 0x940070 Offset: 0x93EA70 VA: 0x180940070
	public void Close(ConfirmationPopup.EResponse outcome) { }

	// RVA: 0x9401E0 Offset: 0x93EBE0 VA: 0x1809401E0
	private void Confirm() { }

	// RVA: 0x940060 Offset: 0x93EA60 VA: 0x180940060
	private void Cancel() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
