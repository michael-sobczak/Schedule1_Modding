public class TVInterface : MonoBehaviour // TypeDefIndex: 637
{
	// Fields
	public const float OPEN_TIME = 0.15;
	public const float FOV = 60;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	public List<Player> Players; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public Transform CameraPosition; // 0x38
	public TVHomeScreen HomeScreen; // 0x40
	public TextMeshPro TimeLabel; // 0x48
	public TextMeshPro Daylabel; // 0x50
	public UnityEvent<Player> onPlayerAdded; // 0x58
	public UnityEvent<Player> onPlayerRemoved; // 0x60

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0xAA86D0 Offset: 0xAA70D0 VA: 0x180AA86D0
	public void Awake() { }

	// RVA: 0xAA9560 Offset: 0xAA7F60 VA: 0x180AA9560
	public void Start() { }

	// RVA: 0xAA8E10 Offset: 0xAA7810 VA: 0x180AA8E10
	private void OnDestroy() { }

	// RVA: 0xAA8C90 Offset: 0xAA7690 VA: 0x180AA8C90
	private void MinPass() { }

	// RVA: 0xAA8F30 Offset: 0xAA7930 VA: 0x180AA8F30
	public void Open() { }

	// RVA: 0xAA8800 Offset: 0xAA7200 VA: 0x180AA8800
	public void Close() { }

	// RVA: 0xAA8C40 Offset: 0xAA7640 VA: 0x180AA8C40
	private void Exit(ExitAction action) { }

	// RVA: 0xAA87F0 Offset: 0xAA71F0 VA: 0x180AA87F0
	public bool CanOpen() { }

	// RVA: 0xAA85D0 Offset: 0xAA6FD0 VA: 0x180AA85D0
	public void AddPlayer(Player player) { }

	// RVA: 0xAA94B0 Offset: 0xAA7EB0 VA: 0x180AA94B0
	public void RemovePlayer(Player player) { }

	// RVA: 0xAA9600 Offset: 0xAA8000 VA: 0x180AA9600
	public void .ctor() { }
}
