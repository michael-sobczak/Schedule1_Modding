public class TextInputScreen : Singleton<TextInputScreen> // TypeDefIndex: 2714
{
	// Fields
	public Canvas Canvas; // 0x28
	public TextMeshProUGUI HeaderLabel; // 0x30
	public TMP_InputField InputField; // 0x38
	private TextInputScreen.OnSubmit onSubmit; // 0x40

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x8F9340 Offset: 0x8F7D40 VA: 0x1808F9340
	public bool get_IsOpen() { }

	// RVA: 0x91A790 Offset: 0x919190 VA: 0x18091A790 Slot: 5
	protected override void Awake() { }

	// RVA: 0x91ADD0 Offset: 0x9197D0 VA: 0x18091ADD0
	public void Submit() { }

	// RVA: 0x91A840 Offset: 0x919240 VA: 0x18091A840
	public void Cancel() { }

	// RVA: 0x91ADE0 Offset: 0x9197E0 VA: 0x18091ADE0
	private void Update() { }

	// RVA: 0x91AAC0 Offset: 0x9194C0 VA: 0x18091AAC0
	public void Exit(ExitAction action) { }

	// RVA: 0x91AB20 Offset: 0x919520 VA: 0x18091AB20
	public void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000) { }

	// RVA: 0x91A850 Offset: 0x919250 VA: 0x18091A850
	private void Close(bool submit) { }

	// RVA: 0x91AE30 Offset: 0x919830 VA: 0x18091AE30
	public void .ctor() { }
}
