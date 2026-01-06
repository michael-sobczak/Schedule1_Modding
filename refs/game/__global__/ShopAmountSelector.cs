public class ShopAmountSelector : MonoBehaviour // TypeDefIndex: 3002
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SelectedAmount>k__BackingField; // 0x24
	[Header("References")]
	public RectTransform Container; // 0x28
	public TMP_InputField InputField; // 0x30
	public UnityEvent<int> onSubmitted; // 0x38

	// Properties
	public bool IsOpen { get; set; }
	public int SelectedAmount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_SelectedAmount() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	private void set_SelectedAmount(int value) { }

	// RVA: 0x981C80 Offset: 0x980680 VA: 0x180981C80
	private void Awake() { }

	// RVA: 0x982010 Offset: 0x980A10 VA: 0x180982010
	public void Open() { }

	// RVA: 0x981DB0 Offset: 0x9807B0 VA: 0x180981DB0
	public void Close() { }

	// RVA: 0x981DF0 Offset: 0x9807F0 VA: 0x180981DF0
	private void OnSubmitted(string value) { }

	// RVA: 0x981F30 Offset: 0x980930 VA: 0x180981F30
	private void OnValueChanged(string value) { }

	// RVA: 0x9820C0 Offset: 0x980AC0 VA: 0x1809820C0
	public void .ctor() { }
}
