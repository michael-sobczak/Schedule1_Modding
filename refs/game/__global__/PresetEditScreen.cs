public class PresetEditScreen : MonoBehaviour // TypeDefIndex: 1234
{
	// Fields
	public Preset EditedPreset; // 0x20
	[Header("References")]
	public RectTransform IconBackgroundRect; // 0x28
	public Image IconBackground; // 0x30
	public RectTransform InputFieldRect; // 0x38
	public TMP_InputField InputField; // 0x40
	public RectTransform EditButtonRect; // 0x48
	public Button ReturnButton; // 0x50
	public Button DeleteButton; // 0x58

	// Properties
	public bool isOpen { get; }

	// Methods

	// RVA: 0x6208C0 Offset: 0x61F2C0 VA: 0x1806208C0
	public bool get_isOpen() { }

	// RVA: 0x61FD80 Offset: 0x61E780 VA: 0x18061FD80 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x6200F0 Offset: 0x61EAF0 VA: 0x1806200F0
	private void Exit(ExitAction action) { }

	// RVA: 0x620320 Offset: 0x61ED20 VA: 0x180620320 Slot: 5
	public virtual void Open(Preset preset) { }

	// RVA: 0x61FFC0 Offset: 0x61E9C0 VA: 0x18061FFC0
	public void Close() { }

	// RVA: 0x6204B0 Offset: 0x61EEB0 VA: 0x1806204B0
	private void RefreshIcon() { }

	// RVA: 0x620570 Offset: 0x61EF70 VA: 0x180620570
	private void RefreshTransforms() { }

	// RVA: 0x620200 Offset: 0x61EC00 VA: 0x180620200
	private void NameFieldChange(string newVal) { }

	// RVA: 0x620210 Offset: 0x61EC10 VA: 0x180620210
	private void NameFieldDone(string piss) { }

	// RVA: 0x620170 Offset: 0x61EB70 VA: 0x180620170
	private bool IsNameAppropriate(string name) { }

	// RVA: 0x620010 Offset: 0x61EA10 VA: 0x180620010
	public void DeleteButtonClicked() { }

	// RVA: 0x61FFC0 Offset: 0x61E9C0 VA: 0x18061FFC0
	public void ReturnButtonClicked() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(PresetEditScreen.<<Open>g__Delay|13_0>d))]
	// RVA: 0x620850 Offset: 0x61F250 VA: 0x180620850
	private IEnumerator <Open>g__Delay|13_0() { }
}
