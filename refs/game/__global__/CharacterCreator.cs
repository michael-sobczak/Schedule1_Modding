public class CharacterCreator : Singleton<CharacterCreator> // TypeDefIndex: 3180
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	public List<BaseCharacterCreatorField> Fields; // 0x30
	[CompilerGenerated]
	private BasicAvatarSettings <ActiveSettings>k__BackingField; // 0x38
	[Header("References")]
	public Transform Container; // 0x40
	public Transform CameraPosition; // 0x48
	public Transform RigContainer; // 0x50
	public Avatar Rig; // 0x58
	public Canvas Canvas; // 0x60
	public Animation CanvasAnimation; // 0x68
	[Header("Settings")]
	public bool DemoCreator; // 0x70
	public BasicAvatarSettings DefaultSettings; // 0x78
	public List<BasicAvatarSettings> Presets; // 0x80
	public UnityEvent<BasicAvatarSettings> onComplete; // 0x88
	public UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing; // 0x90
	private Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions; // 0x98
	private float rigTargetY; // 0xA0

	// Properties
	public bool IsOpen { get; set; }
	public BasicAvatarSettings ActiveSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public BasicAvatarSettings get_ActiveSettings() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_ActiveSettings(BasicAvatarSettings value) { }

	// RVA: 0x9B6590 Offset: 0x9B4F90 VA: 0x1809B6590 Slot: 5
	protected override void Awake() { }

	// RVA: 0x9B7600 Offset: 0x9B6000 VA: 0x1809B7600 Slot: 4
	protected override void Start() { }

	// RVA: 0x9B76E0 Offset: 0x9B60E0 VA: 0x1809B76E0
	private void Update() { }

	// RVA: 0x9B6A90 Offset: 0x9B5490 VA: 0x1809B6A90
	public void Open(BasicAvatarSettings initialSettings, bool showUI = True) { }

	// RVA: 0x9B74B0 Offset: 0x9B5EB0 VA: 0x1809B74B0
	public void ShowUI() { }

	// RVA: 0x9B6650 Offset: 0x9B5050 VA: 0x1809B6650
	public void Close() { }

	// RVA: 0x8E72B0 Offset: 0x8E5CB0 VA: 0x1808E72B0
	public void DisableStuff() { }

	// RVA: 0x9B66D0 Offset: 0x9B50D0 VA: 0x1809B66D0
	public void Done() { }

	// RVA: 0x9B75E0 Offset: 0x9B5FE0 VA: 0x1809B75E0
	public void SliderChanged(float newVal) { }

	// RVA: -1 Offset: -1
	public T SetValue<T>(string fieldName, T value, ClothingDefinition definition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5F6E0 Offset: 0xE5E0E0 VA: 0x180E5F6E0
	|-CharacterCreator.SetValue<Color>
	|
	|-RVA: 0xE5FB80 Offset: 0xE5E580 VA: 0x180E5FB80
	|-CharacterCreator.SetValue<int>
	|
	|-RVA: 0xE5FD50 Offset: 0xE5E750 VA: 0x180E5FD50
	|-CharacterCreator.SetValue<object>
	|
	|-RVA: 0xE5FEC0 Offset: 0xE5E8C0 VA: 0x180E5FEC0
	|-CharacterCreator.SetValue<float>
	|
	|-RVA: 0xE5F8C0 Offset: 0xE5E2C0 VA: 0x180E5F8C0
	|-CharacterCreator.SetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x9B7250 Offset: 0x9B5C50 VA: 0x1809B7250
	public void SelectPreset(string presetName) { }

	// RVA: 0x9B70A0 Offset: 0x9B5AA0 VA: 0x1809B70A0
	public void RefreshCategory(CharacterCreator.ECategory category) { }

	// RVA: 0x9B77C0 Offset: 0x9B61C0 VA: 0x1809B77C0
	public void .ctor() { }

	[IteratorStateMachine(typeof(CharacterCreator.<<Close>g__Close|28_0>d))]
	[CompilerGenerated]
	// RVA: 0x9B7670 Offset: 0x9B6070 VA: 0x1809B7670
	private IEnumerator <Close>g__Close|28_0() { }
}
