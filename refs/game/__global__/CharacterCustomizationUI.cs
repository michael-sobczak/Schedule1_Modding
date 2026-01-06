public class CharacterCustomizationUI : MonoBehaviour // TypeDefIndex: 2973
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[CompilerGenerated]
	private CharacterCustomizationCategory <ActiveCategory>k__BackingField; // 0x28
	[Header("Settings")]
	public string Title; // 0x30
	public CharacterCustomizationCategory[] Categories; // 0x38
	public bool LoadAvatarSettingsNaked; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x48
	public RectTransform MainContainer; // 0x50
	public RectTransform MenuContainer; // 0x58
	public TextMeshProUGUI TitleText; // 0x60
	public RectTransform ButtonContainer; // 0x68
	public Button ExitButton; // 0x70
	public Slider RigRotationSlider; // 0x78
	public RectTransform PreviewIndicator; // 0x80
	public CharacterCustomizationShop CharacterCustomizationShop; // 0x88
	[Header("Prefab")]
	public Button CategoryButtonPrefab; // 0x90
	private float rigTargetY; // 0x98
	private Coroutine openCloseRoutine; // 0xA0
	protected BasicAvatarSettings currentSettings; // 0xA8

	// Properties
	public bool IsOpen { get; set; }
	public CharacterCustomizationCategory ActiveCategory { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public CharacterCustomizationCategory get_ActiveCategory() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ActiveCategory(CharacterCustomizationCategory value) { }

	// RVA: 0x97A210 Offset: 0x978C10 VA: 0x18097A210
	private void OnValidate() { }

	// RVA: 0x979B20 Offset: 0x978520 VA: 0x180979B20
	private void Awake() { }

	// RVA: 0x97A930 Offset: 0x979330 VA: 0x18097A930 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x97A670 Offset: 0x979070 VA: 0x18097A670
	public void SetActiveCategory(CharacterCustomizationCategory category) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 5
	public virtual bool IsOptionCurrentlyApplied(CharacterCustomizationOption option) { }

	// RVA: 0x97A620 Offset: 0x979020 VA: 0x18097A620 Slot: 6
	public virtual void OptionSelected(CharacterCustomizationOption option) { }

	// RVA: 0x97A560 Offset: 0x978F60 VA: 0x18097A560 Slot: 7
	public virtual void OptionDeselected(CharacterCustomizationOption option) { }

	// RVA: 0x97A5E0 Offset: 0x978FE0 VA: 0x18097A5E0 Slot: 8
	public virtual void OptionPurchased(CharacterCustomizationOption option) { }

	// RVA: 0x97A290 Offset: 0x978C90 VA: 0x18097A290 Slot: 9
	public virtual void Open() { }

	// RVA: 0x97A090 Offset: 0x978A90 VA: 0x18097A090
	private void Exit(ExitAction action) { }

	// RVA: 0x979F40 Offset: 0x978940 VA: 0x180979F40 Slot: 10
	protected virtual void Close() { }

	// RVA: 0x97AA30 Offset: 0x979430 VA: 0x18097AA30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x97A830 Offset: 0x979230 VA: 0x18097A830
	private void <Awake>b__25_0(float value) { }

	[IteratorStateMachine(typeof(CharacterCustomizationUI.<<Open>g__Close|32_0>d))]
	[CompilerGenerated]
	// RVA: 0x97A8C0 Offset: 0x9792C0 VA: 0x18097A8C0
	private IEnumerator <Open>g__Close|32_0() { }

	[IteratorStateMachine(typeof(CharacterCustomizationUI.<<Close>g__Close|34_0>d))]
	[CompilerGenerated]
	// RVA: 0x97A850 Offset: 0x979250 VA: 0x18097A850
	private IEnumerator <Close>g__Close|34_0() { }
}
