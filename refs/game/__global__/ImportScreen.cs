public class ImportScreen : MainMenuScreen // TypeDefIndex: 2935
{
	// Fields
	[Header("References")]
	public GameObject MainContainer; // 0x50
	public GameObject FailContainer; // 0x58
	public Button ConfirmButton; // 0x60
	public TextMeshProUGUI OrganisationNameLabel; // 0x68
	public TextMeshProUGUI NetworthLabel; // 0x70
	public TextMeshProUGUI VersionLabel; // 0x78
	public TextMeshProUGUI WarningLabel; // 0x80
	private int slotToOverwrite; // 0x88
	private SaveInfo saveInfo; // 0x90

	// Methods

	// RVA: 0x95E520 Offset: 0x95CF20 VA: 0x18095E520
	public void Initialize(int _slotToOverwrite, MainMenuScreen previousScreen) { }

	// RVA: 0x95E000 Offset: 0x95CA00 VA: 0x18095E000
	public void Cancel() { }

	// RVA: 0x95E020 Offset: 0x95CA20 VA: 0x18095E020
	public void Confirm() { }

	// RVA: 0x95E3B0 Offset: 0x95CDB0 VA: 0x18095E3B0
	private static void CopyFilesRecursively(string sourcePath, string targetPath) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
