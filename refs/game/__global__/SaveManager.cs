public class SaveManager : PersistentSingleton<SaveManager> // TypeDefIndex: 871
{
	// Fields
	public const string MAIN_SCENE_NAME = "Main";
	public const string MENU_SCENE_NAME = "Menu";
	public const string TUTORIAL_SCENE_NAME = "Tutorial";
	public const int SAVES_PER_FRAME = 15;
	public const string SAVE_FILE_EXTENSION = ".json";
	public const int SAVE_SLOT_COUNT = 5;
	public const string SAVE_GAME_PREFIX = "SaveGame_";
	public const bool DEBUG = False;
	public const bool PRETTY_PRINT = True;
	public static bool SaveError; // 0x0
	[CompilerGenerated]
	private bool <AccessPermissionIssueDetected>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsSaving>k__BackingField; // 0x29
	[CompilerGenerated]
	private float <SecondsSinceLastSave>k__BackingField; // 0x2C
	[CompilerGenerated]
	private string <PlayersSavePath>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <IndividualSavesContainerPath>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <SaveName>k__BackingField; // 0x40
	public List<ISaveable> Saveables; // 0x48
	public List<IBaseSaveable> BaseSaveables; // 0x50
	[HideInInspector]
	public List<string> ApprovedBaseLevelPaths; // 0x58
	protected List<ISaveable> CompletedSaveables; // 0x60
	protected List<SaveRequest> QueuedSaveRequests; // 0x68
	[Header("References")]
	public RectTransform WriteIssueDisplay; // 0x70
	[Header("Events")]
	public UnityEvent onSaveStart; // 0x78
	public UnityEvent onSaveComplete; // 0x80
	private bool saveFolderInitialized; // 0x88

	// Properties
	public bool AccessPermissionIssueDetected { get; set; }
	public bool IsSaving { get; set; }
	public float SecondsSinceLastSave { get; set; }
	public string PlayersSavePath { get; set; }
	public string IndividualSavesContainerPath { get; set; }
	public string BackupFolderPath { get; }
	public string SaveName { get; set; }

	// Methods

	// RVA: 0x5C9520 Offset: 0x5C7F20 VA: 0x1805C9520
	public static void ReportSaveError() { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_AccessPermissionIssueDetected() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_AccessPermissionIssueDetected(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_IsSaving() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	protected void set_IsSaving(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_SecondsSinceLastSave() { }

	[CompilerGenerated]
	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	protected void set_SecondsSinceLastSave(float value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_PlayersSavePath() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_PlayersSavePath(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_IndividualSavesContainerPath() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_IndividualSavesContainerPath(string value) { }

	// RVA: 0x5CA040 Offset: 0x5C8A40 VA: 0x1805CA040
	public string get_BackupFolderPath() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_SaveName() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_SaveName(string value) { }

	// RVA: 0x5C7C80 Offset: 0x5C6680 VA: 0x1805C7C80 Slot: 5
	protected override void Awake() { }

	// RVA: 0x5C9AD0 Offset: 0x5C84D0 VA: 0x1805C9AD0 Slot: 4
	protected override void Start() { }

	// RVA: 0x5C7F50 Offset: 0x5C6950 VA: 0x1805C7F50
	public void CheckSaveFolderInitialized() { }

	// RVA: 0x5C91A0 Offset: 0x5C7BA0 VA: 0x1805C91A0
	public static bool HasWritePermissionOnDir(string path) { }

	// RVA: 0x5C9C50 Offset: 0x5C8650 VA: 0x1805C9C50
	private void Update() { }

	// RVA: 0x5C8D40 Offset: 0x5C7740 VA: 0x1805C8D40
	public void DelayedSave() { }

	// RVA: 0x5C9620 Offset: 0x5C8020 VA: 0x1805C9620
	public void Save() { }

	// RVA: 0x5C96B0 Offset: 0x5C80B0 VA: 0x1805C96B0
	public void Save(string saveFolderPath) { }

	// RVA: 0x5C82E0 Offset: 0x5C6CE0 VA: 0x1805C82E0
	private void ClearBaseLevelOutdatedSaves(string saveFolderPath) { }

	// RVA: 0x5C8820 Offset: 0x5C7220 VA: 0x1805C8820
	public void CompleteSaveable(ISaveable saveable) { }

	// RVA: 0x5C87C0 Offset: 0x5C71C0 VA: 0x1805C87C0
	public void ClearCompletedSaveable(ISaveable saveable) { }

	// RVA: 0x5C88F0 Offset: 0x5C72F0 VA: 0x1805C88F0
	public void CreateSaveBackup(SaveInfo saveInfo) { }

	// RVA: 0x5C93D0 Offset: 0x5C7DD0 VA: 0x1805C93D0
	public void RegisterSaveable(ISaveable saveable) { }

	// RVA: 0x5C9320 Offset: 0x5C7D20 VA: 0x1805C9320
	public void QueueSaveRequest(SaveRequest request) { }

	// RVA: 0x5C8D90 Offset: 0x5C7790 VA: 0x1805C8D90
	public void DequeueSaveRequest(SaveRequest request) { }

	// RVA: 0x5C9BE0 Offset: 0x5C85E0 VA: 0x1805C9BE0
	public static string StripExtensions(string filePath) { }

	// RVA: 0x5C9260 Offset: 0x5C7C60 VA: 0x1805C9260
	public static string MakeFileSafe(string fileName) { }

	// RVA: 0x5C8FE0 Offset: 0x5C79E0 VA: 0x1805C8FE0
	public static float GetVersionNumber(string version) { }

	// RVA: 0x5C8240 Offset: 0x5C6C40 VA: 0x1805C8240
	private void Clean() { }

	// RVA: 0x5C8DF0 Offset: 0x5C77F0 VA: 0x1805C8DF0
	public void DisablePlayTutorial(SaveInfo info) { }

	// RVA: 0x5C9560 Offset: 0x5C7F60 VA: 0x1805C9560
	public static string SanitizeFileName(string fileName) { }

	// RVA: 0x5C9E40 Offset: 0x5C8840 VA: 0x1805C9E40
	public void .ctor() { }
}
