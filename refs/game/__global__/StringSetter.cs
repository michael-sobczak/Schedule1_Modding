public class StringSetter : ClipboardScreen // TypeDefIndex: 2908
{
	// Fields
	[Header("References")]
	public TextMeshProUGUI TitleLabel; // 0x48
	public TMP_InputField InputField; // 0x50
	public Button DoneButton; // 0x58
	private string _existingValue; // 0x60
	private bool _allowEmpty; // 0x68
	private Action<string> _callback; // 0x70

	// Methods

	// RVA: 0x96DA80 Offset: 0x96C480 VA: 0x18096DA80
	private void Awake() { }

	// RVA: 0x96DCB0 Offset: 0x96C6B0 VA: 0x18096DCB0
	public void Initialize(string selectionTitle, string existingValue, int characterLimit, bool allowEmpty, Action<string> callback) { }

	// RVA: 0x96DDC0 Offset: 0x96C7C0 VA: 0x18096DDC0 Slot: 5
	public override void Open() { }

	// RVA: 0x96DB90 Offset: 0x96C590 VA: 0x18096DB90 Slot: 6
	public override void Close() { }

	// RVA: 0x96DC30 Offset: 0x96C630 VA: 0x18096DC30
	private void DoneButtonPressed() { }

	// RVA: 0x96DD50 Offset: 0x96C750 VA: 0x18096DD50
	private void OnSubmit(string value) { }

	// RVA: 0x96DE80 Offset: 0x96C880 VA: 0x18096DE80
	public void .ctor() { }
}
