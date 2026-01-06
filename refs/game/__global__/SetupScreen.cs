public class SetupScreen : MainMenuScreen // TypeDefIndex: 2947
{
	// Fields
	public const string DEFAULT_SAVE_PATH = "DefaultSave";
	[Header("References")]
	public GameInputField InputField; // 0x50
	public Button StartButton; // 0x58
	public RectTransform SkipIntroContainer; // 0x60
	public Toggle SkipIntroToggle; // 0x68
	public RectTransform NotHostWarning; // 0x70
	private int slotIndex; // 0x78

	// Methods

	// RVA: 0x96D520 Offset: 0x96BF20 VA: 0x18096D520 Slot: 8
	protected virtual void Start() { }

	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	public void Initialize(int index) { }

	// RVA: 0x96D600 Offset: 0x96C000 VA: 0x18096D600
	private void Update() { }

	// RVA: 0x96CF60 Offset: 0x96B960 VA: 0x18096CF60
	public void StartGame() { }

	// RVA: 0x96CF30 Offset: 0x96B930 VA: 0x18096CF30
	private bool IsInputValid() { }

	// RVA: 0x96CAA0 Offset: 0x96B4A0 VA: 0x18096CAA0
	private void ClearFolderContents(string folderPath) { }

	// RVA: 0x96CBC0 Offset: 0x96B5C0 VA: 0x18096CBC0
	private void CopyDefaultSaveToFolder(string folderPath) { }

	// RVA: 0x96CDB0 Offset: 0x96B7B0 VA: 0x18096CDB0
	private static void CopyFilesRecursively(string sourcePath, string targetPath) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x96D5F0 Offset: 0x96BFF0 VA: 0x18096D5F0
	private void <Start>b__7_0(string <p0>) { }
}
