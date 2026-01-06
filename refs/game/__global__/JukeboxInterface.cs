public class JukeboxInterface : MonoBehaviour // TypeDefIndex: 3213
{
	// Fields
	public const float OPEN_TIME = 0.15;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("References")]
	public Jukebox Jukebox; // 0x28
	public Canvas Canvas; // 0x30
	public Transform CameraPosition; // 0x38
	public InteractableObject IntObj; // 0x40
	public Image PausePlayImage; // 0x48
	public Button ShuffleButton; // 0x50
	public Button RepeatButton; // 0x58
	public Button SyncButton; // 0x60
	public RectTransform EntryContainer; // 0x68
	public GameObject AmbientDisplayContainer; // 0x70
	public TextMeshPro AmbientDisplaySongLabel; // 0x78
	public TextMeshPro AmbientDisplayTimeLabel; // 0x80
	[Header("Settings")]
	public Sprite PlaySprite; // 0x88
	public Sprite PauseSprite; // 0x90
	public Sprite SongEntryPlaySprite; // 0x98
	public Sprite SongEntryPauseSprite; // 0xA0
	public Sprite RepeatModeSprite_None; // 0xA8
	public Sprite RepeatModeSprite_Track; // 0xB0
	public Sprite RepeatModeSprite_Queue; // 0xB8
	public Color DeselectedColor; // 0xC0
	public Color SelectedColor; // 0xD0
	public GameObject SongEntryPrefab; // 0xE0
	private List<RectTransform> songEntries; // 0xE8

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x9CC3D0 Offset: 0x9CADD0 VA: 0x1809CC3D0
	private void Awake() { }

	// RVA: 0x9CCA90 Offset: 0x9CB490 VA: 0x1809CCA90
	private void FixedUpdate() { }

	// RVA: 0x9CDC50 Offset: 0x9CC650 VA: 0x1809CDC50
	private void UpdateAmbientDisplay() { }

	// RVA: 0x9CD5A0 Offset: 0x9CBFA0 VA: 0x1809CD5A0
	private void SetupSongEntries() { }

	// RVA: 0x9CDA80 Offset: 0x9CC480 VA: 0x1809CDA80
	public void Start() { }

	// RVA: 0x9CCB40 Offset: 0x9CB540 VA: 0x1809CCB40
	private void OnDestroy() { }

	// RVA: 0x9CCA40 Offset: 0x9CB440 VA: 0x1809CCA40
	private void Exit(ExitAction action) { }

	// RVA: 0x9CCBD0 Offset: 0x9CB5D0 VA: 0x1809CCBD0
	public void Open() { }

	// RVA: 0x9CC750 Offset: 0x9CB150 VA: 0x1809CC750
	public void Close() { }

	// RVA: 0x9CCAA0 Offset: 0x9CB4A0 VA: 0x1809CCAA0
	private void Hovered() { }

	// RVA: 0x9CCB10 Offset: 0x9CB510 VA: 0x1809CCB10
	private void Interacted() { }

	// RVA: 0x9CD000 Offset: 0x9CBA00 VA: 0x1809CD000
	public void PlayPausePressed() { }

	// RVA: 0x9CC690 Offset: 0x9CB090 VA: 0x1809CC690
	public void BackPressed() { }

	// RVA: 0x9CCB20 Offset: 0x9CB520 VA: 0x1809CCB20
	public void NextPressed() { }

	// RVA: 0x9CD990 Offset: 0x9CC390 VA: 0x1809CD990
	public void ShufflePressed() { }

	// RVA: 0x9CD510 Offset: 0x9CBF10 VA: 0x1809CD510
	public void RepeatPressed() { }

	// RVA: 0x9CDBE0 Offset: 0x9CC5E0 VA: 0x1809CDBE0
	public void SyncPressed() { }

	// RVA: 0x9CD9B0 Offset: 0x9CC3B0 VA: 0x1809CD9B0
	public void SongEntryClicked(RectTransform entry) { }

	// RVA: 0x9CD0B0 Offset: 0x9CBAB0 VA: 0x1809CD0B0
	private void RefreshSongEntries() { }

	// RVA: 0x9CD2A0 Offset: 0x9CBCA0 VA: 0x1809CD2A0
	private void RefreshUI() { }

	// RVA: 0x9CD020 Offset: 0x9CBA20 VA: 0x1809CD020
	private void RefreshAmbientDisplay() { }

	// RVA: 0x9CE100 Offset: 0x9CCB00 VA: 0x1809CE100
	public void .ctor() { }
}
